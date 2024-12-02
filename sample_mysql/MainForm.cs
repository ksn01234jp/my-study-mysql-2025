using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;	// ServiceController

namespace sample_mysql
{
	public partial class MainForm : Form
	{
		/// <summary>
		/// サービスコントローラー
		/// </summary>
		private ServiceController scMysql;

		/// <summary>
		/// 
		/// </summary>
		public MainForm()
		{
			Console.WriteLine("========================================");

			InitializeComponent();


			// サービス状態を取得
			this.scMysql = new ServiceController(this.tbServiceName.Text);
			Console.WriteLine($"サービス名 : {this.scMysql.DisplayName}");
			Console.WriteLine($"サービス状態 {this.scMysql.Status}");
			this.lbServiceStatus.Text = this.scMysql.Status.ToString();
		}
	}
}



