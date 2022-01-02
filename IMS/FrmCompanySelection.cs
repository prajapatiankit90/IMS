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
    public partial class FrmCompanySelection : Form
    {
        ProjSet RasClass = new IMS.ProjSet();
        public FrmCompanySelection()
        {
            InitializeComponent();
        }

        private void FrmCompanySelection_Load(object sender, EventArgs e)
        {
            
            gridControl1.DataSource = RasClass.FillDataTable("Select *  from CompanyMaster");
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                FrmMain main = new FrmMain();
                MyModule.CompanyId = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0].FieldName.ToString()).ToString());
                //main.lblCompanyName.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1].FieldName.ToString()).ToString();
                ((FrmMain)MdiParent).lblCompanyName.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1].FieldName.ToString()).ToString();
                this.Close();
            }
            catch
            { }
            

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                FrmMain main = new FrmMain();
                MyModule.CompanyId = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0].FieldName.ToString()).ToString());
                //main.lblCompanyName.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1].FieldName.ToString()).ToString();
                ((FrmMain)MdiParent).lblCompanyName.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1].FieldName.ToString()).ToString();
                this.Close();
               
            }
            catch
            { }
        }
    }
}
