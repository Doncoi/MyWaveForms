using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWaveForms.Entity
{
	//追踪器配置信息
	internal class TracerInfor
	{
		GroupBox groupBox;
		TextBox textBoxTracerName;
		CheckBox checkBoxVisibility;
		Label labelType;
		Label labelCount;
		ComboBox comboBoxType;
		ComboBox comboBoxCount;
		Button buttonDelete;

		public TracerInfor()
		{

		}

		public TracerInfor(GroupBox groupBox, TextBox textBoxName, CheckBox checkBoxVisibility, Label labelType, Label labelCount, ComboBox comboBoxType, ComboBox comboBoxCount, Button buttonDelete)
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

		public GroupBox GroupBox { get => groupBox; set => groupBox = value; }
		public TextBox TextBoxTracerName { get => textBoxTracerName; set => textBoxTracerName = value; }
		public CheckBox CheckBoxVisibility { get => checkBoxVisibility; set => checkBoxVisibility = value; }
		public Label LabelType { get => labelType; set => labelType = value; }
		public Label LabelCount { get => labelCount; set => labelCount = value; }
		public ComboBox ComboBoxType { get => comboBoxType; set => comboBoxType = value; }
		public ComboBox ComboBoxCount { get => comboBoxCount; set => comboBoxCount = value; }
		public Button ButtonDelete { get => buttonDelete; set => buttonDelete = value; }

		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(this.GroupBox.Name.ToString() + Environment.NewLine);
			stringBuilder.Append(this.GroupBox.Location.ToString() + Environment.NewLine);
			return stringBuilder.ToString();
		}
	}
}
