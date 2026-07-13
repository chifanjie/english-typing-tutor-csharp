using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace san_ji_xiang_mu
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void rbt1_CheckedChanged(object sender, EventArgs e)
        {
            rtb3.Enabled =true;
            rtb4.Enabled =true;
            rtb3.Text = "";
            rtb4.Text = "";
            string[] a = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };//罗列所有的字符
            Random ra = new Random();
            string s = "";
            string s2="";
            int num,num2;
            for (int i = 0; i <= 30; i++)
            {
                num = ra.Next(0, 10);
                num2 = ra.Next(0,10);
                s += a[num];
                s2 += a[num2];

            }
            rtb1.Text = s;
            rtb1.SelectAll();
            rtb1.SelectionColor = Color.Black;
            rtb2.Text = s2;
            rtb2.SelectAll();
            rtb2.SelectionColor = Color.Black;
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            this.Close();
            f6.Show();
        }

        private void rtb3_TextChanged(object sender, EventArgs e)
        {  
            rtb1.Select(rtb3.TextLength, 1);//选择输入框输入字符长度后的一个字符
            rtb1.SelectionColor = Color.Blue;//将颜色改为蓝色
            rtb1.Select(0, 0);//不选择任何字符
            if (rtb3.TextLength <= 30)//当输入框字符数小于等于30的时候
            {

                for (int i = 0; i < rtb3.TextLength; i++)//for循环用于逐个字符进行比较
                {
                    if (rtb1.Text[i] != rtb3.Text[i])//当两个同位置字符不相同的时候
                    {
                        rtb1.Select(i, 1);//选中那个字符
                        rtb1.SelectionColor = Color.Red;//将它改为红色
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
                rtb4.Focus();
            }
        }

        private void rtb4_TextChanged(object sender, EventArgs e)
        {

            rtb2.Select(rtb4.TextLength, 1);//选择输入框输入字符长度后的一个字符
            rtb2.SelectionColor = Color.Blue;//将颜色改为黑色
            rtb2.Select(0, 0);//不选择任何字符
            if (rtb4.TextLength <= 30)//当输入框字符数小于等于30的时候
            {

                for (int i = 0; i < rtb4.TextLength; i++)//for循环用于逐个字符进行比较
                {
                    if (rtb2.Text[i] != rtb4.Text[i])//当两个同位置字符不相同的时候
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
                MessageBox.Show("您已经完成练习");
                rtb3.Enabled = false;
                rtb4.Enabled = false;
            }
        }

        private void rbt2_CheckedChanged(object sender, EventArgs e)
        {
            rtb3.Enabled = true;
            rtb4.Enabled = true;
            rtb3.Text = "";
            rtb4.Text = "";
            string[] a = new string[]{"Q","W","E","R","T","Y","U","I","O","P","A","S","D","F","G","H","J","K","L","Z","X","C","V","B","N","M",
                "q","w","e","r","t","y","u","i","o","p","a","s","d","f","g","h","j","k","l","z","x","c","v","b","n","m",
                };//罗列所有的字符
            Random ra = new Random();
            string s = "";
            string s2 = "";
            int num,num2;
            for (int i = 0; i <= 30; i++)
            {
                num = ra.Next(0, 52);
                num2 = ra.Next(0,52);
                s += a[num];
                s2 += a[num2];

            }
            rtb1.Text = s;
            rtb1.SelectAll();
            rtb1.SelectionColor = Color.Black;
            rtb2.Text = s2;
            rtb2.SelectAll();
            rtb2.SelectionColor = Color.Black;
            timer1.Enabled = true;
        }
        public int time = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;//时间减少
            int q, w, l;//定义q和w来存放分和秒
            q = time / 60;//分钟等于总时间除60
            w = time % 60;//秒等于总时间除60的余数
            l = time / 3600;
            string str = l.ToString() + ":" + q.ToString() + ":" + w.ToString();//定义字符串并连接字符串
            label1.Text = str;//时间文本框显示连接好的字符
        }

        private void Form7_KeyDown(object sender, KeyEventArgs e)
        { 
            //点击键盘的时候对应按钮变成蓝色
            switch (e.KeyCode)
            {
                case Keys.A: A.BackColor = Color.Blue;
                    break;

                case Keys.B: B.BackColor = Color.Blue;
                    break;

                case Keys.C: C.BackColor = Color.Blue;
                    break;

                case Keys.D: D.BackColor = Color.Blue;
                    break;

                case Keys.E: E.BackColor = Color.Blue;
                    break;

                case Keys.F: F.BackColor = Color.Blue;
                    break;

                case Keys.G: G.BackColor = Color.Blue;
                    break;
                case Keys.H: H.BackColor = Color.Blue;
                    break;

                case Keys.I: I.BackColor = Color.Blue;
                    break;

                case Keys.J: J.BackColor = Color.Blue;
                    break;

                case Keys.K: K.BackColor = Color.Blue;
                    break;


                case Keys.L: L.BackColor = Color.Blue;
                    break;

                case Keys.M: M.BackColor = Color.Blue;
                    break;

                case Keys.N: N.BackColor = Color.Blue;
                    break;

                case Keys.O: O.BackColor = Color.Blue;
                    break;


                case Keys.P: P.BackColor = Color.Blue;
                    break;

                case Keys.Q: Q.BackColor = Color.Blue;
                    break;
                case Keys.R: R.BackColor = Color.Blue;
                    break;

                case Keys.S: S.BackColor = Color.Blue;
                    break;


                case Keys.T: T.BackColor = Color.Blue;
                    break;

                case Keys.U: U.BackColor = Color.Blue;
                    break;

                case Keys.V: V.BackColor = Color.Blue;
                    break;

                case Keys.W: W.BackColor = Color.Blue;
                    break;
                case Keys.X: X.BackColor = Color.Blue;
                    break;

                case Keys.Y: Y.BackColor = Color.Blue;
                    break;
                case Keys.Z: Z.BackColor = Color.Blue;
                    break;
                case Keys.D1: btn1.BackColor = Color.Blue;
                    break;
                case Keys.D2: btn2.BackColor = Color.Blue;
                    break;
                case Keys.D3: btn3.BackColor = Color.Blue;
                    break;
                case Keys.D4: btn4.BackColor = Color.Blue;
                    break;
                case Keys.D5: btn5.BackColor = Color.Blue;
                    break;
                case Keys.D6: btn6.BackColor = Color.Blue;
                    break;
                case Keys.D7: btn7.BackColor = Color.Blue;
                    break;
                case Keys.D8: btn8.BackColor = Color.Blue;
                    break;
                case Keys.D9: btn9.BackColor = Color.Blue;
                    break;
                case Keys.D0: btn0.BackColor = Color.Blue;
                    break;
                case Keys.Back: Backspace.BackColor = Color.Red;
                    break;
                case Keys.Tab: Tab.BackColor = Color.Red;
                    break;
                case Keys.Enter: Enter.BackColor = Color.Red;
                    break;
                case Keys.CapsLock: CapsLk.BackColor = Color.Red;
                    break;
                case Keys.Shift: Shift.BackColor = Color.Red;
                    Shift1.BackColor = Color.Red;
                    break;
                

            }
        }

        private void Form7_KeyUp(object sender, KeyEventArgs e)
        {
           //松开键盘时按钮恢复白色
            switch (e.KeyCode)
            {
                case Keys.Shift: Shift.BackColor = Color.White;
                    Shift1.BackColor = Color.White;
                    break;
                case Keys.CapsLock: CapsLk.BackColor = Color.White;
                    break;
                case Keys.Enter: Enter.BackColor = Color.White;
                    break;
                case Keys.Tab: Tab.BackColor = Color.White;
                    break;
                case Keys.Back: Backspace.BackColor = Color.White;
                    break;
                case Keys.A: A.BackColor = Color.White;
                    break;

                case Keys.B: B.BackColor = Color.White;
                    break;

                case Keys.C: C.BackColor = Color.White;
                    break;

                case Keys.D: D.BackColor = Color.White;
                    break;

                case Keys.E: E.BackColor = Color.White;
                    break;

                case Keys.F: F.BackColor = Color.White;
                    break;

                case Keys.G: G.BackColor = Color.White;
                    break;
                case Keys.H: H.BackColor = Color.White;
                    break;

                case Keys.I: I.BackColor = Color.White;
                    break;

                case Keys.J: J.BackColor = Color.White;
                    break;

                case Keys.K: K.BackColor = Color.White;
                    break;

                case Keys.L: L.BackColor = Color.White;
                    break;

                case Keys.M: M.BackColor = Color.White;
                    break;

                case Keys.N: N.BackColor = Color.White;
                    break;

                case Keys.O: O.BackColor = Color.White;
                    break;

                case Keys.P: P.BackColor = Color.White;
                    break;

                case Keys.Q: Q.BackColor = Color.White;
                    break;
                case Keys.R: R.BackColor = Color.White;
                    break;

                case Keys.S: S.BackColor = Color.White;
                    break;

                case Keys.T: T.BackColor = Color.White;
                    break;

                case Keys.U: U.BackColor = Color.White;
                    break;

                case Keys.V: V.BackColor = Color.White;
                    break;

                case Keys.W: W.BackColor = Color.White;
                    break;
                case Keys.X: X.BackColor = Color.White;
                    break;

                case Keys.Y: Y.BackColor = Color.White;
                    break;
                case Keys.Z: Z.BackColor = Color.White;
                    break;
                case Keys.D1: btn1.BackColor = Color.White;
                    break;
                case Keys.D2: btn2.BackColor = Color.White;
                    break;
                case Keys.D3: btn3.BackColor = Color.White;
                    break;
                case Keys.D4: btn4.BackColor = Color.White;
                    break;
                case Keys.D5: btn5.BackColor = Color.White;
                    break;
                case Keys.D6: btn6.BackColor = Color.White;
                    break;
                case Keys.D7: btn7.BackColor = Color.White;
                    break;
                case Keys.D8: btn8.BackColor = Color.White;
                    break;
                case Keys.D9: btn9.BackColor = Color.White;
                    break;
                case Keys.D0: btn0.BackColor = Color.White;
                    break;

            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void rtb3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form7_KeyPress(object sender, KeyPressEventArgs e)
        {
 
        }

    }
}
