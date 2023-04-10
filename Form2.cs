using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp.Extensions;

using System.Threading;
using OpenCvSharp;
using OpenCvSharp.Extensions;


namespace cnn_project
{
    public partial class Form2 : Form
    {

        private readonly VideoCapture capture; 

        public Form2()
        {
            InitializeComponent();
            capture = new VideoCapture();
        }

        DateTime now; // 타이머가 동작할 목표 시간을 저장할 DateTime 변수 선언

        public static string Code { get; set; }
        string timer_minute = Code;

        private void Form2_Load(object sender, EventArgs e)
        {
            capture.Open(0, VideoCaptureAPIs.ANY);
            if (!capture.IsOpened())
            {
                Close();
                return;
            }

            //ClientSize = new System.Drawing.Size(capture.FrameWidth, capture.FrameHeight);
            backgroundWorker1.RunWorkerAsync();

            now = DateTime.Now.AddMinutes(Int32.Parse($"{timer_minute}")); // 현재 시간에 타이머 분 수를 더하여 타이머가 동작할 목표 시간을 설정합니다.
            timer1.Start(); // 타이머를 시작합니다.
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            backgroundWorker1.CancelAsync();
            capture.Dispose();
            timer1.Stop();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var bgWorker = (BackgroundWorker)sender;

            while (!bgWorker.CancellationPending)
            {
                using (var frameMat = capture.RetrieveMat())
                {
                    var frameBitmap = BitmapConverter.ToBitmap(frameMat);
                    bgWorker.ReportProgress(0, frameBitmap);
                }
                Thread.Sleep(100);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var frameBitmap = (Bitmap)e.UserState;
            pictureBox1.Image.Dispose();
            pictureBox1.Image = frameBitmap;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // 타이머 간격을 1000밀리초(1초)로 설정합니다.
            TimeSpan t = now - DateTime.Now; // 목표 시간과 현재 시간의 차이를 계산하여 TimeSpan 형태로 저장
            if (t > TimeSpan.Zero)
            {
                lbl_timer.Text = String.Format("{0}", t.ToString("hh':'mm':'ss"));  // 차이를 "hh:mm:ss" 형태의 문자열로 변환하여 textBox_timer 컨트롤에 출력합니다.
            }
            else
            {
                backgroundWorker1.CancelAsync();
                capture.Dispose();
                timer1.Stop();
                button2.Visible = true;
                pictureBox2.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // form2로 이동
            this.Hide();
            Form1 first_form = new Form1();
            first_form.ShowDialog();
            this.Close();

            pictureBox2.Visible = false;
            button2.Visible = false;
        }
    }
}
