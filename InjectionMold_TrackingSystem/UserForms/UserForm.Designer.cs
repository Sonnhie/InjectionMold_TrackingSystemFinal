namespace InjectionMold_TrackingSystem.UserForms
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitApp = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Dashboard = new System.Windows.Forms.Button();
            this.InjectionMonitoring = new System.Windows.Forms.Button();
            this.MoldMonitoring = new System.Windows.Forms.Button();
            this.Transaction = new System.Windows.Forms.Button();
            this.StatusViewer = new System.Windows.Forms.Button();
            this.QrGenerator = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Logout = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitApp)).BeginInit();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.panel1.TabIndex = 1;
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
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.Logout);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 660);
            this.panel2.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Dashboard);
            this.flowLayoutPanel1.Controls.Add(this.InjectionMonitoring);
            this.flowLayoutPanel1.Controls.Add(this.MoldMonitoring);
            this.flowLayoutPanel1.Controls.Add(this.Transaction);
            this.flowLayoutPanel1.Controls.Add(this.StatusViewer);
            this.flowLayoutPanel1.Controls.Add(this.QrGenerator);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 235);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(253, 363);
            this.flowLayoutPanel1.TabIndex = 8;
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
            this.Dashboard.Location = new System.Drawing.Point(3, 3);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Dashboard.Size = new System.Drawing.Size(247, 40);
            this.Dashboard.TabIndex = 8;
            this.Dashboard.Text = "               Dashboard";
            this.Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard.UseVisualStyleBackColor = true;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // InjectionMonitoring
            // 
            this.InjectionMonitoring.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.InjectionMonitoring.FlatAppearance.BorderSize = 0;
            this.InjectionMonitoring.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(117)))), ((int)(((byte)(101)))));
            this.InjectionMonitoring.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(117)))), ((int)(((byte)(101)))));
            this.InjectionMonitoring.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InjectionMonitoring.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InjectionMonitoring.ForeColor = System.Drawing.Color.White;
            this.InjectionMonitoring.Image = ((System.Drawing.Image)(resources.GetObject("InjectionMonitoring.Image")));
            this.InjectionMonitoring.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InjectionMonitoring.Location = new System.Drawing.Point(3, 49);
            this.InjectionMonitoring.Name = "InjectionMonitoring";
            this.InjectionMonitoring.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.InjectionMonitoring.Size = new System.Drawing.Size(247, 40);
            this.InjectionMonitoring.TabIndex = 2;
            this.InjectionMonitoring.Text = "               Injection Monitoring";
            this.InjectionMonitoring.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InjectionMonitoring.UseVisualStyleBackColor = true;
            this.InjectionMonitoring.Click += new System.EventHandler(this.InjectionMonitoring_Click);
            // 
            // MoldMonitoring
            // 
            this.MoldMonitoring.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MoldMonitoring.FlatAppearance.BorderSize = 0;
            this.MoldMonitoring.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(117)))), ((int)(((byte)(101)))));
            this.MoldMonitoring.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(117)))), ((int)(((byte)(101)))));
            this.MoldMonitoring.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoldMonitoring.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoldMonitoring.ForeColor = System.Drawing.Color.White;
            this.MoldMonitoring.Image = ((System.Drawing.Image)(resources.GetObject("MoldMonitoring.Image")));
            this.MoldMonitoring.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MoldMonitoring.Location = new System.Drawing.Point(3, 95);
            this.MoldMonitoring.Name = "MoldMonitoring";
            this.MoldMonitoring.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.MoldMonitoring.Size = new System.Drawing.Size(247, 40);
            this.MoldMonitoring.TabIndex = 9;
            this.MoldMonitoring.Text = "               Mold Monitoring";
            this.MoldMonitoring.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MoldMonitoring.UseVisualStyleBackColor = true;
            this.MoldMonitoring.Click += new System.EventHandler(this.MoldMonitoring_Click);
            // 
            // Transaction
            // 
            this.Transaction.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Transaction.FlatAppearance.BorderSize = 0;
            this.Transaction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(117)))), ((int)(((byte)(101)))));
            this.Transaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(117)))), ((int)(((byte)(101)))));
            this.Transaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Transaction.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transaction.ForeColor = System.Drawing.Color.White;
            this.Transaction.Image = ((System.Drawing.Image)(resources.GetObject("Transaction.Image")));
            this.Transaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Transaction.Location = new System.Drawing.Point(3, 141);
            this.Transaction.Name = "Transaction";
            this.Transaction.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Transaction.Size = new System.Drawing.Size(247, 40);
            this.Transaction.TabIndex = 3;
            this.Transaction.Text = "               Transaction History";
            this.Transaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Transaction.UseVisualStyleBackColor = true;
            this.Transaction.Click += new System.EventHandler(this.Transaction_Click);
            // 
            // StatusViewer
            // 
            this.StatusViewer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.StatusViewer.FlatAppearance.BorderSize = 0;
            this.StatusViewer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(117)))), ((int)(((byte)(101)))));
            this.StatusViewer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(117)))), ((int)(((byte)(101)))));
            this.StatusViewer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatusViewer.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusViewer.ForeColor = System.Drawing.Color.White;
            this.StatusViewer.Image = ((System.Drawing.Image)(resources.GetObject("StatusViewer.Image")));
            this.StatusViewer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StatusViewer.Location = new System.Drawing.Point(3, 187);
            this.StatusViewer.Name = "StatusViewer";
            this.StatusViewer.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.StatusViewer.Size = new System.Drawing.Size(247, 40);
            this.StatusViewer.TabIndex = 4;
            this.StatusViewer.Text = "               Status Viewer";
            this.StatusViewer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StatusViewer.UseVisualStyleBackColor = true;
            this.StatusViewer.Click += new System.EventHandler(this.StatusViewer_Click);
            // 
            // QrGenerator
            // 
            this.QrGenerator.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.QrGenerator.FlatAppearance.BorderSize = 0;
            this.QrGenerator.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(117)))), ((int)(((byte)(101)))));
            this.QrGenerator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(117)))), ((int)(((byte)(101)))));
            this.QrGenerator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QrGenerator.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QrGenerator.ForeColor = System.Drawing.Color.White;
            this.QrGenerator.Image = ((System.Drawing.Image)(resources.GetObject("QrGenerator.Image")));
            this.QrGenerator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.QrGenerator.Location = new System.Drawing.Point(3, 233);
            this.QrGenerator.Name = "QrGenerator";
            this.QrGenerator.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.QrGenerator.Size = new System.Drawing.Size(247, 40);
            this.QrGenerator.TabIndex = 5;
            this.QrGenerator.Text = "              QR Generator Tool";
            this.QrGenerator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.QrGenerator.UseVisualStyleBackColor = true;
            this.QrGenerator.Click += new System.EventHandler(this.QrGenerator_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(77, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome, User";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.Logout.Location = new System.Drawing.Point(0, 613);
            this.Logout.Name = "Logout";
            this.Logout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Logout.Size = new System.Drawing.Size(253, 47);
            this.Logout.TabIndex = 7;
            this.Logout.Text = "             Logout";
            this.Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(253, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(884, 660);
            this.panel3.TabIndex = 3;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 694);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserForm_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitApp)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ExitApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Dashboard;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button QrGenerator;
        private System.Windows.Forms.Button StatusViewer;
        private System.Windows.Forms.Button Transaction;
        private System.Windows.Forms.Button InjectionMonitoring;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button MoldMonitoring;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}