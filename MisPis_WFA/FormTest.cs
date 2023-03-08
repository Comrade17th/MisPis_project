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
    public partial class FormTest : Form
    {
        database DB = new database();
        string login;
        int unit;
        int type;
        List<Question> listQuest = new List<Question>();
        List<RichTextBox> listRich = new List<RichTextBox>();
        List<TextBox> listTextBox = new List<TextBox>();
        int time = 1000*60; // 1 minute
        const int TIME_MODIFIER = 3;
        double testResult = 0;

        public FormTest()
        {
            InitializeComponent();
        }

        public FormTest(string login, int unit, int type)
        {
            this.login = login;
            this.unit = unit;
            this.type = type;
            InitializeComponent();
        }

        private void FormTest_Load(object sender, EventArgs e)
        {
            RichToList();
            TextBoxToList();
        }

        private void TextBoxToList()
        {
            listTextBox.Add(textBoxAns1);
            listTextBox.Add(textBoxAns2);
            listTextBox.Add(textBoxAns3);
        }

        private void RichToList()
        {
            listRich.Add(richTextBoxQuest1);
            listRich.Add(richTextBoxQuest2);
            listRich.Add(richTextBoxQuest3);
        }

        private void OpenMainMenu()
        {
            FormMainMenu formMainMenu = new FormMainMenu(login);
            formMainMenu.Show();
            this.Close();
        }

        private void buttonEndTest_Click(object sender, EventArgs e)
        {
            EndTest();
            // check, are u sure to end test

            // send to DB test result

            // show result message

            OpenMainMenu();
        }

        private void EndTest()
        {
            CalculateResult();
            MakeReport();
            MessageBox.Show($"{GetMarkString()}");
        }

        private string GetMarkString()
        {
            int mark = 0;

            if (testResult < 0.6)
                mark = 2;
            else if (testResult < 0.73)
                mark = 3;
            else if (testResult < 0.87)
                mark = 4;
            else
                mark = 5;
            string result = $"Ваша оценка: {mark} \nПри результате: {testResult}";

            return result;
        }

        private void CalculateResult()
        {
            double total = 0;
            for(int i = 0; i < listQuest.Count; i++)
            {
                total += listQuest[i].difficulty;
                if (listQuest[i].ans == listTextBox[i].Text)
                    testResult += listQuest[i].difficulty;
            }
            total /= listQuest.Count;
            testResult /= listQuest.Count;
            testResult /= total;
            testResult = Math.Round(testResult, 2);
        }

        private void MakeReport()
        {
            DB.openConnection();
            
            string queryAdd = GetQueryStringReport();
            SqlCommand command = new SqlCommand(queryAdd, DB.GetConnection());
            command.ExecuteNonQuery();
                
            DB.closeConnection();
        }

        private string GetQueryStringReport()
        {
            string result = $"INSERT INTO Report (UserLogin, Result, UnitId, QId) VALUES('{login}', {DoubleToStringDot(testResult)}, {unit}, {type});";
            return result;
        }

        private string DoubleToStringDot(double num)
        {
            string result = "";
            if(num != 0 || num != 1)
            {
                foreach(var c in num.ToString())
                {
                    if (c == ',')
                        result += '.';
                    else
                        result += c;
                }
            }
            return result;
        }

        private void StartTest()
        {
            // load quest text to richBoxes
            WriteQuestToList();
            WriteQuestToRich();
            SetTimer();
        }

        private void WriteQuestToRich()
        {
            for(int i = 0; i < listRich.Count;i++)
            {
                if(i < listQuest.Count)
                {
                    listRich[i].Text = listQuest[i].text;
                }
            }
        }

        private void WriteQuestToList()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string queryString = GetQueryStringQuest();
            SqlCommand command = new SqlCommand(queryString, DB.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            for(int i = 0; i < table.Rows.Count && i < 3; i++)
            { 
                Question question = new Question(
                    table.Rows[i][0].ToString(),
                    table.Rows[i][1].ToString(),
                    Convert.ToInt32(table.Rows[i][2].ToString())
                    );
                listQuest.Add(question);
            }
        }

        private string GetQueryStringQuest()
        {
            string result = $"select QuestText, QuestAns, QuestDiffculty from Quests where QId = {type} and UnitId = {unit};";

            return result;
        }

        private void buttonStartTest_Click(object sender, EventArgs e)
        {
            // set this.button inactive
            buttonStartTest.Enabled = false;
            StartTest();
            
            // load timer
            // start timer
        }

        private void SetTimer()
        {
            int minutes = 0;
            int i = 0;
            foreach (var quest in listQuest)
            {
                minutes += quest.difficulty;
                if (i >= 3)
                    break;
                i++;
            }
            minutes *= TIME_MODIFIER;
            time *= minutes;
            timer1.Interval = 1000; // 1 sec
            timer1.Enabled = true; 
        }

        private void MStoMinSec(int ms, out int min, out int sec)
        {
            ms /= 1000; // ms now hold sec
            min = ms / 60;
            sec = ms % 60;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int min, sec;
            MStoMinSec(time, out min, out sec);
            labelTimer.Text = $"Таймер: {min}:{sec}";
            if (time <= 0)
                EndTest();
            time -= timer1.Interval;
        }
    }
}
