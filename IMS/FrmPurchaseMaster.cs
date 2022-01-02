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
    public partial class FrmPurchaseMaster : Form
    {

        bool IsEditItem = false;
        bool IsEdit = false;
        int ItemIdx = 0;
        ProjSet RasClass = new ProjSet();
        string query;
        int PurchaseId = 0;
        Int32 shopid;
        Int32 Itemid;
        bool InState = true;

        public FrmPurchaseMaster()
        {
            InitializeComponent();
        }

        private void FrmPurchaseMaster_Load(object sender, EventArgs e)
        {
            BtnAddNew_Click(null, null);
            txtShopName.Focus();
        }

        private void Clear()
        {
            txtShopName.Text = string.Empty;
            txtBillNo.Text = string.Empty;
            dtpBillDate.Value = DateTime.Now;
            listView1.Items.Clear();
            txtShopName.Focus();
            txtTotalCGSTAmt.Text = string.Empty;
            txtTotalIgstAmt.Text = string.Empty;
            txtTotalSGSTAmt.Text = string.Empty;
            txtTotal.Text = string.Empty;
            txtTotalKg.Text = string.Empty;
            IsOpening.Checked = false;
        }

        private void ClearItem()
        {
            txtItemName.Text = string.Empty;
            txtHSN.Text = string.Empty;
            txtKg.Text =  "0";
            txtQty.Text = "0";
            txtRate.Text = string.Empty;
            txtTotalAmount .Text = string.Empty;
            txtCGSTPer.Text = string.Empty;
            txtCGSTAmt.Text = string.Empty;
            txtSGSTPer.Text = string.Empty;
            txtSGSTAmt.Text = string.Empty;
            txtIgstPer.Text = string.Empty;
            txtIgstAmt.Text = string.Empty;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            decimal Kg = string.IsNullOrEmpty(txtKg.Text) ? 0 : Convert.ToDecimal(txtKg.Text);
            decimal Qty = string.IsNullOrEmpty(txtQty.Text) ? 0 : Convert.ToDecimal(txtQty.Text);
            decimal Rate = string.IsNullOrEmpty(txtRate.Text) ? 0 : Convert.ToDecimal(txtRate.Text);
            decimal TotalAmt = ((Kg == 0 ? Qty : Kg) * Rate);
            txtTaxable.Text = TotalAmt.ToString("#0.00");
            decimal CGST = string.IsNullOrEmpty(txtCGSTPer.Text) ? 0 : Convert.ToDecimal(txtCGSTPer.Text);
            decimal SGST = string.IsNullOrEmpty(txtSGSTPer.Text) ? 0 : Convert.ToDecimal(txtSGSTPer.Text);
            
            if (InState)
            {
                txtCGSTAmt.Text = ((TotalAmt * CGST) / 100).ToString("#0.00");
                txtSGSTAmt.Text = ((TotalAmt * SGST) / 100).ToString("#0.00");
            }
            else
            {
                txtCGSTAmt.Text = "0.00";
                txtSGSTAmt.Text = "0.00";
            }
            txtTotalAmount.Text = (TotalAmt + Convert.ToDecimal(txtCGSTAmt.Text) + Convert.ToDecimal(txtCGSTAmt.Text)).ToString();
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtItemName.Text))
            {
                MessageBox.Show("Please Enter Item Name","Purchase Master",MessageBoxButtons.OK);
                txtItemName.Focus();
                return;
            }
            if ((string.IsNullOrEmpty(txtQty.Text) && string.IsNullOrEmpty(txtKg.Text)) || (Convert.ToDecimal(txtQty.Text) == 0 && Convert.ToDecimal(txtKg.Text) == 0))
            {
                MessageBox.Show("Please Enter Item Quentity Or Kg.","Purchase Master", MessageBoxButtons.OK);
                txtQty.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtRate.Text))
            {
                MessageBox.Show("Please Enter Item Rate.","Purchase Master", MessageBoxButtons.OK);
                txtRate.Focus();
                return;
            }
            
            if (IsEditItem == false)
            {
                ListViewItem Liv = new ListViewItem();
                Liv.Text = (listView1.Items.Count + 1).ToString();
                Liv.SubItems.Add(Convert.ToString(Itemid));
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
            DialogResult Dr = MessageBox.Show("Are You Sure Want to you?", "Purchase Master", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Dr == DialogResult.Yes)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
                foreach (ListViewItem liv in listView1.Items)
                {
                    liv.Text = (liv.Index + 1).ToString();
                }
                txtSrNo.Text = (listView1.Items.Count + 1).ToString();
                TotalCalculation();
                ItemIdx = 0;
                IsEditItem = false;
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

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            Clear();
            ClearItem();
            txtSrNo.Text = "1";
            txtShopName.Focus();

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                txtSrNo.Text = listView1.SelectedItems[0].Text;
                txtItemName.Tag = listView1.SelectedItems[0].SubItems[1].Text ;
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

        private void FrmPurchaseMaster_Shown(object sender, EventArgs e)
        {
           RasClass.FillText("Select ShopName from ShopMaster where inactive=0 And CompanyId = " + MyModule.CompanyId, txtShopName);
           RasClass.FillText("Select ItemName from ItemMaster where inactive=0 And CompanyId = " + MyModule.CompanyId, txtItemName);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            IsEdit = true;
            txtShopName.Focus();
            BtnSave.Enabled = true;
        }

        public void txtShopName_Validating(object sender, CancelEventArgs e)
        {
            shopid = Convert.ToInt32(RasClass.GetValue("SELECT ID FROM shopMaster WHERE shopName = '"+txtShopName.Text +"' And CompanyId = " + MyModule.CompanyId));
            //InState = Convert.ToBoolean(RasClass.GetValue("SELECT InState FROM shopMaster WHERE shopName = '" + txtShopName.Text + "'"));
        }

        public  void txtItemName_Validating(object sender, CancelEventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = RasClass .FillDataTable("SELECT * FROM itemMaster WHERE itemName = '" + txtItemName.Text + "' And CompanyId = " + MyModule.CompanyId);
            if (Dt.Rows.Count > 0)
            {
                Itemid = Convert.ToInt32(Dt.Rows[0]["Id"]);
                txtHSN.Text = Dt.Rows[0]["Hsncode"].ToString();
                decimal MyCGSTPer = string.IsNullOrEmpty(Dt.Rows[0]["CgstPer"].ToString()) ? 0 : Convert.ToDecimal(Dt.Rows[0]["CgstPer"].ToString());
                decimal MySgstPer = string.IsNullOrEmpty(Dt.Rows[0]["SgstPer"].ToString()) ? 0 : Convert.ToDecimal(Dt.Rows[0]["CgstPer"].ToString());
                if (InState)
                {
                    txtCGSTPer.Text = MyCGSTPer.ToString();
                    txtSGSTPer.Text = MySgstPer.ToString();
                   
                }
                else
                {
                    txtCGSTPer.Text = "0.00";
                    txtSGSTPer.Text = "0.00";
                   
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(IsOpening.Checked == true)
            {
                txtBillNo.Text = "0";
            }
            if (txtBillNo.Text == string.Empty)
            {
                    MessageBox.Show("Please Enter Bill No..!!", Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    txtBillNo.Focus();                
            }
            else
            {
                if (IsEdit == false)
                {
                    // insert New record In Purhase Master
                    query = String.Format("Insert into PurchaseMaster (EntryDate, BillNo, BillDate, TotalAmount, TotalKg ,Shopid, PaymentAmount, CompanyId, TrType, IsOpening) Values ('{0}','{1}','{2}',{3},{4},{5},0,{6},'{7}',{8})",
                        DateTime.Now.ToString("yyy/MM/dd"),
                        txtBillNo.Text.Trim(),
                        dtpBillDate.Value.ToString("yyyy/MM/dd"),
                        txtTotal.Text.Trim(),
                        txtTotalKg.Text,
                        shopid,
                        MyModule.CompanyId,
                        "PB",
                        IsOpening.Checked);
                    RasClass.addrecord(query);
                    PurchaseId = Convert.ToInt32(RasClass.GetValue("Select MAX(Purchseid) From PurchaseMaster Where CompanyId = "+ MyModule.CompanyId ));
                }
                else
                {
                    // Update record In Purhase Master
                    query = String.Format("Update PurchaseMaster Set BillNo = '{0}',BillDate = '{1}', TotalAmount = {2}, ShopId = {3}, IsOpening = {4} WHere Purchseid = {5} And CompanyId = {6}",
                        txtBillNo.Text.Trim(),
                        dtpBillDate.Value.ToString("yyyy/MM/dd"),
                        txtTotal.Text.Trim(),
                        shopid,
                        PurchaseId,
                        MyModule.CompanyId,
                        IsOpening.Checked);
                    RasClass.addrecord(query);
                    // When Update Purchase Entry then Delete Record  from Purchase Details and Stock Master Corresponding Purchase Id
                    RasClass.addrecord("Delete From PurchaseDetail WHere PurchaseId = " + PurchaseId.ToString());
                    RasClass.addrecord("Delete From StockMaster WHere PurchaseId = " + PurchaseId.ToString() + " And CompanyId = " + MyModule.CompanyId);
                }

                foreach (ListViewItem Liv in listView1.Items)
                {
                    decimal tempStockKg = Convert.ToDecimal(RasClass.GetValue("Select StockKg  from itemmaster where Id=" + Liv.SubItems[1].Text));
                    decimal tempStockQty = Convert.ToDecimal(RasClass.GetValue("Select StockQty  from itemmaster where Id=" + Liv.SubItems[1].Text));
                    query = string.Format("Insert Into PurchaseDetail (PurchaseId, ItemId, Hsn, Kg, Qty, Rate,Amount,CgstPer,CgstAmt,SgstPer,SgstAmt) Values ({0},{1},'{2}',{3},{4},{5},{6},{7},{8},{9},{10})",
                        PurchaseId,
                        Liv.SubItems[1].Text,
                        Liv.SubItems[3].Text,
                        string.IsNullOrEmpty(Liv.SubItems[4].Text) ? 0 : Convert.ToDecimal(Liv.SubItems[4].Text),
                        string.IsNullOrEmpty(Liv.SubItems[5].Text) ? 0 : Convert.ToDecimal(Liv.SubItems[5].Text),
                        string.IsNullOrEmpty(Liv.SubItems[6].Text) ? 0 : Convert.ToDecimal(Liv.SubItems[6].Text),
                        Liv.SubItems[7].Text,
                        Liv.SubItems[8].Text,
                        Liv.SubItems[9].Text,
                        Liv.SubItems[10].Text,
                        Liv.SubItems[11].Text);
                    RasClass.addrecord(query);
                    query = string.Format("Insert Into StockMaster (Shopid, Itemid, Kg ,Qty, EntryDate,PurchaseId,Companyid, TrType) Values ({0},{1},{2},{3},'{4}',{5},{6},'{7}')",
                        shopid,
                        Liv.SubItems[1].Text,
                         string.IsNullOrEmpty(Liv.SubItems[4].Text) ? 0 : Convert.ToDecimal(Liv.SubItems[4].Text),
                        string.IsNullOrEmpty(Liv.SubItems[5].Text) ? 0 : Convert.ToDecimal(Liv.SubItems[5].Text),
                        DateTime.Now.ToString("yyyy/MM/dd"),
                        PurchaseId,
                        MyModule.CompanyId,
                        "PB");
                    RasClass.addrecord(query);
                    query = String.Format("Insert Into Itembook (EntryDate, BillDate, Itemid, Companyid, Kg, Qty, Rate, TrType) values ('{0}','{1}',{2},{3},{4},{5},{6},'{7}')",
                       DateTime.Now.ToString("yyyy/MM/dd"),
                       dtpBillDate.Value.ToString("yyyy/MM/dd"),
                       Liv.SubItems[1].Text,
                       MyModule.CompanyId,
                        string.IsNullOrEmpty(Liv.SubItems[4].Text) ? 0 : Convert.ToDecimal(Liv.SubItems[4].Text),
                        string.IsNullOrEmpty(Liv.SubItems[5].Text) ? 0 : Convert.ToDecimal(Liv.SubItems[5].Text),
                        string.IsNullOrEmpty(Liv.SubItems[6].Text) ? 0 : Convert.ToDecimal(Liv.SubItems[6].Text),
                       "PB");
                    RasClass.addrecord(query);
                    query = String.Format("Update Itemmaster set StockKg = {0} + {1} , StockQty = {2} + {3} where Id= {4}",
                         tempStockKg,
                         Convert.ToDecimal(Liv.SubItems[4].Text),
                         tempStockQty,
                         Convert.ToDecimal(Liv.SubItems[5].Text),
                         Liv.SubItems[1].Text
                        );
                    RasClass.addrecord(query);
                }
                MessageBox.Show("Successfully Save Your Details ..!!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnAddNew_Click(null, null);
            }
        }
        public void TotalCalculation()
        {
            txtTotal.Text = string.Empty;
            txtTotalCGSTAmt.Text = string.Empty;
            txtTotalSGSTAmt.Text = string.Empty;
            txtTotalIgstAmt.Text = string.Empty;
            txtTotalKg.Text = string.Empty;

            foreach (ListViewItem li in listView1.Items)
            {
                decimal Total = string.IsNullOrEmpty(txtTotal.Text) ? 0 : Convert.ToDecimal(txtTotal.Text);
                decimal CGST = string.IsNullOrEmpty(txtTotalCGSTAmt.Text) ? 0 : Convert.ToDecimal(txtTotalCGSTAmt.Text);
                decimal SGST = string.IsNullOrEmpty(txtTotalSGSTAmt.Text) ? 0 : Convert.ToDecimal(txtTotalSGSTAmt.Text);
                decimal TotalKg = string.IsNullOrEmpty(txtTotalKg.Text) ? 0 : Convert.ToDecimal(txtTotalKg.Text);                            
                
                decimal MyCGST = string.IsNullOrEmpty(li.SubItems[9].Text) ? 0 : Convert.ToDecimal(li.SubItems[9].Text);
                decimal MySGST = string.IsNullOrEmpty(li.SubItems[11].Text) ? 0 : Convert.ToDecimal(li.SubItems[11].Text);
                decimal MyTotal = string.IsNullOrEmpty(li.SubItems[12].Text) ? 0 : Convert.ToDecimal(li.SubItems[12].Text);
                decimal MyKg = string.IsNullOrEmpty(li.SubItems[4].Text) ? 0 : Convert.ToDecimal(li.SubItems[4].Text);

                txtTotalAmt.Text = (Total + MyTotal).ToString("#0.00");
                txtTotalCGSTAmt.Text = (CGST + MyCGST).ToString("#0.00");
                txtTotalSGSTAmt.Text = (SGST + MySGST).ToString("#0.00");
                txtTotalKg.Text = (TotalKg + MyKg).ToString("#0.00");
                txtTotal.Text = txtTotalAmt.Text; //(Convert.ToDecimal(txtTotalAmt.Text) + Convert.ToDecimal(txtTotalCGSTAmt.Text) + Convert.ToDecimal(txtTotalSGSTAmt.Text) + Convert.ToDecimal(txtTotalIgstAmt.Text)).ToString();
            }
        }

        private void txtShopName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            FrmSearch objSearch = new FrmSearch(1);
            objSearch.ShowDialog(this);
            PurchaseId = MyModule.FindId;

            if (Convert.ToInt32(PurchaseId).Equals(0).Equals(true))
            {
                BtnAddNew_Click(null, null);
            }
            else
            { FillData(PurchaseId); }

        }
        public void FillData(int MyId)
        {
            DataTable Dt = new DataTable();
            query = string.Empty;
            //query = "SELECT PurchaseMaster.Purchseid, ShopMaster.ShopName, PurchaseMaster.EntryDate, PurchaseMaster.BillDate, PurchaseMaster.TotalAmount FROM ShopMaster INNER JOIN PurchaseMaster ON ShopMaster.ID = PurchaseMaster.ShopId WHere PurchaseMaster.Purchseid = " + PurchaseId +";";
            query = "SELECT PurchaseMaster.Purchseid, ShopMaster.ShopName, PurchaseMaster.EntryDate, PurchaseMaster.BillNo , PurchaseMaster.BillDate, PurchaseMaster.TotalAmount, PurchaseMaster.TotalKg ,PurchaseMaster.Companyid  " +
                    "FROM(ShopMaster INNER JOIN PurchaseMaster ON ShopMaster.ID = PurchaseMaster.ShopId) INNER JOIN CompanyMaster ON PurchaseMaster.CompanyId = CompanyMaster.ID " +
                    "WHERE(((PurchaseMaster.Purchseid) = "+ PurchaseId + " And [PurchaseMaster].[Companyid] = " + MyModule.CompanyId + "));";

            Dt = RasClass.FillDataTable(query);
            if (Dt.Rows.Count > 0)
            {
                txtShopName.Text = Dt.Rows[0]["ShopName"].ToString();
                txtBillNo.Text = Convert.ToString(Dt.Rows[0]["BillNo"].ToString());
                dtpBillDate.Value = Convert.ToDateTime(Dt.Rows[0]["BillDate"].ToString());
                Dt = null;
                Dt = new DataTable();
                query = string.Empty;
                query = "SELECT PurchaseDetail.PurchaseDetailId, PurchaseDetail.PurchaseId, PurchaseDetail.ItemId, PurchaseDetail.Hsn, PurchaseDetail.Kg, PurchaseDetail.Qty, PurchaseDetail.Rate, PurchaseDetail.Amount, PurchaseDetail.CgstPer, PurchaseDetail.CgstAmt, PurchaseDetail.SgstPer, PurchaseDetail.SgstAmt, PurchaseDetail.IgstPer, PurchaseDetail.IgstAmt,ItemMaster.ItemName " +
                         "FROM ItemMaster INNER JOIN PurchaseDetail ON ItemMaster.ID = PurchaseDetail.ItemId " +
                         "WHERE(((PurchaseDetail.PurchaseId) = " + PurchaseId + ")); ";
                Dt = RasClass.FillDataTable(query);
                listView1.Items.Clear();
                foreach (DataRow Dr in Dt.Rows)
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
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(Dr["Kg"].ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(Dr["Qty"].ToString());
                }
                txtSrNo.Text = (listView1.Items.Count + 1).ToString();
                txtShopName.Focus();
                TotalCalculation();
                BtnSave.Enabled = false;
            }
        }

        private void txtTotalCGSTAmt_TextChanged(object sender, EventArgs e)
        {

        }

        private void IsOpening_CheckedChanged(object sender, EventArgs e)
        {
            txtBillNo.Text = "0";
            if(IsOpening.Checked == true)
            {
                txtBillNo.Enabled = false;
            }
            else
            {
                txtBillNo.Enabled = true;
                txtBillNo.Text = "";
            }
        }
    }
}
