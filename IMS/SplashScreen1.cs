using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraEditors;

namespace IMS
{
    public partial class SplashScreen1 : DevExpress.XtraEditors.XtraForm
    {
        int cnt = 0;

        public SplashScreen1()
        {
            InitializeComponent();
        }

        #region Overrides

        //public override void ProcessCommand(Enum cmd, object arg)
        //{
        //    base.ProcessCommand(cmd, arg);
        //}

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                cnt += 1;
                if (cnt.Equals(1))
                {
                    timer1.Stop();
                    FrmMain objMain = new FrmMain();
                    objMain.Show();
                    Hide();
                }
            }
            catch (Exception ex)
            { XtraMessageBox.Show(ex.Message.ToString()); }
        }
    }
}