using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playful_Square_V0._2
{
    public partial class Form1 : Form
    {
        int r, g, b;
        int counter=0;
        Random random = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ScrollBarXMinimum.Text == "" || ScrollBarXMaximum.Text == "" || ScrollBarYMinimum.Text == "" || ScrollBarYMaximum.Text == "")
            {
                vScrollBar1.Enabled = false;
                hScrollBar1.Enabled = false;
            }
            else
            {
                vScrollBar1.Enabled = true;
                hScrollBar1.Enabled = true;
                VScroolBarText.Enabled = true;
                HScroolBarText.Enabled = true;
                pictureBox2.Size = new Size(0, 0);
                label5.Text = "Tebrikler, aralıkları belirledin.Şimdi kaydırma\n çubuklarını kullanarak kareyle oyna.";
                timer1.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 100;
            timer2.Start();
            timer2.Interval = 1000;
            label5.Text = "Hoşgeldin\n Sana öncelikle uygulamayı tanıtayım";

        }

        private void ScrollBarXMinimum_TextChanged(object sender, EventArgs e)
        {
            hScrollBar1.Minimum = Convert.ToInt32(ScrollBarXMinimum.Text);
            switch (hScrollBar1.Minimum)
            {
                case 0:
                    ScrollBarXMaximum.Items.Clear();
                    ScrollBarXMaximum.Items.Add("100");
                    ScrollBarXMaximum.Items.Add("300");
                    ScrollBarXMaximum.Items.Add("1000");
                    break;
                case 100:
                    ScrollBarXMaximum.Items.Clear();
                    ScrollBarXMaximum.Items.Add("300");
                    ScrollBarXMaximum.Items.Add("1000");
                    break;
                case 300:
                    ScrollBarXMaximum.Items.Clear();
                    ScrollBarXMaximum.Items.Add("1000");
                    break;
                case 1000:
                    ScrollBarXMinimum.Text = "0";
                    MessageBox.Show("Minimum değer 1000'den küçük olmalıdır", "Minimum Değer Hatası");
                    break;
            }
        }

        private void ScrollBarXMaximum_TextChanged(object sender, EventArgs e)
        {
            hScrollBar1.Maximum = Convert.ToInt32(ScrollBarXMaximum.Text);
        }

        private void ScrollBarYMinimum_TextChanged(object sender, EventArgs e)
        {
            vScrollBar1.Minimum = Convert.ToInt32(ScrollBarYMinimum.Text);
            switch (vScrollBar1.Minimum)
            {
                case 0:
                    ScrollBarYMaximum.Items.Clear();
                    ScrollBarYMaximum.Items.Add("100");
                    ScrollBarYMaximum.Items.Add("300");
                    ScrollBarYMaximum.Items.Add("1000");
                    break;
                case 100:
                    ScrollBarYMaximum.Items.Clear();
                    ScrollBarYMaximum.Items.Add("300");
                    ScrollBarYMaximum.Items.Add("1000");
                    break;
                case 300:
                    ScrollBarYMaximum.Items.Clear();
                    ScrollBarYMaximum.Items.Add("1000");
                    break;
                case 1000:
                    ScrollBarYMinimum.Text = "0";
                    MessageBox.Show("Minimum değer 1000'den küçük olmalıdır", "Minimum Değer Hatası");
                    break;
            }
        }

        private void ScrollBarYMaximum_TextChanged(object sender, EventArgs e)
        {
            vScrollBar1.Maximum = Convert.ToInt32(ScrollBarYMaximum.Text);
        }

        private void VScroolBarText_TextChanged(object sender, EventArgs e)
        {
            if ((VScroolBarText.Text != "") && (Convert.ToInt32(VScroolBarText.Text) >= vScrollBar1.Minimum) && (Convert.ToInt32(VScroolBarText.Text) <= vScrollBar1.Maximum))
            {
                vScrollBar1.Value = Convert.ToInt32(VScroolBarText.Text);
            }
            else if ((VScroolBarText.TextLength > 0))
            {
                if ((Convert.ToInt32(VScroolBarText.Text) > vScrollBar1.Maximum))
                {
                    VScroolBarText.Text = vScrollBar1.Maximum.ToString();
                }
            }
        }

        private void HScroolBarText_TextChanged(object sender, EventArgs e)
        {
            if ((HScroolBarText.Text != "") && (Convert.ToInt32(HScroolBarText.Text) >= hScrollBar1.Minimum) && (Convert.ToInt32(HScroolBarText.Text) <= hScrollBar1.Maximum))
            {
                hScrollBar1.Value = Convert.ToInt32(HScroolBarText.Text);
            }
            else if ( (HScroolBarText.TextLength>0))
            {
                if((Convert.ToInt32(HScroolBarText.Text) > hScrollBar1.Maximum))
                {
                    HScroolBarText.Text = hScrollBar1.Maximum.ToString();
                }
            }
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            int ekh = map(hScrollBar1.Value, hScrollBar1.Minimum, hScrollBar1.Maximum, 0, 173);
            pictureBox6.Location = new Point(775 + ekh,pictureBox6.Location.Y);
            HScroolBarText.Text = hScrollBar1.Value.ToString();
            textBox4.Location = new Point(784 + ekh,textBox4.Location.Y);
            textBox4.Text = hScrollBar1.Value.ToString();
            ///textBox3.Text = hScrollBar1.Value.ToString();
            ///Color Change
            int color = map(hScrollBar1.Value, hScrollBar1.Minimum, hScrollBar1.Maximum, 0, 100);
            r = random.Next(0, 155 + color);
            g = random.Next(0, 155 + color);
            b = random.Next(0, 155 + color);
            pictureBox2.BackColor = Color.FromArgb(r, g, b);
            ///Color Change
            //////Size Change
            int boyutx = map(hScrollBar1.Value, hScrollBar1.Minimum, hScrollBar1.Maximum, 0, 300);
            int boyuty = map(vScrollBar1.Value, vScrollBar1.Minimum, vScrollBar1.Maximum, 0, 300);
            textBox2.Text = "Kare cisim boyutu %" + ((boyuty * boyutx) / 900);
            pictureBox2.Width = boyutx;
            pictureBox2.Location = new Point(150 - (boyutx / 2), pictureBox2.Location.Y);
            label5.Visible = false;
            label6.Text = "\nKaptın bu işi. Buradan seni izleyeceğim.";
            ///Size Change
        }

        private void vScrollBar1_ValueChanged(object sender, EventArgs e)
        {

            int ekv = map(vScrollBar1.Value, vScrollBar1.Minimum, vScrollBar1.Maximum, 0, 159);
            pictureBox5.Location = new Point(pictureBox5.Location.X, 143 + ekv);
            VScroolBarText.Text = vScrollBar1.Value.ToString();
            textBox3.Location=new Point(textBox3.Location.X,156+ekv);
            textBox3.Text = vScrollBar1.Value.ToString();
            ///Color Change
            int color = map(vScrollBar1.Value, vScrollBar1.Minimum, vScrollBar1.Maximum, 0, 100);
            r = random.Next(0, 155 + color);
            g = random.Next(0, 155 + color);
            b = random.Next(0, 155 + color);
            pictureBox2.BackColor = Color.FromArgb(r, g, b);
            ///Color Change
            ///Size Change
            int boyuty = map(vScrollBar1.Value, vScrollBar1.Minimum, vScrollBar1.Maximum, 0, 300);
            int boyutx = map(hScrollBar1.Value, hScrollBar1.Minimum, hScrollBar1.Maximum, 0, 300);
            textBox2.Text = "Kare cisim boyutu %" + ((boyuty * boyutx) / 900);
            pictureBox2.Height = boyuty;
            pictureBox2.Location = new Point(pictureBox2.Location.X, 150 - (boyuty / 2));
            label5.Visible = false;
            label6.Text = "\nKaptın bu işi. Buradan seni izleyeceğim.";
            ///Size Change
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            counter++;
           
            if(counter == 5)
            {
                label5.Text = "Uygulamanın amacı kaydırma çubukları ile\n karenin rengini ve boyunu değiştirmek";
            }
            if (counter == 12)
            {
                label5.Text = "Bunun için ise öncelikle x ve y ekseni için\n kaydırma çubuklarının aralıklarını seçmelesin";
            }
            if (counter == 19)
            {
                label5.Text = "Aralıkları belirlerken önce minimum seviyeyi\nsonra maksimum seviyeyi seçmelisin.";
            }
            if (counter == 25)
            {
                label5.Text = "\nBaşlamak için aralıkları belirlemeni bekliyorum.";
            }
            
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.tarikcelik8219.blogspot.com");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.youtube.com/channel/UCCacV0NG-2NVqFFQkh7jBGA");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.linkedin.com/in/tar%C4%B1k-%C3%A7elik-838a73177/");
        }

        public Form1()
        {
            InitializeComponent();
        }
        int map(int value, int InputMinimum, int InputMaximum, int OutputMinimum, int OutputMaximum)
        {
            return ((value - InputMinimum) * (OutputMaximum - OutputMinimum)) / ((InputMaximum - InputMinimum) + OutputMinimum);
        }
    }
}
