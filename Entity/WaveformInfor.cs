using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyWaveForms.MyException;

namespace MyWaveForms.Entity
{
	//波形发生器配置信息
	internal class WaveformInfor
	{
		#region 配置对应字符串
		static private string[] strWaveType = {"直流电源 DC",
			"正弦波 Sine",
			"三角波 Triganle",
			"方波 Square",
			"上升波形 RampUp",
			"下降波形 Ramp Down",
			"噪声 Noise",
			"梯形波 Trapezium",
			"正弦电源 Sine Power"};
		static private string[] strFrequencyUnit = { "Hz", "kHz", "MHz" };
		static private string[] strTimeTickUnit = { "s", "ms", "μs", "ns" };
		#endregion
		#region 配置关键字
		//波形类型
		//0 - DC
		//1 - Sine
		//2 - Square
		//3 - Triangle
		//4 - Ramp Up
		//5 - Ramp Down
		//6 - Noise
		//7 - Trapezium
		//8 - SinePower
		private byte bWaveType;
		//频率数值
		private double dFrequencyValue;     
		//频率单位
		//0 - Hz
		//1 - kHz
		//2 - MHz
		private byte bFrequencyUnit;
		//幅值 单位V
		private double dAmplitude;
		//幅值偏移量 单位V 正数表示正向偏移
		private double dOffset;
		//对称量 单位% 范围[0, 1] 大于0.5表示向对称轴右侧偏移
		private double dSymmetry;
		//相位 单位°范围[0, 360]
		private byte bPhase;
		//单周期长度数值
		int iTimeTickValue;
		//单周期长度单位
		//0 - s
		//1 - ms
		//2 - μs
		//3 - ns
		private byte bTimeTickUnit;

		public byte BWaveType { get => bWaveType; set => bWaveType = value; }
		public double DFrequencyValue { get => dFrequencyValue; set => dFrequencyValue = value; }
		public byte BFrequencyUnit { get => bFrequencyUnit; set => bFrequencyUnit = value; }
		public double DAmplitude { get => dAmplitude; set => dAmplitude = value; }
		public double DOffset { get => dOffset; set => dOffset = value; }
		public double DSymmetry { get => dSymmetry; set => dSymmetry = value; }
		public byte BPhase { get => bPhase; set => bPhase = value; }
		public int ITimeTickValue { get => iTimeTickValue; set => iTimeTickValue = value; }
		public byte BTimeTickUnit { get => bTimeTickUnit; set => bTimeTickUnit = value; }
		#endregion
		#region 构造函数
		//默认构造函数
		public WaveformInfor()		
		{
			this.bWaveType = 1;		//正弦波
			this.dFrequencyValue = 1;		//1kHz
			this.bFrequencyUnit = 1;
			this.dAmplitude = 2;	//2V
			this.dOffset = 0;	//无偏移
			this.dSymmetry = 0.5;	//无对称偏转
			this.bPhase = 0;    //无相位偏转

			iTimeTickValue = (int)(1000 / this.dFrequencyValue);    //计算单周期长度
			if (this.dFrequencyValue == 1) this.iTimeTickValue = 1;
			bTimeTickUnit = this.GetTimeTickUnit();     //计算周期长度单位
		}

		//使用实数参数构造
		public WaveformInfor(byte _bWaveType, double _dFrequencyValue, byte _bFrequencyUnit, double _dAmplitude, double _dOffset, double _dSymmetry, byte _bPhase)
		{
			this.bWaveType = _bWaveType;
			this.dFrequencyValue = _dFrequencyValue;
			this.bFrequencyUnit = _bFrequencyUnit;
			this.dAmplitude = _dAmplitude;
			this.dOffset = _dOffset;
			this.dSymmetry = _dSymmetry;
			this.bPhase = _bPhase;

			//计算单周期长度
			if (this.dFrequencyValue <= 1) this.iTimeTickValue = (int)(1.0 / this.dFrequencyValue);
			else iTimeTickValue = (int)(1000 / this.dFrequencyValue);
			//计算周期长度单位  
			bTimeTickUnit = this.GetTimeTickUnit();
		}

