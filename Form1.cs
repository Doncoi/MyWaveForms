using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;
using MyWaveForms.Entity;
using MyWaveForms.Controller;
using ScottPlot.Plottable;
using MyWaveForms.Test;
using MyWaveForms.Generator;
using System.Diagnostics;
using System.Linq;

namespace MyWaveForms
{
	public partial class Form1 : Form
	{
		//跨线程操作会引起异常，接收数据是新开线程，窗口的接受文本在主线程
		//两个解决方案任选其一
		//解决方案一：新建委托来显示接受内容
		//protected delegate void UpdateDisplayDelegate(string text, TextBox textBox);

		#region 全局变量
		/*
		公用
		*/
		private Boolean isInit = false;                         //IndexChange事件屏蔽标记
		private WaveformDataGenerator waveformDataGenerator;            //数据生成器
		private ChartTester tester;                                     //图表测试器                                             
		private SerialPortController serialPortController;              //串口助手控制器
		/*
		设备管理部分
		*/
		private DeviceController deviceController;
		/*
		示波器部分
		*/
		private Stopwatch stopwatch;
		private SignalPlotXY signalPlotXYScope;                 //信号图对象
		private ScopeChartController scopeChartController;        //图表控制器
		private Crosshair crosshair;                            //鼠标随动十字光标线
		/*
		信号发生器部分
		*/                                                    
		const int PlotSize = 1000;                              //预览图表点数
		private WavegenChartController wavegenChartController;  //图表控制器
		private SignalPlotXY signalPlotXYWaveGen;               //信号图对象
		/*
		电压电流计
		*/
		private TracerController meterTracerController;
		private SignalPlotXY signalPlotXYMeter;                 //信号图对象
		/*
		频谱分析仪
		*/
		private TracerController spectrumTracerController;        //Tracer控制器
		private SpectrumChartController spectrumChartController;	//图表控制器
		private SignalPlotXY signalPlotXYSpectrum;                 //信号图对象
		#endregion

		public Form1()
		{
			this.Width = 1760;
			this.Height = 1200;
			InitializeComponent();
			//解决方案二：取消跨线程检查
			//Control.CheckForIllegalCrossThreadCalls = false;
			/*
			公用
			*/
			serialPortController = new SerialPortController();
			scopeChartController = new ScopeChartController(this.formsPlotScope);
			waveformDataGenerator = new WaveformDataGenerator();
			/*
			设备管理部分
			 */
			deviceController = new DeviceController(this.serialPortController);
			/*
			示波器部分
			*/
			stopwatch = new Stopwatch();
			tester = new ChartTester(this.formsPlotScope);
			signalPlotXYScope = new SignalPlotXY();
			/*
			信号发生器部分
			*/
			wavegenChartController = new WavegenChartController();
			signalPlotXYWaveGen = new SignalPlotXY();
			/*
			电压电流计
			*/
			meterTracerController = new TracerController(panelMeter, formsPlotMeter, 0, 6, 198, 100, 0, 0);
			signalPlotXYMeter = new SignalPlotXY();
			/*
			频谱分析仪
			*/
			spectrumTracerController = new TracerController(panelSpectrum, formsPlotSpectrum, 1, 10, 198, 100, 0, 260 + 10);
			spectrumChartController = new SpectrumChartController();
			signalPlotXYSpectrum = new SignalPlotXY();
		}

		#region 串口助手部分
		#region 初始化
		private void InitUARTAsssist()
		{
			//serialPort1 = new SerialPort();
			//serialPort1.Encoding = Encoding.GetEncoding("GBK2312");    //串口编码引入GBK2312
			serialPortController.ReflashPortToComboBox(serialPort1, comboBoxPort);    //启动时扫描可用串口

			buttonClosePort.Enabled = false;    //禁用关闭串口按钮
			buttonSend.Enabled = false;     //禁用发送按钮
			comboBoxBaudRate.SelectedIndex = 3;     //波特率默认设置
			comboBoxDataBit.SelectedIndex = 1;     //数据位默认设置
			comboBoxCheckBit.SelectedIndex = 0;     //校验位默认设置
			comboBoxStopBit.SelectedIndex = 0;     //停止位默认设置
		}

		private void tabPageAUARTAssist_Enter(object sender, EventArgs e)
		{
			serialPortController = new SerialPortController(); 
			InitUARTAsssist();
		}
		#endregion
		#region 控件禁用/启用
		//禁用串口设置的相关ComboBox
		private void DisablePortSettingComboBox()
		{
			comboBoxBaudRate.Enabled = false;
			comboBoxPort.Enabled = false;
			comboBoxDataBit.Enabled = false;
			comboBoxCheckBit.Enabled = false;
			comboBoxStopBit.Enabled = false;
		}

		//启用串口设置的相关ComboBox
		private void EnablePortSettingComboBox()
		{
			comboBoxBaudRate.Enabled = true;
			comboBoxPort.Enabled = true;
			comboBoxDataBit.Enabled = true;
			comboBoxCheckBit.Enabled = true;
			comboBoxStopBit.Enabled = true;
		}

		//串口打开状态，禁用开启串口按钮
		private void DisableOpenPortButton()
		{
			buttonSend.Enabled = true;      //启用发送按钮
			buttonClosePort.Enabled = true;    //启用关闭串口按钮
			buttonOpenPort.Enabled = false;    //禁用开启串口按钮
		}

		//串口关闭状态，启用开启串口按钮
		private void EnableOpenPortButton()
		{
			buttonSend.Enabled = false;      //禁用发送按钮
			buttonClosePort.Enabled = false;    //禁用关闭串口按钮
			buttonOpenPort.Enabled = true;    //启用开启串口按钮
		}
		#endregion
		#region 串口设置
		//端口号lable点击事件，刷新端口
		private void labelPortNumber_Click(object sender, EventArgs e)
		{
			serialPortController.ReflashPortToComboBox(serialPort1, comboBoxPort);
		}

		//打开串口按钮点击事件
		private void buttonOpenPort_Click(object sender, EventArgs e)
		{
			if (comboBoxPort.SelectedItem == null)
			{
				MessageBox.Show("没有选择串口！");
			}
			if (comboBoxBaudRate.SelectedItem == null)
			{
				MessageBox.Show("没有选择波特率！");
			}
			//获取ComboBox数据
			SerialPortConfig portConfig = new SerialPortConfig(
				comboBoxPort.SelectedItem.ToString(),
				comboBoxBaudRate.SelectedItem.ToString(),
				comboBoxDataBit.SelectedItem.ToString(),
				comboBoxCheckBit.SelectedItem.ToString(),
				comboBoxStopBit.SelectedItem.ToString());
			//打开串口
			bool res = serialPortController.OpenPort(serialPort1, portConfig);
			DisablePortSettingComboBox();   //禁用串口设置的相关ComboBox
			DisableOpenPortButton();    //禁用开启串口按钮
		}

		//关闭串口按钮点击事件
		private void buttonClosePort_Click(object sender, EventArgs e)
		{
			serialPortController.ClosePort(serialPort1);
			EnablePortSettingComboBox();
			EnableOpenPortButton();
		}
		#endregion
		#region 接收/发送设置
		//清空接受窗按钮点击事件
		private void buttonClearReceived_Click(object sender, EventArgs e)
		{
			textBoxReceived.Clear();
		}

		//清空发送窗按钮点击事件
		private void buttonClearSent_Click(object sender, EventArgs e)
		{
			textBoxSend.Clear();
		}

