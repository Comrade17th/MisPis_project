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
    public partial class FormMaterials : Form
    {
        public FormMaterials()
        {
            InitializeComponent();
        }

        private void FormMaterials_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormPhotoViewer pv = new FormPhotoViewer("history");
            pv.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPhotoViewer pv = new FormPhotoViewer("scilab");
            pv.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPhotoViewer pv = new FormPhotoViewer("vm");
            pv.Show();
        }
    }
}
