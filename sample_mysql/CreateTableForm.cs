using MySql.Data.MySqlClient;
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
	public partial class CreateTableForm : Form
	{
		public CreateTableForm()
		{
			InitializeComponent();

			// DATA_TYPEをセット
			Utilities.setDataGridViewComboBoxColumnItems(this.colDataType);

			// 行をクリア
			this.dataGridView.Rows.Add("id", "INT", "PRIMARY KEY AUTO_INCREMENT");
			//this.dataGridView.Rows[0].Cells[0].Value = "id";
			//this.dataGridView.Rows[0].Cells[1].Value = "INT";
			//this.dataGridView.Rows[0].Cells[2].Value = "PRIMARY KEY AUTO_INCREMENT";
		}

		/// <summary>
		/// 行を追加
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AddRow_Click(object sender, EventArgs e)
		{
			this.dataGridView.Rows.Add();
		}

		/// <summary>
		/// 選択中の行を削除
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DeleteRow_Click(object sender, EventArgs e)
		{
			int iRowIndex;

			if (this.dataGridView.SelectedCells.Count == 0)
			{
				return;
			}
			// 選択中の行を取得
			iRowIndex = this.dataGridView.SelectedCells[0].RowIndex;
			if (iRowIndex == 0)
			{
				return;
			}
			// 削除実行
			this.dataGridView.Rows.RemoveAt(iRowIndex);
		}

		/// <summary>
		/// クエリ作成ボタンクリックイベント
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CreateQuery_Click(object sender, EventArgs e)
		{
			//Utilities.getConnectionInfomationString(this.tbSchemaName.Text);

			string strQuery = string.Empty;

			strQuery += $@"CREATE TABLE {this.tbTableName.Text} (";
			for (int iIndex = 0; iIndex < this.dataGridView.Rows.Count; iIndex++)
			{
				strQuery += $@"{this.dataGridView.Rows[iIndex].Cells[0].Value} ";
				strQuery += $@"{this.dataGridView.Rows[iIndex].Cells[1].Value} ";
				strQuery += $@"{this.dataGridView.Rows[iIndex].Cells[2].Value} ";
				if (iIndex + 1 != this.dataGridView.Rows.Count)
				{
					strQuery += @", ";
				}
			}
			strQuery += $@");";

			this.tbQuery.Text = strQuery;

		}

		/// <summary>
		/// クエリ実行ボタンクリックイベント
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ExecuteQuery_Click(object sender, EventArgs e)
		{
			string strQuery = this.tbQuery.Text;
			Console.WriteLine(strQuery);
			try
			{
				using (MySqlConnection mySqlConnection = new MySqlConnection(Utilities.getConnectionInfomationString(this.tbSchemaName.Text)))
				{
					mySqlConnection.Open();
					MySqlCommand mySqlCommand = new MySqlCommand(strQuery, mySqlConnection);
					mySqlCommand.ExecuteNonQuery();
					Console.WriteLine($"テーブルが成城に作成されました");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}
	}
}
