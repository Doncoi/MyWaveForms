using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWaveForms.Generator
{
	//用于生成控件，配合TracerController快速生成新的Tracer
	internal class WidgetGenerator
	{
		//获取GroupBox对象
		public GroupBox GetGroupBox(string sName, string sText, int iWidth, int iHeight, int iPositionX, int iPositionY)
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
		public TextBox GetTextBox(string sName, string sText, int iWidth, int iHeight, int iPositionX, int iPositionY)
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
		public CheckBox GetCheckBox(string sName, string sText, int iWidth, int iHeight, int iPositionX, int iPositionY, EventHandler e, bool bChecked)
		{
			CheckBox cbox = new CheckBox();
			cbox.Name = sName;      //设置名称及文本
			cbox.Text = sText;
			cbox.Width = iWidth;    //设置大小
			cbox.Height = iHeight;
			cbox.Location = new Point(iPositionX, iPositionY);      //设置位置
			cbox.Checked = bChecked;
			cbox.CheckedChanged += new System.EventHandler(e);
			return cbox;
		}

		//获取Button对象
		public Button GetButton(string sName, string sText, int iWidth, int iHeight, int iPositionX, int iPositionY, EventHandler e)
		{
			Button button = new Button();
			button.Name = sName;      //设置名称及文本
			button.Text = sText;
			button.Width = iWidth;    //设置大小
			button.Height = iHeight;
			button.Location = new Point(iPositionX, iPositionY);      //设置位置
			button.BackColor = Color.Tomato;     //添加背景色
			button.FlatStyle = FlatStyle.Flat;      //削弱边框样式
			button.FlatAppearance.BorderColor = Color.Tomato;   //设置边框颜色
			button.Click += new System.EventHandler(e);      //绑定删除事件
			return button;
		}

		//获取Label对象
		public Label GetLabel(string sName, string sText, int iPositionX, int iPositionY)
		{
			Label label = new Label();
			label.Name = sName;      //设置名称及文本
			label.Text = sText;
			label.Location = new Point(iPositionX, iPositionY);      //设置位置
			return label;
		}

		//获取ComboBox对象
		public ComboBox GetComboBox(string sName, int iWidth, int iHeight, int iPositionX, int iPositionY, string[] strItems, int iDefaultSelectIndex)
		{
			ComboBox cbox = new ComboBox();     //新建GroupBox
			cbox.Name = sName;      //设置名称及文本
			cbox.Width = iWidth;    //设置大小
			cbox.Height = iHeight;
			cbox.Location = new Point(iPositionX, iPositionY);      //设置位置
			foreach (string s in strItems)      //加入选项
				cbox.Items.Add(s);
			cbox.SelectedIndex = iDefaultSelectIndex;		//设置默认选项
			cbox.DropDownStyle = ComboBoxStyle.DropDownList;      //禁用选项变更
			return cbox;
		}
	}
}