		//使用字符串参数构造
		public WaveformInfor(int _bWaveType, string sFrequency, string sAmplitude, string sOffset, string sSymmetry, string sPharse)
		{
			//波形类型
			this.bWaveType = (byte)_bWaveType;
			//抓取频率
			this.dFrequencyValue = GetValueFromString(sFrequency);
			//设置频率单位
			switch ((char)sFrequency[sFrequency.Length - 3])
			{
				case 'H':
					this.bFrequencyUnit = 0;
					break;
				case 'k':
					this.bFrequencyUnit = 1;
					break;
				case 'M':
					this.bFrequencyUnit= 2;
					break;
				default:
					throw new FrequencyParanmeterException("频率参数异常");
			}
			//抓取幅值
			this.dAmplitude = GetValueFromString(sAmplitude);
			//抓取幅值偏移量
			this.dOffset = GetValueFromString(sOffset);
			//抓取对称偏移量
			this.dSymmetry = GetValueFromString(sSymmetry);
			//抓取相位
			this.bPhase = (byte)GetValueFromString(sPharse);
			//计算单周期长度
			if (this.dFrequencyValue <= 1) this.iTimeTickValue = (int)(1.0 / this.dFrequencyValue);
			else iTimeTickValue = (int)(1000 / this.dFrequencyValue);
			//计算周期长度单位  
			bTimeTickUnit = this.GetTimeTickUnit();
		}

		//使用字符串列表构造
		public WaveformInfor(List<string> list)
		{
			//波形类型
			for (int i = 0; i < strWaveType.Length; ++i)
				if (strWaveType[i].Equals(list[0]))
					this.bWaveType = (byte)i;
			//抓取频率
			this.dFrequencyValue = GetValueFromString(list[1]);
			//设置频率单位
			switch ((char)list[1][list[1].Length - 3])		//抓取频率参数倒数第三位
			{	
				case 'k':		//kHz
					this.bFrequencyUnit = 1;
					break;
				case 'M':		//MHz
					this.bFrequencyUnit = 2;
					break;
				default:		//Hz
					this.bFrequencyUnit = 0;
					break;
					//throw new FrequencyParanmeterException("频率参数异常");
			}
			//抓取幅值
			this.dAmplitude = GetValueFromString(list[2]);
			//抓取幅值偏移量
			this.dOffset = GetValueFromString(list[3]);
			//抓取对称偏移量
			this.dSymmetry = GetValueFromString(list[4]) / 100.0;
			//抓取相位
			this.bPhase = (byte)GetValueFromString(list[5]);
			//计算单周期长度
			if (this.dFrequencyValue <= 1) this.iTimeTickValue = (int)(1.0 / this.dFrequencyValue);
			else iTimeTickValue = (int)(1000 / this.dFrequencyValue);
			//计算周期长度单位  
			bTimeTickUnit = this.GetTimeTickUnit();
		}

		#endregion
		//在字符串中抓取实型数值
		private double GetValueFromString(string str)
		{
			//return double.Parse(str);
			StringBuilder res = new StringBuilder();
			foreach (char chr in str)
			{
				if ((chr >= '0' && chr <= '9') || chr == '.' || chr == '-')
					res.Append(chr);
			}
			//MessageBox.Show(res.ToString());
			//if (res.Length == 0) return 0;
			return double.Parse(res.ToString());
		}

		//计算周期长度单位
		private byte GetTimeTickUnit()
		{
			byte res = 0;

			if(this.dFrequencyValue <= 1)
				res = bFrequencyUnit;	//1kHz - 1ms  1 - 1
			else 
				res = (byte)(bFrequencyUnit + 1);    //10MHz - 100ns  2 - 3

			return res;
		}

		//获取字符串格式的周期长度单位
		public string GetTimeTickLabel()
		{
			return strTimeTickUnit[this.bTimeTickUnit];
		}

		//ToString()方法重载
		override public string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("Wave Type: " + this.bWaveType.ToString() + Environment.NewLine);
			sb.Append("Frequency: " + this.dFrequencyValue.ToString() + strFrequencyUnit[this.bFrequencyUnit] + Environment.NewLine);
			sb.Append("Amplitude: " + this.dAmplitude.ToString() + "V" + Environment.NewLine);
			sb.Append("Offset: " + this.dOffset.ToString() + "V" + Environment.NewLine);
			sb.Append("Symmetry: " + (this.dSymmetry * 100).ToString() + "%" + Environment.NewLine);
			sb.Append("Phase: " + this.bPhase.ToString() + "°" + Environment.NewLine);
			sb.Append("Period: " + this.iTimeTickValue.ToString() + GetTimeTickLabel() + Environment.NewLine);
			return sb.ToString();
		}
	}
}
