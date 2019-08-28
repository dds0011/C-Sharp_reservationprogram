using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Web;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {


        MySqlConnection conn =
        new MySqlConnection("Server=localhost;Database=hwanja_db;Uid=root;Pwd=1234;");

        MySqlDataAdapter msc;


        public Form1()
        {
            InitializeComponent();

        }

        //진료의
        private string[] doctor0 = { "정상수", "김철수", "김갑수", "김수가" };
        private string[] doctor1 = { "오예수", "오부처", "오알라", "오하늘" };
        private string[] doctor2 = { "강철구", "조순철", "금지철", "서한지" };
        private string[] doctor3 = { "차수미", "장덕철", "장제인", "추성희" };
        private string[] doctor4 = { "박수소", "이세희", "이고진", "진지혜" };
        private string[] doctor5 = { "한곡의", "한고예", "마동철", "마박세" };
        private string[] doctor6 = { "이승철", "성재진", "이재진", "나진자" };
        private string[] doctor7 = { "나선추", "추재준", "하선호", "하진주" };
        private string[] doctor8 = { "오바람", "오아람", "성후진", "강신후" };
        private string[] doctor9 = { "강도철", "한오루", "한바람", "한지준" };
        private string[] doctor10 = { "추종희", "마진철", "마종진", "홍선철" };


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox4.Text = monthCalendar1.SelectionRange.Start.ToShortDateString() + DateTime.Now.ToString("일 hh시mm분");

        }

        private bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("서버에 연결할 수 없습니다. 관리자에게 문의하세요.");
                        break;
                    default:
                        MessageBox.Show(ex.Message);
                        break;
                }
                return false;
            }
        }



        private bool CloseConnection()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;


            if (this.OpenConnection() == true)
            {
                msc = new MySqlDataAdapter("select * from reservation_info", conn);
                DataSet ds = new DataSet();
                msc.Fill(ds);
                reservation_View.DataSource = ds.Tables[0];

                //close.conntecton
                this.CloseConnection();
            }




        }
        //http://www.hanyang.or.kr/board_pytR77/212,https://www.codeproject.com/Questions/480014/HowplusloadplusMysqlplustableplustoplusDATAGRIDVIE,
        //http://solibnis.blogspot.com/2013/02/connecting-mysql-table-to-datagridview.html



        private void add_Click(object sender, EventArgs e)
        {
            // string insertQuery = "INSERT INTO reservation_info(re_depart,re_dr, re_date, re_dis, re_hwan,re_ju,re_phone) VALUES('실험과','마동석','오전 2019-06-18-03시36분','감기','실험맨','960616-1154787','010-5478-8177')";
            string insertQuery = "INSERT INTO reservation_info(진료과, 진료의, 접수일시, 병명, 이름, 주민등록번호, 전화번호, 주소) VALUES('" + comboBox1.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + ' ' + textBox4.Text + "','" + textBox6.Text + "','" + textBox1.Text + "','" + textBox7.Text + '-' + textBox8.Text + "','" + comboBox2.Text + '-' + textBox2.Text + '-' + textBox3.Text + "','" + textBox5.Text + "')";
            //  conn.Open();
            MySqlCommand reser = new MySqlCommand(insertQuery, conn);


            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && reser.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("예약완료");
                }
                else
                {
                    MessageBox.Show("예약실패");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            textBox4.Clear(); textBox5.Clear(); textBox6.Clear(); textBox7.Clear();
            textBox8.Clear(); comboBox1.SelectedIndex = 0; comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0; comboBox4.SelectedIndex = 0;

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 4;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.MaxLength = 4;
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox7.MaxLength = 6;
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            textBox8.MaxLength = 7;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.MaxLength = 18;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(doctor0);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(doctor1);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(doctor2);
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(doctor3);
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(doctor4);
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(doctor5);
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(doctor6);
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(doctor7);
            }
            else if (comboBox1.SelectedIndex == 8)
            {
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(doctor8);
            }
            else if (comboBox1.SelectedIndex == 9)
            {
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(doctor9);
            }
            else if (comboBox1.SelectedIndex == 10)
            {
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(doctor10);
            }
        }

        private void reservation_View_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataTable changes = ((DataTable)reservation_View.DataSource).GetChanges();

            if (changes != null)
            {
                MySqlCommandBuilder mcb = new MySqlCommandBuilder(msc);
                msc.UpdateCommand = mcb.GetUpdateCommand();
                msc.Update(changes);
                ((DataTable)reservation_View.DataSource).AcceptChanges();
            }
        }
    }
}

