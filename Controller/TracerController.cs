using MyWaveForms.Entity;
using MyWaveForms.Generator;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWaveForms.Controller
{
	internal class TracerController
	{
		#region 常量
		//ComboBoxType Items字符串数组
		string[] strSpectrumTracerType = {
			"样本",
			"连续保持峰值",
			"保持峰值",
			"连续保持最小值",
			"保持最小值",
			"线性RMS平均",
			"线性dB平均",
			"指数RMS平均",
			"指数dB平均"};
		//ComboBoxType Items字符串数组
		string[] strMeterTracerType = {
			"DC",
			"True RMS",
			"AC RMS",
			"Ampere"};
		//ComboBoxCount Items字符串数组
		string[] strSpectrumTracerCount = {
			"1000000",
			"500000",
			"200000",
			"100000",
			"50000",
			"20000",
			"10000",
			"5000",
			"2000",
			"1000",
			"500",
			"200",
			"100",
			"50",
			"20",
			"10",
			"5",
			"2",
			"1"};
		#endregion

		#region 成员
		//支持的Tracer类型
		//0, Meter Tracer
		//1, Spectrum Tracer
		byte tracerType;
		//同时存在的最大Tracer数量
		private byte MAXSIZE;

		//Tracer控件尺寸
		private int iTracerWidgetWidth;
		private int iTracerWidgetHeight;

		//第一个Tracer的GroupBox的Location，也是后续添加的基准点
		private int iFirstLocationX;
		private int iFirstLocationY;
		//控件生成器
		WidgetGenerator widgetGenerator;
		//追踪器列表
		private List<Tracer> tracerList;
		//目标容器
		Panel targetContainer;
		//目标图表
		FormsPlot targetChart;
		#endregion

		public TracerController(Panel targetContainer, FormsPlot targetChart, byte tracerType, byte mAXSIZE, int iTracerWidgetWidth, int iTracerWidgetHeigh, int iFirstLocationX, int iFirstLocationY)
		{
			this.targetContainer = targetContainer;
			this.targetChart = targetChart;
			this.tracerType = tracerType;
			MAXSIZE = mAXSIZE;
			this.iTracerWidgetWidth = iTracerWidgetWidth;
			this.iTracerWidgetHeight = iTracerWidgetHeigh;
			this.iFirstLocationX = iFirstLocationX;
			this.iFirstLocationY = iFirstLocationY;
			this.widgetGenerator = new WidgetGenerator();
			this.tracerList = new List<Tracer>();
		}

		internal List<Tracer> TracerList { get => tracerList; set => tracerList = value; }

		//添加追踪器
		public bool AddTracer()
		{
			//滚动条归位，保证在滚动中也能正常添加
			//targetContainer.VerticalScroll.Value = targetContainer.VerticalScroll.Minimum;
			//获取新加入Tracer的序号
			int iIndex = tracerList.Count;
			//限制Tracer数目
			if (iIndex >= this.MAXSIZE)
			{
				MessageBox.Show("已达到支持的Tracer数目上限");
				return false;
			}
			//计算位置
			int iPositionX = iFirstLocationX;
			//追加滚动条偏移量，保证在滚动中也能正常添加
			int iPositionY = this.iFirstLocationY + this.iTracerWidgetHeight * iIndex - targetContainer.VerticalScroll.Value;
			//绘制新的Tracer，并获取其信息类
			Tracer tracerInfor;
			switch(this.tracerType)
			{
				case 0:
					tracerInfor = DrawMeterTracerWidget(targetContainer, iIndex, iPositionX, iPositionY);
					break;
				case 1:
					tracerInfor = DrawSpectrumTracerWidget(targetContainer, iIndex, iPositionX, iPositionY);
					break;
				default:
					tracerInfor = null;
					break;
			}
			//todo 添加图线至绘图区
			WaveformDataGenerator waveformDataGenerator = new WaveformDataGenerator();
			//生成测试数据
			double[] dXValues = new double[100];
			for (int i = 0; i < dXValues.Length; i++) dXValues[i] = i;
			double[] dYValues = waveformDataGenerator.GenerateWaveformData((byte)iIndex, 100, new WaveformConfig());
			//设置测试数据
			tracerInfor.DXValues = dXValues;
			tracerInfor.DYValues = dYValues;
			//添加图线
			tracerInfor.SignalPlot = targetChart.Plot.AddSignalXY(dXValues, dYValues);
			targetChart.Render();
			//添加新Tracer至列表
			tracerList.Add(tracerInfor);

			return true;
		}

		#region 绘制控件
		//添加MeterTracer相关控件
		private MeterTracer DrawMeterTracerWidget(Panel targetContainer, int iIndex, int iPositionX, int iPositionY)
		{
			MeterTracer tracer = new MeterTracer();
			//设定GroupBox
			GroupBox gbox = this.widgetGenerator.GetGroupBox("groupBoxTracer_" + iIndex.ToString(),
				"追踪器 " + (iIndex + 1).ToString(),
				iTracerWidgetWidth, iTracerWidgetHeight, iPositionX, iPositionY);
			tracer.GroupBox = gbox;
			targetContainer.Controls.Add(gbox);     //添加至容器

			#region 第一行
			//设定TextBox
			TextBox tbox = this.widgetGenerator.GetTextBox("textBoxTracer_" + iIndex.ToString(),
				"Tracer" + (iIndex + 1).ToString(),
				110, 30, 5, 20);
			tracer.TextBoxTracerName = tbox;
			gbox.Controls.Add(tbox);    //添加至容器，注意gbox外所有控件都添加到gbox
			tbox.BringToFront();    //显示在最上层

			//设定CheckBox
			CheckBox cbox = this.widgetGenerator.GetCheckBox("checkBoxVisibilityTracer_" + iIndex.ToString(),
				"可见",
				50, 30, 125, 15, new System.EventHandler(this.ChangePlotVisible), true);
			tracer.CheckBoxVisibility = cbox;
			gbox.Controls.Add(cbox);    //添加至容器，注意gbox外所有控件都添加到gbox
			cbox.BringToFront();    //显示在最上层

			// 设定Button
			Button button = this.widgetGenerator.GetButton("buttonDeleteTracer_" + iIndex.ToString(),
				"×",
				20, 20, 170, 20,
				new System.EventHandler(this.DeleteTracer));
			tracer.ButtonDelete = button;
			gbox.Controls.Add(button);    //添加至容器，注意gbox外所有控件都添加到gbox
			button.BringToFront();    //显示在最上层
			#endregion
			#region 第二行
			//设定当前值文本标签
			Label label1 = this.widgetGenerator.GetLabel("labelCurrentTextTracer_" + iIndex.ToString(), "当前值", 5, 50);
			tracer.LabelCurrentText = label1;
			gbox.Controls.Add(label1);    //添加至容器，注意gbox外所有控件都添加到gbox
			label1.BringToFront();    //显示在最上层		

			//设定当前值显示标签
			Label label2 = this.widgetGenerator.GetLabel("labelCurrentValueTracer_" + iIndex.ToString(), "N/A", 45, 50);
			tracer.LabelCurrentValue = label2;
			gbox.Controls.Add(label2);    //添加至容器，注意gbox外所有控件都添加到gbox
			label2.BringToFront();    //显示在最上层

			// 设定Label3  “类型”
			Label label3 = this.widgetGenerator.GetLabel("labelTypeTracer_" + iIndex.ToString(), "类型", 95, 50);
			tracer.LabelType = label3;
			gbox.Controls.Add(label3);    //添加至容器，注意gbox外所有控件都添加到gbox
			label3.BringToFront();    //显示在最上层

			// 设定ComboBox1  “类型”
			ComboBox comboBox1 = this.widgetGenerator.GetComboBox("labelTypeTracer_" + iIndex.ToString(), 60, 30, 130, 45, strMeterTracerType, 0);
			tracer.ComboBoxType = comboBox1;
			gbox.Controls.Add(comboBox1);    //添加至容器，注意gbox外所有控件都添加到gbox
			comboBox1.BringToFront();    //显示在最上层		
			#endregion
			#region 第三行
			//设定最大值文本标签
			Label label4 = this.widgetGenerator.GetLabel("labelCurrentTextTracer_" + iIndex.ToString(), "最大值", 5, 75);
			tracer.LabelMaxText = label4;
			gbox.Controls.Add(label4);    //添加至容器，注意gbox外所有控件都添加到gbox
			label4.BringToFront();    //显示在最上层

			//设定当前值显示标签
			Label label5 = this.widgetGenerator.GetLabel("labelCurrentValueTracer_" + iIndex.ToString(), "N/A", 45, 75);
			tracer.LabelMaxValue = label5;
			gbox.Controls.Add(label5);    //添加至容器，注意gbox外所有控件都添加到gbox
			label5.BringToFront();    //显示在最上层

			//设定最大值文本标签
			Label label6 = this.widgetGenerator.GetLabel("labelCurrentTextTracer_" + iIndex.ToString(), "最小值", 95, 75);
			tracer.LabelMinText = label6;
			gbox.Controls.Add(label6);    //添加至容器，注意gbox外所有控件都添加到gbox
			label6.BringToFront();    //显示在最上层

			//设定当前值显示标签
			Label label7 = this.widgetGenerator.GetLabel("labelCurrentValueTracer_" + iIndex.ToString(), "N/A", 135, 75);
			tracer.LabelMinValue = label7;
			gbox.Controls.Add(label7);    //添加至容器，注意gbox外所有控件都添加到gbox
			label7.BringToFront();    //显示在最上层
			#endregion
			
			return tracer;
		}

		//添加SpectrumTracer相关控件
		private SpectrumTracer DrawSpectrumTracerWidget(Panel targetContainer, int iIndex, int iPositionX, int iPositionY)
		{
			SpectrumTracer tracer = new SpectrumTracer();
			//设定GroupBox
			GroupBox gbox = this.widgetGenerator.GetGroupBox("groupBoxTracer_" + iIndex.ToString(),
				"追踪器 " + (iIndex + 1).ToString(),
				iTracerWidgetWidth, iTracerWidgetHeight, iPositionX, iPositionY);
			tracer.GroupBox = gbox;
			targetContainer.Controls.Add(gbox);     //添加至容器
			#region 第一行
			//设定TextBox
			TextBox tbox = this.widgetGenerator.GetTextBox("textBoxTracer_" + iIndex.ToString(),
				"Tracer" + (iIndex + 1).ToString(),
				110, 30, 10, 20);
			tracer.TextBoxTracerName = tbox;
			gbox.Controls.Add(tbox);    //添加至容器，注意gbox外所有控件都添加到gbox
			tbox.BringToFront();    //显示在最上层

			//设定CheckBox
			CheckBox cbox = this.widgetGenerator.GetCheckBox("checkBoxVisibilityTracer_" + iIndex.ToString(),
				"可见",
				50, 30, 125, 15, new System.EventHandler(this.ChangePlotVisible), true);
			tracer.CheckBoxVisibility = cbox;
			cbox.CheckedChanged += new System.EventHandler(ChangePlotVisible);		//添加可见性更改事件
			gbox.Controls.Add(cbox);    //添加至容器，注意gbox外所有控件都添加到gbox
			cbox.BringToFront();    //显示在最上层

			// 设定Button
			Button button = this.widgetGenerator.GetButton("buttonDeleteTracer_" + iIndex.ToString(),
				"×",
				20, 20, 170, 20,
				new System.EventHandler(this.DeleteTracer));
			tracer.ButtonDelete = button;
			gbox.Controls.Add(button);    //添加至容器，注意gbox外所有控件都添加到gbox
			button.BringToFront();    //显示在最上层
			#endregion
			#region 第二行
			// 设定Label1  “类型”
			Label label1 = this.widgetGenerator.GetLabel("labelTypeTracer_" + iIndex.ToString(), "类型", 10, 50);
			tracer.LabelType = label1;
			gbox.Controls.Add(label1);    //添加至容器，注意gbox外所有控件都添加到gbox
			label1.BringToFront();    //显示在最上层

			// 设定ComboBox1  “类型”
			ComboBox comboBox1 = this.widgetGenerator.GetComboBox("labelTypeTracer_" + iIndex.ToString(), 140, 30, 45, 45, strSpectrumTracerType, 0);
			tracer.ComboBoxType = comboBox1;
			gbox.Controls.Add(comboBox1);    //添加至容器，注意gbox外所有控件都添加到gbox
			comboBox1.BringToFront();    //显示在最上层
			#endregion
			#region 第三行
			// 设定Label2  “计数”
			Label label2 = this.widgetGenerator.GetLabel("labelTypeTracer_" + iIndex.ToString(), "计数", 10, 75);
			tracer.LabelCount = label2;
			gbox.Controls.Add(label2);    //添加至容器，注意gbox外所有控件都添加到gbox
			label2.BringToFront();    //显示在最上层

			// 设定ComboBox2  “计数”
			ComboBox comboBox2 = this.widgetGenerator.GetComboBox("labelTypeTracer_" + iIndex.ToString(), 140, 30, 45, 70, strSpectrumTracerCount, 0);
			tracer.ComboBoxCount = comboBox2;
			gbox.Controls.Add(comboBox2);    //添加至容器，注意gbox外所有控件都添加到gbox
			comboBox2.BringToFront();    //显示在最上层						  
			#endregion
			return tracer;
		}
		#endregion

		#region 响应事件
		//更改可见性
		public void ChangePlotVisible(object sender, EventArgs e)
		{
			CheckBox cbox = (CheckBox)sender;     //获取发送者

			//获取待更改的TracerInfor
			int index;
			for (index = 0; index < tracerList.Count; ++index)    //遍历list以获取index
				if (tracerList[index].CheckBoxVisibility == cbox)   //匹配button以确认位置
					break;

			//更改图线可见性
			tracerList[index].SignalPlot.IsVisible = cbox.Checked;
			//刷新图表
			Thread thread = new Thread(new ThreadStart(DoRefresh));
			thread.Start();

		}

		//删除Tracaer
		public void DeleteTracer(object sender, EventArgs e)
		{
			Button button = (Button)sender;     //获取发送者
			GroupBox groupBox = (GroupBox)button.Parent;    //获取Tracer GroupBox

			//获取待删除的TracerInfor
			int index;
			for (index = 0; index < tracerList.Count; ++index)    //遍历list以获取index
				if (tracerList[index].GroupBox == groupBox)   //匹配button以确认位置
					break;
			//删除图线
			targetChart.Plot.Remove(tracerList[index].SignalPlot);
			//刷新图表
			Thread thread = new Thread(new ThreadStart(DoRefresh));
			thread.Start();

			//将待删除元素后的元素及控件前移
			for (int i = index; i < tracerList.Count - 1; ++i)
			{
				tracerList[i] = tracerList[i + 1];
				tracerList[i].GroupBox.Location =
					new Point(tracerList[i].GroupBox.Location.X, tracerList[i].GroupBox.Location.Y - iTracerWidgetHeight);
			}

			//删除最后一个Tracer记录
			//tracerList.RemoveAt(tracerList.Count - 1);
			tracerList.Remove(tracerList.Last());

			//删除Tracer控件
			targetContainer.Controls.Remove(groupBox);    //从父控件中删除Trace
		}
		#endregion

		#region 删除和清空Tracer
		//删除Tracer
		public void DeleteTracer(int index)
		{
			GroupBox gbox = tracerList[index].GroupBox;
			//删除图线
			targetChart.Plot.Remove(tracerList[index].SignalPlot);
			//刷新图表
			Thread thread = new Thread(new ThreadStart(DoRefresh));
			thread.Start();

			//将待删除元素后的元素及控件前移
			for (int i = index; i < tracerList.Count - 1; ++i)
			{
				tracerList[i] = tracerList[i + 1];
				tracerList[i].GroupBox.Location =
					new Point(tracerList[i].GroupBox.Location.X, tracerList[i].GroupBox.Location.Y - iTracerWidgetHeight);
			}

			//删除最后一个Tracer记录
			//tracerList.RemoveAt(tracerList.Count - 1);
			tracerList.Remove(tracerList.Last());

			//删除Tracer控件
			targetContainer.Controls.Remove(gbox);    //从父控件中删除Trace
		}

		public void ClearTracer()
		{
			while (tracerList.Count > 0)
				DeleteTracer(tracerList.Count - 1);
		}
		#endregion

		#region 委托刷新图表
		public void DoRefresh()
		{
			FormsPlotRefresh("yyyy");
		}

		//声明事件委托
		public delegate void FormsPlotRefreshEvent(string strMsg);
		public void FormsPlotRefresh(string strMsg)
		{
			try
			{
				if (this.targetChart.InvokeRequired)
				{
					FormsPlotRefreshEvent fPREvent = new FormsPlotRefreshEvent(FormsPlotRefresh);
					this.targetChart.Invoke(fPREvent, new Object[] { strMsg });
				}
				else
				{
					this.targetChart.Refresh(true, true);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
		}
		#endregion
	}
}
