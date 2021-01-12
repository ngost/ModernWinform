
namespace ModernWinform
{
    partial class Form_Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button_countdown = new System.Windows.Forms.Button();
            this.button_stopwatch = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_child_form = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.minimize_box = new System.Windows.Forms.PictureBox();
            this.maximize_box = new System.Windows.Forms.PictureBox();
            this.exit_box = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_child_form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximize_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_box)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.OrangeRed;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.minimize_box);
            this.panel3.Controls.Add(this.maximize_box);
            this.panel3.Controls.Add(this.exit_box);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1404, 27);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_pannel_mouse_down);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(25, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(1);
            this.label3.Size = new System.Drawing.Size(171, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Simple StopWatch";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button_countdown);
            this.panel1.Controls.Add(this.button_stopwatch);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 846);
            this.panel1.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(0, 324);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(295, 86);
            this.button5.TabIndex = 7;
            this.button5.Text = "Help";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button_help_click);
            // 
            // button_countdown
            // 
            this.button_countdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.button_countdown.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_countdown.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_countdown.FlatAppearance.BorderSize = 0;
            this.button_countdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_countdown.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_countdown.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_countdown.Location = new System.Drawing.Point(0, 238);
            this.button_countdown.Name = "button_countdown";
            this.button_countdown.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_countdown.Size = new System.Drawing.Size(295, 86);
            this.button_countdown.TabIndex = 6;
            this.button_countdown.Text = "Count Down";
            this.button_countdown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_countdown.UseVisualStyleBackColor = false;
            this.button_countdown.Click += new System.EventHandler(this.button_countdown_click);
            // 
            // button_stopwatch
            // 
            this.button_stopwatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.button_stopwatch.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_stopwatch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_stopwatch.FlatAppearance.BorderSize = 0;
            this.button_stopwatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_stopwatch.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_stopwatch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_stopwatch.Location = new System.Drawing.Point(0, 152);
            this.button_stopwatch.Name = "button_stopwatch";
            this.button_stopwatch.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_stopwatch.Size = new System.Drawing.Size(295, 86);
            this.button_stopwatch.TabIndex = 5;
            this.button_stopwatch.Text = "Stop Watch";
            this.button_stopwatch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_stopwatch.UseVisualStyleBackColor = false;
            this.button_stopwatch.Click += new System.EventHandler(this.button_stopwatch_click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(0, 66);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(295, 86);
            this.button2.TabIndex = 4;
            this.button2.Text = "Home";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_home_click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 66);
            this.label2.TabIndex = 3;
            this.label2.Text = "Menu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_child_form
            // 
            this.panel_child_form.Controls.Add(this.label5);
            this.panel_child_form.Controls.Add(this.label4);
            this.panel_child_form.Controls.Add(this.pictureBox1);
            this.panel_child_form.Controls.Add(this.label1);
            this.panel_child_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_child_form.Location = new System.Drawing.Point(295, 27);
            this.panel_child_form.Name = "panel_child_form";
            this.panel_child_form.Size = new System.Drawing.Size(1109, 846);
            this.panel_child_form.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(373, 719);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(383, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Made by easyJin, South Korea";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(405, 774);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(314, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contect : hm5207@gmail.com";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(193, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(745, 80);
            this.label1.TabIndex = 1;
            this.label1.Text = "Simple StopWatch";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::ModernWinform.Properties.Resources.image_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(412, 262);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::ModernWinform.Properties.Resources.image_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(1);
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // minimize_box
            // 
            this.minimize_box.BackColor = System.Drawing.Color.Transparent;
            this.minimize_box.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimize_box.Image = global::ModernWinform.Properties.Resources.minimize_window_128;
            this.minimize_box.Location = new System.Drawing.Point(1327, 0);
            this.minimize_box.Name = "minimize_box";
            this.minimize_box.Padding = new System.Windows.Forms.Padding(5);
            this.minimize_box.Size = new System.Drawing.Size(25, 25);
            this.minimize_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimize_box.TabIndex = 2;
            this.minimize_box.TabStop = false;
            this.minimize_box.Click += new System.EventHandler(this.minimize_box_Click);
            // 
            // maximize_box
            // 
            this.maximize_box.BackColor = System.Drawing.Color.Transparent;
            this.maximize_box.Dock = System.Windows.Forms.DockStyle.Right;
            this.maximize_box.Image = global::ModernWinform.Properties.Resources.maximize_window_128;
            this.maximize_box.Location = new System.Drawing.Point(1352, 0);
            this.maximize_box.Name = "maximize_box";
            this.maximize_box.Padding = new System.Windows.Forms.Padding(5);
            this.maximize_box.Size = new System.Drawing.Size(25, 25);
            this.maximize_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maximize_box.TabIndex = 1;
            this.maximize_box.TabStop = false;
            this.maximize_box.Click += new System.EventHandler(this.maximize_click);
            // 
            // exit_box
            // 
            this.exit_box.BackColor = System.Drawing.Color.Transparent;
            this.exit_box.Dock = System.Windows.Forms.DockStyle.Right;
            this.exit_box.Image = global::ModernWinform.Properties.Resources.x_mark_5_128;
            this.exit_box.Location = new System.Drawing.Point(1377, 0);
            this.exit_box.Name = "exit_box";
            this.exit_box.Padding = new System.Windows.Forms.Padding(5);
            this.exit_box.Size = new System.Drawing.Size(25, 25);
            this.exit_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit_box.TabIndex = 0;
            this.exit_box.TabStop = false;
            this.exit_box.Click += new System.EventHandler(this.exit_box_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1404, 873);
            this.Controls.Add(this.panel_child_form);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("굴림", 15F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1300, 750);
            this.Name = "Form_Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel_child_form.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximize_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button_countdown;
        private System.Windows.Forms.Button button_stopwatch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox exit_box;
        private System.Windows.Forms.PictureBox minimize_box;
        private System.Windows.Forms.PictureBox maximize_box;
        private System.Windows.Forms.Panel panel_child_form;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

