namespace Playful_Square_V0._2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.HScroolBarText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ScrollBarXMaximum = new System.Windows.Forms.ComboBox();
            this.ScrollBarXMinimum = new System.Windows.Forms.ComboBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ScrollBarYMaximum = new System.Windows.Forms.ComboBox();
            this.ScrollBarYMinimum = new System.Windows.Forms.ComboBox();
            this.VScroolBarText = new System.Windows.Forms.TextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // HScroolBarText
            // 
            this.HScroolBarText.Enabled = false;
            this.HScroolBarText.Location = new System.Drawing.Point(844, 141);
            this.HScroolBarText.Margin = new System.Windows.Forms.Padding(2);
            this.HScroolBarText.Name = "HScroolBarText";
            this.HScroolBarText.Size = new System.Drawing.Size(81, 20);
            this.HScroolBarText.TabIndex = 20;
            this.HScroolBarText.TextChanged += new System.EventHandler(this.HScroolBarText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(805, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Kaydırma Çubuğu X Maksimum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(805, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Kaydırma Çubuğu X Minimum";
            // 
            // ScrollBarXMaximum
            // 
            this.ScrollBarXMaximum.FormattingEnabled = true;
            this.ScrollBarXMaximum.Location = new System.Drawing.Point(807, 88);
            this.ScrollBarXMaximum.Margin = new System.Windows.Forms.Padding(2);
            this.ScrollBarXMaximum.Name = "ScrollBarXMaximum";
            this.ScrollBarXMaximum.Size = new System.Drawing.Size(151, 21);
            this.ScrollBarXMaximum.TabIndex = 31;
            this.ScrollBarXMaximum.TextChanged += new System.EventHandler(this.ScrollBarXMaximum_TextChanged);
            // 
            // ScrollBarXMinimum
            // 
            this.ScrollBarXMinimum.FormattingEnabled = true;
            this.ScrollBarXMinimum.Items.AddRange(new object[] {
            "0",
            "100",
            "300",
            "1000"});
            this.ScrollBarXMinimum.Location = new System.Drawing.Point(807, 33);
            this.ScrollBarXMinimum.Margin = new System.Windows.Forms.Padding(2);
            this.ScrollBarXMinimum.Name = "ScrollBarXMinimum";
            this.ScrollBarXMinimum.Size = new System.Drawing.Size(151, 21);
            this.ScrollBarXMinimum.TabIndex = 30;
            this.ScrollBarXMinimum.TextChanged += new System.EventHandler(this.ScrollBarXMinimum_TextChanged);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hScrollBar1.LargeChange = 1;
            this.hScrollBar1.Location = new System.Drawing.Point(770, 163);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(225, 26);
            this.hScrollBar1.TabIndex = 21;
            this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(581, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Kaydırma Çubuğu Y Maksimum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(581, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Kaydırma Çubuğu Y Minimum";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(291, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 240);
            this.panel1.TabIndex = 27;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(348, 265);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(138, 13);
            this.textBox2.TabIndex = 26;
            // 
            // ScrollBarYMaximum
            // 
            this.ScrollBarYMaximum.FormattingEnabled = true;
            this.ScrollBarYMaximum.Location = new System.Drawing.Point(584, 89);
            this.ScrollBarYMaximum.Margin = new System.Windows.Forms.Padding(2);
            this.ScrollBarYMaximum.Name = "ScrollBarYMaximum";
            this.ScrollBarYMaximum.Size = new System.Drawing.Size(150, 21);
            this.ScrollBarYMaximum.TabIndex = 24;
            this.ScrollBarYMaximum.TextChanged += new System.EventHandler(this.ScrollBarYMaximum_TextChanged);
            // 
            // ScrollBarYMinimum
            // 
            this.ScrollBarYMinimum.FormattingEnabled = true;
            this.ScrollBarYMinimum.Items.AddRange(new object[] {
            "0",
            "100",
            "300",
            "1000"});
            this.ScrollBarYMinimum.Location = new System.Drawing.Point(584, 34);
            this.ScrollBarYMinimum.Margin = new System.Windows.Forms.Padding(2);
            this.ScrollBarYMinimum.Name = "ScrollBarYMinimum";
            this.ScrollBarYMinimum.Size = new System.Drawing.Size(150, 21);
            this.ScrollBarYMinimum.TabIndex = 23;
            this.ScrollBarYMinimum.TextChanged += new System.EventHandler(this.ScrollBarYMinimum_TextChanged);
            // 
            // VScroolBarText
            // 
            this.VScroolBarText.Enabled = false;
            this.VScroolBarText.Location = new System.Drawing.Point(610, 352);
            this.VScroolBarText.Margin = new System.Windows.Forms.Padding(2);
            this.VScroolBarText.Name = "VScroolBarText";
            this.VScroolBarText.Size = new System.Drawing.Size(94, 20);
            this.VScroolBarText.TabIndex = 25;
            this.VScroolBarText.TextChanged += new System.EventHandler(this.VScroolBarText_TextChanged);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.vScrollBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.vScrollBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.vScrollBar1.LargeChange = 1;
            this.vScrollBar1.Location = new System.Drawing.Point(641, 136);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(28, 209);
            this.vScrollBar1.TabIndex = 22;
            this.vScrollBar1.ValueChanged += new System.EventHandler(this.vScrollBar1_ValueChanged);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "label5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 38;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(685, 154);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(38, 15);
            this.textBox3.TabIndex = 44;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(784, 225);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(27, 13);
            this.textBox4.TabIndex = 45;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Playful_Square_V0._2.Properties.Resources.vector_web_search_icon;
            this.pictureBox9.Location = new System.Drawing.Point(738, 428);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(73, 75);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 48;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Playful_Square_V0._2.Properties.Resources.youtube_vector_icon_8;
            this.pictureBox8.Location = new System.Drawing.Point(830, 433);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(62, 66);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 47;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Playful_Square_V0._2.Properties.Resources.linkedin_icon;
            this.pictureBox7.Location = new System.Drawing.Point(913, 433);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(62, 66);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 46;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Playful_Square_V0._2.Properties.Resources.Adsız___Kopya;
            this.pictureBox6.Location = new System.Drawing.Point(775, 192);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(39, 55);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 43;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Playful_Square_V0._2.Properties.Resources.Adsız;
            this.pictureBox5.Location = new System.Drawing.Point(670, 143);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(55, 39);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 41;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Playful_Square_V0._2.Properties.Resources.Speech_Bubble_PNG_Free_Download_1;
            this.pictureBox4.Location = new System.Drawing.Point(104, 276);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(261, 92);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 36;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Playful_Square_V0._2.Properties.Resources.images;
            this.pictureBox3.Location = new System.Drawing.Point(1, 290);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(166, 224);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Playful_Square_V0._2.Properties.Resources.Ekran_Alıntıssı;
            this.pictureBox1.Location = new System.Drawing.Point(1, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(84, 84);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.MaximumSize = new System.Drawing.Size(240, 240);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1004, 511);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.HScroolBarText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ScrollBarXMaximum);
            this.Controls.Add(this.ScrollBarXMinimum);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ScrollBarYMaximum);
            this.Controls.Add(this.ScrollBarYMinimum);
            this.Controls.Add(this.VScroolBarText);
            this.Controls.Add(this.vScrollBar1);
            this.MaximumSize = new System.Drawing.Size(1020, 550);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1020, 550);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HScroolBarText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ScrollBarXMaximum;
        private System.Windows.Forms.ComboBox ScrollBarXMinimum;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox ScrollBarYMaximum;
        private System.Windows.Forms.ComboBox ScrollBarYMinimum;
        private System.Windows.Forms.TextBox VScroolBarText;
        public System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
    }
}

