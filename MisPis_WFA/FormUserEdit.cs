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
    public partial class FormUserEdit : Form
    {
        database DB = new database();
        int selectedRow;

        public FormUserEdit()
        {
            InitializeComponent();
        }

        private void FormUserEdit_Load(object sender, EventArgs e)
        {
            // gonna be empty, not running
        }

        private void FormUserEdit_Load_1(object sender, EventArgs e)
        {
            // working
            CreateColumns();
            RefreshDataGridView(dataGridView2);
        }

        private void CreateColumns()
        {
            // (UserId, UserName, UserForName, UserLogin, UserPassword, UserRole) 
            dataGridView2.Columns.Add("UserId", "id");
            dataGridView2.Columns.Add("UserName", "Имя");
            dataGridView2.Columns.Add("UserForName", "Фамилие");
            dataGridView2.Columns.Add("UserLogin", "Логин");
            dataGridView2.Columns.Add("UserPassword", "Пароль");
            dataGridView2.Columns.Add("UserRole", "Роль");
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(
                record.GetInt32(0),
                record.GetString(1),
                record.GetString(2),
                record.GetString(3),
                record.GetString(4),
                record.GetString(5)
                );
        }

        private void RefreshDataGridView(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from Users";
            SqlCommand command = new SqlCommand(queryString, DB.GetConnection());
            DB.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
            DB.closeConnection();
        }

        private void AddUser()
        {
            DB.openConnection();

            string UserName = textBoxName.Text;
            string UserForName = textBoxForname.Text;
            string UserLogin = textBoxLogin.Text;
            string UserPassword = textBoxPassword.Text;
            string UserRole = textBoxRole.Text;
            if(UserName == "" || UserForName == "" || UserLogin == "" || UserName == "" || UserRole == "")
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                if (IsUserExsists(UserLogin))
                {
                    MessageBox.Show("Пользователь с таким логином уже есть, выберите другой логин!");
                }
                else
                {
                    string queryAdd = $"INSERT INTO Users (UserName, UserForName, UserLogin, UserPassword, UserRole) " +
                    $"VALUES('{UserName}', '{UserForName}', '{UserLogin}', '{UserPassword}', '{UserRole}'); ";
                    SqlCommand command = new SqlCommand(queryAdd, DB.GetConnection());
                    command.ExecuteNonQuery();
                    RefreshDataGridView(dataGridView2);
                }
            }
            DB.closeConnection();
        }

        private bool IsUserExsists(string login)
        {
            bool result = false;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querryString = $"select * from Users where UserLogin = '{login}'";
            SqlCommand command = new SqlCommand(querryString, DB.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count >= 1)
            {
                result = true;
            }

            return result;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void ChangeUser()
        {
            DB.openConnection();
            string UserLogin = textBoxLogin.Text;
            if (!IsAllFieldsAreFilled())
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                if (IsUserExsists(UserLogin))
                {
                    MessageBox.Show("Пользователь с таким логином уже есть, выберите другой логин!");
                }
                else
                {
                    string queryAdd = GetChangeQueryString();
                    SqlCommand command = new SqlCommand(queryAdd, DB.GetConnection());
                    command.ExecuteNonQuery();
                    RefreshDataGridView(dataGridView2);
                }
            }
            DB.closeConnection();
        }

        private bool IsAllFieldsAreFilled()
        {
            if (textBoxName.Text == "" ||
                textBoxForname.Text == "" ||
                textBoxLogin.Text == "" ||
                textBoxPassword.Text == "" ||
                textBoxRole.Text == "")
                return false;
            else
                return true;
        }

        private string GetChangeQueryString()
        {
            string UserId = label_need_id.Text;
            string UserName = textBoxName.Text;
            string UserForName = textBoxForname.Text;
            string UserLogin = textBoxLogin.Text;
            string UserPassword = textBoxPassword.Text;
            string UserRole = textBoxRole.Text;
            string result = $"UPDATE Users SET " +
                $"UserName = '{UserName}', " +
                $"UserForName = '{UserForName}', " +
                $"UserLogin = '{UserLogin}', " +
                $"UserPassword = '{UserPassword}', " +
                $"UserRole = '{UserRole}'" +
                $"WHERE UserId = {UserId}; ";
            return result;
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            ChangeUser();
        }

        private void RemoveUser()
        {
            DB.openConnection();
            string UserLogin = textBoxLogin.Text;
            
            if (IsUserExsists(UserLogin))
            {
                string queryAdd = GetRemoveQueryString();
                SqlCommand command = new SqlCommand(queryAdd, DB.GetConnection());
                command.ExecuteNonQuery();
                RefreshDataGridView(dataGridView2);
            }
            else
            {
                MessageBox.Show("Выберите пользователя, который существует");
            }
            DB.closeConnection();
        }

        private string GetRemoveQueryString()
        {
            string result = $"DELETE FROM Users WHERE UserId = {label_need_id.Text}";
            return result;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            RemoveUser();
        }

        private void DgwInfoToTextBoxes(DataGridViewCellEventArgs e)
        {
            // (UserName, UserForName, UserLogin, UserPassword, UserRole) 
            selectedRow = e.RowIndex;
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[selectedRow];
                label_need_id.Text = row.Cells[0].Value.ToString();
                textBoxName.Text = row.Cells[1].Value.ToString();
                textBoxForname.Text = row.Cells[2].Value.ToString();
                textBoxLogin.Text = row.Cells[3].Value.ToString();
                textBoxPassword.Text = row.Cells[4].Value.ToString();
                textBoxRole.Text = row.Cells[5].Value.ToString();

            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DgwInfoToTextBoxes(e);
        }

        private void ClearFields()
        {
            label_need_id.Text = "";
            textBoxName.Text = "";
            textBoxForname.Text = "";
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
            textBoxRole.Text = "";
        }

        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
