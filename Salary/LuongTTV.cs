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
    public partial class LuongTTV : Form
    {
        public LuongTTV()
        {
            InitializeComponent();
        }

        private void LuongTTV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toiThieuVungDB.ToiThieuVung' table. You can move, or remove it, as needed.
            this.toiThieuVungTableAdapter.Fill(this.toiThieuVungDB.ToiThieuVung);
        }

        private void ThemLTTV_Click(object sender, EventArgs e)
        {
            ChitietLTTV fr = new ChitietLTTV();
            fr.SuaLTTV2.Enabled = false;
            fr.ShowDialog();
        }

        private void SuaLTTV_Click(object sender, EventArgs e)
        {
            ChitietLTTV fr = new ChitietLTTV();
            fr.ThemLTTV2.Enabled = false;
            fr.ShowDialog();
        }
    }
}
