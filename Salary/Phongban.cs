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
    public partial class Phongban : Form
    {
        public Phongban()
        {
            InitializeComponent();
        }

        private void Phongban_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phongBanDB.Phongban' table. You can move, or remove it, as needed.
            this.phongbanTableAdapter.Fill(this.phongBanDB.Phongban);
        }
    }
}
