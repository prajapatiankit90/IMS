namespace IMS
{
    partial class FrmDuplicate
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
            this.GrpDocumentDetail = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.lblinvoiceNo = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.BtnShow = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.lblPartyName = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.GrpDocumentDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpDocumentDetail
            // 
            this.GrpDocumentDetail.Controls.Add(this.txtSearch);
            this.GrpDocumentDetail.Controls.Add(this.lblInvoiceDate);
            this.GrpDocumentDetail.Controls.Add(this.lblinvoiceNo);
            this.GrpDocumentDetail.Controls.Add(this.Label7);
            this.GrpDocumentDetail.Controls.Add(this.BtnShow);
            this.GrpDocumentDetail.Controls.Add(this.Label2);
            this.GrpDocumentDetail.Controls.Add(this.Label1);
            this.GrpDocumentDetail.Controls.Add(this.Label3);
            this.GrpDocumentDetail.Controls.Add(this.lblAmount);
            this.GrpDocumentDetail.Controls.Add(this.Label5);
            this.GrpDocumentDetail.Controls.Add(this.lblPartyName);
            this.GrpDocumentDetail.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpDocumentDetail.Location = new System.Drawing.Point(4, 5);
            this.GrpDocumentDetail.Name = "GrpDocumentDetail";
            this.GrpDocumentDetail.Size = new System.Drawing.Size(726, 126);
            this.GrpDocumentDetail.TabIndex = 1;
            this.GrpDocumentDetail.TabStop = false;
            this.GrpDocumentDetail.Text = "Invoice Detail";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearch.Location = new System.Drawing.Point(107, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(224, 22);
            this.txtSearch.TabIndex = 0;
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceDate.Location = new System.Drawing.Point(126, 60);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(35, 14);
            this.lblInvoiceDate.TabIndex = 45;
            this.lblInvoiceDate.Text = "0.00";
            // 
            // lblinvoiceNo
            // 
            this.lblinvoiceNo.AutoSize = true;
            this.lblinvoiceNo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinvoiceNo.Location = new System.Drawing.Point(598, 21);
            this.lblinvoiceNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblinvoiceNo.Name = "lblinvoiceNo";
            this.lblinvoiceNo.Size = new System.Drawing.Size(74, 14);
            this.lblinvoiceNo.TabIndex = 34;
            this.lblinvoiceNo.Text = "Receipt No";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(433, 20);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(152, 14);
            this.Label7.TabIndex = 33;
            this.Label7.Text = "Bill No / Receipt No.:-";
            // 
            // BtnShow
            // 
            this.BtnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnShow.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnShow.Location = new System.Drawing.Point(338, 15);
            this.BtnShow.Margin = new System.Windows.Forms.Padding(4);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(57, 22);
            this.BtnShow.TabIndex = 1;
            this.BtnShow.Text = "Show";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(7, 19);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(93, 14);
            this.Label2.TabIndex = 14;
            this.Label2.Text = "Invoice No.:-";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(8, 40);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(100, 14);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "Party Name.:-";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(8, 60);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(102, 14);
            this.Label3.TabIndex = 18;
            this.Label3.Text = "Invoice Date:-";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(126, 82);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(35, 14);
            this.lblAmount.TabIndex = 25;
            this.lblAmount.Text = "0.00";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(9, 82);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(105, 14);
            this.Label5.TabIndex = 20;
            this.Label5.Text = "Total Amount:-";
            // 
            // lblPartyName
            // 
            this.lblPartyName.AutoSize = true;
            this.lblPartyName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartyName.Location = new System.Drawing.Point(127, 40);
            this.lblPartyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPartyName.Name = "lblPartyName";
            this.lblPartyName.Size = new System.Drawing.Size(43, 14);
            this.lblPartyName.TabIndex = 24;
            this.lblPartyName.Text = "Name";
            // 
            // BtnCancel
            // 
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(676, 137);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(56, 23);
            this.BtnCancel.TabIndex = 4;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(605, 137);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(71, 23);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // FrmDuplicate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 171);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.GrpDocumentDetail);
            this.Name = "FrmDuplicate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Duplicate";
            this.Load += new System.EventHandler(this.FrmDuplicate_Load);
            this.GrpDocumentDetail.ResumeLayout(false);
            this.GrpDocumentDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GrpDocumentDetail;
        internal System.Windows.Forms.TextBox txtSearch;
        internal System.Windows.Forms.Label lblInvoiceDate;
        internal System.Windows.Forms.Label lblinvoiceNo;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Button BtnShow;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label lblAmount;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label lblPartyName;
        internal System.Windows.Forms.Button BtnCancel;
        internal System.Windows.Forms.Button BtnSave;
    }
}