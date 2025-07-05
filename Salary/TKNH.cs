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
    public partial class TKNH : Form
    {
        public TKNH()
        {
            InitializeComponent();
        }

        private void TKNH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taiKhoanNHDB.TaiKhoanNH' table. You can move, or remove it, as needed.
            this.taiKhoanNHTableAdapter.Fill(this.taiKhoanNHDB.TaiKhoanNH);
        }

        private void ThemTKNH_Click(object sender, EventArgs e)
        {
            ChitietTKNH fr = new ChitietTKNH();
            fr.SuaTKNH2.Enabled = false;
            fr.ShowDialog();
        }

        private void SuaTKNH_Click(object sender, EventArgs e)
        {
            ChitietTKNH fr = new ChitietTKNH();
            fr.ThemTKNH2.Enabled = false;
            fr.ShowDialog();
        }
    }
}
