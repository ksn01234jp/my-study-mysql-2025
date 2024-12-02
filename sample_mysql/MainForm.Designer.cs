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
			this.lbServiceStatus.Location = new System.Drawing.Point(329, 20);
			this.lbServiceStatus.Name = "lbServiceStatus";
			this.lbServiceStatus.Size = new System.Drawing.Size(80, 16);
			this.lbServiceStatus.TabIndex = 2;
			this.lbServiceStatus.Text = "STARTING";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(661, 358);
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
	}
}

