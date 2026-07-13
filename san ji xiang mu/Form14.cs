using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace san_ji_xiang_mu
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open File";
            ofd.Filter = "txt文件|*.txt|所有文件|*.*";
            double[] temp = new double[10000000];
            int Len = 0;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                StreamReader srs = new StreamReader(fs);

                string strLine;

                while (srs.EndOfStream == false)
                {
                    strLine = srs.ReadLine();
                    textBox2.Text = textBox2.Text + strLine + " " + "\r\n";
                    temp[Len] = Convert.ToDouble(strLine);
                    Len++;
                }
                srs.Dispose();
                fs.Dispose();
                for (int pointIndex = 0; pointIndex < Len; pointIndex++)
                {
                    chart1.Series["Series1"].Points.AddY(temp[pointIndex]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }

        private void Form14_Load(object sender, EventArgs e)
        {

        }
    }
}
