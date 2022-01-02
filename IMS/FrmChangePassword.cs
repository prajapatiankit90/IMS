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
    public partial class FrmChangePassword : Form
    {
        string Sqlstring;
        public FrmChangePassword()
        {
            InitializeComponent();
        }

        private void FrmChangePassword_Load(object sender, EventArgs e)
        {
            txtUserName.Text = ((FrmMain)MdiParent).lblCompanyName.Text;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Password..!",Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtpassword.Focus();
                return;
            }
            else if (txtCpassword.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Conform Password..!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCpassword.Focus();
                return;
            }
            else if (txtCpassword.Text != txtpassword.Text)
            {
                MessageBox.Show("Password Not Match..!",Text,MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            else
            {
                ProjSet RasClass = new IMS.ProjSet();
                Sqlstring = "Update login set Pwd= '" + txtCpassword.Text + "' where Name = '" + txtUserName.Text + "'";
                RasClass.addrecord(Sqlstring);
                MessageBox.Show("Successfully Save Your Data..!!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserName.Text = string.Empty;
                txtpassword.Text = string.Empty;
                txtCpassword.Text = string.Empty;
                
            }
        }
    }
}
