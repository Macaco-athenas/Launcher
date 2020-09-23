using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LauncherLA
{
    public partial class LauncherLA : Form
    {
        int mov;
        int movX;
        int movY;
        public LauncherLA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("ts3client_win64");
            if (processes.Length <= 0)
            {
                System.Diagnostics.Process.Start($"fivem://connect/athenasrp.cf"); System.Diagnostics.Process.Start($"ts3server://athenasrp.meuts3.com");
                this.Close();
            }
            else
            {
                System.Diagnostics.Process.Start($"fivem://connect/athenasrp.cf");
                this.Close();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($"https://www.instagram.com/_losangelesrp_/");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($"https://bit.ly/2Lk4vDP");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($"https://discord.gg/MZhWBQa");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LauncherLA_Load(object sender, EventArgs e)
        {

        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
        
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }   
}
