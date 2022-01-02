using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;



namespace IMS
{
    class ProjSet
    {
        public void addrecord(string OlDb)
        {
            //OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Inventory Management Software\IMS\IMS\bin\Debug\IMS.accdb");
            OleDbConnection conn = new OleDbConnection(MyModule.ConnString);
            OleDbCommand cmd = new OleDbCommand(OlDb, conn);
            if (cmd.Connection.State == ConnectionState.Closed)
                conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public object GetValue(string SqlString)
        {
            object obj = new object();
            OleDbConnection Conn = new OleDbConnection(MyModule.ConnString);
            OleDbCommand Mycmd = new OleDbCommand(SqlString, Conn);
            Conn.Open();
            obj = Mycmd.ExecuteScalar();
            Conn.Close();
            Conn = null;
            Mycmd = null;
            return obj;
        }

        public DataTable FillDataTable(string SqlString)
        {

            OleDbConnection sqlconn = new OleDbConnection(MyModule.ConnString);
            OleDbDataAdapter da = new OleDbDataAdapter(SqlString, sqlconn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void FillText(string SqlString, TextBox txt)
        {
            AutoCompleteStringCollection autostr = new AutoCompleteStringCollection();
            using (OleDbConnection Conn = new OleDbConnection(MyModule.ConnString))
            {
                OleDbCommand cmd = new OleDbCommand(SqlString, Conn);
                Conn.Open();
                OleDbDataReader Reader = null;
                Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    autostr.Add(Reader[0].ToString().Trim());
                }
                Conn.Close();
                txt.AutoCompleteCustomSource = autostr;
            }

        }
        public void addnewrecord(string SqlString, List<System.Data.OleDb.OleDbParameter> cpara)
        {
            if (SqlString != string.Empty)
            {
                using (OleDbConnection conn = new OleDbConnection(MyModule.ConnString))
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    try
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandTimeout = 0;
                        cmd.CommandText = SqlString;
                        cmd.Parameters.AddRange(cpara.ToArray());
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
            }
        }
        public void SetDbLogon(ReportDocument RepDoc)
        {

            //ReportDocument cryRpt = new ReportDocument();
            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;

            //cryRpt.Load("PUT CRYSTAL REPORT PATH HERE\CrystalReport1.rpt");

            //    crConnectionInfo.ServerName = "Microsoft.ACE.OLEDB.12.0";
            crConnectionInfo.ServerName = Application.StartupPath + @"\IMS.accdb";
            //crConnectionInfo.DatabaseName = Application.StartupPath + @"\IMS.accdb";
            //crConnectionInfo.UserID = "Admin";
            //crConnectionInfo.Password = string.Empty;

            CrTables = RepDoc.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                crtableLogoninfo.ReportName = RepDoc.Name;
                crtableLogoninfo.TableName = CrTable.Name;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }
            RptReport FrmRpt = new RptReport();
            FrmRpt.crystalReportViewer1.ReportSource = RepDoc;
            FrmRpt.crystalReportViewer1.Zoom(1);
            FrmRpt.crystalReportViewer1.Refresh();
            FrmRpt.Show();


            //TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            //TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            //ConnectionInfo crConnectionInfo = new ConnectionInfo();
            //Tables CrTables;
            ////Table CrTable;
            //CrTables = RepDoc.Database.Tables;
            //foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            //{
            //    crtableLogoninfo = CrTable.LogOnInfo;
            //    crConnectionInfo = crtableLogoninfo.ConnectionInfo;
            //    crConnectionInfo.ServerName = Application.StartupPath + @"\IMS.accdb";
            //    crConnectionInfo.DatabaseName = Application.StartupPath + @"\IMS.accdb";
            //    crConnectionInfo.UserID = "Admin";
            //    crConnectionInfo.Password = string.Empty;
            //    crtableLogoninfo.ConnectionInfo = crConnectionInfo;
            //    CrTable.ApplyLogOnInfo(crtableLogoninfo);
            //}
            //RptReport FrmRpt = new RptReport();
            //FrmRpt.crystalReportViewer1.ReportSource = RepDoc;
            //FrmRpt.crystalReportViewer1.Zoom(1);
            //FrmRpt.crystalReportViewer1.Refresh();
            //FrmRpt.Show();


        }
    }
}
