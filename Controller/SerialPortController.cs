using MyWaveForms.Entity;
using MyWaveForms.MyException;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWaveForms.Controller
{
	//扫描可用串口并添加到串口号列表
	internal class SerialPortController     //串口控制类
	{
		public void ReflashPortToComboBox(SerialPort serialPort, ComboBox comboBox)
		{
			if (!serialPort.IsOpen)     //串口处于关闭状态
			{
				comboBox.Items.Clear();     //清空原有选项
				string[] str = SerialPort.GetPortNames();    //获取已连接端口
				if (null == str)
				{
					MessageBox.Show("没有找到可用的串口", "Error");
					return;
				}
				foreach (string s in str)   //添加串口
				{
					comboBox.Items.Add(s);
					//Console.WriteLine(s);
				}
				if (comboBox.Items.Count > 0)
				{
					comboBox.SelectedIndex = 0;     //设置默认选项
				}
			}
			else    //串口处于打开状态
			{
				MessageBox.Show("请关闭当前串口后继续操作", "Error");
			}
		}

		//打开串口
		public bool OpenPort(SerialPort serialPort, SerialPortConfig portConfig)
		{
			if (!serialPort.IsOpen)     //串口处于关闭状态
			{
				try
				{
					portConfig.setSerialPort(serialPort);   //设置串口
					serialPort.Open();      //打开串口
					return true;
				}
				catch (StopBitErrorException sbee)
				{
					MessageBox.Show(sbee.Message);
					return false;
				}
				catch (CheckBitErrorException cbee)
				{
					MessageBox.Show(cbee.Message);
					return false;
				}
				catch (System.Exception ex)
				{
					MessageBox.Show("串口打开失败" + ex, "Error");
					return false;
				}
			}
			else
			{
				MessageBox.Show("串口已经打开", "Error");
				return false;
			}
		}

		//关闭串口
		public bool ClosePort(SerialPort serialPort)
		{
			try
			{
				serialPort.Close();
				return true;
			}
			catch (System.Exception ex)
			{
				MessageBox.Show("串口关闭失败！" + ex, "Error");
				return false;
			}
		}

		//字符串转为二进制
		private string HEXtoBIN(string str)
		{
			StringBuilder stringBuilder = new StringBuilder();
			string strTmp = null;
			for (int i = 0; i < str.Length; ++i)
			{
				switch (str[i])
				{
					case '0': strTmp = "0000"; break;
					case '1': strTmp = "0001"; break;
					case '2': strTmp = "0010"; break;
					case '3': strTmp = "0011"; break;
					case '4': strTmp = "0100"; break;
					case '5': strTmp = "0101"; break;
					case '6': strTmp = "0110"; break;
					case '7': strTmp = "0111"; break;
					case '8': strTmp = "1000"; break;
					case '9': strTmp = "1001"; break;
					case 'A': strTmp = "1010"; break;
					case 'B': strTmp = "1011"; break;
					case 'C': strTmp = "1100"; break;
					case 'D': strTmp = "1101"; break;
					case 'E': strTmp = "1110"; break;
					case 'F': strTmp = "1111"; break;
					default: break;
				}
				stringBuilder.Append(strTmp);
			}
			return stringBuilder.ToString();
		}

		//获取接收到的字符串
		public string GetReceivedString(SerialPort serialPort, byte bCommuFormat)
		{
			string strReceivedContent = null;
			if (bCommuFormat == 0)    //如果以ASCII模式接收
			{
				strReceivedContent = serialPort.ReadExisting();
			}
			else
			{
				byte[] ReDatas = new byte[serialPort.BytesToRead];
				serialPort.Read(ReDatas, 0, ReDatas.Length);   //读取数据

				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < ReDatas.Length; ++i)
				{
					stringBuilder.AppendFormat("{0:x2}" + "", ReDatas[i]);    //格式化数据
				}
				strReceivedContent = stringBuilder.ToString().ToUpper();    //转存为大写字母

				if (bCommuFormat == 1)    //以HEX模式接收
				{
					int iTmp = strReceivedContent.Length;
					while (iTmp - 2 > 0)        //为HEX模式下接受到的字串，每两位插入一个空格
					{
						iTmp -= 2;
						strReceivedContent = strReceivedContent.Insert(iTmp, " ");
					}
				}
				else if (bCommuFormat == 2)     //以BIN模式接收
				{
					strReceivedContent = HEXtoBIN(strReceivedContent);  //转为二进制
					int iTmp = strReceivedContent.Length;
					while (iTmp - 8 > 0)        //为BIN模式下接受到的字串，每8位插入一个空格
					{
						iTmp -= 8;
						strReceivedContent = strReceivedContent.Insert(iTmp, " ");
					}
				}
			}
			return strReceivedContent;
		}

		//为接收/发送信息追加时间戳和接受/发送模式
		public string AppendTimestamp(string strReceivedContent, bool bCommuType, byte bCommuFormat)
		{
			//添加时间戳
			string strTimeStamp = "[" + System.DateTime.Now.ToString("MM-dd HH:mm:ss:ms") + "]";
			if (false == bCommuType)
			{
				//添加接受模式
				if (bCommuFormat == 0) strTimeStamp += " #RECV ASCII>";     //ASCII
				else if (bCommuFormat == 1) strTimeStamp += " #RECV HEX>";      //HEX
				else if (bCommuFormat == 2) strTimeStamp += " #RECV BIN>";      //BIN
			}
			else
			{
				//添加发送模式
				if (bCommuFormat == 0) strTimeStamp += " #SEND ASCII>";     //ASCII
				else if (bCommuFormat == 1) strTimeStamp += " #SEND HEX>";      //HEX
			}

			strTimeStamp += System.Environment.NewLine;
			//添加原字符串
			strTimeStamp += strReceivedContent;
			strTimeStamp += (System.Environment.NewLine + System.Environment.NewLine);
			return strTimeStamp;
		}
		
		public void SerialPortSend(SerialPort serialPort, string str, byte bCommuFormat)
		{
			
			if (bCommuFormat == 0)   //以ASCII格式发送
			{
				//to-do 完善ASCII格式发送
			}
			else if (bCommuFormat == 1)     //以HEX格式发送
			{
				//to-do 完善十六进制发送
			}
			serialPort.Write(str);    //发送数据
		}
	}
}
