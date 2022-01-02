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
    public partial class FrmSearch : Form
    {
        int SearchType = 0;
        string  Query;
        DataTable DT = new DataTable();
        
        public FrmSearch(int MySearch)
        {
            InitializeComponent();
            SearchType = MySearch;
        }

        private void FrmSearch_Load(object sender, EventArgs e)
        {

        }

        private void FrmSearch_Shown(object sender, EventArgs e)
        {
            BtnSearch_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgDetails.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please Select any Row.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (SearchType == 1)
            {
                // Purchase Search
                MyModule.FindId = Convert.ToInt32(dgDetails.SelectedRows[0].Cells[0].Value.ToString());
            }
            else if (SearchType == 2)
            {
                //Sales Search
                MyModule.FindId = Convert.ToInt32(dgDetails.SelectedRows[0].Cells[0].Value.ToString());
            }
            else if (SearchType == 3)
            {
                // Purchase Return
                MyModule.FindId = Convert.ToInt32(dgDetails.SelectedRows[0].Cells[0].Value.ToString());
            }
            else if (SearchType == 4)
            {
                // Sales Return Search
                MyModule.FindId = Convert.ToInt32(dgDetails.SelectedRows[0].Cells[0].Value.ToString());
            }
            else if (SearchType == 5)
            {
                // Sales Return Search
                MyModule.FindId = Convert.ToInt32(dgDetails.SelectedRows[0].Cells[0].Value.ToString());
            }
            Close();
        }

        private void txtShopName_TextChanged(object sender, EventArgs e)
        {

         
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (SearchType == 1)
            {
                // Purchase Search
                //Query = "SELECT PurchaseMaster.Purchseid, ShopMaster.ShopName, PurchaseMaster.EntryDate, PurchaseMaster.BillDate, PurchaseMaster.TotalAmount FROM ShopMaster INNER JOIN PurchaseMaster ON ShopMaster.ID = PurchaseMaster.ShopId WHERE (((ShopMaster.ShopName) Like '%" + txtSearch.Text + "%') AND ((PurchaseMaster.BillDate)>=#" + dtpFromDate.Value.ToString("yyyy/MM/dd") + "# And (PurchaseMaster.BillDate)<=#" + dtpToDate.Value.ToString("yyyy/MM/dd") + "#));";
                Query = "SELECT " +
                        "PurchaseMaster.Purchseid, " + 
                        " ShopMaster.ShopName, " +
                        "PurchaseMaster.EntryDate, " +
                        "PurchaseMaster.BillDate, " +
                        "PurchaseMaster.TotalAmount, " +
                        "PurchaseMaster.TrType " +
                        "FROM(ShopMaster INNER JOIN PurchaseMaster ON ShopMaster.ID = PurchaseMaster.ShopId) " +
                        "INNER JOIN CompanyMaster ON PurchaseMaster.CompanyId = CompanyMaster.ID " +
                        "WHERE(((ShopMaster.ShopName)Like '%" + txtSearch.Text + "%') " +
                        "AND((PurchaseMaster.BillDate) >=#" + dtpFromDate.Value.ToString("yyyy/MM/dd") + "# And (PurchaseMaster.BillDate)<=#" + dtpToDate.Value.ToString("yyyy/MM/dd") + "#)) " +
                        "AND (PurchaseMaster.CompanyId =" + MyModule.CompanyId  + ") AND (PurchaseMaster.TrType='PB');";
            }
            else if (SearchType == 2)
            {
                //Sales Search
               // Query = "SELECT SalesMaster.SalesId, ShopMaster.ShopName, SalesMaster.BillNo ,SalesMaster.BillDate, SalesMaster.TotalAmount FROM ShopMaster INNER JOIN SalesMaster ON ShopMaster.ID = SalesMaster.ShopId WHERE (((ShopMaster.ShopName) Like '%" + txtSearch.Text + "%') AND ((SalesMaster.BillDate)>=#" + dtpFromDate.Value.ToString("yyyy/MM/dd") + "# And (SalesMaster.BillDate)<=#" + dtpToDate.Value.ToString("yyyy/MM/dd") + "#));";
                Query = "SELECT " +
                         "SalesMaster.SalesId, " +
                         "ShopMaster.ShopName, "+
                         "SalesMaster.BillNo, "+
                         "SalesMaster.BillDate, "+
                         "SalesMaster.TotalAmount, "+
                         "SalesMaster.TrType " +
                         "FROM(ShopMaster INNER JOIN SalesMaster ON ShopMaster.ID = SalesMaster.ShopId) " +
                         "INNER JOIN CompanyMaster ON SalesMaster.CompanyId = CompanyMaster.ID "+
                         "WHERE(((ShopMaster.ShopName)Like '%" + txtSearch.Text + "%') " +
                        "AND((SalesMaster.BillDate) >=#" + dtpFromDate.Value.ToString("yyyy/MM/dd") + "# And (SalesMaster.BillDate)<=#" + dtpToDate.Value.ToString("yyyy/MM/dd") + "#)) " +
                        "AND (SalesMaster.CompanyId =" + MyModule.CompanyId + ") AND (SalesMAster.TrType='SB');";
            }
            else if (SearchType == 3)
            {
                // Purchase return Search
                Query = "SELECT " +
                        "PurchaseReturnMaster.PurchseReturnid, " +
                        " ShopMaster.ShopName, " +
                        "PurchaseReturnMaster.EntryDate, " +
                        "PurchaseReturnMaster.ReturnBillDate, " +
                        "PurchaseReturnMaster.TotalAmount, " +
                        "PurchaseReturnMaster.TrType " +
                        "FROM(ShopMaster INNER JOIN PurchaseReturnMaster ON ShopMaster.ID = PurchaseReturnMaster.ShopId) " +
                        "INNER JOIN CompanyMaster ON PurchaseReturnMaster.CompanyId = CompanyMaster.ID " +
                        "WHERE(((ShopMaster.ShopName)Like '%" + txtSearch.Text + "%') " +
                        "AND((PurchaseReturnMaster.ReturnBillDate) >=#" + dtpFromDate.Value.ToString("yyyy/MM/dd") + "# And (PurchaseReturnMaster.ReturnBillDate)<=#" + dtpToDate.Value.ToString("yyyy/MM/dd") + "#)) " +
                        "AND (PurchaseReturnMaster.CompanyId =" + MyModule.CompanyId + ") AND (PurchaseReturnMAster.TrType='PR');";
            }
            else if(SearchType == 4)
            {
                // Sales Return Search
                Query = "SELECT " +
                         "SalesReturnMaster.SalesreturnId, " +
                         "ShopMaster.ShopName, " +
                         "SalesReturnMaster.ReturnBillNo, " +
                         "SalesReturnMaster.ReturnBillDate, " +
                         "SalesReturnMaster.TotalAmount, " +
                         "SalesReturnMaster.TrType " +
                         "FROM(ShopMaster INNER JOIN SalesReturnMaster ON ShopMaster.ID = SalesReturnMaster.ShopId) " +
                         "INNER JOIN CompanyMaster ON SalesReturnMaster.CompanyId = CompanyMaster.ID " +
                         "WHERE(((ShopMaster.ShopName)Like '%" + txtSearch.Text + "%') " +
                        "AND((SalesReturnMaster.ReturnBillDate) >=#" + dtpFromDate.Value.ToString("yyyy/MM/dd") + "# And (SalesReturnMaster.ReturnBillDate)<=#" + dtpToDate.Value.ToString("yyyy/MM/dd") + "#)) " +
                        "AND (SalesReturnMaster.CompanyId =" + MyModule.CompanyId + ") AND (SalesReturnMAster.TrType='SR');";
            }
            else if (SearchType == 5)
            {
                // Sales Return Search
                Query = "SELECT " +
                         "TempInvoiceMaster.InvoiceId, " +
                         "ShopMaster.ShopName, " +
                         "TempInvoiceMaster.InvoiceNo, " +
                         "TempInvoiceMaster.InvoiceDate, " +
                         "TempInvoiceMaster.TotalAmount " +
                         "FROM(ShopMaster INNER JOIN TempInvoiceMaster ON ShopMaster.ID = TempInvoiceMaster.ShopId) " +
                         "INNER JOIN CompanyMaster ON TempInvoiceMaster.CompanyId = CompanyMaster.ID " +
                         "WHERE(((ShopMaster.ShopName)Like '%" + txtSearch.Text + "%') " +
                        "AND((TempInvoiceMaster.InvoiceDate) >=#" + dtpFromDate.Value.ToString("yyyy/MM/dd") + "# And (TempInvoiceMaster.InvoiceDate)<=#" + dtpToDate.Value.ToString("yyyy/MM/dd") + "#)) " +
                        "AND (TempInvoiceMaster.CompanyId =" + MyModule.CompanyId + ") AND (TempInvoiceMaster.TrType='TB');";
            }
            if (!string.IsNullOrEmpty(Query))
            {
                ProjSet RasClass = new ProjSet();
                DT = RasClass.FillDataTable(Query);
                dgDetails.DataSource = DT;
                dgDetails.AutoResizeColumns();
                dgDetails.ClearSelection();
                cmbSearch.Items.Clear();
                foreach (DataColumn dc in DT.Columns)
                {
                    if ((dc.ColumnName.ToLower() == "entrydate" || dc.ColumnName.ToLower() == "billdate"))
                    { continue; }

                    cmbSearch.Items.Add(dc.ColumnName.ToString());
                }
            }
        }
    }
}
