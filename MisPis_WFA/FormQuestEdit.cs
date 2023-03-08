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
        int selectedQuest;

        public FormQuestEdit()
        {
            InitializeComponent();
        }

        private void FormQuestEdit_Load(object sender, EventArgs e)
        {
            ClearLabels();
            CreateUnitColumns();
            CreateTypeColumns();
            CreateQuestColumns();
            RefreshAllDataGridView();
        }

        private void ClearLabels()
        {
            labelTypeId.Text = "1";
            labelUnitId.Text = "1";
        }

        private void RefreshAllDataGridView()
        {
            RefreshDataGridViewUnit(dataGridViewUnits);
            RefreshDataGridViewType(dataGridViewQuestionTypes);
            RefreshDataGridViewQuest(dataGridViewQuestions);
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

        private void CreateQuestColumns()
        {
            //INSERT INTO Quests (UnitId, Qid, QuestDiffculty, QuestText, QuestAns) 
            dataGridViewQuestions.Columns.Add("QuestId", "id");
            dataGridViewQuestions.Columns.Add("UnitId", "UnitId");
            dataGridViewQuestions.Columns.Add("Qid", "TypeId");
            dataGridViewQuestions.Columns.Add("QuestDiffculty", "Сложность");
            dataGridViewQuestions.Columns.Add("QuestText", "Вопрос");
            dataGridViewQuestions.Columns.Add("QuestAns", "Ответ");
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

        private void ReadQuestSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(
                record.GetInt32(0),
                record.GetInt32(1),
                record.GetInt32(2),
                record.GetInt32(3),
                record.GetString(4),
                record.GetString(5)
                );
        }

        private void RefreshDataGridViewQuest(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from Quests where Qid = {labelTypeId.Text} and UnitId = {labelUnitId.Text}";
            SqlCommand command = new SqlCommand(queryString, DB.GetConnection());
            DB.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadQuestSingleRow(dgw, reader);
            }
            reader.Close();
            DB.closeConnection();
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
            RefreshDataGridViewQuest(dataGridViewQuestions);
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
            RefreshDataGridViewQuest(dataGridViewQuestions);
        }

        private void DgwQuestToTextBox(DataGridViewCellEventArgs e)
        {
            // (QuestId, UnitId, Qid, QuestDiffculty, QuestText, QuestAns) 
            selectedQuest = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewQuestions.Rows[selectedQuest];
                labelQuestId.Text = row.Cells[0].Value.ToString();
                textBoxDifficulty.Text = row.Cells[3].Value.ToString();
                richTextBoxQuest.Text = row.Cells[4].Value.ToString();
                textBoxAns.Text = row.Cells[5].Value.ToString();
            }
        }

        private void dataGridViewQuestions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DgwQuestToTextBox(e);
        }

        private void AddQuest()
        {
            DB.openConnection();            
            if (IsQuestFieldsEmpty())
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                if (IsDifficultyNum())
                {
                    string queryAdd = GetAddQueryStringQuest();
                    SqlCommand command = new SqlCommand(queryAdd, DB.GetConnection());
                    command.ExecuteNonQuery();
                    RefreshDataGridViewQuest(dataGridViewQuestions);
                }
                else
                {
                    MessageBox.Show("В поле сложности должно быть число!");
                }
            }
            DB.closeConnection();
        }

        private bool IsDifficultyNum()
        {
            int num = 0;
            return int.TryParse(textBoxDifficulty.Text, out num);
        }

        private bool IsQuestFieldsEmpty()
        {
            if (richTextBoxQuest.Text == "" ||
                textBoxAns.Text == "" ||
                textBoxDifficulty.Text == "")
                return true;
            else
                return false;
        }

        private string GetAddQueryStringQuest()
        {
            string result = $"INSERT INTO Quests (UnitId, Qid, QuestDiffculty, QuestText, QuestAns) VALUES" +
                $"({labelUnitId.Text}, " +
                $"{labelTypeId.Text}, " +
                $"{textBoxDifficulty.Text}, " +
                $"'{richTextBoxQuest.Text}', " +
                $"'{textBoxAns.Text}'); ";
            return result;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddQuest();
            RefreshDataGridViewQuest(dataGridViewQuestions);
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
