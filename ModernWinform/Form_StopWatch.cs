using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ModernWinform
{
    public partial class Form_StopWatch : Form
    {

        Boolean playmode = false;
        int millisecond = 0;
        int second = 0;
        int minute = 0;
        Stopwatch stopwatch;
        TimeSpan timeSpan;

        public Form_StopWatch()
        {
            stopwatch = new Stopwatch();
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //play btn

            timer1.Enabled = true;
            timer1.Interval = 50;


            if(playmode == false)
            {

                start_time();
            }
            else
            {

                pause_time();
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void start_time()
        {
            pictureBox1.Image = Properties.Resources.pause_512;
            playmode = true;
            timer1.Start();
            stopwatch.Start();
        }
        private void pause_time()
        {
            pictureBox1.Image = Properties.Resources.play_512;
            playmode = false;
            timer1.Stop();
            stopwatch.Stop();
        }

        private void reset_button_click(object sender, EventArgs e)
        {
            playmode = false;
            pictureBox1.Image = Properties.Resources.play_512;
            timer1.Stop();
            stopwatch.Reset();
            syncTime(0, 0, 0, 0);
        }

        private void watch_tic(object sender, EventArgs e)
        {
            timeSpan = stopwatch.Elapsed;

            syncTime(timeSpan.Hours,timeSpan.Minutes,timeSpan.Seconds,timeSpan.Milliseconds/10);
        }
        private void syncTime(int hour, int minute,int second, int msc)
        {

            millisecond_text.Text = String.Format("{0:00}", msc);
            second_text.Text = String.Format("{0:00}", second);
            minute_text.Text = String.Format("{0:00}", minute);
            hour_text.Text = hour.ToString();
        }

        
    }
}
