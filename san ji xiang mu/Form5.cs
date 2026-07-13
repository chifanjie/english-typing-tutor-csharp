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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public int time = 60;
        public double countright, countwrong;
        public double right, wrong;
        public double shu1, shu2;
        private void button1_Click(object sender, EventArgs e)//通过返回，返回选择模式界面
        {
            Form3 f3=new Form3();
            this.Hide();
            f3.Show();
            timer1.Enabled = false;
            
            RtbInput.Enabled = false;
            bt2.Enabled = false;
            double m = Math.Round(right / (right + wrong), 2) * 100;
            label5.Text = m.ToString() + "%";
            MessageBox.Show("欢迎下次使用该模式");
        }

        private void rbt3_CheckedChanged(object sender, EventArgs e)
        {
            bt1.Enabled = true;
            bt2.Enabled = true;
            string[] a = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };//罗列所有的字符
            Random ra = new Random();
            string s = "";
            int num;
            //将所有随机数赋值到字符串s中
            for (int i = 0; i <= 30; i++)
            {
                num = ra.Next(0, 10);
                s += a[num];


            }
            RtbGenerate.Text = s;
            RtbGenerate.SelectAll();
            RtbGenerate.SelectionColor = Color.Black;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            RtbGenerate.Enabled = false;                  
            RtbInput.Enabled = false;
            label1.Text = "1:00";
            rbt1.Checked = false;
            rbt2.Checked = false;
            rbt3.Checked = false;
            bt1.Enabled = false;
            bt2.Enabled = false;
        }

        private void RtbGenerate_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rbt1_CheckedChanged(object sender, EventArgs e)
        {
            bt1.Enabled = true;
            bt2.Enabled = true;
            string[] a = new string[]{"Q","W","E","R","T","Y","U","I","O","P","A","S","D","F","G","H","J","K","L","Z","X","C","V","B","N","M",
                "q","w","e","r","t","y","u","i","o","p","a","s","d","f","g","h","j","k","l","z","x","c","v","b","n","m",
                "0","1","2","3","4","5","6","7","8","9"};//罗列所有的字符
            Random ra = new Random();
            string s = "";
            int num;
            //将所有随机数赋值到字符串s中
            for (int i = 0; i <= 30; i++)
            {
                num = ra.Next(0, 62);
                s += a[num];


            }
            RtbGenerate.Text = s;
            RtbGenerate.SelectAll();
            RtbGenerate.SelectionColor = Color.Black;
        }

        private void RtbInput_TextChanged(object sender, EventArgs e)
        {
            wrong = right = 0;
            RtbGenerate.Select(RtbInput.TextLength, 1);//选择输入框输入字符长度后的一个字符
            RtbGenerate.SelectionColor = Color.Blue;//将颜色改为蓝色
            RtbGenerate.Select(0, 0);//不选择任何字符
            if (RtbInput.TextLength <=30)//当输入框字符数小于等于30的时候
            {

                for (int i = 0; i < RtbInput.TextLength; i++)//for循环用于逐个字符进行比较
                {
                    if (RtbGenerate.Text[i] != RtbInput.Text[i])//当两个同位置字符不相同的时候
                    {
                        RtbGenerate.Select(i, 1);//选中那个字符
                        RtbGenerate.SelectionColor = Color.Red;//将他改为红色
                        RtbGenerate.Select(i + 1, 0);//光标放在那个字符后并且不选中任何字符
                        wrong++;//错误数++
                    }
                    else
                    {
                        RtbGenerate.Select(i, 1);//否则两个字符相等，则正确
                        RtbGenerate.SelectionColor = Color.Blue;//将他改为蓝色
                        RtbGenerate.Select(i + 1, 0);//光标放在那个字符后并且不选中任何字符
                        right++;//正确数++
                    }
                }
            }
            if (RtbInput.TextLength == 30)
            {
                countright += right;//把正确数加给CountRight
                countwrong += wrong;//把错误数加给CountWrong
            }
            if (RtbInput.TextLength == 31)//当字符数等于30的时候
            {               
                //countright += right;//把正确数加给CountRight
                //countwrong += wrong;//把错误数加给CountWrong
                RtbGenerate.Text = "";//清空生成框
                RtbInput.Text = "";//清空输入框
                if (rbt1.Checked)//如果第一个被选中
                {
                    rbt1_CheckedChanged(null, null);//调用第一个生成方法
                }
                else if (rbt2.Checked)//如果第二个被选中
                {
                    rbt2_CheckedChanged(null, null);//调用第二个生成方法
                }
                else
                    rbt3_CheckedChanged(null, null);//调用第三个生成方法

            }
            label2.Text = Convert.ToString(right + countright);//正确提示框等于正确数
            label3.Text = Convert.ToString(wrong + countwrong);//错误提示框等于错误数
            shu1 = right + countright;
            shu2 = wrong + countwrong;
        }

        private void rbt2_CheckedChanged(object sender, EventArgs e)
        {
            bt1.Enabled = true;
            bt2.Enabled = true;
            string[] a = new string[]{"Q","W","E","R","T","Y","U","I","O","P","A","S","D","F","G","H","J","K","L","Z","X","C","V","B","N","M",
                "q","w","e","r","t","y","u","i","o","p","a","s","d","f","g","h","j","k","l","z","x","c","v","b","n","m",
                };//罗列所有的字符
            Random ra = new Random();
            string s = "";
            int num;
            for (int i = 0; i <= 30; i++)
            {
                num = ra.Next(0, 52);
                s += a[num];


            }
            RtbGenerate.Text = s;
            RtbGenerate.SelectAll();
            RtbGenerate.SelectionColor = Color.Black;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;//设置计时器不可用
            bt1.Enabled = false;//一开始的开始键不可用
            RtbInput.Enabled = true;//输入框可以输入
            rbt1.Enabled = false;
            rbt2.Enabled = false;
            rbt3.Enabled = false;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            if (bt2.Text == "暂停")//当停止被按下
            {
                bt2.Text = "继续";//暂停变为继续
                timer1.Enabled = false;//计时器暂停
                RtbInput.Enabled = false;
            }
            else if (bt2.Text == "继续")//当继续被按下
            {
                bt2.Text = "暂停";//开始变为暂停
                timer1.Enabled = true;//计时器打开
                RtbInput.Enabled = true;
            }
        }
        
        double sm = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            time--;//时间减少
            int q, w;//定义q和w来存放分和秒
            q = time / 60;//分钟等于总时间除60
            w = time % 60;//秒等于总时间除60的余数
            string str = q.ToString() + ":" + w.ToString();//定义字符串并连接字符串
            label1.Text = str;//时间文本框显示连接好的字符
            if (time == 0)
            {
                //游戏停止
                timer1.Enabled = false;

                RtbInput.Enabled = false;
                bt2.Enabled = false;
                double m = Math.Round(shu1/ (shu1  + shu2 ), 4) * 100;
                label5.Text = m.ToString() + "%";
                MessageBox.Show("练习结束,您的正确率为：" + label5.Text);
                sm = m;

            }
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Close();
            f5.Show();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            //将游戏成绩保存到记事本
            //if (sm>=0)
            //{
            //    File.AppendAllText(System.Windows.Forms.Application.StartupPath + @"\data\qw.txt", Convert.ToString(sm) + '\n');
            //}
            //MessageBox.Show("成绩保存成功！");


            StreamWriter sw = new StreamWriter(Class1.user + ".txt", true, Encoding.Default);
            try
            {
                sw.WriteLine(sm);
                MessageBox.Show("保存成功");
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "");
                throw;
            }
        }

       

    }
}
