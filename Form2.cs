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
using System.Media;
using WMPLib;
using MySqlConnector;
using Mysqlx.Crud;
using System.Security.Cryptography;
using Mysqlx.Notice;


namespace cnn_project
{
    public partial class Form2 : Form
    {
        MySqlConnection connection = new MySqlConnection("server=10.10.21.102;Database=medical_details;Uid=manager;Pwd=0000");
        private readonly VideoCapture capture;
        WindowsMediaPlayer wmp;
        DateTime now; // 타이머가 동작할 목표 시간을 저장할 DateTime 변수 선언
        //DateTime yesButtonClickTime; // 마지막으로 버튼이 클릭된 시간
        //DateTime noButtonClickTime;
        //private const int MAX_CLICK_INTERVAL = 3000;
        public static string Code { get; set; }
        string timer_minute = Code;
        bool music = false;
        bool warning = false;

        public Form2()
        {
            InitializeComponent();
            capture = new VideoCapture();
        }

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
            //timer2.Start();
            //yesButtonClickTime = DateTime.Now; // 폼이 로드될 때 버튼 누르는 시간 현재 시간으로 초기화
            //noButtonClickTime = DateTime.Now;

            try
            {
                string selectQuery = "SELECT * FROM medical_details.number_test ORDER BY RAND() LIMIT 1";
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                MySqlDataReader table = cmd.ExecuteReader();

                while (table.Read())
                {
                    Console.WriteLine("번호: {0}, 문제: {1}", table["num"], table["test"]);
                    test.Text = table["test"].ToString();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("실패");
                Console.WriteLine(ex.ToString());
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            backgroundWorker1.CancelAsync();
            capture.Dispose();
            timer1.Stop();
            timer2.Stop();
            wmp.controls.stop();
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
                wmp.controls.stop();
                backgroundWorker1.CancelAsync();
                capture.Dispose();
                timer1.Stop();
                button2.Visible = true;
                pictureBox2.Visible = true;
            }
        }

        // 경고음 버튼 누르면 소리나고, 다시 누르면 꺼짐.
        private void button1_Click(object sender, EventArgs e)
        {
            if (music == false)
            {
                wmp = new WindowsMediaPlayer();
                wmp.URL = @"C:\Users\Kiot\Downloads\alarm.mp3";
                music = true;
            }
            else
            {
                music = false;
                wmp.controls.stop();
            }
        }

        // 첫번째 화면으로 돌아감
        private void button2_Click_1(object sender, EventArgs e)
        {
            // form1로 이동
            this.Hide();
            Form1 first_form = new Form1();
            first_form.ShowDialog();
            this.Close();

            pictureBox2.Visible = false;
            button2.Visible = false;
        }

        private void btn_y_Click(object sender, EventArgs e)
        {
            // 버튼이 클릭될 때마다 현재 시간으로 갱신
            //yesButtonClickTime = DateTime.Now;

            try
            {
                string selectQuery = "SELECT * FROM medical_details.number_test ORDER BY RAND() LIMIT 1";
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                MySqlDataReader table = cmd.ExecuteReader();

                while (table.Read())
                {
                    Console.WriteLine("번호: {0}, 문제: {1}", table["num"], table["test"]);
                    test.Text = table["test"].ToString();
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("실패");
                Console.WriteLine(ex.ToString());
            }

            if (warning == true)
            {
                warning = false;
                wmp.controls.stop();

                try
                {
                    string selectQuery = "SELECT * FROM medical_details.number_test ORDER BY RAND() LIMIT 1";
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                    MySqlDataReader table = cmd.ExecuteReader();

                    while (table.Read())
                    {
                        Console.WriteLine("번호: {0}, 문제: {1}", table["num"], table["test"]);
                        test.Text = table["test"].ToString();
                    }
                    connection.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("실패");
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        private void btn_n_Click(object sender, EventArgs e)
        {
            // 버튼이 클릭될 때마다 현재 시간으로 갱신
            //noButtonClickTime = DateTime.Now;

            if (warning == false)
            {
                wmp = new WindowsMediaPlayer();
                wmp.URL = @"C:\Users\Kiot\Downloads\alarm.mp3";
                warning = true;

            }

            else
            {
                warning = false;
                wmp.controls.stop();
            }
        }

        //private void timer2_Tick(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        wmp = new WindowsMediaPlayer();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.ToString());
        //    }

        //    // 타이머가 주기적으로 실행되며, 현재 시간과 마지막으로 버튼이 클릭된 시간의 차이를 계산
        //    TimeSpan time = DateTime.Now - yesButtonClickTime;
        //    TimeSpan time2 = DateTime.Now - noButtonClickTime;

        //    if (time.TotalMilliseconds > MAX_CLICK_INTERVAL)
        //    {
        //        // 버튼이 일정 시간 이상 눌리지 않은 경우 경고음 출력
        //        try
        //        {
        //            wmp.URL = @"C:/Users/Kiot/source/repos/2nd_corporate_project/Resources/alarm.mp3";
        //            warning = true;
        //            Console.WriteLine("경고음 나오냐");

        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.ToString());
        //        }
                
        //    }
        //    else if (time2.TotalMilliseconds > MAX_CLICK_INTERVAL)
        //    {
        //        // 버튼이 일정 시간 이상 눌리지 않은 경우 경고음 출력
        //        try
        //        {
        //            wmp.URL = @"C:/Users/Kiot/source/repos/2nd_corporate_project/Resources/alarm.mp3";
        //            warning = true;
        //            Console.WriteLine("경고음 나오냐");
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.ToString());
        //        }
        //    }
        //    else 
        //    {
        //        try
        //        {
        //            warning = false;
        //            wmp.controls.stop();
        //            Console.WriteLine("경고음 멈췄냐");
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.ToString());
        //        }
        //    }
        //}
    }
}
