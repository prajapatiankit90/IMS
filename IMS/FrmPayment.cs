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
    public partial class FrmPayment : Form
    {
        DataTable dt = new DataTable();
        string query = string.Empty;
        public FrmPayment()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            ProjSet RasClass = new ProjSet();
            //query = "SELECT PurchaseMaster.IsPayment, PurchaseMaster.Purchseid, ShopMaster.ShopName, PurchaseMaster.EntryDate, PurchaseMaster.TotalAmount, PurchaseMaster.PaymentAmount, PurchaseMaster.TotalAmount-PurchaseMaster.PaymentAmount AS [Due Amount] FROM PurchaseMaster, ShopMaster WHERE(((PurchaseMaster.EntryDate) >= # " + dtpFromDate.Value.ToString("yyyy/MM/dd") + "# And (PurchaseMaster.EntryDate)<=#" + dtpToDate.Value.ToString("yyyy/MM/dd") + "#)) and ShopMaster.ShopName = '" + cmdShopName.Text + "' and PurchaseMaster.TotalAmount-PurchaseMaster.PaymentAmount <> 0";
            query = "SELECT PurchaseMaster.IsPayment, PurchaseMaster.Purchseid, ShopMaster.ShopName, PurchaseMaster.EntryDate, PurchaseMaster.TotalAmount, PurchaseMaster.PaymentAmount AS [Paid Amount], 0 AS [Pay Amount], PurchaseMaster.TotalAmount-PurchaseMaster.PaymentAmount AS [Due Amount] " +
                    "FROM ShopMaster INNER JOIN PurchaseMaster ON ShopMaster.ID = PurchaseMaster.ShopId " +
                    "WHERE(((PurchaseMaster.EntryDate) >=#" + dtpFromDate.Value.ToString("yyyy/MM/dd") + "# And (PurchaseMaster.EntryDate)<=#" + dtpToDate.Value.ToString("yyyy/MM/dd") + "#) AND (([PurchaseMaster].[TotalAmount]-[PurchaseMaster].[PaymentAmount])<>0) AND ((ShopMaster.ShopName)='" + cmdShopName.Text.Trim() + "'));";
            dt = RasClass.FillDataTable(query);
            dgDetails.DataSource = dt;
            dgDetails.AutoResizeColumns();
            dgDetails.Columns[1].ReadOnly = true;
            dgDetails.Columns[2].ReadOnly = true;
            dgDetails.Columns[3].ReadOnly = true;
            dgDetails.Columns[4].ReadOnly = true;
            dgDetails.Columns[5].ReadOnly = true;
            dgDetails.Columns[6].ReadOnly = true;
            dgDetails.Columns[7].ReadOnly = true;
            RasClass = null;
        }
        public void FillCombo()
        {
            ProjSet RassClass = new ProjSet();
            DataTable Dt = new DataTable();
            dt = RassClass.FillDataTable("Select ShopName From ShopMaster order by ShopName Asc");
            cmdShopName.Items.Clear();
            foreach (DataRow Dr in dt.Rows)
            {
                cmdShopName.Items.Add(Dr[0].ToString());
            }
        }

        private void FrmPayment_Shown(object sender, EventArgs e)
        {
            FillCombo();
        }

        private void dgDetails_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgDetails.Columns[6].Name.ToString() == "Pay Amount")
            {
                return;
            }
                if (dgDetails.IsCurrentCellDirty)
            {
                dgDetails.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgDetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dgDetails.Columns[6].ReadOnly = !Convert.ToBoolean(dgDetails.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (Convert.ToBoolean(dgDetails.Rows[e.RowIndex].Cells[0].Value.ToString()) == false)
            {
                dgDetails.Rows[e.RowIndex].Cells[6].Value = 0;
            }
           

            if (dgDetails.Columns[e.ColumnIndex ].Name.ToString() == "IsPayment")
            {

                int TotalAmt = string.IsNullOrEmpty(dgDetails.Rows[e.RowIndex].Cells[4].Value.ToString()) ? 0 : Convert.ToInt32(dgDetails.Rows[e.RowIndex].Cells[4].Value);
                int PreAmount = string.IsNullOrEmpty(dgDetails.Rows[e.RowIndex].Cells[5].Value.ToString()) ? 0 : Convert.ToInt32(dgDetails.Rows[e.RowIndex].Cells[5].Value);
                int CurrPayAmt = string.IsNullOrEmpty(dgDetails.Rows[e.RowIndex].Cells[6].Value.ToString()) ? 0 : Convert.ToInt32(dgDetails.Rows[e.RowIndex].Cells[6].Value);
                dgDetails.Rows[e.RowIndex].Cells[7].Value = (TotalAmt - PreAmount).ToString();
            }

            if (dgDetails.Columns[e.ColumnIndex].Name.ToString() == "Pay Amount")
            {

                int TotalAmt = string.IsNullOrEmpty(dgDetails.Rows[e.RowIndex].Cells[4].Value.ToString()) ? 0 : Convert.ToInt32(dgDetails.Rows[e.RowIndex].Cells[4].Value);
                int PreAmount = string.IsNullOrEmpty(dgDetails.Rows[e.RowIndex].Cells[5].Value.ToString()) ? 0 : Convert.ToInt32(dgDetails.Rows[e.RowIndex].Cells[5].Value);
                int CurrPayAmt = string.IsNullOrEmpty(dgDetails.Rows[e.RowIndex].Cells[6].Value.ToString()) ? 0 : Convert.ToInt32(dgDetails.Rows[e.RowIndex].Cells[6].Value);
                int DueAmt = string.IsNullOrEmpty(dgDetails.Rows[e.RowIndex].Cells[7].Value.ToString()) ? 0 : Convert.ToInt32(dgDetails.Rows[e.RowIndex].Cells[7].Value);
                if (CurrPayAmt>DueAmt)
                {
                    MessageBox.Show("Pay Amount not More Then Due Amount","Paymet Process",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;

                }
                dgDetails.Rows[e.RowIndex].Cells[7].Value = (TotalAmt - (PreAmount + CurrPayAmt)).ToString();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            ProjSet RasClass = new ProjSet();
            foreach (DataGridViewRow dr in dgDetails.Rows)
            {
                if (Convert.ToBoolean(dr.Cells[0].Value.ToString()) == true)
                    {
                    query = string.Empty;
                    int BillAmount = string.IsNullOrEmpty(dr.Cells[4].Value.ToString()) ? 0 : Convert.ToInt32(dr.Cells[4].Value);
                    int PreAmount = string.IsNullOrEmpty(dr.Cells[5].Value.ToString()) ? 0 : Convert.ToInt32(dr.Cells[5].Value);
                    int CurrPayAmt = string.IsNullOrEmpty(dr.Cells[6].Value.ToString()) ? 0 : Convert.ToInt32(dr.Cells[6].Value);
                    int DueAmount = string.IsNullOrEmpty(dr.Cells[7].Value.ToString()) ? 0 : Convert.ToInt32(dr.Cells[7].Value);
                    int TotalPayAmount = PreAmount + CurrPayAmt;
                    // Insert into Payment Details
                    query = string.Format("insert into PaymentDetails (Purchseid,TotalAmount,PaidAmount,DueAmount,PaymentDate) Values ({0},{1},{2},{3},'{4}')", dr.Cells[1].Value.ToString(), BillAmount, CurrPayAmt, DueAmount,DateTime.Now.ToString("yyyy/MM/dd"));
                    RasClass.addrecord(query);
                    query = string.Empty;

                    // Update purchase Master
                    query = "Update PurchaseMaster set PaymentAmount = " + TotalPayAmount.ToString() + ", PaymentDate = #" + DateTime.Now.ToString("yyyy/MM/dd") + "# where Purchseid = " + dr.Cells[1].Value.ToString();
                    RasClass.addrecord(query);
                    MessageBox.Show("Payment Process Successfully Completed..!!","Payment Process",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    
                }
            }
            RasClass = null;
            BtnSearch_Click(null, null);
        }

        private void FrmPayment_Load(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            dtpFromDate.Value = DateTime.Now;
            dtpToDate.Value = DateTime.Now;
            cmdShopName.Text = string.Empty;
            BtnSearch_Click(null, null);
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
