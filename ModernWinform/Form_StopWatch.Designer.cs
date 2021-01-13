
namespace ModernWinform
{
    partial class Form_StopWatch
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.second_text = new System.Windows.Forms.Label();
            this.hour_text = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.minute_text = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.millisecond_text = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.64935F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.35065F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 246F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 238F));
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.millisecond_text, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.second_text, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.minute_text, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.hour_text, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(81, 108);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(948, 184);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // second_text
            // 
            this.second_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.second_text.AutoSize = true;
            this.second_text.Font = new System.Drawing.Font("굴림", 60F);
            this.second_text.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.second_text.Location = new System.Drawing.Point(492, 13);
            this.second_text.Name = "second_text";
            this.second_text.Size = new System.Drawing.Size(188, 120);
            this.second_text.TabIndex = 2;
            this.second_text.Text = "00";
            this.second_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hour_text
            // 
            this.hour_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hour_text.AutoSize = true;
            this.hour_text.Font = new System.Drawing.Font("굴림", 60F);
            this.hour_text.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hour_text.Location = new System.Drawing.Point(58, 13);
            this.hour_text.Name = "hour_text";
            this.hour_text.Size = new System.Drawing.Size(119, 120);
            this.hour_text.TabIndex = 0;
            this.hour_text.Text = "0";
            this.hour_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("굴림", 15F);
            this.label5.ForeColor = System.Drawing.SystemColors.Menu;
            this.label5.Location = new System.Drawing.Point(712, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 37);
            this.label5.TabIndex = 5;
            this.label5.Text = "Millisecond";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("굴림", 15F);
            this.label6.ForeColor = System.Drawing.SystemColors.Menu;
            this.label6.Location = new System.Drawing.Point(466, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 37);
            this.label6.TabIndex = 6;
            this.label6.Text = "Second";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("굴림", 15F);
            this.label8.ForeColor = System.Drawing.SystemColors.Menu;
            this.label8.Location = new System.Drawing.Point(3, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(229, 37);
            this.label8.TabIndex = 8;
            this.label8.Text = "Hour";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.watch_tic);
            // 
            // minute_text
            // 
            this.minute_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minute_text.AutoSize = true;
            this.minute_text.Font = new System.Drawing.Font("굴림", 60F);
            this.minute_text.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minute_text.Location = new System.Drawing.Point(255, 13);
            this.minute_text.Name = "minute_text";
            this.minute_text.Size = new System.Drawing.Size(188, 120);
            this.minute_text.TabIndex = 1;
            this.minute_text.Text = "00";
            this.minute_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("굴림", 15F);
            this.label7.ForeColor = System.Drawing.SystemColors.Menu;
            this.label7.Location = new System.Drawing.Point(238, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 37);
            this.label7.TabIndex = 7;
            this.label7.Text = "Minute";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // millisecond_text
            // 
            this.millisecond_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.millisecond_text.AutoSize = true;
            this.millisecond_text.Font = new System.Drawing.Font("굴림", 60F);
            this.millisecond_text.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.millisecond_text.Location = new System.Drawing.Point(734, 13);
            this.millisecond_text.Name = "millisecond_text";
            this.millisecond_text.Size = new System.Drawing.Size(188, 120);
            this.millisecond_text.TabIndex = 3;
            this.millisecond_text.Text = "00";
            this.millisecond_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("굴림", 40F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(514, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 101);
            this.label1.TabIndex = 3;
            this.label1.Text = ":";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("굴림", 40F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(759, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 101);
            this.label2.TabIndex = 4;
            this.label2.Text = ":";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.Font = new System.Drawing.Font("굴림", 40F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(282, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 101);
            this.label3.TabIndex = 5;
            this.label3.Text = ":";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = global::ModernWinform.Properties.Resources.recurring_appointment_512;
            this.pictureBox2.Location = new System.Drawing.Point(665, 385);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(270, 280);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.reset_button_click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::ModernWinform.Properties.Resources.play_512;
            this.pictureBox1.Location = new System.Drawing.Point(188, 385);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form_StopWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1109, 790);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_StopWatch";
            this.Text = "Form_StopWatch";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label second_text;
        private System.Windows.Forms.Label hour_text;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label millisecond_text;
        private System.Windows.Forms.Label minute_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}