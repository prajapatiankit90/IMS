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
    public partial class FrmSalesReturn : Form
    {
        ProjSet RasClass = new ProjSet();
        bool IsEditItem = false;
        bool IsEdit = false;
        int ItemIdx = 0;
        string query = string.Empty;
        int SalesReturnId = 0;
        int ShopId = 0;
        int ItemId = 0;
        Int32 Itemid;
        bool InState = true;

        public FrmSalesReturn()
        {
            InitializeComponent();
        }

        private void FrmSalesMaster_Load(object sender, EventArgs e)
        {
            BtnAddNew_Click(null, null);
            txtShopName.Focus();
            lblbillNo.Text = RasClass.GetValue("select max(SalesreturnId) from salesreturnmaster where Companyid = " + MyModule.CompanyId + " and TrType = 'SR'").ToString();
            txtBillNo.Text = RasClass.GetValue("select max(SalesreturnId)+1 from salesreturnmaster where Companyid = " + MyModule.CompanyId + " and TrType = 'SR'").ToString();
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
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            Clear();
            ClearItem();
            txtSrNo.Text = "1";
            txtShopName.Focus();

        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            decimal Kg = string.IsNullOrEmpty(txtKg.Text) ? 0 : Convert.ToDecimal(txtKg.Text);
            decimal Qty = string.IsNullOrEmpty(txtQty.Text) ? 0 : Convert.ToDecimal(txtQty.Text);
            decimal Rate = string.IsNullOrEmpty(txtRate.Text) ? 0 : Convert.ToDecimal(txtRate.Text);
            decimal TotalAmt = ((Qty == 0 ? Kg : Qty) * Rate);
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
            if (string.IsNullOrEmpty(txtSalesBillNo.Text).Equals(false))
            {
                decimal StockKg = Convert.ToDecimal(RasClass.GetValue("SELECT SalesDetail.Kg FROM SalesMaster INNER JOIN SalesDetail ON SalesMaster.SalesId = SalesDetail.SalesId where salesmaster.billno = '"+ txtSalesBillNo.Text +"' and salesmaster.trtype = 'SB' and salesdetail.itemid = "+ Itemid + ""));
                
                if (StockKg < Convert.ToDecimal(txtKg.Text))
                {
                    DialogResult dialogResult = MessageBox.Show("Kg is greather than Sales bill " + Environment.NewLine + " Do You Want To Continue", "Conformation",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
            }
            if (string.IsNullOrEmpty(txtSalesBillNo.Text).Equals(false))
            {
                decimal StockQty = Convert.ToDecimal(RasClass.GetValue("SELECT SalesDetail.Qty FROM SalesMaster INNER JOIN SalesDetail ON SalesMaster.SalesId = SalesDetail.SalesId where salesmaster.billno = '" + txtSalesBillNo.Text + "' and salesmaster.trtype = 'SB' and salesdetail.itemid = " + Itemid + ""));
                if (StockQty < Convert.ToDecimal(txtQty.Text))
                {
                    DialogResult dialogResult = MessageBox.Show("Qty is greather than Sales bill" + Environment.NewLine +" Do You Want To Continue" , "Conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
            }
            if (string.IsNullOrEmpty(txtItemName.Text))
            {
                MessageBox.Show("Please Enter Item Name",Text,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                txtItemName.Focus();
                return;
            }
            if ((string.IsNullOrEmpty(txtQty.Text) && string.IsNullOrEmpty(txtKg.Text)) || (Convert.ToDecimal(txtQty.Text) == 0 && Convert.ToDecimal(txtKg.Text) == 0))
            {
                MessageBox.Show("Please Enter Item Quentity Or Kg.",Text,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                txtQty.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtRate.Text) || Convert.ToDecimal(txtRate.Text) == 0)
            {
                MessageBox.Show("Please Enter Item Rate.");
                txtRate.Focus();
                return;
            }

            //string Stock = string.Empty;
            //Stock = Convert.ToString(RasClass.GetValue("select Sum(Qty) from StockMaster Where ItemId = " + ItemId));

            //if (string.IsNullOrEmpty(Stock) || Convert.ToInt32(Stock) <= 0 || Convert.ToInt32(txtQty.Text) > Convert.ToInt32(Stock))
            //{
            //    MessageBox.Show("Stock Not Available..!", Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    txtItemName.Focus();
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

                    //object billno = RasClass.GetValue("SELECT billno FROM salesmaster WHERE billno ='" + txtBillNo.Text + "' AND CompanyId =" + MyModule.CompanyId);
                    //object trtype = RasClass.GetValue("Select Trtype FRom salesMaster where billno ='" + txtBillNo.Text + "' AND CompanyId = " + MyModule.CompanyId);
                    //if (trtype == "SB") {
                    //    if (!string.IsNullOrEmpty(Convert.ToString(billno)))
                    //    {
                    //        MessageBox.Show("This Billno Already Created. Please Enter New Bill No", "Sales Master", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //        txtBillNo.Focus();
                    //        return;
                    //    }
                    //}

                    // insert New record In Purhase Master
                    query = String.Format("Insert into SalesReturnMaster (ReturnBillNo,ReturnBillDate,TotalAmount, TotalKg , ShopId, CompanyId, TrType) Values ('{0}','{1}',{2},{3},{4},{5},'{6}')",
                        txtBillNo.Text.Trim(),
                        dtpBillDate.Value.ToString("yyyy/MM/dd"),
                        txtTotalAmt.Text.Trim(),
                        txtTotalKg.Text.Trim(),
                        ShopId,
                        MyModule.CompanyId,
                        "SR");
                    RasClass.addrecord(query);
                    SalesReturnId = Convert.ToInt32(RasClass.GetValue("Select MAX(SalesReturnid) From SalesReturnMaster where CompanyId = " + MyModule.CompanyId));
                }
                else
                {
                    // Update record In Purhase Master
                    query = String.Format("Update SalesReturnMaster Set ReturnBillNo = '{0}',ReturnBillDate = '{1}', TotalAmount = {2}, TotalKg = {3}, ShopId = {4} WHere SalesReturnId = {5} and CompanyId = {6}",
                        txtBillNo.Text.Trim(),
                        dtpBillDate.Value.ToString("yyyy/MM/dd"),
                        txtTotalAmt.Text.Trim(),
                        txtTotalKg.Text.Trim(),
                        ShopId,
                        SalesReturnId,
                        MyModule.CompanyId);
                    RasClass.addrecord(query);
                    // When Update Purchase Entry then Delete Record  from Purchase Details and Stock Master Corresponding Purchase Id
                    RasClass.addrecord("Delete From SalesReturnDetail WHere SalesReturnId = " + SalesReturnId.ToString());
                    RasClass.addrecord("Delete From StockMaster WHere SalesReturnId = " + SalesReturnId.ToString() + " And CompanyId = " + MyModule.CompanyId);

                }
                
                foreach (ListViewItem Liv in listView1.Items)
                {
                    decimal tempStockKg = Convert.ToDecimal(RasClass.GetValue("Select StockKg  from itemmaster where Id=" + Liv.SubItems[1].Text));
                    decimal tempStockQty = Convert.ToDecimal(RasClass.GetValue("Select StockQty  from itemmaster where Id=" + Liv.SubItems[1].Text));
                    query = string.Format("Insert Into SalesReturnDetail (SalesReturnId, ItemId, Hsn, Kg, Qty, Rate, Amount, CgstPer, CgstAmt, SgstPer, SgstAmt) Values ({0}, {1} ,'{2}',{3},{4},{5},{6},{7},{8},{9},{10})",
                        SalesReturnId,
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
                    query = string.Format("Insert Into StockMaster (Shopid, Itemid, Kg ,Qty, EntryDate,SalesReturnId,CompanyId,TrType) Values ({0},{1},{2},{3},'{4}',{5},{6},'{7}')",
                        ShopId,
                        Liv.SubItems[1].Text,
                        string.IsNullOrEmpty(Liv.SubItems[4].Text) ? 0 : Convert.ToDecimal(Liv.SubItems[4].Text),
                        string.IsNullOrEmpty(Liv.SubItems[5].Text) ? 0 : Convert.ToDecimal(Liv.SubItems[5].Text),
                        DateTime.Now.ToString("yyyy/MM/dd"),
                        SalesReturnId,
                        MyModule.CompanyId,
                        "SR");
                    RasClass.addrecord(query);
                    query = String.Format("Insert Into Itembook (EntryDate, BillDate, Itemid, Companyid, Kg, Qty, Rate, TrType) values ('{0}','{1}',{2},{3},{4},{5},{6},'{7}')",
                        DateTime.Now.ToString("yyyy/MM/dd"),
                        dtpBillDate.Value.ToString("yyyy/MM/dd"),
                        Liv.SubItems[1].Text,
                        MyModule.CompanyId,
                        string.IsNullOrEmpty(Liv.SubItems[4].Text) ? 0 : Convert.ToDecimal(Liv.SubItems[4].Text),
                        string.IsNullOrEmpty(Liv.SubItems[5].Text) ? 0 : Convert.ToDecimal(Liv.SubItems[5].Text),
                        string.IsNullOrEmpty(Liv.SubItems[6].Text) ? 0 : Convert.ToDecimal(Liv.SubItems[6].Text),
                        "SR");
                    RasClass.addrecord(query);
                    query = String.Format("Update Itemmaster set StockKg = StockKg - {0} + {1} , StockQty = StockQty - {2} + {3} where Id= {4} and CompanyId = {5}",
                        tempStockKg,
                        string.IsNullOrEmpty(Liv.SubItems[4].Text) ? 0 : Convert.ToDecimal(Liv.SubItems[4].Text),
                        tempStockQty,
                        string.IsNullOrEmpty(Liv.SubItems[5].Text) ? 0 : Convert.ToDecimal(Liv.SubItems[5].Text),
                        Liv.SubItems[1].Text,
                        MyModule.CompanyId
                       );
                    RasClass.addrecord(query);
                }
                MessageBox.Show("Successfuly Save Your Details..!!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            // PrintReport(Convert.ToInt32(SalesReturnId));
            BtnAddNew_Click(null, null);           
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
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            FrmSearch objSearch = new FrmSearch(4);
            objSearch.ShowDialog(this);
            SalesReturnId = MyModule.FindId;
            if (Convert.ToInt32(SalesReturnId).Equals(0).Equals(true))
            {
                BtnAddNew_Click(null, null);
            }
            else
            { FillData(SalesReturnId); }
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
            if (txtBillNo.Text == string.Empty)
            {
                MessageBox.Show("Please Enter BillNo", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBillNo.Focus();
                return;
            }
            else
            {
                PrintReport(Convert.ToInt32(SalesReturnId));
            }
        }
        public void PrintReport(Int32 SId)
        {
            RptSales MyReport = new RptSales();
            RptReport rr = new RptReport();
            MyReport.SetParameterValue("SalesReturnId", Convert.ToInt32(SalesReturnId));
            //rr.crystalReportViewer1.ReportSource = MyReport;
            //rr.Show();
            //MyReport.SetParameterValue("SalesReturnId", Convert.ToInt32(SalesReturnId));
            RasClass.SetDbLogon(MyReport);
        }

        public void FillData(int MyId)
        {
            DataTable DT = new DataTable();
            query = string.Empty;
            query = "SELECT SalesReturnMaster.SalesReturnId, ShopMaster.ShopName, SalesReturnMaster.ReturnBillNo ,SalesReturnMaster.ReturnBillDate, SalesReturnMaster.TotalAmount " +
                    "FROM SalesReturnMaster left JOIN ShopMaster ON SalesReturnMaster.ShopId = ShopMaster.ID " +
                    "WHERE(((SalesReturnMaster.SalesReturnId) =" + MyId + "));";
            DT = RasClass.FillDataTable(query);
            if (DT.Rows.Count > 0)
            {
                txtShopName.Text = DT.Rows[0]["ShopName"].ToString();
                dtpBillDate.Value = Convert.ToDateTime(DT.Rows[0]["ReturnBillDate"].ToString());
                txtBillNo.Text = Convert.ToString(DT.Rows[0]["ReturnBillNo"].ToString());
                DT = null;
                DT = new DataTable();
                query = string.Empty;
                query = "SELECT SalesReturnDetail.SalesDetailReturnId, SalesReturnDetail.SalesReturnId, SalesReturnDetail.ItemId, SalesReturnDetail.Hsn, SalesReturnDetail.Kg , SalesReturnDetail.Qty, SalesReturnDetail.Rate, SalesReturnDetail.Amount, SalesReturnDetail.CgstPer, SalesReturnDetail.CgstAmt, SalesReturnDetail.SgstPer, SalesReturnDetail.SgstAmt, SalesReturnDetail.IgstPer, SalesReturnDetail.IgstAmt,ItemMaster.ItemName " +
                        "FROM SalesReturnDetail INNER JOIN ItemMaster ON SalesReturnDetail.ItemId = ItemMaster.ID " +
                        "WHERE(((SalesReturnDetail.SalesReturnId) =" + MyId + "));";
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
            SalesReturnId = Convert.ToInt32(RasClass.GetValue("Select Max(SalesReturnId) from SalesMaster Where CompanyId=" + MyModule.CompanyId.ToString()));
            if (SalesReturnId.Equals(0))
            {
                BtnCancel_Click(null, null);
            }
            else
            {
                FillData(SalesReturnId);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            object SId = null;
            SId = RasClass.GetValue("SELECT Max(SalesReturnId) FROM  SalesMaster Where CompanyId=" + MyModule.CompanyId.ToString() + " And SalesReturnId < " + SalesReturnId.ToString ());
            if (SId.ToString().Equals(String.Empty))
            {
                SalesReturnId = 0;
                BtnCancel_Click(null, null);
            }
            else
            {
                SalesReturnId = Convert.ToInt32(SId);
                FillData(SalesReturnId);
            }
        }
        private void BtnNext_Click(object sender, EventArgs e)
        {
            object SId = null;
            SId = RasClass.GetValue("SELECT Min(SalesReturnId) FROM  SalesMaster Where CompanyId=" + MyModule.CompanyId.ToString() + " And SalesReturnId < " + SalesReturnId.ToString());
            if (SId.ToString().Equals(String.Empty))
            {
                SalesReturnId = 0;
                BtnCancel_Click(null, null);
            }
            else
            {
                SalesReturnId = Convert.ToInt32(SId);
                FillData(SalesReturnId);
            }
        }
        private void BtnFirst_Click(object sender, EventArgs e)
        {
            SalesReturnId = Convert.ToInt32(RasClass.GetValue("Select Min(SalesReturnId) from SalesMaster Where CompanyId=" + MyModule.CompanyId.ToString()));
            if (SalesReturnId.Equals(0))
            {
                BtnCancel_Click(null, null);
            }
            else
            {
                FillData(SalesReturnId);
            }
        }
    }
}