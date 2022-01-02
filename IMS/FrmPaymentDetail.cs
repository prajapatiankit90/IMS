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
    public partial class FrmPaymentDetail : Form
    {
        DataTable dt = new DataTable();
        string query = string.Empty;
        public FrmPaymentDetail()
        {
            InitializeComponent();
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

        private void FrmPaymentDetail_Shown(object sender, EventArgs e)
        {
            FillCombo();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            ProjSet RasClass = new ProjSet();
            query = "SELECT ShopMaster.ShopName,PaymentDetails.PaymentDate, PaymentDetails.TotalAmount, PaymentDetails.PaidAmount, PaymentDetails.DueAmount FROM(PurchaseMaster INNER JOIN PaymentDetails ON PurchaseMaster.Purchseid = PaymentDetails.Purchseid) INNER JOIN ShopMaster ON PurchaseMaster.ShopId = ShopMaster.ID WHERE (((ShopMaster.ShopName)='"+cmdShopName.Text.Trim()+"') AND ((PaymentDetails.PaymentDate)>=#"+ dtpFromDate.Value.ToString("yyyy/MM/dd") +"# And (PaymentDetails.PaymentDate)<=#"+ dtpToDate.Value.ToString("yyyy/MM/dd") +"#));";
            dt = RasClass.FillDataTable(query);
            dgDetails.DataSource = dt;
            dgDetails.AutoResizeColumns();
        }

        private void FrmPaymentDetail_Load(object sender, EventArgs e)
        {

        }
    }
}
