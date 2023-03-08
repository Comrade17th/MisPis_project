using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MisPis_WFA
{
    public partial class Login : Form
    {
        database DB = new database();
        string role;
        string login;
        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '*';
            textBox_login.MaxLength = 50;
            textBox_password.MaxLength = 50;
        }

        private void Open_Temp_Menu()
        {
            FormTempMenu tempMenu = new FormTempMenu(role, login);
            this.Hide();
            tempMenu.Show();
        }

        private void SignIn()
        {
            string login = textBox_login.Text;
            string password = textBox_password.Text;
            if (login == "" || password == "")
            {
                MessageBox.Show("Пустые поля! Введите логин и пароль");
            }
            else
            {
                if (IsUserExsists(login, password))
                {
                    MessageBox.Show("Вы успешно вошли");
                    this.login = login;
                    Open_Temp_Menu();
                }
                else
                {
                    MessageBox.Show("Не удалось войти, проверьте логин и пароль!");
                }
            }
        }

        private bool IsUserExsists(string login, string password)
        {
            bool result = false;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querryString = $"select * from Users where UserLogin = '{login}' and UserPassword = '{password}'";
            SqlCommand command = new SqlCommand(querryString, DB.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 1)
                result = true;
            return result;
        }

        private void button_signin_Click(object sender, EventArgs e)
        {


            // check is textBoxes Filled

            // make sql select, check password
            // if user exist && pass good, open next form
            // else show errMsg

            SignIn();
        }
    }
}
