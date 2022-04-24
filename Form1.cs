using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;
using MyWaveForms.Entity;
using MyWaveForms.Controller;
using ScottPlot.Plottable;
using ScottPlot;

namespace MyWaveForms
{
	public partial class Form1 : Form
	{
		//跨线程操作会引起异常，接收数据是新开线程，窗口的接受文本在主线程
		//两个解决方案任选其一
		//解决方案一：新建委托来显示接受内容
		//protected delegate void UpdateDisplayDelegate(string text, TextBox textBox);

		public Form1()
		{
			this.Width = 1760;
			this.Height = 1200;
			InitializeComponent();
			//解决方案二：取消跨线程检查
			//Control.CheckForIllegalCrossThreadCalls = false;
			//InitUARTAsssist();
			//InitScopeWidget();
		}

		#region 串口助手部分
		SerialPortController serialPortController;

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
		private void labelSerialPortNumber_Click(object sender, EventArgs e)
		{
			serialPortController.ReflashPortToComboBox(serialPort1, comboBoxPort);
		}

		//打开串口按钮点击事件
		private void buttonOpenPort_Click(object sender, EventArgs e)
		{
			if (comboBoxPort.SelectedItem == null)
			{
				MessageBox.Show("没有选择串口！");
				return;
			}
			if (comboBoxBaudRate.SelectedItem == null)
			{
				MessageBox.Show("没有选择波特率！");
				return;
			}
			//获取ComboBox数据
			SerialPortInfor portConfig1 = new SerialPortInfor(
				comboBoxPort.SelectedItem.ToString(),
				comboBoxBaudRate.SelectedItem.ToString(),
				comboBoxDataBit.SelectedItem.ToString(),
				comboBoxCheckBit.SelectedItem.ToString(),
				comboBoxStopBit.SelectedItem.ToString());
			//打开串口
			serialPortController.OpenPort(serialPort1, portConfig1);
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

		#region 示波器部分
		//图表控制器
		ScopeChartController scopeChartController;
		//测试控制器
		ScopeChartTester scopeChartTester; 
		//信号图对象
		private SignalPlotXY signalPlotXY = null;
		//鼠标随动十字光标线
		private Crosshair crosshair;
		//IndexChange事件屏蔽标记
		private Boolean isInit = false;

		#region 控件初始化
		//初始化控件
		private void InitScopeWidget()
		{
			if(scopeChartController == null)	//实例化图表控制器
				scopeChartController = new ScopeChartController();
			if (scopeChartTester == null)   //实例化测试控制器
				scopeChartTester = new ScopeChartTester(formsPlotScope);

			isInit = true;      //打开屏蔽标记
			//显示区控件初始化
			comboBoxColorStyle.SelectedIndex = 0;    //浅色
			comboBoxLineStyle.SelectedIndex = 0;    //折线
			comboBoxLineWidth.SelectedIndex = 0;     //线宽：1
			//控制区控件初始化
			comboBoxCoupledType.SelectedIndex = 0;      //DC
			comboBoxTriggerType.SelectedIndex = 0;      //同时触发
			comboBoxVerticalSensitivity.SelectedIndex = 2;      //0.1V
			comboBoxTimeBase.SelectedIndex = 9;     //1ms
			isInit = false;     //关闭屏蔽标记

			//无数据初始化图表
			ValueTuple<SignalPlotXY, Crosshair> vt = scopeChartController.InitChart(formsPlotScope,
				comboBoxColorStyle.SelectedIndex,
				Double.Parse(comboBoxLineWidth.SelectedItem.ToString()),
				comboBoxLineStyle.SelectedIndex);		
			this.signalPlotXY = vt.Item1;
			this.crosshair = vt.Item2;
		}

		private void tabPageScope_Enter(object sender, EventArgs e)
		{
			InitScopeWidget();
		}
		#endregion
		#region 测试数据
		//Demo Mode标签点击事件
		private void labelDemo_Click(object sender, EventArgs e)
		{
			if (labelDemo.BackColor == Color.Tomato)     //启动Demo模式
			{
				//获取波形发生器配置
				List<string> list = GetWavegenConfigSelectedList();
				if (list == null)
				{
					MessageBox.Show("信号发生器无参数");
				}
				else 
				{
					//生成波形发生器配置信息
					WaveformInfor waveformInfor = new WaveformInfor(list);
					//从波形数据生成器获取数据
					ValueTuple<double[], double[]> dataTuple = wavegenChartController.GetWaveData(waveformInfor);
					scopeChartTester.InitTestData(dataTuple);
					//加载图表
					ValueTuple<SignalPlotXY, Crosshair> vt = scopeChartController.InitChart(formsPlotScope,
						scopeChartTester.GetTestData(),
						comboBoxColorStyle.SelectedIndex,
						Double.Parse(comboBoxLineWidth.SelectedItem.ToString()),
						comboBoxLineStyle.SelectedIndex); 
					this.signalPlotXY = vt.Item1;
					this.crosshair = vt.Item2;
					//更新X轴单位标签
					formsPlotScope.Plot.XLabel(waveformInfor.GetTimeTickLabel());
					//初始化定时器
					scopeChartTester.InitTimer();
					//标签转为绿色
					labelDemo.BackColor = Color.LimeGreen;
				}
			}
			else
			{
				labelDemo.BackColor = Color.Tomato;
				//关闭定时器
				scopeChartTester.StopTimer();
			}
		}
		#endregion
		#region 显示设置 已完成，不要动

		//变更图表色彩模式
		private void comboBoxColorStyle_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (isInit) return;     //如果正在初始化,则屏蔽更改事件
				int colorStyle = comboBoxColorStyle.SelectedIndex;      //获取色彩模式
				scopeChartController.SetPlotColorStyle(this.formsPlotScope, this.signalPlotXY, colorStyle);     //变更色彩模式
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// 变更图表线条粗细
		private void comboBoxLineWidth_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (isInit) return;     //如果正在初始化,则屏蔽更改事件
				double dLineWidth = Double.Parse(comboBoxLineWidth.SelectedItem.ToString());    //获取线宽
				scopeChartController.SetLineWidth(this.formsPlotScope, this.signalPlotXY, dLineWidth);
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// 变更图表线条样式
		private void comboBoxLineStyle_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (isInit) return;     //如果正在初始化,则屏蔽更改事件
				int iLineStyle = comboBoxLineStyle.SelectedIndex;       //获取连线样式
				scopeChartController.SetLineStyle(this.formsPlotScope, this.signalPlotXY, iLineStyle);
			}
			catch(System.Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		#endregion
		#region 交互设置 已完成，不要动
		//鼠标右键拖拽缩放
		private void checkBoxRightClickDragZoom_CheckedChanged(object sender, EventArgs e)
		{
			this.formsPlotScope.Configuration.RightClickDragZoom = this.checkBoxRightClickDragZoom.Checked;
		}

		//鼠标滚轮缩放
		private void checkBoxScrollWheelZoom_CheckedChanged(object sender, EventArgs e)
		{
			this.formsPlotScope.Configuration.ScrollWheelZoom = this.checkBoxScrollWheelZoom.Checked;
		}

		//启用/禁用水平缩放
		private void checkBoxHorizontalZoom_CheckedChanged(object sender, EventArgs e)
		{
			this.formsPlotScope.Configuration.LockHorizontalAxis = ! this.checkBoxHorizontalZoom.Checked;
		}

		//启用/禁用垂直缩放
		private void checkBoxVerticalZoom_CheckedChanged(object sender, EventArgs e)
		{
			this.formsPlotScope.Configuration.LockVerticalAxis = ! this.checkBoxVerticalZoom.Checked;
		}

		//启用/禁用十字准线
		private void checkBoxCrosshair_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				if (checkBoxCrosshair.Checked)
				{
					this.crosshair.VerticalLine.IsVisible = true;
					this.crosshair.HorizontalLine.IsVisible = true;
				}
				else
				{
					this.crosshair.VerticalLine.IsVisible = false;
					this.crosshair.HorizontalLine.IsVisible = false;
				}
				this.formsPlotScope.Refresh(false, false);
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		//鼠标移动时处理十字光标
		private void formsPlotMain_MouseMove(object sender, MouseEventArgs e)
		{
			if (checkBoxCrosshair.Checked == false) return;      //如果不需要绘制十字准线，直接返回
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
				if (checkBoxCrosshair.Checked == false) return;      //如果不需要绘制十字准线，直接返回
				if (checkBoxCrosshair.Checked)		//如果需要显示十字准线
				{
					//this.crosshair.IsVisible = true;
					this.crosshair.VerticalLine.IsVisible = true;	//设为可见
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
			catch(System.Exception ex)
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
		#region 信息区 to-do
		#endregion
		#endregion

		#region 信号发生器部分
		const int PlotSize = 1000;
		WavegenChartController wavegenChartController = new WavegenChartController();

		//初始化信号发生器页
		private void tabPageWavegen_Enter(object sender, EventArgs e)
		{
			isInit = true;
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

		//获取波形配置信息
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

		#region 发送波形/停止发送
		//运行/停止按钮
		private void buttonRunStop_Click(object sender, EventArgs e)
		{
			if (checkBoxRunState.Checked == false)      //如果当前没有在运行
			{
				//to-do 产生波形
				EnableWidget(false, false, false, false, false, false);
				buttonRunWavegen.BackColor = Color.Tomato;
				buttonRunWavegen.Text = "停止";
				checkBoxRunState.Checked = true;
			}
			else
			{
				//to-do 接受波形
				if (comboBoxWaveType.SelectedIndex == 0)        //对DC电源
					EnableWidget(true, true, false, false, false, false);
				else if (comboBoxWaveType.SelectedIndex == 6)     //对噪声选项
					EnableWidget(true, true, true, true, false, false);
				else if (comboBoxWaveType.SelectedIndex == 7)     //对梯形波选项
					EnableWidget(true, true, true, true, true, true);
				else
					EnableWidget(true, true, true, true, true, false);
				buttonRunWavegen.BackColor = Color.LimeGreen;
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
			else if (comboBoxWaveType.SelectedIndex == 7)     //对梯形波选项
				EnableWidget(true, true, true, true, true, true);
			else
				EnableWidget(true, true, true, true, true, false);

			//获取配置信息并添加预览图线
			wavegenChartController.AddWaveforms(formsPlotWaveGen, new WaveformInfor(GetWavegenConfigSelectedList()));
		}

		//频率选项发生变更
		private void comboBoxFrequency_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (isInit == true) return;
			//重设坐标轴
			//wavegenChartController.SetAxis(formsPlotWaveGen, new WaveformInfor(GetSelectedList()));
			//获取配置信息并添加预览图线
			wavegenChartController.AddWaveforms(formsPlotWaveGen, new WaveformInfor(GetWavegenConfigSelectedList()));
		}

		//幅值选项发生变更
		private void comboBoxAmplitde_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (isInit == true) return;
			//获取配置信息并添加预览图线
			wavegenChartController.AddWaveforms(formsPlotWaveGen, new WaveformInfor(GetWavegenConfigSelectedList()));
		}

		//y轴偏移量选项发生变更
		private void comboBoxOffset_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (isInit == true) return;
			//获取配置信息并添加预览图线
			wavegenChartController.AddWaveforms(formsPlotWaveGen, new WaveformInfor(GetWavegenConfigSelectedList()));
		}

		//对称偏移量选项发生变更
		private void comboBoxSymmetry_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (isInit == true) return;
			//获取配置信息并添加预览图线
			wavegenChartController.AddWaveforms(formsPlotWaveGen, new WaveformInfor(GetWavegenConfigSelectedList()));
		}

		//相位选项发生变更
		private void comboBoxPhase_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (isInit == true) return;
			//获取配置信息并添加预览图线
			wavegenChartController.AddWaveforms(formsPlotWaveGen, new WaveformInfor(GetWavegenConfigSelectedList()));
		}
		#endregion
		#endregion

		#region 电压电流计

		#endregion

		#region 频谱分析仪
		//Tracer控制器
		SpectrumTracerController tracerController = new SpectrumTracerController();

		//添加控制器
		private void buttonAddTrace_Click(object sender, EventArgs e)
		{
			tracerController.AddTracer(panelSpectrum);
		}
		#endregion

		#region 测试页
		private void button6_Click(object sender, EventArgs e)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < tracerController.TracerList.Count; ++i)
			{
				stringBuilder.Append(i.ToString() + tracerController.TracerList[i].ToString() + Environment.NewLine);
			}
			textBox3.Text = stringBuilder.ToString();
		}

		#endregion

		public static void RefreshPlot(FormsPlot formsPlot, bool lowQuality = false, bool skipIfCurrentlyRendering = false)
		{
			//while (formsPlot.InvokeRequired == true) ;
			formsPlot.Refresh(lowQuality, skipIfCurrentlyRendering);
		}
	}
}
