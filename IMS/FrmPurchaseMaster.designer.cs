namespace IMS
{
    partial class FrmPurchaseMaster
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
            this.txtShopName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnAddNew = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBillNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpBillDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHSN = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtKg = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtTaxable = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCGSTAmt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCGSTPer = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSGSTAmt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSGSTPer = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.txtSrNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.BtnAddItem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colSrNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colItemId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHsn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colKg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTaxable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCGSTPer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCGSTAmt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSGSTPer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSGSTAmt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotalAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.oldKg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.oldQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTotalSGSTAmt = new System.Windows.Forms.TextBox();
            this.txtTotalCGSTAmt = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtTotalKg = new System.Windows.Forms.TextBox();
            this.IsOpening = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTotalAmt = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtIgstAmt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTotalIgstAmt = new System.Windows.Forms.TextBox();
            this.txtIgstPer = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtShopName
            // 
            this.txtShopName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtShopName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtShopName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShopName.Location = new System.Drawing.Point(103, 23);
            this.txtShopName.Name = "txtShopName";
            this.txtShopName.Size = new System.Drawing.Size(515, 22);
            this.txtShopName.TabIndex = 0;
            this.txtShopName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtShopName_KeyDown);
            this.txtShopName.Validating += new System.ComponentModel.CancelEventHandler(this.txtShopName_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Party Name";
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(904, 613);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(61, 32);
            this.BtnExit.TabIndex = 7;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(841, 613);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(61, 32);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(778, 613);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(61, 32);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Location = new System.Drawing.Point(131, 5);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(63, 23);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(194, 5);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(63, 23);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Visible = false;
            // 
            // BtnEdit
            // 
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.Location = new System.Drawing.Point(68, 5);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(63, 23);
            this.BtnEdit.TabIndex = 1;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnAddNew
            // 
            this.BtnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddNew.Location = new System.Drawing.Point(5, 5);
            this.BtnAddNew.Name = "BtnAddNew";
            this.BtnAddNew.Size = new System.Drawing.Size(63, 23);
            this.BtnAddNew.TabIndex = 0;
            this.BtnAddNew.Text = "New";
            this.BtnAddNew.UseVisualStyleBackColor = true;
            this.BtnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Bill No. :";
            // 
            // txtBillNo
            // 
            this.txtBillNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillNo.Location = new System.Drawing.Point(103, 46);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Size = new System.Drawing.Size(130, 21);
            this.txtBillNo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Bill Date :";
            // 
            // dtpBillDate
            // 
            this.dtpBillDate.CustomFormat = "dd/MM/yyyy";
            this.dtpBillDate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBillDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBillDate.Location = new System.Drawing.Point(104, 71);
            this.dtpBillDate.Name = "dtpBillDate";
            this.dtpBillDate.Size = new System.Drawing.Size(130, 22);
            this.dtpBillDate.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.txtHSN);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.txtKg);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.txtTaxable);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtCGSTAmt);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtCGSTPer);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtSGSTAmt);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtSGSTPer);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtTotalAmount);
            this.groupBox1.Controls.Add(this.txtSrNo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.BtnAddItem);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtRate);
            this.groupBox1.Controls.Add(this.txtQty);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.txtItemName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(954, 407);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase Details";
            // 
            // txtHSN
            // 
            this.txtHSN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHSN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtHSN.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHSN.Location = new System.Drawing.Point(272, 50);
            this.txtHSN.Name = "txtHSN";
            this.txtHSN.Size = new System.Drawing.Size(69, 20);
            this.txtHSN.TabIndex = 2;
            this.txtHSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label24
            // 
            this.label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label24.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(272, 19);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(69, 31);
            this.label24.TabIndex = 71;
            this.label24.Text = "HSN/SAG";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtKg
            // 
            this.txtKg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKg.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKg.Location = new System.Drawing.Point(341, 50);
            this.txtKg.Name = "txtKg";
            this.txtKg.Size = new System.Drawing.Size(54, 20);
            this.txtKg.TabIndex = 3;
            this.txtKg.Text = "0";
            this.txtKg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label25
            // 
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label25.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(341, 19);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(54, 31);
            this.label25.TabIndex = 69;
            this.label25.Text = "Kg";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTaxable
            // 
            this.txtTaxable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaxable.Enabled = false;
            this.txtTaxable.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxable.Location = new System.Drawing.Point(521, 50);
            this.txtTaxable.Name = "txtTaxable";
            this.txtTaxable.ReadOnly = true;
            this.txtTaxable.Size = new System.Drawing.Size(79, 20);
            this.txtTaxable.TabIndex = 6;
            this.txtTaxable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label20
            // 
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label20.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(521, 19);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 31);
            this.label20.TabIndex = 49;
            this.label20.Text = "Taxable Amt";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCGSTAmt
            // 
            this.txtCGSTAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCGSTAmt.Enabled = false;
            this.txtCGSTAmt.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCGSTAmt.Location = new System.Drawing.Point(643, 50);
            this.txtCGSTAmt.Name = "txtCGSTAmt";
            this.txtCGSTAmt.ReadOnly = true;
            this.txtCGSTAmt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCGSTAmt.Size = new System.Drawing.Size(64, 20);
            this.txtCGSTAmt.TabIndex = 8;
            this.txtCGSTAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(643, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 31);
            this.label12.TabIndex = 47;
            this.label12.Text = "CGST Amt.";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCGSTPer
            // 
            this.txtCGSTPer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCGSTPer.Enabled = false;
            this.txtCGSTPer.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCGSTPer.Location = new System.Drawing.Point(600, 50);
            this.txtCGSTPer.Name = "txtCGSTPer";
            this.txtCGSTPer.ReadOnly = true;
            this.txtCGSTPer.Size = new System.Drawing.Size(43, 20);
            this.txtCGSTPer.TabIndex = 7;
            this.txtCGSTPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(600, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 31);
            this.label13.TabIndex = 45;
            this.label13.Text = "CGST %";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSGSTAmt
            // 
            this.txtSGSTAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSGSTAmt.Enabled = false;
            this.txtSGSTAmt.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSGSTAmt.Location = new System.Drawing.Point(760, 50);
            this.txtSGSTAmt.Name = "txtSGSTAmt";
            this.txtSGSTAmt.ReadOnly = true;
            this.txtSGSTAmt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSGSTAmt.Size = new System.Drawing.Size(64, 20);
            this.txtSGSTAmt.TabIndex = 10;
            this.txtSGSTAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(760, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 31);
            this.label11.TabIndex = 43;
            this.label11.Text = "SGST Amt.";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSGSTPer
            // 
            this.txtSGSTPer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSGSTPer.Enabled = false;
            this.txtSGSTPer.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSGSTPer.Location = new System.Drawing.Point(707, 50);
            this.txtSGSTPer.Name = "txtSGSTPer";
            this.txtSGSTPer.ReadOnly = true;
            this.txtSGSTPer.Size = new System.Drawing.Size(53, 20);
            this.txtSGSTPer.TabIndex = 9;
            this.txtSGSTPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(707, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 31);
            this.label10.TabIndex = 41;
            this.label10.Text = "SGST %";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalAmount.Enabled = false;
            this.txtTotalAmount.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(824, 50);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(86, 20);
            this.txtTotalAmount.TabIndex = 11;
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSrNo
            // 
            this.txtSrNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSrNo.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSrNo.Location = new System.Drawing.Point(6, 50);
            this.txtSrNo.Name = "txtSrNo";
            this.txtSrNo.ReadOnly = true;
            this.txtSrNo.Size = new System.Drawing.Size(44, 20);
            this.txtSrNo.TabIndex = 0;
            this.txtSrNo.TabStop = false;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 31);
            this.label8.TabIndex = 39;
            this.label8.Text = "Sr.No.";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRemove
            // 
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(916, 49);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(33, 20);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // BtnAddItem
            // 
            this.BtnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddItem.Location = new System.Drawing.Point(916, 29);
            this.BtnAddItem.Name = "BtnAddItem";
            this.BtnAddItem.Size = new System.Drawing.Size(33, 20);
            this.BtnAddItem.TabIndex = 12;
            this.BtnAddItem.Text = "+";
            this.BtnAddItem.UseVisualStyleBackColor = true;
            this.BtnAddItem.Click += new System.EventHandler(this.BtnAddItem_Click);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(824, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 31);
            this.label7.TabIndex = 6;
            this.label7.Text = "Amount";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRate
            // 
            this.txtRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRate.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(449, 50);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(72, 20);
            this.txtRate.TabIndex = 5;
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRate.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtShopName_KeyDown);
            // 
            // txtQty
            // 
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(395, 50);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(54, 20);
            this.txtQty.TabIndex = 4;
            this.txtQty.Text = "0";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQty.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtShopName_KeyDown);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(449, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 31);
            this.label6.TabIndex = 4;
            this.label6.Text = "Rate";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(395, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Qty";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSrNo,
            this.colItemId,
            this.colItemName,
            this.colHsn,
            this.colKg,
            this.colQty,
            this.colRate,
            this.clmTaxable,
            this.colCGSTPer,
            this.colCGSTAmt,
            this.colSGSTPer,
            this.colSGSTAmt,
            this.colTotalAmount,
            this.oldKg,
            this.oldQty});
            this.listView1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(6, 70);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(942, 331);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // colSrNo
            // 
            this.colSrNo.Text = "Sr.No.";
            this.colSrNo.Width = 41;
            // 
            // colItemId
            // 
            this.colItemId.Text = "ItemId";
            this.colItemId.Width = 0;
            // 
            // colItemName
            // 
            this.colItemName.Text = "Description";
            this.colItemName.Width = 224;
            // 
            // colHsn
            // 
            this.colHsn.Text = "Hsn";
            this.colHsn.Width = 67;
            // 
            // colKg
            // 
            this.colKg.Text = "Kg";
            this.colKg.Width = 54;
            // 
            // colQty
            // 
            this.colQty.Text = "Quentity";
            this.colQty.Width = 55;
            // 
            // colRate
            // 
            this.colRate.Text = "Rate";
            this.colRate.Width = 71;
            // 
            // clmTaxable
            // 
            this.clmTaxable.Text = "Taxable Amt";
            this.clmTaxable.Width = 78;
            // 
            // colCGSTPer
            // 
            this.colCGSTPer.Text = "CGST % ";
            this.colCGSTPer.Width = 45;
            // 
            // colCGSTAmt
            // 
            this.colCGSTAmt.Text = "CGST Amt.";
            this.colCGSTAmt.Width = 63;
            // 
            // colSGSTPer
            // 
            this.colSGSTPer.Text = "SGST %";
            this.colSGSTPer.Width = 52;
            // 
            // colSGSTAmt
            // 
            this.colSGSTAmt.Text = "SGST Amt";
            this.colSGSTAmt.Width = 67;
            // 
            // colTotalAmount
            // 
            this.colTotalAmount.Text = "Total Amount";
            this.colTotalAmount.Width = 82;
            // 
            // oldKg
            // 
            this.oldKg.Text = "";
            this.oldKg.Width = 0;
            // 
            // oldQty
            // 
            this.oldQty.Text = "";
            this.oldQty.Width = 2;
            // 
            // txtItemName
            // 
            this.txtItemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtItemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(50, 50);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(222, 20);
            this.txtItemName.TabIndex = 1;
            this.txtItemName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtShopName_KeyDown);
            this.txtItemName.Validating += new System.ComponentModel.CancelEventHandler(this.txtItemName_Validating);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Description";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTotal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(841, 553);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(120, 21);
            this.txtTotal.TabIndex = 38;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalSGSTAmt
            // 
            this.txtTotalSGSTAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotalSGSTAmt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTotalSGSTAmt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTotalSGSTAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSGSTAmt.Location = new System.Drawing.Point(768, 553);
            this.txtTotalSGSTAmt.Name = "txtTotalSGSTAmt";
            this.txtTotalSGSTAmt.ReadOnly = true;
            this.txtTotalSGSTAmt.Size = new System.Drawing.Size(71, 21);
            this.txtTotalSGSTAmt.TabIndex = 42;
            this.txtTotalSGSTAmt.TabStop = false;
            this.txtTotalSGSTAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalCGSTAmt
            // 
            this.txtTotalCGSTAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotalCGSTAmt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTotalCGSTAmt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTotalCGSTAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCGSTAmt.Location = new System.Drawing.Point(627, 553);
            this.txtTotalCGSTAmt.Name = "txtTotalCGSTAmt";
            this.txtTotalCGSTAmt.ReadOnly = true;
            this.txtTotalCGSTAmt.Size = new System.Drawing.Size(88, 21);
            this.txtTotalCGSTAmt.TabIndex = 44;
            this.txtTotalCGSTAmt.TabStop = false;
            this.txtTotalCGSTAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalCGSTAmt.TextChanged += new System.EventHandler(this.txtTotalCGSTAmt_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(237, 46);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(18, 17);
            this.label21.TabIndex = 47;
            this.label21.Text = "*";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(237, 72);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(18, 17);
            this.label22.TabIndex = 48;
            this.label22.Text = "*";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Red;
            this.label23.Location = new System.Drawing.Point(622, 26);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(18, 17);
            this.label23.TabIndex = 49;
            this.label23.Text = "*";
            // 
            // txtTotalKg
            // 
            this.txtTotalKg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotalKg.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTotalKg.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTotalKg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalKg.Location = new System.Drawing.Point(343, 553);
            this.txtTotalKg.Name = "txtTotalKg";
            this.txtTotalKg.ReadOnly = true;
            this.txtTotalKg.Size = new System.Drawing.Size(60, 21);
            this.txtTotalKg.TabIndex = 51;
            this.txtTotalKg.TabStop = false;
            this.txtTotalKg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // IsOpening
            // 
            this.IsOpening.AutoSize = true;
            this.IsOpening.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsOpening.Location = new System.Drawing.Point(646, 26);
            this.IsOpening.Name = "IsOpening";
            this.IsOpening.Size = new System.Drawing.Size(119, 19);
            this.IsOpening.TabIndex = 52;
            this.IsOpening.Text = "Opening Stock";
            this.IsOpening.UseVisualStyleBackColor = true;
            this.IsOpening.CheckedChanged += new System.EventHandler(this.IsOpening_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.IsOpening);
            this.groupBox2.Controls.Add(this.txtShopName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.dtpBillDate);
            this.groupBox2.Controls.Add(this.txtBillNo);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(948, 102);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Party Detail";
            // 
            // txtTotalAmt
            // 
            this.txtTotalAmt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTotalAmt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTotalAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmt.Location = new System.Drawing.Point(173, 605);
            this.txtTotalAmt.Name = "txtTotalAmt";
            this.txtTotalAmt.ReadOnly = true;
            this.txtTotalAmt.Size = new System.Drawing.Size(129, 21);
            this.txtTotalAmt.TabIndex = 61;
            this.txtTotalAmt.TabStop = false;
            this.txtTotalAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalAmt.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(75, 609);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(94, 13);
            this.label19.TabIndex = 60;
            this.label19.Text = "Total Amount";
            this.label19.Visible = false;
            // 
            // txtIgstAmt
            // 
            this.txtIgstAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIgstAmt.Enabled = false;
            this.txtIgstAmt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIgstAmt.Location = new System.Drawing.Point(131, 574);
            this.txtIgstAmt.Name = "txtIgstAmt";
            this.txtIgstAmt.ReadOnly = true;
            this.txtIgstAmt.Size = new System.Drawing.Size(81, 22);
            this.txtIgstAmt.TabIndex = 58;
            this.txtIgstAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIgstAmt.Visible = false;
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(131, 554);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 21);
            this.label15.TabIndex = 59;
            this.label15.Text = "IGST Amt.";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.Visible = false;
            // 
            // txtTotalIgstAmt
            // 
            this.txtTotalIgstAmt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTotalIgstAmt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTotalIgstAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalIgstAmt.Location = new System.Drawing.Point(217, 574);
            this.txtTotalIgstAmt.Name = "txtTotalIgstAmt";
            this.txtTotalIgstAmt.ReadOnly = true;
            this.txtTotalIgstAmt.Size = new System.Drawing.Size(81, 21);
            this.txtTotalIgstAmt.TabIndex = 55;
            this.txtTotalIgstAmt.TabStop = false;
            this.txtTotalIgstAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalIgstAmt.Visible = false;
            // 
            // txtIgstPer
            // 
            this.txtIgstPer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIgstPer.Enabled = false;
            this.txtIgstPer.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIgstPer.Location = new System.Drawing.Point(50, 574);
            this.txtIgstPer.Name = "txtIgstPer";
            this.txtIgstPer.ReadOnly = true;
            this.txtIgstPer.Size = new System.Drawing.Size(81, 22);
            this.txtIgstPer.TabIndex = 56;
            this.txtIgstPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIgstPer.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(218, 558);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 13);
            this.label16.TabIndex = 54;
            this.label16.Text = "Total IGST ";
            this.label16.Visible = false;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(50, 554);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 21);
            this.label14.TabIndex = 57;
            this.label14.Text = "IGST %";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.Visible = false;
            // 
            // FrmPurchaseMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 657);
            this.Controls.Add(this.txtTotalAmt);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtIgstAmt);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtTotalIgstAmt);
            this.Controls.Add(this.txtIgstPer);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtTotalKg);
            this.Controls.Add(this.txtTotalCGSTAmt);
            this.Controls.Add(this.txtTotalSGSTAmt);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAddNew);
            this.Name = "FrmPurchaseMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Master";
            this.Load += new System.EventHandler(this.FrmPurchaseMaster_Load);
            this.Shown += new System.EventHandler(this.FrmPurchaseMaster_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtShopName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnAddNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBillNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpBillDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSrNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button BtnAddItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colSrNo;
        private System.Windows.Forms.ColumnHeader colItemId;
        private System.Windows.Forms.ColumnHeader colItemName;
        private System.Windows.Forms.ColumnHeader colQty;
        private System.Windows.Forms.ColumnHeader colRate;
        private System.Windows.Forms.ColumnHeader colTotalAmount;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtCGSTAmt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCGSTPer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSGSTAmt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSGSTPer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColumnHeader colCGSTPer;
        private System.Windows.Forms.ColumnHeader colCGSTAmt;
        private System.Windows.Forms.ColumnHeader colSGSTPer;
        private System.Windows.Forms.ColumnHeader colSGSTAmt;
        private System.Windows.Forms.TextBox txtTotalSGSTAmt;
        private System.Windows.Forms.TextBox txtTotalCGSTAmt;
        private System.Windows.Forms.TextBox txtTaxable;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ColumnHeader clmTaxable;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtHSN;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtKg;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ColumnHeader colHsn;
        private System.Windows.Forms.ColumnHeader colKg;
        private System.Windows.Forms.ColumnHeader oldKg;
        private System.Windows.Forms.ColumnHeader oldQty;
        private System.Windows.Forms.TextBox txtTotalKg;
        private System.Windows.Forms.CheckBox IsOpening;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTotalAmt;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtIgstAmt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTotalIgstAmt;
        private System.Windows.Forms.TextBox txtIgstPer;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
    }
}