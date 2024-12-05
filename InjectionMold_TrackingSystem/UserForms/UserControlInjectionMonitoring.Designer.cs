namespace InjectionMold_TrackingSystem.UserForms
{
    partial class UserControlInjectionMonitoring
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.Location_cmb = new System.Windows.Forms.TextBox();
            this.ScanData = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SaveData = new System.Windows.Forms.Button();
            this.ShotCount_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Remarks_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Status_cmb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Customer_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DieNumber_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MoldNumber_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PartNumber_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.moldStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moldTrackingSystemDataSet = new InjectionMold_TrackingSystem.MoldTrackingSystemDataSet();
            this.moldStatusTableAdapter = new InjectionMold_TrackingSystem.MoldTrackingSystemDataSetTableAdapters.MoldStatusTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TransactionDataGridView = new Zuby.ADGV.AdvancedDataGridView();
            this.panel1.SuspendLayout();
            this.InputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moldStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moldTrackingSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TransactionDataGridView);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(17, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 302);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaction Logs";
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
            // Column9
            // 
            this.Column9.Name = "Column9";
            // 
            // Column2
            // 
            this.Column2.Name = "Column2";
            // 
            // Column10
            // 
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.Name = "Column11";
            // 
            // UserId
            // 
            this.UserId.Name = "UserId";
            // 
            // InputPanel
            // 
            this.InputPanel.Controls.Add(this.Location_cmb);
            this.InputPanel.Controls.Add(this.ScanData);
            this.InputPanel.Controls.Add(this.label10);
            this.InputPanel.Controls.Add(this.ClearButton);
            this.InputPanel.Controls.Add(this.SaveData);
            this.InputPanel.Controls.Add(this.ShotCount_txt);
            this.InputPanel.Controls.Add(this.label9);
            this.InputPanel.Controls.Add(this.label8);
            this.InputPanel.Controls.Add(this.Remarks_txt);
            this.InputPanel.Controls.Add(this.label7);
            this.InputPanel.Controls.Add(this.Status_cmb);
            this.InputPanel.Controls.Add(this.label6);
            this.InputPanel.Controls.Add(this.Customer_txt);
            this.InputPanel.Controls.Add(this.label5);
            this.InputPanel.Controls.Add(this.DieNumber_txt);
            this.InputPanel.Controls.Add(this.label4);
            this.InputPanel.Controls.Add(this.MoldNumber_txt);
            this.InputPanel.Controls.Add(this.label3);
            this.InputPanel.Controls.Add(this.PartNumber_txt);
            this.InputPanel.Controls.Add(this.label2);
            this.InputPanel.Controls.Add(this.label11);
            this.InputPanel.Location = new System.Drawing.Point(17, 325);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(851, 322);
            this.InputPanel.TabIndex = 1;
            // 
            // Location_cmb
            // 
            this.Location_cmb.Location = new System.Drawing.Point(585, 105);
            this.Location_cmb.Name = "Location_cmb";
            this.Location_cmb.ReadOnly = true;
            this.Location_cmb.Size = new System.Drawing.Size(213, 22);
            this.Location_cmb.TabIndex = 81;
            this.Location_cmb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Location_cmb_KeyDown);
            // 
            // ScanData
            // 
            this.ScanData.Location = new System.Drawing.Point(585, 13);
            this.ScanData.Name = "ScanData";
            this.ScanData.Size = new System.Drawing.Size(213, 22);
            this.ScanData.TabIndex = 80;
            this.ScanData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ScanData_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(439, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 17);
            this.label10.TabIndex = 79;
            this.label10.Text = "Scan QR Code Here:";
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(127)))), ((int)(((byte)(57)))));
            this.ClearButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(674, 269);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(126, 42);
            this.ClearButton.TabIndex = 78;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SaveData
            // 
            this.SaveData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(127)))), ((int)(((byte)(57)))));
            this.SaveData.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveData.ForeColor = System.Drawing.Color.White;
            this.SaveData.Location = new System.Drawing.Point(517, 269);
            this.SaveData.Name = "SaveData";
            this.SaveData.Size = new System.Drawing.Size(126, 42);
            this.SaveData.TabIndex = 77;
            this.SaveData.Text = "Save";
            this.SaveData.UseVisualStyleBackColor = false;
            this.SaveData.Click += new System.EventHandler(this.SaveData_Click);
            // 
            // ShotCount_txt
            // 
            this.ShotCount_txt.Location = new System.Drawing.Point(222, 232);
            this.ShotCount_txt.Name = "ShotCount_txt";
            this.ShotCount_txt.Size = new System.Drawing.Size(102, 22);
            this.ShotCount_txt.TabIndex = 76;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(131, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 75;
            this.label9.Text = "Shot Count:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(510, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 73;
            this.label8.Text = "Location:";
            // 
            // Remarks_txt
            // 
            this.Remarks_txt.Location = new System.Drawing.Point(585, 159);
            this.Remarks_txt.Multiline = true;
            this.Remarks_txt.Name = "Remarks_txt";
            this.Remarks_txt.Size = new System.Drawing.Size(213, 95);
            this.Remarks_txt.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(510, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 71;
            this.label7.Text = "Remarks:";
            // 
            // Status_cmb
            // 
            this.Status_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Status_cmb.FormattingEnabled = true;
            this.Status_cmb.Items.AddRange(new object[] {
            "Mold Set-up (Start)",
            "Mold Set-up (End)",
            "End of Schedule (Downmold)",
            "End of Schedule (Standby-at-machine)"});
            this.Status_cmb.Location = new System.Drawing.Point(585, 53);
            this.Status_cmb.Name = "Status_cmb";
            this.Status_cmb.Size = new System.Drawing.Size(213, 25);
            this.Status_cmb.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(529, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 69;
            this.label6.Text = "Status:";
            // 
            // Customer_txt
            // 
            this.Customer_txt.Location = new System.Drawing.Point(222, 186);
            this.Customer_txt.Name = "Customer_txt";
            this.Customer_txt.ReadOnly = true;
            this.Customer_txt.Size = new System.Drawing.Size(102, 22);
            this.Customer_txt.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(141, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 67;
            this.label5.Text = "Customer:";
            // 
            // DieNumber_txt
            // 
            this.DieNumber_txt.Location = new System.Drawing.Point(222, 141);
            this.DieNumber_txt.Name = "DieNumber_txt";
            this.DieNumber_txt.ReadOnly = true;
            this.DieNumber_txt.Size = new System.Drawing.Size(102, 22);
            this.DieNumber_txt.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 65;
            this.label4.Text = "Die Number:";
            // 
            // MoldNumber_txt
            // 
            this.MoldNumber_txt.Location = new System.Drawing.Point(222, 94);
            this.MoldNumber_txt.Name = "MoldNumber_txt";
            this.MoldNumber_txt.ReadOnly = true;
            this.MoldNumber_txt.Size = new System.Drawing.Size(213, 22);
            this.MoldNumber_txt.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 63;
            this.label3.Text = "Mold Number:";
            // 
            // PartNumber_txt
            // 
            this.PartNumber_txt.Location = new System.Drawing.Point(222, 48);
            this.PartNumber_txt.Name = "PartNumber_txt";
            this.PartNumber_txt.ReadOnly = true;
            this.PartNumber_txt.Size = new System.Drawing.Size(213, 22);
            this.PartNumber_txt.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 61;
            this.label2.Text = "Part Number:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(62, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 19);
            this.label11.TabIndex = 60;
            this.label11.Text = "Data Entry";
            // 
            // moldStatusBindingSource
            // 
            this.moldStatusBindingSource.DataMember = "MoldStatus";
            this.moldStatusBindingSource.DataSource = this.moldTrackingSystemDataSet;
            // 
            // moldTrackingSystemDataSet
            // 
            this.moldTrackingSystemDataSet.DataSetName = "MoldTrackingSystemDataSet";
            this.moldTrackingSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moldStatusTableAdapter
            // 
            this.moldStatusTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(585, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 81;
            // 
            // TransactionDataGridView
            // 
            this.TransactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionDataGridView.FilterAndSortEnabled = true;
            this.TransactionDataGridView.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.TransactionDataGridView.Location = new System.Drawing.Point(169, 74);
            this.TransactionDataGridView.MaxFilterButtonImageHeight = 23;
            this.TransactionDataGridView.Name = "TransactionDataGridView";
            this.TransactionDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TransactionDataGridView.Size = new System.Drawing.Size(240, 150);
            this.TransactionDataGridView.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.TransactionDataGridView.TabIndex = 1;
            // 
            // UserControlInjectionMonitoring
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.InputPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControlInjectionMonitoring";
            this.Size = new System.Drawing.Size(884, 660);
            this.Load += new System.EventHandler(this.UserControlInjectionMonitoring_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moldStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moldTrackingSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
      //  private ADGV.AdvancedDataGridView TransactionDataGridView;
        private System.Windows.Forms.TextBox ScanData;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SaveData;
        private System.Windows.Forms.TextBox ShotCount_txt;
        private System.Windows.Forms.Label label9;
        //private System.Windows.Forms.ComboBox Location_cmb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Remarks_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Status_cmb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Customer_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DieNumber_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MoldNumber_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PartNumber_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource moldStatusBindingSource;
        private MoldTrackingSystemDataSet moldTrackingSystemDataSet;
        private MoldTrackingSystemDataSetTableAdapters.MoldStatusTableAdapter moldStatusTableAdapter;
        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.TextBox Location_cmb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private Zuby.ADGV.AdvancedDataGridView TransactionDataGridView;
    }
}
