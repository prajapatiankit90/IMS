using DevExpress.XtraEditors;
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
    public partial class FrmItemMaster : Form
    {
        string query;
        ProjSet RasClass = new ProjSet();
        Boolean IsEdit = false;
        public FrmItemMaster()
        {
            InitializeComponent();
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            button6_Click(null, null);
            BtnSave.Enabled = true;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            IsEdit = true;
            txtid.Focus();
            BtnSave.Enabled = true;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtItemName .Text == string.Empty)
            {
                MessageBox.Show("Please Enter ItemName..!!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtItemName.Focus();
                return;
            }
            else if (txtCGSTPer.Text == string.Empty)
            {
                MessageBox.Show("Enter CGST PER..!!",Text,MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtCGSTPer.Focus();
                return;
            }
            else if (txtSGSTPer.Text == string.Empty)
            {
                MessageBox.Show("Enter SGST PER..!!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSGSTPer.Focus();
                return;
            }
            else if (txthsncode.Text == string.Empty)
            {
                MessageBox.Show("Enter HSN Code..!!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txthsncode.Focus();
                return;
            }
            //else if (txtIGSTPer.Text == string.Empty)
            //{
            //    XtraMessageBox.Show("Enter IGST PER..!!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtIGSTPer.Focus();
            //    return;
            //}
            else
            {
                if (IsEdit == false)
                {
                    object ShName = RasClass.GetValue("Select ItemName From ItemMaster WHERE ItemName = '" + txtItemName.Text.Trim().ToString() + "' and Inactive = 0");
                    if (Convert.ToString(ShName) != "")
                    {
                        MessageBox.Show("Item Name Already Exists.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtItemName.Focus();
                        return;
                    }

                    query = "Insert into Itemmaster (itemname,Hsncode,CgstPer,SgstPer,IgstPer,EntryDate,CompanyId) values ('" + txtItemName.Text.Trim().ToString() +"','"+ txthsncode.Text.Trim().ToString() +"',"+ txtCGSTPer.Text +","+ txtSGSTPer.Text+",'0','"+ DateTime.Now + "'," +MyModule.CompanyId +")";
                    RasClass.addrecord(query);
                    txtItemName.Clear();
                    txthsncode.Clear();
                    txtCGSTPer.Clear();
                    txtSGSTPer.Clear();
                    txtIGSTPer.Text= "0";
                    MessageBox.Show("Successfully Save Your Data..!!",Text,MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    object ShNameCnt = RasClass.GetValue("Select Count(itemName) From ItemMaster WHERE itemName = '" + txtItemName.Text.Trim().ToString() + "' Group By ItemName");
                    if (Convert.ToInt32(ShNameCnt) > 1)
                    {
                        MessageBox.Show("Item Name Already Exists.", "Error");
                        txtItemName.Focus();
                        return;
                    }
                    query = "UPDATE Itemmaster set Itemname= '"+txtItemName.Text+ "', Hsncode= '" + txthsncode.Text + "', CgstPer=" + txtCGSTPer.Text +",SgstPer="+ txtSGSTPer.Text +",IgstPer=0,UpdateDate='"+DateTime.Now+ "',CompanyId = " + MyModule.CompanyId + " where id = " + txtid.Text +"";
                    RasClass.addrecord(query);
                    txtItemName.Clear();
                    txthsncode.Clear();
                    txtCGSTPer.Clear();
                    txtSGSTPer.Clear();
                    txtIGSTPer.Text = "0";
                    MessageBox.Show("Successfully Save Your Data..!!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IsEdit = false;
                }
                
            }
            FillData();
            BtnAddNew_Click(null, null);
        }
        public void FillData()
        {
            gridControl1.DataSource = RasClass.FillDataTable("Select * From ItemMaster where inactive= 0 and companyId = " + MyModule.CompanyId+ " order by id desc");
            gridView1.Columns[0].Visible = false;
            gridView1.Columns[3].Visible = false;
            gridView1.Columns[6].Visible = false;
            gridView1.Columns[7].Visible = false;
            gridView1.Columns[8].Visible = false;
            gridView1.Columns[9].Visible = false;
            gridView1.Columns[10].Visible = false;
            gridView1.Columns[11].Visible = false;

        }

        private void FrmItemMaster_Load(object sender, EventArgs e)
        {
            FillData();
            BtnAddNew_Click(null, null);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult Msg = XtraMessageBox.Show("Are You Sure Delete..", "Information", MessageBoxButtons.YesNo);
            if (Msg == DialogResult.Yes)
            {
                query = "UPDATE itemMaster SET inActive = 1 where id = " + txtid.Text + "";
                RasClass.addrecord(query);
                MessageBox.Show("Deleted Your Shop..!!");
                txtItemName.Clear();
                FrmItemMaster_Load(null, null);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtItemName.Text = string.Empty;
            txtid.Text = string.Empty;
            txthsncode.Text = string.Empty;
            txtIGSTPer.Text = string.Empty;
            txtSGSTPer.Text = string.Empty;
            txtCGSTPer.Text = string.Empty;
        }

        private void dgDetail_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //int index;
            //index = e.RowIndex;
            //txtid.Text = dgDetail.Rows[e.RowIndex].Cells[0].Value.ToString();
            //txtItemName.Text = dgDetail.Rows[e.RowIndex].Cells[1].Value.ToString();
            //txtCGSTPer.Text = dgDetail.Rows[e.RowIndex].Cells[3].Value.ToString();
            //txtSGSTPer.Text = dgDetail.Rows[e.RowIndex].Cells[4].Value.ToString();
            //txtIGSTPer.Text = dgDetail.Rows[e.RowIndex].Cells[5].Value.ToString();
            //BtnSave.Enabled = false;
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtid.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0].FieldName.ToString()).ToString();
            txtItemName.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1].FieldName.ToString()).ToString();
            txthsncode.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2].FieldName.ToString()).ToString();
            txtSGSTPer.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[5].FieldName.ToString()).ToString();
            txtIGSTPer.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[6].FieldName.ToString()).ToString();
            txtCGSTPer.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[4].FieldName.ToString()).ToString();
            BtnSave.Enabled = false;
        }
    }
}
