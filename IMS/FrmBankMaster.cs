using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
namespace IMS
{
    public partial class FrmBankMaster : Form
    {
        string query;
        ProjSet RasClass = new ProjSet();
        Boolean IsEdit = false;
        public FrmBankMaster()
        {
            InitializeComponent();
        }

        private void FrmBankMaster_Load(object sender, EventArgs e)
        {
            FillData();
        }
        public void FillData()
        {
            gridControl1.DataSource = RasClass.FillDataTable("Select * From BankMaster where companyId =" + MyModule.CompanyId);
            gridView1.Columns[0].Visible = false;
            gridView1.Columns[4].Visible = false;
            gridView1.Columns[5].Visible = false;
            gridView1.Columns[6].Visible = false;
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            txtBankName.Focus();
            txtBankName.Clear();
            txtid.Clear();
            txtAccountNo.Clear();
            txtIFSCCode.Clear();
            BtnSave.Enabled = true;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            IsEdit = true;
            txtid.Focus();
            BtnSave.Enabled = true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult Msg = XtraMessageBox.Show("Are You Sure Delete..", "Information", MessageBoxButtons.YesNo);
            if (Msg == DialogResult.Yes)
            {
                query = "UPDATE BankMaster SET inActive = 1 and UpdateDate= '" + DateTime.Now + "' where id = " + txtid.Text + "";
                RasClass.addrecord(query);
                MessageBox.Show("Deleted Your Shop..!!",Text,MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtBankName.Clear();
                FrmBankMaster_Load(null, null);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtBankName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Bank Name..",Text,MessageBoxButtons.OK,MessageBoxIcon.Question);
                txtBankName.Focus();
                return;
            }
            else if (txtAccountNo.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Account No..",Text,MessageBoxButtons.OK,MessageBoxIcon.Question);
                txtAccountNo.Focus();
                return;
            }
            else if (txtIFSCCode.Text == string.Empty)
            {
                MessageBox.Show("Please Enter IFSC Code..", Text, MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtIFSCCode.Focus();
                return;
            }
            else 
            {
                if (IsEdit == false)
                {
                    object ShName = RasClass.GetValue("Select BankName From BankMaster WHERE BankName = '" + txtBankName.Text.Trim().ToString() + "' and CompanyId = " + MyModule.CompanyId + "");
                    if (Convert.ToString(ShName) != "")
                    {
                        MessageBox.Show("Bank Name Already Exists.", Text,MessageBoxButtons.OK,MessageBoxIcon.Error);
                        txtBankName.Focus();
                        return;
                    }
                    query = "INSERT INTO BANKMASTER (BankName,AccountNo,IFSCCode,AddDate,CompanyId) values ('" + txtBankName.Text + "','" + txtAccountNo.Text + "','" + txtIFSCCode.Text  + "','" + DateTime.Now +"',"+ MyModule.CompanyId +")";
                 }
                else
                {
                    object ShNameCnt = RasClass.GetValue("Select Count(BankName) From BankMaster WHERE BankName = '" + txtBankName.Text.Trim().ToString() + "' and CompnyId = " + MyModule.CompanyId + " Group By BankName");
                    if (Convert.ToInt32(ShNameCnt) > 1)
                    {
                        MessageBox.Show("Bank Name Already Exists.", Text ,MessageBoxButtons.OK,MessageBoxIcon.Error);
                        txtBankName.Focus();
                        return;
                    }
                    query = "UPDATE Bankmaster set Bankname= '"+ txtBankName.Text + "',AccountNo='"+ txtAccountNo.Text +"',IFSCCode='"+ txtIFSCCode.Text + "',UpdateDate='" + DateTime.Now +"' where id = " + txtid.Text + " And CompanyId = " + MyModule.CompanyId + "";
                }
                RasClass.addrecord(query);
                MessageBox.Show("Successfully Save..", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnAddNew_Click(null, null);
                FillData();
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            txtid.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0].FieldName.ToString()).ToString();
            txtBankName.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1].FieldName.ToString()).ToString();
            txtAccountNo.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2].FieldName.ToString()).ToString();
            txtIFSCCode.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[3].FieldName.ToString()).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BtnAddNew_Click(null, null);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
