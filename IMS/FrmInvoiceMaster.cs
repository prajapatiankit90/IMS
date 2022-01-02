using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class FrmInvoiceMaster : Form
    {
        ProjSet RasClass = new ProjSet();
        bool IsEditItem = false;
        bool IsEdit = false;
        int ItemIdx = 0;
        string query = string.Empty;
        int SalesId = 0;
        int ShopId = 0;
        int ItemId = 0;
        Int32 Itemid;
        bool InState = true;
        DataTable dt = new DataTable();
        public FrmInvoiceMaster()
        {
            InitializeComponent();
        }

        private void FrmSalesMaster_Load(object sender, EventArgs e)
        {
            BtnAddNew_Click(null, null);
            txtShopName.Focus();
            //lblBillNo.Text = RasClass.GetValue("select max(SalesId) from salesmaster where Companyid = " + MyModule.CompanyId + " and TrType = 'SB'").ToString();
            //txtBillNo.Text  = RasClass.GetValue("select max(SalesId)+1 from salesmaster where Companyid = " + MyModule.CompanyId + " and TrType = 'SB'").ToString();
        }
        private void Clear()
        {
            txtShopName.Text = string.Empty;
            txtBillNo.Text = string.Empty;
            dtpBillDate.Value = DateTime.Now;
            listView1.Items.Clear();
            txtShopName.Focus();
            txtTotalCGSTAmt.Text = string.Empty;
            txtTotalKg.Text = string.Empty;
            txtTotalSGSTAmt.Text = string.Empty;
            txtTotal.Text = string.Empty;
            lblBillNo.Text = "0";
        }

        private void ClearItem()
        {
            txtItemName.Text = string.Empty;
            txtHSN.Text = string.Empty;
            txtKg.Text = "0";
            txtQty.Text = "0";
            txtRate.Text = string.Empty;
            txtTaxable.Text = string.Empty;
            txtTotalAmount.Text = string.Empty;
            txtCGSTPer.Text = string.Empty;
            txtCGSTAmt.Text = string.Empty;
            txtSGSTPer.Text = string.Empty;
            txtSGSTAmt.Text = string.Empty;
            txtIgstPer.Text = string.Empty;
            txtIgstAmt.Text = string.Empty;
            txtTotalCGSTAmt.Text = string.Empty;
            txtTotalKg.Text = string.Empty;
            txtTotalSGSTAmt.Text = string.Empty;
            txtTotal.Text = string.Empty;
            txtTotalAmt.Text = string.Empty;
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            Clear();
            ClearItem();
            txtSrNo.Text = "1";
            txtShopName.Focus();
            dataGridView1.DataSource = null;

        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            decimal Kg = string.IsNullOrEmpty(txtKg.Text) ? 0 : Convert.ToDecimal(txtKg.Text);
            decimal Qty = string.IsNullOrEmpty(txtQty.Text) ? 0 : Convert.ToDecimal(txtQty.Text);
            decimal Rate = string.IsNullOrEmpty(txtRate.Text) ? 0 : Convert.ToDecimal(txtRate.Text);
             decimal TotalAmt = ( (Kg == 0 ? Qty : Kg)  * Rate);
            //decimal TotalAmt = (Qty * Kg * Rate);
            txtTaxable.Text = TotalAmt.ToString("#0.00");

            decimal CGST = string.IsNullOrEmpty(txtCGSTPer.Text) ? 0 : Convert.ToDecimal(txtCGSTPer.Text);
            decimal SGST = string.IsNullOrEmpty(txtSGSTPer.Text) ? 0 : Convert.ToDecimal(txtSGSTPer.Text);
            
            if (InState)
            {
                txtCGSTAmt.Text = ((TotalAmt * CGST) / 100).ToString("#0.00");
                txtSGSTAmt.Text = ((TotalAmt * SGST) / 100).ToString("#0.00");
                txtIgstAmt.Text = "0.00";
            }
            else
            {
                txtCGSTAmt.Text = "0.00";
                txtSGSTAmt.Text = "0.00";
                txtIgstAmt.Text = ((TotalAmt * SGST) / 100).ToString("#0.00");
            }
            txtTotalAmount.Text = (TotalAmt + Convert.ToDecimal(txtCGSTAmt.Text) + Convert.ToDecimal(txtCGSTAmt.Text)).ToString();
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtItemName.Text))
            {
                MessageBox.Show("Please Enter Item Name",Text,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                txtItemName.Focus();
                return;
            }
            if ((string.IsNullOrEmpty(txtQty.Text) && string.IsNullOrEmpty(txtKg.Text)))
            {
                MessageBox.Show("Please Enter Item Quentity Or Kg.",Text,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                txtQty.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtRate.Text))
            {
                MessageBox.Show("Please Enter Item Rate.",Text,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                txtRate.Focus();
                return;
            }

            //string Stock = string.Empty;
            //string StockKg = string.Empty;            
            //decimal StockKg = Convert.ToDecimal(RasClass.GetValue("Select StockKg from ItemMaster where Id =" + ItemId));
            //decimal Stock = Convert.ToDecimal(RasClass.GetValue("select Stockqty from ItemMaster Where Id = " + ItemId));
            
            //if ( Convert.ToDecimal(Stock) < 0 || Convert.ToDecimal(txtQty.Text) > Convert.ToDecimal(Stock))
            //{
            //    MessageBox.Show("Qty Stock Not Available..!", Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    txtQty.Focus();
            //    return;
            //}
            //else if (Convert.ToDecimal(StockKg) < 0 || Convert.ToDecimal(txtKg.Text) > Convert.ToDecimal(StockKg))
            //{
            //    MessageBox.Show("Kg Stock Not Available..!", Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    txtKg.Focus();
            //    return;
            //}

            //else
            //{

                if (IsEditItem == false)
                {
                    ListViewItem Liv = new ListViewItem();
                    Liv.Text = (listView1.Items.Count + 1).ToString();
                    Liv.SubItems.Add(Convert.ToString(ItemId));
                    Liv.SubItems.Add(txtItemName.Text.ToString());
                    Liv.SubItems.Add(txtHSN.Text.ToString());
                    Liv.SubItems.Add(txtKg.Text);
                    Liv.SubItems.Add(txtQty.Text);
                    Liv.SubItems.Add(Convert.ToDecimal(txtRate.Text).ToString());
                    Liv.SubItems.Add(Convert.ToDecimal(txtTaxable.Text).ToString());
                    Liv.SubItems.Add(Convert.ToDecimal(txtCGSTPer.Text).ToString());
                    Liv.SubItems.Add(Convert.ToDecimal(txtCGSTAmt.Text).ToString());
                    Liv.SubItems.Add(Convert.ToDecimal(txtSGSTPer.Text).ToString());
                    Liv.SubItems.Add(Convert.ToDecimal(txtSGSTAmt.Text).ToString());
                    Liv.SubItems.Add(Convert.ToDecimal(txtTotalAmount.Text).ToString());
                    Liv.SubItems.Add(Convert.ToDecimal(0).ToString());
                    Liv.SubItems.Add(Convert.ToDecimal(0).ToString());
                    listView1.Items.Add(Liv);
                }
                else
                {
                    listView1.Items[ItemIdx].Text = txtSrNo.Text;
                    listView1.Items[ItemIdx].SubItems[1].Text = Convert.ToString(txtItemName.Tag);
                    listView1.Items[ItemIdx].SubItems[2].Text = txtItemName.Text;
                    listView1.Items[ItemIdx].SubItems[3].Text = txtHSN.Text;
                    listView1.Items[ItemIdx].SubItems[4].Text = txtKg.Text;
                    listView1.Items[ItemIdx].SubItems[5].Text = txtQty.Text;
                    listView1.Items[ItemIdx].SubItems[6].Text = txtRate.Text;
                    listView1.Items[ItemIdx].SubItems[7].Text = txtTaxable.Text;
                    listView1.Items[ItemIdx].SubItems[8].Text = txtCGSTPer.Text;
                    listView1.Items[ItemIdx].SubItems[9].Text = txtCGSTAmt.Text;
                    listView1.Items[ItemIdx].SubItems[10].Text = txtSGSTPer.Text;
                    listView1.Items[ItemIdx].SubItems[11].Text = txtSGSTAmt.Text;
                    listView1.Items[ItemIdx].SubItems[12].Text = txtTotalAmount.Text;
                }
                ClearItem();
                txtSrNo.Text = (listView1.Items.Count + 1).ToString();
                txtItemName.Focus();

                IsEditItem = false;
                ItemIdx = 0;
                TotalCalculation();
            
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count <= 0)
            {
                return;
            }
            DialogResult Dr = MessageBox.Show("Are You Sure Want to you?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Dr == DialogResult.Yes)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
                foreach (ListViewItem liv in listView1.Items)
                {
                    liv.Text = (liv.Index + 1).ToString();
                }
                txtSrNo.Text = (listView1.Items.Count + 1).ToString();
                TotalCalculation();
            }

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            BtnAddNew_Click(null, null);
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                txtSrNo.Text = listView1.SelectedItems[0].Text;
                txtItemName.Tag = listView1.SelectedItems[0].SubItems[1].Text;
                txtItemName.Text = listView1.SelectedItems[0].SubItems[2].Text;
                txtHSN.Text = listView1.SelectedItems[0].SubItems[3].Text;
                txtKg.Text = listView1.SelectedItems[0].SubItems[4].Text;
                txtQty.Text = listView1.SelectedItems[0].SubItems[5].Text;
                txtRate.Text = listView1.SelectedItems[0].SubItems[6].Text;
                txtTaxable.Text = listView1.SelectedItems[0].SubItems[7].Text;
                txtCGSTPer.Text = listView1.SelectedItems[0].SubItems[8].Text;
                txtCGSTAmt.Text = listView1.SelectedItems[0].SubItems[9].Text;
                txtSGSTPer.Text = listView1.SelectedItems[0].SubItems[10].Text;
                txtSGSTAmt.Text = listView1.SelectedItems[0].SubItems[11].Text;
                txtTotalAmount.Text = listView1.SelectedItems[0].SubItems[12].Text;
                txtItemName.Focus();
                IsEditItem = true;
                ItemIdx = listView1.SelectedItems[0].Index;
            }
        }

        private void FrmSalesMaster_Shown(object sender, EventArgs e)
        {
            RasClass.FillText("Select ShopName from ShopMaster where inactive=0 and CompanyId = " + MyModule.CompanyId, txtShopName);
            RasClass.FillText("Select ItemName from ItemMaster where inactive=0 and CompanyId = " + MyModule.CompanyId, txtItemName);
        }

        public void TotalCalculation()
        {
            txtTotalAmt.Text = string.Empty;
            txtTotalCGSTAmt.Text = string.Empty;
            txtTotalSGSTAmt.Text = string.Empty;
            txtTotalKg.Text = string.Empty;
            foreach (ListViewItem li in listView1.Items)
            {
                decimal Total = string.IsNullOrEmpty(txtTotalAmt.Text) ? 0 : Convert.ToDecimal(txtTotalAmt.Text);
                decimal CGST = string.IsNullOrEmpty(txtTotalCGSTAmt.Text) ? 0 : Convert.ToDecimal(txtTotalCGSTAmt.Text);
                decimal SGST = string.IsNullOrEmpty(txtTotalSGSTAmt.Text) ? 0 : Convert.ToDecimal(txtTotalSGSTAmt.Text);
                decimal TotalKg = string.IsNullOrEmpty(txtTotalKg.Text) ? 0 : Convert.ToDecimal(txtTotalKg.Text);

                decimal MyCGST = string.IsNullOrEmpty(li.SubItems[9].Text) ? 0 : Convert.ToDecimal(li.SubItems[9].Text);
                decimal MySGST = string.IsNullOrEmpty(li.SubItems[11].Text) ? 0 : Convert.ToDecimal(li.SubItems[11].Text);
                decimal MyTotal = string.IsNullOrEmpty(li.SubItems[12].Text) ? 0 : Convert.ToDecimal(li.SubItems[12].Text);
                decimal MyTotalKg = string.IsNullOrEmpty(li.SubItems[4].Text) ? 0 : Convert.ToDecimal(li.SubItems[4].Text);

                txtTotalAmt.Text = (Total + MyTotal).ToString("#0.00");
                txtTotalCGSTAmt.Text = (CGST + MyCGST).ToString("#0.00");
                txtTotalSGSTAmt.Text = (SGST + MySGST).ToString("#0.00");
                txtTotalKg.Text = (TotalKg + MyTotalKg).ToString("#0.00");
                
                txtTotal.Text = (txtTotalAmt.Text); //(Convert.ToDecimal(txtTotalAmt.Text) + Convert.ToDecimal(txtTotalCGSTAmt.Text) + Convert.ToDecimal(txtTotalSGSTAmt.Text) + Convert.ToDecimal(txtTotalIgstAmt.Text)).ToString();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //if (txtBillNo.Text == string.Empty)
            //{
            //    MessageBox.Show("Please Enter Bill No..!!", Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //    txtBillNo.Focus();
            //    return;
            //}

            //else
            //{
                if (IsEdit == false)
                {

                    //object nextBill = RasClass.GetValue("SELECT Max(SalesId)+ FROM salesmaster WHERE billno ='" + txtBillNo.Text + "' AND CompanyId =" + MyModule.CompanyId);
                    // lblBillNo.Text = RasClass.GetValue("select Billno from salesmaster WHere SalesId = (select max(SalesId) from salesmaster where Companyid = "+MyModule.CompanyId + " and TrType = 'SB'").ToString();
                    //if (!string.IsNullOrEmpty(Convert.ToString(billno)))
                    //{
                    //    MessageBox.Show("This Billno Already Created. Please Enter New Bill No", "Sales Master", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    txtBillNo.Focus();
                    //    return;
                    //}

                    // insert New record In Purhase Master
                    query = String.Format("Insert into TempInvoiceMaster (InvoiceNo,InvoiceDate,TotalAmount, TotalKg ,ShopId, CompanyId, TrType) Values ('{0}','{1}',{2},{3},{4},{5},'{6}')",
                             txtBillNo.Text,
                            dtpBillDate.Value.ToString("yyyy/MM/dd"),
                            txtTotalAmt.Text.Trim(),
                            txtTotalKg.Text.Trim(),
                            ShopId,
                            MyModule.CompanyId,
                            "TB");
                    RasClass.addrecord(query);
                    SalesId = Convert.ToInt32(RasClass.GetValue("Select MAX(InvoiceId) From TempInvoiceMaster where CompanyId = " + MyModule.CompanyId));
                }
                else
                {
                    // Update record In Purhase Master
                    query = String.Format("Update TempInvoiceMaster Set InvoiceDate = '{0}', TotalAmount = {1}, TotalKg = {2}  ,ShopId = {3} WHere InvoiceId = {4} and CompanyId = {5}",
                        dtpBillDate.Value.ToString("yyyy/MM/dd"),
                        txtTotalAmt.Text.Trim(),
                        txtTotalKg.Text.Trim(),
                        ShopId,
                        SalesId,
                        MyModule.CompanyId);
                    RasClass.addrecord(query);
                    // When Update Purchase Entry then Delete Record  from Purchase Details and Stock Master Corresponding Purchase Id
                    RasClass.addrecord("Delete From TempInvoiceDetail WHere InvoiceId = " + SalesId.ToString());
                }


                foreach (ListViewItem Liv in listView1.Items)
                {
                decimal tempStockKg = Convert.ToDecimal(RasClass.GetValue("Select StockKg  from itemmaster where Id=" + Liv.SubItems[1].Text));
                decimal tempStockQty = Convert.ToDecimal(RasClass.GetValue("Select StockQty  from itemmaster where Id=" + Liv.SubItems[1].Text));
                query = string.Format("Insert Into TempInvoiceDetail (InvoiceId, ItemId, Hsn, Kg, Qty, Rate, Amount, CgstPer, CgstAmt, SgstPer, SgstAmt) Values ({0}, {1} ,'{2}',{3},{4},{5},{6},{7},{8},{9},{10})",
                        SalesId,
                        Liv.SubItems[1].Text,
                        Liv.SubItems[3].Text,
                        string.IsNullOrEmpty(Liv.SubItems[4].Text) ? 0 : Convert.ToDecimal(Liv.SubItems[4].Text),
                        string.IsNullOrEmpty(Liv.SubItems[5].Text) ? 0 : Convert.ToDecimal(Liv.SubItems[5].Text),
                        string.IsNullOrEmpty(Liv.SubItems[6].Text) ? 0 : Convert.ToDecimal(Liv.SubItems[6].Text),
                        Liv.SubItems[7].Text,
                        Liv.SubItems[8].Text,
                        Liv.SubItems[9].Text,
                        Liv.SubItems[10].Text,
                        Liv.SubItems[11].Text
                        );
                    RasClass.addrecord(query);
                    //query = string.Format("Insert Into StockMaster (Shopid, Itemid, Kg, Qty, EntryDate,Salesid,CompanyId,TrType) Values ({0},{1},{2},{3},'{4}',{5},{6},'{7}')",
                    //    ShopId,
                    //    Liv.SubItems[1].Text,
                    //    string.IsNullOrEmpty(Liv.SubItems[4].Text) ? 0 : ( Convert.ToDecimal(Liv.SubItems[4].Text)) * -1,
                    //    string.IsNullOrEmpty(Liv.SubItems[5].Text) ? 0 : (Convert.ToDecimal(Liv.SubItems[5].Text)) * -1,
                    //    DateTime.Now.ToString("yyyy/MM/dd"),
                    //    SalesId,
                    //    MyModule.CompanyId,
                    //    "SB");
                    //RasClass.addrecord(query);
                    query = String.Format("Insert Into Itembook (EntryDate, BillDate, Itemid, Companyid, Kg, Qty, Rate, TrType) values ('{0}','{1}',{2},{3},{4},{5},{6},'{7}')",
                       DateTime.Now.ToString("yyyy/MM/dd"),
                       dtpBillDate.Value.ToString("yyyy/MM/dd"),
                       Liv.SubItems[1].Text,
                       MyModule.CompanyId,
                       (string.IsNullOrEmpty(Liv.SubItems[4].Text) ? 0 : Convert.ToDecimal(Liv.SubItems[4].Text)) * -1,
                       (string.IsNullOrEmpty(Liv.SubItems[5].Text) ? 0 : Convert.ToDecimal(Liv.SubItems[5].Text)) * -1,
                        string.IsNullOrEmpty(Liv.SubItems[6].Text) ? 0 : Convert.ToDecimal(Liv.SubItems[6].Text),
                       "TB");
                    RasClass.addrecord(query);
                //    query = String.Format("Update Itemmaster set StockKg =  {0} - {1} , StockQty = {2} - {3} where Id= {4} and CompanyId = {5}",
                //        tempStockKg,
                //       string.IsNullOrEmpty(Liv.SubItems[4].Text) ? 0 : (Convert.ToDecimal(Liv.SubItems[4].Text)),
                //        tempStockQty,
                //       string.IsNullOrEmpty(Liv.SubItems[5].Text) ? 0 : (Convert.ToDecimal(Liv.SubItems[5].Text)),
                //        Liv.SubItems[1].Text,
                //        MyModule.CompanyId
                //       );
                //RasClass.addrecord(query);
            }
                MessageBox.Show("Successfuly Save Your Details..!!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
        
        

        private void txtItemName_Validating(object sender, CancelEventArgs e)
        {
            ItemId = Convert.ToInt32(RasClass.GetValue("SELECT ID FROM itemMaster WHERE itemName = '" + txtItemName.Text + "' and CompanyId =" + MyModule.CompanyId));
            DataTable Dt = new DataTable();
            Dt = RasClass.FillDataTable("SELECT * FROM itemMaster WHERE itemName = '" + txtItemName.Text + "' and CompanyId =" + MyModule.CompanyId);
            if (Dt.Rows.Count > 0)
            {
                Itemid = Convert.ToInt32(Dt.Rows[0]["Id"]);
                txtHSN.Text = (Dt.Rows[0]["hsncode"].ToString());
                decimal MyCGSTPer = string.IsNullOrEmpty(Dt.Rows[0]["CgstPer"].ToString()) ? 0 : Convert.ToDecimal(Dt.Rows[0]["CgstPer"].ToString());
                decimal MySgstPer = string.IsNullOrEmpty(Dt.Rows[0]["SgstPer"].ToString()) ? 0 : Convert.ToDecimal(Dt.Rows[0]["CgstPer"].ToString());
                if (InState)
                {
                    txtCGSTPer.Text = MyCGSTPer.ToString();
                    txtSGSTPer.Text = MySgstPer.ToString();
                    txtIgstPer.Text = "0.00";
                }
                else
                {
                    txtCGSTPer.Text = "0.00";
                    txtSGSTPer.Text = "0.00";
                    txtIgstPer.Text = (MyCGSTPer + MySgstPer).ToString();
                }
            }
        }

        private void txtShopName_Validating(object sender, CancelEventArgs e)
        {
            ShopId = Convert.ToInt32(RasClass.GetValue("SELECT ID FROM shopMaster WHERE shopName = '" + txtShopName.Text + "' and CompanyId =" + MyModule.CompanyId));

            lblBillNo.Text = RasClass.GetValue("Select max(InvoiceNo) from TempInvoiceMaster where Shopid = " + ShopId + " and Companyid = " + MyModule.CompanyId).ToString();
            if(IsEdit == false)
            {
              txtBillNo.Text = RasClass.GetValue("Select max(InvoiceNo)+1 from TempInvoiceMaster where Shopid = " + ShopId + " and Companyid = " + MyModule.CompanyId).ToString();

            }

            txtTotalAmt.Text = RasClass.GetValue("Select Sum(TotalAmount) from TempInvoiceMaster where shopId = " + ShopId + " and CompanyId = " + MyModule.CompanyId + "").ToString();

            query = "SELECT ShopMaster.ShopName as PartyName, TempInvoiceMaster.InvoiceNo, TempInvoiceMaster.InvoiceDate, TempInvoiceMaster.TotalKg, TempInvoiceMaster.TotalAmount " +
            " FROM TempInvoiceMaster INNER JOIN ShopMaster ON TempInvoiceMaster.ShopId = ShopMaster.ID " +
            " WHERE(((TempInvoiceMaster.CompanyId) = " + MyModule.CompanyId +  ") AND((TempInvoiceMaster.ShopId) = " + ShopId + "));";

            dt = RasClass.FillDataTable(query);            
            dataGridView1.DataSource = dt;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            FrmSearch objSearch = new FrmSearch(5);
            objSearch.ShowDialog(this);
            SalesId = MyModule.FindId;

            if (Convert.ToInt32(SalesId).Equals(0).Equals(true))
            {
                BtnAddNew_Click(null, null);
            }
            else
            { FillData(SalesId); }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            IsEdit = true;
            txtShopName.Focus();
            BtnSave.Enabled = true;
        }

        private void txtShopName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        
        private void btnPrint_Click(object sender, EventArgs e)
        {
           
                PrintReport(Convert.ToInt32(SalesId));
           
        }
        public void PrintReport(Int32 SId)
        {
            RptSales MyReport = new RptSales();
            RptReport rr = new RptReport();
            MyReport.SetParameterValue("SalesId", Convert.ToInt32(SalesId));
            //rr.crystalReportViewer1.ReportSource = MyReport;
            //rr.Show();
            //MyReport.SetParameterValue("SalesId", Convert.ToInt32(SalesId));
            RasClass.SetDbLogon(MyReport);
        }

        public void FillData(int MyId)
        {
            DataTable DT = new DataTable();
            query = string.Empty;
            query = "SELECT TempInvoiceMaster.InvoiceId,ShopMaster.ShopName ,  TempInvoiceMaster.InvoiceNo ,TempInvoiceMaster.InvoiceDate, TempInvoiceMaster.TotalAmount, TempInvoiceMaster.TotalKg " +
                    "FROM TempInvoiceMaster left JOIN ShopMaster ON TempInvoiceMaster.ShopId = ShopMaster.ID " +
                    "WHERE(((TempInvoiceMaster.InvoiceId) =" + MyId + "));";
            DT = RasClass.FillDataTable(query);
            if (DT.Rows.Count > 0)
            {
                txtShopName.Text = DT.Rows[0]["ShopName"].ToString();
                dtpBillDate.Value = Convert.ToDateTime(DT.Rows[0]["InvoiceDate"].ToString());
                txtBillNo.Text = Convert.ToString(DT.Rows[0]["InvoiceNo"].ToString());
                DT = null;
                DT = new DataTable();
                query = string.Empty;
                query = "SELECT TempInvoiceDetail.InvoiceDetailId, TempInvoiceDetail.InvoiceId, TempInvoiceDetail.ItemId, TempInvoiceDetail.Hsn, TempInvoiceDetail.Kg , TempInvoiceDetail.Qty, TempInvoiceDetail.Rate, TempInvoiceDetail.Amount, TempInvoiceDetail.CgstPer, TempInvoiceDetail.CgstAmt, TempInvoiceDetail.SgstPer, TempInvoiceDetail.SgstAmt, TempInvoiceDetail.IgstPer, TempInvoiceDetail.IgstAmt,ItemMaster.ItemName " +
                        "FROM TempInvoiceDetail INNER JOIN ItemMaster ON TempInvoiceDetail.ItemId = ItemMaster.ID " +
                        "WHERE(((TempInvoiceDetail.InvoiceId) =" + MyId + "));";

                DT = RasClass.FillDataTable(query);
                listView1.Items.Clear();
                foreach (DataRow Dr in DT.Rows)
                {
                    listView1.Items.Add(Convert.ToString(listView1.Items.Count + 1));
                    //ListViewItem Liv = new ListViewItem();
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(Dr["ItemId"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(Dr["ItemName"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(Dr["Hsn"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(Dr["Kg"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(Dr["Qty"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(Dr["Rate"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(Dr["Amount"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(Dr["CgstPer"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(Dr["CgstAmt"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(Dr["SgstPer"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(Dr["SgstAmt"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(Dr["IgstPer"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(Dr["IgstAmt"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(Dr["Amount"].ToString());
                }
                txtSrNo.Text = (listView1.Items.Count + 1).ToString();
                txtShopName.Focus();
                TotalCalculation();
                BtnSave.Enabled = false;
            }
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            SalesId = Convert.ToInt32(RasClass.GetValue("Select Max(SalesID) from SalesMaster Where CompanyId=" + MyModule.CompanyId.ToString()));
            if (SalesId.Equals(0))
            {
                BtnCancel_Click(null, null);
            }
            else
            {
                FillData(SalesId);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            object SId = null;
            SId = RasClass.GetValue("SELECT Max(SalesId) FROM  SalesMaster Where CompanyId=" + MyModule.CompanyId.ToString() + " And SalesId < " + SalesId.ToString ());
            if (SId.ToString().Equals(String.Empty))
            {
                SalesId = 0;
                BtnCancel_Click(null, null);
            }
            else
            {
                SalesId = Convert.ToInt32(SId);
                FillData(SalesId);
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            object SId = null;
            SId = RasClass.GetValue("SELECT Min(SalesId) FROM  SalesMaster Where CompanyId=" + MyModule.CompanyId.ToString() + " And SalesId < " + SalesId.ToString());
            if (SId.ToString().Equals(String.Empty))
            {
                SalesId = 0;
                BtnCancel_Click(null, null);
            }
            else
            {
                SalesId = Convert.ToInt32(SId);
                FillData(SalesId);
            }
        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            SalesId = Convert.ToInt32(RasClass.GetValue("Select Min(SalesId) from SalesMaster Where CompanyId=" + MyModule.CompanyId.ToString()));
            if (SalesId.Equals(0))
            {
                BtnCancel_Click(null, null);
            }
            else
            {
                FillData(SalesId);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        private void txtSrNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKg_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTaxable_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCGSTAmt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCGSTPer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSGSTAmt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSGSTPer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHSN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}