		//屏蔽接收信息复选框状态变化时，丢弃接收缓冲区数据
		private void checkBoxReceivedBlock_CheckedChanged(object sender, EventArgs e)
		{
			serialPort1.DiscardInBuffer();      //丢弃接收缓冲区数据
		}
		#endregion
		#region 接收/发送
		//串口数据接收事件
		private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
		{
			try
			{
				//如果激活屏蔽接收，则不显示接收数据
				if (true == checkBoxReceivedBlock.Checked)
					return;
				//获取接收模式
				byte bCommuFormat;
				if (radioButtonReceiveASCII.Checked == true) bCommuFormat = 0;
				else if (radioButtonReceiveHEX.Checked == true) bCommuFormat = 1;
				else bCommuFormat = 2;
				//获取接收到的字符串
				string strReceivedContent = serialPortController.GetReceivedString(serialPort1,bCommuFormat);
				//添加时间戳并显示
				textBoxReceived.AppendText(serialPortController.AppendTimestamp(strReceivedContent, false, bCommuFormat));
				/*Invoke(new UpdateDisplayDelegate(UpdateDisplayToTexxBox),
						new object[] { strReceivedContent, textBoxReceived });*/
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message, "接收数据异常提示");
			}
		}

		//发送数据按钮点击事件
		private void buttonSend_Click(object sender, EventArgs e)
		{
			if (serialPort1.IsOpen)    //如果串口已经打开
			{
				if (textBoxSend.Text != "")    //如果发送窗有数据
				{
					try
					{
						//获取发送格式
						byte bCommuFormat;
						if (radioButtonSendASCII.Checked == true) bCommuFormat = 0;
						else bCommuFormat = 1;
						//获取发送区文本
						string strSendContent = textBoxSend.Text;    
						//串口发送
						serialPortController.SerialPortSend(serialPort1, strSendContent, bCommuFormat);
						//添加日志
						textBoxReceived.AppendText(serialPortController.AppendTimestamp(strSendContent, true, bCommuFormat));    
					}
					catch (System.Exception ex)
					{
						serialPort1.Close();    //关闭串口
						EnablePortSettingComboBox();
						EnableOpenPortButton();
						MessageBox.Show(ex.Message, "串口数据写入错误");
					}
				}
			}
		}
		#endregion
		#endregion

		#region 设备管理部分
		#region 表格视图管理
		/// <summary>
		/// 向可用设备列表添加新的信息
		/// </summary>
		/// <param name="dataGridView"></param>
		/// <param name="deviceConfig"></param>
		private void AddRowToDeviceInforList(DataGridView dataGridView, DeviceConfig deviceConfig)
		{
			int index = this.dataGridViewDeviceInfor.Rows.Add();
			this.dataGridViewDeviceInfor.Rows[index].Cells[0].Value = deviceConfig.SPortNumber;
			this.dataGridViewDeviceInfor.Rows[index].Cells[1].Value = deviceConfig.SDeviceName;
			this.dataGridViewDeviceInfor.Rows[index].Cells[2].Value = deviceConfig.SDeviceNumber;
			this.dataGridViewDeviceInfor.Rows[index].Cells[3].Value = "Ready";
		}

		/// <summary>
		/// 清空列表
		/// </summary>
		/// <param name="dataGridView"></param>
		private void ClearDeviceInforList(DataGridView dataGridView)
		{
			dataGridView.Rows.Clear();
		}

		/// <summary>
		/// 获取选中设备
		/// </summary>
		/// <returns></returns>
		private DeviceConfig GetSelectedDeviceConfig()
		{
			DataGridViewRow row = this.dataGridViewDeviceInfor.CurrentRow;
			string sPortNumber = row.Cells[0].Value.ToString();
			string sDeviceName = row.Cells[1].Value.ToString();
			string sDeviceNumber = row.Cells[2].Value.ToString();
			return new DeviceConfig(sPortNumber, sDeviceName, sDeviceNumber, new SerialPortConfig());
		}
		#endregion
		#region 响应事件
		/// <summary>
		/// 进入设备管理页事件
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tabPageDeviceManage_Enter(object sender, EventArgs e)
		{
			// 添加测试数据
			this.AddRowToDeviceInforList(
				this.dataGridViewDeviceInfor,
				new DeviceConfig("COM15", "MSP4305529F", "t0001", new SerialPortConfig()));
		}

		/// <summary>
		/// 连接设备按钮响应事件
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonConnect_Click(object sender, EventArgs e)
		{
			// 如果当前按钮功能为连接
			if (this.checkBoxConnected.Checked == false)
			{
				//this.checkBoxConnected.Checked = this.deviceController.ConnectWithDevice(serialPort1, new SerialPortConfig());
				this.checkBoxConnected.Checked = true;
			}
			else    
			{
				//this.checkBoxConnected.Checked = this.deviceController.DisconnectWithDevice(serialPort1);
				this.checkBoxConnected.Checked = false;
			}
			// 设备连接成功
			if (this.checkBoxConnected.Checked == true)
			{
				buttonConnect.Text = "断开";		//显示为断开
				buttonRefresh.Enabled = false;      //禁止刷新
				labelConnectState.Text = "已连接 " + GetSelectedDeviceConfig().SDeviceName;		//更新连接状态
			}
			else
			{
				buttonConnect.Text = "连接";      //显示为断开
				buttonRefresh.Enabled = true;      //禁止刷新
				labelConnectState.Text = "未连接";
			}
		}
		#endregion
		#endregion

		#region 示波器部分
		#region 控件初始化
		//初始化控件
		private void InitScopeWidget()
		{
			if(scopeChartController == null)	//实例化图表控制器
				scopeChartController = new ScopeChartController(this.formsPlotScope);
			//if (scopeChartTester == null)   //实例化测试控制器
				//scopeChartTester = new ChartTester(formsPlotScope);

			isInit = true;      //打开屏蔽标记
			//显示区控件初始化
			toolStripComboBoxColorStyle.SelectedIndex = 0;    //浅色
			toolStripComboBoxLineStyle.SelectedIndex = 0;    //折线
			toolStripComboBoxLineWidth.SelectedIndex = 0;     //线宽：1
			//控制区控件初始化
			comboBoxCoupledType.SelectedIndex = 0;      //DC
			comboBoxTriggerType.SelectedIndex = 0;      //同时触发
			comboBoxVerticalSensitivity.SelectedIndex = 2;      //0.1V
			comboBoxTimeBase.SelectedIndex = 15;     //100ms
			//信息区初始化
			labelDisplayPlotCount.Text = "1000";
			labelDisplayFrequency.Text = "50MHz";
			isInit = false;     //关闭屏蔽标记

			//无数据初始化图表
			ValueTuple<SignalPlotXY, Crosshair> vt = scopeChartController.InitScopeChart(
				toolStripComboBoxColorStyle.SelectedIndex,								//获取色彩模式
				Double.Parse(toolStripComboBoxLineWidth.SelectedItem.ToString()),		//获取线宽
				toolStripComboBoxLineStyle.SelectedIndex);								//获取连线样式
			this.signalPlotXYScope = vt.Item1;
			this.crosshair = vt.Item2;

			// 翻转刻度线方向
			formsPlotScope.Plot.XAxis.TickMarkDirection(outward: false);
			formsPlotScope.Plot.YAxis.TickMarkDirection(outward: false);

			// 调整刻度
			ScopeConfig scopeConfig = new ScopeConfig(GetScopeConfigSelectedList());
			double dVerticalSensitivity = scopeConfig.DVerticalSensitivity;     //获取垂直灵敏度
			scopeChartController.SetVerticalAxis(dVerticalSensitivity);     // 更改图表纵轴刻度
			double dTimeBaseValue = scopeConfig.DTimeBaseValue;     //获取时基
			string sTimeBaseUnit = scopeConfig.strTimeBaseUnit[scopeConfig.BTimeBaseUnit];      //获取时基单位
			scopeChartController.SetTimeBaseAxis(dTimeBaseValue, sTimeBaseUnit); // 更改图表横轴刻度

		}

