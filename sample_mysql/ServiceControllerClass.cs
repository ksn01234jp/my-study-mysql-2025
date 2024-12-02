using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceProcess;    // ServiceController

namespace sample_mysql
{
	/// <summary>
	/// 
	/// </summary>
	internal class ServiceControllerClass
	{
		/// <summary>
		/// サービスコントローラー
		/// </summary>
		private ServiceController scMysql;

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public ServiceControllerClass() { }

		/// <summary>
		/// リフレッシュ
		/// </summary>
		/// <param name="strServiceName"></param>
		/// <returns></returns>
		public string doReflesh(string strServiceName)
		{
			string strRet = string.Empty;

			try
			{
				if (this.scMysql != null)
				{
					this.scMysql.Dispose();
				}
				this.scMysql = new ServiceController(strServiceName);
				this.scMysql.Refresh();
				strRet = this.scMysql.Status.ToString();
			}
			catch (InvalidOperationException ex)
			{
				Console.WriteLine(ex.Message);
				strRet = "NOTHING";
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				strRet = "ERROR";
			}

			return strRet;
		}

		/// <summary>
		/// サービス開始
		/// </summary>
		/// <returns></returns>
		public string doStart()
		{
			string strRet = string.Empty;

			try
			{
				this.scMysql.Start();
				this.scMysql.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(10));
				this.scMysql.Refresh();
				strRet = this.scMysql.Status.ToString();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				strRet = "ERRPR";
			}

			return strRet;
		}

		/// <summary>
		/// サービス停止
		/// </summary>
		/// <returns></returns>
		public string doStop()
		{
			string strRet = string.Empty;

			try
			{
				this.scMysql.Stop();
				// サービスが停止状態になるのを待機
				this.scMysql.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(10));
				this.scMysql.Refresh();
				strRet = this.scMysql.Status.ToString();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				strRet = "ERRPR";
			}

			return strRet;
		}
	}
}
