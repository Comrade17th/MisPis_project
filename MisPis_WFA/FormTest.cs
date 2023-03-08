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
    public partial class FormTest : Form
    {
        string login;
        int unit;
        int type;
        public FormTest()
        {
            InitializeComponent();
        }

        public FormTest(string login, int unit, int type)
        {
            this.login = login;
            this.unit = unit;
            this.type = type;
            InitializeComponent();
        }

        private void FormTest_Load(object sender, EventArgs e)
        {

        }
    }
}
