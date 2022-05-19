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
	internal class WavegenChartController : BaseChartController
	{
		//波形数据产生器
		private WaveformDataGenerator waveDataGenerator;

		public WavegenChartController()
		{
			//创建波形数据产生器实例
			this.waveDataGenerator = new WaveformDataGenerator();
		}

		//使用外部数据加载图表
		public SignalPlotXY AddWaveforms(FormsPlot formsPlot, ValueTuple<double[], double[]>  vt, WaveformConfig node)
		{
			//清空绘图区
			formsPlot.Plot.Clear();
			//绘制图像
			SignalPlotXY sp = formsPlot.Plot.AddSignalXY(vt.Item1, vt.Item2);
			//更新X轴单位标签
			formsPlot.Plot.XLabel(node.GetTimeTickLabel());
			//刷新绘图区
			formsPlot.Render();

			return sp;
		}

		//使用来自WaveformDataGenerator的数据加载图表
		public SignalPlotXY AddWaveforms(FormsPlot formsPlot, WaveformConfig node, int size = 1000)
		{
			//清空绘图区
			formsPlot.Plot.Clear();
			//获取X轴与Y轴数据
			ValueTuple<double[], double[]> vt = GetWaveData(size, node);
			//绘制图像
			SignalPlotXY sp = formsPlot.Plot.AddSignalXY(vt.Item1, vt.Item2);
			//更新X轴单位标签
			formsPlot.Plot.XLabel(node.GetTimeTickLabel());
			//刷新绘图区
			formsPlot.Render();

			return sp;
		}

		public ValueTuple<double[], double[]> GetWaveData(int size,WaveformConfig node)
		{
			//x标定数组
			double[] dXValues = new double[size];
			//y标定数组
			double[] dYValues = new double[size];
			//x标定数组步长 表示相邻两点在x轴上的间隔
			double dXStep = (double)node.ITimeTickValue / (double)(size - 1);
			//MessageBox.Show(node.ToString() + "\n" + dXStep.ToString());
			for (int i = 1; i < size; i++)
				dXValues[i] = dXValues[i - 1] + dXStep;

			//MessageBox.Show(node.BWaveType.ToString());
			switch (node.BWaveType)
			{
				case 0:
					dYValues = this.waveDataGenerator.GenerateDCData(size, node);
					break;
				case 1:
					dYValues = this.waveDataGenerator.GenerateSineData(size, node);
					break;
				case 2:
					dYValues = this.waveDataGenerator.GenerateTriangleData(size, node);
					break;
				case 3:
					dYValues = this.waveDataGenerator.GenerateSquareData(size, node);
					break;
				case 4:
					dYValues = this.waveDataGenerator.GenerateRampUpData(size, node);
					break;
				case 5:
					dYValues = this.waveDataGenerator.GenerateRampDownData(size, node);
					break;
				case 6:
					dYValues = this.waveDataGenerator.GenerateNoiseData(size, node);
					break;
				case 7:
					dYValues = this.waveDataGenerator.GenerateTrapeziumData(size, node);
					break;
				default:
					break;
			}

			return new ValueTuple<double[], double[]>(dXValues, dYValues);
		}

		public SignalPlot AddDCWave(FormsPlot formsPlot, WaveformConfig node)
		{
			//清空绘图区
			formsPlot.Plot.Clear();
			//生成DC数据，并绘制图像
			SignalPlot sp = formsPlot.Plot.AddSignal(
				this.waveDataGenerator.GenerateDCData(
					node.ITimeTickValue, node));
			//刷新绘图区
			formsPlot.Render();
			return sp;
		}
		public SignalPlot AddSineWave(FormsPlot formsPlot, WaveformConfig node)
		{
			//清空绘图区
			formsPlot.Plot.Clear();
			//生成正弦波Sine数据，并绘制图像
			SignalPlot sp = formsPlot.Plot.AddSignal(
				this.waveDataGenerator.GenerateSineData(
					node.ITimeTickValue, node));
			//刷新绘图区
			formsPlot.Render();
			return sp;
		}
		public SignalPlot AddTriangleWave(FormsPlot formsPlot, WaveformConfig node)
		{
			//清空绘图区
			formsPlot.Plot.Clear();
			//生成三角波数据，并绘制图像
			SignalPlot sp = formsPlot.Plot.AddSignal(
				this.waveDataGenerator.GenerateTriangleData(
					node.ITimeTickValue, node));
			//刷新绘图区
			formsPlot.Render();
			return sp;
		}
		public SignalPlot AddSquareWave(FormsPlot formsPlot, WaveformConfig node)
		{
			//清空绘图区
			formsPlot.Plot.Clear();
			//生成方波数据，并绘制图像
			SignalPlot sp = formsPlot.Plot.AddSignal(
				this.waveDataGenerator.GenerateSquareData(
					node.ITimeTickValue, node));
			//设为阶梯显示
			sp.StepDisplay = true;
			//刷新绘图区
			formsPlot.Render();
			return sp;
		}
		public SignalPlot AddRampUpWave(FormsPlot formsPlot, WaveformConfig node)
		{
			//清空绘图区
			formsPlot.Plot.Clear();
			//生成上升波数据，并绘制图像
			SignalPlot sp = formsPlot.Plot.AddSignal(
				this.waveDataGenerator.GenerateRampUpData(
					node.ITimeTickValue, node));
			//刷新绘图区
			formsPlot.Render();
			return sp;
		}
		public SignalPlot AddRampDownWave(FormsPlot formsPlot, WaveformConfig node)
		{
			//清空绘图区
			formsPlot.Plot.Clear();
			//生成下降波数据，并绘制图像
			SignalPlot sp = formsPlot.Plot.AddSignal(
				this.waveDataGenerator.GenerateRampDownData(
					node.ITimeTickValue, node));
			//刷新绘图区
			formsPlot.Render();
			return sp;
		}
		public SignalPlot AddNoiseWave(FormsPlot formsPlot, WaveformConfig node)
		{
			//清空绘图区
			formsPlot.Plot.Clear();
			//生成噪声数据，并绘制图像
			SignalPlot sp = formsPlot.Plot.AddSignal(
				this.waveDataGenerator.GenerateNoiseData(
					node.ITimeTickValue, node));
			//刷新绘图区
			formsPlot.Render();
			return sp;
		}
		public SignalPlot AddTrapeziumWave(FormsPlot formsPlot, WaveformConfig node)
		{
			//清空绘图区
			formsPlot.Plot.Clear();
			//生成梯形波数据，并绘制图像
			SignalPlot sp = formsPlot.Plot.AddSignal(
				this.waveDataGenerator.GenerateTrapeziumData(
					node.ITimeTickValue, node));
			//刷新绘图区
			formsPlot.Render();
			return sp;
		}
	}
}
