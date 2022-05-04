using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NWaves.Transforms;

namespace MyWaveForms.Analyzer
{
	internal class FrequencyAnalyzer
	{
		// FFT操作类
		private RealFft fft;

		// 必须指定fft大小
		public FrequencyAnalyzer(int iFFTSize = 1024)
		{
			this.fft = new RealFft(iFFTSize);
		}

		// 更改FFT大小
		public void ChangeFFTSize(int iFFTSize)
		{
			this.fft = null;
			this.fft = new RealFft(iFFTSize);
		}

		// 获取FFT大小
		public int GetFFTSize()
		{
			return fft.Size;
		}

		public float[] GetMagnitudeSpectrum(double[] signal, bool normalize = false)
		{
			/*Console.WriteLine("samples size = " + signal.Length.ToString());
			Console.WriteLine("Analyzer got data: ");
			foreach (double d in signal)
				Console.Write(d.ToString() + " ");
			Console.WriteLine();*/

			// 待处理信号进行类型转换
			float[] _signal = new float[signal.Length];
			for (int i = 0; i < signal.Length; i++)
				_signal[i] = (float)signal[i];

			// FFT变换
			float[] _realSpectrum = new float[this.fft.Size];
			float[] _imagSpectrum = new float[this.fft.Size];
			this.fft.Direct(_signal, _realSpectrum, _imagSpectrum);

			// 计算绝对值
			float[] spectrum = new float[this.fft.Size];
			Console.WriteLine("Magnitude Spectrum: ");
			for (int i = 0; i < spectrum.Length; ++i)
				Console.Write(spectrum[i].ToString() + " ");
			if (normalize == true)
			{
				for (var i = 0; i < spectrum.Length; i++)
				{
					spectrum[i] = (float)(Math.Sqrt(_realSpectrum[i] * _realSpectrum[i] + _imagSpectrum[i] * _imagSpectrum[i]) / this.fft.Size);
					// Console.WriteLine("index = {0}, {1}", i, spectrum[i]);
				}
			}
			else
			{
				for (var i = 0; i < spectrum.Length; i++)
				{
					spectrum[i] = (float)(Math.Sqrt(_realSpectrum[i] * _realSpectrum[i] + _imagSpectrum[i] * _imagSpectrum[i]));
					// Console.WriteLine("index = {0}, {1}", i, spectrum[i]);
				}
			}

			/*Console.WriteLine("spectrum size = " + spectrum.Length.ToString());
			Console.WriteLine("Magnitude Spectrum: ");
			for (int i = 0; i < spectrum.Length; ++ i)
				Console.Write(spectrum[i].ToString() + " ");*/
			return spectrum;
		}
	}
}
