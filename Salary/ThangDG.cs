﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary
{
    public partial class ThangDG : Form
    {
        public ThangDG()
        {
            InitializeComponent();
        }

        private void ThangDG_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thangDGDB.ThangDG' table. You can move, or remove it, as needed.
            this.thangDGTableAdapter.Fill(this.thangDGDB.ThangDG);

        }
    }
}
