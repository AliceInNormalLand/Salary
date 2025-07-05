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
    public partial class Hopdong : Form
    {
        public Hopdong()
        {
            InitializeComponent();
        }

        private void Hopdong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hopDongLDDB.HopDongLD' table. You can move, or remove it, as needed.
            this.hopDongLDTableAdapter.Fill(this.hopDongLDDB.HopDongLD);

        }

        private void ThemHDLD_Click(object sender, EventArgs e)
        {
            ChitietHD fr = new ChitietHD();
            fr.SuaHDLD2.Enabled = false;
            fr.ShowDialog();
        }

        private void SuaHDLD_Click(object sender, EventArgs e)
        {
            ChitietHD fr = new ChitietHD();
            fr.ThemHDLD2.Enabled = false;
            fr.ShowDialog();
        }
    }
}
