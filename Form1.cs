using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cnn_project
{
    public partial class Form1 : Form
    {
        MySqlConnection connection = new MySqlConnection("server=10.10.21.102;Database=medical_details;Uid=manager;Pwd=0000");

        public Form1()
        {
            InitializeComponent();
            cmb_patient.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            if (cmb_patient.SelectedItem == null)
                MessageBox.Show("환자 리스트를 선택해주세요");
            else if(tbx_medi.Text.Length == 0)
            {
                MessageBox.Show("투여 마취제 용량을 작성해주세요");
            }
            else
            {
                int dose = int.Parse(tbx_medi.Text);
                string insertQuery = $"INSERT INTO medical_records(anesthetic_dose) VALUES({dose})";
                connection.Open();
                MySqlCommand command = new MySqlCommand(insertQuery, connection);
                connection.Close();

                // form2로 이동
                this.Hide();
                Form2 timer_form = new Form2();
                timer_form.ShowDialog();
                this.Close();
            }
        }

        private void tbx_medi_TextChanged(object sender, EventArgs e)
        {

            // 현재 시각 뜸
            // string time = DateTime.Now.ToString("yy년 MM월 dd일 HH:mm:ss");
            
            // 마취제 양에 따라서 타이머 권장 시간을 작성
            if (tbx_medi.Text.Length != 0)
            {
                string recommendedTime = Convert.ToString(int.Parse(tbx_medi.Text) * 10);
                lbl_recommendedTime.Text = recommendedTime;
            }

            //string timeset = tbx_medi.Text; // 변환할 문자열
            //int num; // 정수로 변환된 값을 저장할 변수

            //if (int.TryParse(timeset, out num))
            //{
            //    // timeset 변수의 문자열이 정수로 변환되었을 경우에 실행되는 코드
            //    // num 변수에 정수 값이 할당됨
            //    Console.WriteLine("정수로 변환된 값: " + num);
            //}
            //else
            //{
            //    // timeset 변수의 문자열이 정수로 변환되지 않았을 경우에 실행되는 코드
            //    // 에러 처리 등을 수행할 수 있음
            //    Console.WriteLine("입력 문자열의 형식이 잘못되었습니다.");
            //}


            //TimeSpan ts = new TimeSpan(0, num * 10, 0);
            //DateTime time_num = Convert.ToDateTime(time);
            //DateTime timer_result = time_num + ts;
            //string timer_result2 = timer_result.ToString("yy년 MM월 dd일 HH:mm:ss");
        }

        private void tbx_medi_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자와 백스페이스를 제외한 나머지를 바로 처리
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        // form을 열었을 때 실행(콤보박스에 환자 리스트 추가)
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string selectQuery = "SELECT * FROM medical_details.patient_info";
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                MySqlDataReader table = cmd.ExecuteReader();

                while (table.Read())
                {
                    Console.WriteLine("환자번호: {0}, 이름: {1}, 성별: {2}", table["patient_id"], table["name"], table["gender"]);
                    cmb_patient.Items.Add(table["name"]);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("실패");
                Console.WriteLine(ex.ToString());
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}