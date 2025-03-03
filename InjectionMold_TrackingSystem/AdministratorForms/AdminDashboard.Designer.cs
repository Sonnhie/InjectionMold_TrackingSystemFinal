namespace InjectionMold_TrackingSystem.AdministratorForms
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitApp = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Dashboard = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.MoldStatusManagement = new System.Windows.Forms.Button();
            this.LocationManagement = new System.Windows.Forms.Button();
            this.TransactionHistory = new System.Windows.Forms.Button();
            this.MoldMasterlist = new System.Windows.Forms.Button();
            this.UserManagement = new System.Windows.Forms.Button();
            this.Wlcome_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitApp)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(153)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.ExitApp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1137, 34);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // ExitApp
            // 
            this.ExitApp.Image = ((System.Drawing.Image)(resources.GetObject("ExitApp.Image")));
            this.ExitApp.Location = new System.Drawing.Point(1112, 4);
            this.ExitApp.Name = "ExitApp";
            this.ExitApp.Size = new System.Drawing.Size(19, 20);
            this.ExitApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitApp.TabIndex = 9;
            this.ExitApp.TabStop = false;
            this.ExitApp.Click += new System.EventHandler(this.ExitApp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "INJECTION MOLD TRACKING SYTEM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.Dashboard);
            this.panel2.Controls.Add(this.Logout);
            this.panel2.Controls.Add(this.MoldStatusManagement);
            this.panel2.Controls.Add(this.LocationManagement);
            this.panel2.Controls.Add(this.TransactionHistory);
            this.panel2.Controls.Add(this.MoldMasterlist);
            this.panel2.Controls.Add(this.UserManagement);
            this.panel2.Controls.Add(this.Wlcome_lbl);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 660);
            this.panel2.TabIndex = 1;
            // 
            // Dashboard
            // 
            this.Dashboard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Dashboard.FlatAppearance.BorderSize = 0;
            this.Dashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(117)))), ((int)(((byte)(101)))));
            this.Dashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(117)))), ((int)(((byte)(101)))));
            this.Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard.ForeColor = System.Drawing.Color.White;
            this.Dashboard.Image = ((System.Drawing.Image)(resources.GetObject("Dashboard.Image")));
            this.Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard.Location = new System.Drawing.Point(0, 241);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Dashboard.Size = new System.Drawing.Size(247, 40);
            this.Dashboard.TabIndex = 8;
            this.Dashboard.Text = "               Dashboard";
            this.Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard.UseVisualStyleBackColor = true;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // Logout
            // 
            this.Logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Logout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Logout.FlatAppearance.BorderSize = 0;
            this.Logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(117)))), ((int)(((byte)(101)))));
            this.Logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(117)))), ((int)(((byte)(101)))));
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.Color.White;
            this.Logout.Image = ((System.Drawing.Image)(resources.GetObject("Logout.Image")));
            this.Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logout.Location = new System.Drawing.Point(0, 620);
            this.Logout.Name = "Logout";
            this.Logout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Logout.Size = new System.Drawing.Size(253, 40);
            this.Logout.TabIndex = 7;
            this.Logout.Text = "             Logout";
            this.Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // MoldStatusManagement
            // 
            this.MoldStatusManagement.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MoldStatusManagement.FlatAppearance.BorderSize = 0;
            this.MoldStatusManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(117)))), ((int)(((byte)(101)))));
            this.MoldStatusManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(117)))), ((int)(((byte)(101)))));
            this.MoldStatusManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoldStatusManagement.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoldStatusManagement.ForeColor = System.Drawing.Color.White;
            this.MoldStatusManagement.Image = ((System.Drawing.Image)(resources.GetObject("MoldStatusManagement.Image")));
            this.MoldStatusManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MoldStatusManagement.Location = new System.Drawing.Point(0, 513);
            this.MoldStatusManagement.Name = "MoldStatusManagement";
            this.MoldStatusManagement.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.MoldStatusManagement.Size = new System.Drawing.Size(247, 40);
            this.MoldStatusManagement.TabIndex = 6;
            this.MoldStatusManagement.Text = "              Mold Status Management";
            this.MoldStatusManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MoldStatusManagement.UseVisualStyleBackColor = true;
            // 
            // LocationManagement
            // 
            this.LocationManagement.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LocationManagement.FlatAppearance.BorderSize = 0;
            this.LocationManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(117)))), ((int)(((byte)(101)))));
            this.LocationManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(117)))), ((int)(((byte)(101)))));
            this.LocationManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LocationManagement.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationManagement.ForeColor = System.Drawing.Color.White;
            this.LocationManagement.Image = ((System.Drawing.Image)(resources.GetObject("LocationManagement.Image")));
            this.LocationManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LocationManagement.Location = new System.Drawing.Point(0, 460);
            this.LocationManagement.Name = "LocationManagement";
            this.LocationManagement.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.LocationManagement.Size = new System.Drawing.Size(247, 40);
            this.LocationManagement.TabIndex = 5;
            this.LocationManagement.Text = "              Mold Location Management";
            this.LocationManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LocationManagement.UseVisualStyleBackColor = true;
            this.LocationManagement.Click += new System.EventHandler(this.LocationManagement_Click);
            // 
            // TransactionHistory
            // 
            this.TransactionHistory.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.TransactionHistory.FlatAppearance.BorderSize = 0;
            this.TransactionHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(117)))), ((int)(((byte)(101)))));
            this.TransactionHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(117)))), ((int)(((byte)(101)))));
            this.TransactionHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransactionHistory.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionHistory.ForeColor = System.Drawing.Color.White;
            this.TransactionHistory.Image = ((System.Drawing.Image)(resources.GetObject("TransactionHistory.Image")));
            this.TransactionHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TransactionHistory.Location = new System.Drawing.Point(0, 407);
            this.TransactionHistory.Name = "TransactionHistory";
            this.TransactionHistory.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.TransactionHistory.Size = new System.Drawing.Size(247, 40);
            this.TransactionHistory.TabIndex = 4;
            this.TransactionHistory.Text = "               Transaction Management";
            this.TransactionHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TransactionHistory.UseVisualStyleBackColor = true;
            this.TransactionHistory.Click += new System.EventHandler(this.TransactionHistory_Click);
            // 
            // MoldMasterlist
            // 
            this.MoldMasterlist.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MoldMasterlist.FlatAppearance.BorderSize = 0;
            this.MoldMasterlist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(117)))), ((int)(((byte)(101)))));
            this.MoldMasterlist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(117)))), ((int)(((byte)(101)))));
            this.MoldMasterlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoldMasterlist.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoldMasterlist.ForeColor = System.Drawing.Color.White;
            this.MoldMasterlist.Image = ((System.Drawing.Image)(resources.GetObject("MoldMasterlist.Image")));
            this.MoldMasterlist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MoldMasterlist.Location = new System.Drawing.Point(0, 347);
            this.MoldMasterlist.Name = "MoldMasterlist";
            this.MoldMasterlist.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.MoldMasterlist.Size = new System.Drawing.Size(247, 40);
            this.MoldMasterlist.TabIndex = 3;
            this.MoldMasterlist.Text = "               Mold Masterlist Management";
            this.MoldMasterlist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MoldMasterlist.UseVisualStyleBackColor = true;
            this.MoldMasterlist.Click += new System.EventHandler(this.MoldMasterlist_Click);
            // 
            // UserManagement
            // 
            this.UserManagement.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.UserManagement.FlatAppearance.BorderSize = 0;
            this.UserManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(117)))), ((int)(((byte)(101)))));
            this.UserManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(117)))), ((int)(((byte)(101)))));
            this.UserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserManagement.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserManagement.ForeColor = System.Drawing.Color.White;
            this.UserManagement.Image = ((System.Drawing.Image)(resources.GetObject("UserManagement.Image")));
            this.UserManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserManagement.Location = new System.Drawing.Point(0, 291);
            this.UserManagement.Name = "UserManagement";
            this.UserManagement.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.UserManagement.Size = new System.Drawing.Size(247, 40);
            this.UserManagement.TabIndex = 2;
            this.UserManagement.Text = "               User Management";
            this.UserManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserManagement.UseVisualStyleBackColor = true;
            this.UserManagement.Click += new System.EventHandler(this.UserManagement_Click);
            // 
            // Wlcome_lbl
            // 
            this.Wlcome_lbl.AutoSize = true;
            this.Wlcome_lbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wlcome_lbl.ForeColor = System.Drawing.Color.White;
            this.Wlcome_lbl.Location = new System.Drawing.Point(68, 173);
            this.Wlcome_lbl.Name = "Wlcome_lbl";
            this.Wlcome_lbl.Size = new System.Drawing.Size(108, 16);
            this.Wlcome_lbl.TabIndex = 1;
            this.Wlcome_lbl.Text = "Welcome, Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(253, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(884, 660);
            this.panel3.TabIndex = 2;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 694);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMTS";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminDashboard_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitApp)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button UserManagement;
        private System.Windows.Forms.Label Wlcome_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ExitApp;
        private System.Windows.Forms.Button TransactionHistory;
        private System.Windows.Forms.Button MoldMasterlist;
        private System.Windows.Forms.Button LocationManagement;
        private System.Windows.Forms.Button MoldStatusManagement;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Dashboard;
    }
}