		private void tabPageScope_Enter(object sender, EventArgs e)
		{
			InitScopeWidget();
		}
		#endregion
		#region 工具栏响应事件
		/// <summary>
		/// 运行示波器响应按钮
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void toolStripButtonRunScope_Click(object sender, EventArgs e)
		{
			// todo 启动示波器
		}

		#region 示波器图表显示设置 已完成，不要动
		//变更图表色彩模式
		private void toolStripComboBoxColorStyle_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (isInit) return;     //如果正在初始化,则屏蔽更改事件
				int colorStyle = toolStripComboBoxColorStyle.SelectedIndex;      //获取色彩模式
				scopeChartController.SetPlotColorStyle(this.formsPlotScope, this.signalPlotXYScope, colorStyle);     //变更色彩模式
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// 变更图表线条样式
		private void toolStripComboBoxLineStyle_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (isInit) return;     //如果正在初始化,则屏蔽更改事件
				int iLineStyle = toolStripComboBoxLineStyle.SelectedIndex;       //获取连线样式
				scopeChartController.SetLineStyle(this.formsPlotScope, this.signalPlotXYScope, iLineStyle);
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// 变更图表线条粗细
		private void toolStripComboBoxLineWidth_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (isInit) return;     //如果正在初始化,则屏蔽更改事件
				double dLineWidth = Double.Parse(toolStripComboBoxLineWidth.SelectedItem.ToString());    //获取线宽
				scopeChartController.SetLineWidth(this.formsPlotScope, this.signalPlotXYScope, dLineWidth);
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		#endregion
		#region 示波器图表交互设置 已完成，不要动
		//鼠标右键拖拽缩放
		private void toolStripMenuItemRightClickDragZoom_Click(object sender, EventArgs e)
		{
			this.toolStripMenuItemRightClickDragZoom.Checked =
				!this.toolStripMenuItemRightClickDragZoom.Checked;
			this.formsPlotScope.Configuration.RightClickDragZoom =
				this.toolStripMenuItemRightClickDragZoom.Checked;
		}

		//鼠标滚轮缩放

		private void toolStripMenuItemScrollWheelZoom_Click(object sender, EventArgs e)
		{
			this.toolStripMenuItemScrollWheelZoom.Checked =
				!this.toolStripMenuItemScrollWheelZoom.Checked;
			this.formsPlotScope.Configuration.ScrollWheelZoom =
				this.toolStripMenuItemScrollWheelZoom.Checked;
		}

		//启用/禁用水平缩放
		private void toolStripMenuItemHorizontalZoom_Click(object sender, EventArgs e)
		{
			this.toolStripMenuItemHorizontalZoom.Checked =
				!this.toolStripMenuItemHorizontalZoom.Checked;
			this.formsPlotScope.Configuration.LockHorizontalAxis =
				!this.toolStripMenuItemHorizontalZoom.Checked;
		}

		//启用/禁用垂直缩放
		private void toolStripMenuItemVerticalZoom_Click(object sender, EventArgs e)
		{
			this.toolStripMenuItemVerticalZoom.Checked =
				!this.toolStripMenuItemVerticalZoom.Checked;
			this.formsPlotScope.Configuration.LockVerticalAxis =
				!this.toolStripMenuItemVerticalZoom.Checked;
		}

		//启用/禁用十字准线
		private void toolStripMenuItemCrosshair_Click(object sender, EventArgs e)
		{
			this.toolStripMenuItemCrosshair.Checked =
				!this.toolStripMenuItemCrosshair.Checked;
			try
			{
				if (toolStripMenuItemCrosshair.Checked)
				{
					this.crosshair.VerticalLine.IsVisible = true;
					this.crosshair.HorizontalLine.IsVisible = true;
				}
				else
				{
					this.crosshair.VerticalLine.IsVisible = false;
					this.crosshair.HorizontalLine.IsVisible = false;
				}
				this.formsPlotScope.Refresh(true, true);
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		//鼠标移动时处理十字光标
		private void formsPlotMain_MouseMove(object sender, MouseEventArgs e)
		{
			if (toolStripMenuItemCrosshair.Checked == false) return;      //如果不需要绘制十字准线，直接返回
																		  //获取鼠标位置
			ValueTuple<double, double> mouseCoordinates = this.formsPlotScope.GetMouseCoordinates();
			double coordinateX = mouseCoordinates.Item1;
			double coordinateY = mouseCoordinates.Item2;
			//移动十字准线
			this.crosshair.X = coordinateX;
			this.crosshair.Y = coordinateY;

			//RefreshPlot(formsPlotScope, true, true);
			this.formsPlotScope.Refresh(true, true);
		}

		//鼠标进入图表中执行的任务
		private void formsPlotMain_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				if (toolStripMenuItemCrosshair.Checked == false) return;      //如果不需要绘制十字准线，直接返回
				if (toolStripMenuItemCrosshair.Checked)     //如果需要显示十字准线
				{
					//this.crosshair.IsVisible = true;
					this.crosshair.VerticalLine.IsVisible = true;   //设为可见
					this.crosshair.HorizontalLine.IsVisible = true;
				}
				/*
				else      //如果不需要显示十字准线
				{
					//this.crosshair.IsVisible = false;
					this.crosshair.VerticalLine.IsVisible = false;		//设为不可见
					this.crosshair.HorizontalLine.IsVisible = false;
				}
				*/

				this.formsPlotScope.Refresh();
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		//鼠标离开图表执行的任务
		private void formsPlotMain_MouseLeave(object sender, EventArgs e)
		{
			//Console.WriteLine(new StackTrace(new StackFrame(true)).GetFrame(0));
			try
			{
				//if (null == this.crosshair) return;
				this.crosshair.VerticalLine.IsVisible = false;
				this.crosshair.HorizontalLine.IsVisible = false;
				this.formsPlotScope.Refresh();
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		#endregion
		#endregion
		#region 控制区响应事件
		/// <summary>
		/// 耦合方式更改响应事件
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void comboBoxCoupledType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (isInit == true) return;		//屏蔽初始化动作
			ScopeConfig scopeConfig = new ScopeConfig(GetScopeConfigSelectedList());
			this.textBoxScopeTest.Text = scopeConfig.ToString();	//在测试区显示配置
			// todo 向下位机发送配置
		}

		/// <summary>
		/// 触发方式更改响应事件
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void comboBoxTriggerType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (isInit == true) return;     //屏蔽初始化动作
			ScopeConfig scopeConfig = new ScopeConfig(GetScopeConfigSelectedList());
			this.textBoxScopeTest.Text = scopeConfig.ToString();     //在测试区显示配置
			// todo 向下位机发送配置
		}

		/// <summary>
		/// 垂直灵敏度更改响应事件
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void comboBoxVerticalSensitivity_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (isInit == true) return;     //屏蔽初始化动作
			ScopeConfig scopeConfig = new ScopeConfig(GetScopeConfigSelectedList());
			this.textBoxScopeTest.Text = scopeConfig.ToString();     //在测试区显示配置
			// 更改图表纵轴刻度
			double dVerticalSensitivity = scopeConfig.DVerticalSensitivity;     //获取垂直灵敏度
			scopeChartController.SetVerticalAxis(dVerticalSensitivity);
			// todo 向下位机发送配置
		}

		/// <summary>
		/// 时基更改响应事件
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void comboBoxTimeBase_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (isInit == true) return;     //屏蔽初始化动作
			ScopeConfig scopeConfig = new ScopeConfig(GetScopeConfigSelectedList());
			this.textBoxScopeTest.Text = scopeConfig.ToString();     //在测试区显示配置
			// 更改图表横轴刻度
			double dTimeBaseValue = scopeConfig.DTimeBaseValue;     //获取时基
			string sTimeBaseUnit = scopeConfig.strTimeBaseUnit[scopeConfig.BTimeBaseUnit];      //获取时基单位
			scopeChartController.SetTimeBaseAxis(dTimeBaseValue, sTimeBaseUnit);
			// todo 向下位机发送配置
		}
		#endregion
		#region 信息区 to-do
		#endregion
		#endregion

