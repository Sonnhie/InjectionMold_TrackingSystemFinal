namespace InjectionMold_TrackingSystem.UserForms
{
    partial class UserControlMoldMonitoring
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TransactionDataGridView = new Zuby.ADGV.AdvancedDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.Location_cmb = new System.Windows.Forms.TextBox();
            this.ScanData = new System.Windows.Forms.TextBox();
            this.ScanDatalbl = new System.Windows.Forms.Label();
            this.SaveData = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Remarks_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
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
            this.label9 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelDbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDataGridView)).BeginInit();
            this.InputPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TransactionDataGridView);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(17, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 272);
            this.panel1.TabIndex = 2;
            // 
            // TransactionDataGridView
            // 
            this.TransactionDataGridView.AllowUserToAddRows = false;
            this.TransactionDataGridView.AllowUserToDeleteRows = false;
            this.TransactionDataGridView.AllowUserToResizeColumns = false;
            this.TransactionDataGridView.AllowUserToResizeRows = false;
            this.TransactionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TransactionDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(127)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TransactionDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.TransactionDataGridView.EnableHeadersVisualStyles = false;
            this.TransactionDataGridView.FilterAndSortEnabled = true;
            this.TransactionDataGridView.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.TransactionDataGridView.Location = new System.Drawing.Point(17, 42);
            this.TransactionDataGridView.MaxFilterButtonImageHeight = 23;
            this.TransactionDataGridView.Name = "TransactionDataGridView";
            this.TransactionDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TransactionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.TransactionDataGridView.Size = new System.Drawing.Size(815, 213);
            this.TransactionDataGridView.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.TransactionDataGridView.TabIndex = 2;
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
            // Column10
            // 
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.Name = "Column11";
            // 
            // InputPanel
            // 
            this.InputPanel.Controls.Add(this.Location_cmb);
            this.InputPanel.Controls.Add(this.ScanData);
            this.InputPanel.Controls.Add(this.ScanDatalbl);
            this.InputPanel.Controls.Add(this.SaveData);
            this.InputPanel.Controls.Add(this.label8);
            this.InputPanel.Controls.Add(this.Remarks_txt);
            this.InputPanel.Controls.Add(this.label7);
            this.InputPanel.Controls.Add(this.ClearButton);
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
            this.InputPanel.Controls.Add(this.label9);
            this.InputPanel.Location = new System.Drawing.Point(17, 300);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(851, 298);
            this.InputPanel.TabIndex = 3;
            // 
            // Location_cmb
            // 
            this.Location_cmb.Location = new System.Drawing.Point(581, 101);
            this.Location_cmb.Name = "Location_cmb";
            this.Location_cmb.ReadOnly = true;
            this.Location_cmb.Size = new System.Drawing.Size(213, 22);
            this.Location_cmb.TabIndex = 98;
            // 
            // ScanData
            // 
            this.ScanData.Location = new System.Drawing.Point(581, 6);
            this.ScanData.Name = "ScanData";
            this.ScanData.Size = new System.Drawing.Size(213, 22);
            this.ScanData.TabIndex = 97;
            this.ScanData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ScanData_KeyDown_1);
            // 
            // ScanDatalbl
            // 
            this.ScanDatalbl.AutoSize = true;
            this.ScanDatalbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScanDatalbl.Location = new System.Drawing.Point(464, 11);
            this.ScanDatalbl.Name = "ScanDatalbl";
            this.ScanDatalbl.Size = new System.Drawing.Size(112, 17);
            this.ScanDatalbl.TabIndex = 96;
            this.ScanDatalbl.Text = "Scan Data here:";
            // 
            // SaveData
            // 
            this.SaveData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(127)))), ((int)(((byte)(57)))));
            this.SaveData.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveData.ForeColor = System.Drawing.Color.White;
            this.SaveData.Location = new System.Drawing.Point(509, 250);
            this.SaveData.Name = "SaveData";
            this.SaveData.Size = new System.Drawing.Size(126, 42);
            this.SaveData.TabIndex = 94;
            this.SaveData.Text = "Save";
            this.SaveData.UseVisualStyleBackColor = false;
            this.SaveData.Click += new System.EventHandler(this.SaveData_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(506, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 92;
            this.label8.Text = "Location:";
            // 
            // Remarks_txt
            // 
            this.Remarks_txt.Location = new System.Drawing.Point(581, 140);
            this.Remarks_txt.Multiline = true;
            this.Remarks_txt.Name = "Remarks_txt";
            this.Remarks_txt.Size = new System.Drawing.Size(213, 95);
            this.Remarks_txt.TabIndex = 91;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(506, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 90;
            this.label7.Text = "Remarks:";
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(127)))), ((int)(((byte)(57)))));
            this.ClearButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(668, 250);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(126, 42);
            this.ClearButton.TabIndex = 95;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Status_cmb
            // 
            this.Status_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Status_cmb.FormattingEnabled = true;
            this.Status_cmb.Items.AddRange(new object[] {
            "Mold Preparation ",
            "Mold Issuance",
            "Mold Endorsement",
            "Mold Maintenance",
            "Mold Preparation"});
            this.Status_cmb.Location = new System.Drawing.Point(581, 54);
            this.Status_cmb.Name = "Status_cmb";
            this.Status_cmb.Size = new System.Drawing.Size(213, 25);
            this.Status_cmb.TabIndex = 89;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(525, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 88;
            this.label6.Text = "Status:";
            // 
            // Customer_txt
            // 
            this.Customer_txt.Location = new System.Drawing.Point(220, 175);
            this.Customer_txt.Name = "Customer_txt";
            this.Customer_txt.ReadOnly = true;
            this.Customer_txt.Size = new System.Drawing.Size(102, 22);
            this.Customer_txt.TabIndex = 87;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(139, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 86;
            this.label5.Text = "Customer:";
            // 
            // DieNumber_txt
            // 
            this.DieNumber_txt.Location = new System.Drawing.Point(220, 130);
            this.DieNumber_txt.Name = "DieNumber_txt";
            this.DieNumber_txt.ReadOnly = true;
            this.DieNumber_txt.Size = new System.Drawing.Size(102, 22);
            this.DieNumber_txt.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 84;
            this.label4.Text = "Die Number:";
            // 
            // MoldNumber_txt
            // 
            this.MoldNumber_txt.Location = new System.Drawing.Point(220, 83);
            this.MoldNumber_txt.Name = "MoldNumber_txt";
            this.MoldNumber_txt.ReadOnly = true;
            this.MoldNumber_txt.Size = new System.Drawing.Size(213, 22);
            this.MoldNumber_txt.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 82;
            this.label3.Text = "Mold Number:";
            // 
            // PartNumber_txt
            // 
            this.PartNumber_txt.Location = new System.Drawing.Point(220, 37);
            this.PartNumber_txt.Name = "PartNumber_txt";
            this.PartNumber_txt.ReadOnly = true;
            this.PartNumber_txt.Size = new System.Drawing.Size(213, 22);
            this.PartNumber_txt.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 80;
            this.label2.Text = "Part Number:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(56, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 19);
            this.label9.TabIndex = 79;
            this.label9.Text = "Data Entry";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelDbStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 638);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(884, 22);
            this.statusStrip1.TabIndex = 99;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelDbStatus
            // 
            this.toolStripStatusLabelDbStatus.Name = "toolStripStatusLabelDbStatus";
            this.toolStripStatusLabelDbStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserControlMoldMonitoring
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InputPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlMoldMonitoring";
            this.Size = new System.Drawing.Size(884, 660);
            this.Load += new System.EventHandler(this.UserControlMoldMonitoring_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDataGridView)).EndInit();
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
      //  private ADGV.AdvancedDataGridView TransactionDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.TextBox ScanData;
        private System.Windows.Forms.Label ScanDatalbl;
        private System.Windows.Forms.Button SaveData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Remarks_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ClearButton;
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
        private System.Windows.Forms.Label label9;
        private Zuby.ADGV.AdvancedDataGridView TransactionDataGridView;
        private System.Windows.Forms.TextBox Location_cmb;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDbStatus;
        private System.Windows.Forms.Timer timer1;
    }
}
