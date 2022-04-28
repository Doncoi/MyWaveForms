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
	internal class WavegenChartController
	{
		//数组大小
		private const int MAXSIZE = 1000 + 1;
		//波形数据产生器
		private WaveformDataGenerator waveDataGenerator;

		public WavegenChartController()
		{
			//创建波形数据产生器实例
			this.waveDataGenerator = new WaveformDataGenerator();
		}

		//使用外部数据加载图表
		public SignalPlotXY AddWaveforms(FormsPlot formsPlot, ValueTuple<double[], double[]>  vt, WaveformInfor node)
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
		public SignalPlotXY AddWaveforms(FormsPlot formsPlot, WaveformInfor node)
		{
			//清空绘图区
			formsPlot.Plot.Clear();
			//获取X轴与Y轴数据
			ValueTuple<double[], double[]> vt = GetWaveData(node);
			//绘制图像
			SignalPlotXY sp = formsPlot.Plot.AddSignalXY(vt.Item1, vt.Item2);
			//更新X轴单位标签
			formsPlot.Plot.XLabel(node.GetTimeTickLabel());
			//刷新绘图区
			formsPlot.Render();

			return sp;
		}

		public ValueTuple<double[], double[]> GetWaveData(WaveformInfor node)
		{
			//x标定数组
			double[] dXValues = new double[MAXSIZE];
			//y标定数组
			double[] dYValues = new double[MAXSIZE];
			//x标定数组步长 表示相邻两点在x轴上的间隔
			double dXStep = (double)node.ITimeTickValue / (double)(MAXSIZE - 1);
			//MessageBox.Show(node.ToString() + "\n" + dXStep.ToString());
			for (int i = 1; i < MAXSIZE; i++)
				dXValues[i] = dXValues[i - 1] + dXStep;

			//MessageBox.Show(node.BWaveType.ToString());
			switch (node.BWaveType)
			{
				case 0:
					dYValues = this.waveDataGenerator.GenerateDCData(MAXSIZE, node).DValues;
					break;
				case 1:
					dYValues = this.waveDataGenerator.GenerateSineData(MAXSIZE, node).DValues;
					break;
				case 2:
					dYValues = this.waveDataGenerator.GenerateTriangleData(MAXSIZE, node).DValues;
					break;
				case 3:
					dYValues = this.waveDataGenerator.GenerateSquareData(MAXSIZE, node).DValues;
					break;
				case 4:
					dYValues = this.waveDataGenerator.GenerateRampUpData(MAXSIZE, node).DValues;
					break;
				case 5:
					dYValues = this.waveDataGenerator.GenerateRampDownData(MAXSIZE, node).DValues;
					break;
				case 6:
					dYValues = this.waveDataGenerator.GenerateNoiseData(MAXSIZE, node).DValues;
					break;
				case 7:
					dYValues = this.waveDataGenerator.GenerateTrapeziumData(MAXSIZE, node).DValues;
					break;
				default:
					break;
			}

			return new ValueTuple<double[], double[]>(dXValues, dYValues);
		}

		public SignalPlot AddDCWave(FormsPlot formsPlot, WaveformInfor node)
		{
			//清空绘图区
			formsPlot.Plot.Clear();
			//生成DC数据，并绘制图像
			SignalPlot sp = formsPlot.Plot.AddSignal(
				this.waveDataGenerator.GenerateDCData(
					node.ITimeTickValue, node).DValues);
			//刷新绘图区
			formsPlot.Render();
			return sp;
		}
		public SignalPlot AddSineWave(FormsPlot formsPlot, WaveformInfor node)
		{
			//清空绘图区
			formsPlot.Plot.Clear();
			//生成正弦波Sine数据，并绘制图像
			SignalPlot sp = formsPlot.Plot.AddSignal(
				this.waveDataGenerator.GenerateSineData(
					node.ITimeTickValue, node).DValues);
			//刷新绘图区
			formsPlot.Render();
			return sp;
		}
		public SignalPlot AddTriangleWave(FormsPlot formsPlot, WaveformInfor node)
		{
			//清空绘图区
			formsPlot.Plot.Clear();
			//生成三角波数据，并绘制图像
			SignalPlot sp = formsPlot.Plot.AddSignal(
				this.waveDataGenerator.GenerateTriangleData(
					node.ITimeTickValue, node).DValues);
			//刷新绘图区
			formsPlot.Render();
			return sp;
		}
		public SignalPlot AddSquareWave(FormsPlot formsPlot, WaveformInfor node)
		{
			//清空绘图区
			formsPlot.Plot.Clear();
			//生成方波数据，并绘制图像
			SignalPlot sp = formsPlot.Plot.AddSignal(
				this.waveDataGenerator.GenerateSquareData(
					node.ITimeTickValue, node).DValues);
			//设为阶梯显示
			sp.StepDisplay = true;
			//刷新绘图区
			formsPlot.Render();
			return sp;
		}
		public SignalPlot AddRampUpWave(FormsPlot formsPlot, WaveformInfor node)
		{
			//清空绘图区
			formsPlot.Plot.Clear();
			//生成上升波数据，并绘制图像
			SignalPlot sp = formsPlot.Plot.AddSignal(
				this.waveDataGenerator.GenerateRampUpData(
					node.ITimeTickValue, node).DValues);
			//刷新绘图区
			formsPlot.Render();
			return sp;
		}
		public SignalPlot AddRampDownWave(FormsPlot formsPlot, WaveformInfor node)
		{
			//清空绘图区
			formsPlot.Plot.Clear();
			//生成下降波数据，并绘制图像
			SignalPlot sp = formsPlot.Plot.AddSignal(
				this.waveDataGenerator.GenerateRampDownData(
					node.ITimeTickValue, node).DValues);
			//刷新绘图区
			formsPlot.Render();
			return sp;
		}
		public SignalPlot AddNoiseWave(FormsPlot formsPlot, WaveformInfor node)
		{
			//清空绘图区
			formsPlot.Plot.Clear();
			//生成噪声数据，并绘制图像
			SignalPlot sp = formsPlot.Plot.AddSignal(
				this.waveDataGenerator.GenerateNoiseData(
					node.ITimeTickValue, node).DValues);
			//刷新绘图区
			formsPlot.Render();
			return sp;
		}
		public SignalPlot AddTrapeziumWave(FormsPlot formsPlot, WaveformInfor node)
		{
			//清空绘图区
			formsPlot.Plot.Clear();
			//生成梯形波数据，并绘制图像
			SignalPlot sp = formsPlot.Plot.AddSignal(
				this.waveDataGenerator.GenerateTrapeziumData(
					node.ITimeTickValue, node).DValues);
			//刷新绘图区
			formsPlot.Render();
			return sp;
		}
	}
}
