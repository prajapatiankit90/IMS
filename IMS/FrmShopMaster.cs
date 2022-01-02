using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using DevExpress.XtraEditors;

namespace IMS
{
    public partial class FrmShopMaster : Form
    {
        string query;
        ProjSet RasClass = new ProjSet();
        Boolean IsEdit = false;
        public FrmShopMaster()
        {
            InitializeComponent();
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            txtShopName.Focus();
            button6_Click(null, null);
            BtnSave.Enabled= true;
            
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtShopName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Shop Name..!!", Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            else if (txtAddress.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Address..!!", Text,MessageBoxButtons.OK,MessageBoxIcon.Hand);
                return;
            }
            else
            {
                if (IsEdit == false)
                {
                    object ShName = RasClass.GetValue("Select ShopName From ShopMaster WHERE ShopName = '" + txtShopName.Text.Trim().ToString() + "'");
                    if (Convert.ToString(ShName) != "")
                    {
                        MessageBox.Show("Shop Name Already Exists.", Text,MessageBoxButtons.OK,MessageBoxIcon.Error);
                        txtShopName.Focus();
                        return;
                        
                    }
                    query = "Insert into shopmaster (shopname,Address,GsttinNo,EntryDate,CompanyID) values ('" + txtShopName.Text.Trim().ToString() +"','" + txtAddress.Text.Trim().ToString() +"','"+ txtGsttinNo .Text+ "','"+DateTime.Now+"'," +MyModule.CompanyId+ ")";
                    RasClass.addrecord(query);
                    txtShopName.Clear();
                    txtGsttinNo.Clear();
                    txtAddress.Clear();
                    MessageBox.Show("Successfully Save Your Data..!!",Text,MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    object ShNameCnt = RasClass.GetValue("Select Count(ShopName) From ShopMaster WHERE ShopName = '" + txtShopName.Text.Trim().ToString() + "' Group By ShopName");
                    if (Convert.ToInt32(ShNameCnt) > 1)
                    {
                        MessageBox.Show("Shop Name Already Exists.", "Error");
                        txtShopName.Focus();
                        return;
                    }
                    query = "UPDATE shopmaster set shopname= '"+txtShopName.Text+ "',Address='"+txtAddress.Text+"',GsttinNo='"+txtGsttinNo.Text+ "',UpdateDate='"+DateTime.Now+"',CompanyId = "+ MyModule.CompanyId +" where id = " + txtid.Text +"";
                    RasClass.addrecord(query);
                    txtShopName.Clear();
                    txtGsttinNo.Clear();
                    txtAddress.Clear();
                    MessageBox.Show("Successfully Save Your Data..!!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            FillData();
            BtnAddNew_Click(null, null);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            IsEdit = true;
            txtid.Focus();
            BtnSave.Enabled = true;
        }
        public void FillData()
        {
            gridControl1.DataSource = RasClass.FillDataTable("Select * From ShopMaster where inactive = 0 and companyId = "+MyModule.CompanyId+" order by id desc");
            gridView1.Columns[0].Visible = false;
            gridView1.Columns[4].Visible = false;
            gridView1.Columns[5].Visible = false;
            gridView1.Columns[6].Visible = false;
            gridView1.Columns[7].Visible = false;
          
        }
      
        private void FrmShopMaster_Load(object sender, EventArgs e)
        {
            FillData();
            BtnAddNew_Click(null, null);
        }


        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult Msg = MessageBox.Show("Are You Sure Delete..", "Information", MessageBoxButtons.YesNo);
            if (Msg == DialogResult.Yes)
            {
                query = "UPDATE ShopMaster SET inActive = 1 where id = " + txtid.Text + "";
                RasClass.addrecord(query);
                MessageBox.Show("Deleted Your Shop..!!",Text,MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtShopName.Clear();
                txtGsttinNo.Clear();
                txtAddress.Clear();
                FrmShopMaster_Load(null, null);
            }
        }

        private void dgDetail_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //int index;
            //index = e.RowIndex;
            //txtid.Text = dgDetail.Rows[e.RowIndex].Cells[0].Value.ToString();
            //txtShopName.Text = dgDetail.Rows[e.RowIndex].Cells[1].Value.ToString();
            //txtAddress.Text = dgDetail.Rows[e.RowIndex].Cells[2].Value.ToString();
            //txtGsttinNo.Text = dgDetail.Rows[e.RowIndex].Cells[3].Value.ToString();
            //ChkInActive.Checked =Convert.ToBoolean(dgDetail.Rows[e.RowIndex].Cells[3].Value.ToString());
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtShopName.Text = string.Empty;
            txtid.Text = string.Empty;
            txtGsttinNo.Text = string.Empty;
            txtAddress.Text = string.Empty;
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtid.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0].FieldName.ToString()).ToString();
            txtShopName.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1].FieldName.ToString()).ToString();
            txtAddress.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2].FieldName.ToString()).ToString();
            txtGsttinNo.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[3].FieldName.ToString()).ToString();
            
        }
    }
}
