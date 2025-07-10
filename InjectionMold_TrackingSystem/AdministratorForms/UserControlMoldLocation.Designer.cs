namespace InjectionMold_TrackingSystem.AdministratorForms
{
    partial class UserControlMoldLocation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlMoldLocation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TransactionDataGridView = new Zuby.ADGV.AdvancedDataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.AddNewMold = new System.Windows.Forms.Button();
            this.DeleteData = new System.Windows.Forms.DataGridViewImageColumn();
            this.PrintLocation = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TransactionDataGridView);
            this.panel1.Location = new System.Drawing.Point(17, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 506);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(436, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 88;
            this.label1.Text = "Print Preview";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(433, 231);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(393, 257);
            this.panel3.TabIndex = 87;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(13, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 257);
            this.panel2.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 64;
            this.label2.Text = "Add New location";
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
            this.DeleteData,
            this.PrintLocation});
            this.TransactionDataGridView.EnableHeadersVisualStyles = false;
            this.TransactionDataGridView.FilterAndSortEnabled = true;
            this.TransactionDataGridView.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.TransactionDataGridView.Location = new System.Drawing.Point(13, 11);
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
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.TransactionDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.TransactionDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.TransactionDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.TransactionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.TransactionDataGridView.Size = new System.Drawing.Size(813, 187);
            this.TransactionDataGridView.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.TransactionDataGridView.TabIndex = 86;
            this.TransactionDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TransactionDataGridView_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mold Location";
            // 
            // Column3
            // 
            this.Column3.Name = "Column3";
            // 
            // Column1
            // 
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.Name = "Column2";
            // 
            // Column6
            // 
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.Name = "Column7";
            // 
            // AddNewMold
            // 
            this.AddNewMold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(127)))), ((int)(((byte)(57)))));
            this.AddNewMold.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewMold.ForeColor = System.Drawing.Color.White;
            this.AddNewMold.Location = new System.Drawing.Point(734, 29);
            this.AddNewMold.Name = "AddNewMold";
            this.AddNewMold.Size = new System.Drawing.Size(126, 42);
            this.AddNewMold.TabIndex = 62;
            this.AddNewMold.Text = "Add new location";
            this.AddNewMold.UseVisualStyleBackColor = false;
            this.AddNewMold.Click += new System.EventHandler(this.AddNewMold_Click);
            // 
            // DeleteData
            // 
            this.DeleteData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeleteData.HeaderText = "Delete";
            this.DeleteData.Image = ((System.Drawing.Image)(resources.GetObject("DeleteData.Image")));
            this.DeleteData.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.DeleteData.MinimumWidth = 24;
            this.DeleteData.Name = "DeleteData";
            this.DeleteData.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.DeleteData.ToolTipText = "Delete Data";
            this.DeleteData.Visible = false;
            // 
            // PrintLocation
            // 
            this.PrintLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrintLocation.HeaderText = "Print";
            this.PrintLocation.Image = ((System.Drawing.Image)(resources.GetObject("PrintLocation.Image")));
            this.PrintLocation.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.PrintLocation.MinimumWidth = 24;
            this.PrintLocation.Name = "PrintLocation";
            this.PrintLocation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.PrintLocation.Visible = false;
            // 
            // UserControlMoldLocation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.AddNewMold);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControlMoldLocation";
            this.Size = new System.Drawing.Size(884, 660);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column6;
        private System.Windows.Forms.DataGridViewImageColumn Column7;
        public System.Windows.Forms.Button AddNewMold;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        public Zuby.ADGV.AdvancedDataGridView TransactionDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewImageColumn DeleteData;
        private System.Windows.Forms.DataGridViewImageColumn PrintLocation;
    }
}
