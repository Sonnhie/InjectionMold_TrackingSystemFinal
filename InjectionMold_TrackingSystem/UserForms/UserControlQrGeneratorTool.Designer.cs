namespace InjectionMold_TrackingSystem.UserForms
{
    partial class UserControlQrGeneratorTool
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
            this.QRPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // QRPanel
            // 
            this.QRPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QRPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QRPanel.Location = new System.Drawing.Point(0, 0);
            this.QRPanel.Name = "QRPanel";
            this.QRPanel.Size = new System.Drawing.Size(884, 718);
            this.QRPanel.TabIndex = 1;
            // 
            // UserControlQrGeneratorTool
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.QRPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControlQrGeneratorTool";
            this.Size = new System.Drawing.Size(884, 718);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel QRPanel;
    }
}
