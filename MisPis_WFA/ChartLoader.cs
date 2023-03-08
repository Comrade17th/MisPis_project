using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace MisPis_WFA
{
    internal class ChartLoader
    {
        database DB = new database();
        Chart chart;
        //legend colors
        Color color_POL = Color.FromArgb(194, 62, 62);
        Color color_CEL = Color.FromArgb(67, 69, 145);
        Color color_UME = Color.FromArgb(194, 131, 37);

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
            LoadData();
        }

        private void LoadData()
        {
            this.POL = GetReportResult(1);
            this.CEL = GetReportResult(2);
            this.UME = GetReportResult(3);
            SetPreference();
            UpdatePoints();
        }

        private void SetPreference()
        {
            chart.Series.Clear();
            // legend names
            chart.Series.Add("POL");
            chart.Series.Add("CEL");
            chart.Series.Add("UME");
            // legend colors
            chart.Series["POL"].Color = color_POL;
            chart.Series["CEL"].Color = color_CEL;
            chart.Series["UME"].Color = color_UME;

            //chart.Series["POL"].SetCustomProperty("PixelPointWidth", "10");
            //chart.Series["CEL"].SetCustomProperty("PixelPointWidth", "10");
            //chart.Series["UME"].SetCustomProperty("PixelPointWidth", "10");

            chart.ChartAreas[0].Position.Auto = false;
            chart.ChartAreas[0].Position.Height = 100F;
            chart.ChartAreas[0].Position.Width = 100F;
            chart.ChartAreas[0].Position.X = 0F;
            chart.ChartAreas[0].Position.Y = 0F;


            chart.ChartAreas[0].AxisY.Maximum = 1;

            chart.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
        }

        private void UpdatePoints()
        {
            chart.Series["POL"].Points.Clear();
            chart.Series["CEL"].Points.Clear();
            chart.Series["UME"].Points.Clear();

            chart.Series["POL"].Points.Add(POL);
            chart.Series["CEL"].Points.Add(CEL);
            chart.Series["UME"].Points.Add(UME);
        }

        public string GetInfo()
        {
            string result = $"Полнота: {POL}\nЦелостность: {CEL}\nУмение: {UME}";
            return result;
        }

        private double GetReportResult(int type)
        {
            double result = 0;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querryString = GetReportQueryString(unit, type);
            SqlCommand command = new SqlCommand(querryString, DB.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                result = Convert.ToDouble(table.Rows[0][0].ToString());
            }

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
