using MyWaveForms.Entity;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWaveForms.Controller
{
	internal class DeviceController
	{
		// 串口通信类
		private SerialPortController serialPortController;

		public DeviceController(SerialPortController serialPortController)
		{
			this.serialPortController = serialPortController;
		}

		/// <summary>
		/// 获取可用设备列表
		/// </summary>
		/// <param name="serialPort"></param>
		/// <param name="comboBox"></param>
		public List<DeviceConfig> GetDeviceInforList(SerialPort serialPort, ComboBox comboBox)
		{
			List<DeviceConfig> list = new List<DeviceConfig>();
			// todo 扫描可用设备列表
			return list;
		}

		/// <summary>
		/// 连接到设备
		/// </summary>
		/// <param name="serialPort"></param>
		/// <param name="serialPortConfig"></param>
		/// <returns></returns>
		public bool ConnectWithDevice(SerialPort serialPort, SerialPortConfig serialPortConfig)
		{
			bool res = serialPortController.OpenPort(serialPort, serialPortConfig);
			return res;
		}

		/// <summary>
		/// 关闭串口
		/// </summary>
		/// <returns></returns>
		public bool DisconnectWithDevice(SerialPort serialPort)
		{
			// todo 有待完善
			bool res = serialPortController.ClosePort(serialPort);
			return res;
		}
	}
}
