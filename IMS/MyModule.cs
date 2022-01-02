using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    public static class MyModule
    {

        public static string ServerName;
        public static string Database;
        public static string UserId;
        public static string Password;
        public static string ConnString = string.Empty;
        public static int FindId = 0;
        public static int CompanyId;

        public static void ReadFile()
        {
            string FileName = "Connection.ini";
            if (System.IO.File.Exists(FileName) == true)
            {
                System.IO.StreamReader objReader = new System.IO.StreamReader(FileName);
                do
                {
                    ServerName = objReader.ReadLine();
                    Database = objReader.ReadLine();
                    UserId = objReader.ReadLine();
                    Password = objReader.ReadLine();

                } while (objReader.Peek() != -1);
                objReader.Close();

                System.Data.OleDb.OleDbConnectionStringBuilder objConnBuilder = new System.Data.OleDb.OleDbConnectionStringBuilder();
                objConnBuilder.Provider = ServerName;
                objConnBuilder.DataSource = Database;

                ConnString = objConnBuilder.ConnectionString + ";Jet OLEDB:Database Password = " + Password + "; ";


            }
            else
            {
                System.IO.File.Create(FileName).Close();
                System.Windows.Forms.MessageBox.Show("Connection File Not Found."); 
            }
        }
    }
}
