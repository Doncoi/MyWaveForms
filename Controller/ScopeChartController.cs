using MyWaveForms.Entity;
using MyWaveForms.Generator;
using ScottPlot;
using ScottPlot.Plottable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWaveForms.Controller
{
	//显示样式控制器
	internal class ScopeChartController : BaseChartController
	{
		private FormsPlot targetFormsPlot;

		// 必须指定目标图表
		public ScopeChartController(FormsPlot formsPlot)
		{
			this.targetFormsPlot = formsPlot;
		}

		/// <summary>
		/// 以空数组初始化目标图表
		/// </summary>
		/// <param name="formsPlot">图表对象</param>
		/// <param name="iColorStyle">颜色模式</param>
		/// <param name="dLineWidth">连线宽度</param>
		/// <param name="iLineStyle">连线样式</param>
		/// <returns></returns>
		public ValueTuple<SignalPlotXY, Crosshair> InitScopeChart(int iColorStyle = 0, double dLineWidth = 1, int iLineStyle = 0)
		{
			targetFormsPlot.Plot.Clear();     //清空图表
			SignalPlotXY signalPlotXY = targetFormsPlot.Plot.AddSignalXY(new double[1], new double[1]);     //添加信号图
			this.SetPlotColorStyle(targetFormsPlot, signalPlotXY, iColorStyle);     //设置色彩样式
			this.SetLineStyle(targetFormsPlot, signalPlotXY, iLineStyle);     //设置线条样式
			this.SetLineWidth(targetFormsPlot, signalPlotXY, dLineWidth);     //设置线条宽度
			Crosshair crosshair = this.AddCrossHair(targetFormsPlot);     //添加十字准线
																		  //formsPlot.Plot.AxisAutoX();     //X坐标轴自适应
																		  //formsPlot.Plot.AxisAutoY();     //Y坐标轴自适应
			targetFormsPlot.Plot.XLabel("s");     //更新X轴单位标签
			targetFormsPlot.Plot.YLabel("V");     //更新Y轴标签
			targetFormsPlot.Render();     //刷新图表

			return new ValueTuple<SignalPlotXY, Crosshair>(signalPlotXY, crosshair);
		}

		/// <summary>
		/// 初始化目标图表 使用X轴及Y轴数据
		/// 返回绘制的信号图对象和十字线对象
		/// </summary>
		/// <param name="formsPlot">图表对象</param>
		/// <param name="dataTuple">包装X轴及Y轴数据的ValueTuple对象</param>
		/// <param name="iColorStyle">颜色模式</param>
		/// <param name="dLineWidth">连线宽度</param>
		/// <param name="iLineStyle">连线样式</param>
		/// <returns></returns>
		public ValueTuple<SignalPlotXY, Crosshair> InitScopeChart(ValueTuple<double[], double[]> dataTuple, int iColorStyle = 0, double dLineWidth = 1, int iLineStyle = 0)
		{
			targetFormsPlot.Plot.Clear();     //清空图表
			SignalPlotXY signalPlotXY = targetFormsPlot.Plot.AddSignalXY(dataTuple.Item1, dataTuple.Item2);     //添加信号图
			this.SetPlotColorStyle(targetFormsPlot, signalPlotXY, iColorStyle);	  //设置色彩样式
			this.SetLineStyle(targetFormsPlot, signalPlotXY, iLineStyle);		//设置线条样式
			this.SetLineWidth(targetFormsPlot, signalPlotXY, dLineWidth);		//设置线条宽度
			Crosshair crosshair = this.AddCrossHair(targetFormsPlot);     //添加十字准线
																		  //formsPlot.Plot.AxisAutoX();     //X坐标轴自适应
																		  //formsPlot.Plot.AxisAutoY();     //Y坐标轴自适应
			targetFormsPlot.Plot.XLabel("s");     //更新X轴单位标签
			targetFormsPlot.Plot.YLabel("V");       //更新Y轴标签
			targetFormsPlot.Render();		//刷新图表
				
			return new ValueTuple<SignalPlotXY, Crosshair>(signalPlotXY, crosshair);
		}

		/// <summary>
		/// 设置垂直灵敏度
		/// </summary>
		/// <param name="dVerticalSensitivity"></param>
		public void SetVerticalAxis(double dVerticalSensitivity)
		{
			targetFormsPlot.Plot.YAxis.ManualTickSpacing(dVerticalSensitivity);      //将Tick间距更改为所设灵敏度
			targetFormsPlot.Refresh();
		}

		/// <summary>
		/// 设置时基轴刻度及标签
		/// </summary>
		/// <param name="dTimeBaseValue"></param>
		/// <param name="sTimeBaseUnit"></param>
		public void SetTimeBaseAxis( double dTimeBaseValue, string sTimeBaseUnit)
		{
			switch (sTimeBaseUnit)
			{
				case "us":
					if (dTimeBaseValue < 100)
					{
						targetFormsPlot.Plot.XAxis.ManualTickSpacing(dTimeBaseValue);        //将Tick间距更改为所设灵敏度
						targetFormsPlot.Plot.XAxis.Label(sTimeBaseUnit);     //更改坐标轴标签
					}
					else      // 美观起见，换算为ms显示
					{
						targetFormsPlot.Plot.XAxis.ManualTickSpacing(dTimeBaseValue / 1000);        //将Tick间距更改为所设灵敏度
						targetFormsPlot.Plot.XAxis.Label("ms");     //更改坐标轴标签
					}
					break;
				case "ms":
					if (dTimeBaseValue < 100)
					{
						targetFormsPlot.Plot.XAxis.ManualTickSpacing(dTimeBaseValue);        //将Tick间距更改为所设灵敏度
						targetFormsPlot.Plot.XAxis.Label(sTimeBaseUnit);     //更改坐标轴标签
					}
					else      // 美观起见，换算为ms显示
					{
						targetFormsPlot.Plot.XAxis.ManualTickSpacing(dTimeBaseValue / 1000);        //将Tick间距更改为所设灵敏度
						targetFormsPlot.Plot.XAxis.Label("s");     //更改坐标轴标签
					}
					break;
				case "s":
					targetFormsPlot.Plot.XAxis.ManualTickSpacing(dTimeBaseValue);        //将Tick间距更改为所设灵敏度
					targetFormsPlot.Plot.XAxis.Label(sTimeBaseUnit);     //更改坐标轴标签
					break;
			}
			targetFormsPlot.Refresh();
		}
	}
}
