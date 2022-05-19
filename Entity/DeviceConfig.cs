using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWaveForms.Entity
{
	/// <summary>
	/// 设备信息类
	/// </summary>
	internal class DeviceConfig : BaseConfig
	{
		// 端口号
		private string sPortNumber;
		// 设备名称
		private string sDeviceName;
		// 设备序列号
		private string sDeviceNumber;
		// 端口配置
		private SerialPortConfig serialPortConfig;

		public DeviceConfig(string sPortNumber, string sDeviceName, string sDeviceNumber, SerialPortConfig serialPortConfig)
		{
			this.sPortNumber = sPortNumber;
			this.sDeviceName = sDeviceName;
			this.sDeviceNumber = sDeviceNumber;
			this.serialPortConfig = serialPortConfig;
		}

		public string SPortNumber { get => sPortNumber; set => sPortNumber = value; }
		public string SDeviceName { get => sDeviceName; set => sDeviceName = value; }
		public string SDeviceNumber { get => sDeviceNumber; set => sDeviceNumber = value; }
		internal SerialPortConfig SerialPortConfig { get => serialPortConfig; set => serialPortConfig = value; }
	}
}
