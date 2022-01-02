namespace IMS
{
    partial class FrmSalesReturn
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
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.txtSrNo = new System.Windows.Forms.TextBox();
            this.colSrNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemove = new System.Windows.Forms.Button();
            this.BtnAddItem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.colTotalAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.colItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.colItemId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHSN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmKg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTaxableAmt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCgstPer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCgstAmt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSgstPer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSgstAmt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.olgKg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.oldQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHSN = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtKg = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
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
            this.txtIgstAmt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtIgstPer = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpBillDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBillNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnAddNew = new System.Windows.Forms.Button();
            this.txtShopName = new System.Windows.Forms.TextBox();
            this.txtTotalAmt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalCGSTAmt = new System.Windows.Forms.TextBox();
            this.txtTotalSGSTAmt = new System.Windows.Forms.TextBox();
            this.txtTotalKg = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.BtnLast = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnFirst = new System.Windows.Forms.Button();
            this.txtSalesBillNo = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblbillNo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalAmount.Enabled = false;
            this.txtTotalAmount.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(840, 48);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(96, 20);
            this.txtTotalAmount.TabIndex = 10;
            this.txtTotalAmount.TabStop = false;
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSrNo
            // 
            this.txtSrNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSrNo.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSrNo.Location = new System.Drawing.Point(6, 48);
            this.txtSrNo.Name = "txtSrNo";
            this.txtSrNo.ReadOnly = true;
            this.txtSrNo.Size = new System.Drawing.Size(35, 20);
            this.txtSrNo.TabIndex = 0;
            this.txtSrNo.TabStop = false;
            // 
            // colSrNo
            // 
            this.colSrNo.Text = "Sr.No.";
            this.colSrNo.Width = 38;
            // 
            // btnRemove
            // 
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(941, 46);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(38, 20);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "-";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // BtnAddItem
            // 
            this.BtnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddItem.Location = new System.Drawing.Point(941, 20);
            this.BtnAddItem.Name = "BtnAddItem";
            this.BtnAddItem.Size = new System.Drawing.Size(38, 25);
            this.BtnAddItem.TabIndex = 11;
            this.BtnAddItem.Text = "+";
            this.BtnAddItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAddItem.UseVisualStyleBackColor = true;
            this.BtnAddItem.Click += new System.EventHandler(this.BtnAddItem_Click);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(840, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 31);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total Amount";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRate
            // 
            this.txtRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRate.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(460, 48);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(60, 20);
            this.txtRate.TabIndex = 4;
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRate.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            this.txtRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtShopName_KeyDown);
            // 
            // txtQty
            // 
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(400, 48);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(60, 20);
            this.txtQty.TabIndex = 3;
            this.txtQty.Text = "0";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtShopName_KeyDown);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(460, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 31);
            this.label6.TabIndex = 4;
            this.label6.Text = "Rate";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(400, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Qty";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtItemName
            // 
            this.txtItemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtItemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtItemName.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(41, 48);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(229, 20);
            this.txtItemName.TabIndex = 0;
            this.txtItemName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtShopName_KeyDown);
            this.txtItemName.Validating += new System.ComponentModel.CancelEventHandler(this.txtItemName_Validating);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Description";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colTotalAmount
            // 
            this.colTotalAmount.Text = "Total Amount";
            this.colTotalAmount.Width = 92;
            // 
            // colRate
            // 
            this.colRate.Text = "Rate";
            this.colRate.Width = 62;
            // 
            // colQty
            // 
            this.colQty.Text = "Quentity";
            this.colQty.Width = 62;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 31);
            this.label8.TabIndex = 39;
            this.label8.Text = "Sr.No.";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colItemName
            // 
            this.colItemName.Text = "Description";
            this.colItemName.Width = 226;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSrNo,
            this.colItemId,
            this.colItemName,
            this.clmHSN,
            this.clmKg,
            this.colQty,
            this.colRate,
            this.clmTaxableAmt,
            this.clmCgstPer,
            this.clmCgstAmt,
            this.clmSgstPer,
            this.clmSgstAmt,
            this.colTotalAmount,
            this.olgKg,
            this.oldQty});
            this.listView1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(6, 68);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(973, 318);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // colItemId
            // 
            this.colItemId.Text = "ItemId";
            this.colItemId.Width = 0;
            // 
            // clmHSN
            // 
            this.clmHSN.Text = "HSN/SAG";
            this.clmHSN.Width = 67;
            // 
            // clmKg
            // 
            this.clmKg.Text = "KG";
            this.clmKg.Width = 59;
            // 
            // clmTaxableAmt
            // 
            this.clmTaxableAmt.Text = "Taxable Amt";
            this.clmTaxableAmt.Width = 87;
            // 
            // clmCgstPer
            // 
            this.clmCgstPer.Text = "CGST %";
            this.clmCgstPer.Width = 57;
            // 
            // clmCgstAmt
            // 
            this.clmCgstAmt.Text = "CGST Amt";
            this.clmCgstAmt.Width = 59;
            // 
            // clmSgstPer
            // 
            this.clmSgstPer.Text = "SGST %";
            this.clmSgstPer.Width = 52;
            // 
            // clmSgstAmt
            // 
            this.clmSgstAmt.Text = "SGST Amt";
            this.clmSgstAmt.Width = 64;
            // 
            // olgKg
            // 
            this.olgKg.Width = 0;
            // 
            // oldQty
            // 
            this.oldQty.Width = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.txtHSN);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.txtKg);
            this.groupBox1.Controls.Add(this.label21);
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
            this.groupBox1.Location = new System.Drawing.Point(4, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(989, 392);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sales Return Detail";
            // 
            // txtHSN
            // 
            this.txtHSN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHSN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtHSN.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHSN.Location = new System.Drawing.Point(270, 48);
            this.txtHSN.Name = "txtHSN";
            this.txtHSN.Size = new System.Drawing.Size(70, 20);
            this.txtHSN.TabIndex = 1;
            this.txtHSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label22
            // 
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label22.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(270, 17);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(70, 31);
            this.label22.TabIndex = 67;
            this.label22.Text = "HSN/SAG";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtKg
            // 
            this.txtKg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKg.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKg.Location = new System.Drawing.Point(340, 48);
            this.txtKg.Name = "txtKg";
            this.txtKg.Size = new System.Drawing.Size(60, 20);
            this.txtKg.TabIndex = 2;
            this.txtKg.Text = "0";
            this.txtKg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label21
            // 
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label21.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(340, 17);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 31);
            this.label21.TabIndex = 65;
            this.label21.Text = "Kg";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTaxable
            // 
            this.txtTaxable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaxable.Enabled = false;
            this.txtTaxable.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxable.Location = new System.Drawing.Point(520, 48);
            this.txtTaxable.Name = "txtTaxable";
            this.txtTaxable.ReadOnly = true;
            this.txtTaxable.Size = new System.Drawing.Size(89, 20);
            this.txtTaxable.TabIndex = 5;
            this.txtTaxable.TabStop = false;
            this.txtTaxable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label20
            // 
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label20.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(520, 17);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 31);
            this.label20.TabIndex = 61;
            this.label20.Text = "Taxable Amt";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCGSTAmt
            // 
            this.txtCGSTAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCGSTAmt.Enabled = false;
            this.txtCGSTAmt.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCGSTAmt.Location = new System.Drawing.Point(657, 48);
            this.txtCGSTAmt.Name = "txtCGSTAmt";
            this.txtCGSTAmt.ReadOnly = true;
            this.txtCGSTAmt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCGSTAmt.Size = new System.Drawing.Size(65, 20);
            this.txtCGSTAmt.TabIndex = 7;
            this.txtCGSTAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(657, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 31);
            this.label12.TabIndex = 59;
            this.label12.Text = "CGST Amt.";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCGSTPer
            // 
            this.txtCGSTPer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCGSTPer.Enabled = false;
            this.txtCGSTPer.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCGSTPer.Location = new System.Drawing.Point(609, 48);
            this.txtCGSTPer.Name = "txtCGSTPer";
            this.txtCGSTPer.ReadOnly = true;
            this.txtCGSTPer.Size = new System.Drawing.Size(48, 20);
            this.txtCGSTPer.TabIndex = 6;
            this.txtCGSTPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(609, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 31);
            this.label13.TabIndex = 57;
            this.label13.Text = "CGST %";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSGSTAmt
            // 
            this.txtSGSTAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSGSTAmt.Enabled = false;
            this.txtSGSTAmt.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSGSTAmt.Location = new System.Drawing.Point(775, 48);
            this.txtSGSTAmt.Name = "txtSGSTAmt";
            this.txtSGSTAmt.ReadOnly = true;
            this.txtSGSTAmt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSGSTAmt.Size = new System.Drawing.Size(67, 20);
            this.txtSGSTAmt.TabIndex = 9;
            this.txtSGSTAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(775, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 31);
            this.label11.TabIndex = 55;
            this.label11.Text = "SGST Amt.";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSGSTPer
            // 
            this.txtSGSTPer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSGSTPer.Enabled = false;
            this.txtSGSTPer.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSGSTPer.Location = new System.Drawing.Point(722, 48);
            this.txtSGSTPer.Name = "txtSGSTPer";
            this.txtSGSTPer.ReadOnly = true;
            this.txtSGSTPer.Size = new System.Drawing.Size(53, 20);
            this.txtSGSTPer.TabIndex = 8;
            this.txtSGSTPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(722, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 31);
            this.label10.TabIndex = 51;
            this.label10.Text = "SGST %";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIgstAmt
            // 
            this.txtIgstAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIgstAmt.Enabled = false;
            this.txtIgstAmt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIgstAmt.Location = new System.Drawing.Point(1203, 34);
            this.txtIgstAmt.Name = "txtIgstAmt";
            this.txtIgstAmt.ReadOnly = true;
            this.txtIgstAmt.Size = new System.Drawing.Size(81, 22);
            this.txtIgstAmt.TabIndex = 52;
            this.txtIgstAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIgstAmt.Visible = false;
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1203, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 21);
            this.label15.TabIndex = 54;
            this.label15.Text = "IGST Amt.";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.Visible = false;
            // 
            // txtIgstPer
            // 
            this.txtIgstPer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIgstPer.Enabled = false;
            this.txtIgstPer.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIgstPer.Location = new System.Drawing.Point(1122, 34);
            this.txtIgstPer.Name = "txtIgstPer";
            this.txtIgstPer.ReadOnly = true;
            this.txtIgstPer.Size = new System.Drawing.Size(81, 22);
            this.txtIgstPer.TabIndex = 48;
            this.txtIgstPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIgstPer.Visible = false;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1122, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 21);
            this.label14.TabIndex = 50;
            this.label14.Text = "IGST %";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.Visible = false;
            // 
            // dtpBillDate
            // 
            this.dtpBillDate.CustomFormat = "dd/MM/yyyy";
            this.dtpBillDate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBillDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBillDate.Location = new System.Drawing.Point(103, 93);
            this.dtpBillDate.Name = "dtpBillDate";
            this.dtpBillDate.Size = new System.Drawing.Size(118, 22);
            this.dtpBillDate.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Bill Date :";
            // 
            // txtBillNo
            // 
            this.txtBillNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillNo.Location = new System.Drawing.Point(102, 71);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Size = new System.Drawing.Size(139, 21);
            this.txtBillNo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Sales Bill No. :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Party Name";
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(918, 652);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(63, 43);
            this.BtnExit.TabIndex = 10;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(855, 652);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(63, 43);
            this.BtnCancel.TabIndex = 9;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(792, 652);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(63, 43);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Location = new System.Drawing.Point(138, 12);
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
            this.BtnDelete.Location = new System.Drawing.Point(201, 12);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(63, 23);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Visible = false;
            // 
            // BtnEdit
            // 
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.Location = new System.Drawing.Point(75, 12);
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
            this.BtnAddNew.Location = new System.Drawing.Point(12, 12);
            this.BtnAddNew.Name = "BtnAddNew";
            this.BtnAddNew.Size = new System.Drawing.Size(63, 23);
            this.BtnAddNew.TabIndex = 0;
            this.BtnAddNew.Text = "New";
            this.BtnAddNew.UseVisualStyleBackColor = true;
            this.BtnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // txtShopName
            // 
            this.txtShopName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtShopName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtShopName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShopName.Location = new System.Drawing.Point(103, 22);
            this.txtShopName.Name = "txtShopName";
            this.txtShopName.Size = new System.Drawing.Size(600, 22);
            this.txtShopName.TabIndex = 5;
            this.txtShopName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtShopName_KeyDown);
            this.txtShopName.Validating += new System.ComponentModel.CancelEventHandler(this.txtShopName_Validating);
            // 
            // txtTotalAmt
            // 
            this.txtTotalAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotalAmt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTotalAmt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTotalAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalAmt.Enabled = false;
            this.txtTotalAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmt.Location = new System.Drawing.Point(120, 586);
            this.txtTotalAmt.Name = "txtTotalAmt";
            this.txtTotalAmt.ReadOnly = true;
            this.txtTotalAmt.Size = new System.Drawing.Size(123, 21);
            this.txtTotalAmt.TabIndex = 52;
            this.txtTotalAmt.TabStop = false;
            this.txtTotalAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalAmt.Visible = false;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 590);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "Total Amount :";
            this.label9.Visible = false;
            // 
            // txtTotalCGSTAmt
            // 
            this.txtTotalCGSTAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotalCGSTAmt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTotalCGSTAmt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTotalCGSTAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCGSTAmt.Location = new System.Drawing.Point(597, 585);
            this.txtTotalCGSTAmt.Name = "txtTotalCGSTAmt";
            this.txtTotalCGSTAmt.ReadOnly = true;
            this.txtTotalCGSTAmt.Size = new System.Drawing.Size(123, 21);
            this.txtTotalCGSTAmt.TabIndex = 60;
            this.txtTotalCGSTAmt.TabStop = false;
            this.txtTotalCGSTAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalSGSTAmt
            // 
            this.txtTotalSGSTAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotalSGSTAmt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTotalSGSTAmt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTotalSGSTAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSGSTAmt.Location = new System.Drawing.Point(740, 586);
            this.txtTotalSGSTAmt.Name = "txtTotalSGSTAmt";
            this.txtTotalSGSTAmt.ReadOnly = true;
            this.txtTotalSGSTAmt.Size = new System.Drawing.Size(100, 21);
            this.txtTotalSGSTAmt.TabIndex = 58;
            this.txtTotalSGSTAmt.TabStop = false;
            this.txtTotalSGSTAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalKg
            // 
            this.txtTotalKg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotalKg.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTotalKg.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTotalKg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalKg.Location = new System.Drawing.Point(338, 582);
            this.txtTotalKg.Name = "txtTotalKg";
            this.txtTotalKg.ReadOnly = true;
            this.txtTotalKg.Size = new System.Drawing.Size(80, 21);
            this.txtTotalKg.TabIndex = 56;
            this.txtTotalKg.TabStop = false;
            this.txtTotalKg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTotal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(846, 586);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(123, 21);
            this.txtTotal.TabIndex = 54;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(274, 677);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(63, 43);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // BtnLast
            // 
            this.BtnLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLast.Location = new System.Drawing.Point(207, 684);
            this.BtnLast.Name = "BtnLast";
            this.BtnLast.Size = new System.Drawing.Size(63, 28);
            this.BtnLast.TabIndex = 15;
            this.BtnLast.Text = "Last";
            this.BtnLast.UseVisualStyleBackColor = true;
            this.BtnLast.Visible = false;
            this.BtnLast.Click += new System.EventHandler(this.BtnLast_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(144, 684);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(63, 28);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNext.Location = new System.Drawing.Point(81, 684);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(63, 28);
            this.BtnNext.TabIndex = 13;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Visible = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnFirst
            // 
            this.BtnFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFirst.Location = new System.Drawing.Point(18, 684);
            this.BtnFirst.Name = "BtnFirst";
            this.BtnFirst.Size = new System.Drawing.Size(63, 28);
            this.BtnFirst.TabIndex = 12;
            this.BtnFirst.Text = "First";
            this.BtnFirst.UseVisualStyleBackColor = true;
            this.BtnFirst.Visible = false;
            this.BtnFirst.Click += new System.EventHandler(this.BtnFirst_Click);
            // 
            // txtSalesBillNo
            // 
            this.txtSalesBillNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalesBillNo.Location = new System.Drawing.Point(103, 47);
            this.txtSalesBillNo.Name = "txtSalesBillNo";
            this.txtSalesBillNo.Size = new System.Drawing.Size(139, 21);
            this.txtSalesBillNo.TabIndex = 4;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(41, 72);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 13);
            this.label23.TabIndex = 62;
            this.label23.Text = "Bill No. :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(419, 17);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(110, 17);
            this.label24.TabIndex = 63;
            this.label24.Text = "Last Bill No. :";
            // 
            // lblbillNo
            // 
            this.lblbillNo.AutoSize = true;
            this.lblbillNo.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbillNo.Location = new System.Drawing.Point(550, 17);
            this.lblbillNo.Name = "lblbillNo";
            this.lblbillNo.Size = new System.Drawing.Size(31, 17);
            this.lblbillNo.TabIndex = 64;
            this.lblbillNo.Text = "Bill";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtShopName);
            this.groupBox2.Controls.Add(this.txtBillNo);
            this.groupBox2.Controls.Add(this.txtSalesBillNo);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtpBillDate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(986, 126);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Party Detail";
            // 
            // FrmSalesReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 725);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblbillNo);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.BtnLast);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnFirst);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtTotalCGSTAmt);
            this.Controls.Add(this.txtTotalSGSTAmt);
            this.Controls.Add(this.txtIgstAmt);
            this.Controls.Add(this.txtTotalKg);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtIgstPer);
            this.Controls.Add(this.txtTotalAmt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAddNew);
            this.Name = "FrmSalesReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Return";
            this.Load += new System.EventHandler(this.FrmSalesMaster_Load);
            this.Shown += new System.EventHandler(this.FrmSalesMaster_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.TextBox txtSrNo;
        private System.Windows.Forms.ColumnHeader colSrNo;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button BtnAddItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader colTotalAmount;
        private System.Windows.Forms.ColumnHeader colRate;
        private System.Windows.Forms.ColumnHeader colQty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader colItemName;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colItemId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpBillDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBillNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnAddNew;
        private System.Windows.Forms.TextBox txtShopName;
        private System.Windows.Forms.TextBox txtTotalAmt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCGSTAmt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCGSTPer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtIgstAmt;
        private System.Windows.Forms.TextBox txtSGSTAmt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIgstPer;
        private System.Windows.Forms.TextBox txtSGSTPer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColumnHeader clmCgstPer;
        private System.Windows.Forms.ColumnHeader clmCgstAmt;
        private System.Windows.Forms.ColumnHeader clmSgstPer;
        private System.Windows.Forms.ColumnHeader clmSgstAmt;
        private System.Windows.Forms.TextBox txtTotalCGSTAmt;
        private System.Windows.Forms.TextBox txtTotalSGSTAmt;
        private System.Windows.Forms.TextBox txtTotalKg;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ColumnHeader clmTaxableAmt;
        private System.Windows.Forms.TextBox txtTaxable;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button BtnLast;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnFirst;
        private System.Windows.Forms.ColumnHeader clmHSN;
        private System.Windows.Forms.ColumnHeader clmKg;
        private System.Windows.Forms.TextBox txtHSN;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtKg;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader olgKg;
        private System.Windows.Forms.ColumnHeader oldQty;
        private System.Windows.Forms.TextBox txtSalesBillNo;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblbillNo;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}