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
    public partial class FormUnit : Form
    {
        string login;
        int unit;
        ChartLoader chartLoader = new ChartLoader();
        public FormUnit()
        {
            InitializeComponent();
        }

        public FormUnit(string login, int unit)
        {
            this.login = login;
            this.unit = unit;
            InitializeComponent();
        }

        private void FormUnit_Load(object sender, EventArgs e)
        {
            LoadChart();
        }

        private void LoadChart()
        {
            chartLoader = new ChartLoader(unit, login, chartUnit);
        }

        private void OpenTest(int type)
        {
            FormTest test = new FormTest(login, unit, type);
            test.Show();
            this.Close();
        }

        private void buttonTestType1_Click(object sender, EventArgs e)
        {
            OpenTest(1);
        }

        private void buttonTestType2_Click(object sender, EventArgs e)
        {
            OpenTest(2);
        }

        private void buttonTestType3_Click(object sender, EventArgs e)
        {
            OpenTest(3);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormMainMenu mainMenu = new FormMainMenu(login);
            mainMenu.Show();
            this.Close();
        }
    }
}
