namespace sample_mysql
{
	partial class CreateTableForm
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
			this.lbSchemaName = new System.Windows.Forms.Label();
			this.tbSchemaName = new System.Windows.Forms.TextBox();
			this.lbTableName = new System.Windows.Forms.Label();
			this.tbTableName = new System.Windows.Forms.TextBox();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.colColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDataType = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.colOption = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btAddRow = new System.Windows.Forms.Button();
			this.btDeleteRow = new System.Windows.Forms.Button();
			this.lbColumnTable = new System.Windows.Forms.Label();
			this.btCreateQuery = new System.Windows.Forms.Button();
			this.tbQuery = new System.Windows.Forms.TextBox();
			this.btExecuteQuery = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// lbSchemaName
			// 
			this.lbSchemaName.AutoSize = true;
			this.lbSchemaName.Location = new System.Drawing.Point(20, 21);
			this.lbSchemaName.Name = "lbSchemaName";
			this.lbSchemaName.Size = new System.Drawing.Size(99, 16);
			this.lbSchemaName.TabIndex = 3;
			this.lbSchemaName.Text = "schema name";
			// 
			// tbSchemaName
			// 
			this.tbSchemaName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbSchemaName.Location = new System.Drawing.Point(137, 18);
			this.tbSchemaName.Name = "tbSchemaName";
			this.tbSchemaName.Size = new System.Drawing.Size(641, 23);
			this.tbSchemaName.TabIndex = 2;
			this.tbSchemaName.Text = "sample_schema";
			// 
			// lbTableName
			// 
			this.lbTableName.AutoSize = true;
			this.lbTableName.Location = new System.Drawing.Point(20, 58);
			this.lbTableName.Name = "lbTableName";
			this.lbTableName.Size = new System.Drawing.Size(81, 16);
			this.lbTableName.TabIndex = 4;
			this.lbTableName.Text = "table name";
			// 
			// tbTableName
			// 
			this.tbTableName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbTableName.Location = new System.Drawing.Point(137, 55);
			this.tbTableName.Name = "tbTableName";
			this.tbTableName.Size = new System.Drawing.Size(641, 23);
			this.tbTableName.TabIndex = 5;
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colColumnName,
            this.colDataType,
            this.colOption});
			this.dataGridView.Location = new System.Drawing.Point(23, 124);
			this.dataGridView.MultiSelect = false;
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowTemplate.Height = 21;
			this.dataGridView.Size = new System.Drawing.Size(755, 113);
			this.dataGridView.TabIndex = 6;
			// 
			// colColumnName
			// 
			this.colColumnName.HeaderText = "COLUMN_NAME";
			this.colColumnName.Name = "colColumnName";
			this.colColumnName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.colColumnName.Width = 200;
			// 
			// colDataType
			// 
			this.colDataType.HeaderText = "DATA_TYPE";
			this.colDataType.Name = "colDataType";
			this.colDataType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.colDataType.Width = 200;
			// 
			// colOption
			// 
			this.colOption.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colOption.HeaderText = "option";
			this.colOption.Name = "colOption";
			this.colOption.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// btAddRow
			// 
			this.btAddRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btAddRow.Font = new System.Drawing.Font("MS UI Gothic", 10F);
			this.btAddRow.Location = new System.Drawing.Point(671, 95);
			this.btAddRow.Name = "btAddRow";
			this.btAddRow.Size = new System.Drawing.Size(107, 23);
			this.btAddRow.TabIndex = 7;
			this.btAddRow.Text = "Add Row";
			this.btAddRow.UseVisualStyleBackColor = true;
			this.btAddRow.Click += new System.EventHandler(this.AddRow_Click);
			// 
			// btDeleteRow
			// 
			this.btDeleteRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btDeleteRow.Font = new System.Drawing.Font("MS UI Gothic", 10F);
			this.btDeleteRow.Location = new System.Drawing.Point(548, 95);
			this.btDeleteRow.Name = "btDeleteRow";
			this.btDeleteRow.Size = new System.Drawing.Size(107, 23);
			this.btDeleteRow.TabIndex = 8;
			this.btDeleteRow.Text = "Delete Row";
			this.btDeleteRow.UseVisualStyleBackColor = true;
			this.btDeleteRow.Click += new System.EventHandler(this.DeleteRow_Click);
			// 
			// lbColumnTable
			// 
			this.lbColumnTable.AutoSize = true;
			this.lbColumnTable.Location = new System.Drawing.Point(20, 97);
			this.lbColumnTable.Name = "lbColumnTable";
			this.lbColumnTable.Size = new System.Drawing.Size(78, 16);
			this.lbColumnTable.TabIndex = 9;
			this.lbColumnTable.Text = "column list";
			// 
			// btCreateQuery
			// 
			this.btCreateQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btCreateQuery.Font = new System.Drawing.Font("MS UI Gothic", 12F);
			this.btCreateQuery.Location = new System.Drawing.Point(23, 243);
			this.btCreateQuery.Name = "btCreateQuery";
			this.btCreateQuery.Size = new System.Drawing.Size(755, 31);
			this.btCreateQuery.TabIndex = 10;
			this.btCreateQuery.Text = "Create Query";
			this.btCreateQuery.UseVisualStyleBackColor = true;
			this.btCreateQuery.Click += new System.EventHandler(this.CreateQuery_Click);
			// 
			// tbQuery
			// 
			this.tbQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbQuery.Location = new System.Drawing.Point(23, 280);
			this.tbQuery.Multiline = true;
			this.tbQuery.Name = "tbQuery";
			this.tbQuery.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbQuery.Size = new System.Drawing.Size(755, 69);
			this.tbQuery.TabIndex = 11;
			// 
			// btExecuteQuery
			// 
			this.btExecuteQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btExecuteQuery.Font = new System.Drawing.Font("MS UI Gothic", 12F);
			this.btExecuteQuery.Location = new System.Drawing.Point(23, 355);
			this.btExecuteQuery.Name = "btExecuteQuery";
			this.btExecuteQuery.Size = new System.Drawing.Size(755, 31);
			this.btExecuteQuery.TabIndex = 12;
			this.btExecuteQuery.Text = "Execute Query";
			this.btExecuteQuery.UseVisualStyleBackColor = true;
			this.btExecuteQuery.Click += new System.EventHandler(this.ExecuteQuery_Click);
			// 
			// CreateTableForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(805, 396);
			this.Controls.Add(this.btExecuteQuery);
			this.Controls.Add(this.tbQuery);
			this.Controls.Add(this.btCreateQuery);
			this.Controls.Add(this.lbColumnTable);
			this.Controls.Add(this.btDeleteRow);
			this.Controls.Add(this.btAddRow);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.tbTableName);
			this.Controls.Add(this.lbTableName);
			this.Controls.Add(this.lbSchemaName);
			this.Controls.Add(this.tbSchemaName);
			this.Font = new System.Drawing.Font("MS UI Gothic", 12F);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "CreateTableForm";
			this.Text = "Create Table Form";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbSchemaName;
		private System.Windows.Forms.TextBox tbSchemaName;
		private System.Windows.Forms.Label lbTableName;
		private System.Windows.Forms.TextBox tbTableName;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn colColumnName;
		private System.Windows.Forms.DataGridViewComboBoxColumn colDataType;
		private System.Windows.Forms.DataGridViewTextBoxColumn colOption;
		private System.Windows.Forms.Button btAddRow;
		private System.Windows.Forms.Button btDeleteRow;
		private System.Windows.Forms.Label lbColumnTable;
		private System.Windows.Forms.Button btCreateQuery;
		private System.Windows.Forms.TextBox tbQuery;
		private System.Windows.Forms.Button btExecuteQuery;
	}
}