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
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {


        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=hwanja_db;Uid=root;Pwd=1234;");

        MySqlDataAdapter msc;
        MySqlDataAdapter msctwo;

        int time = 0;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti2 =  new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti3 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti4 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti5 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti6 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti7 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti8 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti9 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti10 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti11= new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti12 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti13 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti14 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti15 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti16 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti17 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti18 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti19 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti20 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti21 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti22 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti23 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti24 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti25 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti26 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti27 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti28 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti29 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti30 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti31 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti32 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti33 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti34 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti35 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti36 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti37 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti38 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti39 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti40 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti41 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti42 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti43 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ti44 = new System.Windows.Forms.Timer();


        string cell;
        int cellcheck = 0;
        bool timecheck;
        public Form1()
        {
            InitializeComponent();
            
        }
     
        //진료의
        private string[] doctor0 = {"정상수", "김철수", "김갑수", "김수가"};
        private string[] doctor1 = {"오예수", "오부처", "오알라", "오하늘" };
        private string[] doctor2 = {"강철구", "조순철", "금지철", "서한지" };
        private string[] doctor3 = {"차수미", "장덕철", "장제인", "추성희" };
        private string[] doctor4 = {"박수소", "이세희", "이고진", "진지혜" };
        private string[] doctor5 = {"한곡의", "한고예", "마동철", "마박세" };
        private string[] doctor6 = {"이승철", "성재진", "이재진", "나진자" };
        private string[] doctor7 = {"나선추", "추재준", "하선호", "하진주" };
        private string[] doctor8 = {"오바람", "오아람", "성후진", "강신후" };
        private string[] doctor9 = {"강도철", "한오루", "한바람", "한지준" };
        private string[] doctor10= {"추종희", "마진철", "마종진", "홍선철" };

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)

        { 
            textBox4.Text = monthCalendar1.SelectionRange.Start.ToShortDateString() + DateTime.Now.ToString("일hh시mm분");
        }

        //-----------------------------------create table method--------------------------------------------//
        private void Create()
        {
            try
            {
                string TrunQuery = "create table reservation_info(No int not null primary key AUTO_INCREMENT,진료과 varchar(30) not null,진료의 varchar(30) not null,접수일시 varchar(40) not null,병명 varchar(35) not null,이름 varchar(30)not null,주민등록번호 varchar(40) not null,전화번호 varchar(35) not null,주소 varchar(60) not null); ";
                MySqlCommand trun = new MySqlCommand(TrunQuery, conn);
                trun.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
             //MessageBox.Show(ex.ToString());
            }
        }

        private void CreateTwo()
        {
            try
            {
                string TrunQuery = "create table reservationsecond_info(No int not null primary key AUTO_INCREMENT,진료과 varchar(30) not null,진료의 varchar(30) not null,접수일시 varchar(40) not null,병명 varchar(35) not null,이름 varchar(30)not null,주민등록번호 varchar(40) not null,전화번호 varchar(35) not null,주소 varchar(60) not null); ";
                MySqlCommand trun = new MySqlCommand(TrunQuery, conn);
                trun.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
               //MessageBox.Show(ex.ToString());
            }
        }

        private void CreateThree()
        {
            try
            {
                string TrunQuery = "create table reservationthird_info(No int not null primary key AUTO_INCREMENT,진료과 varchar(30) not null,진료의 varchar(30) not null,접수일시 varchar(40) not null,병명 varchar(35) not null,이름 varchar(30)not null,주민등록번호 varchar(40) not null,전화번호 varchar(35) not null,주소 varchar(60) not null); ";
                MySqlCommand trun = new MySqlCommand(TrunQuery, conn);
                trun.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
              //MessageBox.Show(ex.ToString());
            }
        }


        private void CreateFour()
        {
            try
            {
                string TrunQuery = "create table sa_info(No int not null primary key AUTO_INCREMENT,진료과 varchar(30) not null,진료의 varchar(30) not null,접수일시 varchar(40) not null,병명 varchar(35) not null,이름 varchar(30)not null,주민등록번호 varchar(40) not null,전화번호 varchar(35) not null,주소 varchar(60) not null); ";
                MySqlCommand trun = new MySqlCommand(TrunQuery, conn);
                trun.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
              //MessageBox.Show(ex.ToString());
            }
        }
        //------------------------------------create table method----------------------------------------//
        private bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch(MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("서버에 연결할 수 없습니다. 관리자에게 문의하세요.","서버에러",MessageBoxButtons.OK,(MessageBoxIcon.Error));
                        break;
                    default:
                        MessageBox.Show(ex.Message);
                        break;
                }
                return false;
            }
        }

        //delete method 
        private void  Swap()
        {
            try
            {
                string SwapQuery = "INSERT INTO reservationsecond_info (진료과, 진료의, 접수일시, 병명, 이름, 주민등록번호, 전화번호, 주소) SELECT 진료과, 진료의, 접수일시, 병명, 이름, 주민등록번호, 전화번호, 주소 FROM reservation_info";
                MySqlCommand swap = new MySqlCommand(SwapQuery, conn);
                swap.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Trun()

        {
            try
            {
                string TrunQuery = "truncate reservation_info";
                MySqlCommand trun = new MySqlCommand(TrunQuery, conn);
                trun.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SwapTwo()

        {

            try
            {
                string SwapQueryTwo = "INSERT INTO reservation_info (진료과, 진료의, 접수일시, 병명, 이름, 주민등록번호, 전화번호, 주소) SELECT 진료과, 진료의, 접수일시, 병명, 이름, 주민등록번호, 전화번호, 주소 FROM reservationsecond_info";
                MySqlCommand swaptwo = new MySqlCommand(SwapQueryTwo, conn);
                swaptwo.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void TrunTwo()
        {

            try
            {
                string TrunQuery = "truncate reservationsecond_info";
                MySqlCommand truntwo = new MySqlCommand(TrunQuery, conn);
                truntwo.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        // -------------- delete method end-----------------------//

         //-------------------------------------add method---------------------------------------//

        private void AddSwap()

        {
            try
            {
                string AddSwapQuery = "INSERT INTO reservationthird_info (진료과, 진료의, 접수일시, 병명, 이름, 주민등록번호, 전화번호, 주소) SELECT 진료과, 진료의, 접수일시, 병명, 이름, 주민등록번호, 전화번호, 주소 FROM reservation_info";
                MySqlCommand addswap = new MySqlCommand(AddSwapQuery, conn);
                addswap.ExecuteNonQuery();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void AddTrun()
        {

            try
            {
                string AddTrunQuery = "truncate reservation_info";
                MySqlCommand addtrun = new MySqlCommand(AddTrunQuery, conn);
                addtrun.ExecuteNonQuery(); 
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void AddSwapTwo()
        {

            try
            {
                string AddSwapQueryTwo = "INSERT INTO reservation_info (진료과, 진료의, 접수일시, 병명, 이름, 주민등록번호, 전화번호, 주소) SELECT 진료과, 진료의, 접수일시, 병명, 이름, 주민등록번호, 전화번호, 주소 FROM reservationthird_info";
                MySqlCommand swaptwo = new MySqlCommand(AddSwapQueryTwo, conn);
                swaptwo.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void AddTrunTwo()

        {

            try
            {
                string AddTrunQuery = "truncate reservationthird_info";
                MySqlCommand addtruntwo = new MySqlCommand(AddTrunQuery, conn);
                addtruntwo.ExecuteNonQuery();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       private void Sainfo()
        {
            try
            {
                string sainfo = "INSERT INTO sa_info(진료과, 진료의, 접수일시, 병명, 이름, 주민등록번호, 전화번호, 주소) VALUES('" + comboBox1.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + ' ' + textBox4.Text + "','" + textBox6.Text + "','" + textBox1.Text + "','" + textBox7.Text + '-' + textBox8.Text + "','" + comboBox2.Text + '-' + textBox2.Text + '-' + textBox3.Text + "','" + textBox5.Text + "')";
                MySqlCommand sainfotwo = new MySqlCommand(sainfo, conn);
                sainfotwo.ExecuteNonQuery();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //----------------------------------------------------add method end--------------------------------------------//

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
        //-------------------------------------------From1_load--- ~~~~ SQLQuery------------------------------------------//

        private void Form1_Load(object sender, EventArgs e)
        {




            comboBox2.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;


            if (this.OpenConnection() == true) {

                Create();
                CreateTwo();
                CreateThree();
                CreateFour();
                msc = new MySqlDataAdapter("select * from reservation_info", conn);
                DataSet ds = new DataSet();          
                msc.Fill(ds);            
                reservation_View.DataSource = ds.Tables[0];
                //close.conntecton
                this.CloseConnection();

            }
        }
       
        private void add_Click(object sender, EventArgs e)
        {
        
            conn.Open();
            string insertQuery = "INSERT INTO reservation_info(진료과, 진료의, 접수일시, 병명, 이름, 주민등록번호, 전화번호, 주소) VALUES('" + comboBox1.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + ' ' + textBox4.Text + "','" + textBox6.Text + "','" + textBox1.Text + "','" + textBox7.Text + '-' + textBox8.Text + "','" + comboBox2.Text + '-' + textBox2.Text + '-' + textBox3.Text + "','" + textBox5.Text +"')";
            
            MySqlCommand reser = new MySqlCommand(insertQuery, conn);

            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != 
                    "" && textBox7.Text !=  "" && textBox8.Text != "" && reser.ExecuteNonQuery() == 1)
                {
                    AddSwap();
                    AddTrun();
                    AddSwapTwo();
                    AddTrunTwo();
                    Sainfo();

                    msc = new MySqlDataAdapter("select * from reservation_info", conn);
                    DataSet ds = new DataSet();
                    msc.Fill(ds);
                    reservation_View.DataSource = ds.Tables[0];

                    //close.conn
                    this.CloseConnection();
                    MessageBox.Show("예약완료");

                }
                else
                {
                    MessageBox.Show("예약실패", "예약", MessageBoxButtons.OK, (MessageBoxIcon.Warning));
                    this.CloseConnection();
                    return;

                }
                //진료과 진료의 comboBox1 , comboBox3 

                //------------------------------------외과-------------------------------------------//
                if (comboBox1.Text=="외과" && comboBox3.Text=="정상수")
                {
                    MessageBox.Show("외과 의사 정상수 예약");
                    timer.Enabled = true;
                    timer.Interval = 1000;
                    timer.Tick += new EventHandler(Timer1_Tick);
                    timer.Start();
                    comboBox3.Items.RemoveAt(0);
                    comboBox3.Items.Insert(0, "예약(정상수)");
                }

                if (comboBox1.Text == "외과" && comboBox3.Text == "김철수")
                {
                    MessageBox.Show("외과 의사 김철수 예약");
                    ti2.Enabled = true;
                    ti2.Interval = 1000;
                    ti2.Tick += new EventHandler(Timer2_Tick);
                    ti2.Start();
                    comboBox3.Items.RemoveAt(1);
                    comboBox3.Items.Insert(1, "예약(김철수)");
                }

                if (comboBox1.Text == "외과" && comboBox3.Text == "김갑수")
                {
                    MessageBox.Show("외과 의사 김갑수 예약");
                    ti3.Enabled = true;
                    ti3.Interval = 1000;
                    ti3.Tick += new EventHandler(Timer3_Tick);
                    ti3.Start();
                    comboBox3.Items.RemoveAt(2);
                    comboBox3.Items.Insert(2, "예약(김갑수)");
                }

                if (comboBox1.Text == "외과" && comboBox3.Text == "김수가")
                {
                    MessageBox.Show("외과 의사 김수가 예약");
                    ti4.Enabled = true;
                    ti4.Interval = 1000;
                    ti4.Tick += new EventHandler(Timer4_Tick);
                    ti4.Start();
                    comboBox3.Items.RemoveAt(3);
                    comboBox3.Items.Insert(3, "예약(김수가)");
                }
                //----------------------------------------외과 끝 ----------------------------------------//

                //---------------------------------------심장내과-----------------------------------------//
                if (comboBox1.Text == "심장내과" && comboBox3.Text == "오예수")
                {
                    MessageBox.Show("심장내과 의사 오예수 예약");
                    ti5.Enabled = true;
                    ti5.Interval = 1000;
                    ti5.Tick += new EventHandler(Timer5_Tick);
                    ti5.Start();
                    comboBox3.Items.RemoveAt(0);
                    comboBox3.Items.Insert(0, "예약(오예수)");
                }

                if (comboBox1.Text == "심장내과" && comboBox3.Text == "오부처")
                {

                    MessageBox.Show("심장내과 의사 오부처 예약");
                    ti6.Enabled = true;
                    ti6.Interval = 1000;
                    ti6.Tick += new EventHandler(Timer6_Tick);
                    ti6.Start();
                    comboBox3.Items.RemoveAt(1);
                    comboBox3.Items.Insert(1, "예약(오부처)");
                }

                if (comboBox1.Text == "심장내과" && comboBox3.Text == "오알라")
                {
                    MessageBox.Show("심장내과 의사 오알라 예약");
                    ti7.Enabled = true;
                    ti7.Interval = 1000;
                    ti7.Tick += new EventHandler(Timer7_Tick);
                    ti7.Start();
                    comboBox3.Items.RemoveAt(2);
                    comboBox3.Items.Insert(2, "예약(오부처)");
                }

                if (comboBox1.Text == "심장내과" && comboBox3.Text == "오하늘")
                {
                    MessageBox.Show("심장내과 의사 오하늘 예약");
                    ti8.Enabled = true;
                    ti8.Interval = 1000;
                    ti8.Tick += new EventHandler(Timer8_Tick);
                    ti8.Start();
                    comboBox3.Items.RemoveAt(3);
                    comboBox3.Items.Insert(3, "예약(오하늘)");
                }

                //--------------------------------------심장내과 끝-------------------------------------//

                //--------------------------------------신경외과 시작----------------------------------//
                if (comboBox1.Text == "신경외과" && comboBox3.Text == "강철구")
                {
                    MessageBox.Show("신경외과 의사 강철구 예약");
                    ti9.Enabled = true;
                    ti9.Interval = 1000;
                    ti9.Tick += new EventHandler(Timer9_Tick);
                    ti9.Start();
                    comboBox3.Items.RemoveAt(0);
                    comboBox3.Items.Insert(0, "예약(강철구)");
                }

                if (comboBox1.Text == "신경외과" && comboBox3.Text == "조순철")
                {
                    MessageBox.Show("신경외과 의사 조순철 예약");
                    ti10.Enabled = true;
                    ti10.Interval = 1000;
                    ti10.Tick += new EventHandler(Timer10_Tick);
                    ti10.Start();
                    comboBox3.Items.RemoveAt(1);
                    comboBox3.Items.Insert(1, "예약(조순철)");
                }

                if (comboBox1.Text == "신경외과" && comboBox3.Text == "금지철")
                {
                    MessageBox.Show("신경외과 의사 금지철 예약");
                    ti11.Enabled = true;
                    ti11.Interval = 1000;
                    ti11.Tick += new EventHandler(Timer11_Tick);
                    ti11.Start();
                    comboBox3.Items.RemoveAt(2);
                    comboBox3.Items.Insert(2, "예약(금지철)");
                }

                if (comboBox1.Text == "신경외과" && comboBox3.Text == "서한지")
                {
                    MessageBox.Show("신경외과 의사 서한지 예약");
                    ti12.Enabled = true;
                    ti12.Interval = 1000;
                    ti12.Tick += new EventHandler(Timer12_Tick);
                    ti12.Start();
                    comboBox3.Items.RemoveAt(3);
                    comboBox3.Items.Insert(3, "예약(서한지)");
                }
                //---------------------------------------신경외과 끝----------------------------------//

                //--------------------------------------소아청소년과 시작-----------------------------//
                if (comboBox1.Text == "소아청소년과" && comboBox3.Text == "차수미")
                {
                    MessageBox.Show("소아청소년과 의사 차수미 예약");
                    ti13.Enabled = true;
                    ti13.Interval = 1000;
                    ti13.Tick += new EventHandler(Timer13_Tick);
                    ti13.Start();
                    comboBox3.Items.RemoveAt(0);
                    comboBox3.Items.Insert(0, "예약(차수미)");
                }

                if (comboBox1.Text == "소아청소년과" && comboBox3.Text == "장덕철")
                {
                    MessageBox.Show("소아청소년과 의사 장덕철 예약");
                    ti14.Enabled = true;
                    ti14.Interval = 1000;
                    ti14.Tick += new EventHandler(Timer14_Tick);
                    ti14.Start();
                    comboBox3.Items.RemoveAt(1);
                    comboBox3.Items.Insert(1, "예약(장덕철)");
                }

                if (comboBox1.Text == "소아청소년과" && comboBox3.Text == "장제인")
                {
                    MessageBox.Show("소아청소년과 의사 장제인 예약");
                    ti15.Enabled = true;
                    ti15.Interval = 1000;
                    ti15.Tick += new EventHandler(Timer15_Tick);
                    ti15.Start();
                    comboBox3.Items.RemoveAt(2);
                    comboBox3.Items.Insert(2, "예약(장제인)");
                }

                if (comboBox1.Text == "소아청소년과" && comboBox3.Text == "추성희")
                {
                    MessageBox.Show("소아청소년과 의사 추성희 예약");
                    ti16.Enabled = true;
                    ti16.Interval = 1000;
                    ti16.Tick += new EventHandler(Timer16_Tick);
                    ti16.Start();
                    comboBox3.Items.RemoveAt(3);
                    comboBox3.Items.Insert(3, "예약(추성희)");
                }
                //-------------------------------------------소아청소년과----------------------------------------//

                //---------------------------------------- 이비인후과 시작---------------------------------------//
                if (comboBox1.Text == "이비인후과" && comboBox3.Text == "박수소")
                {
                    MessageBox.Show("이비인후과 의사 박수소 예약");
                    ti17.Enabled = true;
                    ti17.Interval = 1000;
                    ti17.Tick += new EventHandler(Timer17_Tick);
                    ti17.Start();
                    comboBox3.Items.RemoveAt(0);
                    comboBox3.Items.Insert(0, "예약(박수소)");
                }

                if (comboBox1.Text == "이비인후과" && comboBox3.Text == "이세희")
                {
                    MessageBox.Show("이비인후과 의사 이세희 예약");
                    ti18.Enabled = true;
                    ti18.Interval = 1000;
                    ti18.Tick += new EventHandler(Timer18_Tick);
                    ti18.Start();
                    comboBox3.Items.RemoveAt(1);
                    comboBox3.Items.Insert(1, "예약(이세희)");
                }

                if (comboBox1.Text == "이비인후과" && comboBox3.Text == "이고진")
                {
                    MessageBox.Show("이비인후과 의사 이고진 예약");
                    ti19.Enabled = true;
                    ti19.Interval = 1000;
                    ti19.Tick += new EventHandler(Timer19_Tick);
                    ti19.Start();
                    comboBox3.Items.RemoveAt(2);
                    comboBox3.Items.Insert(2, "예약(이고진)");
                }

                if (comboBox1.Text == "이비인후과" && comboBox3.Text == "진지혜")
                {
                    MessageBox.Show("이비인후과 의사 진지혜 예약");
                    ti20.Enabled = true;
                    ti20.Interval = 1000;
                    ti20.Tick += new EventHandler(Timer20_Tick);
                    ti20.Start();
                    comboBox3.Items.RemoveAt(3);
                    comboBox3.Items.Insert(3, "예약(진지혜)");
                }
                //------------------------------------------------------이비인후과--끝---------------------------------------------------//

                //------------------------------------------------------소화기내과 시작----------------------------------------------------//

                if (comboBox1.Text == "소화기내과" && comboBox3.Text == "한곡의")
                {
                    MessageBox.Show("소화기내과 의사 한곡의 예약");
                    ti21.Enabled = true;
                    ti21.Interval = 1000;
                    ti21.Tick += new EventHandler(Timer21_Tick);
                    ti21.Start();
                    comboBox3.Items.RemoveAt(0);
                    comboBox3.Items.Insert(0, "예약(한곡의)");
                }

                if (comboBox1.Text == "소화기내과" && comboBox3.Text == "한고예")
                {
                    MessageBox.Show("소화기내과 의사 한고예 예약");
                    ti22.Enabled = true;
                    ti22.Interval = 1000;
                    ti22.Tick += new EventHandler(Timer22_Tick);
                    ti22.Start();
                    comboBox3.Items.RemoveAt(1);
                    comboBox3.Items.Insert(1, "예약(한고예)");
                }

                if (comboBox1.Text == "소화기내과" && comboBox3.Text == "마동철")
                {
                    MessageBox.Show("소화기내과 의사 마동철 예약");
                    ti23.Enabled = true;
                    ti23.Interval = 1000;
                    ti23.Tick += new EventHandler(Timer23_Tick);
                    ti23.Start();
                    comboBox3.Items.RemoveAt(2);
                    comboBox3.Items.Insert(2, "예약(마동철)");
                }

                if (comboBox1.Text == "소화기내과" && comboBox3.Text == "마박세")
                {
                    MessageBox.Show("소화기내과 의사 마박세 예약");
                    ti24.Enabled = true;
                    ti24.Interval = 1000;
                    ti24.Tick += new EventHandler(Timer24_Tick);
                    ti24.Start();
                    comboBox3.Items.RemoveAt(3);
                    comboBox3.Items.Insert(3, "예약(마박세)");
                }
                //----------------------------------------소화기내과 끝---------------------------------------//


                //----------------------------------------치과 시작------------------------------------------//

                if (comboBox1.Text == "치과" && comboBox3.Text == "이승철")
                {
                    MessageBox.Show("치과 의사 이승철 예약");
                    ti25.Enabled = true;
                    ti25.Interval = 1000;
                    ti25.Tick += new EventHandler(Timer25_Tick);
                    ti25.Start();
                    comboBox3.Items.RemoveAt(0);
                    comboBox3.Items.Insert(0, "예약(이승철)");
                }

                if (comboBox1.Text == "치과" && comboBox3.Text == "성재진")
                {
                    MessageBox.Show("치과 의사 성재진 예약");
                    ti26.Enabled = true;
                    ti26.Interval = 1000;
                    ti26.Tick += new EventHandler(Timer26_Tick);
                    ti26.Start();
                    comboBox3.Items.RemoveAt(1);
                    comboBox3.Items.Insert(1, "예약(성재진)");
                }

                if (comboBox1.Text == "치과" && comboBox3.Text == "이재진")
                {
                    MessageBox.Show("치과 의사 이재진 예약");
                    ti27.Enabled = true;
                    ti27.Interval = 1000;
                    ti27.Tick += new EventHandler(Timer27_Tick);
                    ti27.Start();
                    comboBox3.Items.RemoveAt(2);
                    comboBox3.Items.Insert(2, "예약(이재진)");
                }

                if (comboBox1.Text == "치과" && comboBox3.Text == "나진자")
                {
                    MessageBox.Show("치과 의사 나진자 예약");
                    ti28.Enabled = true;
                    ti28.Interval = 1000;
                    ti28.Tick += new EventHandler(Timer28_Tick);
                    ti28.Start();
                    comboBox3.Items.RemoveAt(3);
                    comboBox3.Items.Insert(3, "예약(나진자)");
                }

                //-------------------------------------------------치과 끝--------------------------------------//

                //--------------------------------------------정형외과 시작-------------------------------------//
                if (comboBox1.Text == "정형외과" && comboBox3.Text == "나선추")
                {
                    MessageBox.Show("정형외과 의사 나선추 예약");
                    ti29.Enabled = true;
                    ti29.Interval = 1000;
                    ti29.Tick += new EventHandler(Timer29_Tick);
                    ti29.Start();
                    comboBox3.Items.RemoveAt(0);
                    comboBox3.Items.Insert(0, "예약(나선추)");
                }

                if (comboBox1.Text == "정형외과" && comboBox3.Text == "추재준")
                {
                    MessageBox.Show("정형외과 의사 추재준 예약");
                    ti30.Enabled = true;
                    ti30.Interval = 1000;
                    ti30.Tick += new EventHandler(Timer30_Tick);
                    ti30.Start();
                    comboBox3.Items.RemoveAt(1);
                    comboBox3.Items.Insert(1, "예약(추재준)");
                }

                if (comboBox1.Text == "정형외과" && comboBox3.Text == "하선호")
                {
                    MessageBox.Show("정형외과 의사 하선호 예약");
                    ti31.Enabled = true;
                    ti31.Interval = 1000;
                    ti31.Tick += new EventHandler(Timer31_Tick);
                    ti31.Start();
                    comboBox3.Items.RemoveAt(2);
                    comboBox3.Items.Insert(2, "예약(하선호)");
                }

                if (comboBox1.Text == "정형외과" && comboBox3.Text == "하진주")
                {
                    MessageBox.Show("정형외과 의사 하진주 예약");
                    ti32.Enabled = true;
                    ti32.Interval = 1000;
                    ti32.Tick += new EventHandler(Timer32_Tick);
                    ti32.Start();
                    comboBox3.Items.RemoveAt(3);
                    comboBox3.Items.Insert(3, "예약(하진주)");
                }

                //--------------------------------------------------정형외과 끝-----------------------------------------------------------//

                //--------------------------------------------------산부인과 시작---------------------------------------------------------//
                if (comboBox1.Text == "산부인과" && comboBox3.Text == "오바람")
                {
                    MessageBox.Show("산부인과 의사 오바람 예약");
                    ti33.Enabled = true;
                    ti33.Interval = 1000;
                    ti33.Tick += new EventHandler(Timer33_Tick);
                    ti33.Start();
                    comboBox3.Items.RemoveAt(0);
                    comboBox3.Items.Insert(0, "예약(오바람)");
                }

                if (comboBox1.Text == "산부인과" && comboBox3.Text == "오아람")
                {
                    MessageBox.Show("산부인과 의사 오아람 예약");
                    ti34.Enabled = true;
                    ti34.Interval = 1000;
                    ti34.Tick += new EventHandler(Timer34_Tick);
                    ti34.Start();
                    comboBox3.Items.RemoveAt(1);
                    comboBox3.Items.Insert(1, "예약(오아람)");
                }

                if (comboBox1.Text == "산부인과" && comboBox3.Text == "성후진")
                {
                    MessageBox.Show("산부인과 의사 성후진 예약");
                    ti35.Enabled = true;
                    ti35.Interval = 1000;
                    ti35.Tick += new EventHandler(Timer35_Tick);
                    ti35.Start();
                    comboBox3.Items.RemoveAt(2);
                    comboBox3.Items.Insert(2, "예약(성후진)");
                }

                if (comboBox1.Text == "산부인과" && comboBox3.Text == "강신후")
                {
                    MessageBox.Show("산부인과 의사 강신후 예약");
                    ti36.Enabled = true;
                    ti36.Interval = 1000;
                    ti36.Tick += new EventHandler(Timer36_Tick);
                    ti36.Start();
                    comboBox3.Items.RemoveAt(3);
                    comboBox3.Items.Insert(3, "예약(강신후)");
                }
                //-----------------------------------------------------------산부인과 끝-------------------------------------------------//

                //-----------------------------------------------------------비뇨기과 시작-----------------------------------------------//
                if (comboBox1.Text == "비뇨기과" && comboBox3.Text == "강도철")
                {
                    MessageBox.Show("비뇨기과 의사 강도철 예약");
                    ti37.Enabled = true;
                    ti37.Interval = 1000;
                    ti37.Tick += new EventHandler(Timer37_Tick);
                    ti37.Start();
                    comboBox3.Items.RemoveAt(0);
                    comboBox3.Items.Insert(0, "예약(강도철)");
                }

                if (comboBox1.Text == "비뇨기과" && comboBox3.Text == "한오루")
                {
                    MessageBox.Show("비뇨기과 의사 한오루 예약");
                    ti38.Enabled = true;
                    ti38.Interval = 1000;
                    ti38.Tick += new EventHandler(Timer38_Tick);
                    ti38.Start();
                    comboBox3.Items.RemoveAt(1);
                    comboBox3.Items.Insert(1, "예약(한오루)");
                }

                if (comboBox1.Text == "비뇨기과" && comboBox3.Text == "한바람")
                {
                    MessageBox.Show("비뇨기과 의사 한바람 예약");
                    ti39.Enabled = true;
                    ti39.Interval = 1000;
                    ti39.Tick += new EventHandler(Timer39_Tick);
                    ti39.Start();
                    comboBox3.Items.RemoveAt(2);
                    comboBox3.Items.Insert(2, "예약(한바람)");
                }

                if (comboBox1.Text == "비뇨기과" && comboBox3.Text == "한지준")
                {
                    MessageBox.Show("비뇨기과 의사 한지준 예약");
                    ti40.Enabled = true;
                    ti40.Interval = 1000;
                    ti40.Tick += new EventHandler(Timer40_Tick);
                    ti40.Start();
                    comboBox3.Items.RemoveAt(3);
                    comboBox3.Items.Insert(3, "예약(한지준)");
                }

                //--------------------------------------------비뇨기과 끝--------------------------------------//

                //--------------------------------------------신경과 시작--------------------------------------//

                if (comboBox1.Text == "신경과" && comboBox3.Text == "추종희")
                {
                    MessageBox.Show("신경과 의사 추종희 예약");
                    ti41.Enabled = true;
                    ti41.Interval = 1000;
                    ti41.Tick += new EventHandler(Timer41_Tick);
                    ti41.Start();
                    comboBox3.Items.RemoveAt(0);
                    comboBox3.Items.Insert(0, "예약(추종희)");
                }

                if (comboBox1.Text == "신경과" && comboBox3.Text == "마진철")
                {
                    MessageBox.Show("신경과 의사 마진철 예약");
                    ti42.Enabled = true;
                    ti42.Interval = 1000;
                    ti42.Tick += new EventHandler(Timer42_Tick);
                    ti42.Start();
                    comboBox3.Items.RemoveAt(1);
                    comboBox3.Items.Insert(1, "예약(마진철)");
                }

                if (comboBox1.Text == "신경과" && comboBox3.Text == "마종진")
                {
                    MessageBox.Show("신경과 의사 마종진 예약");
                    ti43.Enabled = true;
                    ti43.Interval = 1000;
                    ti43.Tick += new EventHandler(Timer43_Tick);
                    ti43.Start();
                    comboBox3.Items.RemoveAt(2);
                    comboBox3.Items.Insert(2, "예약(마종진)");
                }

                if (comboBox1.Text == "신경과" && comboBox3.Text == "홍선철")
                {
                    MessageBox.Show("신경과 의사 홍선철 예약");
                    ti44.Enabled = true;
                    ti44.Interval = 1000;
                    ti44.Tick += new EventHandler(Timer44_Tick);
                    ti44.Start();
                    comboBox3.Items.RemoveAt(3);
                    comboBox3.Items.Insert(3, "예약(홍선철)");
                }

            //---------------------------------------------신경외과 끝-------------------------------------------//
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
  
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            textBox4.Clear(); textBox5.Clear(); textBox6.Clear(); textBox7.Clear();
            textBox8.Clear();  comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex =  comboBox4.SelectedIndex = 0;

        }
       

       

        private void reservation_View_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            cell = reservation_View.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
        }
   
        private void delete_Click(object sender, EventArgs e)
        {
           
            conn.Open();
            cellcheck = Convert.ToInt32(cell);
            string DeleteQuery = "DELETE FROM reservation_info where  No='" +cellcheck + "'";
             
            try  
            {
             
                if (MessageBox.Show("삭제 하시겠습니까?", "삭제", MessageBoxButtons.YesNo, (MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    MySqlCommand reser = new MySqlCommand(DeleteQuery, conn);
                    if(reser.ExecuteNonQuery() == 1)
                    Swap();
                    Trun();
                    SwapTwo();
                    TrunTwo();
                    msc = new MySqlDataAdapter("select * from reservation_info", conn);
                    DataSet ds = new DataSet();
                    msc.Fill(ds);
                    reservation_View.DataSource = ds.Tables[0];
                    //close.conn
                    this.CloseConnection();
                    MessageBox.Show("삭제 완료", "삭제", MessageBoxButtons.OK, (MessageBoxIcon.Asterisk));
                }
                
                else
               {
                  MessageBox.Show("삭제취소","삭제",MessageBoxButtons.OK,(MessageBoxIcon.Warning));
               }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }


      
        private void serch_Click(object sender, EventArgs e)
        {
            conn.Open();
 
            try
            {
                if (textBox9.Text=="")
                {
                    MessageBox.Show("검색창이 비었습니다.","검색",MessageBoxButtons.OK,(MessageBoxIcon.Warning));
                    this.CloseConnection();
                    return;
                }
                msctwo = new MySqlDataAdapter("select * from sa_info where 이름='"+textBox9.Text+"'", conn);
                DataSet dds = new DataSet();
                msctwo.Fill(dds);
                sainfo_View.DataSource = dds.Tables[0];
                //close.conn
                this.CloseConnection();
                MessageBox.Show("검색완료");
                }
            catch (Exception ex)
            {
                MessageBox.Show("에러",ex.ToString(), MessageBoxButtons.OK, (MessageBoxIcon.Hand));

            }
            conn.Close();
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
            if(comboBox1.SelectedIndex == 0)
            {
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(doctor0);
                comboBox3.Text = "";
            }
            else if(comboBox1.SelectedIndex== 1)
            {
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(doctor1);
                comboBox3.Text = "";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(doctor2);
                comboBox3.Text = "";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(doctor3);
                comboBox3.Text = "";
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(doctor4);
                comboBox3.Text = "";
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(doctor5);
                comboBox3.Text = "";
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(doctor6);
                comboBox3.Text = "";
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(doctor7);
                comboBox3.Text = "";
            }
            else if (comboBox1.SelectedIndex == 8)
            {
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(doctor8);
                comboBox3.Text = "";
            }
            else if (comboBox1.SelectedIndex == 9)
            {
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(doctor9);
                comboBox3.Text = "";
            }
            else if (comboBox1.SelectedIndex == 10)
            {
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(doctor10);
                comboBox3.Text = "";
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
            this.reservation_View.Invalidate();
        }

        private void sainfo_View_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataTable changes = ((DataTable)sainfo_View.DataSource).GetChanges();

            if (changes != null)
            {
                MySqlCommandBuilder mdb = new MySqlCommandBuilder(msctwo);
                msctwo.UpdateCommand = mdb.GetUpdateCommand();
                msctwo.Update(changes);
                ((DataTable)sainfo_View.DataSource).AcceptChanges();

            }
            this.sainfo_View.Invalidate();
        }

        //--------------------------------- KEY METHOD -----------------------------//
        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8)
            {

                e.Handled = true;

            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8 )
            {

                e.Handled = true;

            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8)
            {

                e.Handled = true;

            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8)
            {

                e.Handled = true;

            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8)
            {

                e.Handled = true;

            }
        }
        //------------------------------------------- SELECT QUERY---------------------------------------------//
        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            string choQuery = "truncate reservation_info";

            try
            {
                if (MessageBox.Show("예약리스트를 초기화 하시겠습니까?","초기화",MessageBoxButtons.YesNo,(MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    MySqlCommand cho = new MySqlCommand(choQuery, conn);
                    if(cho.ExecuteNonQuery() == 1)
                    msc = new MySqlDataAdapter("select * from reservation_info", conn);
                    DataSet ds = new DataSet();
                    msc.Fill(ds);
                    reservation_View.DataSource = ds.Tables[0];
                    //close.conn
                    this.CloseConnection();
                    MessageBox.Show("초기화 완료", "초기화", MessageBoxButtons.OK, (MessageBoxIcon.Asterisk));
                }
                 else
                  {
                    MessageBox.Show("초기화 취소", "초기화", MessageBoxButtons.OK, (MessageBoxIcon.Asterisk));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("에러", ex.ToString(), MessageBoxButtons.OK, (MessageBoxIcon.Hand));
            }
            conn.Close();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //--------------------------외과TIMER!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!_---------------///////////
        private void Timer1_Tick(object sender, EventArgs e)
        {
            time++;
            if (time > 30)
            {
                time = 0;
                timer.Enabled = false;
                MessageBox.Show("외과 의사 예약(정상수) 대기 끝");


                if (timer.Enabled == false)
                {
                    if(comboBox3.Text=="예약(정상수)" && comboBox1.SelectedIndex==0)
                    MessageBox.Show("외과 의사 정상수 진료 가능합니다.");
                    comboBox3.Items.RemoveAt(0);
                    comboBox3.Items.Insert(0, "정상수");

                }
            }

        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            time++;
            if (time > 350)
            {
                time = 0;
                timer.Enabled = false;
                MessageBox.Show("외과 의사 예약(김철수) 대기 끝");


                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(김철수)" && comboBox1.SelectedIndex == 0)
                        MessageBox.Show("외과 의사 김철수 진료 가능합니다.");
                    comboBox3.Items.RemoveAt(1);
                    comboBox3.Items.Insert(1, "김철수");

                }
            }
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            time++;
            if (time > 550)
            {
                time = 0;
                timer.Enabled = false;
                MessageBox.Show("외과 의사 예약(김갑수) 대기 끝");


                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(김갑수)" && comboBox1.SelectedIndex == 0)
                        MessageBox.Show("외과 의사 김갑수 진료 가능합니다.");
                    comboBox3.Items.RemoveAt(2);
                    comboBox3.Items.Insert(2, "김갑수");

                }
            }
        }

        private void Timer4_Tick(object sender, EventArgs e)
        {
            time++;
            if (time >600)
            {
                time = 0;
                timer.Enabled = false;
                MessageBox.Show("외과 의사 예약(김수가) 대기 끝");


                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(김수가)" && comboBox1.SelectedIndex == 0)
                        MessageBox.Show("외과 의사 김수가 진료 가능합니다.");
                    comboBox3.Items.RemoveAt(3);
                    comboBox3.Items.Insert(3, "김수가");

                }
            }
        }

        //----------------------------------------외과 끝--------------------------------------//

        //---------------------------------------심장내과 시작-----------------------------------//
        private void Timer5_Tick(object sender, EventArgs e)
        {
            time++;
            if (time > 800)
            {

                time = 0;
                timer.Enabled = false;
                MessageBox.Show("심장내과 의사 예약(오예수) 대기 끝");

                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(오예수)" && comboBox1.SelectedIndex == 1)

                    MessageBox.Show("심장내과 오예수 진료 가능합니다.");
                    comboBox3.Items.RemoveAt(0);
                    comboBox3.Items.Insert(0, "오예수");

                }
            }
        }

        private void Timer6_Tick(object sender, EventArgs e)
        {
            time++;
            if (time > 700)
            {

                time = 0;
                timer.Enabled = false;
                MessageBox.Show("심장내과 의사 예약(오부처) 대기 끝");

                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(오부처)" && comboBox1.SelectedIndex == 1)
                    MessageBox.Show("심장내과 오부처 진료 가능합니다");
                    comboBox3.Items.RemoveAt(1);
                    comboBox3.Items.Insert(1, "오부처");

                }
            }
        }

        private void Timer7_Tick(object sender, EventArgs e)
        {
            time++;
            if (time > 530)
            {

                time = 0;
                timer.Enabled = false;
                MessageBox.Show("심장내과 의사 예약(오알라) 대기 끝");

                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(오알라)" && comboBox1.SelectedIndex == 1)

                        MessageBox.Show("심장내과 오알라 진료 가능합니다");
                    comboBox3.Items.RemoveAt(2);
                    comboBox3.Items.Insert(2, "오알라");

                }
            }
        }

        private void Timer8_Tick(object sender, EventArgs e)
        {

            time++;
            if (time > 820)
            {

                time = 0;
                timer.Enabled = false;
                MessageBox.Show("심장내과 의사 예약(오하늘) 대기 끝");

                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(오하늘)" && comboBox1.SelectedIndex == 1)

                    MessageBox.Show("심장내과 오하늘 진료 가능합니다");
                    comboBox3.Items.RemoveAt(3);
                    comboBox3.Items.Insert(3, "오하늘");

                }
            }
        } 

        //----------------------------------------심장내과 끝---------------------------------------//

            //-------------------------------------신경외과---------------------------------------//
        private void Timer9_Tick(object sender, EventArgs e)
        {
            time++;

            if (time > 900)
            {
                time = 0;
                timer.Enabled = false;
                MessageBox.Show("신경외과 의사 예약(강철구) 대기 끝");

                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(강철구)" && comboBox1.SelectedIndex == 2)

                        MessageBox.Show("신경외과 강철구 진료 가능합니다");
                    comboBox3.Items.RemoveAt(0);
                    comboBox3.Items.Insert(0, "강철구");
                }
            }
        }

        private void Timer10_Tick(object sender, EventArgs e)
        {
            time++;

            if (time > 950)
            {
                time = 0;
                timer.Enabled = false;
                MessageBox.Show("신경외과 의사 예약(조순철) 대기 끝");

                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(조순철)" && comboBox1.SelectedIndex == 2)

                        MessageBox.Show("신경외과 조순철 진료 가능합니다.");
                    comboBox3.Items.RemoveAt(1);
                    comboBox3.Items.Insert(1, "조순철");
                }
            }
        }

        private void Timer11_Tick(object sender, EventArgs e)
        {
            time++;

            if (time > 900)
            {
                time = 0;
                timer.Enabled = false;
                MessageBox.Show("신경외과 의사 예약(금지철) 대기 끝");

                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(금지철)" && comboBox1.SelectedIndex == 2)

                        MessageBox.Show("신경외과 금지철 진료 가능해짐");
                    comboBox3.Items.RemoveAt(2);
                    comboBox3.Items.Insert(2, "금지철");
                }
            }
        }

        private void Timer12_Tick(object sender, EventArgs e)
        {
            time++;

            if (time > 760)
            {
                time = 0;
                timer.Enabled = false;
                MessageBox.Show("신경외과 의사 예약(서한지) 대기 끝");

                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(서한지)" && comboBox1.SelectedIndex == 2)

                        MessageBox.Show("신경외과 서한지 진료 가능해짐");
                    comboBox3.Items.RemoveAt(3);
                    comboBox3.Items.Insert(3, "서한지");
                }
            }
        }
        //--------------------------------------신경외과 끝------------------------------------//

       //---------------------------------------소아청소년과---------------------------------//
        private void Timer13_Tick(object sender, EventArgs e)
        {
            time++;

            if (time > 900)
            {
                time = 0;
                timer.Enabled = false;
                MessageBox.Show("소아청소년과 의사 예약(차수미) 대기 끝");

                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(차수미)" && comboBox1.SelectedIndex == 3)

                        MessageBox.Show("소아청소년과 차수미 진료 가능합니다");
                    comboBox3.Items.RemoveAt(0);
                    comboBox3.Items.Insert(0, "차수미");
                }
            }
        }

        private void Timer14_Tick(object sender, EventArgs e)
        {
            time++;
            if (time > 660)
            {
                time = 0;
                timer.Enabled = false;

                MessageBox.Show("소아청소년과 의사 예약(장덕철) 대기 끝");

                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(장덕철)" && comboBox1.SelectedIndex == 3)

                        MessageBox.Show("소아청소년과 장덕철 진료 가능합니다");
                    comboBox3.Items.RemoveAt(1);
                    comboBox3.Items.Insert(1, "장덕철");
                }
            }
        }

        private void Timer15_Tick(object sender, EventArgs e)
        {
            time++;
            if (time > 1100)
            {
                time = 0;
                timer.Enabled = false;

                MessageBox.Show("소아청소년과 의사 예약(장제인) 대기 끝");

                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(장제인)" && comboBox1.SelectedIndex == 3)

                        MessageBox.Show("소아청소년과 장제인 진료 가능합니다");
                    comboBox3.Items.RemoveAt(2);
                    comboBox3.Items.Insert(2, "장덕철");
                }
            }
        }

        private void Timer16_Tick(object sender, EventArgs e)
        {
            time++;
            if (time > 1050)
            {
                time = 0;
                timer.Enabled = false;

                MessageBox.Show("소아청소년과 의사 예약(추성희) 대기 끝");

                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(추성희)" && comboBox1.SelectedIndex == 3)

                        MessageBox.Show("소아청소년과 추성희 진료 가능합니다");
                    comboBox3.Items.RemoveAt(3);
                    comboBox3.Items.Insert(3, "추성희");
                }
            }
        }
        //-----------------------------------소아청소년과 끝------------------------------------//

        //-----------------------------------이비인후과-----------------------------------------//
        private void Timer17_Tick(object sender, EventArgs e)
        {

            time++;

            if (time > 1400)
            {
                time = 0;
                timer.Enabled = false;
                MessageBox.Show("이비인후과 의사 예약(박수소) 대기 끝");

                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(박수소)" && comboBox1.SelectedIndex == 4)

                    MessageBox.Show("이비인후과 박수소 진료 가능합니다");
                    comboBox3.Items.RemoveAt(0);
                    comboBox3.Items.Insert(0, "박수소");
                }
            }
        }

        private void Timer18_Tick(object sender, EventArgs e)
        {
            time++;

            if (time > 1300)
            {
                time = 0;
                timer.Enabled = false;

                MessageBox.Show("이비인후과 의사 예약(이세희) 대기 끝");

                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(이세희)" && comboBox1.SelectedIndex == 4)

                    MessageBox.Show("이비인후과 이세희 진료 가능합니다");

                    comboBox3.Items.RemoveAt(1);
                    comboBox3.Items.Insert(1, "이세희");
                }
            }
        }

        private void Timer19_Tick(object sender, EventArgs e)
        {
            time++;

            if (time > 1240)
            {
                time = 0;
                timer.Enabled = false;

                MessageBox.Show("이비인후과 의사 예약(이고진) 대기 끝");

                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(이고진)" && comboBox1.SelectedIndex == 4)

                        MessageBox.Show("이비인후과 이고진 진료 가능합니다");

                    comboBox3.Items.RemoveAt(2);
                    comboBox3.Items.Insert(2, "이고진");
                }
            }
        }

        private void Timer20_Tick(object sender, EventArgs e)
        {

            time++;

            if (time > 1700)
            {
                time = 0;
                timer.Enabled = false;

                MessageBox.Show("이비인후과 의사 예약(진지혜) 대기 끝");

                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(진지혜)" && comboBox1.SelectedIndex == 4)

                        MessageBox.Show("이비인후과 진지혜 진료 가능합니다");

                    comboBox3.Items.RemoveAt(3);
                    comboBox3.Items.Insert(3, "진지혜");
                }
            }
        }
        //----------------------------------이비인후과 끝----------------------------------------//

        //----------------------------------소화기내과 시작-------------------------------------//
        private void Timer21_Tick(object sender, EventArgs e)
        {
            time++;

            if (time > 1900)
            {
                time = 0;
                timer.Enabled = false;
                MessageBox.Show("소화기내과 의사 예약(한곡의) 대기 끝");

                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(한곡의)" && comboBox1.SelectedIndex == 5)

                        MessageBox.Show("소화기내과 한곡의 진료 가능합니다");
                    comboBox3.Items.RemoveAt(0);
                    comboBox3.Items.Insert(0, "한곡의");
                }
            }
        }

        private void Timer22_Tick(object sender, EventArgs e)
        {
            time++;

            if (time > 450)
            {
                time = 0;
                timer.Enabled = false;
                MessageBox.Show("소화기내과 의사 예약(한고예) 대기 끝");

                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(한고예)" && comboBox1.SelectedIndex == 5)

                        MessageBox.Show("소화기내과 한고예 진료 가능합니다");
                    comboBox3.Items.RemoveAt(1);
                    comboBox3.Items.Insert(1, "한고예");
                }
            }
        }

        private void Timer23_Tick(object sender, EventArgs e)
        {

            time++;
            if (time > 300)

            {
                time = 0;
                timer.Enabled = false;

                MessageBox.Show("소화기내과 의사 예약(마동철) 대기 끝");

                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(마동철)" && comboBox1.SelectedIndex == 5)

                        MessageBox.Show("소화기내과 마동철 진료 가능합니다");
                    comboBox3.Items.RemoveAt(2);
                    comboBox3.Items.Insert(2, "마동철");
                }
            }
        }

        private void Timer24_Tick(object sender, EventArgs e)
        {

            time++;
            if (time > 1320)

            {
                time = 0;
                timer.Enabled = false;

                MessageBox.Show("소화기내과 의사 예약(마박세) 대기 끝");

                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(마박세)" && comboBox1.SelectedIndex == 5)

                        MessageBox.Show("소화기내과 마박세 진료 가능합니다");
                    comboBox3.Items.RemoveAt(3);
                    comboBox3.Items.Insert(3, "마박세");
                }
            }
        }

        //--------------------------------소화기내과 끝------------------------------------------//


        //----------------------------------치과--------------------------------------//
        private void Timer25_Tick(object sender, EventArgs e)
        {

            time++;
            if (time > 1850)
            {
                time = 0;
                timer.Enabled = false;
                MessageBox.Show("치과 의사 예약(이승철) 대기 끝");

                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(이승철)" && comboBox1.SelectedIndex == 6)

                        MessageBox.Show("치과 이승철 진료 가능합니다");
                    comboBox3.Items.RemoveAt(0);
                    comboBox3.Items.Insert(0, "이승철");
                }
            }
        }

        private void Timer26_Tick(object sender, EventArgs e)
        {
            time++;
            if (time > 1550)
            {
                time = 0;
                timer.Enabled = false;
                MessageBox.Show("치과 의사 예약(성재진) 대기 끝");

                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(성재진)" && comboBox1.SelectedIndex == 6)

                        MessageBox.Show("치과 성재진 진료 가능합니다");
                    comboBox3.Items.RemoveAt(1);
                    comboBox3.Items.Insert(1, "성재진");
                }
            }
        }

        private void Timer27_Tick(object sender, EventArgs e)
        {
            time++;
            if (time > 1330)
            {
                time = 0;
                timer.Enabled = false;
                MessageBox.Show("치과 의사 예약(이재진) 대기 끝");

                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(이재진)" && comboBox1.SelectedIndex == 6)

                        MessageBox.Show("치과 이재진 진료 가능합니다");
                    comboBox3.Items.RemoveAt(2);
                    comboBox3.Items.Insert(2, "이재진");
                }
            }
        }

        private void Timer28_Tick(object sender, EventArgs e)
        {
            time++;
            if (time > 2100)
            {
                time = 0;
                timer.Enabled = false;
                MessageBox.Show("치과 의사 예약(나진자) 대기 끝");

                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(나진자)" && comboBox1.SelectedIndex == 6)

                        MessageBox.Show("치과 나진자 진료 가능합니다");
                    comboBox3.Items.RemoveAt(3);
                    comboBox3.Items.Insert(3, "나진자");
                }
            }
        }
        //------------------------------------차과 끝-------------------------------//

        //------------------------------------정형외과-------------------------------//
        private void Timer29_Tick(object sender, EventArgs e)
        {
            time++;
            if (time > 2250)
            {
                time = 0;
                timer.Enabled = false;
                MessageBox.Show("정형외과 의사 예약(나선추) 대기 끝");

                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(나선추)" && comboBox1.SelectedIndex == 7)

                        MessageBox.Show("정형외과 나선추 진료 가능합니다");
                    comboBox3.Items.RemoveAt(0);
                    comboBox3.Items.Insert(0, "나선추");
                }
            }
        }

        private void Timer30_Tick(object sender, EventArgs e)
        {
            time++;
            if (time > 2200)
            {
                time = 0;
                timer.Enabled = false;
                MessageBox.Show("정형외과 의사 예약(추재준) 대기 끝");

                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(추재준)" && comboBox1.SelectedIndex == 7)

                        MessageBox.Show("정형외과 추재준 진료 가능합니다");
                    comboBox3.Items.RemoveAt(1);
                    comboBox3.Items.Insert(1, "추재준");
                }
            }
        }

        private void Timer31_Tick(object sender, EventArgs e)
        {
            time++;
            if (time > 1880)
            {
                time = 0;
                timer.Enabled = false;
                MessageBox.Show("정형외과 의사 예약(하선호) 대기 끝");

                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(하선호)" && comboBox1.SelectedIndex == 7)

                        MessageBox.Show("정형외과 하선호 진료 가능합니다");
                    comboBox3.Items.RemoveAt(2);
                    comboBox3.Items.Insert(2, "하선호");
                }
            }
        }

        private void Timer32_Tick(object sender, EventArgs e)
        {
            time++;
            if (time > 2800)
            {
                time = 0;
                timer.Enabled = false;
                MessageBox.Show("정형외과 의사 예약(하진주) 대기 끝");

                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(하진주)" && comboBox1.SelectedIndex == 7)

                        MessageBox.Show("정형외과 하진주 진료 가능합니다");
                    comboBox3.Items.RemoveAt(3);
                    comboBox3.Items.Insert(3, "하진주");
                }
            }
        }
        //--------------------------------정형외과 끝-------------------------------------//

        //-------------------------------------산부인과----------------------------------//
        private void Timer33_Tick(object sender, EventArgs e)
        {
            time++;
            if (time > 2400)
            {
                time = 0;
                timer.Enabled = false;
                MessageBox.Show("산부인과 의사 예약(오바람) 대기 끝");

                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(오바람)" && comboBox1.SelectedIndex == 8)

                        MessageBox.Show("산부인과 오바람 진료 가능합니다");
                    comboBox3.Items.RemoveAt(0);
                    comboBox3.Items.Insert(0, "오바람");
                }
            }
        }

        private void Timer34_Tick(object sender, EventArgs e)
        {
            time++;
            if (time > 777)
            {
                time = 0;
                timer.Enabled = false;
                MessageBox.Show("산부인과 의사 예약(오아람) 대기 끝");

                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(오아람)" && comboBox1.SelectedIndex == 8)

                        MessageBox.Show("산부인과 오아람 진료 가능합니다");
                    comboBox3.Items.RemoveAt(1);
                    comboBox3.Items.Insert(1, "오아람");
                }
            }
        }

        private void Timer35_Tick(object sender, EventArgs e)
        {
            time++;
            if (time > 1000)
            {
                time = 0;
                timer.Enabled = false;
                MessageBox.Show("산부인과 의사 예약(성후진) 대기 끝");

                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(성후진)" && comboBox1.SelectedIndex == 8)

                        MessageBox.Show("산부인과 성후진 진료 가능합니다");
                    comboBox3.Items.RemoveAt(2);
                    comboBox3.Items.Insert(2, "성후진");
                }
            }
        }

        private void Timer36_Tick(object sender, EventArgs e)
        {
            time++;
            if (time > 1600)
            {
                time = 0;
                timer.Enabled = false;
                MessageBox.Show("산부인과 의사 예약(강신후) 대기 끝");

                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(강신후)" && comboBox1.SelectedIndex == 8)

                        MessageBox.Show("산부인과 강신후 진료 가능합니다");
                    comboBox3.Items.RemoveAt(3);
                    comboBox3.Items.Insert(3, "강신후");
                }
            }
        }

        //------------------------------산부인과 끝-----------------------------------//

        
        //----------------------------------비뇨기과-----------------------------------//

        private void Timer37_Tick(object sender, EventArgs e)
        {
            time++;
            if (time > 3000)
            {
                time = 0;
                timer.Enabled = false;
                MessageBox.Show("비뇨기과 의사 예약(강도철) 대기 끝");

                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(강도철)" && comboBox1.SelectedIndex == 9)

                        MessageBox.Show("비뇨기과 강도철 진료 가능합니다");
                    comboBox3.Items.RemoveAt(0);
                    comboBox3.Items.Insert(0, "강도철");
                }
            }
        }

        private void Timer38_Tick(object sender, EventArgs e)
        {
            time++;
            if (time > 1600)
            {
                time = 0;
                timer.Enabled = false;
                MessageBox.Show("비뇨기과 의사 예약(한오루) 대기 끝");

                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(한오루)" && comboBox1.SelectedIndex == 9)

                        MessageBox.Show("비뇨기과 한오루 진료 가능합니다");
                    comboBox3.Items.RemoveAt(1);
                    comboBox3.Items.Insert(1, "한오루");
                }
            }
        }

        private void Timer39_Tick(object sender, EventArgs e)
        {
            time++;
            if (time > 800)
            {
                time = 0;
                timer.Enabled = false;
                MessageBox.Show("비뇨기과 의사 예약(한바람) 대기 끝");

                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(한바람)" && comboBox1.SelectedIndex == 9)

                        MessageBox.Show("비뇨기과 한바람 진료 가능합니다");
                    comboBox3.Items.RemoveAt(2);
                    comboBox3.Items.Insert(2, "한바람");
                }
            }
        }

        private void Timer40_Tick(object sender, EventArgs e)
        {
            time++;
            if (time > 2000)
            {
                time = 0;
                timer.Enabled = false;
                MessageBox.Show("비뇨기과 의사 예약(한지준) 대기 끝");

                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(한지준)" && comboBox1.SelectedIndex == 9)

                        MessageBox.Show("비뇨기과 한지준 진료 가능합니다");
                    comboBox3.Items.RemoveAt(3);
                    comboBox3.Items.Insert(3, "한지준");
                }
            }
        }
        //------------------------------비뇨기과 끝--------------------------------------//

       //--------------------------------신경과 시작----------------------------------------//
        private void Timer41_Tick(object sender, EventArgs e)
        {
            time++;
            if (time > 1000)
            {
                time = 0;
                timer.Enabled = false;
                MessageBox.Show("신경과 의사 예약(추종희) 대기 끝");

                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(추종희)" && comboBox1.SelectedIndex == 10)

                        MessageBox.Show("신경과 추종희 진료 가능합니다");
                    comboBox3.Items.RemoveAt(0);
                    comboBox3.Items.Insert(0, "추종희");
                }
            }
        }

        private void Timer42_Tick(object sender, EventArgs e)
        {
            time++;
            if (time > 700)
            {
                time = 0;
                timer.Enabled = false;
                MessageBox.Show("신경과 의사 예약(마진철) 대기 끝");

                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(마진철)" && comboBox1.SelectedIndex == 10)

                        MessageBox.Show("신경과 마진철 진료 가능합니다");
                    comboBox3.Items.RemoveAt(1);
                    comboBox3.Items.Insert(1, "마진철");
                }
            }
        }

        private void Timer43_Tick(object sender, EventArgs e)
        {
            time++;
            if (time > 1900)
            {
                time = 0;
                timer.Enabled = false;
                MessageBox.Show("신경과 의사 예약(마종진) 대기 끝");

                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(마종진)" && comboBox1.SelectedIndex == 10)

                        MessageBox.Show("신경과 마종진 진료 가능합니다");
                    comboBox3.Items.RemoveAt(2);
                    comboBox3.Items.Insert(2, "마종진");
                }
            }
        }

        private void Timer44_Tick(object sender, EventArgs e)
        {
            time++;
            if (time > 900)
            {
                time = 0;
                timer.Enabled = false;
                MessageBox.Show("신경과 의사 예약(홍선철) 대기 끝");

                if (timer.Enabled == false)
                {
                    if (comboBox3.Text == "예약(홍선철)" && comboBox1.SelectedIndex == 10)

                        MessageBox.Show("신경과 홍선철 진료 가능합니다");
                    comboBox3.Items.RemoveAt(3);
                    comboBox3.Items.Insert(3, "홍선철");
                }
            }
        }
        //-------------------------------신경과 끝------------------------------------//
        //---------------KEY METHOD AND SELECTQUERY END------------------------------//
    }
  }

