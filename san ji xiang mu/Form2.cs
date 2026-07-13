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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //向记事本中注册账号和密码
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("用户名或密码不能为空");
                return;
            }
            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("两次密码输入错误！");
                return;
            }
            //判断验证码是否正确。
            if (textBox4.Text!=code)
            {
                MessageBox.Show("验证码错误");
                code = GenerateCheckCode();
                Bitmap image = CreateCheckCodeImage(code, 130, 60);
                pictureBox1.Image = image;
                textBox4.Text = "";
                return;
            }
            StreamReader sr = new StreamReader(System.Windows.Forms.Application.StartupPath + @"\data\UserName.txt");
            string[] strs = sr.ReadToEnd().Split('\n');
            sr.Close();
            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i] == textBox1.Text)
                {
                    MessageBox.Show("该用户名已存在");
                    textBox1.Text = textBox2.Text = textBox3.Text = "";
                    return;
                }
            }
            File.AppendAllText(System.Windows.Forms.Application.StartupPath + @"\data\UserName.txt", textBox1.Text + '\n');
            File.AppendAllText(System.Windows.Forms.Application.StartupPath + @"\data\PassWord.txt", textBox2.Text + '\n');
            MessageBox.Show("注册成功");
            this.Close();
            Form1 F1 = new Form1();
            F1.Show();
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 F1 = new Form1();
            F1.Show();
        }
        string code;
        private void Form2_Load(object sender, EventArgs e)
        {
            code = GenerateCheckCode();//得到验证码
            Bitmap image = CreateCheckCodeImage(code, 130, 60);//生成验证码图片
            pictureBox1.Image = image;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //通过字符长度来对比安全性
            if (textBox2.Text.Length<=3)
            {
                label5.Text = "密码安全性较弱";
            }
            if (textBox2.Text.Length>3&&textBox2.Text.Length<=6)
            {
                label5.Text = "密码安全性较强";
            }
            if (textBox2.Text.Length>6)
            {
                label5.Text = "密码安全性非常强";
            }
            if (textBox2.Text.Length==0)
            {
                 label5.Text = " ";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text!=textBox2.Text)
            {
                label6.Text = "两次输入密码不一致";
            }
            if (textBox3.Text==textBox2.Text||textBox3.Text=="")
            {
                label6.Text = "";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 得到验证码
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private string GenerateCheckCode()
        {
            Random r = new Random();
            string str = null;
            for (int i = 0; i < 4; i++)
            {
                int rNumber = r.Next(0, 10);
                str += rNumber;
            }
            return str.ToUpper();
        }
        /// <summary>
        /// 生成验证码图片
        /// </summary>
        /// <param name="checkCode"></param>
        /// <param name="context"></param>
        private Bitmap CreateCheckCodeImage(string checkCode, int w = 130, int h = 60)
        {
            Random r = new Random();
            string str = null;
            for (int i = 0; i < 4; i++)
            {
                int rNumber = r.Next(0, 10);
                str += rNumber;
            }
            System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(130, 60);
            Graphics g = Graphics.FromImage(bmp);
            for (int i = 0; i < 4; i++)
            {
                Point p = new Point(i * 25, 0);
                string[] fonts = { "宋体", "黑体", "隶书", "楷体" };
                Color[] colors = { Color.Orange, Color.Red, Color.Green, Color.Blue };
                g.DrawString(str[i].ToString(), new Font(fonts[r.Next(0, 4)], 30, FontStyle.Bold), new SolidBrush(colors[r.Next(0, 4)]), p);

            }

            for (int i = 0; i < 25; i++)
            {
                Point p1 = new Point(r.Next(0, bmp.Width),r.Next(0,bmp.Height));
                Point p2 = new Point(r.Next(0, bmp.Width),r.Next(0,bmp.Height));
                g.DrawLine(new Pen(Brushes.Green), p1, p2);
            }
            for (int i = 0; i < 800; i++)
            {
                Point p = new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height));
                bmp.SetPixel(p.X, p.Y, Color.Black);
            }
           
            Random rand = new Random();
            int z = 15;//干扰线条数
            for (int i = 0; i < z; i++)
            {
                int x1 = rand.Next(bmp.Width);
                int x2 = rand.Next(bmp.Width);
                int y1 = rand.Next(bmp.Height);
                int y2 = rand.Next(bmp.Height);
                g.DrawLine(new Pen(Color.LightGray, 1), x1, y1, x2, y2);//根据坐标画线
            }
          
            bmp = TwistImage(bmp, true, 5, 1);
            g.DrawRectangle(new Pen(Color.Yellow, 0), 0, 0, bmp.Width - 1, bmp.Height - 1);
            return bmp;
        }

        private const double PI = 3.1415926535897932384626433832795;
        private const double PI2 = 6.283185307179586476925286766559;

        /// <summary>
        /// 正弦曲线Wave扭曲图片（Edit By 51aspx.com）
        /// </summary>
        /// <param name="srcBmp">图片路径</param>
        /// <param name="bXDir">如果扭曲则选择为True</param>
        /// <param name="nMultValue">波形的幅度倍数，越大扭曲的程度越高，一般为3</param>
        /// <param name="dPhase">波形的起始相位，取值区间[0-2*PI)</param>
        /// <returns></returns>
        public System.Drawing.Bitmap TwistImage(Bitmap bmp, bool bXDir, double dMultValue, double dPhase)
        {
            System.Drawing.Bitmap destBmp = new Bitmap(bmp.Width, bmp.Height);

            /* // 将位图背景填充为白色
             System.Drawing.Graphics graph = System.Drawing.Graphics.FromImage(destBmp);
             graph.FillRectangle(new SolidBrush(System.Drawing.Color.White), 0, 0, destBmp.Width, destBmp.Height);
             graph.Dispose();*/
            double dBaseAxisLen = bXDir ? (double)destBmp.Height : (double)destBmp.Width;

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    double dx = 0;
                    dx = bXDir ? (PI2 * (double)j) / dBaseAxisLen : (PI2 * (double)i) / dBaseAxisLen;
                    dx += dPhase;
                    double dy = Math.Sin(dx);

                    // 取得当前点
                    // 取得当前点的颜色
                    int nOldX = 0, nOldY = 0;
                    nOldX = bXDir ? i + (int)(dy * dMultValue) : i;
                    nOldY = bXDir ? j : j + (int)(dy * dMultValue);

                    System.Drawing.Color color = bmp.GetPixel(i, j);
                    if (nOldX >= 0 && nOldX < bmp.Width
                     && nOldY >= 0 && nOldY < bmp.Height)
                    {
                        destBmp.SetPixel(nOldX, nOldY, color);
                    }
                }
            }

            return destBmp;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            code = GenerateCheckCode();
            Bitmap image = CreateCheckCodeImage(code, 130, 60);
            pictureBox1.Image = image;

        }

        private void label8_Click(object sender, EventArgs e)
        {
            code = GenerateCheckCode();
            Bitmap image = CreateCheckCodeImage(code, 130, 60);
            pictureBox1.Image = image;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox3.PasswordChar = '\0';
            }
            else
            {
                textBox3.PasswordChar = '*';
            }
        }

    }
}
