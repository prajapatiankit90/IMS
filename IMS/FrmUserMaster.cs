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

namespace IMS
{
    public partial class FrmUserMaster : Form
    {
        string query;
        ProjSet RasClass = new ProjSet();
        Boolean IsEdit = false;

        public FrmUserMaster()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Name..!!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            else if (txtUserName .Text == string.Empty)
            {
                MessageBox.Show("Please Enter UserName..!!",Text,MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtUserName.Focus();
                return;
            }   
            
            else if (txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Password..!!", Text,MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtPassword.Focus();
                return; 
            }
            else if (txtPassword.Text.Length <= 5 || txtPassword.Text.Length >= 8)
            {
                MessageBox.Show("Password character not less then 5 and not more then 8. ", Text,MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtPassword.Focus();
            }
            else
            {
                if (IsEdit == false)
                {
                    query = "insert into Login (Name,UserName,pwd) values ('" + txtName.Text + "','" + txtUserName.Text + "','" + txtPassword.Text + "')";
                }
                else
                {
                    query = "Update login set name= '" + txtName.Text + "', Username= '" + txtUserName.Text + "',pwd='" + txtPassword.Text + "' where id = " + txtid.Text + "";
                }
                RasClass.addrecord(query);
                MessageBox.Show("Sucessfully Save", Text,MessageBoxButtons.OK,MessageBoxIcon.Information);
                FillData();
                clear();
            }
        }
        public void clear()
        {
            txtName.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
        public void FillData()
        {
            ProjSet RasClass = new ProjSet();
            gridControl1.DataSource = RasClass.FillDataTable("Select * From login");
            gridView1.Columns[0].Visible = false;
            gridView1.Columns[3].Visible = false;
            gridView1.Columns[4].Visible = false;
            gridView1.Columns[5].Visible = false;
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            clear();
            txtName.Focus();
            BtnSave.Enabled = true;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            IsEdit = true;
            txtid.Focus();
            BtnSave.Enabled =true;

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
        //    OleDbConnection sqlconn = new OleDbConnection(MyModule.ConnString);
        //    OleDbCommand sqlcmd = new OleDbCommand("Select * from login where name = '"+txtName.Text +"'", sqlconn);
        //    OleDbDataReader DR;
        //    sqlconn.Open();
        //    DR = sqlcmd.ExecuteReader();
        //    if (DR.HasRows)
        //    {
        //        while (DR.Read())
        //        {
        //            txtid.Text = DR["id"].ToString();
        //            txtName.Text = DR["Name"].ToString();
        //            txtUserName.Text = DR["UserName"].ToString();
        //            txtPassword.Text = DR["pwd"].ToString();
        //        }
           // }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult Msg = MessageBox.Show("Are You Sure Delete..", "Information", MessageBoxButtons.YesNo);
            if (Msg == DialogResult.Yes)
            {
                query = "DELETE FROM login WHERE ID = " + txtid.Text + "";
                RasClass.addrecord(query);
                MessageBox.Show("Delete Successfully...", "Information");
                clear();
            }
        }

        private void FrmUserMaster_Load(object sender, EventArgs e)
        {
            FillData();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            txtid.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0].FieldName.ToString()).ToString();
            txtName.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1].FieldName.ToString()).ToString();
            txtUserName.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2].FieldName.ToString()).ToString();
            txtPassword.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[3].FieldName.ToString()).ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            BtnAddNew_Click(null, null);
        }
    }
}
