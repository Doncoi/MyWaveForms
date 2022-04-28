using ScottPlot;
using System;
using System.Timers;
using System.Threading;
using System.Windows.Forms;

namespace MyWaveForms.Test
{
	internal class ChartTester
	{
		#region 成员变量
		//计时器默认时间间隔
		const int DEFAULT_INTERVAL = 10;
		//窗体数组默认大小
		const int DEFAULT_SIZE = 1000;
		//目标窗口
		private FormsPlot formsPlot;
		// 定时器 测试用
		private System.Timers.Timer timerUpdateTestValues;
		// 窗口数组
		int iMaxSize;
		double[] dXValues;
		double[] dYValues;

		public int IMaxSize { get => iMaxSize; set => iMaxSize = value; }
		#endregion
		#region 构造函数
		public ChartTester(FormsPlot _formsPlot, int _iMaxSize = 1000)
		{
			this.formsPlot = _formsPlot;
			this.iMaxSize = _iMaxSize;
			dXValues = new double[iMaxSize]; 
			dYValues = new double[iMaxSize];
		}

		public ChartTester(FormsPlot _formsPlot, double[] dXValues, double[] dYValues, int _iMaxSize = DEFAULT_SIZE)
		{
			this.formsPlot = _formsPlot;
			this.iMaxSize = _iMaxSize;
			this.dXValues = dXValues;
			this.dYValues = dYValues;
		}
		#endregion
		#region 测试器启停
		//初始化定时器
		public void InitTimer(int iIntervalMS = DEFAULT_INTERVAL)
		{
			//MessageBox.Show(this.formsPlot.ToString() + " " + System.Reflection.MethodBase.GetCurrentMethod().Name);
			//创建定时器
			timerUpdateTestValues = new System.Timers.Timer();
			//设置定时器属性
			timerUpdateTestValues.Elapsed += new System.Timers.ElapsedEventHandler(this.UpdateValues);
			timerUpdateTestValues.Interval = iIntervalMS;
			timerUpdateTestValues.Enabled = true;
			
		}

		//初始化测试数据
		public void InitTestData(ValueTuple<double[], double[]> dataTuple)
		{
			//MessageBox.Show(this.formsPlot.ToString() + " " + System.Reflection.MethodBase.GetCurrentMethod().Name);
			this.dXValues = dataTuple.Item1;
			this.dYValues = dataTuple.Item2;
		}

		//开启定时器
		public void StartTimer()
		{
			//开启定时器
			timerUpdateTestValues.Start();
		}

		//关闭定时器
		public void StopTimer()
		{
			//MessageBox.Show(this.formsPlot.ToString() + " " + System.Reflection.MethodBase.GetCurrentMethod().Name);
			this.timerUpdateTestValues.Stop();
		}

		
		#endregion
		#region 数据更新
		//更新窗口数据
		private void UpdateValues(Object myObject, EventArgs myEventArgs)
		{
			for (int i = 0; i < dYValues.Length - 1; ++i)
			{
				dYValues[i] = dYValues[i + 1];
			}
			dYValues[dYValues.Length - 1] = dYValues[0];
			//这里会出现跨线程争夺formsPlot资源的错误
			//this.formsPlot.Refresh();
			//尝试新建线程并触发委托
			//to-do 目前这样做性能很差，需要改进
			Thread thread = new Thread(new ThreadStart(DoRefresh));
			thread.Start();

			//更新时间标签
			//labelDisplayTime.Text = System.DateTime.Now.ToString("T");
		}

		public void DoRefresh()
		{
			FormsPlotRefresh("yyyy");
		}

		//声明事件委托
		public delegate void FormsPlotRefreshEvent(string strMsg);
		public void FormsPlotRefresh(string strMsg)
		{
			try
			{
				if (this.formsPlot.InvokeRequired)
				{
					FormsPlotRefreshEvent fPREvent = new FormsPlotRefreshEvent(FormsPlotRefresh);
					this.formsPlot.Invoke(fPREvent, new Object[] { strMsg });
				}
				else
				{
					this.formsPlot.Refresh(true, true);
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
		}

		//必须把图表的数据源设为测试器的内部数据,才能看到数据刷新
		public ValueTuple<double[], double[]> GetTestData()
		{
			return new ValueTuple<double[], double[]>(this.dXValues, this.dYValues);
		}
		#endregion
	}
}
