namespace InjectionMold_TrackingSystem.UserForms
{
    partial class UserControlTransactionHistory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlTransactionHistory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ExportDataToCSV = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionDataGridView = new Zuby.ADGV.AdvancedDataGridView();
            this.UpdateData = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteData = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TransactionDataGridView);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.EndDatePicker);
            this.panel1.Controls.Add(this.StartDatePicker);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.ExportDataToCSV);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(14, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 591);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 81;
            this.label2.Text = "From:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(596, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 80;
            this.label1.Text = "To:";
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Location = new System.Drawing.Point(622, 27);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(211, 22);
            this.EndDatePicker.TabIndex = 79;
            this.EndDatePicker.ValueChanged += new System.EventHandler(this.EndDatePicker_ValueChanged);
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Location = new System.Drawing.Point(366, 27);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(220, 22);
            this.StartDatePicker.TabIndex = 78;
            this.StartDatePicker.ValueChanged += new System.EventHandler(this.StartDatePicker_ValueChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 549);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(689, 22);
            this.progressBar1.TabIndex = 77;
            // 
            // ExportDataToCSV
            // 
            this.ExportDataToCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(127)))), ((int)(((byte)(57)))));
            this.ExportDataToCSV.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportDataToCSV.ForeColor = System.Drawing.Color.White;
            this.ExportDataToCSV.Location = new System.Drawing.Point(711, 545);
            this.ExportDataToCSV.Name = "ExportDataToCSV";
            this.ExportDataToCSV.Size = new System.Drawing.Size(126, 36);
            this.ExportDataToCSV.TabIndex = 76;
            this.ExportDataToCSV.Text = "Export To Excel";
            this.ExportDataToCSV.UseVisualStyleBackColor = false;
            this.ExportDataToCSV.Click += new System.EventHandler(this.ExportDataToCSV_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Transaction History";
            // 
            // Column2
            // 
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.Name = "Column5";
            // 
            // Column8
            // 
            this.Column8.Name = "Column8";
            // 
            // Column6
            // 
            this.Column6.Name = "Column6";
            // 
            // Column9
            // 
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.Name = "Column11";
            // 
            // UserID
            // 
            this.UserID.Name = "UserID";
            // 
            // TransactionDataGridView
            // 
            this.TransactionDataGridView.AllowUserToAddRows = false;
            this.TransactionDataGridView.AllowUserToDeleteRows = false;
            this.TransactionDataGridView.AllowUserToResizeColumns = false;
            this.TransactionDataGridView.AllowUserToResizeRows = false;
            this.TransactionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TransactionDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(127)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TransactionDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TransactionDataGridView.ColumnHeadersHeight = 26;
            this.TransactionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UpdateData,
            this.DeleteData});
            this.TransactionDataGridView.EnableHeadersVisualStyles = false;
            this.TransactionDataGridView.FilterAndSortEnabled = true;
            this.TransactionDataGridView.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.TransactionDataGridView.Location = new System.Drawing.Point(16, 67);
            this.TransactionDataGridView.MaxFilterButtonImageHeight = 23;
            this.TransactionDataGridView.Name = "TransactionDataGridView";
            this.TransactionDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TransactionDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TransactionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.TransactionDataGridView.Size = new System.Drawing.Size(817, 472);
            this.TransactionDataGridView.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.TransactionDataGridView.TabIndex = 85;
            // 
            // UpdateData
            // 
            this.UpdateData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UpdateData.HeaderText = "Update";
            this.UpdateData.Image = ((System.Drawing.Image)(resources.GetObject("UpdateData.Image")));
            this.UpdateData.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.UpdateData.MinimumWidth = 24;
            this.UpdateData.Name = "UpdateData";
            this.UpdateData.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.UpdateData.ToolTipText = "Update Data";
            this.UpdateData.Visible = false;
            this.UpdateData.Width = 78;
            // 
            // DeleteData
            // 
            this.DeleteData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DeleteData.HeaderText = "Delete";
            this.DeleteData.Image = ((System.Drawing.Image)(resources.GetObject("DeleteData.Image")));
            this.DeleteData.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.DeleteData.MinimumWidth = 24;
            this.DeleteData.Name = "DeleteData";
            this.DeleteData.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.DeleteData.ToolTipText = "Delete Data";
            this.DeleteData.Visible = false;
            this.DeleteData.Width = 74;
            // 
            // UserControlTransactionHistory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControlTransactionHistory";
            this.Size = new System.Drawing.Size(884, 660);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
      //  private ADGV.AdvancedDataGridView TransactionDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ExportDataToCSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private Zuby.ADGV.AdvancedDataGridView TransactionDataGridView;
        private System.Windows.Forms.DataGridViewImageColumn UpdateData;
        private System.Windows.Forms.DataGridViewImageColumn DeleteData;
    }
}
