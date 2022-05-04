using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWaveForms.MyException
{
	internal class CongfigException : System.Exception
	{
		public CongfigException(string message) : base(message)
		{

		}
	}

	//停止位参数错误
	class StopBitErrorException : CongfigException
	{
		public StopBitErrorException(string message) : base(message)
		{

		}
	}

	//校验位参数错误
	class CheckBitErrorException : CongfigException
	{
		public CheckBitErrorException(string message) : base(message)
		{

		}
	}

	//频率类型参数错误
	internal class FrequencyParanmeterException : CongfigException
	{
		public FrequencyParanmeterException(string message) : base(message)
		{

		}
	}
}
