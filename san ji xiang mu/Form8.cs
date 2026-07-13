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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            //添加游戏难度等级
            timer1.Enabled = false;
            cbonan.Items.Add("简单");
            cbonan.Items.Add("中等");
            cbonan.Items.Add("困难");
            
        }

        private void cbonan_SelectedIndexChanged(object sender, EventArgs e)
        {
            //当选择游戏等级时跳出相应文章
            rtb5.Enabled = true;
            rtb6.Enabled = true;
            rtb7.Enabled = true;
            rtb8.Enabled = true;
            rtb1.Text = "";
            rtb2.Text = "";
            rtb3.Text = "";
            rtb4.Text = "";
            rtb5.Text = "";
            rtb6.Text = "";
            rtb7.Text = "";
            rtb8.Text = "";
            cbowen.Items.Clear();
            if (cbonan.Text == "简单")
            {
                cbowen.Items.Add("文章1.1");
                cbowen.Items.Add("文章1.2");
                cbowen.Items.Add("文章1.3");

            }
            if (cbonan.Text == "中等")
            {
                cbowen.Items.Add("文章2.1");
                cbowen.Items.Add("文章2.2");
                cbowen.Items.Add("文章2.3");
            }
            if (cbonan.Text == "困难")
            {
                cbowen.Items.Add("文章3.1");
                cbowen.Items.Add("文章3.2");
                cbowen.Items.Add("文章3.3");
            }
            timer1.Enabled = true;
        }

        private void cbowen_SelectedIndexChanged(object sender, EventArgs e)
        {
            //选择文章后读取相应文本
            if (cbowen.Text == "文章1.1")
            {
                StreamReader sr = new StreamReader(System.Windows.Forms.Application.StartupPath + @"\laoshouwenzhang\wen1.txt");
                string[] wen1 = sr.ReadToEnd().Split('\n');
                rtb1.Text = wen1[0];
                rtb2.Text = wen1[1];
                rtb3.Text = wen1[2];
                rtb4.Text = wen1[3];
            }
            if (cbowen.Text == "文章1.2")
            {
                StreamReader sr = new StreamReader(System.Windows.Forms.Application.StartupPath + @"\laoshouwenzhang\wen4.txt");
                string[] wen4 = sr.ReadToEnd().Split('\n');
                rtb1.Text = wen4[0];
                rtb2.Text = wen4[1];
                rtb3.Text = wen4[2];
                rtb4.Text = wen4[3];

            }
            if (cbowen.Text == "文章1.3")
            {
                StreamReader sr = new StreamReader(System.Windows.Forms.Application.StartupPath + @"\laoshouwenzhang\wen7.txt");
                string[] wen7 = sr.ReadToEnd().Split('\n');
                rtb1.Text = wen7[0];
                rtb2.Text = wen7[1];
                rtb3.Text = wen7[2];
                rtb4.Text = wen7[3];
            }
            if (cbowen.Text == "文章2.1")
            {
                StreamReader sr = new StreamReader(System.Windows.Forms.Application.StartupPath + @"\laoshouwenzhang\wen2.txt");
                string[] wen2 = sr.ReadToEnd().Split('\n');
                rtb1.Text = wen2[0];
                rtb2.Text = wen2[1];
                rtb3.Text = wen2[2];
                rtb4.Text = wen2[3];
            }
            if (cbowen.Text == "文章2.2")
            {
                StreamReader sr = new StreamReader(System.Windows.Forms.Application.StartupPath + @"\laoshouwenzhang\wen5.txt");
                string[] wen5 = sr.ReadToEnd().Split('\n');
                rtb1.Text = wen5[0];
                rtb2.Text = wen5[1];
                rtb3.Text = wen5[2];
                rtb4.Text = wen5[3];
            }
            if (cbowen.Text == "文章2.3")
            {
                StreamReader sr = new StreamReader(System.Windows.Forms.Application.StartupPath + @"\laoshouwenzhang\wen8.txt");
                string[] wen8 = sr.ReadToEnd().Split('\n');
                rtb1.Text = wen8[0];
                rtb2.Text = wen8[1];
                rtb3.Text = wen8[2];
                rtb4.Text = wen8[3];
            }
            if (cbowen.Text == "文章3.1")
            {
                StreamReader sr = new StreamReader(System.Windows.Forms.Application.StartupPath + @"\laoshouwenzhang\wen3.txt");
                string[] wen3 = sr.ReadToEnd().Split('\n');
                rtb1.Text = wen3[0];
                rtb2.Text = wen3[1];
                rtb3.Text = wen3[2];
                rtb4.Text = wen3[3];
            }
            if (cbowen.Text == "文章3.2")
            {
                StreamReader sr = new StreamReader(System.Windows.Forms.Application.StartupPath + @"\laoshouwenzhang\wen6.txt");
                string[] wen6 = sr.ReadToEnd().Split('\n');
                rtb1.Text = wen6[0];
                rtb2.Text = wen6[1];
                rtb3.Text = wen6[2];
                rtb4.Text = wen6[3];
            }
            if (cbowen.Text == "文章3.3")
            {
                StreamReader sr = new StreamReader(System.Windows.Forms.Application.StartupPath + @"\laoshouwenzhang\wen9.txt");
                string[] wen9 = sr.ReadToEnd().Split('\n');
                rtb1.Text = wen9[0];
                rtb2.Text = wen9[1];
                rtb3.Text = wen9[2];
                rtb4.Text = wen9[3];
            }
        }
       
        private void rtb5_TextChanged(object sender, EventArgs e)
        {
            rtb1.Select(rtb5.TextLength, 1);//选择输入框输入字符长度后的一个字符
            rtb1.SelectionColor = Color.Blue;//将颜色改为蓝色
            rtb1.Select(0, 0);//不选择任何字符
            if (rtb5.TextLength < rtb1.TextLength)
            {
                for (int i = 0; i < rtb5.TextLength; i++)//for循环用于逐个字符进行比较
                {
                    if (rtb1.Text[i] != rtb5.Text[i])//当两个同位置字符不相同的时候
                    {
                        rtb1.Select(i, 1);//选中那个字符
                        rtb1.SelectionColor = Color.Red;//将他改为红色
                        rtb1.Select(i + 1, 0);//光标放在那个字符后并且不选中任何字符
                        
                    }
                    else
                    {
                        rtb1.Select(i, 1);//否则两个字符相等，则正确
                        rtb1.SelectionColor = Color.Blue;//将他改为蓝色
                        rtb1.Select(i + 1, 0);//光标放在那个字符后并且不选中任何字符
                       
                    }

                }
            }
            else
            {
                rtb6.Focus();
            }
            
        }

        private void rtb6_TextChanged(object sender, EventArgs e)
        {
            rtb2.Select(rtb6.TextLength, 1);//选择输入框输入字符长度后的一个字符
            rtb2.SelectionColor = Color.Blue;//将颜色改为黑色
            rtb2.Select(0, 0);//不选择任何字符
            if (rtb6.TextLength < rtb2.TextLength)
            {
                for (int i = 0; i < rtb6.TextLength; i++)//for循环用于逐个字符进行比较
                {
                    if (rtb2.Text[i] != rtb6.Text[i])//当两个同位置字符不相同的时候
                    {
                        rtb2.Select(i, 1);//选中那个字符
                        rtb2.SelectionColor = Color.Red;//将他改为红色
                        rtb2.Select(i + 1, 0);//光标放在那个字符后并且不选中任何字符
                       
                    }
                    else
                    {
                        rtb2.Select(i, 1);//否则两个字符相等，则正确
                        rtb2.SelectionColor = Color.Blue;//将他改为蓝色
                        rtb2.Select(i + 1, 0);//光标放在那个字符后并且不选中任何字符
                        
                    }

                }
            }
            else
            {
                rtb7.Focus();
            }
            
        }

        private void rtb7_TextChanged(object sender, EventArgs e)
        {
            rtb3.Select(rtb7.TextLength, 1);//选择输入框输入字符长度后的一个字符
            rtb3.SelectionColor = Color.Blue;//将颜色改为黑色
            rtb3.Select(0, 0);//不选择任何字符
            if (rtb7.TextLength < rtb3.TextLength)
            {
                for (int i = 0; i < rtb7.TextLength; i++)//for循环用于逐个字符进行比较
                {
                    if (rtb3.Text[i] != rtb7.Text[i])//当两个同位置字符不相同的时候
                    {
                        rtb3.Select(i, 1);//选中那个字符
                        rtb3.SelectionColor = Color.Red;//将他改为红色
                        rtb3.Select(i + 1, 0);//光标放在那个字符后并且不选中任何字符
                       
                    }
                    else
                    {
                        rtb3.Select(i, 1);//否则两个字符相等，则正确
                        rtb3.SelectionColor = Color.Blue;//将他改为蓝色
                        rtb3.Select(i + 1, 0);//光标放在那个字符后并且不选中任何字符
                        
                    }

                }
            }
            else
            {
                rtb8.Focus();
            }
            
        }

        private void rtb8_TextChanged(object sender, EventArgs e)
        {
            
            rtb4.Select(rtb8.TextLength, 1);//选择输入框输入字符长度后的一个字符
            rtb4.SelectionColor = Color.Blue;//将颜色改为黑色
            rtb4.Select(0, 0);//不选择任何字符
            if (rtb8.TextLength < rtb4.TextLength)
            {
                for (int i = 0; i < rtb8.TextLength; i++)//for循环用于逐个字符进行比较
                {
                    if (rtb4.Text[i] != rtb8.Text[i])//当两个同位置字符不相同的时候
                    {
                        rtb4.Select(i, 1);//选中那个字符
                        rtb4.SelectionColor = Color.Red;//将他改为红色
                        rtb4.Select(i + 1, 0);//光标放在那个字符后并且不选中任何字符
                       
                    }
                    else
                    {
                        rtb4.Select(i, 1);//否则两个字符相等，则正确
                        rtb4.SelectionColor = Color.Blue;//将他改为蓝色
                        rtb4.Select(i + 1, 0);//光标放在那个字符后并且不选中任何字符
                        
                    }

                }
            }
            else
            {
                MessageBox.Show("您已经完成本文章练习");
                rtb5.Enabled = false;
                rtb6.Enabled = false;
                rtb7.Enabled = false;
                rtb8.Enabled = false;
                
            }
        }
        public int time = 0;
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            time++;//时间增加
            int q, w, l;//定义q和w来存放分和秒
            q = time / 60;//分钟等于总时间除60
            w = time % 60;//秒等于总时间除60的余数
            l = time / 3600;//计算小时数
            string str = l.ToString() + ":" + q.ToString() + ":" + w.ToString();//定义字符串并连接字符串
            label4.Text = str;//时间文本框显示连接好的字符
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            this.Close();
            f6.Show();
        }
    }
}
