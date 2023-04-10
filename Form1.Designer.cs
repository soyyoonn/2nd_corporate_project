namespace cnn_project
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_go = new System.Windows.Forms.Button();
            this.lbl_recommendedTime = new System.Windows.Forms.Label();
            this.tbx_medi = new System.Windows.Forms.TextBox();
            this.cmb_patient = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_timer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "환자명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "마취제 용량\r\n(숫자 입력요망)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "권장시간";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "mg";
            // 
            // btn_go
            // 
            this.btn_go.Location = new System.Drawing.Point(202, 312);
            this.btn_go.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(86, 29);
            this.btn_go.TabIndex = 8;
            this.btn_go.Text = "실행";
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // lbl_recommendedTime
            // 
            this.lbl_recommendedTime.Location = new System.Drawing.Point(214, 211);
            this.lbl_recommendedTime.Name = "lbl_recommendedTime";
            this.lbl_recommendedTime.Size = new System.Drawing.Size(141, 15);
            this.lbl_recommendedTime.TabIndex = 9;
            this.lbl_recommendedTime.Text = "miniute";
            this.lbl_recommendedTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbx_medi
            // 
            this.tbx_medi.Location = new System.Drawing.Point(216, 152);
            this.tbx_medi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_medi.Name = "tbx_medi";
            this.tbx_medi.Size = new System.Drawing.Size(138, 25);
            this.tbx_medi.TabIndex = 12;
            this.tbx_medi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbx_medi.TextChanged += new System.EventHandler(this.tbx_medi_TextChanged);
            this.tbx_medi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_medi_KeyPress);
            // 
            // cmb_patient
            // 
            this.cmb_patient.FormattingEnabled = true;
            this.cmb_patient.Location = new System.Drawing.Point(216, 99);
            this.cmb_patient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_patient.Name = "cmb_patient";
            this.cmb_patient.Size = new System.Drawing.Size(138, 23);
            this.cmb_patient.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "졸음경보기";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "타이머";
            // 
            // tbx_timer
            // 
            this.tbx_timer.Location = new System.Drawing.Point(216, 249);
            this.tbx_timer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_timer.Name = "tbx_timer";
            this.tbx_timer.Size = new System.Drawing.Size(138, 25);
            this.tbx_timer.TabIndex = 19;
            this.tbx_timer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbx_timer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_timer_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "분";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(361, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "분";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 412);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbx_timer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_patient);
            this.Controls.Add(this.tbx_medi);
            this.Controls.Add(this.lbl_recommendedTime);
            this.Controls.Add(this.btn_go);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.Label lbl_recommendedTime;
        private System.Windows.Forms.TextBox tbx_medi;
        private System.Windows.Forms.ComboBox cmb_patient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_timer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

