namespace sample_mysql
{
	partial class MainForm
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.lbServiceName = new System.Windows.Forms.Label();
			this.tbServiceName = new System.Windows.Forms.TextBox();
			this.lbServiceStatus = new System.Windows.Forms.Label();
			this.btServiceRefresh = new System.Windows.Forms.Button();
			this.btServiceStart = new System.Windows.Forms.Button();
			this.btServiceStop = new System.Windows.Forms.Button();
			this.btCheckTable = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbServiceName
			// 
			this.lbServiceName.AutoSize = true;
			this.lbServiceName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lbServiceName.Location = new System.Drawing.Point(12, 20);
			this.lbServiceName.Name = "lbServiceName";
			this.lbServiceName.Size = new System.Drawing.Size(101, 16);
			this.lbServiceName.TabIndex = 0;
			this.lbServiceName.Text = "Service Name";
			// 
			// tbServiceName
			// 
			this.tbServiceName.Font = new System.Drawing.Font("MS UI Gothic", 12F);
			this.tbServiceName.Location = new System.Drawing.Point(145, 17);
			this.tbServiceName.Name = "tbServiceName";
			this.tbServiceName.Size = new System.Drawing.Size(160, 23);
			this.tbServiceName.TabIndex = 1;
			this.tbServiceName.Text = "MySQL91";
			// 
			// lbServiceStatus
			// 
			this.lbServiceStatus.AutoSize = true;
			this.lbServiceStatus.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lbServiceStatus.Location = new System.Drawing.Point(320, 20);
			this.lbServiceStatus.Name = "lbServiceStatus";
			this.lbServiceStatus.Size = new System.Drawing.Size(80, 16);
			this.lbServiceStatus.TabIndex = 2;
			this.lbServiceStatus.Text = "STARTING";
			// 
			// btServiceRefresh
			// 
			this.btServiceRefresh.Font = new System.Drawing.Font("MS UI Gothic", 12F);
			this.btServiceRefresh.Location = new System.Drawing.Point(415, 12);
			this.btServiceRefresh.Name = "btServiceRefresh";
			this.btServiceRefresh.Size = new System.Drawing.Size(79, 33);
			this.btServiceRefresh.TabIndex = 3;
			this.btServiceRefresh.Text = "Refresh";
			this.btServiceRefresh.UseVisualStyleBackColor = true;
			this.btServiceRefresh.Click += new System.EventHandler(this.ServiceRefresh_Click);
			// 
			// btServiceStart
			// 
			this.btServiceStart.Font = new System.Drawing.Font("MS UI Gothic", 12F);
			this.btServiceStart.Location = new System.Drawing.Point(500, 12);
			this.btServiceStart.Name = "btServiceStart";
			this.btServiceStart.Size = new System.Drawing.Size(79, 33);
			this.btServiceStart.TabIndex = 4;
			this.btServiceStart.Text = "Start";
			this.btServiceStart.UseVisualStyleBackColor = true;
			this.btServiceStart.Click += new System.EventHandler(this.ServiceStart_Click);
			// 
			// btServiceStop
			// 
			this.btServiceStop.Font = new System.Drawing.Font("MS UI Gothic", 12F);
			this.btServiceStop.Location = new System.Drawing.Point(585, 12);
			this.btServiceStop.Name = "btServiceStop";
			this.btServiceStop.Size = new System.Drawing.Size(79, 33);
			this.btServiceStop.TabIndex = 5;
			this.btServiceStop.Text = "Stop";
			this.btServiceStop.UseVisualStyleBackColor = true;
			this.btServiceStop.Click += new System.EventHandler(this.ServiceStop_Click);
			// 
			// btCheckTable
			// 
			this.btCheckTable.Font = new System.Drawing.Font("MS UI Gothic", 12F);
			this.btCheckTable.Location = new System.Drawing.Point(12, 81);
			this.btCheckTable.Name = "btCheckTable";
			this.btCheckTable.Size = new System.Drawing.Size(195, 39);
			this.btCheckTable.TabIndex = 6;
			this.btCheckTable.Text = "保有テーブル確認";
			this.btCheckTable.UseVisualStyleBackColor = true;
			this.btCheckTable.Click += new System.EventHandler(this.CheckTable_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(681, 358);
			this.Controls.Add(this.btCheckTable);
			this.Controls.Add(this.btServiceStop);
			this.Controls.Add(this.btServiceStart);
			this.Controls.Add(this.btServiceRefresh);
			this.Controls.Add(this.lbServiceStatus);
			this.Controls.Add(this.tbServiceName);
			this.Controls.Add(this.lbServiceName);
			this.Name = "MainForm";
			this.Text = "Sample MySQL main form";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbServiceName;
		private System.Windows.Forms.TextBox tbServiceName;
		private System.Windows.Forms.Label lbServiceStatus;
		private System.Windows.Forms.Button btServiceRefresh;
		private System.Windows.Forms.Button btServiceStart;
		private System.Windows.Forms.Button btServiceStop;
		private System.Windows.Forms.Button btCheckTable;
	}
}

