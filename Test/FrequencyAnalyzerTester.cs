using MyWaveForms.Analyzer;
using MyWaveForms.Entity;
using MyWaveForms.Generator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWaveForms.Test
{
	internal class FrequencyAnalyzerTester
	{
		WaveformDataGenerator generator;
		SpectrumAnalyzer analyzer;

		public FrequencyAnalyzerTester(int iFFTSize = 1024)
		{
			generator = new WaveformDataGenerator();
			analyzer = new SpectrumAnalyzer(iFFTSize);
		}

		public float[] TestMagnitudeSpectrum(byte waveType = 0, WaveformConfig node = null)
		{
			if (node == null) node = new WaveformConfig();
			double[] sample = generator.GenerateWaveformData(waveType, analyzer.GetFFTSize(), node);
			return analyzer.GetMagnitudeSpectrum(sample, true);
		}
	}
}
