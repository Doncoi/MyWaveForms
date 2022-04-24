using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWaveForms.MyException
{
	internal class WaveformInforException : System.Exception
	{
		public WaveformInforException(string message) : base(message)
		{

		}
	}

	//频率类型参数错误
	internal class FrequencyParanmeterException : System.Exception
	{
		public FrequencyParanmeterException(string message) : base(message)
		{
		
		}
	}
}
