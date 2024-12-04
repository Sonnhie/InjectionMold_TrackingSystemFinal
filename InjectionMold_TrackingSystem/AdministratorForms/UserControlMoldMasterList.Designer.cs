
namespace InjectionMold_TrackingSystem.AdministratorForms
{
    partial class UserControlMoldMasterList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlMoldMasterList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Previous = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.AddNewMold = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.UpdateMold = new System.Windows.Forms.Button();
            this.Customer_Combobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DieNumber_ComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PartName_Txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PartNumber_Txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MoldNumber_Txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblform = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TransactionDataGridView = new Zuby.ADGV.AdvancedDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoldNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DieNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Previous);
            this.panel1.Controls.Add(this.Next);
            this.panel1.Controls.Add(this.AddNewMold);
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.UpdateMold);
            this.panel1.Controls.Add(this.Customer_Combobox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.DieNumber_ComboBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.PartName_Txt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.PartNumber_Txt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.MoldNumber_Txt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblform);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TransactionDataGridView);
            this.panel1.Location = new System.Drawing.Point(17, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 622);
            this.panel1.TabIndex = 1;
            // 
            // Previous
            // 
            this.Previous.BackColor = System.Drawing.Color.Transparent;
            this.Previous.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Previous.ForeColor = System.Drawing.Color.Black;
            this.Previous.Image = ((System.Drawing.Image)(resources.GetObject("Previous.Image")));
            this.Previous.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Previous.Location = new System.Drawing.Point(685, 321);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(69, 28);
            this.Previous.TabIndex = 63;
            this.Previous.Text = "      Prev";
            this.Previous.UseVisualStyleBackColor = false;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.Transparent;
            this.Next.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.ForeColor = System.Drawing.Color.Black;
            this.Next.Image = ((System.Drawing.Image)(resources.GetObject("Next.Image")));
            this.Next.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Next.Location = new System.Drawing.Point(756, 321);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(69, 28);
            this.Next.TabIndex = 62;
            this.Next.Text = " Next";
            this.Next.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // AddNewMold
            // 
            this.AddNewMold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(127)))), ((int)(((byte)(57)))));
            this.AddNewMold.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewMold.ForeColor = System.Drawing.Color.White;
            this.AddNewMold.Location = new System.Drawing.Point(367, 555);
            this.AddNewMold.Name = "AddNewMold";
            this.AddNewMold.Size = new System.Drawing.Size(126, 42);
            this.AddNewMold.TabIndex = 61;
            this.AddNewMold.Text = "Add New Mold";
            this.AddNewMold.UseVisualStyleBackColor = false;
            this.AddNewMold.Click += new System.EventHandler(this.AddNewMold_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(127)))), ((int)(((byte)(57)))));
            this.ClearButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(646, 555);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(126, 42);
            this.ClearButton.TabIndex = 60;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // UpdateMold
            // 
            this.UpdateMold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(127)))), ((int)(((byte)(57)))));
            this.UpdateMold.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateMold.ForeColor = System.Drawing.Color.White;
            this.UpdateMold.Location = new System.Drawing.Point(505, 555);
            this.UpdateMold.Name = "UpdateMold";
            this.UpdateMold.Size = new System.Drawing.Size(126, 42);
            this.UpdateMold.TabIndex = 59;
            this.UpdateMold.Text = "Update Mold";
            this.UpdateMold.UseVisualStyleBackColor = false;
            this.UpdateMold.Click += new System.EventHandler(this.UpdateMold_Click);
            // 
            // Customer_Combobox
            // 
            this.Customer_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Customer_Combobox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Combobox.FormattingEnabled = true;
            this.Customer_Combobox.Items.AddRange(new object[] {
            "YAZAKI",
            "EPPI",
            "BIPH",
            "CBMP",
            "JCM",
            "IVOCLAR",
            "NCFL",
            "IMI",
            "EXCELITAS",
            "IONICS",
            "ZAMA"});
            this.Customer_Combobox.Location = new System.Drawing.Point(630, 441);
            this.Customer_Combobox.Name = "Customer_Combobox";
            this.Customer_Combobox.Size = new System.Drawing.Size(139, 25);
            this.Customer_Combobox.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(560, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 57;
            this.label4.Text = "Customer:";
            // 
            // DieNumber_ComboBox
            // 
            this.DieNumber_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DieNumber_ComboBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DieNumber_ComboBox.FormattingEnabled = true;
            this.DieNumber_ComboBox.Items.AddRange(new object[] {
            "D1",
            "D2",
            "D3",
            "D4"});
            this.DieNumber_ComboBox.Location = new System.Drawing.Point(630, 393);
            this.DieNumber_ComboBox.Name = "DieNumber_ComboBox";
            this.DieNumber_ComboBox.Size = new System.Drawing.Size(139, 25);
            this.DieNumber_ComboBox.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(549, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 55;
            this.label5.Text = "Die number:";
            // 
            // PartName_Txt
            // 
            this.PartName_Txt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartName_Txt.Location = new System.Drawing.Point(249, 492);
            this.PartName_Txt.Name = "PartName_Txt";
            this.PartName_Txt.Size = new System.Drawing.Size(241, 23);
            this.PartName_Txt.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 497);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 53;
            this.label2.Text = "Part Name:";
            // 
            // PartNumber_Txt
            // 
            this.PartNumber_Txt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartNumber_Txt.Location = new System.Drawing.Point(249, 443);
            this.PartNumber_Txt.Name = "PartNumber_Txt";
            this.PartNumber_Txt.Size = new System.Drawing.Size(241, 23);
            this.PartNumber_Txt.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 51;
            this.label1.Text = "Part Number:";
            // 
            // MoldNumber_Txt
            // 
            this.MoldNumber_Txt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoldNumber_Txt.Location = new System.Drawing.Point(249, 394);
            this.MoldNumber_Txt.Name = "MoldNumber_Txt";
            this.MoldNumber_Txt.Size = new System.Drawing.Size(120, 23);
            this.MoldNumber_Txt.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(158, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 49;
            this.label6.Text = "Mold Number:";
            // 
            // lblform
            // 
            this.lblform.AutoSize = true;
            this.lblform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.lblform.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblform.ForeColor = System.Drawing.Color.Black;
            this.lblform.Location = new System.Drawing.Point(33, 342);
            this.lblform.Name = "lblform";
            this.lblform.Size = new System.Drawing.Size(127, 19);
            this.lblform.TabIndex = 48;
            this.lblform.Text = "Add Mold Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mold Master List";
            // 
            // TransactionDataGridView
            // 
            this.TransactionDataGridView.AllowUserToAddRows = false;
            this.TransactionDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(127)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TransactionDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TransactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.MoldNumber,
            this.Material,
            this.Material_name,
            this.DieNumber,
            this.Customer,
            this.Column5,
            this.Update,
            this.Delete});
            this.TransactionDataGridView.EnableHeadersVisualStyles = false;
            this.TransactionDataGridView.FilterAndSortEnabled = true;
            this.TransactionDataGridView.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.TransactionDataGridView.Location = new System.Drawing.Point(22, 50);
            this.TransactionDataGridView.MaxFilterButtonImageHeight = 23;
            this.TransactionDataGridView.Name = "TransactionDataGridView";
            this.TransactionDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TransactionDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TransactionDataGridView.Size = new System.Drawing.Size(802, 265);
            this.TransactionDataGridView.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.TransactionDataGridView.TabIndex = 0;
            this.TransactionDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TransactionDataGridView_CellClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 24;
            this.id.Name = "id";
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.id.Width = 44;
            // 
            // MoldNumber
            // 
            this.MoldNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MoldNumber.HeaderText = "Mold Number";
            this.MoldNumber.MinimumWidth = 24;
            this.MoldNumber.Name = "MoldNumber";
            this.MoldNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.MoldNumber.Width = 113;
            // 
            // Material
            // 
            this.Material.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Material.HeaderText = "Part Number";
            this.Material.MinimumWidth = 24;
            this.Material.Name = "Material";
            this.Material.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Material.Width = 107;
            // 
            // Material_name
            // 
            this.Material_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Material_name.HeaderText = "Part Name";
            this.Material_name.MinimumWidth = 24;
            this.Material_name.Name = "Material_name";
            this.Material_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Material_name.Width = 96;
            // 
            // DieNumber
            // 
            this.DieNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DieNumber.HeaderText = "Die number";
            this.DieNumber.MinimumWidth = 24;
            this.DieNumber.Name = "DieNumber";
            this.DieNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.DieNumber.Width = 101;
            // 
            // Customer
            // 
            this.Customer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Customer.HeaderText = "Customer";
            this.Customer.MinimumWidth = 24;
            this.Customer.Name = "Customer";
            this.Customer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Customer.Width = 90;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Date Created";
            this.Column5.MinimumWidth = 24;
            this.Column5.Name = "Column5";
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column5.Width = 116;
            // 
            // Update
            // 
            this.Update.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            this.Update.DefaultCellStyle = dataGridViewCellStyle2;
            this.Update.HeaderText = "";
            this.Update.Image = ((System.Drawing.Image)(resources.GetObject("Update.Image")));
            this.Update.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Update.MinimumWidth = 24;
            this.Update.Name = "Update";
            this.Update.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Update.ToolTipText = "Edit Data";
            this.Update.Width = 24;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.MinimumWidth = 24;
            this.Delete.Name = "Delete";
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Delete.ToolTipText = "Delete Data";
            this.Delete.Width = 24;
            // 
            // UserControlMoldMasterList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlMoldMasterList";
            this.Size = new System.Drawing.Size(884, 660);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private Zuby.ADGV.AdvancedDataGridView TransactionDataGridView;
        public System.Windows.Forms.Button AddNewMold;
        public System.Windows.Forms.Button ClearButton;
        public System.Windows.Forms.Button UpdateMold;
        public System.Windows.Forms.ComboBox Customer_Combobox;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox DieNumber_ComboBox;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox PartName_Txt;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox PartNumber_Txt;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox MoldNumber_Txt;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lblform;
        public System.Windows.Forms.Button Previous;
        public System.Windows.Forms.Button Next;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoldNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn DieNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Updates;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn Update;
    }
}
