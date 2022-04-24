using MyWaveForms.Entity;
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
	internal class ScopeChartController
	{
		// 色彩代码
		private System.Drawing.Color colorWhite = System.Drawing.ColorTranslator.FromHtml("#ffffff");
		private System.Drawing.Color colorGrey = System.Drawing.ColorTranslator.FromHtml("#f0f0f0");
		private System.Drawing.Color colorLightGrey = System.Drawing.ColorTranslator.FromHtml("#f3f3f3");
		private System.Drawing.Color colorBlack = System.Drawing.ColorTranslator.FromHtml("#000000");
		private System.Drawing.Color colorRayless = System.Drawing.ColorTranslator.FromHtml("#2e3440");
		private System.Drawing.Color colorFiftyGrey = System.Drawing.ColorTranslator.FromHtml("#686D75");

		private System.Drawing.Color colorLightYellow = System.Drawing.ColorTranslator.FromHtml("#EFFB07");
		private System.Drawing.Color colorDarkYellow = System.Drawing.ColorTranslator.FromHtml("#e5c07b");
		private System.Drawing.Color colorLazuli = System.Drawing.ColorTranslator.FromHtml("#5fabea");
		private System.Drawing.Color colorRed = System.Drawing.ColorTranslator.FromHtml("#FF0000");

		/*
		//初始化图表 使用单Y轴数据
		//返回绘制的信号图对象和十字线对象
		public ValueTuple<SignalPlot, Crosshair> InitChart(FormsPlot formsPlot, WaveformData waveformData, int iColorStyle, double dLineWidth, int iLineStyle)
		{
			formsPlot.Plot.Clear();     //清空图表
			SignalPlot signalPlot = formsPlot.Plot.AddSignal(waveformData.DValues);		//添加信号图
			this.SetPlotColorStyle(formsPlot, signalPlot, iColorStyle);
			this.SetLineStyle(formsPlot, signalPlot, iLineStyle);
			this.SetLineWidth(formsPlot, signalPlot, dLineWidth);
			Crosshair crosshair = this.AddCrossHair(formsPlot);		//添加十字准线
			formsPlot.Plot.AxisAutoX();     //X坐标轴自适应
			formsPlot.Plot.AxisAutoY();     //Y坐标轴自适应
			formsPlot.Render();

			return new ValueTuple<SignalPlot, Crosshair>(signalPlot, crosshair);
		}
		*/

		//初始化图表 无数据
		public ValueTuple<SignalPlotXY, Crosshair> InitChart(FormsPlot formsPlot, int iColorStyle, double dLineWidth, int iLineStyle)
		{
			formsPlot.Plot.Clear();     //清空图表
			SignalPlotXY signalPlotXY = formsPlot.Plot.AddSignalXY(new double[100], new double[100]);     //添加信号图
			this.SetPlotColorStyle(formsPlot, signalPlotXY, iColorStyle);     //设置色彩样式
			this.SetLineStyle(formsPlot, signalPlotXY, iLineStyle);     //设置线条样式
			this.SetLineWidth(formsPlot, signalPlotXY, dLineWidth);     //设置线条宽度
			Crosshair crosshair = this.AddCrossHair(formsPlot);     //添加十字准线
			//formsPlot.Plot.AxisAutoX();     //X坐标轴自适应
			//formsPlot.Plot.AxisAutoY();     //Y坐标轴自适应
			formsPlot.Plot.XLabel("s");     //更新X轴单位标签
			formsPlot.Plot.YLabel("V");     //更新Y轴标签
			formsPlot.Render();     //刷新图表

			return new ValueTuple<SignalPlotXY, Crosshair>(signalPlotXY, crosshair);
		}


		//初始化图表 使用X轴及Y轴数据
		//返回绘制的信号图对象和十字线对象
		public ValueTuple<SignalPlotXY, Crosshair> InitChart(FormsPlot formsPlot, ValueTuple<double[], double[]> vt, int iColorStyle, double dLineWidth, int iLineStyle)
		{
			formsPlot.Plot.Clear();     //清空图表
			SignalPlotXY signalPlotXY = formsPlot.Plot.AddSignalXY(vt.Item1, vt.Item2);     //添加信号图
			this.SetPlotColorStyle(formsPlot, signalPlotXY, iColorStyle);	  //设置色彩样式
			this.SetLineStyle(formsPlot, signalPlotXY, iLineStyle);		//设置线条样式
			this.SetLineWidth(formsPlot, signalPlotXY, dLineWidth);		//设置线条宽度
			Crosshair crosshair = this.AddCrossHair(formsPlot);     //添加十字准线
			//formsPlot.Plot.AxisAutoX();     //X坐标轴自适应
			//formsPlot.Plot.AxisAutoY();     //Y坐标轴自适应
			formsPlot.Plot.XLabel("s");     //更新X轴单位标签
			formsPlot.Plot.YLabel("V");		//更新Y轴标签
			formsPlot.Render();		//刷新图表
				
			return new ValueTuple<SignalPlotXY, Crosshair>(signalPlotXY, crosshair);
		}

		// 变更图标色彩模式
		public Boolean SetPlotColorStyle(FormsPlot formsPlot, SignalPlotXY signalPlot, int iColorStyle)
		{
			if (formsPlot == null || signalPlot == null) return false;
			try
			{
				switch (iColorStyle)
				{
					case 0:
						formsPlot.Plot.Style(figureBackground: colorGrey,    //外部图表：灰色   
							dataBackground: colorWhite,     //内部图表：白色
							grid: colorLightGrey,     //网格线：浅灰色
							tick: colorBlack,       //坐标轴：黑色
							axisLabel: colorBlack);     //坐标轴标签：黑色
						signalPlot.Color = colorLazuli;
						formsPlot.Render();
						return true;
					case 1:
						formsPlot.Plot.Style(figureBackground: colorRayless,    //外部图表：低照明  
							dataBackground: colorRayless,     //内部图表：低照明
							grid: colorFiftyGrey,     //网格线：浅灰色
							tick: colorFiftyGrey,       //坐标轴：浅灰色
							axisLabel: colorFiftyGrey);     //坐标轴标签：浅灰色
						signalPlot.Color = colorLightYellow;
						formsPlot.Render();
						return true;
					default:
						return false;
				}
			}
			catch (System.Exception ex)
			{
				throw(ex);
			}
		}

		//变更连线宽度
		public Boolean SetLineWidth(FormsPlot formsPlot, SignalPlotXY signalPlot, double dLineWidth)
		{
			if (formsPlot == null || signalPlot == null) return false;
			try
			{
				signalPlot.LineWidth = dLineWidth;      //更改线宽
				formsPlot.Render();
				return true;
			}
			catch (System.Exception ex)
			{
				throw (ex);
			}
		}

		//变更连线样式
		public Boolean SetLineStyle(FormsPlot formsPlot, SignalPlotXY signalPlot, int iLineStyle)
		{
			if (formsPlot == null || signalPlot == null) return false;
			try
			{
				switch(iLineStyle)
				{
					case 0:
						signalPlot.StepDisplay = false;
						formsPlot.Render();
						return true;
					case 1:
						signalPlot.StepDisplay = true;
						formsPlot.Render();
						return true;
					default:
						return false;
				}
			}
			catch(System.Exception ex)
			{
				throw (ex);
			}
		}

		//添加十字准线
		public Crosshair AddCrossHair(FormsPlot formsPlot, LineStyle lineStyle = LineStyle.Solid, double lineWidth = 0.5)
		{
			try
			{
				// 添加十字准线
				Crosshair crosshair = formsPlot.Plot.AddCrosshair(0.0, 0.0);      //添加十字准线
				crosshair.LineStyle = lineStyle;      //线型设为实线
				crosshair.LineWidth = lineWidth;      //线宽设为0.5
				//this.crosshair.LineColor = isLight ? colorLoghtYellow : colorRed;

				crosshair.VerticalLine.IsVisible = true;    //设为可见
				crosshair.HorizontalLine.IsVisible = true;
				return crosshair;
			}
			catch (System.Exception ex)
			{
				throw (ex);
			}
		}
	}
}
