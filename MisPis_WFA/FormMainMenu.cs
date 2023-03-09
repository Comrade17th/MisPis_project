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

        private void OpenFormUnit(int unit)
        {
            FormUnit unitForm = new FormUnit(login,unit);
            unitForm.Show();
            this.Close();
        }

        private void buttonUnit1_Click(object sender, EventArgs e)
        {
            OpenFormUnit(1);
        }

        private void buttonUnit2_Click(object sender, EventArgs e)
        {
            OpenFormUnit(2);
        }

        private void buttonUnit3_Click(object sender, EventArgs e)
        {
            OpenFormUnit(3);
        }

        private void OpenMaterials()
        {
            FormMaterials formMaterials = new FormMaterials();
            formMaterials.Show();
        }

        private void buttonMaterials_Click(object sender, EventArgs e)
        {
            OpenMaterials();
        }
    }
}
