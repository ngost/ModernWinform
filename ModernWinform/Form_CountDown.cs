using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;
namespace ModernWinform
{
    public partial class Form_CountDown : Form
    {

        static int dst_hour;
        static int dst_minute;
        static int dst_second;
        static bool is_btn_down = false;
        CancellationTokenSource ctoken;
        Stopwatch stopwatch;
        TimeSpan time_span;
        bool playmode = false;
        public Form_CountDown()
        {
            stopwatch = new Stopwatch();

            InitializeComponent();
            set_button_opacity();
            up_down_btn_hold_event_init();    
        }

        private void up_down_btn_hold_event_init()
        {
            second_up_img.MouseDown += MouseHold;
            second_up_img.MouseUp += MouseUp;
            second_down_img.MouseDown += MouseHold;
            second_down_img.MouseUp += MouseUp;

            minute_up_img.MouseDown += MouseHold;
            minute_up_img.MouseUp += MouseUp;
            minute_down_img.MouseDown += MouseHold;
            minute_down_img.MouseUp += MouseUp;

            hour_up_img.MouseDown += MouseHold;
            hour_up_img.MouseUp += MouseUp;
            hour_down_img.MouseDown += MouseHold;
            hour_down_img.MouseUp += MouseUp;
        }
        
        private async void MouseHold(Object obj, EventArgs args)
        {
            PictureBox m_img = (PictureBox) obj;
            is_btn_down = true;
            int delay_time = 100;

            //if mouse downed more 0.5sec
            //token으로 비동기 task 중지 가능하도록 만듬, 과정중에 예외처리 해야된다.
            ctoken = new CancellationTokenSource();
            try
            {
                await Task.Delay(500, ctoken.Token);
            }
            catch(Exception e)
            {
                //ex.Message
            }


            while (is_btn_down) {
                switch (m_img.Name)
                {
                    case "hour_down_img":
                        delay_time = 100;
                        hour_down_img_Click(this, null);
                        break;
                    case "hour_up_img":
                        delay_time = 100;
                        hour_up_img_Click(this, null);
                        break;
                    case "minute_down_img":
                        delay_time = 40;
                        minute_down_img_Click(this, null);
                        break;
                    case "minute_up_img":
                        delay_time = 40;
                        minute_up_img_Click(this, null);
                        break;
                    case "second_down_img":
                        delay_time = 20;
                        second_down_img_Click(this, null);
                        break;
                    case "second_up_img":
                        delay_time = 20;
                        second_up_img_Click(this, null);

                        break;
                }
                await Task.Delay(delay_time);
                syncTime();
            }
        }

        private void MouseUp(Object obj, EventArgs args)
        {
            is_btn_down = false;
            if (ctoken != null)
                ctoken.Cancel();

        }
        


        public void set_button_opacity()
        {
            second_up_img.Image = ChangeOpacity(second_up_img.Image, 0.5f);
            second_down_img.Image = ChangeOpacity(second_down_img.Image, 0.5f);
            minute_up_img.Image = ChangeOpacity(minute_up_img.Image, 0.5f);
            minute_down_img.Image = ChangeOpacity(minute_down_img.Image, 0.5f);
            hour_up_img.Image = ChangeOpacity(hour_up_img.Image, 0.5f);
            hour_down_img.Image = ChangeOpacity(hour_down_img.Image, 0.5f);
        }

        public Bitmap ChangeOpacity(Image img, float opacityvalue)
        {
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            Graphics graphics = Graphics.FromImage(bmp);
            ColorMatrix colormatrix = new ColorMatrix();
            colormatrix.Matrix33 = opacityvalue;
            ImageAttributes imgAttribute = new ImageAttributes();

            imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            graphics.DrawImage(img, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imgAttribute);
            graphics.Dispose();
            return bmp;
        }



        private void hour_up_img_Click(object sender, EventArgs e)
        {
            ++dst_hour;
            syncTime();
        }

        private void hour_down_img_Click(object sender, EventArgs e)
        {
            if(dst_hour!=0)
                --dst_hour;
            syncTime();
        }

        

        private void minute_up_img_Click(object sender, EventArgs e)
        {
            if (dst_minute >= 59)
            {
                dst_minute = 0;
            }
            else
            {
                ++dst_minute;
            }

            syncTime();
        }

        private void minute_down_img_Click(object sender, EventArgs e)
        {
            if (dst_minute < 1)
            {
                dst_minute = 59;
            }
            else
            {
                --dst_minute;
            }

            syncTime();
        }

        private void second_up_img_Click(object sender, EventArgs e)
        {
            if (dst_second >= 59)
            {
                dst_second = 0;
            }
            else{
                ++dst_second;
            }

            syncTime();
        }

        private void second_down_img_Click(object sender, EventArgs e)
        {
            if (dst_second < 1)
            {
                dst_second = 59;

            }
            else
            {
                --dst_second;
            }
            syncTime();
        }



        private void watch_tick(object sender, EventArgs e)
        {
            time_span = stopwatch.Elapsed;
            if ((time_span.Hours == dst_hour) && (time_span.Minutes == dst_minute) && (time_span.Seconds == dst_second))
            {
                reset_timer();
                alert();
                syncTime();
            }
            else
            {
                syncTime(time_span.Hours, time_span.Minutes, time_span.Seconds);
            }

        }

        private void play_btn_click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 500;

            if (playmode == false)
            {

                start_timer();
            }
            else
            {

                pause_timer();
            }
        }

        private void start_timer()
        {
            play_btn.Image = Properties.Resources.pause_512;
            timer1.Start();
            stopwatch.Start();
        }
        
        private void pause_timer()
        {
            play_btn.Image = Properties.Resources.play_512;
            timer1.Stop();
            stopwatch.Stop();
            
        }

        private void reset_timer()
        {
            play_btn.Image = Properties.Resources.play_512;
            timer1.Stop();
            stopwatch.Reset();
        }

        private void reset_btn_click(object sender, EventArgs e)
        {
            //reset
            /*dst_second = 0;
            dst_minute = 0;
            dst_hour = 0;*/
            syncTime();
        }

        private void syncTime()
        {
            hour_text.Text = String.Format("{0:0}", dst_hour);
            minute_text.Text = String.Format("{0:00}", dst_minute);
            second_text.Text = String.Format("{0:00}", dst_second);
        }

        private void syncTime(int hours,int minutes,int seconds)
        {
            int showed_seconds = dst_second - seconds;
            int showed_minutes = dst_minute - minutes;
            int showed_hours = dst_hour - hours;

            if (showed_seconds < 0)
            {
                showed_seconds = 60 + showed_seconds;
                showed_minutes -= 1;
            }

            if (showed_minutes < 0)
            {
                showed_minutes = 60 + showed_minutes;
                showed_hours -= 1;
            }
               

            hour_text.Text = String.Format("{0:0}", showed_hours);
            minute_text.Text = String.Format("{0:00}", showed_minutes);
            second_text.Text = String.Format("{0:00}", showed_seconds);
        }

        private void alert()
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.alert_sound);
            soundPlayer.Play();
        }
    }
}
