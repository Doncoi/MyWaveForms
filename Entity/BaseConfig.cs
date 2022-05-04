using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWaveForms.Entity
{
	internal abstract class BaseConfig
	{
		//在字符串中抓取实型数值
		public static double GetRealFromString(string str)
		{
			//return double.Parse(str);
			StringBuilder res = new StringBuilder();
			foreach (char chr in str)
			{
				if ((chr >= '0' && chr <= '9') || chr == '.' || chr == '-')
					res.Append(chr);
			}
			//MessageBox.Show(res.ToString());
			//if (res.Length == 0) return 0;
			return double.Parse(res.ToString());
		}

		//获取单位
		public static string GetUnitFromString(string str)
		{
			StringBuilder res_1 = new StringBuilder();
			foreach (char chr in str)
			{
				if ((chr >= '0' && chr <= '9') || chr == '.' || chr == '-')
					res_1.Append(chr);
			}
			int length = res_1.Length;
			StringBuilder res_2 = new StringBuilder();
			for (int i = length; i < str.Length; ++i)
			{
				res_2.Append(str[i]);
			}
			return res_2.ToString();
		}
	}
}
