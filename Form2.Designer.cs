namespace cnn_project
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_timer = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new Guna.UI2.WinForms.Guna2Button();
<<<<<<< HEAD
            this.btn_cancel = new Guna.UI2.WinForms.Guna2Button();
=======
            this.button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.test = new System.Windows.Forms.Label();
            this.btn_y = new Guna.UI2.WinForms.Guna2Button();
            this.btn_n = new Guna.UI2.WinForms.Guna2Button();
>>>>>>> cd5f839bf6dd13fe251cb2748d896934b803178e
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("경기천년제목B Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(36, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "타이머";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("경기천년제목B Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(36, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "졸음 인식";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // lbl_timer
            // 
            this.lbl_timer.Font = new System.Drawing.Font("경기천년제목B Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_timer.Location = new System.Drawing.Point(123, 271);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(98, 16);
            this.lbl_timer.TabIndex = 4;
            this.lbl_timer.Text = "실행 시간";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::cnn_project.Properties.Resources.잠;
            this.pictureBox2.Location = new System.Drawing.Point(-4, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(486, 565);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::cnn_project.Properties.Resources._17;
            this.pictureBox1.Location = new System.Drawing.Point(39, 79);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Animated = true;
            this.button2.AutoRoundedCorners = true;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.BorderRadius = 17;
            this.button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.button2.HoverState.CustomBorderColor = System.Drawing.Color.Blue;
            this.button2.HoverState.FillColor = System.Drawing.Color.Blue;
<<<<<<< HEAD
            this.button2.Location = new System.Drawing.Point(197, 390);
=======
            this.button2.Location = new System.Drawing.Point(204, 438);
>>>>>>> cd5f839bf6dd13fe251cb2748d896934b803178e
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 37);
            this.button2.TabIndex = 23;
            this.button2.Text = "처음화면";
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
<<<<<<< HEAD
            // btn_cancel
            // 
            this.btn_cancel.Animated = true;
            this.btn_cancel.AutoRoundedCorners = true;
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cancel.BorderRadius = 17;
            this.btn_cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.btn_cancel.HoverState.CustomBorderColor = System.Drawing.Color.Blue;
            this.btn_cancel.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btn_cancel.Location = new System.Drawing.Point(197, 472);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(76, 37);
            this.btn_cancel.TabIndex = 24;
            this.btn_cancel.Text = "취소";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
=======
            // button1
            // 
            this.button1.Animated = true;
            this.button1.AutoRoundedCorners = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.BorderRadius = 13;
            this.button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.button1.HoverState.CustomBorderColor = System.Drawing.Color.Blue;
            this.button1.HoverState.FillColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(368, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 28);
            this.button1.TabIndex = 24;
            this.button1.Text = "경고음";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("경기천년제목B Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(36, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "숫자계산";
            // 
            // test
            // 
            this.test.Font = new System.Drawing.Font("경기천년제목B Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.test.Location = new System.Drawing.Point(123, 319);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(122, 16);
            this.test.TabIndex = 26;
            this.test.Text = "랜덤 문제";
            // 
            // btn_y
            // 
            this.btn_y.Animated = true;
            this.btn_y.AutoRoundedCorners = true;
            this.btn_y.BackColor = System.Drawing.Color.Transparent;
            this.btn_y.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_y.BorderColor = System.Drawing.Color.Transparent;
            this.btn_y.BorderRadius = 17;
            this.btn_y.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_y.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_y.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_y.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_y.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_y.ForeColor = System.Drawing.Color.White;
            this.btn_y.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.btn_y.HoverState.CustomBorderColor = System.Drawing.Color.Blue;
            this.btn_y.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btn_y.Location = new System.Drawing.Point(116, 354);
            this.btn_y.Name = "btn_y";
            this.btn_y.Size = new System.Drawing.Size(61, 36);
            this.btn_y.TabIndex = 27;
            this.btn_y.Text = "예";
            this.btn_y.Click += new System.EventHandler(this.btn_y_Click);
            // 
            // btn_n
            // 
            this.btn_n.Animated = true;
            this.btn_n.AutoRoundedCorners = true;
            this.btn_n.BackColor = System.Drawing.Color.Transparent;
            this.btn_n.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_n.BorderRadius = 17;
            this.btn_n.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_n.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_n.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_n.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_n.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_n.ForeColor = System.Drawing.Color.White;
            this.btn_n.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.btn_n.HoverState.CustomBorderColor = System.Drawing.Color.Blue;
            this.btn_n.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btn_n.Location = new System.Drawing.Point(192, 354);
            this.btn_n.Name = "btn_n";
            this.btn_n.Size = new System.Drawing.Size(65, 36);
            this.btn_n.TabIndex = 28;
            this.btn_n.Text = "아니오";
            this.btn_n.Click += new System.EventHandler(this.btn_n_Click);
>>>>>>> cd5f839bf6dd13fe251cb2748d896934b803178e
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(474, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_n);
            this.Controls.Add(this.btn_y);
            this.Controls.Add(this.test);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.PictureBox pictureBox2;
        //private System.Windows.Forms.Button button21;
        private Guna.UI2.WinForms.Guna2Button button2;
<<<<<<< HEAD
        private Guna.UI2.WinForms.Guna2Button btn_cancel;
=======
        private Guna.UI2.WinForms.Guna2Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label test;
        private Guna.UI2.WinForms.Guna2Button btn_y;
        private Guna.UI2.WinForms.Guna2Button btn_n;
>>>>>>> cd5f839bf6dd13fe251cb2748d896934b803178e
    }
}