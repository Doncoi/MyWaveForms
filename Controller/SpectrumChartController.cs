using ScottPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWaveForms.Controller
{
	internal class SpectrumChartController : BaseChartController
	{
		public void ChangeFrequencyAxisLimits(FormsPlot formsPlot, string strMinFrequencyItem, string strMaxFrequencyItem, int iScaleType)
		{
			// 获取幅值下限及单位
			double dMinFrequencyValue = GetRealFromString(strMinFrequencyItem);
			string strMinFrequencyUnit = GetUnitFromString(strMinFrequencyItem);
			// 计算幅值上限及单位
			double dMaxFrequencyValue = GetRealFromString(strMaxFrequencyItem);
			string strMaxFrequencyUnit = GetUnitFromString(strMaxFrequencyItem);

			// 如果上下限单位相同,则不做处理
			// 否则
			if (!strMinFrequencyUnit.Equals(strMaxFrequencyUnit))
			{
				if (strMinFrequencyUnit.Equals("Hz"))
				{
					if (strMaxFrequencyUnit.Equals("kHz"))
					{
						// 转为kHz
						dMinFrequencyValue /= 1000;
					}
					else if (strMaxFrequencyUnit.Equals("MHz"))
					{
						// 从0开始显示
						dMinFrequencyValue = 0;
					}
				}
				else if (strMinFrequencyUnit.Equals("kHz"))
				{
					if (strMaxFrequencyUnit.Equals("MHz"))
					{
						// 转为MHz
						dMinFrequencyValue /= 1000;
					}
				}
			}

			// 更改显示范围
			// 以线性模式放缩
			if (iScaleType == 0)
			{
				formsPlot.Plot.SetAxisLimitsX(dMinFrequencyValue, dMaxFrequencyValue);
			}
			// todo 以对数模式放缩
			else
			{
				// formsPlotSpectrum.Plot.SetAxisLimitsX(dMinFrequencyValue, Math.Log10(dMaxFrequencyValue));
			}

			// 刷新图表
			formsPlot.Refresh();
		}


		// 更改频率坐标轴标签
		public void ChangeFrequencyAxisLabel(FormsPlot formsPlot, string strTopItem)
		{
			// 获取单位
			string strTopUnit = GetUnitFromString(strTopItem);
			// 更新坐标轴标签
			formsPlot.Plot.XLabel(strTopUnit);
			// 刷新图表
			formsPlot.Refresh();
		}

		// 更改幅值坐标轴上下限
		public void ChangeMagnitudeAxisLimits(FormsPlot formsPlot, string strMagnitudeTopItem, string strMagnitudeRangeItem)
		{
			// 获取幅值上限
			double dMaxMagnitude = GetRealFromString(strMagnitudeTopItem);
			// 计算幅值下限
			double dMinMagnitude = dMaxMagnitude - GetRealFromString(strMagnitudeRangeItem);
			// 更改显示范围
			formsPlot.Plot.SetAxisLimitsY(dMinMagnitude, dMaxMagnitude);
			// 刷新图表
			formsPlot.Refresh();
		}

		// 更改幅值坐标轴标签
		public void ChangeMagnitudeAxisLabel(FormsPlot formsPlot, string strTopItem)
		{
			// 获取单位
			string strTopUnit = GetUnitFromString(strTopItem);
			// 更新坐标轴标签
			formsPlot.Plot.YLabel(strTopUnit);
			// 刷新图表
			formsPlot.Refresh();
		}
	}
}
