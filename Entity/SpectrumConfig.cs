using MyWaveForms.MyException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWaveForms.Entity
{
	internal class SpectrumConfig : BaseConfig
	{ 
		#region 配置项字符串
		#region 频谱设置
		//频率单位
		string[] strFrequencyUnit =
		{
			"Hz",
			"kHZ",
			"MHz"
		};
		//坐标轴放缩
		string[] strScale =
		{
			"线性",
			"对数",
		};
		//分析算法
		string[] strAlgorithm =
		{
			"FFT",
			"CZT"
		};
		#endregion
		#region 振幅设置
		//振幅单位
		string[] strMagnitudeUnit =
		{
			"Vpeak(V)",
			"Vrms",
			"dBV",
			"dBu",
			"dB"
		};
		//量程单位
		string[] strRangeUnit =
		{
			"V",
			"mV",
			"uV",
			"Vrms",
			"mVrms",
			"uVrms",
			"dBV"
		};
		//参考电压单位
		string[] strReferenceUnit =
		{
			"kV",
			"V",
			"mV",
			"uV"
		};
		#endregion
		#endregion
		#region 配置项关键字
		#region 频谱设置
		//最小频率
		private double dFrequencyStartValue;
		//最小频率单位
		//0 - Hz
		//1 - kHz
		//2 - MHz
		private byte bFrequencyStartUnit;
		//最大频率
		private double dFrequencyStopValue;
		//最大频率单位
		//0 - Hz
		//1 - kHz
		//2 - MHz
		private byte bFrequencyStopUnit;
		//频率箱数量
		//-1 - Default
		private int iFrequencyBoxCount;
		//坐标轴放缩类型
		private byte bScaleType;
		//分析算法
		private byte bAlgorithmType;
		#endregion
		#region 振幅设置
		//振幅单位
		//0 - Vpeak(V)
		//1 - Vrms
		//2 - dBV
		//3 - dBu
		//4 - dB
		private byte bMagnitudeUnit;
		//显示上限
		private double dMagnitudeTopValue;
		private byte bMagnitudeTopUnit;
		//显示范围
		private double dMagnitudeRangeValue;
		private byte bMagnitudeRangeUnit;
		//参考电压值
		private double dReferenceValue;
		//参考电压单位
		//0 - kV
		//1 - V
		//2 - mV
		//3 - uV
		private byte bReferenceUnit;
		#endregion
		#region 信道设置
		//偏移
		private double dChannelOffset;
		//信道量程
		//-1 - Auto
		private double dChannelRange;
		//信道衰减
		private double dChannelAttenuation;
		#endregion
		#endregion
		#region Get/Set
		public double DFrequencyStartValue { get => dFrequencyStartValue; set => dFrequencyStartValue = value; }
		public byte BFrequencyStartUnit { get => bFrequencyStartUnit; set => bFrequencyStartUnit = value; }
		public double DFrequencyStopValue { get => dFrequencyStopValue; set => dFrequencyStopValue = value; }
		public byte BFrequencyStopUnit { get => bFrequencyStopUnit; set => bFrequencyStopUnit = value; }
		public int IFrequencyBoxCount { get => iFrequencyBoxCount; set => iFrequencyBoxCount = value; }
		public byte BScaleType { get => bScaleType; set => bScaleType = value; }
		public byte BAlgorithmType { get => bAlgorithmType; set => bAlgorithmType = value; }
		public byte BMagnitudeUnit { get => bMagnitudeUnit; set => bMagnitudeUnit = value; }
		public double DMagnitudeTop { get => dMagnitudeTopValue; set => dMagnitudeTopValue = value; }
		public double DMagnitudeRange { get => dMagnitudeRangeValue; set => dMagnitudeRangeValue = value; }
		public double DReferenceValue { get => dReferenceValue; set => dReferenceValue = value; }
		public byte BReferenceUnit { get => bReferenceUnit; set => bReferenceUnit = value; }
		public double DChannelOffset { get => dChannelOffset; set => dChannelOffset = value; }
		public double DChannelRange { get => dChannelRange; set => dChannelRange = value; }
		public double DChannelAttenuation { get => dChannelAttenuation; set => dChannelAttenuation = value; }
		#endregion
		#region 构造函数
		public SpectrumConfig(double dFrequencyStartValue = 0, byte bFrequencyStartUnit = 0,
			double dFrequencyStopValue = 1, byte bFrequencyStopUnit = 3,
			int iFrequencyBoxCount = -1, byte bScaleType = 0,
			byte bAlgorithmType = 0, byte bMagnitudeUnit = 0,
			double dMagnitudeTopValue = 20, byte bMagnitudeTopUnit = 0,
			double dMagnitudeRangeValue = 200, byte bMagnitudeRangeUnit = 0,
			double dReferenceValue = 0.05, byte bReferenceUnit = 1, 
			double dChannelOffset = 0, double dChannelRange = -1, 
			double dChannelAttenuation = 1)
		{
			// 频谱设置
			this.dFrequencyStartValue = dFrequencyStartValue;
			this.bFrequencyStartUnit = bFrequencyStartUnit;
			this.dFrequencyStopValue = dFrequencyStopValue;
			this.bFrequencyStopUnit = bFrequencyStopUnit;
			this.iFrequencyBoxCount = iFrequencyBoxCount;
			this.bScaleType = bScaleType;
			this.bAlgorithmType = bAlgorithmType;
			// 振幅设置
			this.bMagnitudeUnit = bMagnitudeUnit;
			this.dMagnitudeTopValue = dMagnitudeTopValue;
			this.bMagnitudeTopUnit = bMagnitudeTopUnit;
			this.dMagnitudeRangeValue = dMagnitudeRangeValue;
			this.bMagnitudeRangeUnit = bMagnitudeRangeUnit;
			this.dReferenceValue = dReferenceValue;
			// 信道设置
			this.bReferenceUnit = bReferenceUnit;
			this.dChannelOffset = dChannelOffset;
			this.dChannelRange = dChannelRange;
			this.dChannelAttenuation = dChannelAttenuation;
		}

		public SpectrumConfig(List<string> list)
		{
			string str;
			#region 频谱设置
			//获取最小频率 0
			this.dFrequencyStartValue = GetRealFromString(list[0]);
			str = GetUnitFromString(list[0]);
			for (int i = 0; i < strFrequencyUnit.Length; ++i)
				if (strFrequencyUnit[i].Equals(str))
					this.bFrequencyStartUnit = (byte)i;
			//获取最大频率 1
			this.dFrequencyStopValue = GetRealFromString(list[1]);
			str = GetUnitFromString(list[1]);
			for (int i = 0; i < strFrequencyUnit.Length; ++i)
				if (strFrequencyUnit[i].Equals(str))
					this.bFrequencyStopUnit = (byte)i;
			//获取频率箱点数 2
			if ((char)list[2][0] == 'D')
				this.iFrequencyBoxCount = -1;
			else
				this.iFrequencyBoxCount = (int)GetRealFromString(list[2]);
			//获取坐标轴放缩类型 3
			for (int i = 0; i < strScale.Length; ++i)
				if (strScale[i].Equals(list[3]))
					this.bScaleType = (byte)i;
			//获取变换算法类型 4
			for (int i = 0; i < strAlgorithm.Length; ++i)
				if (strAlgorithm[i].Equals(list[4]))
					this.bAlgorithmType = (byte)i;
			#endregion
			#region 幅值设置
			// 幅值单位设置 5
			for (int i = 0; i < strMagnitudeUnit.Length; ++i)
				if (strMagnitudeUnit[i].Equals(list[5]))
					this.bMagnitudeUnit = (byte)i;
			// 最大幅值设置 6
			this.dMagnitudeTopValue = GetRealFromString(list[6]);
			// 最大幅值单位 6
			str = GetUnitFromString(list[6]);
			for (int i = 0; i < strRangeUnit.Length; ++i)
				if (strRangeUnit[i].Equals(str))
					this.bMagnitudeTopUnit = (byte)i;
			// 幅值范围设置 7
			this.dMagnitudeRangeValue = GetRealFromString(list[7]);
			// 幅值范围单位 7
			str = GetUnitFromString(list[7]);
			for (int i = 0; i < strRangeUnit.Length; ++i)
				if (strRangeUnit[i].Equals(str))
					this.bMagnitudeRangeUnit = (byte)i;
			// 参考电压设置 8
			this.dReferenceValue = GetRealFromString(list[8]);
			// 参考电压单位
			str = GetUnitFromString(list[8]);
			for (int i = 0; i < strReferenceUnit.Length; ++i)
				if (strReferenceUnit[i].Equals(str))
					this.bReferenceUnit = (byte)i;
			#endregion
			#region 信道设置 
			//信道偏移 9
			this.dChannelOffset = GetRealFromString(list[9]);
			//信道量程 10
			if ((char)list[10][0] == 'A')
				this.dChannelRange = -1;
			else
				this.dChannelRange = GetRealFromString(list[10]);
			//信道衰减 11
			this.dChannelAttenuation = GetRealFromString(list[11]);
			#endregion
		}
		#endregion

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("Spectrum Settings" + Environment.NewLine);
			sb.Append("Start Frequency: " + this.dFrequencyStartValue.ToString() + 
				this.strFrequencyUnit[this.bFrequencyStartUnit] + Environment.NewLine);
			sb.Append("Stop Frequency: " + this.dFrequencyStopValue.ToString() +
				this.strFrequencyUnit[this.bFrequencyStopUnit] + Environment.NewLine);
			sb.Append("Box Count: " + this.iFrequencyBoxCount.ToString() + Environment.NewLine);
			sb.Append("Scale Type: " + this.strScale[this.bScaleType] + Environment.NewLine);
			sb.Append("Algorithm: " + this.strAlgorithm[this.bAlgorithmType] + Environment.NewLine);
			sb.Append("Magnitude Settings" + Environment.NewLine);
			sb.Append("Magnitude Unit: " + this.strMagnitudeUnit[this.bMagnitudeUnit] + Environment.NewLine);
			sb.Append("Top: " + this.dMagnitudeTopValue.ToString() + 
				strRangeUnit[this.bMagnitudeTopUnit] + Environment.NewLine);
			sb.Append("Range: " + this.dMagnitudeRangeValue.ToString() +
				strRangeUnit[this.bMagnitudeRangeUnit] + Environment.NewLine);
			sb.Append("Reference: " + this.dReferenceValue.ToString() +
				this.strReferenceUnit[this.bReferenceUnit] + Environment.NewLine);
			sb.Append("Channel Settings" + Environment.NewLine);
			sb.Append("Channel Offset: " + this.dChannelOffset.ToString() + "V" + Environment.NewLine);
			sb.Append("Channel Range: " + this.dChannelRange.ToString() + "V" + Environment.NewLine) ;
			sb.Append("Channel Attenuation: " + this.dChannelAttenuation.ToString() + "X" + Environment.NewLine);
			return sb.ToString();
		}
	}
}
