using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;

namespace MisPis_WFA
{
    internal class ChartLoader
    {
        database DB = new database();
        Chart chart;
        int unit;
        int type;
        string login;

        double POL, CEL, UME;

        public ChartLoader()
        {

        }

        public ChartLoader(int unit, int type, string login, Chart chart)
        {
            this.unit = unit;
            this.type = type;
            this.login = login;
            this.chart = chart;
        }

        private void LoadData()
        {

        }

        private double GetReportResult()
        {
            double result = 0;

            return result;
        }

        private string GetReportQueryString()
        {
            string result = $"select top(1) Result from Report where UnitId = {unit} and QId = {type} and UserLogin = '{login}' order by Result desc;";
            return result;
        }

        private string GetReportQueryString(int unit, int type)
        {
            string result = $"select top(1) Result from Report where UnitId = {unit} and QId = {type} and UserLogin = '{login}' order by Result desc;";
            return result;
        }
    }
}
