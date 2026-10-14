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
    public partial class Form4 : Form
    {
        ImageList imageList = new ImageList();
        Panel Game = new Panel();//游戏区域
        Panel cebian = new Panel();//侧边栏区域
        Panel plean = new Panel();//飞机
        Random rad = new Random();//随机数
        Button bt1 = new Button();//暂停游戏按钮
        Timer zimuadd = new Timer();//控制创建字母计时器
        Timer zimutop = new Timer();//控制字母下落计时器
        Button btnstar = new Button();//开始游戏按钮
        Label lab = new Label();//得分
        int score = 0;//记录分数
        ProgressBar HS = new ProgressBar();//进度
        Label HSback = new Label();//进度条背景
        Label HSjindu = new Label();//进度条
        int xt = 100;//血量
        int xy = 0;//蓄力值
        List<Label> zimulab = new List<Label>();//储存字母
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.Size = new Size(1000, 600);
            this.Left = Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2;
            this.Top = Screen.PrimaryScreen.Bounds.Height / 2 - this.Height / 2;
            this.BackColor = Color.White;

            //游戏区域设置
            Game.Size = new Size(800, 540);
            Game.BackColor = Color.White;
            Game.Location = new Point(10, 10);
            this.Controls.Add(Game);
            //飞机所在的游戏区域
            plean.Size = new Size(60, 60);
            plean.Tag = "plean";
            plean.Top = Game.Height - plean.Height;
            plean.Left = Game.Width / 2 - plean.Width / 2;
            plean.BackgroundImage = DemoResources.LoadImage(DemoResources.PathFor(@"game\fj.png"));
            plean.BackgroundImageLayout = ImageLayout.Stretch;
            Game.Controls.Add(plean);
            //添加游戏的侧边栏
            cebian.Size = new Size(150, 540);
            cebian.BackColor = Color.Aqua;
            cebian.Left = 820;
            cebian.Top = 10;
            this.Controls.Add(cebian);

            btnstar.Font = new Font("平方", 15);
            btnstar.Size = new Size(80, 30);
            btnstar.AutoSize = true;
          
            btnstar.Location = new Point(10, 10);
            btnstar.Text = "开始游戏";
            btnstar.Click += Btnstart_Click;
            cebian.Controls.Add(btnstar);

            bt1.Font = new Font("平方", 15);
            bt1.Size = new Size(80, 30);
            bt1.AutoSize = true;
            bt1.Location = new Point(10, 200);
            bt1.Text = "结束游戏";
            bt1.Click += bt1_Click;
            cebian.Controls.Add(bt1);

            //侧边栏显示得分
            lab.Font = new Font("平方", 15);
            lab.AutoSize = true;
            lab.Text = "得分：0分";
            lab.Location = new Point(10, 50);
            cebian.Controls.Add(lab);
            zimuadd.Tick += Zimuadd_Tick;
            zimuadd.Interval = 1000;
            zimutop.Tick += Zimutop_Tick;
            zimutop.Interval = 10;

            //系统自带的血量进度条
            Label la = new Label();
            la.Font = new Font("平方", 10);
            la.AutoSize = true;
            la.ForeColor = Color.Red;
            la.Text = "血量👇";
            la.Location = new Point(10, 90);
            cebian.Controls.Add(la);

            HS.Location = new Point(10, 110);
            HS.Size = new Size(100, 20);
            HS.Value = xt;
            cebian.Controls.Add(HS);
            //定义一个蓄力值，作用是等到蓄力值满的时候屏幕字母全部清空
            Label xu = new Label();
            xu.Text = "蓄力值";
            xu.Font = new Font("平方", 10);
            xu.AutoSize = true;
            xu.ForeColor = Color.Red;
            xu.Location = new Point(10, 150);
            cebian.Controls.Add(xu);

            HSback.Size = new Size(100, 20);
            HSback.Location = new Point(10, 150);
            HSback.BackColor = Color.Aqua;
            HSjindu.Size = new Size(xy, 20);
            HSjindu.Location = new Point(10, 170);
            HSjindu.BackColor = Color.Red;

            cebian.Controls.Add(HSback);
            cebian.Controls.Add(HSjindu);
            //窗口键盘事件
            this.KeyPress += Form1_KeyPress;
        }
        private void Btnstart_Click(object sender, EventArgs e)//开始游戏和暂停游戏
        {
            if (btnstar.Text == "开始游戏")
            {
                zimuadd.Start();
                zimutop.Start();
                btnstar.Text = "暂停";

            }
            else if (btnstar.Text == "暂停")
            {
                zimuadd.Stop();
                zimutop.Stop();
                btnstar.Text = "开始游戏";
            }
        }
        private void bt1_Click(object sender, EventArgs e)
        {
            zimuadd.Stop();
            zimutop.Stop();
           // File.AppendAllText(System.Windows.Forms.Application.StartupPath + @"\data\po.txt", Convert.ToString(score) + '\n');

            //分用户成绩保存
            StreamWriter sw = new StreamWriter(Class1.user+ 1 + ".txt", true, Encoding.Default);
            try
            {
                sw.WriteLine(score);
                //MessageBox.Show("保存成功");
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "");
                throw;
            }

            Form3 f3 = new Form3();
            f3.Show();
            this.Close();
            MessageBox.Show("游戏结束，你的得分：" + score, "Game Over");

        }

        private void Zimuadd_Tick(object sender, EventArgs e)//控制字母添加
        {
            Label zimu = new Label();
            zimu.Tag = "zimu";
            zimu.Text = ((char)rad.Next(97, 123)).ToString();
            zimu.Font = new Font("平方", rad.Next(20, 31));
            zimu.ForeColor = Color.FromArgb(rad.Next(255), rad.Next(255), rad.Next(255));
            zimu.BackColor = Color.Transparent;
            zimu.Top = 0;
            zimu.AutoSize = true;
            zimu.Left = rad.Next(0, Game.Width - zimu.Width);
            Game.Controls.Add(zimu);
            //把zimu添加到泛型集合中
            zimulab.Add(zimu);

        }
        private void Zimutop_Tick(object sender, EventArgs e)//控制子母下落，子弹上升计时器
        {
            foreach (Control item in Game.Controls)
            {
                //字母下落
                if (item.Tag.ToString() == "zimu" || item.Tag.ToString() == "biaoji")
                {
                    item.Top += 3;
                    if (item.Top > Game.Height)
                    {
                        item.Dispose();
                        //记录血条与的得分
                        xt -= 10;
                        HS.Value = xt;
                        if (xt == 0)
                        {
                            zimuadd.Stop();
                            zimutop.Stop();
                            //File.AppendAllText(System.Windows.Forms.Application.StartupPath + @"\data\po.txt", Convert.ToString(score) + '\n');

                            //分用户成绩保存
                            StreamWriter sw = new StreamWriter(Class1.user + 1 + ".txt", true, Encoding.Default);
                            try
                            {
                                sw.WriteLine(score);
                               // MessageBox.Show("保存成功");
                                sw.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "");
                                throw;
                            }


                            //判断游戏是否结束
                            if (MessageBox.Show("游戏结束，你的得分：" + score, "Game Over",
                                MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == DialogResult.Retry)
                            {
                                //数据初始化
                                btnstar.Text = "开始游戏";
                                score = 0;
                                lab.Text = "得分：" + score + "分";
                                xt = 100;
                                HS.Value = xt;
                                xy = 0;
                                HSjindu.Width = xy;
                                //调用清屏方法
                                QingPing();

                            }
                            else
                            {
                                this.Hide();
                                Form3 f3 = new Form3();
                                f3.Show();
                            }

                        }
                    }
                }

                if (item.Tag.ToString() == "zidan")//子弹上升
                {
                    item.Top -= 10;
                    if (item.Top < -item.Height)
                    {
                        item.Dispose();
                    }
                    foreach (Control it in Game.Controls)
                    {
                        if (it.Tag.ToString() == "biaoji")
                        {
                            if (item.Top <= it.Top + it.Height && item.Left + item.Width / 2 == it.Left + it.Width / 2)
                            {
                                item.Dispose();
                                it.Dispose();
                                string emg = DemoResources.PathFor(@"yinyue\爆炸.WAV");
                                SoundPlayer bgm = new SoundPlayer(emg);
                                if (File.Exists(emg)) bgm.Play();
                                //蓄力值进度条增加
                                xy += 10;
                                HSjindu.Width = xy;
                                if (xy == 100)
                                {
                                    //清空屏幕，蓄力值为零
                                    xy = 0;
                                    HSjindu.Width = xy;
                                    QingPing();
                                }
                                score += 10;
                                lab.Text = "得分：" + score + "分";

                                //PictureBox bomimgs = new PictureBox();
                                //bomimgs.Size = new Size(30, 30);
                                //bomimgs.Tag = 0;
                                

                                //从这
                                imageList.ImageSize = new Size(30,30);
                                PictureBox Bomb = new PictureBox();
                                Bomb.Size = new Size(30,30);
                                Bomb.Tag = 0;
                                //Bomb.Image=imageList.Images[0];
                                Bomb.Left = it.Left + it.Width / 2 - Bomb.Width / 2;
                                Bomb.Top = it.Top + it.Height / 2 - Bomb.Height / 2;
                                Game.Controls.Add(Bomb);
                                //设置图片路径
                                string path = DemoResources.PathFor(@"game\bj.png");
                                    imageList.Images.Add(DemoResources.LoadImage(path));
                                    Bomb.Image=imageList.Images[Convert.ToInt32(Bomb.Tag)];
                                
                                //bomimgs.Left = it.Left + it.Width / 2 - bomimgs.Width / 2;
                                //bomimgs.Top = it.Top + it.Height / 2 - bomimgs.Height / 2;
                                //Game.Controls.Add(bomimgs);

                                //Timer timerbom = new Timer();
                                //timerbom.Tag = bomimgs;
                                //timerbom.Interval = 30;
                                //timerbom.Start();
                                //timerbom.Tick += Timerbom_Tick;

                                Timer timerbom = new Timer();
                                timerbom.Tag = Bomb;
                                timerbom.Interval = 30;
                                timerbom.Start();
                                timerbom.Tick += Timerbom_Tick;
                            }
                        }
                    }
                }
            }
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)//键盘点击事件
        {
            foreach (Control item in Game.Controls)
            {
                if (item.Text == e.KeyChar.ToString() && item.Tag.ToString() == "zimu")
                {
                    item.Tag = "biaoji";
                    plean.Left = item.Left + item.Width / 2 - plean.Width / 2;
                    PictureBox fire = new PictureBox();
                    fire.Tag = "zidan";
                    fire.Size = new Size(10, 30);
                    fire.Image = DemoResources.LoadImage(DemoResources.PathFor(@"game\fj.png"));
                    fire.SizeMode = PictureBoxSizeMode.StretchImage;
                    fire.Left = plean.Left + plean.Width / 2 - fire.Width / 2;
                    fire.Top = plean.Top - fire.Height;
                    Game.Controls.Add(fire);
                    return;
                }

            }
        }
        private void Timerbom_Tick(object sender, EventArgs e)
        {
            //Timer timbom = (Timer)sender;
            //PictureBox bomimgs = (PictureBox)timbom.Tag;
            //bomimgs.Tag = ((int)bomimgs.Tag) + 1;
          
            //if ((int)bomimgs.Tag >= 31)
            //{
            //    bomimgs.Dispose();
            //    timbom.Dispose();
            //}

            Timer timbom = (Timer)sender;
            PictureBox bomimgs = (PictureBox)timbom.Tag;
            bomimgs.Tag = ((int)bomimgs.Tag) + 1;
            if ((int)bomimgs.Tag >= 31)
            {
                bomimgs.Dispose();
                timbom.Dispose();
            }
        }
        private void QingPing()
        {
            foreach (Label zimu in zimulab)
            {
                zimu.Dispose();
            }
        }
    }
}
