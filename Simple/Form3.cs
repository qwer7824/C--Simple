using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
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

                        String Password = txtPW.Text;

                        


                        String result = EncryptionHelper.EncryptionSHA256(Password);

                        string insertQuery = string.Format("INSERT INTO user (username, password) VALUES ('{0}', '{1}');", txtID.Text, result);

                        MySqlCommand command = new MySqlCommand(insertQuery, mysql);
                        if (command.ExecuteNonQuery() != 1)
                            MessageBox.Show("Failed to insert data.");

                        txtID.Text = "";
                        txtPW.Text = "";

                }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
    }
}
