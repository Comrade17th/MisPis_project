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
    public partial class Login : Form
    {
        string role;
        string login;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Open_Temp_Menu()
        {
            FormTempMenu tempMenu = new FormTempMenu(role, login);
            this.Hide();
            tempMenu.Show();
        }

        private void button_signin_Click(object sender, EventArgs e)
        {
            Open_Temp_Menu();
        }
    }
}
