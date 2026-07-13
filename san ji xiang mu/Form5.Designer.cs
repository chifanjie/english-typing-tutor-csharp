namespace san_ji_xiang_mu
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.button1 = new System.Windows.Forms.Button();
            this.rbt1 = new System.Windows.Forms.RadioButton();
            this.rbt2 = new System.Windows.Forms.RadioButton();
            this.rbt3 = new System.Windows.Forms.RadioButton();
            this.RtbGenerate = new System.Windows.Forms.RichTextBox();
            this.RtbInput = new System.Windows.Forms.RichTextBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bt3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "返回👈";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbt1
            // 
            this.rbt1.AutoSize = true;
            this.rbt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rbt1.Font = new System.Drawing.Font("华文行楷", 10F);
            this.rbt1.ForeColor = System.Drawing.Color.Blue;
            this.rbt1.Location = new System.Drawing.Point(75, 124);
            this.rbt1.Name = "rbt1";
            this.rbt1.Size = new System.Drawing.Size(165, 22);
            this.rbt1.TabIndex = 1;
            this.rbt1.TabStop = true;
            this.rbt1.Text = "英文数字混合练习";
            this.rbt1.UseVisualStyleBackColor = false;
            this.rbt1.CheckedChanged += new System.EventHandler(this.rbt1_CheckedChanged);
            // 
            // rbt2
            // 
            this.rbt2.AutoSize = true;
            this.rbt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rbt2.Font = new System.Drawing.Font("华文行楷", 10F);
            this.rbt2.ForeColor = System.Drawing.Color.Blue;
            this.rbt2.Location = new System.Drawing.Point(250, 124);
            this.rbt2.Name = "rbt2";
            this.rbt2.Size = new System.Drawing.Size(97, 22);
            this.rbt2.TabIndex = 2;
            this.rbt2.TabStop = true;
            this.rbt2.Text = "英文练习";
            this.rbt2.UseVisualStyleBackColor = false;
            this.rbt2.CheckedChanged += new System.EventHandler(this.rbt2_CheckedChanged);
            // 
            // rbt3
            // 
            this.rbt3.AutoSize = true;
            this.rbt3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rbt3.Font = new System.Drawing.Font("华文行楷", 10F);
            this.rbt3.ForeColor = System.Drawing.Color.Blue;
            this.rbt3.Location = new System.Drawing.Point(353, 124);
            this.rbt3.Name = "rbt3";
            this.rbt3.Size = new System.Drawing.Size(97, 22);
            this.rbt3.TabIndex = 3;
            this.rbt3.TabStop = true;
            this.rbt3.Text = "数字练习";
            this.rbt3.UseVisualStyleBackColor = false;
            this.rbt3.CheckedChanged += new System.EventHandler(this.rbt3_CheckedChanged);
            // 
            // RtbGenerate
            // 
            this.RtbGenerate.Font = new System.Drawing.Font("宋体", 23F);
            this.RtbGenerate.Location = new System.Drawing.Point(75, 201);
            this.RtbGenerate.Name = "RtbGenerate";
            this.RtbGenerate.Size = new System.Drawing.Size(747, 63);
            this.RtbGenerate.TabIndex = 4;
            this.RtbGenerate.Text = "";
            this.RtbGenerate.TextChanged += new System.EventHandler(this.RtbGenerate_TextChanged);
            // 
            // RtbInput
            // 
            this.RtbInput.Font = new System.Drawing.Font("宋体", 23F);
            this.RtbInput.Location = new System.Drawing.Point(75, 334);
            this.RtbInput.Name = "RtbInput";
            this.RtbInput.Size = new System.Drawing.Size(747, 63);
            this.RtbInput.TabIndex = 5;
            this.RtbInput.Text = "";
            this.RtbInput.TextChanged += new System.EventHandler(this.RtbInput_TextChanged);
            // 
            // bt1
            // 
            this.bt1.Font = new System.Drawing.Font("华文行楷", 12F);
            this.bt1.Location = new System.Drawing.Point(159, 520);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(153, 58);
            this.bt1.TabIndex = 6;
            this.bt1.Text = "开始游戏";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Font = new System.Drawing.Font("华文行楷", 12F);
            this.bt2.Location = new System.Drawing.Point(394, 520);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(153, 58);
            this.bt2.TabIndex = 7;
            this.bt2.Text = "暂停";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.Location = new System.Drawing.Point(945, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(945, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(945, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("华文行楷", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(852, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "正确率：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(945, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("华文行楷", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(826, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "剩余时间：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("华文行楷", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(852, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "正确数：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("华文行楷", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(852, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "错误数：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label9.Font = new System.Drawing.Font("华文行楷", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(71, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(226, 21);
            this.label9.TabIndex = 16;
            this.label9.Text = "请先选择您的练习模式👇";
            // 
            // bt3
            // 
            this.bt3.Font = new System.Drawing.Font("华文行楷", 12F);
            this.bt3.Location = new System.Drawing.Point(637, 520);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(153, 58);
            this.bt3.TabIndex = 17;
            this.bt3.Text = "重新开始";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("华文行楷", 12F);
            this.button2.Location = new System.Drawing.Point(855, 520);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 58);
            this.button2.TabIndex = 18;
            this.button2.Text = "保存成绩";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1176, 644);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.RtbInput);
            this.Controls.Add(this.RtbGenerate);
            this.Controls.Add(this.rbt3);
            this.Controls.Add(this.rbt2);
            this.Controls.Add(this.rbt1);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "打字测试";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbt1;
        private System.Windows.Forms.RadioButton rbt2;
        private System.Windows.Forms.RadioButton rbt3;
        private System.Windows.Forms.RichTextBox RtbGenerate;
        private System.Windows.Forms.RichTextBox RtbInput;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button button2;
    }
}