using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MisPis_WFA
{
    public partial class FormTempMenu : Form
    {
        string role;
        string login;
        public FormTempMenu()
        {
            InitializeComponent();
        }

        public FormTempMenu(string role, string login)
        {
            this.role = role;
            this.login = login;
            InitializeComponent();
        }

        private void FormTempMenu_Load(object sender, EventArgs e)
        {
            //MessageBox.Show($"Ваша роль:{this.role}");
            SetEditButtonsVisibality();
        }

        private void SetEditButtonsVisibality()
        {
            switch (CheckRole())
            {
                case 0:
                    buttonQuestEdit.Visible = false;
                    buttonUserEdit.Visible = false;
                    break;
                case 1:
                    buttonQuestEdit.Visible = true;
                    buttonUserEdit.Visible = false;
                    break;
                case 2:
                    buttonQuestEdit.Visible = true;
                    buttonUserEdit.Visible = true;
                    break;
            }
                
        }

        private int CheckRole() // 0 - user, 1 - master(lecture), 2 - admin
        {
            int result = 0;
            if (role == "user" || role == "")
                result = 0;
            if (role == "master")
                result = 1;
            if (role == "admin")
                result = 2;
            return result;
        }

        private void OpenMainMenu()
        {
            FormMainMenu mainMenu = new FormMainMenu(login);
            this.Hide();
            mainMenu.Show();
        }

        private void buttonOpenMainMenu_Click(object sender, EventArgs e)
        {
            OpenMainMenu();
        }

        private void OpenUserEdit()
        {
            FormUserEdit formUserEdit = new FormUserEdit();
            formUserEdit.Show();
        }

        private void buttonUserEdit_Click(object sender, EventArgs e)
        {
            OpenUserEdit();
        }

        private void OpenQuestEdit()
        {
            FormQuestEdit formQuestEdit = new FormQuestEdit();
            formQuestEdit.Show();
        }
        private void buttonQuestEdit_Click(object sender, EventArgs e)
        {
            OpenQuestEdit();
        }
    }
}
