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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.IndianRed;
            pictureBox2.BackColor = Color.LightGreen;
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Close();
            f3.Show();
            f.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form15_Load(object sender, EventArgs e)
        {
            //读取文件夹中的文章
            this.pictureBox1.Hide();
            this.pictureBox2.Hide();
            StreamReader sr = new StreamReader(System.Windows.Forms.Application.StartupPath + @"\duanwen\wen2.txt");
            string[] wen = sr.ReadToEnd().Split('\n');
            richTextBox1.Text=wen[0];
        }
        //将文件夹中的文本储存到f中
        FileStream f = new FileStream(DemoResources.PathFor(@"duanwen\wen.txt"), FileMode.OpenOrCreate, FileAccess.ReadWrite);

        private void richTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //选择对应长度的文本进行对比
            int len = richTextBox2.Text.Length;
            f.Position = len;
            if ((int)e.KeyChar == f.ReadByte())
            {
                pictureBox1.Hide();
                pictureBox2.Show();
            }
            else
            {
                pictureBox1.Show();
                pictureBox2.Hide();
            }

            //错误的位置
            if ((int)e.KeyChar == 113)
            {
                pictureBox2.Location = Q.Location;
            }
            if ((int)e.KeyChar == 119)
            {
                pictureBox2.Location = W.Location;
            }
            if ((int)e.KeyChar == 101)
            {
                pictureBox2.Location = E.Location;
            }
            if ((int)e.KeyChar == 114)
            {
                pictureBox2.Location = R.Location;
            }
            if ((int)e.KeyChar == 116)
            {
                pictureBox2.Location = T.Location;
            }
            if ((int)e.KeyChar == 121)
            {
                pictureBox2.Location = Y.Location;
            }
            if ((int)e.KeyChar == 117)
            {
                pictureBox2.Location = U.Location;
            }
            if ((int)e.KeyChar == 105)
            {
                pictureBox2.Location = I.Location;
            }
            if ((int)e.KeyChar == 111)
            {
                pictureBox2.Location = O.Location;
            }
            if ((int)e.KeyChar == 112)
            {
                pictureBox2.Location = P.Location;
            }
            if ((int)e.KeyChar == 97)
            {
                pictureBox2.Location = A.Location;
            }
            if ((int)e.KeyChar == 115)
            {
                pictureBox2.Location = S.Location;
            }
            if ((int)e.KeyChar == 100)
            {
                pictureBox2.Location = D.Location;
            }
            if ((int)e.KeyChar == 102)
            {
                pictureBox2.Location = F.Location;
            }
            if ((int)e.KeyChar == 103)
            {
                pictureBox2.Location = G.Location;
            }
            if ((int)e.KeyChar == 104)
            {
                pictureBox2.Location = H.Location;
            }
            if ((int)e.KeyChar == 106)
            {
                pictureBox2.Location = J.Location;
            }
            if ((int)e.KeyChar == 107)
            {
                pictureBox2.Location = K.Location;
            }
            if ((int)e.KeyChar == 108)
            {
                pictureBox2.Location = L.Location;
            }
            if ((int)e.KeyChar == 122)
            {
                pictureBox2.Location = Z.Location;
            }
            if ((int)e.KeyChar == 120)
            {
                pictureBox2.Location = X.Location;
            }
            if ((int)e.KeyChar == 99)
            {
                pictureBox2.Location = C.Location;
            }
            if ((int)e.KeyChar == 118)
            {
                pictureBox2.Location = V.Location;
            }
            if ((int)e.KeyChar == 98)
            {
                pictureBox2.Location = B.Location;
            }
            if ((int)e.KeyChar == 110)
            {
                pictureBox2.Location = N.Location;
            }
            if ((int)e.KeyChar == 109)
            {
                pictureBox2.Location = M.Location;
            }

            //正确的位置
            if ((int)e.KeyChar == 113)
            {
                pictureBox1.Location = Q.Location;
            }
            if ((int)e.KeyChar == 119)
            {
                pictureBox1.Location = W.Location;
            }
            if ((int)e.KeyChar == 101)
            {
                pictureBox1.Location = E.Location;
            }
            if ((int)e.KeyChar == 114)
            {
                pictureBox1.Location = R.Location;
            }
            if ((int)e.KeyChar == 116)
            {
                pictureBox1.Location = T.Location;
            }
            if ((int)e.KeyChar == 121)
            {
                pictureBox1.Location = Y.Location;
            }
            if ((int)e.KeyChar == 117)
            {
                pictureBox1.Location = U.Location;
            }
            if ((int)e.KeyChar == 105)
            {
                pictureBox1.Location = I.Location;
            }
            if ((int)e.KeyChar == 111)
            {
                pictureBox1.Location = O.Location;
            }
            if ((int)e.KeyChar == 112)
            {
                pictureBox1.Location = P.Location;
            }
            if ((int)e.KeyChar == 97)
            {
                pictureBox1.Location = A.Location;
            }
            if ((int)e.KeyChar == 115)
            {
                pictureBox1.Location = S.Location;
            }
            if ((int)e.KeyChar == 100)
            {
                pictureBox1.Location = D.Location;
            }
            if ((int)e.KeyChar == 102)
            {
                pictureBox1.Location = F.Location;
            }
            if ((int)e.KeyChar == 103)
            {
                pictureBox1.Location = G.Location;
            }
            if ((int)e.KeyChar == 104)
            {
                pictureBox1.Location = H.Location;
            }
            if ((int)e.KeyChar == 106)
            {
                pictureBox1.Location = J.Location;
            }
            if ((int)e.KeyChar == 107)
            {
                pictureBox1.Location = K.Location;
            }
            if ((int)e.KeyChar == 108)
            {
                pictureBox1.Location = L.Location;
            }
            if ((int)e.KeyChar == 122)
            {
                pictureBox1.Location = Z.Location;
            }
            if ((int)e.KeyChar == 120)
            {
                pictureBox1.Location = X.Location;
            }
            if ((int)e.KeyChar == 99)
            {
                pictureBox1.Location = C.Location;
            }
            if ((int)e.KeyChar == 118)
            {
                pictureBox1.Location = V.Location;
            }
            if ((int)e.KeyChar == 98)
            {
                pictureBox1.Location = B.Location;
            }
            if ((int)e.KeyChar == 110)
            {
                pictureBox1.Location = N.Location;
            }
            if ((int)e.KeyChar == 109)
            {
                pictureBox1.Location = M.Location;
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Select(richTextBox2.TextLength, 1);//选择输入框输入字符长度后的一个字符
            richTextBox1.SelectionColor = Color.Blue;//将颜色改为蓝色
            richTextBox1.Select(0, 0);//不选择任何字符
            if (richTextBox2.TextLength < richTextBox1.TextLength)
            {
                for (int i = 0; i < richTextBox2.TextLength; i++)//for循环用于逐个字符进行比较
                {
                    if (richTextBox1.Text[i] != richTextBox2.Text[i])//当两个同位置字符不相同的时候
                    {
                        richTextBox1.Select(i, 1);//选中那个字符
                        richTextBox1.SelectionColor = Color.Red;//将他改为红色
                        richTextBox1.Select(i + 1, 0);//光标放在那个字符后并且不选中任何字符

                    }
                    else
                    {
                        richTextBox1.Select(i, 1);//否则两个字符相等，则正确
                        richTextBox1.SelectionColor = Color.Blue;//将他改为蓝色
                        richTextBox1.Select(i + 1, 0);//光标放在那个字符后并且不选中任何字符

                    }

                }
            }
            else
            {
                //游戏结束并且结束f进程
                MessageBox.Show("您已经完成打字试验，请选择更困难关卡练习！");
                richTextBox2.Enabled = false;
                f.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form15 f15 = new Form15();
            //this.Close();
            //f15.Show();
        }
    }
}
