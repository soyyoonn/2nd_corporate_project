﻿using WMPLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

using System.Net.Sockets;
using System.Net;
using System.Diagnostics;
using System.Drawing.Drawing2D;

using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Runtime.InteropServices.ComTypes;
using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;

using MySqlConnector;
using Mysqlx.Crud;
using Mysqlx.Notice;


namespace cnn_project
{
    public partial class Form2 : Form
    {
        TcpClient client = new TcpClient();
        NetworkStream stream1;
        NetworkStream stream2;
        Thread videoThread;
        Thread receiveThread;
        VideoCapture videoCapture;
        Mat mat = new Mat();

        WindowsMediaPlayer wmp;
        MySqlConnection connection = new MySqlConnection("server=10.10.21.102;Database=medical_details;Uid=manager;Pwd=0000");

        DateTime now; // 타이머가 동작할 목표 시간을 저장할 DateTime 변수 선언
        public static string Code { get; set; }
        string timer_minute = Code;
        bool music = false;
        bool warning = false;

        public Form2()
        {
            InitializeComponent();
            client.Connect("10.10.21.124", 9999);
            video_start();
            receive_start();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            now = DateTime.Now.AddMinutes(Int32.Parse($"{timer_minute}")); // 현재 시간에 타이머 분 수를 더하여 타이머가 동작할 목표 시간을 설정합니다.
            timer1.Start(); // 타이머를 시작합니다.

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
        private void receive_start()
        {
            receiveThread = new Thread(new ThreadStart(ReceiveSignal));  // ReceiveSignal 메서드를 스레드로 실행
            receiveThread.IsBackground = true;                           // 백그라운드 스레드로 설정

            receiveThread.Start();      // 스레드 시작
        }
        private void ReceiveSignal()
        {
            while (true)
            {
                try
                {
                    wmp = new WindowsMediaPlayer();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                // 서버로부터 데이터를 받음
                byte[] data = new byte[1024];
                NetworkStream stream2 = client.GetStream();
                int bytesRead = stream2.Read(data, 0, data.Length);
                string response = Encoding.UTF8.GetString(data, 0, bytesRead);
                switch (response)
                {
                    case "졸음감지":
                        //여기에 졸음감지 시그널이 들어옵니다
                        Console.WriteLine(response);

                        break;
                    case "졸음미감지":
                        //여기에 졸음미감지 시그널이 들어옵니다
                        Console.WriteLine(response);

                        break;
                }
                if (response == "졸음감지")
                {
                    //여기에 졸음감지 시그널이 들어옵니다
                    Console.WriteLine(response);
                    try
                    {
                        wmp.URL = @"C:\Users\Kiot\Downloads\alarm.mp3";
                        music = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }

                }
                else
                {
                    Console.WriteLine(response);
                    try
                    {
                        music = false;
                        wmp.controls.stop();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
        }
        private void video_start()
        {
            videoThread = new Thread(new ThreadStart(CameraCallback));
            videoThread.IsBackground = true;
            videoThread.Start();
        }

        private void CameraCallback()
        {

            stream1 = client.GetStream();
            videoCapture = new VideoCapture(0);

            while (true)
            {
                if (videoCapture.Read(mat))
                {
                    byte[] data = mat.ToBytes();
                    stream1.Write(BitConverter.GetBytes(data.Length), 0, 4);
                    stream1.Write(data, 0, data.Length);
                    //Console.WriteLine(data.Length);

                    Bitmap bitmap = BitmapConverter.ToBitmap(mat);
                    pictureBox1.Image = bitmap;

                }
                Thread.Sleep(50);
            }

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            wmp.controls.stop();

            videoThread.Abort();
            receiveThread.Abort();

            // 연결 종료
            stream1.Close();
            stream2.Close();
            client.Close();
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

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // 타이머 간격을 1000밀리초(1초)로 설정합니다.
            TimeSpan t = now - DateTime.Now; // 목표 시간과 현재 시간의 차이를 계산하여 TimeSpan 형태로 저장
            if (t > TimeSpan.Zero)
            {
                lbl_timer.Text = String.Format("{0}", t.ToString("hh':'mm':'ss"));  // 차이를 "hh:mm:ss" 형태의 문자열로 변환하여 textBox_timer 컨트롤에 출력합니다.
            }
            else
            {
                //wmp.controls.stop();
                videoThread.Abort();
                receiveThread.Abort();

                // 연결 종료
                stream1.Close();
                //stream2.Close();
                client.Close();

                timer1.Stop();
                button2.Visible = true;
                pictureBox2.Visible = true;
            }
        }

        private void btn_y_Click(object sender, EventArgs e)
        {
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
    }
}