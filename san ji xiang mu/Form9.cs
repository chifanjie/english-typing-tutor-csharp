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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Close();
            f1.Show();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            //添加模式
            comboBox1.Items.Add("认识键盘");
            comboBox1.Items.Add("打字姿势");
            comboBox1.Items.Add("基准键位");
            comboBox1.Items.Add("手指分工");
            comboBox1.Items.Add("击键方法");
            comboBox2.Items.Add("英文字母大小写");
            comboBox2.Items.Add("英文标点符号");
            comboBox2.Items.Add("英文打字指法输入");
            comboBox2.Items.Add("提高英文打字速度");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //按照模式选择相应图片
            comboBox2.Text = "";
           // pictureBox1.Refresh();
            if (comboBox1.Text == "认识键盘")
            {
                pictureBox1.Image = DemoResources.LoadImage(DemoResources.PathFor(@"tupian\renshijianpan\1.png"));

            }
            if (comboBox1.Text == "打字姿势")
            {
                pictureBox1.Image = DemoResources.LoadImage(DemoResources.PathFor(@"tupian\dazizishi\14.png"));
            }
            if (comboBox1.Text == "基准键位")
            {
                pictureBox1.Image = DemoResources.LoadImage(DemoResources.PathFor(@"tupian\jizhuijianwei\16.png"));
            }
            if (comboBox1.Text == "手指分工")
            {
                pictureBox1.Image = DemoResources.LoadImage(DemoResources.PathFor(@"tupian\shouzhifengong\17.png"));
            }
            if (comboBox1.Text == "击键方法")
            {
                pictureBox1.Image = DemoResources.LoadImage(DemoResources.PathFor(@"tupian\jijianfangshi\18.png"));
            }
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //按照模式选择相应图片
            comboBox1.Text = "";
            if (comboBox2.Text == "英文字母大小写")
            {
                pictureBox1.Image = DemoResources.LoadImage(DemoResources.PathFor(@"tupian\yingwenzimudaxiaoxie\21.png"));
            }
            if (comboBox2.Text == "英文标点符号")
            {
                pictureBox1.Image = DemoResources.LoadImage(DemoResources.PathFor(@"tupian\yingwenbiaodian\23.png"));
            }
            if (comboBox2.Text == "英文打字指法输入")
            {
                pictureBox1.Image = DemoResources.LoadImage(DemoResources.PathFor(@"tupian\yingwendazizishi\24.png"));
            }
            if (comboBox2.Text == "提高英文打字速度")
            {
                pictureBox1.Image = DemoResources.LoadImage(DemoResources.PathFor(@"tupian\tigaoyingwendazisudu\25.png"));
            }
        }
        //将文件夹中的图片名称储存到数组中
        string[] path = DemoResources.ImageFiles(DemoResources.PathFor(@"tupian\renshijianpan"));
        string[] path1 = DemoResources.ImageFiles(DemoResources.PathFor(@"tupian\dazizishi"));
        string[] path2 = DemoResources.ImageFiles(DemoResources.PathFor(@"tupian\jizhuijianwei"));
        string[] path3 = DemoResources.ImageFiles(DemoResources.PathFor(@"tupian\shouzhifengong"));
        string[] path4 = DemoResources.ImageFiles(DemoResources.PathFor(@"tupian\jijianfangshi"));
        string[] path5 = DemoResources.ImageFiles(DemoResources.PathFor(@"tupian\yingwenzimudaxiaoxie"));
        string[] path6 = DemoResources.ImageFiles(DemoResources.PathFor(@"tupian\yingwenbiaodian"));
        string[] path7 = DemoResources.ImageFiles(DemoResources.PathFor(@"tupian\yingwendazizishi"));
        string[] path8 = DemoResources.ImageFiles(DemoResources.PathFor(@"tupian\tigaoyingwendazisudu"));
        int i = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            //当选择后跳出相应图片
            if (comboBox1.Text == "认识键盘")
            {
                if (i > path.Length)
                {
                    i = 0;
                }
                i++;
                if (i == path.Length)
                {
                    i = 0;
                }
                pictureBox1.Image = DemoResources.LoadImage(path[i]);
            }
            if (comboBox1.Text == "打字姿势")
            {
                if (i > path1.Length)
                {
                    i = 0;
                }
                i++;
                if (i == path1.Length)
                {
                    i = 0;
                }
                pictureBox1.Image = DemoResources.LoadImage(path1[i]);
            }
            if (comboBox1.Text == "基准键位")
            {
                if (i>path2.Length)
                {
                    i = 0;
                }
                i++;
                if (i == path2.Length)
                {
                    i = 0;
                }
                pictureBox1.Image = DemoResources.LoadImage(path2[i]);
            }
            if (comboBox1.Text == "手指分工")
            {
                if (i > path3.Length)
                {
                    i = 0;
                }
                i++;
                if (i == path3.Length)
                {
                    i = 0;
                }
                pictureBox1.Image = DemoResources.LoadImage(path3[i]);
            }
            if (comboBox1.Text == "击键方法")
            {
                if (i > path4.Length)
                {
                    i = 0;
                }
                i++;
                if (i == path4.Length)
                {
                    i = 0;
                }
                pictureBox1.Image = DemoResources.LoadImage(path4[i]);
            }
            if (comboBox1.Text == "英文字母大小写")
            {
                if (i > path5.Length)
                {
                    i = 0;
                }
                i++;
                if (i == path5.Length)
                {
                    i = 0;
                }
                pictureBox1.Image = DemoResources.LoadImage(path5[i]);
            }
            if (comboBox1.Text == "英文标点符号")
            {
                if (i > path6.Length)
                {
                    i = 0;
                }
                i++;
                if (i == path6.Length)
                {
                    i = 0;
                }
                pictureBox1.Image = DemoResources.LoadImage(path6[i]);
            }
            if (comboBox1.Text == "英文打字指法输入")
            {
                if (i > path7.Length)
                {
                    i = 0;
                }
                i++;
                if (i == path7.Length)
                {
                    i = 0;
                }
                pictureBox1.Image = DemoResources.LoadImage(path7[i]);
            }
            if (comboBox1.Text == "提高英文打字速度")
            {
                if (i > path8.Length)
                {
                    i = 0;
                }
                i++;
                if (i == path8.Length)
                {
                    i = 0;
                }
                pictureBox1.Image = DemoResources.LoadImage(path8[i]);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "认识键盘")
            {
                i--;
                if (i < 0)
                {
                    i = path.Length - 1;
                }
                pictureBox1.Image = DemoResources.LoadImage(path[i]);
            }
            if (comboBox1.Text == "打字姿势")
            {
                i--;
                if (i < 0)
                {
                    i = path1.Length - 1;
                }
                pictureBox1.Image = DemoResources.LoadImage(path1[i]);
            }
            if (comboBox1.Text == "基准键位")
            {
                i--;
                if (i < 0)
                {
                    i = path2.Length - 1;
                }
                pictureBox1.Image = DemoResources.LoadImage(path2[i]);
            }
            if (comboBox1.Text == "手指分工")
            {
                i--;
                if (i < 0)
                {
                    i = path3.Length - 1;
                }
                pictureBox1.Image = DemoResources.LoadImage(path3[i]);
            }
            if (comboBox1.Text == "击键方法")
            {
                i--;
                if (i < 0)
                {
                    i = path4.Length - 1;
                }
                pictureBox1.Image = DemoResources.LoadImage(path4[i]);
            }
            if (comboBox1.Text == "英文字母大小写")
            {
                i--;
                if (i < 0)
                {
                    i = path5.Length - 1;
                }
                pictureBox1.Image = DemoResources.LoadImage(path5[i]);
            }
            if (comboBox1.Text == "英文标点符号")
            {
                i--;
                if (i < 0)
                {
                    i = path6.Length - 1;
                }
                pictureBox1.Image = DemoResources.LoadImage(path6[i]);
            }
            if (comboBox1.Text == "英文打字指法输入")
            {
                i--;
                if (i < 0)
                {
                    i = path7.Length - 1;
                }
                pictureBox1.Image = DemoResources.LoadImage(path7[i]);
            }
            if (comboBox1.Text == "提高英文打字速度")
            {
                i--;
                if (i < 0)
                {
                    i = path8.Length - 1;
                }
                pictureBox1.Image = DemoResources.LoadImage(path8[i]);
            }
        }

    }
}
