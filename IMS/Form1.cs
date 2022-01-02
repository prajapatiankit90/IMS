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
    public partial class FrmLogin : Form
    {
        string str;
        public FrmLogin()
        {
            InitializeComponent();
            MyModule.ReadFile();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            
            str = "Select * from Login where UserName='" + txtUserName.Text + "' and pwd='" + txtPassword.Text + "'";
            OleDbConnection sqlconn = new OleDbConnection(MyModule.ConnString);
            OleDbDataAdapter da = new OleDbDataAdapter(str, sqlconn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Login");
            if (txtUserName.Text == string.Empty)
            {
                MessageBox.Show("Invalid User..");
                txtUserName.Focus();
                return;
            }

            if (txtPassword.Text.Length<=5)
            {
                MessageBox.Show("Password not more then 6 Character");
                txtPassword.Focus();
                return;
            }

            if (ds.Tables[0].Rows.Count > 0)
            {   
                FrmMain main = new FrmMain();
                main.lblCompanyName.Text = txtUserName.Text;
                SplashScreen1 spl = new SplashScreen1();
                spl.Show();


               // main.Show();
              Hide();
            }
            else
            {
                MessageBox.Show("Invalid Password..", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Text = string.Empty;
                txtPassword.Text = string.Empty;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
