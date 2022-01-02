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
    public partial class FrmPurchaseReturn : Form
    {

        bool IsEditItem = false;
        bool IsEdit = false;
        int ItemIdx = 0;
        ProjSet RasClass = new ProjSet();
        string query;
        int PurchaseReturnId = 0;
        Int32 shopid;
        Int32 Itemid;
        bool InState = true;

        public FrmPurchaseReturn()
        {
            InitializeComponent();
        }

        private void FrmPurchaseMaster_Load(object sender, EventArgs e)
        {
            BtnAddNew_Click(null, null);
            txtShopName.Focus();
            lblBillNo.Text = RasClass.GetValue("select max(PurchseReturnid) from PurchaseReturnMaster where Companyid = " + MyModule.CompanyId + " and TrType = 'PR'").ToString();
            txtBillNo.Text = RasClass.GetValue("select max(PurchseReturnid)+1 from PurchaseReturnMaster where Companyid = " + MyModule.CompanyId + " and TrType = 'PR'").ToString();
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
        }

        private void ClearItem()
        {
            txtItemName.Text = string.Empty;
            txtHSN.Text = string.Empty;
            txtKg.Text = "0";
            txtQty.Text =  "0";
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
            decimal TotalAmt = ((Qty == 0 ? Kg : Qty) * Rate);
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
            if (string.IsNullOrEmpty(txtpurchaseBillNo.Text).Equals(false))
            {
                decimal StockKg = Convert.ToDecimal(RasClass.GetValue("SELECT StockKg FROM ItemMaster id = " + Itemid));

                if (StockKg < Convert.ToDecimal(txtKg.Text))
                {
                    DialogResult dialogResult = MessageBox.Show("Kg is greather than Comapair to Purchase Bill " + Environment.NewLine + " Do You Want To Continue", "Conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
            }
            if (string.IsNullOrEmpty(txtpurchaseBillNo.Text).Equals(false))
            {
                decimal StockQty = Convert.ToDecimal(RasClass.GetValue("SELECT StockQty FROM ItemMaster id = "+ Itemid));
                if (StockQty < Convert.ToDecimal(txtQty.Text))
                {
                    DialogResult dialogResult = MessageBox.Show("Qty is greather than  Comapair to Purchase bill" + Environment.NewLine + " Do You Want To Continue", "Conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
            }
            if (string.IsNullOrEmpty(txtItemName.Text))
            {
                MessageBox.Show("Please Enter Item Name","Purchase Master",MessageBoxButtons.OK);
                txtItemName.Focus();
                return;
            }
            if ((string.IsNullOrEmpty(txtQty.Text) && string.IsNullOrEmpty(txtKg.Text)))
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
            if (txtBillNo.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Bill No..!!", Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtBillNo.Focus();
                return;
            }
            else
            {
                if (IsEdit == false)
                {
                    // insert New record In Purhase Master
                    query = String.Format("Insert into PurchaseReturnMaster (EntryDate, ReturnBillNo, ReturnBillDate, TotalAmount, TotalKg , Shopid, PaymentAmount, CompanyId, TrType) Values ('{0}','{1}','{2}',{3},{4},{5},0,'{6}')",
                        DateTime.Now.ToString("yyy/MM/dd"),
                        txtBillNo.Text.Trim(),
                        dtpBillDate.Value.ToString("yyyy/MM/dd"),
                        txtTotal.Text.Trim(),
                        txtTotalKg.Text.Trim(),
                        shopid,
                        MyModule.CompanyId,
                        "PR");
                    RasClass.addrecord(query);
                    PurchaseReturnId = Convert.ToInt32(RasClass.GetValue("Select MAX(PurchseReturnid) From PurchaseReturnMaster Where CompanyId = "+ MyModule.CompanyId ));
                }
                else
                {
                    // Update record In Purhase Master
                    query = String.Format("Update PurchaseReturnMaster Set ReturnBillNo = '{0}',ReturnBillDate = '{1}', TotalAmount = {2}, ShopId = {3} WHere PurchseReturnid = {4} And CompanyId = {5}",
                        txtBillNo.Text.Trim(),
                        dtpBillDate.Value.ToString("yyyy/MM/dd"),
                        txtTotal.Text.Trim(),
                        shopid,
                        PurchaseReturnId,
                        MyModule.CompanyId);
                    RasClass.addrecord(query);
                    // When Update Purchase Entry then Delete Record  from Purchase Details and Stock Master Corresponding Purchase Id
                    RasClass.addrecord("Delete From PurchaseReturnDetail WHere PurchaseReturnId = " + PurchaseReturnId.ToString());
                    RasClass.addrecord("Delete From StockMaster WHere PurchaseReturnId = " + PurchaseReturnId.ToString() + " And CompanyId = " + MyModule.CompanyId);

                }

                foreach (ListViewItem Liv in listView1.Items)
                {
                    decimal tempStockKg = Convert.ToDecimal(RasClass.GetValue("Select StockKg  from itemmaster where Id=" + Liv.SubItems[1].Text));
                    decimal tempStockQty = Convert.ToDecimal(RasClass.GetValue("Select StockQty  from itemmaster where Id=" + Liv.SubItems[1].Text));
                    query = string.Format("Insert Into PurchaseReturnDetail (PurchaseDetailReturnId, ItemId, Hsn, Kg, Qty, Rate,Amount,CgstPer,CgstAmt,SgstPer,SgstAmt) Values ({0},{1},'{2}',{3},{4},{5},{6},{7},{8},{9},{10})",
                        PurchaseReturnId,
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
                    query = string.Format("Insert Into StockMaster (Shopid, Itemid, Kg , Qty, EntryDate,PurchaseReturnId,Companyid, TrType) Values ({0},{1},{2},{3},'{4}',{5},{6},'{7}')",
                        shopid,
                        Liv.SubItems[1].Text,
                        string.IsNullOrEmpty(Liv.SubItems[4].Text) ? 0 : (Convert.ToDecimal(Liv.SubItems[4].Text)) * -1,
                        string.IsNullOrEmpty(Liv.SubItems[5].Text) ? 0 : (Convert.ToDecimal(Liv.SubItems[5].Text)) * -1,
                        DateTime.Now.ToString("yyyy/MM/dd"),
                        PurchaseReturnId,
                        MyModule.CompanyId,
                        "PR");
                    RasClass.addrecord(query);
                    query = String.Format("Insert Into Itembook (EntryDate, BillDate, Itemid, Companyid, Kg, Qty, Rate, TrType) values ('{0}','{1}',{2},{3},{4},{5},{6},'{7}')",
                       DateTime.Now.ToString("yyyy/MM/dd"),
                       dtpBillDate.Value.ToString("yyyy/MM/dd"),
                       Liv.SubItems[1].Text,
                       MyModule.CompanyId,
                      "-" + (string.IsNullOrEmpty(Liv.SubItems[4].Text) ? 0 : Convert.ToDecimal(Liv.SubItems[4].Text)),
                      "-" + (string.IsNullOrEmpty(Liv.SubItems[5].Text) ? 0 : Convert.ToDecimal(Liv.SubItems[5].Text)),
                      string.IsNullOrEmpty(Liv.SubItems[6].Text) ? 0 : Convert.ToDecimal(Liv.SubItems[6].Text),
                       "PR");
                    RasClass.addrecord(query);
                    query = String.Format("Update Itemmaster set StockKg =  {0} - {1} , StockQty = {2} - {3} where Id= {4} and companyid={5}",
                       tempStockKg,
                      string.IsNullOrEmpty(Liv.SubItems[4].Text) ? 0 : (Convert.ToDecimal(Liv.SubItems[4].Text)),
                       tempStockQty,
                      string.IsNullOrEmpty(Liv.SubItems[5].Text) ? 0 : (Convert.ToDecimal(Liv.SubItems[5].Text)),
                       Liv.SubItems[1].Text,
                       MyModule.CompanyId
                      );
                    RasClass.addrecord(query);

                }
                MessageBox.Show("Successfully Save Your Details ..!!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
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
                decimal MyTotalKg = string.IsNullOrEmpty(txtTotalKg.Text) ? 0 : Convert.ToDecimal(txtTotalKg.Text);

                decimal MyCGST = string.IsNullOrEmpty(li.SubItems[9].Text) ? 0 : Convert.ToDecimal(li.SubItems[9].Text);
                decimal MySGST = string.IsNullOrEmpty(li.SubItems[11].Text) ? 0 : Convert.ToDecimal(li.SubItems[11].Text);
                decimal MyTotal = string.IsNullOrEmpty(li.SubItems[12].Text) ? 0 : Convert.ToDecimal(li.SubItems[12].Text);
                decimal MyKg = string.IsNullOrEmpty(li.SubItems[4].Text) ? 0 : Convert.ToDecimal(li.SubItems[4].Text);

                txtTotalKg.Text = (Total + MyTotal).ToString("#0.00");
                txtTotalCGSTAmt.Text = (CGST + MyCGST).ToString("#0.00");
                txtTotalSGSTAmt.Text = (SGST + MySGST).ToString("#0.00");
                txtTotalKg.Text = (MyTotalKg + MyKg).ToString("#0.00");
                txtTotal.Text = txtTotalKg.Text; //(Convert.ToDecimal(txtTotalAmt.Text) + Convert.ToDecimal(txtTotalCGSTAmt.Text) + Convert.ToDecimal(txtTotalSGSTAmt.Text) + Convert.ToDecimal(txtTotalIgstAmt.Text)).ToString();
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
            FrmSearch objSearch = new FrmSearch(3);
            objSearch.ShowDialog(this);
            PurchaseReturnId = MyModule.FindId;

            if (Convert.ToInt32(PurchaseReturnId).Equals(0).Equals(true))
            {
                BtnAddNew_Click(null, null);
            }
            else
            { FillData(PurchaseReturnId); }

        }
        public void FillData(int MyId)
        {
            DataTable Dt = new DataTable();
            query = string.Empty;
            //query = "SELECT PurchaseMaster.Purchseid, ShopMaster.ShopName, PurchaseMaster.EntryDate, PurchaseMaster.BillDate, PurchaseMaster.TotalAmount FROM ShopMaster INNER JOIN PurchaseMaster ON ShopMaster.ID = PurchaseMaster.ShopId WHere PurchaseMaster.Purchseid = " + PurchaseId +";";
            query = "SELECT PurchaseReturnMaster.PurchaseReturnId, ShopMaster.ShopName, PurchaseReturnMaster.EntryDate, PurchaseReturnMaster.ReturnBillNo , PurchaseReturnMaster.RetunBillDate, PurchaseReturnMaster.TotalAmount, PurchaseReturnMaster.Companyid  " +
                    "FROM(ShopMaster INNER JOIN PurchaseReturnMaster ON ShopMaster.ID = PurchaseReturnMaster.ShopId) INNER JOIN CompanyMaster ON PurchaseReturnMaster.CompanyId = CompanyMaster.ID " +
                    "WHERE(((PurchaseReturnMaster.Purchseid) = "+ PurchaseReturnId + " And [PurchaseReturnMaster].[Companyid] = " + MyModule.CompanyId + "));";

            Dt = RasClass.FillDataTable(query);
            if (Dt.Rows.Count > 0)
            {
                txtShopName.Text = Dt.Rows[0]["ShopName"].ToString();
                txtBillNo.Text = Convert.ToString(Dt.Rows[0]["ReturnBillNo"].ToString());
                dtpBillDate.Value = Convert.ToDateTime(Dt.Rows[0]["ReturnBillDate"].ToString());
                Dt = null;
                Dt = new DataTable();
                query = string.Empty;
                query = "SELECT PurchaseReturnDetail.PurchaseReturnDetailId, PurchaseReturnDetail.PurchaseId, PurchaseReturnDetail.ItemId, PurchaseReturnDetail.Hsn, PurchaseReturnDetail.Kg, PurchaseReturnDetail.Qty, PurchaseReturnDetail.Rate, PurchaseReturnDetail.Amount, PurchaseReturnDetail.CgstPer, PurchaseReturnDetail.CgstAmt, PurchaseReturnDetail.SgstPer, PurchaseReturnDetail.SgstAmt, PurchaseReturnDetail.IgstPer, PurchaseReturnDetail.IgstAmt,ItemMaster.ItemName " +
                         "FROM ItemMaster INNER JOIN PurchaseReturnDetail ON ItemMaster.ID = PurchaseReturnDetail.ItemId " +
                         "WHERE(((PurchaseReturnDetail.PurchaseReturnId) = " + PurchaseReturnId + ")); ";
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
                }
                txtSrNo.Text = (listView1.Items.Count + 1).ToString();
                txtShopName.Focus();
                TotalCalculation();
                BtnSave.Enabled = false;
            }
        }
    }
}
