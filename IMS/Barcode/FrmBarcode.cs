using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging; 
namespace IMS.Barcode
{
    public partial class FrmBarcode : Form
    {
        public FrmBarcode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string barcode = textBox1.Text;

            Bitmap bitm = new Bitmap(barcode.Length * 45, 160);
            using (Graphics graphic = Graphics.FromImage(bitm))
            {


                Font newfont = new Font("IDAutomationHC39M", 20);
                PointF point = new PointF(2f, 2f);
                SolidBrush black = new SolidBrush(Color.Black);
                SolidBrush white = new SolidBrush(Color.White);
                graphic.FillRectangle(white, 0, 0, bitm.Width, bitm.Height);
                graphic.DrawString("*" + barcode + "*", newfont, black, point);
             }

            using (MemoryStream Mmst = new MemoryStream())
            {
                bitm.Save("ms", ImageFormat.Jpeg);
                pictureBox1.Image = bitm;
                pictureBox1.Width = bitm.Width;
                pictureBox1.Height = bitm.Height;
            }  
        }

        private void FrmBarcode_Load(object sender, EventArgs e)
        {
            label1.Font = new Font("IDAutomationHC39M", 12, FontStyle.Regular);  
        }
    }
}
