using System;
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
    public partial class DanhGia : Form
    {
        public DanhGia()
        {
            InitializeComponent();
        }

        private void DanhGia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'danhGiaDB.Danhgia' table. You can move, or remove it, as needed.
            this.danhgiaTableAdapter.Fill(this.danhGiaDB.Danhgia);
            // TODO: This line of code loads data into the 'danhGiaDB.Danhgia' table. You can move, or remove it, as needed.
            this.danhgiaTableAdapter.Fill(this.danhGiaDB.Danhgia);

        }

        private void ThemDG_Click(object sender, EventArgs e)
        {

        }
    }
}
