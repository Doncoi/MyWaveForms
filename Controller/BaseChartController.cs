using ScottPlot;
using ScottPlot.Plottable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWaveForms.Controller
{
	//通用图表样式控制器
	internal class BaseChartController
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

		/// <summary>
		/// 变更图表颜色模式
		/// </summary>
		/// <param name="formsPlot">图表对象</param>
		/// <param name="signalPlot">图线对象</param>
		/// <param name="iColorStyle">颜色模式</param>
		/// <returns></returns>
		public Boolean SetPlotColorStyle(FormsPlot formsPlot, SignalPlotXY signalPlot, int iColorStyle = 0)
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
				throw (ex);
			}
		}

		/// <summary>
		/// 更改连线宽度
		/// </summary>
		/// <param name="formsPlot">图表对象</param>
		/// <param name="signalPlot">图线对象</param>
		/// <param name="dLineWidth">连线宽度</param>
		/// <returns></returns>
		public Boolean SetLineWidth(FormsPlot formsPlot, SignalPlotXY signalPlot, double dLineWidth = 1)
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

		/// <summary>
		/// 更改连线样式
		/// </summary>
		/// <param name="formsPlot">图表对象</param>
		/// <param name="signalPlot">图线对象</param>
		/// <param name="iLineStyle">连线样式</param>
		/// <returns></returns>
		public Boolean SetLineStyle(FormsPlot formsPlot, SignalPlotXY signalPlot, int iLineStyle = 0)
		{
			if (formsPlot == null || signalPlot == null) return false;
			try
			{
				switch (iLineStyle)
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
			catch (System.Exception ex)
			{
				throw (ex);
			}
		}

		/// <summary>
		/// 添加十字准线
		/// </summary>
		/// <param name="formsPlot">图表对象</param>
		/// <param name="lineStyle">十字线线条样式</param>
		/// <param name="lineWidth">十字线线条宽度</param>
		/// <returns></returns>
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

		//在字符串中抓取实型数值
		public static double GetRealFromString(string str)
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

		//获取单位
		public static string GetUnitFromString(string str)
		{
			StringBuilder res_1 = new StringBuilder();
			foreach (char chr in str)
			{
				if ((chr >= '0' && chr <= '9') || chr == '.' || chr == '-')
					res_1.Append(chr);
			}
			int length = res_1.Length;
			StringBuilder res_2 = new StringBuilder();
			for (int i = length; i < str.Length; ++i)
			{
				res_2.Append(str[i]);
			}
			return res_2.ToString();
		}
	}
}
