namespace InjectionMold_TrackingSystem.UserForms
{
    partial class UserControlShotcount
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
            this.dataGridViewShotCount = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelDbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.BtnUpload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShotCount)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewShotCount
            // 
            this.dataGridViewShotCount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShotCount.Location = new System.Drawing.Point(17, 84);
            this.dataGridViewShotCount.Name = "dataGridViewShotCount";
            this.dataGridViewShotCount.Size = new System.Drawing.Size(842, 528);
            this.dataGridViewShotCount.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelDbStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 654);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(884, 22);
            this.statusStrip1.TabIndex = 100;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelDbStatus
            // 
            this.toolStripStatusLabelDbStatus.Name = "toolStripStatusLabelDbStatus";
            this.toolStripStatusLabelDbStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 101;
            this.label1.Text = "Part Number:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 33);
            this.textBox1.TabIndex = 102;
            // 
            // BtnFilter
            // 
            this.BtnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(127)))), ((int)(((byte)(57)))));
            this.BtnFilter.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFilter.ForeColor = System.Drawing.Color.White;
            this.BtnFilter.Location = new System.Drawing.Point(328, 21);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(100, 33);
            this.BtnFilter.TabIndex = 103;
            this.BtnFilter.Text = "Search";
            this.BtnFilter.UseVisualStyleBackColor = false;
            // 
            // BtnUpload
            // 
            this.BtnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(127)))), ((int)(((byte)(57)))));
            this.BtnUpload.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpload.ForeColor = System.Drawing.Color.White;
            this.BtnUpload.Location = new System.Drawing.Point(759, 24);
            this.BtnUpload.Name = "BtnUpload";
            this.BtnUpload.Size = new System.Drawing.Size(100, 33);
            this.BtnUpload.TabIndex = 104;
            this.BtnUpload.Text = "Upload Data";
            this.BtnUpload.UseVisualStyleBackColor = false;
            // 
            // UserControlShotcount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnUpload);
            this.Controls.Add(this.BtnFilter);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridViewShotCount);
            this.Name = "UserControlShotcount";
            this.Size = new System.Drawing.Size(884, 676);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShotCount)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewShotCount;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnFilter;
        private System.Windows.Forms.Button BtnUpload;
    }
}
