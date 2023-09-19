using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;
using static Simple.PassWord_SHA256;

namespace Simple

{

    public partial class Form1 : Form
    {
        string _server = "localhost"; //DB 서버 주소, 로컬일 경우 localhost
        int _port = 3306; //DB 서버 포트
        string _database = "simple"; //DB 이름
        string _id = "root"; //계정 아이디
        string _pw = "root"; //계정 비밀번호
        string _connectionAddress = "";

        public Form1()
        {
            InitializeComponent();
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();

                    int login_status = 0;

                    string loginid = txtID.Text;
                    string loginpwd = EncryptionHelper.EncryptionSHA256(txtPW.Text);


                    string selectQuery = "SELECT * FROM user WHERE username = \'" + loginid + "\' ";


                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);

                    MySqlDataReader userAccount = command.ExecuteReader();
                    // MySqlDataReader은 입력값을 받기 위함.
                    // Selectcommand 변수에 ExecuteReader() 객체를 통해 입력값을 받고,
                    // 해당 정보를 userAccount 변수에 저장한다.


                    while (userAccount.Read())
                    {
                        if (loginid == (string)userAccount["username"] && loginpwd == (string)userAccount["password"])
                        {
                            login_status = 1;
                        }
                    }
                    mysql.Close();

                    if (login_status == 1)
                    {
                        MessageBox.Show("로그인 완료");
                        this.Hide();
                        Form2 form2 = new Form2();
                        form2.ShowDialog();
                     
                    }
                    else
                    {
                        MessageBox.Show("회원 정보를 확인해 주세요.");
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
