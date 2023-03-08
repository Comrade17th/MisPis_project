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
    public partial class FormMap : Form
    {
        string login;
        public FormMap()
        {
            InitializeComponent();
        }

        public FormMap(string login)
        {
            this.login = login;
            InitializeComponent();
        }

        private void FormMap_Load(object sender, EventArgs e)
        {

        }
    }
}
