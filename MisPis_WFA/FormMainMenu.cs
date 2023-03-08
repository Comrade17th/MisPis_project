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
    public partial class FormMainMenu : Form
    {
        string login;
        public FormMainMenu()
        {
            InitializeComponent();
        }

        public FormMainMenu(string login)
        {
            this.login = login;
            InitializeComponent();
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void OpenMap()
        {
            FormMap map = new FormMap(login);
            map.Show();
        }

        private void buttonMap_Click(object sender, EventArgs e)
        {
            OpenMap();
        }
    }
}
