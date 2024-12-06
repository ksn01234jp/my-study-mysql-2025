using Org.BouncyCastle.Math.EC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample_mysql
{
	/// <summary>
	/// 
	/// </summary>
	internal class Utilities
	{
		/// <summary>
		/// SQL接続情報文字列を取得
		/// </summary>
		/// <param name="strSchemaName"></param>
		/// <returns></returns>
		public static string getConnectionInfomationString(string strSchemaName)
		{
			return $"Server=localhost;Database={strSchemaName};User Id=root;Password=root;";
		}

		/// <summary>
		/// MySQLで使用できるデータ型リストを引数に設定
		/// </summary>
		public static void setDataGridViewComboBoxColumnItems(DataGridViewComboBoxColumn dataGridViewComboBoxColumn)
		{
			/* 数値型 */

			// -128 ～ 127 / 0 ～ 255 (1バイト)
			dataGridViewComboBoxColumn.Items.Add("TINYINT");

			// -32,768 ～ 32,767 / 0 ～ 65,535 (2バイト)
			dataGridViewComboBoxColumn.Items.Add("SMALLINT");

			// -8,388,608 ～ 8,388,607 / 0 ～ 16,777,215 (3バイト)
			dataGridViewComboBoxColumn.Items.Add("MEDIUMINT");

			// -2,147,483,648 ～ 2,147,483,647 / 0 ～ 4,294,967,295 (4バイト)
			dataGridViewComboBoxColumn.Items.Add("INT");
			dataGridViewComboBoxColumn.Items.Add("INTEGER");

			// -9,223,372,036,854,775,808 ～ 9,223,372,036,854,775,807 / 0 ～ 18,446,744,073,709,551,615 (8バイト)
			dataGridViewComboBoxColumn.Items.Add("BIGINT");

			// 小数点の桁数を指定可能 (可変長)
			dataGridViewComboBoxColumn.Items.Add("DECIMAL");
			dataGridViewComboBoxColumn.Items.Add("NUMERIC");

			// 約±3.402823466E+38 ～ ±1.175494351E-38 (4バイト)
			dataGridViewComboBoxColumn.Items.Add("FLOAT");

			// 約±1.7976931348623157E+308 ～ ±2.2250738585072014E-308 (8バイト)
			dataGridViewComboBoxColumn.Items.Add("DOUBLE");
			dataGridViewComboBoxColumn.Items.Add("REAL");

			// 最大64ビット (1～8バイト)
			dataGridViewComboBoxColumn.Items.Add("BIT");

			/* 文字列型 */

			// 最大255文字
			dataGridViewComboBoxColumn.Items.Add("CHAR(255)");

			// 最大16,383文字 (= 65534 / 4)
			dataGridViewComboBoxColumn.Items.Add("VARCHAR(16383)");

			// 最大255文字
			dataGridViewComboBoxColumn.Items.Add("TINYTEXT");

			// 最大65,535文字
			dataGridViewComboBoxColumn.Items.Add("TEXT");

			// 最大16,777,215文字
			dataGridViewComboBoxColumn.Items.Add("MEDIUMTEXT");

			// 最大4,294,967,295文字
			dataGridViewComboBoxColumn.Items.Add("LONGTEXT");

			// 最大255バイト
			dataGridViewComboBoxColumn.Items.Add("BINARY(255)");

			// 最大65,535バイト（行全体の制限に依存）
			dataGridViewComboBoxColumn.Items.Add("VARBINARY(65535)");

			// 最大255バイト
			dataGridViewComboBoxColumn.Items.Add("TINYBLOB");

			// 最大65,535バイト
			dataGridViewComboBoxColumn.Items.Add("BLOB");

			// 最大16,777,215バイト
			dataGridViewComboBoxColumn.Items.Add("MEDIUMBLOB");

			// 最大4,294,967,295バイト
			dataGridViewComboBoxColumn.Items.Add("LONGBLOB");

			// 最大65,535個の値
			dataGridViewComboBoxColumn.Items.Add("ENUM");

			// 最大64個の値
			dataGridViewComboBoxColumn.Items.Add("SET");

			/* 日時型 */

			// 年月日を格納します（YYYY-MM-DD形式）。1000-01-01 ～ 9999-12-31
			dataGridViewComboBoxColumn.Items.Add("DATE");

			// 年月日と時刻を格納します（YYYY-MM-DD HH:MM:SS形式）。1000-01-01 00:00:00 ～ 9999-12-31 23:59:59
			dataGridViewComboBoxColumn.Items.Add("DATETIME");

			// UNIXタイムスタンプを格納します。1970-01-01 00:00:01 UTC ～ 2038-01-19 03:14:07 UTC
			dataGridViewComboBoxColumn.Items.Add("TIMESTAMP");

			// 時間（時:分:秒）を格納します。-838:59:59 ～ 838:59:59
			dataGridViewComboBoxColumn.Items.Add("TIME");

			// 年を格納します（4桁: YYYY形式）。1901 ～ 2155
			dataGridViewComboBoxColumn.Items.Add("YEAR");
		}
	}
}
