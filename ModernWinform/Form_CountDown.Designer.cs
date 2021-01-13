
namespace ModernWinform
{
    partial class Form_CountDown
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hour_text = new System.Windows.Forms.Label();
            this.minute_text = new System.Windows.Forms.Label();
            this.second_text = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.hour_up_img = new System.Windows.Forms.PictureBox();
            this.hour_down_img = new System.Windows.Forms.PictureBox();
            this.reset_btn = new System.Windows.Forms.PictureBox();
            this.play_btn = new System.Windows.Forms.PictureBox();
            this.minute_up_img = new System.Windows.Forms.PictureBox();
            this.minute_down_img = new System.Windows.Forms.PictureBox();
            this.second_up_img = new System.Windows.Forms.PictureBox();
            this.second_down_img = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hour_up_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hour_down_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reset_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minute_up_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minute_down_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.second_up_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.second_down_img)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.Font = new System.Drawing.Font("굴림", 40F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(344, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 101);
            this.label3.TabIndex = 11;
            this.label3.Text = ":";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("굴림", 40F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(671, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 101);
            this.label1.TabIndex = 9;
            this.label1.Text = ":";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hour_text
            // 
            this.hour_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hour_text.AutoSize = true;
            this.hour_text.Font = new System.Drawing.Font("굴림", 60F);
            this.hour_text.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hour_text.Location = new System.Drawing.Point(93, 13);
            this.hour_text.Name = "hour_text";
            this.hour_text.Size = new System.Drawing.Size(119, 120);
            this.hour_text.TabIndex = 0;
            this.hour_text.Text = "0";
            this.hour_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minute_text
            // 
            this.minute_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minute_text.AutoSize = true;
            this.minute_text.Font = new System.Drawing.Font("굴림", 60F);
            this.minute_text.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minute_text.Location = new System.Drawing.Point(374, 13);
            this.minute_text.Name = "minute_text";
            this.minute_text.Size = new System.Drawing.Size(188, 120);
            this.minute_text.TabIndex = 1;
            this.minute_text.Text = "00";
            this.minute_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // second_text
            // 
            this.second_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.second_text.AutoSize = true;
            this.second_text.Font = new System.Drawing.Font("굴림", 60F);
            this.second_text.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.second_text.Location = new System.Drawing.Point(695, 13);
            this.second_text.Name = "second_text";
            this.second_text.Size = new System.Drawing.Size(188, 120);
            this.second_text.TabIndex = 2;
            this.second_text.Text = "00";
            this.second_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("굴림", 15F);
            this.label6.ForeColor = System.Drawing.SystemColors.Menu;
            this.label6.Location = new System.Drawing.Point(634, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(311, 37);
            this.label6.TabIndex = 6;
            this.label6.Text = "Second";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("굴림", 15F);
            this.label7.ForeColor = System.Drawing.SystemColors.Menu;
            this.label7.Location = new System.Drawing.Point(309, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(319, 37);
            this.label7.TabIndex = 7;
            this.label7.Text = "Minute";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("굴림", 15F);
            this.label8.ForeColor = System.Drawing.SystemColors.Menu;
            this.label8.Location = new System.Drawing.Point(3, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(300, 37);
            this.label8.TabIndex = 8;
            this.label8.Text = "Hour";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.50863F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.49137F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 316F));
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.second_text, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.minute_text, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.hour_text, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(69, 117);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(948, 184);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // hour_up_img
            // 
            this.hour_up_img.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hour_up_img.Image = global::ModernWinform.Properties.Resources.arrow_up1;
            this.hour_up_img.Location = new System.Drawing.Point(167, 61);
            this.hour_up_img.Name = "hour_up_img";
            this.hour_up_img.Size = new System.Drawing.Size(100, 50);
            this.hour_up_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hour_up_img.TabIndex = 13;
            this.hour_up_img.TabStop = false;
            this.hour_up_img.Click += new System.EventHandler(this.hour_up_img_Click);
            // 
            // hour_down_img
            // 
            this.hour_down_img.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hour_down_img.Image = global::ModernWinform.Properties.Resources.arrow_down;
            this.hour_down_img.Location = new System.Drawing.Point(167, 304);
            this.hour_down_img.Name = "hour_down_img";
            this.hour_down_img.Size = new System.Drawing.Size(100, 50);
            this.hour_down_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hour_down_img.TabIndex = 12;
            this.hour_down_img.TabStop = false;
            this.hour_down_img.Click += new System.EventHandler(this.hour_down_img_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.reset_btn.Image = global::ModernWinform.Properties.Resources.recurring_appointment_512;
            this.reset_btn.Location = new System.Drawing.Point(653, 394);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(270, 280);
            this.reset_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reset_btn.TabIndex = 8;
            this.reset_btn.TabStop = false;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_click);
            // 
            // play_btn
            // 
            this.play_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.play_btn.Image = global::ModernWinform.Properties.Resources.play_512;
            this.play_btn.Location = new System.Drawing.Point(176, 394);
            this.play_btn.Name = "play_btn";
            this.play_btn.Size = new System.Drawing.Size(270, 280);
            this.play_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.play_btn.TabIndex = 7;
            this.play_btn.TabStop = false;
            this.play_btn.Click += new System.EventHandler(this.play_btn_click);
            // 
            // minute_up_img
            // 
            this.minute_up_img.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.minute_up_img.Image = global::ModernWinform.Properties.Resources.arrow_up1;
            this.minute_up_img.Location = new System.Drawing.Point(488, 61);
            this.minute_up_img.Name = "minute_up_img";
            this.minute_up_img.Size = new System.Drawing.Size(100, 50);
            this.minute_up_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minute_up_img.TabIndex = 15;
            this.minute_up_img.TabStop = false;
            this.minute_up_img.Click += new System.EventHandler(this.minute_up_img_Click);
            // 
            // minute_down_img
            // 
            this.minute_down_img.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.minute_down_img.Image = global::ModernWinform.Properties.Resources.arrow_down;
            this.minute_down_img.Location = new System.Drawing.Point(488, 304);
            this.minute_down_img.Name = "minute_down_img";
            this.minute_down_img.Size = new System.Drawing.Size(100, 50);
            this.minute_down_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minute_down_img.TabIndex = 14;
            this.minute_down_img.TabStop = false;
            this.minute_down_img.Click += new System.EventHandler(this.minute_down_img_Click);
            // 
            // second_up_img
            // 
            this.second_up_img.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.second_up_img.Image = global::ModernWinform.Properties.Resources.arrow_up1;
            this.second_up_img.Location = new System.Drawing.Point(806, 61);
            this.second_up_img.Name = "second_up_img";
            this.second_up_img.Size = new System.Drawing.Size(100, 50);
            this.second_up_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.second_up_img.TabIndex = 17;
            this.second_up_img.TabStop = false;
            this.second_up_img.Click += new System.EventHandler(this.second_up_img_Click);
            // 
            // second_down_img
            // 
            this.second_down_img.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.second_down_img.Image = global::ModernWinform.Properties.Resources.arrow_down;
            this.second_down_img.Location = new System.Drawing.Point(806, 304);
            this.second_down_img.Name = "second_down_img";
            this.second_down_img.Size = new System.Drawing.Size(100, 50);
            this.second_down_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.second_down_img.TabIndex = 16;
            this.second_down_img.TabStop = false;
            this.second_down_img.Click += new System.EventHandler(this.second_down_img_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.watch_tick);
            // 
            // Form_CountDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1087, 790);
            this.Controls.Add(this.second_up_img);
            this.Controls.Add(this.second_down_img);
            this.Controls.Add(this.minute_up_img);
            this.Controls.Add(this.minute_down_img);
            this.Controls.Add(this.hour_up_img);
            this.Controls.Add(this.hour_down_img);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.play_btn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_CountDown";
            this.Text = "Form_CountDown";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hour_up_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hour_down_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reset_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minute_up_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minute_down_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.second_up_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.second_down_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox reset_btn;
        private System.Windows.Forms.PictureBox play_btn;
        private System.Windows.Forms.Label hour_text;
        private System.Windows.Forms.Label minute_text;
        private System.Windows.Forms.Label second_text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox hour_down_img;
        private System.Windows.Forms.PictureBox hour_up_img;
        private System.Windows.Forms.PictureBox minute_up_img;
        private System.Windows.Forms.PictureBox minute_down_img;
        private System.Windows.Forms.PictureBox second_up_img;
        private System.Windows.Forms.PictureBox second_down_img;
        private System.Windows.Forms.Timer timer1;
    }
}