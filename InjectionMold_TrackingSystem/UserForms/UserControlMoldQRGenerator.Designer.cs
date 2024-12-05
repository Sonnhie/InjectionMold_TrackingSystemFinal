namespace InjectionMold_TrackingSystem.UserForms
{
    partial class UserControlMoldQRGenerator
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMoldNumber = new System.Windows.Forms.TextBox();
            this.textBoxPartNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDieNumber = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxQRCode = new System.Windows.Forms.PictureBox();
            this.PrintQRCode = new System.Windows.Forms.Button();
            this.comboBoxCustomer = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.TransactionDataGridView = new Zuby.ADGV.AdvancedDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mold QR Generator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mold Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Part Number:";
            // 
            // textBoxMoldNumber
            // 
            this.textBoxMoldNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxMoldNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxMoldNumber.Location = new System.Drawing.Point(144, 103);
            this.textBoxMoldNumber.Name = "textBoxMoldNumber";
            this.textBoxMoldNumber.ReadOnly = true;
            this.textBoxMoldNumber.Size = new System.Drawing.Size(185, 22);
            this.textBoxMoldNumber.TabIndex = 7;
            this.textBoxMoldNumber.TextChanged += new System.EventHandler(this.textBoxMoldNumber_TextChanged);
            // 
            // textBoxPartNumber
            // 
            this.textBoxPartNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxPartNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxPartNumber.Location = new System.Drawing.Point(144, 63);
            this.textBoxPartNumber.Name = "textBoxPartNumber";
            this.textBoxPartNumber.Size = new System.Drawing.Size(185, 22);
            this.textBoxPartNumber.TabIndex = 8;
            this.textBoxPartNumber.TextChanged += new System.EventHandler(this.textBoxPartNumber_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Die Number:";
            // 
            // comboBoxDieNumber
            // 
            this.comboBoxDieNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDieNumber.FormattingEnabled = true;
            this.comboBoxDieNumber.Items.AddRange(new object[] {
            "D1",
            "D2",
            "D3"});
            this.comboBoxDieNumber.Location = new System.Drawing.Point(143, 146);
            this.comboBoxDieNumber.Name = "comboBoxDieNumber";
            this.comboBoxDieNumber.Size = new System.Drawing.Size(121, 25);
            this.comboBoxDieNumber.TabIndex = 10;
            this.comboBoxDieNumber.TextChanged += new System.EventHandler(this.comboBoxDieNumber_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Customer:";
            // 
            // pictureBoxQRCode
            // 
            this.pictureBoxQRCode.Location = new System.Drawing.Point(143, 246);
            this.pictureBoxQRCode.Name = "pictureBoxQRCode";
            this.pictureBoxQRCode.Size = new System.Drawing.Size(101, 85);
            this.pictureBoxQRCode.TabIndex = 13;
            this.pictureBoxQRCode.TabStop = false;
            // 
            // PrintQRCode
            // 
            this.PrintQRCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(127)))), ((int)(((byte)(57)))));
            this.PrintQRCode.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintQRCode.ForeColor = System.Drawing.Color.White;
            this.PrintQRCode.Location = new System.Drawing.Point(141, 338);
            this.PrintQRCode.Name = "PrintQRCode";
            this.PrintQRCode.Size = new System.Drawing.Size(106, 38);
            this.PrintQRCode.TabIndex = 77;
            this.PrintQRCode.Text = "Print QR";
            this.PrintQRCode.UseVisualStyleBackColor = false;
            this.PrintQRCode.Click += new System.EventHandler(this.PrintQRCode_Click);
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBoxCustomer.Location = new System.Drawing.Point(143, 199);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(121, 22);
            this.comboBoxCustomer.TabIndex = 78;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(354, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 360);
            this.panel1.TabIndex = 80;
            // 
            // Column2
            // 
            this.Column2.Name = "Column2";
            // 
            // Column5
            // 
            this.Column5.Name = "Column5";
            // 
            // Column1
            // 
            this.Column1.Name = "Column1";
            // 
            // Column6
            // 
            this.Column6.Name = "Column6";
            // 
            // Column4
            // 
            this.Column4.Name = "Column4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(23, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 92;
            this.label6.Text = "Print Logs";
            // 
            // TransactionDataGridView
            // 
            this.TransactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionDataGridView.FilterAndSortEnabled = true;
            this.TransactionDataGridView.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.TransactionDataGridView.Location = new System.Drawing.Point(97, 448);
            this.TransactionDataGridView.MaxFilterButtonImageHeight = 23;
            this.TransactionDataGridView.Name = "TransactionDataGridView";
            this.TransactionDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TransactionDataGridView.Size = new System.Drawing.Size(240, 150);
            this.TransactionDataGridView.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.TransactionDataGridView.TabIndex = 93;
            // 
            // UserControlMoldQRGenerator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.TransactionDataGridView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxCustomer);
            this.Controls.Add(this.PrintQRCode);
            this.Controls.Add(this.pictureBoxQRCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxDieNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPartNumber);
            this.Controls.Add(this.textBoxMoldNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControlMoldQRGenerator";
            this.Size = new System.Drawing.Size(884, 660);
            this.Load += new System.EventHandler(this.UserControlMoldQRGenerator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMoldNumber;
        private System.Windows.Forms.TextBox textBoxPartNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxDieNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxQRCode;
        private System.Windows.Forms.Button PrintQRCode;
        private System.Windows.Forms.TextBox comboBoxCustomer;
        private System.Windows.Forms.Panel panel1;
        //private ADGV.AdvancedDataGridView TransactionDataGridView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Zuby.ADGV.AdvancedDataGridView TransactionDataGridView;
    }
}
