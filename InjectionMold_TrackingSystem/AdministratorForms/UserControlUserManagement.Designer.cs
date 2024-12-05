namespace InjectionMold_TrackingSystem.AdministratorForms
{
    partial class UserControlUserManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlUserManagement));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TransactionDataGridView = new Zuby.ADGV.AdvancedDataGridView();
            this.RegisterUser = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewImageColumn();
            this.Reset = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.UpdateData = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteUser = new System.Windows.Forms.DataGridViewImageColumn();
            this.ResetPass = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TransactionDataGridView);
            this.panel1.Controls.Add(this.RegisterUser);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 612);
            this.panel1.TabIndex = 0;
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
            this.DeleteUser,
            this.ResetPass});
            this.TransactionDataGridView.EnableHeadersVisualStyles = false;
            this.TransactionDataGridView.FilterAndSortEnabled = true;
            this.TransactionDataGridView.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.TransactionDataGridView.Location = new System.Drawing.Point(22, 63);
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
            this.TransactionDataGridView.Size = new System.Drawing.Size(802, 218);
            this.TransactionDataGridView.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.TransactionDataGridView.TabIndex = 14;
            this.TransactionDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TransactionDataGridView_CellContentClick_1);
            // 
            // RegisterUser
            // 
            this.RegisterUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(127)))), ((int)(((byte)(57)))));
            this.RegisterUser.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterUser.ForeColor = System.Drawing.Color.White;
            this.RegisterUser.Location = new System.Drawing.Point(698, 8);
            this.RegisterUser.Name = "RegisterUser";
            this.RegisterUser.Size = new System.Drawing.Size(126, 42);
            this.RegisterUser.TabIndex = 13;
            this.RegisterUser.Text = "Add User";
            this.RegisterUser.UseVisualStyleBackColor = false;
            this.RegisterUser.Click += new System.EventHandler(this.RegisterUser_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(22, 287);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 310);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "User\'s Account Data";
            // 
            // EmployeeID
            // 
            this.EmployeeID.Name = "EmployeeID";
            // 
            // Column2
            // 
            this.Column2.Name = "Column2";
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
            // Update
            // 
            this.Update.Name = "Update";
            // 
            // Reset
            // 
            this.Reset.Name = "Reset";
            // 
            // Delete
            // 
            this.Delete.Name = "Delete";
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
            this.UpdateData.Visible = false;
            this.UpdateData.Width = 78;
            // 
            // DeleteUser
            // 
            this.DeleteUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DeleteUser.HeaderText = "Delete";
            this.DeleteUser.Image = ((System.Drawing.Image)(resources.GetObject("DeleteUser.Image")));
            this.DeleteUser.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.DeleteUser.MinimumWidth = 24;
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.DeleteUser.Visible = false;
            this.DeleteUser.Width = 74;
            // 
            // ResetPass
            // 
            this.ResetPass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ResetPass.HeaderText = "Change Password";
            this.ResetPass.Image = ((System.Drawing.Image)(resources.GetObject("ResetPass.Image")));
            this.ResetPass.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ResetPass.MinimumWidth = 24;
            this.ResetPass.Name = "ResetPass";
            this.ResetPass.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ResetPass.Visible = false;
            this.ResetPass.Width = 138;
            // 
            // UserControlUserManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControlUserManagement";
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button RegisterUser;
        private System.Windows.Forms.DataGridViewImageColumn Updates;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewImageColumn Update;
        private System.Windows.Forms.DataGridViewImageColumn Reset;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private Zuby.ADGV.AdvancedDataGridView TransactionDataGridView;
        private System.Windows.Forms.DataGridViewImageColumn UpdateData;
        private System.Windows.Forms.DataGridViewImageColumn DeleteUser;
        private System.Windows.Forms.DataGridViewImageColumn ResetPass;
    }
}
