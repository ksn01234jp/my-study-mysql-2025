using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Org.BouncyCastle.Asn1.X509;
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
	public partial class CheckTableForm : Form
	{
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public CheckTableForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// クエリ作成ボタンクリックイベント
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CreateQuery_Click(object sender, EventArgs e)
		{
			string strSelect = string.Empty;
			string strFrom = string.Empty;

			if (this.cbShowColumnDataType.Checked)
			{
				strSelect = @"TABLE_NAME, COLUMN_NAME, DATA_TYPE";
				strFrom = @"INFORMATION_SCHEMA.COLUMNS";
			}
			else
			{
				strSelect = @"TABLE_NAME";
				strFrom = @"INFORMATION_SCHEMA.TABLES";
			}

			string strQuery = $@"SELECT {strSelect} FROM {strFrom} WHERE TABLE_SCHEMA = '{this.tbSchemaName.Text}'";

			if (this.cbShowColumnDataType.Checked)
			{
				strQuery += @" ORDER BY TABLE_NAME, ORDINAL_POSITION;";
			}
			else
			{
				strQuery += @";";
			}

			Console.WriteLine($"Result Query = {strQuery}");
			this.tbQuery.Text = strQuery;
		}

		/// <summary>
		/// クエリ実行ボタンクリックイベント
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ExecuteQuery_Click(object sender, EventArgs e)
		{
			// MySQLサーバー接続情報
			string strConnectionInfomation =
				// "Server=localhost;Port=3306;Database=sample_schema;Uid=root;Pwd=root;";
				$"Server=localhost;Port=3306;Database={this.tbSchemaName.Text};Uid=root;Pwd=root;";
			Console.WriteLine($"MySQLサーバー接続情報 -> {strConnectionInfomation}");

			using (MySqlConnection connection = new MySqlConnection(strConnectionInfomation))
			{
				try
				{
					connection.Open();
					Console.WriteLine("MySQLに接続しました。");

					string strQuery = $@"{this.tbQuery.Text}";
					Console.WriteLine($"クエリ -> {strQuery}");

					using (MySqlCommand command = new MySqlCommand(strQuery, connection))
					using (MySqlDataReader reader = command.ExecuteReader())
					{
						string strCurrentTableName = string.Empty;
						string strTmp = string.Empty;
						this.tbResult.Text = string.Empty;

						while (reader.Read())
						{
							string strTableName = reader.GetString("TABLE_NAME");

							// 新しいテーブルの開始
							if (strCurrentTableName != strTableName)
							{
								strCurrentTableName = strTableName;
								strTmp = $"テーブル : {strTableName}";

								if (this.tbResult.Text != string.Empty) { this.tbResult.Text += "\r\n"; }
								this.tbResult.Text += strTmp + "\r\n";
								Console.WriteLine(strTmp);
							}
							// カラム情報を表示
							if (this.cbShowColumnDataType.Checked)
							{
								string strColumnName = reader.GetString("COLUMN_NAME");
								string strDataType = reader.GetString("DATA_TYPE");
								strTmp = $" - {strColumnName} ({strDataType})";
								this.tbResult.Text += strTmp + "\r\n";
								Console.WriteLine(strTmp);
							}
						}
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
			}
		}

	}
}
