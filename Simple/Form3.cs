using MySql.Data.MySqlClient;
using System;
using static Simple.PassWord_SHA256;

namespace Simple
{
    public partial class Form3 : Form
    {
        string _server = "localhost"; //DB 서버 주소, 로컬일 경우 localhost
        int _port = 3306; //DB 서버 포트
        string _database = "simple"; //DB 이름
        string _id = "root"; //계정 아이디
        string _pw = "root"; //계정 비밀번호
        string _connectionAddress = "";

        public Form3()
        {
            InitializeComponent();
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);
        }

            private void btnLogin_Click(object sender, EventArgs e)
            {
                try
                {
                    using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                    {
                        mysql.Open();

                        String username = txtID.Text;
                        String Password = txtPW.Text;

                    Boolean Sign = true;
                     
                    String result = EncryptionHelper.EncryptionSHA256(Password);

                    string selectQuery = "SELECT * FROM user WHERE username = \'" + username + "\' ";

                    MySqlCommand user = new MySqlCommand(selectQuery, mysql);

                    MySqlDataReader userAccount = user.ExecuteReader();

                    while (userAccount.Read())
                    {
                        if (username == (string)userAccount["username"])
                        {
                            MessageBox.Show("이미 있는 아이디 입니다.");
                            Sign=false;
                        }
                        else
                        {
                            Sign = true;
                        }
                        
                    }
                    userAccount.Close();

                    if (Sign == true)
                    {
                        string insertQuery = string.Format("INSERT INTO user (username, password) VALUES ('{0}', '{1}');", txtID.Text, result);

                        MySqlCommand command = new(insertQuery, mysql);
                        if (command.ExecuteNonQuery() != 1)
                            MessageBox.Show("Failed to insert data.");

                        MessageBox.Show("회원가입 완료");
                        txtID.Text = "";
                        txtPW.Text = "";
                    }
                }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
    }
}
