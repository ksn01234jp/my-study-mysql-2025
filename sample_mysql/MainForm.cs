using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample_mysql
{
	public partial class MainForm : Form
	{
		private ServiceControllerClass serviceControllerClass = new ServiceControllerClass();

		/// <summary>
		/// 
		/// </summary>
		public MainForm()
		{
			Console.WriteLine("========================================");

			InitializeComponent();

			// サービス状態を取得
			this.lbServiceStatus.Text = this.serviceControllerClass.doReflesh(this.tbServiceName.Text);

		}

		/// <summary>
		/// サービス状態を更新
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ServiceRefresh_Click(object sender, EventArgs e)
		{
			this.lbServiceStatus.Text = this.serviceControllerClass.doReflesh(this.tbServiceName.Text);
		}

		/// <summary>
		/// サービス開始
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ServiceStart_Click(object sender, EventArgs e)
		{
			this.lbServiceStatus.Text = this.serviceControllerClass.doStart();
		}

		/// <summary>
		/// サービス停止
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ServiceStop_Click(object sender, EventArgs e)
		{
			this.lbServiceStatus.Text = this.serviceControllerClass.doStop();
		}
	}
}



