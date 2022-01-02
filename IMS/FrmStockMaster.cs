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
    public partial class FrmStockMaster : Form
    {
        string query= string.Empty;
        DataTable dt = new DataTable();
        public FrmStockMaster()
        {
            InitializeComponent();
        }

        private void FrmStockMaster_Load(object sender, EventArgs e)
        {
            rdoShopwise.Checked = true;
            BtnSearch_Click(null, null);
            FillCombo();    
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            ProjSet RasClass = new ProjSet();
            //query = "SELECT ItemMaster.ItemName, ShopMaster.ShopName, Sum(StockMaster.Qty) AS [Balance Qty] FROM(StockMaster INNER JOIN ItemMaster ON StockMaster.Itemid = ItemMaster.ID) INNER JOIN ShopMaster ON StockMaster.Shopid = ShopMaster.ID where StockMaster.EntryDate >= '#" + dtpFromDate.Value.ToString("yyyy/MM/dd")+ "#' and StockMaster.EntryDate <= '#" + dtpToDate.Value.ToString("yyyy/MM/dd") + "#' GROUP BY ItemMaster.ItemName, ShopMaster.ShopName HAVING(((Sum(StockMaster.Qty)) <> 0))";
            if (rdoShopwise.Checked.Equals(true))
            {
                //query = "SELECT ItemMaster.ItemName, ShopMaster.ShopName, Sum(StockMaster.Kg) AS [Balance Kg] ,Sum(StockMaster.Qty) AS [Balance Qty] FROM(StockMaster INNER JOIN ItemMaster ON StockMaster.Itemid = ItemMaster.ID) INNER JOIN ShopMaster ON StockMaster.Shopid = ShopMaster.ID WHERE(((StockMaster.EntryDate) >= #" + dtpFromDate.Value.ToString("yyyy/MM/dd") + "# And (StockMaster.EntryDate) <= #" + dtpToDate.Value.ToString("yyyy/MM/dd") + "#) And StockMaster.CompanyId = " + MyModule.CompanyId +") GROUP BY ItemMaster.ItemName, ShopMaster.ShopName HAVING(((Sum(StockMaster.Qty)) <> 0) and (Sum(StockMaster.Kg)) <> 0)";
                query = "SELECT ItemMaster.ItemName, ShopMaster.ShopName, Sum(StockMaster.Kg) AS [Balance Kg] ,Sum(StockMaster.Qty) AS [Balance Qty] FROM(StockMaster INNER JOIN ItemMaster ON StockMaster.Itemid = ItemMaster.ID) INNER JOIN ShopMaster ON StockMaster.Shopid = ShopMaster.ID WHERE(((StockMaster.EntryDate) >= #" + dtpFromDate.Value.ToString("yyyy/MM/dd") + "# And (StockMaster.EntryDate) <= #" + dtpToDate.Value.ToString("yyyy/MM/dd") + "#) And StockMaster.CompanyId = " + MyModule.CompanyId + ") GROUP BY ItemMaster.ItemName, ShopMaster.ShopName";
            }
            else
            {
                query = "SELECT itemMaster.ItemName, Sum(StockMaster.Kg) AS [Balance Kg] ,Sum(StockMaster.Qty) AS [Balance Qty] FROM StockMaster INNER JOIN itemMaster ON StockMaster.Itemid = itemMaster.ID WHERE(((StockMaster.EntryDate) >=#" + dtpFromDate.Value.ToString("yyyy/MM/dd") + "# And (StockMaster.EntryDate)<=#" + dtpToDate.Value.ToString("yyyy/MM/dd") + "#) And StockMaster.CompanyId = "+ MyModule.CompanyId +") GROUP BY itemMaster.ItemName;";
            }
            dt = RasClass.FillDataTable(query);
            if (rdoShopwise.Checked.Equals(true))
            {
                dt.DefaultView.RowFilter = "ShopName Like '%" + cmdShopName.Text + "%'";
            }            
           // dgDetails.DataSource = dt;
            gridControl1.DataSource = dt;
            RasClass = null;
        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {
             dt.DefaultView.RowFilter = "ItemName Like '%" + txtItemName.Text + "%'";
        }
        public void FillCombo()
        {
            ProjSet RassClass = new ProjSet();
            DataTable Dt = new DataTable();
            dt = RassClass.FillDataTable("Select ShopName From ShopMaster Where CompanyId = " + MyModule.CompanyId + "  order by ShopName Asc");
            cmdShopName.Items.Clear();
            cmdShopName.Items.Add("All");
            foreach (DataRow Dr in dt.Rows)
            {
                cmdShopName.Items.Add(Dr[0].ToString());
            }
        }
        private void cmdShopName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmdShopName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmdShopName.Text.Equals("All"))
            {
                dt.DefaultView.RowFilter = string.Empty;
            }
            else
            { dt.DefaultView.RowFilter = "ShopName like '%" + cmdShopName.Text + "%'"; }   
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            xtraSaveFileDialog1.Title = "Export to Excel";
            if (xtraSaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                gridControl1.ExportToXlsx(xtraSaveFileDialog1.FileName + ".xlsx");
      
            }
        }
    }
}
