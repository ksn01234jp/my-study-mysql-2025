namespace sample_mysql
{
	partial class CheckTableForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tbSchemaName = new System.Windows.Forms.TextBox();
			this.lbSchemaName = new System.Windows.Forms.Label();
			this.cbShowColumnDataType = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbQuery = new System.Windows.Forms.TextBox();
			this.btExecuteQuery = new System.Windows.Forms.Button();
			this.btCreateQuery = new System.Windows.Forms.Button();
			this.tbResult = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// tbSchemaName
			// 
			this.tbSchemaName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbSchemaName.Location = new System.Drawing.Point(134, 13);
			this.tbSchemaName.Name = "tbSchemaName";
			this.tbSchemaName.Size = new System.Drawing.Size(391, 23);
			this.tbSchemaName.TabIndex = 0;
			this.tbSchemaName.Text = "sample_schema";
			// 
			// lbSchemaName
			// 
			this.lbSchemaName.AutoSize = true;
			this.lbSchemaName.Location = new System.Drawing.Point(17, 16);
			this.lbSchemaName.Name = "lbSchemaName";
			this.lbSchemaName.Size = new System.Drawing.Size(99, 16);
			this.lbSchemaName.TabIndex = 1;
			this.lbSchemaName.Text = "schema name";
			// 
			// cbShowColumnDataType
			// 
			this.cbShowColumnDataType.AutoSize = true;
			this.cbShowColumnDataType.Checked = true;
			this.cbShowColumnDataType.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbShowColumnDataType.Location = new System.Drawing.Point(134, 57);
			this.cbShowColumnDataType.Name = "cbShowColumnDataType";
			this.cbShowColumnDataType.Size = new System.Drawing.Size(132, 20);
			this.cbShowColumnDataType.TabIndex = 2;
			this.cbShowColumnDataType.Text = "カラム、型を表示";
			this.cbShowColumnDataType.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 16);
			this.label1.TabIndex = 3;
			// 
			// tbQuery
			// 
			this.tbQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbQuery.Location = new System.Drawing.Point(20, 99);
			this.tbQuery.Multiline = true;
			this.tbQuery.Name = "tbQuery";
			this.tbQuery.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbQuery.Size = new System.Drawing.Size(505, 97);
			this.tbQuery.TabIndex = 4;
			// 
			// btExecuteQuery
			// 
			this.btExecuteQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btExecuteQuery.Location = new System.Drawing.Point(20, 214);
			this.btExecuteQuery.Name = "btExecuteQuery";
			this.btExecuteQuery.Size = new System.Drawing.Size(505, 36);
			this.btExecuteQuery.TabIndex = 5;
			this.btExecuteQuery.Text = "Execute Query";
			this.btExecuteQuery.UseVisualStyleBackColor = true;
			this.btExecuteQuery.Click += new System.EventHandler(this.ExecuteQuery_Click);
			// 
			// btCreateQuery
			// 
			this.btCreateQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btCreateQuery.Location = new System.Drawing.Point(317, 48);
			this.btCreateQuery.Name = "btCreateQuery";
			this.btCreateQuery.Size = new System.Drawing.Size(208, 36);
			this.btCreateQuery.TabIndex = 6;
			this.btCreateQuery.Text = "Create Query";
			this.btCreateQuery.UseVisualStyleBackColor = true;
			this.btCreateQuery.Click += new System.EventHandler(this.CreateQuery_Click);
			// 
			// tbResult
			// 
			this.tbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbResult.Location = new System.Drawing.Point(20, 269);
			this.tbResult.Multiline = true;
			this.tbResult.Name = "tbResult";
			this.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbResult.Size = new System.Drawing.Size(505, 225);
			this.tbResult.TabIndex = 7;
			// 
			// CheckTableForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(547, 506);
			this.Controls.Add(this.tbResult);
			this.Controls.Add(this.btCreateQuery);
			this.Controls.Add(this.btExecuteQuery);
			this.Controls.Add(this.tbQuery);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbShowColumnDataType);
			this.Controls.Add(this.lbSchemaName);
			this.Controls.Add(this.tbSchemaName);
			this.Font = new System.Drawing.Font("MS UI Gothic", 12F);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MinimumSize = new System.Drawing.Size(563, 545);
			this.Name = "CheckTableForm";
			this.Text = "Check Table Form";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbSchemaName;
		private System.Windows.Forms.Label lbSchemaName;
		private System.Windows.Forms.CheckBox cbShowColumnDataType;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbQuery;
		private System.Windows.Forms.Button btExecuteQuery;
		private System.Windows.Forms.Button btCreateQuery;
		private System.Windows.Forms.TextBox tbResult;
	}
}