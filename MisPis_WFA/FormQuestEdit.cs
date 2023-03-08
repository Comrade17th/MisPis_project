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
    public partial class FormQuestEdit : Form
    {
        database DB = new database();
        int selectedUnit;
        int selectedType;

        public FormQuestEdit()
        {
            InitializeComponent();
        }

        private void FormQuestEdit_Load(object sender, EventArgs e)
        {
            ClearLabels();
            CreateUnitColumns();
            CreateTypeColumns();
            RefreshAllDataGridView();
        }

        private void ClearLabels()
        {
            labelTypeId.Text = "";
            labelUnitId.Text = "";
        }

        private void RefreshAllDataGridView()
        {
            RefreshDataGridViewUnit(dataGridViewUnits);
            RefreshDataGridViewType(dataGridViewQuestionTypes);
        }

        private void CreateUnitColumns()
        {
            // (UserId, UserName, UserForName, UserLogin, UserPassword, UserRole) 
            dataGridViewUnits.Columns.Add("UnitId", "id");
            dataGridViewUnits.Columns.Add("UnitName", "Название");
            dataGridViewUnits.Columns[0].Visible = false;
            
        }

        private void CreateTypeColumns()
        {
            // (UserId, UserName, UserForName, UserLogin, UserPassword, UserRole) 
            dataGridViewQuestionTypes.Columns.Add("QId", "id");
            dataGridViewQuestionTypes.Columns.Add("QName", "Тип");
            dataGridViewQuestionTypes.Columns[0].Visible = false;

        }

        private void ReadUnitSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(
                record.GetInt32(0),
                record.GetString(1)
                );
        }

        private void ReadTypeSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(
                record.GetInt32(0),
                record.GetString(1)
                );
        }

        private void RefreshDataGridViewUnit(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from Units";
            SqlCommand command = new SqlCommand(queryString, DB.GetConnection());
            DB.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadUnitSingleRow(dgw, reader);
            }
            reader.Close();
            DB.closeConnection();
        }

        private void RefreshDataGridViewType(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from QTypes";
            SqlCommand command = new SqlCommand(queryString, DB.GetConnection());
            DB.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadTypeSingleRow(dgw, reader);
            }
            reader.Close();
            DB.closeConnection();
        }

        private void DgwUnitToTextBox(DataGridViewCellEventArgs e)
        {
            // (UnitId, UnitName) 
            selectedUnit = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewUnits.Rows[selectedUnit];
                labelUnitId.Text = row.Cells[0].Value.ToString();
                textBoxUnitName.Text = row.Cells[1].Value.ToString();
                

            }
        }

        private void dataGridViewUnits_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DgwUnitToTextBox(e);
        }

        private void ChangeUnit()
        {
            DB.openConnection();
            string UnitName = textBoxUnitName.Text;
            if (UnitName == "")
            {
                MessageBox.Show("Заполните поле");
            }
            else
            {
                if (labelUnitId.Text == "")
                {
                    MessageBox.Show("Выберите сперва раздел!");
                }
                else
                {
                    string queryChange = GetChangeQueryStringUnit();
                    SqlCommand command = new SqlCommand(queryChange, DB.GetConnection());
                    command.ExecuteNonQuery();
                    RefreshDataGridViewUnit(dataGridViewUnits);
                }
            }
            DB.closeConnection();
        }

        private string GetChangeQueryStringUnit()
        {
            string result = $"update Units Set UnitName = '{textBoxUnitName.Text}' where UnitId = {labelUnitId.Text};";
            return result;
        }
        private void buttonChangeUnitName_Click(object sender, EventArgs e)
        {
            ChangeUnit();
            RefreshDataGridViewUnit(dataGridViewUnits);
        }

        private void DgwTypeToTextBox(DataGridViewCellEventArgs e)
        {
            // (UnitId, UnitName) 
            selectedType = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewQuestionTypes.Rows[selectedType];
                labelTypeId.Text = row.Cells[0].Value.ToString();
                textBoxQuestionType.Text = row.Cells[1].Value.ToString();
            }
        }

        private void dataGridViewQuestionTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DgwTypeToTextBox(e);
        }
    }
}
