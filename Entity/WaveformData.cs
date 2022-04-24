using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWaveForms.Entity
{
	//封装波形数据
	internal class WaveformData
	{
		int iSize;
		double[] dValues;

		public WaveformData(int _iSize)
		{
			this.iSize = _iSize;
			this.dValues = new double[iSize];
		}

		public WaveformData(int _iSize, double[] _dValues)
		{
			this.iSize = _iSize;
			this.dValues = _dValues;
		}

		public int ISize { get => iSize; set => iSize = value; }
		public double[] DValues { get => dValues; set => dValues = value; }
	}
}
