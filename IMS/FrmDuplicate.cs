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
    public partial class FrmDuplicate : Form

    {
        ProjSet RasClass = new ProjSet();
        string query = string.Empty;
        public FrmDuplicate()
        {
            InitializeComponent();
            
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Invoice Number",Text,MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtSearch.Focus();
            }
            else
            {
                ShowData();
            }
        }

        private void FrmDuplicate_Load(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

        public void ShowData()
        {
            DataTable DT = new DataTable();
            query = "SELECT SalesMaster.BillNo, SalesMaster.BillDate, ShopMaster.ShopName, SalesMaster.TotalAmount, SalesMaster.IsPrint, CompanyMaster.ID " +
                    " FROM(ShopMaster INNER JOIN(SalesDetail INNER JOIN SalesMaster ON SalesDetail.SalesId = SalesMaster.SalesId) ON ShopMaster.ID = SalesMaster.ShopId) INNER JOIN CompanyMaster ON ShopMaster.CompanyId = CompanyMaster.ID " +
                    " WHERE(((SalesMaster.BillNo) = '" + txtSearch.Text + "') AND((CompanyMaster.ID) = " + MyModule.CompanyId + "));";
          
            DT = RasClass.FillDataTable(query);
            if (DT.Rows.Count > 0)
            {
                lblPartyName.Text = DT.Rows[0]["ShopName"].ToString();
                lblInvoiceDate.Text = DT.Rows[0]["BillDate"].ToString();
                lblAmount.Text = DT.Rows[0]["TotalAmount"].ToString();
                lblinvoiceNo.Text = DT.Rows[0]["BillNo"].ToString();
            }
        }

        public void ClearData()
        {
            txtSearch.Text = string.Empty;
            lblAmount.Text = string.Empty;
            lblInvoiceDate.Text = string.Empty;
            lblinvoiceNo.Text = string.Empty;
            lblPartyName.Text = string.Empty;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            query = "UPDATE SalesMaster Set IsPrint= 0 WHERE BillNo='" + txtSearch.Text + "' and CompanyId =" + MyModule.CompanyId;
            RasClass.addrecord(query);
            MessageBox.Show("Save Successfully", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearData();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}
