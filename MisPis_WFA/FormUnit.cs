﻿using System;
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

        }

        private void OpenTest(int unit, int type)
        {

        }

        private void buttonTestType1_Click(object sender, EventArgs e)
        {

        }
    }
}
