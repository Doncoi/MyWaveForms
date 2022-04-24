using MyWaveForms.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWaveForms.Controller
{
	internal class SpectrumTracerController
	{
		#region 常量
		//ComboBoxType Items字符串数组
		string[] strTracerType = { 
			"样本",
			"连续保持峰值",
			"保持峰值",
			"连续保持最小值",
			"保持最小值",
			"线性RMS平均",
			"线性dB平均",
			"指数RMS平均",
			"指数dB平均"};
		//ComboBoxCount Items字符串数组
		string[] strTracerCount = {
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
		//同时存在的最大Tracer数量
		private byte MAXSIZE = 10;

		//Tracer控件尺寸
		//private const int iTracerWidgetWidth = 395;		
		//private const int iTracerWidgetHeight = 260;
		//to-do 无奈之举，缩放不同，只能直接从父控件获取大小
		private const int iTracerWidgetWidth = 198;
		private const int iTracerWidgetHeight = 100;

		//第一个Tracer的GroupBox的Location，也是后续添加的基准点
		//private const int iFirstLocationX = 0;
		//private const int iFirstLocationY = 520;
		//to-do 无奈之举，缩放不同，只能直接从父控件获取位置
		private const int iFirstLocationX = 0;
		private const int iFirstLocationY = 260 + 40;
		#endregion
		//追踪器列表
		private List<TracerInfor> tracerList = new List<TracerInfor>();

		internal List<TracerInfor> TracerList { get => tracerList; set => tracerList = value; }

		//添加追踪器
		public bool AddTracer(Panel targetContainer)
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
			int iPositionY = iFirstLocationY + iTracerWidgetHeight * iIndex - targetContainer.VerticalScroll.Value;
			//绘制新的Tracer，并获取其信息类
			TracerInfor tracerInfor = DrawTracerWidget(targetContainer, iIndex, iPositionX, iPositionY);
			tracerList.Add(tracerInfor);        //添加新Tracer至列表

			return true;
		}

		//添加Tracer相关控件
		private TracerInfor DrawTracerWidget(Panel targetContainer, int iIndex, int iPositionX, int iPositionY)
		{
			TracerInfor tracerInfor = new TracerInfor();
			//设定GroupBox
			GroupBox gbox = GetGroupBox("groupBoxTracer_" + iIndex.ToString(), 
				"追踪器 " + (iIndex + 1).ToString(),
				iTracerWidgetWidth, iTracerWidgetHeight, iPositionX, iPositionY);
			tracerInfor.GroupBox = gbox;
			targetContainer.Controls.Add(gbox);		//添加至容器

			//设定TextBox
			TextBox tbox = GetTextBox("textBoxTracer_" + iIndex.ToString(), 
				"Tracer" + (iIndex + 1).ToString(),
				110, 30, 10, 20);
			tracerInfor.TextBoxTracerName = tbox;
			gbox.Controls.Add(tbox);	//添加至容器，注意gbox外所有控件都添加到gbox
			tbox.BringToFront();    //显示在最上层

			//设定CheckBox
			CheckBox cbox = GetCheckBox("checkBoxVisibilityTracer_" + iIndex.ToString(), 
				"可见",
				50, 30, 125, 15, true);
			tracerInfor.CheckBoxVisibility = cbox;
			gbox.Controls.Add(cbox);    //添加至容器，注意gbox外所有控件都添加到gbox
			cbox.BringToFront();    //显示在最上层

			// 设定Button
			Button button = GetButton("buttonDeleteTracer_" + iIndex.ToString(),
				"×",
				20, 20, 170, 20);
			tracerInfor.ButtonDelete = button;
			gbox.Controls.Add(button);    //添加至容器，注意gbox外所有控件都添加到gbox
			button.BringToFront();    //显示在最上层

			// 设定Label1  “类型”
			Label label1 = GetLabel("labelTypeTracer_" + iIndex.ToString(), "类型", 10, 50);
			tracerInfor.LabelType = label1;
			gbox.Controls.Add(label1);    //添加至容器，注意gbox外所有控件都添加到gbox
			label1.BringToFront();    //显示在最上层
			// 设定Label2  “计数”
			Label label2 = GetLabel("labelTypeTracer_" + iIndex.ToString(), "计数", 10, 75);
			tracerInfor.LabelCount = label2;
			gbox.Controls.Add(label2);    //添加至容器，注意gbox外所有控件都添加到gbox
			label2.BringToFront();    //显示在最上层

			// 设定ComboBox1  “类型”
			ComboBox comboBox1 = GetComboBox("labelTypeTracer_" + iIndex.ToString(), 140, 30, 45, 45, strTracerType);
			tracerInfor.ComboBoxType = comboBox1;
			gbox.Controls.Add(comboBox1);    //添加至容器，注意gbox外所有控件都添加到gbox
			comboBox1.BringToFront();    //显示在最上层
										 // 设定ComboBox2  “计数”
			ComboBox comboBox2 = GetComboBox("labelTypeTracer_" + iIndex.ToString(), 140, 30, 45, 70, strTracerCount);
			tracerInfor.ComboBoxCount = comboBox2;
			gbox.Controls.Add(comboBox2);    //添加至容器，注意gbox外所有控件都添加到gbox
			comboBox2.BringToFront();    //显示在最上层						  

			return tracerInfor;
		}

		//获取GroupBox对象
		private GroupBox GetGroupBox(string sName, string sText, int iWidth, int iHeight, int iPositionX, int iPositionY)
		{
			GroupBox gbox = new GroupBox();     //新建GroupBox
			gbox.Name = sName;      //设置名称及文本
			gbox.Text = sText;
			gbox.Width = iWidth;    //设置大小
			gbox.Height = iHeight;
			gbox.Location = new Point(iPositionX, iPositionY);      //设置位置
			return gbox;
		}

		//获取TextBox对象
		private TextBox GetTextBox(string sName, string sText, int iWidth, int iHeight, int iPositionX, int iPositionY)
		{
			TextBox tbox = new TextBox();
			tbox.Name = sName;      //设置名称及文本
			tbox.Text = sText;
			tbox.Width = iWidth;    //设置大小
			tbox.Height = iHeight;
			tbox.Location = new Point(iPositionX, iPositionY);      //设置位置
			return tbox;
		}

		//获取CheckBox对象
		private CheckBox GetCheckBox(string sName, string sText, int iWidth, int iHeight, int iPositionX, int iPositionY, bool bChecked)
		{
			CheckBox cbox = new CheckBox();
			cbox.Name = sName;      //设置名称及文本
			cbox.Text = sText;
			cbox.Width = iWidth;    //设置大小
			cbox.Height = iHeight;
			cbox.Location = new Point(iPositionX, iPositionY);      //设置位置
			cbox.Checked = bChecked;
			return cbox;
		}

		//获取Button对象
		private Button GetButton(string sName, string sText, int iWidth, int iHeight, int iPositionX, int iPositionY)
		{
			Button button = new Button();
			button.Name = sName;      //设置名称及文本
			button.Text = sText;
			button.Width = iWidth;    //设置大小
			button.Height = iHeight;
			button.Location = new Point(iPositionX, iPositionY);      //设置位置
			button.BackColor = Color.Tomato;	 //添加背景色
			button.FlatStyle = FlatStyle.Flat;		//削弱边框样式
			button.FlatAppearance.BorderColor = Color.Tomato;   //设置边框颜色
			button.Click += new System.EventHandler(this.DeleteTrace);		//绑定删除事件
			return button;
		}

		//获取Label对象
		private Label GetLabel(string sName, string sText, int iPositionX, int iPositionY)
		{
			Label label = new Label();
			label.Name = sName;      //设置名称及文本
			label.Text = sText;
			label.Location = new Point(iPositionX, iPositionY);      //设置位置
			return label;
		}

		//获取ComboBox对象
		private ComboBox GetComboBox(string sName, int iWidth, int iHeight, int iPositionX, int iPositionY, string[] strItems)
		{
			ComboBox cbox = new ComboBox();     //新建GroupBox
			cbox.Name = sName;      //设置名称及文本
			cbox.Width = iWidth;    //设置大小
			cbox.Height = iHeight;
			cbox.Location = new Point(iPositionX, iPositionY);      //设置位置
			foreach (string s in strItems)		//加入选项
				cbox.Items.Add(s);
			cbox.DropDownStyle = ComboBoxStyle.DropDownList;      //禁用选项变更
			return cbox;
		}

		//删除Tracaer
		public void DeleteTrace(object sender, EventArgs e)
		{
			/*
			string sName = ((Button)sender).Name.ToString();	//获取控件名称
			int iIndex = sName[sName.Length - 1] - 48;		//解析控件所属Tracer的index
			MessageBox.Show(sName + " " + iIndex);
			*/

			Button button = (Button)sender;     //获取发送者
			GroupBox groupBox = (GroupBox)button.Parent;    //获取Tracer GroupBox
			Panel panel = (Panel)groupBox.Parent;    //获取父容器Pannel

			//删除TracerInfor
			int index;
			for (index = 0; index < tracerList.Count; ++ index)	  //遍历list以获取index
				if(tracerList[index].GroupBox == groupBox)	  //匹配button以确认位置
					break;
			//MessageBox.Show(index.ToString());
			//将待删除元素后的元素及控件前移
			//to-do 完善这部分代码
			for(int i = index; i < tracerList.Count - 1; ++ i)
			{
				tracerList[i] = tracerList[i + 1];
				tracerList[i].GroupBox.Location =
					new Point(tracerList[i].GroupBox.Location.X, tracerList[i].GroupBox.Location.Y - iTracerWidgetHeight);
			}

			//删除最后一个Tracer记录
			//tracerList.RemoveAt(tracerList.Count - 1);
			tracerList.Remove(tracerList.Last());

			//删除Tracer控件
			panel.Controls.Remove(groupBox);    //从父控件中删除Trace
		}
	}
}
