using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;

namespace ModernWinform
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "hellow World!";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void header_pannel_mouse_down(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112,0xf012,0);

        }


        private void exit_box_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximize_click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }

        }

        private void minimize_box_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_child_form.Controls.Add(childForm);
            panel_child_form.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }



        private void button_countdown_click(object sender, EventArgs e)
        {
            play_click_sound();
            openChildForm(new Form_CountDown());
        }

        private void button_stopwatch_click(object sender, EventArgs e)
        {
            play_click_sound();
            openChildForm(new Form_StopWatch());
        }

        private void button_home_click(object sender, EventArgs e)
        {
            play_click_sound();
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }

        private void button_help_click(object sender, EventArgs e)
        {
            play_click_sound();
            openChildForm(new Form_Help());
        }

        private void play_click_sound()
        {

            new SoundPlayer(Properties.Resources.button_default).Play();
        }
    }
}
