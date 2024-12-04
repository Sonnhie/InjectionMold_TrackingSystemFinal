namespace InjectionMold_TrackingSystem.AdministratorForms
{
    partial class UserControlTransactionManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlTransactionManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Locations = new System.Windows.Forms.TextBox();
            this.Previous = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SaveEdit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ShotCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Remarks = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.ComboBox();
            this.DieNumber = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Customer = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MoldNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PartNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TransactionDataGridView = new Zuby.ADGV.AdvancedDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moldno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Partno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dieno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoldStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoldLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTransact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeTransact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EndDatePicker);
            this.panel1.Controls.Add(this.StartDatePicker);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.Locations);
            this.panel1.Controls.Add(this.Previous);
            this.panel1.Controls.Add(this.Next);
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.SaveEdit);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.ShotCount);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Remarks);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Status);
            this.panel1.Controls.Add(this.DieNumber);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Customer);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.MoldNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PartNumber);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TransactionDataGridView);
            this.panel1.Location = new System.Drawing.Point(19, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 623);
            this.panel1.TabIndex = 2;
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Location = new System.Drawing.Point(608, 20);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(211, 22);
            this.EndDatePicker.TabIndex = 83;
            this.EndDatePicker.ValueChanged += new System.EventHandler(this.EndDatePicker_ValueChanged_1);
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Location = new System.Drawing.Point(352, 20);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(220, 22);
            this.StartDatePicker.TabIndex = 82;
            this.StartDatePicker.ValueChanged += new System.EventHandler(this.StartDatePicker_ValueChanged_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(298, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 17);
            this.label12.TabIndex = 81;
            this.label12.Text = "From:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(578, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 17);
            this.label11.TabIndex = 80;
            this.label11.Text = "To:";
            // 
            // Locations
            // 
            this.Locations.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Locations.Location = new System.Drawing.Point(581, 406);
            this.Locations.Name = "Locations";
            this.Locations.Size = new System.Drawing.Size(191, 23);
            this.Locations.TabIndex = 77;
            // 
            // Previous
            // 
            this.Previous.BackColor = System.Drawing.Color.Transparent;
            this.Previous.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Previous.ForeColor = System.Drawing.Color.Black;
            this.Previous.Image = ((System.Drawing.Image)(resources.GetObject("Previous.Image")));
            this.Previous.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Previous.Location = new System.Drawing.Point(684, 292);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(69, 28);
            this.Previous.TabIndex = 76;
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
            this.Next.Location = new System.Drawing.Point(755, 292);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(69, 28);
            this.Next.TabIndex = 75;
            this.Next.Text = " Next";
            this.Next.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(127)))), ((int)(((byte)(57)))));
            this.ClearButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(659, 563);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(126, 42);
            this.ClearButton.TabIndex = 74;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            // 
            // SaveEdit
            // 
            this.SaveEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(127)))), ((int)(((byte)(57)))));
            this.SaveEdit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveEdit.ForeColor = System.Drawing.Color.White;
            this.SaveEdit.Location = new System.Drawing.Point(502, 563);
            this.SaveEdit.Name = "SaveEdit";
            this.SaveEdit.Size = new System.Drawing.Size(126, 42);
            this.SaveEdit.TabIndex = 73;
            this.SaveEdit.Text = "Save";
            this.SaveEdit.UseVisualStyleBackColor = false;
            this.SaveEdit.Click += new System.EventHandler(this.SaveEdit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(511, 414);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 71;
            this.label9.Text = "Location:";
            // 
            // ShotCount
            // 
            this.ShotCount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShotCount.Location = new System.Drawing.Point(581, 518);
            this.ShotCount.Name = "ShotCount";
            this.ShotCount.Size = new System.Drawing.Size(169, 23);
            this.ShotCount.TabIndex = 70;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(499, 524);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 69;
            this.label7.Text = "Shot count:";
            // 
            // Remarks
            // 
            this.Remarks.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remarks.Location = new System.Drawing.Point(581, 460);
            this.Remarks.Multiline = true;
            this.Remarks.Name = "Remarks";
            this.Remarks.Size = new System.Drawing.Size(169, 41);
            this.Remarks.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(515, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 67;
            this.label2.Text = "Remarks:";
            // 
            // Status
            // 
            this.Status.DisplayMember = "MoldStatus";
            this.Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Status.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.FormattingEnabled = true;
            this.Status.Items.AddRange(new object[] {
            "Mold Preparation ",
            "Mold Issuance",
            "Mold Endorsement",
            "Mold Maintenance",
            "Mold Set-up(Start Set-up)",
            "Mold Set-up(End Set-up)",
            "End-of-schedule(Downmold)",
            "End-of-schedule(Standby at machine)"});
            this.Status.Location = new System.Drawing.Point(581, 358);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(191, 25);
            this.Status.TabIndex = 66;
            // 
            // DieNumber
            // 
            this.DieNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DieNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DieNumber.FormattingEnabled = true;
            this.DieNumber.Items.AddRange(new object[] {
            "D1",
            "D2",
            "D3"});
            this.DieNumber.Location = new System.Drawing.Point(212, 452);
            this.DieNumber.Name = "DieNumber";
            this.DieNumber.Size = new System.Drawing.Size(73, 25);
            this.DieNumber.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(121, 460);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 64;
            this.label6.Text = "Die number:";
            // 
            // Customer
            // 
            this.Customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Customer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer.FormattingEnabled = true;
            this.Customer.Items.AddRange(new object[] {
            "EPPI",
            "ZAMA",
            "IMI",
            "JCM",
            "CBMP",
            "BIPH",
            "NCFL",
            "YAZAKI",
            "IVOCLAR",
            "EXCELITAS"});
            this.Customer.Location = new System.Drawing.Point(212, 499);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(91, 25);
            this.Customer.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(132, 507);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 62;
            this.label5.Text = "Customer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(527, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 61;
            this.label4.Text = "Status:";
            // 
            // MoldNumber
            // 
            this.MoldNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoldNumber.Location = new System.Drawing.Point(212, 360);
            this.MoldNumber.Name = "MoldNumber";
            this.MoldNumber.Size = new System.Drawing.Size(120, 23);
            this.MoldNumber.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 59;
            this.label1.Text = "Mold Number:";
            // 
            // PartNumber
            // 
            this.PartNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartNumber.Location = new System.Drawing.Point(212, 406);
            this.PartNumber.Name = "PartNumber";
            this.PartNumber.Size = new System.Drawing.Size(151, 23);
            this.PartNumber.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(126, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 57;
            this.label8.Text = "Partnumber:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(34, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 19);
            this.label10.TabIndex = 56;
            this.label10.Text = "Edit Transaction";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Transaction History";
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
            this.Moldno,
            this.Partno,
            this.Dieno,
            this.Customers,
            this.MoldStatus,
            this.MoldLocation,
            this.Count,
            this.Remark,
            this.DateTransact,
            this.TimeTransact,
            this.Update,
            this.Delete});
            this.TransactionDataGridView.EnableHeadersVisualStyles = false;
            this.TransactionDataGridView.FilterAndSortEnabled = true;
            this.TransactionDataGridView.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.TransactionDataGridView.Location = new System.Drawing.Point(22, 55);
            this.TransactionDataGridView.MaxFilterButtonImageHeight = 23;
            this.TransactionDataGridView.Name = "TransactionDataGridView";
            this.TransactionDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TransactionDataGridView.Size = new System.Drawing.Size(802, 231);
            this.TransactionDataGridView.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.TransactionDataGridView.TabIndex = 0;
            this.TransactionDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TransactionDataGridView_CellClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.HeaderText = "Transaction ID";
            this.id.MinimumWidth = 24;
            this.id.Name = "id";
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.id.Width = 116;
            // 
            // Moldno
            // 
            this.Moldno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Moldno.HeaderText = "Mold Number";
            this.Moldno.MinimumWidth = 24;
            this.Moldno.Name = "Moldno";
            this.Moldno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Moldno.Width = 113;
            // 
            // Partno
            // 
            this.Partno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Partno.HeaderText = "Part Number";
            this.Partno.MinimumWidth = 24;
            this.Partno.Name = "Partno";
            this.Partno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Partno.Width = 107;
            // 
            // Dieno
            // 
            this.Dieno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Dieno.HeaderText = "Die number";
            this.Dieno.MinimumWidth = 24;
            this.Dieno.Name = "Dieno";
            this.Dieno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Dieno.Width = 101;
            // 
            // Customers
            // 
            this.Customers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Customers.HeaderText = "Customer";
            this.Customers.MinimumWidth = 24;
            this.Customers.Name = "Customers";
            this.Customers.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Customers.Width = 90;
            // 
            // MoldStatus
            // 
            this.MoldStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MoldStatus.HeaderText = "Mold Status";
            this.MoldStatus.MinimumWidth = 24;
            this.MoldStatus.Name = "MoldStatus";
            this.MoldStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.MoldStatus.Width = 103;
            // 
            // MoldLocation
            // 
            this.MoldLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MoldLocation.HeaderText = "Mold Location";
            this.MoldLocation.MinimumWidth = 24;
            this.MoldLocation.Name = "MoldLocation";
            this.MoldLocation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.MoldLocation.Width = 119;
            // 
            // Count
            // 
            this.Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Count.HeaderText = "Shot Count";
            this.Count.MinimumWidth = 24;
            this.Count.Name = "Count";
            this.Count.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Count.Width = 99;
            // 
            // Remark
            // 
            this.Remark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Remark.HeaderText = "Remarks";
            this.Remark.MinimumWidth = 24;
            this.Remark.Name = "Remark";
            this.Remark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Remark.Width = 82;
            // 
            // DateTransact
            // 
            this.DateTransact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DateTransact.HeaderText = "Date";
            this.DateTransact.MinimumWidth = 24;
            this.DateTransact.Name = "DateTransact";
            this.DateTransact.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.DateTransact.Width = 63;
            // 
            // TimeTransact
            // 
            this.TimeTransact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TimeTransact.HeaderText = "Time";
            this.TimeTransact.MinimumWidth = 24;
            this.TimeTransact.Name = "TimeTransact";
            this.TimeTransact.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.TimeTransact.Width = 60;
            // 
            // Update
            // 
            this.Update.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            this.Update.DefaultCellStyle = dataGridViewCellStyle2;
            this.Update.HeaderText = "";
            this.Update.Image = ((System.Drawing.Image)(resources.GetObject("Update.Image")));
            this.Update.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Update.MinimumWidth = 24;
            this.Update.Name = "Update";
            this.Update.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            this.Delete.Width = 24;
            // 
            // UserControlTransactionManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlTransactionManagement";
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
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SaveEdit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ShotCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Remarks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Status;
        private System.Windows.Forms.ComboBox DieNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Customer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MoldNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PartNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Button Previous;
        public System.Windows.Forms.Button Next;
        private System.Windows.Forms.TextBox Locations;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moldno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Partno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dieno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customers;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoldStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoldLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTransact;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeTransact;
        private System.Windows.Forms.DataGridViewImageColumn Updates;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn Update;
    }
}
