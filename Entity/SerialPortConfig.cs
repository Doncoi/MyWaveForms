using MyWaveForms.MyException;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWaveForms.Entity
{
	//串口配置信息类
	internal class SerialPortConfig : BaseConfig
	{
		public string strSerialPortName;
		public int iBaudRate;
		public byte iDataBit;    //0 for others, 7 for 7, 8 for 8
		public byte iCheckBit;    //0 for None, 1 for Odd, 2 for Even, 3 for others
		public byte iStopBit;    //0 for others, 1 for 1, 2 for 2, 3 for 1.5

		//默认构造函数
		public SerialPortConfig()
		{
			this.strSerialPortName = null;
			this.iBaudRate = 0;
			this.iDataBit = 0;
			this.iCheckBit = 3;
			this.iStopBit = 0;
		}

		//使用字符串构造配置信息类
		public SerialPortConfig(string _strSerialPortName, string strBaudRate, string strDataBit, string strCheckBit, string strStopBit)
		{
			this.strSerialPortName = _strSerialPortName;
			this.iBaudRate = Convert.ToInt32(strBaudRate);
			this.iDataBit = Convert.ToByte(strDataBit);
			//this.iCheckBit = Convert.ToByte(strCheckBit);
			//this.iStopBit = Convert.ToByte(strStopBit);
			switch (strCheckBit)
			{
				case "None":
					this.iCheckBit = 0;
					break;
				case "Odd":
					this.iCheckBit = 1;
					break;
				case "Even":
					this.iCheckBit = 2;
					break;
				default:
					this.iCheckBit = 3;
					break;
			}
			switch (strStopBit)
			{
				case "1":
					this.iStopBit = 1;
					break;
				case "2":
					this.iStopBit = 2;
					break;
				case "1.5":
					this.iStopBit = 3;
					break;
				default:
					this.iStopBit = 0;
					break;
			}
		}

		//使用直接类型构造配置信息类
		public SerialPortConfig(string _strSerialPortName, int _iBaudRate, byte _iDatabit, byte _iCheckBit, byte _iStopBit)
		{
			this.strSerialPortName = _strSerialPortName;
			this.iBaudRate = _iBaudRate;
			this.iDataBit = _iDatabit;
			this.iCheckBit = _iCheckBit;
			this.iStopBit = _iStopBit;
		}

		//使用配置信息设置串口类
		public void setSerialPort(SerialPort serialPort)
		{
			//配置转存至serialPort类
			serialPort.PortName = this.strSerialPortName;
			serialPort.BaudRate = this.iBaudRate;
			serialPort.DataBits = this.iDataBit;
			//设置停止位
			switch (this.iStopBit)
			{
				case 1:
					serialPort.StopBits = StopBits.One;
					break;
				case 2:
					serialPort.StopBits = StopBits.Two;
					break;
				case 3:     //终止位为1.5的情况
					serialPort.StopBits = StopBits.OnePointFive;
					break;
				default:
					//MessageBox.Show("停止位参数不正确！");
					throw new StopBitErrorException("停止位参数错误");
			}
			//设置校验位
			switch (this.iCheckBit)
			{
				case 0:
					serialPort.Parity = Parity.None;
					break;
				case 1:
					serialPort.Parity = Parity.Odd;
					break;
				case 2:
					serialPort.Parity = Parity.Even;
					break;
				default:
					//MessageBox.Show("校验位参数不正确！");
					throw new CheckBitErrorException("校验位参数错误");
			}
		}

		//信息输出
		public string toString()
		{
			StringBuilder sTemp = new StringBuilder();
			sTemp.Append("port : " + this.strSerialPortName + System.Environment.NewLine);
			sTemp.Append("BaudRate = " + this.iBaudRate.ToString() + System.Environment.NewLine);
			sTemp.Append("DataBit = " + this.iDataBit.ToString() + System.Environment.NewLine);
			sTemp.Append("CheckBit = " + this.iCheckBit.ToString() + System.Environment.NewLine);
			sTemp.Append("iStopBit = " + this.iStopBit.ToString() + System.Environment.NewLine);
			return sTemp.ToString();
		}
	}
}
