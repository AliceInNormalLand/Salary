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
    public partial class Chucvu : Form
    {
        public Chucvu()
        {
            InitializeComponent();
        }

        private void Chucvu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chucVuDB.ChucVu' table. You can move, or remove it, as needed.
            this.chucVuTableAdapter.Fill(this.chucVuDB.ChucVu);
        }


        private void ThemCV_Click(object sender, EventArgs e)
        {
            //ChitietBT fr = new ChitietBT();
            //fr.SuaCV2.Visible = false;
            //fr.ShowDialog();
        }

        private void SuaCV_Click(object sender, EventArgs e)
        {
            //ChitietBT fr = new ChitietBT();
            //fr.BtnLapBTTU.Visible = false;
            //fr.ShowDialog();
        }
    }
}
