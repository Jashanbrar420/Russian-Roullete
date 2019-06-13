using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gunshot
{
    public partial class Form1 : Form
    {
        int x = 0, y = 0;
        int z = 2, cunt = 0;

        GenreateFire obj = new GenreateFire();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnload_Click(object sender, EventArgs e)
        {

        }

        private void btnreplay_Click(object sender, EventArgs e)
        {
            y = 0;
            x = 0;
            cunt = 0;
            btnfire.Enabled = true;
            pictureBox1.ImageLocation = @"C:\gungame\gun_PNG1385.png";
            pictureBox2.ImageLocation = @"C:\gungame\54revolver.png";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnfire_Click(object sender, EventArgs e)
        {
            if (x > 0)
            {
                y++;
                pictureBox1.ImageLocation = @"C:\gungame\Shot.gif";
                if (y == z && cunt < 2)
                {
                    cunt++;
                    System.Media.SoundPlayer player =
                        new System.Media.SoundPlayer(
                            @"C:\Users\brarj\source\repos\gunshot\9_mm_gunshot-mike-koenig-123:");
                    player.Play();
                    z = obj.fire();

                }
            }
        }

        private void btnspin_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\brarj\source\repos\gunshot\reload gun.wav");
                splayer.Play();
            }

            if (x > 0)
            {

                pictureBox2.ImageLocation = @"C:\Users\brarj\source\repos\gunshot\reload.jpg";
            }
            else
            {
                MessageBox.Show("Please Click on Load Bullet First");
            }

        }
    }
}