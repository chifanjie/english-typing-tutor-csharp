using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace san_ji_xiang_mu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            this.Hide();
            f6.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Hide();
            f5.Show();
        }

        private void 查看打字测试成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            this.Hide();
            f10.Show();
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            this.Hide();
            f13.Show();
        }

        private void 查看单字练习成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form14 f14 = new Form14();
            this.Hide();
            f14.Show();
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string emg = DemoResources.PathFor(@"yinyue\爆炸.wav");
            //SoundPlayer bgm = new SoundPlayer(emg);
            //bgm.Play();
        }

        private void 放大版键盘打字ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form15 f15 = new Form15();
            this.Hide();
            f15.Show();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