		#region 信号发生器部分
		#region 控件初始化
		//初始化信号发生器页
		private void tabPageWavegen_Enter(object sender, EventArgs e)
		{
			//实例化图表控制器
			if(wavegenChartController == null)
				wavegenChartController = new WavegenChartController();
			/*
			//实例化图表测试器
			if (wavegenChartTester == null)
				wavegenChartTester = new ChartTester(formsPlotWaveGen);
			*/
			isInit = true;
			//显示区控件初始化
			toolStripComboBoxColorStyle2.SelectedIndex = 0;    //浅色
			toolStripComboBoxLineStyle2.SelectedIndex = 0;    //折线
			toolStripComboBoxLineWidth2.SelectedIndex = 0;     //线宽：1
			//初始化ComboBox默认项
			comboBoxFrequency.SelectedIndex = comboBoxFrequency.Items.IndexOf("1kHz");
			comboBoxAmplitde.SelectedIndex = comboBoxAmplitde.Items.IndexOf("2V");
			comboBoxOffset.SelectedIndex = comboBoxOffset.Items.IndexOf("0V");
			comboBoxSymmetry.SelectedIndex = comboBoxSymmetry.Items.IndexOf("50%");
			comboBoxPhase.SelectedIndex = comboBoxPhase.Items.IndexOf("0°");
			//进入界面时禁用所有选项
			EnableWidget(true, false, false, false, false, false);
			isInit = false;
			//设置标签
			formsPlotWaveGen.Plot.Title("预览");
			//设置坐标轴
			formsPlotWaveGen.Plot.XLabel("ms");
			formsPlotWaveGen.Plot.YLabel("V");
			formsPlotWaveGen.Plot.SetAxisLimitsX(0, 1);
			// 翻转刻度线方向
			formsPlotWaveGen.Plot.XAxis.TickMarkDirection(outward: false);
			formsPlotWaveGen.Plot.YAxis.TickMarkDirection(outward: false);
		}

		//启用/禁用控件
		private void EnableWidget(bool bWaveType, bool bAmplitude, bool bFrequency, bool bOffset, bool bPhase, bool bSymmetry)
		{
			isInit = true;
			comboBoxWaveType.Enabled = bWaveType;	   //禁用波形选项
			comboBoxAmplitde.Enabled = bAmplitude;		//禁用幅值选项
			comboBoxFrequency.Enabled = bFrequency;     //禁用频率选项
			comboBoxOffset.Enabled = bOffset;     //禁用偏移选项
			comboBoxPhase.Enabled = bPhase;     //禁用相位选项
			comboBoxSymmetry.Enabled = bSymmetry;       //禁用对称选项
			isInit = false;
		}
		#endregion
		#region 发送波形/停止发送

		//运行/停止按钮
		private void buttonRunWaveGen_Click(object sender, EventArgs e)
		{
			if (checkBoxRunState.Checked == false)      //如果当前没有在运行
			{
				//to-do 产生波形
				//运行时禁用所有配置选择控件
				EnableWidget(false, false, false, false, false, false);
				//更改运行按钮样式
				//buttonRunWavegen.BackColor = Color.Tomato;
				buttonRunWavegen.Text = "停止";
				checkBoxRunState.Checked = true;
			}
			else
			{
				//to-do 接受波形
				//重新激活控件
				if (comboBoxWaveType.SelectedIndex == 0)        //对DC电源
					EnableWidget(true, true, false, false, false, false);
				else if (comboBoxWaveType.SelectedIndex == 6)     //对噪声选项
					EnableWidget(true, true, true, true, false, false);
				else
					EnableWidget(true, true, true, true, true, false);
				//buttonRunWavegen.BackColor = Color.LimeGreen;
				buttonRunWavegen.Text = "运行";
				checkBoxRunState.Checked = false;
			}
		}
		#endregion
		#region 配置变更 已完成，不要动
		

		//波形选项发生变更
		private void comboBoxWaveType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (isInit == true) return;
			if(comboBoxWaveType.SelectedIndex == 0)		//对DC电源
				EnableWidget(true, true, false, false, false, false);
			else if (comboBoxWaveType.SelectedIndex == 6)     //对噪声选项
				EnableWidget(true, true, true, true, false, false);
			else
				EnableWidget(true, true, true, true, true, false);

