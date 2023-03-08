using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MisPis_WFA
{
    public partial class FormMap : Form
    {
        string login;
        List<ChartLoader> listChartLoader = new List<ChartLoader>();
        List<ChartLoader> listUnitChartLoader = new List<ChartLoader>();
        public FormMap()
        {
            InitializeComponent();
        }

        public FormMap(string login)
        {
            this.login = login;
            InitializeComponent();
        }

        private void SetCharts()
        {
            // public ChartLoader(int unit, int type, string login, Chart chart)
            listChartLoader.Add(new ChartLoader(1, 1, login, chartU1T1));
            listChartLoader.Add(new ChartLoader(1, 2, login, chartU1T2));
            listChartLoader.Add(new ChartLoader(1, 3, login, chartU1T3));
            listChartLoader.Add(new ChartLoader(2, 1, login, chartU2T1));
            listChartLoader.Add(new ChartLoader(2, 2, login, chartU2T2));
            listChartLoader.Add(new ChartLoader(2, 3, login, chartU2T3));
            listChartLoader.Add(new ChartLoader(3, 1, login, chartU3T1));
            listChartLoader.Add(new ChartLoader(3, 2, login, chartU3T2));
            listChartLoader.Add(new ChartLoader(3, 3, login, chartU3T3));

            listUnitChartLoader.Add(new ChartLoader(1, login, chartU1));
            listUnitChartLoader.Add(new ChartLoader(2, login, chartU2));
            listUnitChartLoader.Add(new ChartLoader(3, login, chartU3));

            ChartLoader course = new ChartLoader(listUnitChartLoader, chartCourse);
        }

        private void FormMap_Load(object sender, EventArgs e)
        {
            SetCharts();
        }
    }
}
