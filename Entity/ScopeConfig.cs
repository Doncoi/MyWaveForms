using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWaveForms.Entity
{
	internal class ScopeConfig : BaseConfig
	{
		#region 配置项字符串
		//耦合方式
		string[] strCoupledType = 
		{
			"DC",
			"AC"
		};
		//触发方式
		string[] strTriggerType =
		{
			"上升沿",
			"下降沿",
			"同时触发"
		};
		//时基单位
		string[] strTimeBaseUnit =
		{
			"us",
			"ms"
		};
		#endregion
		#region 配置项关键字
		//耦合方式
		//0 - DC
		//1 - AC
		private byte bCoupledType;
		//触发方式
		//0 - rising edge
		//1 - falling edge
		//2 - both
		private byte bTriggerType;
		//垂直灵敏度
		private double dVerticalSensitivity;
		//水平灵敏度（时基）值
		private double dTimeBaseValue;
		//水平灵敏度（时基）单位
		//0 - us
		//1 - ms
		private byte bTimeBaseUnit;

		public double DVerticalSensitivity { get => dVerticalSensitivity; set => dVerticalSensitivity = value; }
		public double DTimeBaseValue { get => dTimeBaseValue; set => dTimeBaseValue = value; }
		public byte BTimeBaseUnit { get => bTimeBaseUnit; set => bTimeBaseUnit = value; }
		public byte BCoupledType { get => bCoupledType; set => bCoupledType = value; }
		public byte BTriggerType { get => bTriggerType; set => bTriggerType = value; }

		#endregion
		#region 构造函数
		public ScopeConfig() { }

		public ScopeConfig(byte byteCoupledType, byte byteTriggerType, double dVerticalSensitivity, double dTimeBaseValue, byte bTimeBaseUnit)
		{
			this.bCoupledType = byteCoupledType;
			this.bTriggerType = byteTriggerType;
			this.dVerticalSensitivity = dVerticalSensitivity;
			this.dTimeBaseValue = dTimeBaseValue;
			this.bTimeBaseUnit = bTimeBaseUnit;
		}

		public ScopeConfig(List<String> list)
		{
			//耦合类型
			for (int i = 0; i < strCoupledType.Length; ++i)
				if (strCoupledType[i].Equals(list[0]))
					this.bCoupledType = (byte)i;
			//触发类型
			for (int i = 0; i < strTriggerType.Length; ++i)
				if (strTriggerType[i].Equals(list[1]))
					this.bTriggerType = (byte)i;
			//垂直灵敏度
			this.dVerticalSensitivity = GetRealFromString(list[2]);
			//水平灵敏度
			this.dTimeBaseValue = GetRealFromString(list[3]);
			switch((char) list[3][list[3].Length - 2])  //抓取倒数第2位
			{
				case 'u':
					this.bTimeBaseUnit = 0;
					break;
				case 'm':
					this.bTimeBaseUnit = 1;
					break;
				default:
					this.bTimeBaseUnit = 1;
					break;
			}
		}

		#endregion

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("Coupled Type: " + strCoupledType[this.bCoupledType] + Environment.NewLine);
			sb.Append("Trigger Type: " + strTriggerType[this.bTriggerType] + Environment.NewLine);
			sb.Append("Vertical Sensitivity: " + this.dVerticalSensitivity.ToString() + "V" + Environment.NewLine);
			//MessageBox.Show(res.ToString());
			sb.Append("Time : " + this.DTimeBaseValue.ToString() + strTimeBaseUnit[this.bTimeBaseUnit] + Environment.NewLine);
			return sb.ToString();
		}
	}
}
