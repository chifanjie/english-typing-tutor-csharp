using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace san_ji_xiang_mu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("用户名或密码不能为空");
                return;
            }
            //读取记事本中的账号和密码
            StreamReader sr = new StreamReader(System.Windows.Forms.Application.StartupPath + @"\data\UserName.txt");
            string[] UserName = sr.ReadToEnd().Split('\n');
            sr.Close();
            sr = new StreamReader(System.Windows.Forms.Application.StartupPath + @"\data\PassWord.txt");
            string[] PassWord = sr.ReadToEnd().Split('\n');
            sr.Close();
            for (int i = 0; i < UserName.Length; i++)
            {
                if (UserName[i] == textBox1.Text && PassWord[i] == textBox2.Text)
                {
                    Form3 F3 = new Form3();
                    this.Hide();
                    F3.Show();
                    F3.Focus();
                    return;
                }
            }
            MessageBox.Show("用户名或密码错误");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            this.Hide();
            f11.Show();
        }

        private void 打字教程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            this.Hide();
            f9.Show();
        }

        private void 关于我们ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            this.Hide();
            f12.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';//显示textBox2原本输入的值
            }
            else
            {
                textBox2.PasswordChar = '*';//将文本显示为*
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Class1.user = textBox1.Text;
        }
    }
}
