using MyWaveForms.Entity;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWaveForms.Generator
{
	//波形数据生成器
	internal class WaveformDataGenerator
	{
		//生成直流信号
		public WaveformData GenerateDCData(int size, WaveformInfor node)
		{
			//指定大小，偏移量dOffset，幅值dAmplitude，
			double[] dValues = new double[size];
			for (int i = 0; i < size; ++i)
				dValues[i] = node.DOffset + node.DAmplitude;

			return new WaveformData(size, dValues);
		}

		//生成正弦波
		public WaveformData GenerateSineData(int size, WaveformInfor node)
		{
			//指定大小，生成1个周期，偏移量dOffset，幅值dAmplitude，相位bPhase / 360
			double[] dValues = DataGen.Sin(size, 1, node.DOffset, node.DAmplitude, (double)node.BPhase / 360);
			return new WaveformData(size, dValues);
		}

		//生成三角波
		public WaveformData GenerateTriangleData(int size, WaveformInfor node)
		{
			//指定大小，生成1个周期，偏移量dOffset，幅值dAmplitude，相位bPhase / 360
			double[] dTemp = new double[size];
			double[] dValues = new double[size];
			double step = node.DAmplitude / (size / 4);    //步长
														   //生成原始波形
			for (int i = 1; i <= (size / 4); ++i)
				dTemp[i] = dTemp[i - 1] + step;
			for (int i = (size / 4) + 1; i < (size / 4) * 3 + 1; ++i)
				dTemp[i] = dTemp[i - 1] - step;
			for (int i = (size / 4) * 3 + 1; i < size; ++i)
				dTemp[i] = dTemp[i - 1] + step;
			//追加y轴偏移量
			for (int i = 0; i < size; ++i)
				dTemp[i] = dTemp[i] + node.DOffset;
			//追加相位偏移量
			return AddPhaseDeviation(dTemp, size, node);
		}

		//生成方波
		public WaveformData GenerateSquareData(int size, WaveformInfor node)
		{
			//指定大小，生成1个周期，偏移量dOffset，幅值dAmplitude，相位bPhase / 360
			double[] dTemp = new double[size];
			double[] dValues = new double[size];
			//生成原始波形，增加幅值和偏移量
			for (int i = 0; i < size / 2; ++i)
				dTemp[i] = node.DAmplitude + node.DOffset;
			for (int i = size / 2; i < size; ++i)
				dTemp[i] = node.DAmplitude * -1 + node.DOffset;
			//追加相位偏移量
			return AddPhaseDeviation(dTemp, size, node);
		}

		//生成上升波
		public WaveformData GenerateRampUpData(int size, WaveformInfor node)
		{
			//指定大小，生成1个周期，偏移量dOffset，幅值dAmplitude，相位bPhase / 360
			double[] dTemp = new double[size];
			double[] dValues = new double[size];
			double step = node.DAmplitude * 2 / size;    //步长
			//添加y轴偏移量
			dTemp[0] = node.DOffset;
			//生成波形
			for (int i = 1; i < size; ++i)
				dTemp[i] = dTemp[i - 1] + step;
			//追加相位偏移量
			return AddPhaseDeviation(dTemp, size, node);
		}

		//生成下降波
		public WaveformData GenerateRampDownData(int size, WaveformInfor node)
		{
			//指定大小，生成1个周期，偏移量dOffset，幅值dAmplitude，相位bPhase / 360
			double[] dTemp = new double[size];
			double[] dValues = new double[size];
			double step = node.DAmplitude * 2 / size;    //步长
			 //添加y轴偏移量与幅值
			dTemp[0] = node.DOffset + node.DAmplitude;
			//生成波形
			for (int i = 1; i < size; ++i)
				dTemp[i] = dTemp[i - 1] - step;
			//追加相位偏移量
			return AddPhaseDeviation(dTemp, size, node);
		}

		//生成噪声
		public WaveformData GenerateNoiseData(int size, WaveformInfor node)
		{
			Random rand = new Random(0);
			double[] dValues = new double[size];
			//double[] dValues = DataGen.RandomNormal(rand, size, 0, 0.5, node.DAmplitude);
			for (int i = 0; i < size; ++i)
				dValues[i] = rand.NextDouble() * 
					node.DAmplitude * 
					(rand.NextDouble() > 0.5 ? 1 : -1) + 
					node.DOffset;
			return new WaveformData(size, dValues);
		}

		//生成梯形波
		public WaveformData GenerateTrapeziumData(int size, WaveformInfor node)
		{
			//指定大小，生成1个周期，偏移量dOffset，幅值dAmplitude，相位bPhase / 360
			double[] dTemp = new double[size];
			double[] dValues = new double[size];
			double step = node.DAmplitude / (size / 8);    //步长
			//生成原始波形
			for (int i = 1; i <= (size / 8); ++i)	//1 - 1/8 上升沿
				dTemp[i] = dTemp[i - 1] + step;
			for (int i = (size / 8) + 1; i <= (size / 8) * 3; ++i)   //1/8 - 3/8 水平部分
				dTemp[i] = node.DAmplitude;
			for (int i = (size / 8) * 3 + 1; i <= (size / 8) * 5; ++i)	//3/8 - 5/8 下降沿
				dTemp[i] = dTemp[i - 1] - step;
			for (int i = (size / 8) * 5 + 1; i <= (size / 8) * 7; ++i)  //5/8 - 7/8 水平部分
				dTemp[i] = node.DAmplitude * -1;
			for (int i = (size / 8) * 7 + 1; i < size; ++i)  //7/8 - 1 上升沿
				dTemp[i] = dTemp[i - 1] + step;
			//追加y轴偏移量
			for (int i = 0; i < size; ++i)
				dTemp[i] = dTemp[i] + node.DOffset;

			//追加相位偏移量
			return AddPhaseDeviation(dTemp, size, node);
		}

		//追加相位偏移量
		private WaveformData AddPhaseDeviation(double[] dTemp, int size, WaveformInfor node)
		{
			double[] dValues = new double[size];
			//追加相位偏移量
			int st = (int)(size * ((double)node.BPhase / 360.0));
			//int st = node.BPhase;
			for (int i = st; i < size; ++i)
				dValues[i] = dTemp[i - st];
			for (int i = 0; i < st; ++i)
				dValues[i] = dTemp[size - st + i];

			return new WaveformData(size, dValues);
		}
	}
}
