using ScottPlot.Plottable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWaveForms.Entity
{
	internal class TracerInfor
	{
		protected GroupBox groupBox;      //主容器
		protected TextBox textBoxTracerName;    //名牌
		protected CheckBox checkBoxVisibility;  //可见性选择框
		protected Label labelType;  //tracer任务类型标签
		protected ComboBox comboBoxType;        //tracer任务类型ComboBox
		protected Button buttonDelete;  //删除tracer按钮
		protected SignalPlotXY signalPlot;        //图线
		protected double[] dXValues;
		protected double[] dYValues;

		public GroupBox GroupBox { get => groupBox; set => groupBox = value; }
		public TextBox TextBoxTracerName { get => textBoxTracerName; set => textBoxTracerName = value; }
		public CheckBox CheckBoxVisibility { get => checkBoxVisibility; set => checkBoxVisibility = value; }
		public Label LabelType { get => labelType; set => labelType = value; }
		public ComboBox ComboBoxType { get => comboBoxType; set => comboBoxType = value; }
		public Button ButtonDelete { get => buttonDelete; set => buttonDelete = value; }
		public SignalPlotXY SignalPlot { get => signalPlot; set => signalPlot = value; }
		public double[] DXValues { get => dXValues; set => dXValues = value; }
		public double[] DYValues { get => dYValues; set => dYValues = value; }

		public TracerInfor()
		{

		}

		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(this.groupBox.Name.ToString() + Environment.NewLine);
			stringBuilder.Append(this.groupBox.Location.ToString() + Environment.NewLine);
			return stringBuilder.ToString();
		}
	}

	internal class MeterTracerInfor : TracerInfor
	{
		Label labelCurrentText;		//当前值
		Label labelCurrentValue;
		Label labelMaxText;		//最大值
		Label labelMaxValue;
		Label labelMinText;		//最小值
		Label labelMinValue;

		public MeterTracerInfor()
		{

		}
		public Label LabelCurrentText { get => labelCurrentText; set => labelCurrentText = value; }
		public Label LabelCurrentValue { get => labelCurrentValue; set => labelCurrentValue = value; }
		public Label LabelMaxText { get => labelMaxText; set => labelMaxText = value; }
		public Label LabelMaxValue { get => labelMaxValue; set => labelMaxValue = value; }
		public Label LabelMinText { get => labelMinText; set => labelMinText = value; }
		public Label LabelMinValue { get => labelMinValue; set => labelMinValue = value; }

		public override string ToString()
		{
			return base.ToString();
		}
	}

	internal class SpectrumTracerInfor : TracerInfor
	{
		Label labelCount;		//计算点数标签
		ComboBox comboBoxCount;		 //计算点数ComboBox
		
		public SpectrumTracerInfor()
		{

		}

		public SpectrumTracerInfor(GroupBox groupBox, TextBox textBoxName, CheckBox checkBoxVisibility, Label labelType, Label labelCount, ComboBox comboBoxType, ComboBox comboBoxCount, Button buttonDelete)
		{
			this.groupBox = groupBox;
			this.textBoxTracerName = textBoxName;
			this.checkBoxVisibility = checkBoxVisibility;
			this.labelType = labelType;
			this.labelCount = labelCount;
			this.comboBoxType = comboBoxType;
			this.comboBoxCount = comboBoxCount;
			this.buttonDelete = buttonDelete;
		}

		public Label LabelCount { get => labelCount; set => labelCount = value; }
		public ComboBox ComboBoxCount { get => comboBoxCount; set => comboBoxCount = value; }

		public override string ToString()
		{
			return base.ToString();
		}
	}
}
