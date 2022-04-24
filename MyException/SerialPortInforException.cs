using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWaveForms.MyException
{
	internal class SerialPortInforException : System.Exception
	{
		public SerialPortInforException(string message) : base(message)
		{

		}
	}

	class StopBitErrorException : SerialPortInforException
	{
		public StopBitErrorException(string message) : base(message)
		{

		}
	}

	class CheckBitErrorException : SerialPortInforException
	{
		public CheckBitErrorException(string message) : base(message)
		{

		}
	}
}
