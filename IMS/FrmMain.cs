using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports .UI;
namespace IMS
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(Form _Frm)
        {
            FrmMain objMain = new IMS.FrmMain();
            _Frm.Icon = objMain.Icon;
            _Frm.MdiParent = this;
            _Frm.Show();
            objMain = null;
        }

        private void userMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MyModule.CompanyId == 0)
            {
                MessageBox.Show("Please Select Company..!!", Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            else
            {
                FrmUserMaster usermaster = new FrmUserMaster();
                ShowNewForm(usermaster);
            }
        }

        private void shopMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MyModule.CompanyId == 0)
            {
                MessageBox.Show("Please Select Company..!!", Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            else
            {
                FrmShopMaster shopmaster = new FrmShopMaster();
                ShowNewForm(shopmaster);
            }
        }

        private void itemMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MyModule.CompanyId == 0)
            {
                MessageBox.Show("Please Select Company..!!", Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            else
            {
                FrmItemMaster itemmaster = new FrmItemMaster();
                ShowNewForm(itemmaster);
            }
        }

        private void purchaseMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MyModule.CompanyId == 0)
            {
                MessageBox.Show("Please Select Company..!!", Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            else
            {
                FrmPurchaseMaster purchasemaster = new FrmPurchaseMaster();
                ShowNewForm(purchasemaster);
            }
        }

        private void salesMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MyModule.CompanyId == 0)
            {
                MessageBox.Show("Please Select Company..!!", Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            else
            {
                FrmSalesMaster salesmaster = new FrmSalesMaster();
                ShowNewForm(salesmaster);
            }
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Msg = MessageBox.Show("Are You Sure Close..", "Inventory Management System", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (Msg == DialogResult.Yes)
            {
                e.Cancel=false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MyModule.CompanyId == 0)
            {
                MessageBox.Show("Please Select Company..!!", Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            else
            {
                FrmStockMaster objStock = new IMS.FrmStockMaster();
                ShowNewForm(objStock);
            }
        }

        private void purchasePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MyModule.CompanyId == 0)
            {
                MessageBox.Show("Please Select Company..!!", Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            else
            {
                FrmPayment objPayment = new IMS.FrmPayment();
                ShowNewForm(objPayment);
            }
        }

        private void showPaymentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MyModule.CompanyId == 0)
            {
                MessageBox.Show("Please Select Company..!!", Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            else
            {
                FrmPaymentDetail objPaymentDetail = new IMS.FrmPaymentDetail();
                ShowNewForm(objPaymentDetail);
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmCompanySelection CmpMaster = new FrmCompanySelection();
            CmpMaster.FormBorderStyle = FormBorderStyle.None;
            ShowNewForm(CmpMaster);
            
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChangePassword changepwd = new IMS.FrmChangePassword();
            ShowNewForm(changepwd);
        }

        private void lblTimer_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        }

        private void Prossess_Click(object sender, EventArgs e)
        {

        }

        private void companyMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if(MyModule.CompanyId == 0)
            {
                MessageBox.Show("Please Select Company..!!", Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            else
            {
                FrmCompanyMaster CmpMaster = new FrmCompanyMaster();
                ShowNewForm(CmpMaster);
            }
        }

        private void changeCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCompanySelection CmpSelection = new FrmCompanySelection();
            CmpSelection.FormBorderStyle = FormBorderStyle.None;
            ShowNewForm(CmpSelection);
        }

        private void bankMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MyModule.CompanyId == 0)
            {
                MessageBox.Show("Please Select Company..!!", Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            else
            {
                FrmBankMaster BankMaster = new IMS.FrmBankMaster();
                ShowNewForm(BankMaster);
            }
                
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salesRetrunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MyModule.CompanyId == 0)
            {
                MessageBox.Show("Please Select Company..!!", Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            else
            {
                FrmSalesReturn SaleReturn = new IMS.FrmSalesReturn();
                ShowNewForm(SaleReturn);
            }
        }

        private void purchaseReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MyModule.CompanyId == 0)
            {
                MessageBox.Show("Please Select Company..!!", Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            else
            {
                FrmPurchaseReturn PurchaseReturn = new IMS.FrmPurchaseReturn();
                ShowNewForm(PurchaseReturn);
            }
                

        }

        private void invoiceMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MyModule.CompanyId == 0)
            {
                MessageBox.Show("Please Select Company..!!", Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            else
            {
                FrmInvoiceMaster InvoiceMaster = new IMS.FrmInvoiceMaster();
                ShowNewForm(InvoiceMaster);
            }
        }

        private void removeDuplicateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MyModule.CompanyId == 0)
            {
                MessageBox.Show("Please Select Company..!!", Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            else
            {
                FrmDuplicate Duplicate = new IMS.FrmDuplicate();
                ShowNewForm(Duplicate);
            }

        }
    }
}