			//获取配置信息并添加预览图线
			signalPlotXYWaveGen = wavegenChartController.AddWaveforms(formsPlotWaveGen, new WaveformConfig(GetWavegenConfigSelectedList()));
		}

		//频率选项发生变更
		private void comboBoxFrequency_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (isInit == true) return;
			//重设坐标轴
			//wavegenChartController.SetAxis(formsPlotWaveGen, new WaveformInfor(GetSelectedList()));
			//获取配置信息并添加预览图线
			signalPlotXYWaveGen = wavegenChartController.AddWaveforms(formsPlotWaveGen, new WaveformConfig(GetWavegenConfigSelectedList()));
		}

		//幅值选项发生变更
		private void comboBoxAmplitde_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (isInit == true) return;
			//获取配置信息并添加预览图线
			signalPlotXYWaveGen = wavegenChartController.AddWaveforms(formsPlotWaveGen, new WaveformConfig(GetWavegenConfigSelectedList()));
		}

		//y轴偏移量选项发生变更
		private void comboBoxOffset_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (isInit == true) return;
			//获取配置信息并添加预览图线
			signalPlotXYWaveGen = wavegenChartController.AddWaveforms(formsPlotWaveGen, new WaveformConfig(GetWavegenConfigSelectedList()));
		}

		//对称偏移量选项发生变更
		private void comboBoxSymmetry_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (isInit == true) return;
			//获取配置信息并添加预览图线
			signalPlotXYWaveGen = wavegenChartController.AddWaveforms(formsPlotWaveGen, new WaveformConfig(GetWavegenConfigSelectedList()));
		}

		//相位选项发生变更
		private void comboBoxPhase_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (isInit == true) return;
			//获取配置信息并添加预览图线
			signalPlotXYWaveGen = wavegenChartController.AddWaveforms(formsPlotWaveGen, new WaveformConfig(GetWavegenConfigSelectedList()));
		}
		#endregion
		#region 信号发生器图表显示设置 已完成，不要动
		private void toolStripComboBoxColorStyle2_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (isInit) return;     //如果正在初始化,则屏蔽更改事件
				int colorStyle = toolStripComboBoxColorStyle2.SelectedIndex;      //获取色彩模式
				scopeChartController.SetPlotColorStyle(this.formsPlotWaveGen, this.signalPlotXYWaveGen, colorStyle);     //变更色彩模式
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void toolStripComboBoxLineStyle2_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (isInit) return;     //如果正在初始化,则屏蔽更改事件
				int iLineStyle = toolStripComboBoxLineStyle2.SelectedIndex;       //获取连线样式
				scopeChartController.SetLineStyle(this.formsPlotWaveGen, this.signalPlotXYWaveGen, iLineStyle);
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void toolStripComboBoxLineWidth2_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (isInit) return;     //如果正在初始化,则屏蔽更改事件
				double dLineWidth = Double.Parse(toolStripComboBoxLineWidth2.SelectedItem.ToString());    //获取线宽
				scopeChartController.SetLineWidth(this.formsPlotWaveGen, this.signalPlotXYWaveGen, dLineWidth);
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		#endregion
		#region 信号发生器图表交互设置 已完成，不要动
		//鼠标右键拖拽缩放
		private void toolStripMenuItemRightClickDragZoom2_Click(object sender, EventArgs e)
		{
			this.toolStripMenuItemRightClickDragZoom2.Checked =
				!this.toolStripMenuItemRightClickDragZoom2.Checked;
			this.formsPlotScope.Configuration.RightClickDragZoom =
				this.toolStripMenuItemRightClickDragZoom2.Checked;
		}

		//鼠标滚轮缩放

		private void toolStripMenuItemScrollWheelZoom2_Click(object sender, EventArgs e)
		{
			this.toolStripMenuItemScrollWheelZoom2.Checked =
				!this.toolStripMenuItemScrollWheelZoom2.Checked;
			this.formsPlotScope.Configuration.ScrollWheelZoom =
				this.toolStripMenuItemScrollWheelZoom2.Checked;
		}

		//启用/禁用水平缩放
		private void toolStripMenuItemHorizontalZoom2_Click(object sender, EventArgs e)
		{
			this.toolStripMenuItemHorizontalZoom2.Checked =
				!this.toolStripMenuItemHorizontalZoom2.Checked;
			this.formsPlotScope.Configuration.LockHorizontalAxis =
				!this.toolStripMenuItemHorizontalZoom2.Checked;
		}

		//启用/禁用垂直缩放
		private void toolStripMenuItemVerticalZoom2_Click(object sender, EventArgs e)
		{
			this.toolStripMenuItemVerticalZoom2.Checked =
				!this.toolStripMenuItemVerticalZoom2.Checked;
			this.formsPlotScope.Configuration.LockVerticalAxis =
				!this.toolStripMenuItemVerticalZoom2.Checked;
		}
		#endregion
		#endregion

		#region 电压电流计
		#region 初始化
		private void tabPageMeter_Enter(object sender, EventArgs e)
		{
			//显示区控件初始化
			toolStripComboBoxColorStyle3.SelectedIndex = 0;    //浅色
			toolStripComboBoxLineStyle3.SelectedIndex = 0;    //折线
			toolStripComboBoxLineWidth3.SelectedIndex = 0;     //线宽：1
			// 翻转刻度线方向
			formsPlotMeter.Plot.XAxis.TickMarkDirection(outward: false);
			formsPlotMeter.Plot.YAxis.TickMarkDirection(outward: false);
			formsPlotMeter.Plot.Legend();
		}
		#endregion
		#region 工具栏
		//添加追踪器
		private void toolStripLabelAddTracer_Click(object sender, EventArgs e)
		{
			meterTracerController.AddTracer();
		}

		//清空追踪器
		private void toolStripLabel2_Click(object sender, EventArgs e)
		{
			meterTracerController.ClearTracer();
		}
		#endregion
		#region 电压电流计图表显示设置 已完成，不要动
		private void toolStripComboBoxColorStyle3_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (isInit) return;     //如果正在初始化,则屏蔽更改事件
				int colorStyle = toolStripComboBoxColorStyle3.SelectedIndex;      //获取色彩模式
				scopeChartController.SetPlotColorStyle(this.formsPlotMeter, this.signalPlotXYMeter, colorStyle);     //变更色彩模式
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void toolStripComboBoxLineStyle3_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (isInit) return;     //如果正在初始化,则屏蔽更改事件
				int iLineStyle = toolStripComboBoxLineStyle3.SelectedIndex;       //获取连线样式
				scopeChartController.SetLineStyle(this.formsPlotMeter, this.signalPlotXYMeter, iLineStyle);
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void toolStripComboBoxLineWidth3_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (isInit) return;     //如果正在初始化,则屏蔽更改事件
				double dLineWidth = Double.Parse(toolStripComboBoxLineWidth3.SelectedItem.ToString());    //获取线宽
				scopeChartController.SetLineWidth(this.formsPlotMeter, this.signalPlotXYMeter, dLineWidth);
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		#endregion
		#region 电压电流计图表交互设置 已完成，不要动
		//鼠标右键拖拽缩放
		private void toolStripMenuItemRightClickDragZoom3_Click(object sender, EventArgs e)
		{
			this.toolStripMenuItemRightClickDragZoom3.Checked =
				!this.toolStripMenuItemRightClickDragZoom3.Checked;
			this.formsPlotMeter.Configuration.RightClickDragZoom =
				this.toolStripMenuItemRightClickDragZoom3.Checked;
		}

		//鼠标滚轮缩放

		private void toolStripMenuItemScrollWheelZoom3_Click(object sender, EventArgs e)
		{
			this.toolStripMenuItemScrollWheelZoom3.Checked =
				!this.toolStripMenuItemScrollWheelZoom3.Checked;
			this.formsPlotMeter.Configuration.ScrollWheelZoom =
				this.toolStripMenuItemScrollWheelZoom3.Checked;
		}

		//启用/禁用水平缩放
		private void toolStripMenuItemHorizontalZoom3_Click(object sender, EventArgs e)
		{
			this.toolStripMenuItemHorizontalZoom3.Checked =
				!this.toolStripMenuItemHorizontalZoom3.Checked;
			this.formsPlotMeter.Configuration.LockHorizontalAxis =
				!this.toolStripMenuItemHorizontalZoom3.Checked;
		}

		//启用/禁用垂直缩放
		private void toolStripMenuItemVerticalZoom3_Click(object sender, EventArgs e)
		{
			this.toolStripMenuItemVerticalZoom3.Checked =
				!this.toolStripMenuItemVerticalZoom3.Checked;
			this.formsPlotMeter.Configuration.LockVerticalAxis =
				!this.toolStripMenuItemVerticalZoom3.Checked;
		}
		#endregion
		#endregion

		#region 频谱分析仪
		#region 初始化
		private void tabPageSpectrum_Enter(object sender, EventArgs e)
		{
			//打开初始化标记
			isInit = true;
			//显示区控件初始化
			toolStripComboBoxColorStyle4.SelectedIndex = 0;    //浅色
			toolStripComboBoxLineStyle4.SelectedIndex = 0;    //折线
			toolStripComboBoxLineWidth4.SelectedIndex = 0;     //线宽：1
			//频谱设置区控件初始化
			toolStripComboBoxStart.SelectedIndex = 21;		//Start = 0Hz
			toolStripComboBoxStop.SelectedIndex = 2;	//Stop = 1MHz
			toolStripComboBoxBoxCount.SelectedIndex = 0;	//BoxCount = Default
			toolStripComboBoxScale.SelectedIndex = 0;	//Scale = Linear
			toolStripComboBoxAlgorithm.SelectedIndex = 0;   //Algorithm = FFT
			//振幅设置区控件初始化
			comboBoxMagnitudeUnit.SelectedIndex = 0;    //Unit = Vpeak(V)
			comboBoxReference.SelectedIndex = 13;       //Reference = 0.05V
			//信道设置区控件初始化
			comboBoxChannelOffset.SelectedIndex = 14;   //Offset = 0V
			comboBoxChannelRange.SelectedIndex = 0;     //Range = Auto
			comboBoxChannelAttenuation.SelectedIndex = 2;	 //Attenuation = 1X
			//关闭初始化标记
			isInit = false;

			// 重新装填Top和Range复选框
			ReloadMagnitudeRangeComboBox(comboBoxMagnitudeUnit.SelectedItem.ToString());

			// 刷新X轴上下限及标签 
			spectrumChartController.ChangeFrequencyAxisLimits(
				formsPlotSpectrum,
				toolStripComboBoxStart.SelectedItem.ToString(),
				toolStripComboBoxStop.SelectedItem.ToString(),
				toolStripComboBoxScale.SelectedIndex);
			spectrumChartController.ChangeFrequencyAxisLabel(
				formsPlotSpectrum, 
				toolStripComboBoxStop.SelectedItem.ToString());

			// 刷新Y轴上下限及标签 
			spectrumChartController.ChangeMagnitudeAxisLimits(
				formsPlotSpectrum,
				comboBoxMagnitudeTop.SelectedItem.ToString(),
				comboBoxMagnitudeRange.SelectedItem.ToString());
			spectrumChartController.ChangeMagnitudeAxisLabel(
				formsPlotSpectrum, 
				comboBoxMagnitudeTop.SelectedItem.ToString());

			// 翻转刻度线方向
			formsPlotSpectrum.Plot.XAxis.TickMarkDirection(outward: false);
			formsPlotSpectrum.Plot.YAxis.TickMarkDirection(outward: false);
		}
		#endregion
		#region 工具栏
		FrequencyAnalyzerTester analyzerTester = new FrequencyAnalyzerTester(1024);
		//频谱分析仪页-工具栏-单次采集按钮-测试
		private void toolStripButtonSingle_Click(object sender, EventArgs e)
		{
			//to-do 改为从串口获取波形
			//获取波形类型
			string sWaveTypeText = textBoxSpectrumTest.Text;
			if (sWaveTypeText == null || sWaveTypeText.Equals("")) sWaveTypeText = "0";
			byte bWaveType = 0;
			try 
			{
				bWaveType = (byte)int.Parse(sWaveTypeText);
			} catch(Exception ex)
			{
				MessageBox.Show("波形类型参数错误" + ex.Message);
			}
			
			//获取频谱
			float[] magnitudeSpectrum = analyzerTester.TestMagnitudeSpectrum(bWaveType);
			double[] _magnitudeSpectrum = new double[magnitudeSpectrum.Length];
			for (int i = 0; i < magnitudeSpectrum.Length; ++i)
				_magnitudeSpectrum[i] = (float)magnitudeSpectrum[i];
			//显示频谱
			textBoxSpectrumTest.Text = magnitudeSpectrum.ToString();
			formsPlotSpectrum.Plot.Clear();
			formsPlotSpectrum.Plot.AddSignal(waveformDataGenerator.GenerateWaveformData(bWaveType, 1024, new WaveformConfig()));
			formsPlotSpectrum.Plot.AddSignal(_magnitudeSpectrum);
			formsPlotSpectrum.Render();
		}
		#endregion
		#region 频谱设置
		#region 响应事件
		// 最小频率更改事件
		private void toolStripComboBoxStart_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (isInit == true) return;
			// 如果最大频率小于最小频率
			if (toolStripComboBoxStart.SelectedIndex < toolStripComboBoxStop.SelectedIndex)
				MessageBox.Show("频率设置不正确");
			else
			{
				// 更改频率坐标（X轴）上下限及标签
				spectrumChartController.ChangeFrequencyAxisLimits(
					formsPlotSpectrum,
					toolStripComboBoxStart.SelectedItem.ToString(),
					toolStripComboBoxStop.SelectedItem.ToString(),
					toolStripComboBoxScale.SelectedIndex);
				spectrumChartController.ChangeFrequencyAxisLabel(
					formsPlotSpectrum, 
					GetUnitFromString(toolStripComboBoxStop.SelectedItem.ToString()));
			}
		}

		// 最大频率更改事件
		private void toolStripComboBoxStop_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (isInit == true) return;
			// 如果最大频率小于最小频率
			if (toolStripComboBoxStart.SelectedIndex < toolStripComboBoxStop.SelectedIndex)
				MessageBox.Show("频率设置不正确");
			else
			{
				// 更改频率坐标（X轴）上下限及标签
				spectrumChartController.ChangeFrequencyAxisLimits(
					formsPlotSpectrum,
					toolStripComboBoxStart.SelectedItem.ToString(),
					toolStripComboBoxStop.SelectedItem.ToString(),
					toolStripComboBoxScale.SelectedIndex);
				spectrumChartController.ChangeFrequencyAxisLabel(
					formsPlotSpectrum, 
					GetUnitFromString(toolStripComboBoxStop.SelectedItem.ToString()));
			}
		}

		// 坐标轴放缩类型更改事件
		private void toolStripComboBoxScale_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (isInit == true) return;
			// 更改频率坐标（X轴）上下限及标签
			spectrumChartController.ChangeFrequencyAxisLimits(
				formsPlotSpectrum,
				toolStripComboBoxStart.SelectedItem.ToString(), 
				toolStripComboBoxStop.SelectedItem.ToString(), 
				toolStripComboBoxScale.SelectedIndex);
			spectrumChartController.ChangeFrequencyAxisLabel(
				formsPlotSpectrum, 
				GetUnitFromString(toolStripComboBoxStop.SelectedItem.ToString()));
		}
		#endregion
		#region 功能函数
		// 更改频率坐标轴上下限
		
		#endregion
		#endregion
		#region 幅值设置
		#region 响应事件
			// 幅值单位更改事件
			private void comboBoxMagnitudeUnit_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (isInit == true) return;
			// 获取当前单位
			string strUnit = comboBoxMagnitudeUnit.SelectedItem.ToString();
			// todo 幅值单位变化响应
			// 幅值显示上限及量程重新装填
			ReloadMagnitudeRangeComboBox(strUnit);
			// 更新Y轴上下限与标签
			spectrumChartController.ChangeMagnitudeAxisLimits(
				formsPlotSpectrum,
				comboBoxMagnitudeTop.SelectedItem.ToString(),
				comboBoxMagnitudeRange.SelectedItem.ToString());
			spectrumChartController.ChangeMagnitudeAxisLabel(
				formsPlotSpectrum, 
				comboBoxMagnitudeTop.SelectedItem.ToString());
		}

		// 幅值显示上限更改事件
		private void comboBoxMagnitudeTop_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (isInit == true) return;
			// Vpeak和Vrms模式下保持Top和Range选项一致
			if(comboBoxMagnitudeUnit.SelectedIndex < 2)
			{
				isInit = true;
				comboBoxMagnitudeRange.SelectedIndex = comboBoxMagnitudeTop.SelectedIndex;	
				isInit = false;
			}
			// 更新Y轴上下限与标签
			spectrumChartController.ChangeMagnitudeAxisLimits(
				formsPlotSpectrum,
				comboBoxMagnitudeTop.SelectedItem.ToString(),
				comboBoxMagnitudeRange.SelectedItem.ToString());
			spectrumChartController.ChangeMagnitudeAxisLabel(
				formsPlotSpectrum, 
				comboBoxMagnitudeTop.SelectedItem.ToString());
		}

		// 幅值量程更改事件
		private void comboBoxMagnitudeRange_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (isInit == true) return;
			spectrumChartController.ChangeMagnitudeAxisLimits(
				formsPlotSpectrum,
				comboBoxMagnitudeTop.SelectedItem.ToString(),
				comboBoxMagnitudeRange.SelectedItem.ToString());
		}
		#endregion
		#region 功能函数
		// 重新装填MagnitudeTop及MagnitudeRange
		private void ReloadMagnitudeRangeComboBox(string strUnit)
		{
			isInit = true;
			if (strUnit.Equals("Vpeak(V)"))
			{
				// 禁用Range及Reference
				comboBoxMagnitudeRange.Enabled = false;
				comboBoxReference.Enabled = false;
				// 重新装填Top和Range
				comboBoxMagnitudeTop.Items.Clear();
				comboBoxMagnitudeRange.Items.Clear();
				string[] strVpeakRangeItems =
				{
					"25V", "10V", "5V", "2V", "1V",
					"0.5V", "0.2V", "0.1V",
					"0.05V", "0.02V", "0.01V",
					"5mV", "2mV", "1mV",
					"0.5mV", "0.2mV", "0.1mV",
					"0.05mV", "0.02mV", "0.01mV",
					"5uV", "2uV", "1uV"
				};
				foreach (string str in strVpeakRangeItems)
				{
					comboBoxMagnitudeTop.Items.Add(str);
					comboBoxMagnitudeRange.Items.Add(str);
				}
				comboBoxMagnitudeTop.SelectedIndex = 0;
				comboBoxMagnitudeRange.SelectedIndex = 0;
			}
			else if (strUnit.Equals("Vrms"))
			{
				// 禁用Range及Reference
				comboBoxMagnitudeRange.Enabled = false;
				comboBoxReference.Enabled = false;
				// 重新装填Top和Range
				comboBoxMagnitudeTop.Items.Clear();
				comboBoxMagnitudeRange.Items.Clear();
				string[] strVpeakRangeItems =
				{
					"10Vrms", "5Vrms", "2Vrms", "1Vrms",
					"0.5Vrms", "0.2Vrms", "0.1Vrms",
					"0.05Vrms", "0.02Vrms", "0.01Vrms",
					"5mVrms", "2mVrms", "1mVrms",
					"0.5mVrms", "0.2mVrms", "0.1mVrms",
					"0.05mVrms", "0.02mVrms", "0.01mVrms",
					"5uVrms", "2uVrms", "1uVrms"
				};
				foreach (string str in strVpeakRangeItems)
				{
					comboBoxMagnitudeTop.Items.Add(str);
					comboBoxMagnitudeRange.Items.Add(str);
				}
				comboBoxMagnitudeTop.SelectedIndex = 0;
				comboBoxMagnitudeRange.SelectedIndex = 0;
			}
			else if (strUnit.Equals("dBV") || strUnit.Equals("dBu"))
			{
				// 启用Range，禁用Reference
				comboBoxMagnitudeRange.Enabled = true;
				comboBoxReference.Enabled = false;
				// 重新装填Top和Range
				comboBoxMagnitudeTop.Items.Clear();
				comboBoxMagnitudeRange.Items.Clear();
				for (int i = 100; i >= -100; i -= 10)
					comboBoxMagnitudeTop.Items.Add(i.ToString() + strUnit);
				for(int i = 200; i > 0; i -= 10)
					comboBoxMagnitudeRange.Items.Add(i.ToString() + strUnit);
				comboBoxMagnitudeRange.Items.Add("1" + strUnit);
				// 默认选中 20dBV 200dBV
				comboBoxMagnitudeTop.SelectedIndex = 8;
				comboBoxMagnitudeRange.SelectedIndex = 0;
			}
			else if(strUnit.Equals("dB"))
			{
				// 启用Range，启用Reference
				comboBoxMagnitudeRange.Enabled = true;
				comboBoxReference.Enabled = true;
				// 重新装填Top和Range
				comboBoxMagnitudeTop.Items.Clear();
				comboBoxMagnitudeRange.Items.Clear();
				for (int i = 100; i >= -100; i -= 10)
					comboBoxMagnitudeTop.Items.Add(i.ToString() + strUnit);
				for (int i = 200; i > 0; i -= 10)
					comboBoxMagnitudeRange.Items.Add(i.ToString() + strUnit);
				comboBoxMagnitudeRange.Items.Add("1" + strUnit);
				// 默认选中 20dBV 200dBV
				comboBoxMagnitudeTop.SelectedIndex = 8;
				comboBoxMagnitudeRange.SelectedIndex = 0;
			}
			isInit = false;
		}
		#endregion
		#endregion
		#region 信道设置
		//添加追踪器
		private void buttonAddTrace_Click(object sender, EventArgs e)
		{
			spectrumTracerController.AddTracer();
		}
		#endregion
		#region 频谱分析仪表显示设置 已完成，不要动
		private void toolStripComboBoxColorStyle4_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (isInit) return;     //如果正在初始化,则屏蔽更改事件
				int colorStyle = toolStripComboBoxColorStyle4.SelectedIndex;      //获取色彩模式
				scopeChartController.SetPlotColorStyle(this.formsPlotSpectrum, this.signalPlotXYSpectrum, colorStyle);     //变更色彩模式
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void toolStripComboBoxLineStyle4_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (isInit) return;     //如果正在初始化,则屏蔽更改事件
				int iLineStyle = toolStripComboBoxLineStyle4.SelectedIndex;       //获取连线样式
				scopeChartController.SetLineStyle(this.formsPlotSpectrum, this.signalPlotXYSpectrum, iLineStyle);
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void toolStripComboBoxLineWidth4_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (isInit) return;     //如果正在初始化,则屏蔽更改事件
				double dLineWidth = Double.Parse(toolStripComboBoxLineWidth4.SelectedItem.ToString());    //获取线宽
				scopeChartController.SetLineWidth(this.formsPlotSpectrum, this.signalPlotXYSpectrum, dLineWidth);
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		#endregion
		#region 频谱分析仪图表交互设置 已完成，不要动
		//鼠标右键拖拽缩放
		private void toolStripMenuItemRightClickDragZoom4_Click(object sender, EventArgs e)
		{
			this.toolStripMenuItemRightClickDragZoom4.Checked =
				!this.toolStripMenuItemRightClickDragZoom4.Checked;
			this.formsPlotSpectrum.Configuration.RightClickDragZoom =
				this.toolStripMenuItemRightClickDragZoom4.Checked;
		}

		//鼠标滚轮缩放

		private void toolStripMenuItemScrollWheelZoom4_Click(object sender, EventArgs e)
		{
			this.toolStripMenuItemScrollWheelZoom4.Checked =
				!this.toolStripMenuItemScrollWheelZoom4.Checked;
			this.formsPlotSpectrum.Configuration.ScrollWheelZoom =
				this.toolStripMenuItemScrollWheelZoom4.Checked;
		}

		//启用/禁用水平缩放
		private void toolStripMenuItemHorizontalZoom4_Click(object sender, EventArgs e)
		{
			this.toolStripMenuItemHorizontalZoom4.Checked =
				!this.toolStripMenuItemHorizontalZoom4.Checked;
			this.formsPlotSpectrum.Configuration.LockHorizontalAxis =
				!this.toolStripMenuItemHorizontalZoom4.Checked;
		}

		//启用/禁用垂直缩放
		private void toolStripMenuItemVerticalZoom4_Click(object sender, EventArgs e)
		{
			this.toolStripMenuItemVerticalZoom4.Checked =
				!this.toolStripMenuItemVerticalZoom4.Checked;
			this.formsPlotSpectrum.Configuration.LockVerticalAxis =
				!this.toolStripMenuItemVerticalZoom4.Checked;
		}
		#endregion
		#endregion

		#region 获取配置
		//在字符串中抓取实型数值
		private double GetRealFromString(string str)
		{
			StringBuilder res = new StringBuilder();
			foreach (char chr in str)
			{
				if ((chr >= '0' && chr <= '9') || chr == '.' || chr == '-')
					res.Append(chr);
			}
			return double.Parse(res.ToString());
		}

		//获取单位
		public static string GetUnitFromString(string str)
		{
			StringBuilder res_1 = new StringBuilder();
			foreach (char chr in str)
			{
				if ((chr >= '0' && chr <= '9') || chr == '.' || chr == '-')
					res_1.Append(chr);
			}
			int length = res_1.Length;
			StringBuilder res_2 = new StringBuilder();
			for (int i = length; i < str.Length; ++i)
			{
				res_2.Append(str[i]);
			}
			return res_2.ToString();
		}

		//获取示波器当前配置并打包为List
		private List<string> GetScopeConfigSelectedList()
		{
			List<string> list = new List<string>();
			list.Add(comboBoxCoupledType.SelectedItem.ToString());
			list.Add(comboBoxTriggerType.SelectedItem.ToString());
			list.Add(comboBoxVerticalSensitivity.SelectedItem.ToString());
			list.Add(comboBoxTimeBase.SelectedItem.ToString());
			return list;
		}

		//获取信号发生器当前配置并打包为List
		private List<string> GetWavegenConfigSelectedList()
		{
			List<string> list = new List<string>();
			if (comboBoxWaveType.SelectedItem == null)
			{
				return null;
			}
			else
			{
				list.Add(comboBoxWaveType.SelectedItem.ToString());
				list.Add(comboBoxFrequency.SelectedItem.ToString());
				list.Add(comboBoxAmplitde.SelectedItem.ToString());
				list.Add(comboBoxOffset.SelectedItem.ToString());
				list.Add(comboBoxSymmetry.SelectedItem.ToString());
				list.Add(comboBoxPhase.SelectedItem.ToString());
			}
			return list;
		}

		//获取频谱分析仪当前配置并打包为List
		private List<string> GetSpectrumConfigSelectedList()
		{
			List<string> list = new List<string>();
			if (comboBoxMagnitudeUnit.SelectedItem == null)
			{
				return null;
			}
			else
			{
				list.Add(toolStripComboBoxStart.SelectedItem.ToString());
				list.Add(toolStripComboBoxStop.SelectedItem.ToString());
				list.Add(toolStripComboBoxBoxCount.SelectedItem.ToString());
				list.Add(toolStripComboBoxScale.SelectedItem.ToString());
				list.Add(toolStripComboBoxAlgorithm.SelectedItem.ToString());
				list.Add(comboBoxMagnitudeUnit.SelectedItem.ToString());
				list.Add(comboBoxMagnitudeTop.SelectedItem.ToString());
				list.Add(comboBoxMagnitudeRange.SelectedItem.ToString());
				list.Add(comboBoxReference.SelectedItem.ToString());
				list.Add(comboBoxChannelOffset.SelectedItem.ToString());
				list.Add(comboBoxChannelRange.SelectedItem.ToString());
				list.Add(comboBoxChannelAttenuation.SelectedItem.ToString());
			}
			return list;
		}
		#endregion

		#region 测试
		/// <summary>
		/// 幅值单位标签点击事件,用于在测试文本框显示当前频谱分析仪配置
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void labelMagnitudeUnit_Click(object sender, EventArgs e)
		{
			SpectrumConfig spectrumConfig = new SpectrumConfig(GetSpectrumConfigSelectedList());
			this.textBoxSpectrumTest.Text = spectrumConfig.ToString();
		}

		Timer timerStopWatch = new Timer();
		Timer timerUpdateValues = new Timer();
		Timer timerUpdateForms = new Timer();
		double[] dYValues;
		double[] dXValues;

		/// <summary>
		/// 示波器Demo标签点击事件,用于启动演示模式
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void labelDemo_Click(object sender, EventArgs e)
		{
			if (this.labelDemo.BackColor == Color.Tomato)
			{
				formsPlotScope.Plot.Clear();
				#region 生成数据
				dYValues = waveformDataGenerator.GenerateSineData(1000,
					new WaveformConfig());
				dXValues = new double[dYValues.Length];
				for (int i = 1; i < dYValues.Length; i++) dXValues[i] = dXValues[i - 1] + 0.01;
				#endregion
				#region 初始化定时器
				tester.InitTimer(5);
				timerStopWatch.Interval = 100;
				timerStopWatch.Tick += new System.EventHandler(UpdateRuntime);
				//timerUpdateValues.Interval = 500;	
				//timerUpdateValues.Tick += new System.EventHandler(UpdateValues);
				timerUpdateForms.Interval = 25;
				timerUpdateForms.Tick += new System.EventHandler(UpdateForms);
				#endregion
				#region 初始化图表
				tester.InitTestData(new ValueTuple<double[], double[]>(dXValues, dYValues));
				ValueTuple<SignalPlotXY, Crosshair> vt = scopeChartController.InitScopeChart(tester.GetTestData());
				this.signalPlotXYScope = vt.Item1;
				this.crosshair = vt.Item2;
				this.signalPlotXYScope.Label = "test";
				formsPlotScope.Plot.Legend().FontSize = 15;
				//this.signalPlotXYScope = formsPlotScope.Plot.AddSignalXY(dXValues, dYValues);
				//this.crosshair = formsPlotScope.Plot.AddCrosshair(0.0, 0.0);
				//formsPlotScope.Plot.AxisAuto();
				#endregion
				#region 开始定时器
				tester.StartTimer();
				stopwatch.Restart();
				timerStopWatch.Start();
				//timerUpdateValues.Start();
				timerUpdateForms.Start();
				#endregion
				this.labelDemo.BackColor = Color.LimeGreen;
			}
			else
			{
				#region 关闭定时器
				stopwatch.Stop();
				timerStopWatch.Stop();
				//timerUpdateValues.Stop();
				timerUpdateForms.Stop();
				tester.StopTimer();
				#endregion
				this.labelDemo.BackColor = Color.Tomato;
			}
		}

		public void UpdateRuntime(Object sender, EventArgs myEventArgs)
		{
			labelRunTime.Text = stopwatch.Elapsed.ToString();
		}

		public void UpdateValues(Object sender, EventArgs myEventArgs)
		{
			long ms = stopwatch.ElapsedMilliseconds;
			textBoxScopeTest.Text += ("*** at" + ms.ToString() + Environment.NewLine);
			//dYValues = waveformDataGenerator.GenerateNoiseData(1000, new WaveformInfor()).DValues;
		}

		public void UpdateForms(Object sender, EventArgs myEventArgs)
		{
			//long ms = stopwatch.ElapsedMilliseconds;
			//textBox1.Text += ("--- at" + stopwatch.ElapsedMilliseconds.ToString() + Environment.NewLine);
			this.formsPlotScope.Refresh(true, true);
		}



		#endregion
	}
}
