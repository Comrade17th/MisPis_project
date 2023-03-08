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

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void buttonChange_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {

        }

        private void DgwInfoToTextBoxes(DataGridViewCellEventArgs e)
        {
            // (UserName, UserForName, UserLogin, UserPassword, UserRole) 
            selectedRow = e.RowIndex;
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[selectedRow];
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
    }
}
