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
    public partial class FrmCompanyMaster : Form
    {
        Boolean IsEdit = false;
        String SqlString;
        public FrmCompanyMaster()
        {
            InitializeComponent();
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            ClearData();
            txtCmpName.Focus();
            BtnSave.Enabled = true;
        }
        public void ClearData()
        {
            txtid.Text = string.Empty;
            txtCmpName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtGsttinNo.Text = string.Empty;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            IsEdit = true;
            txtid.Focus();
            BtnSave.Enabled = true;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtCmpName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Company Name..!!",Text,MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            else if (txtAddress.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Address..!!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtGsttinNo.Text == string.Empty)
            {
                MessageBox.Show("Please Enter GSTIN No..!!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (IsEdit == false)
                {
                    ProjSet RasClass = new ProjSet();
                    SqlString = "Insert Into CompanyMaster (CmpName,Address,GsttinNo) Values ('"+ txtCmpName.Text +"','"+ txtAddress.Text +"','"+ txtGsttinNo.Text +"')";
                    RasClass.addrecord(SqlString);
                }
                else
                {
                    ProjSet RasClass = new ProjSet();
                    SqlString = "Update CompanyMaster SET CmpName = '" + txtCmpName.Text + "', Address = '" + txtAddress.Text + "', GsttinNo = '" + txtGsttinNo.Text + "' where id = " + txtid.Text + "";
                    RasClass.addrecord(SqlString);
                }
                MessageBox.Show("SuccesFully Save Your Data...", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData();
                FillData();
            }
        }
        public void FillData()
        {
            ProjSet RasClass = new ProjSet();
            gridControl1.DataSource = RasClass.FillDataTable("Select * From CompanyMaster");
            //gridView1.Columns[0].Visible = false;
            //gridView1.Columns[4].Visible = false;
            //gridView1.Columns[5].Visible = false;
            //gridView1.Columns[6].Visible = false;
        }

        private void FrmCompanyMaster_Load(object sender, EventArgs e)
        {
            FillData();
            BtnAddNew_Click(null, null);            
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtid.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0].FieldName.ToString()).ToString();
            txtCmpName .Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1].FieldName.ToString()).ToString();
            txtAddress.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2].FieldName.ToString()).ToString();
            txtGsttinNo.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[3].FieldName.ToString()).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
