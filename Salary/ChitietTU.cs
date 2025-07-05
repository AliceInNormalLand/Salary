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
    public partial class ChitietTU : Form
    {
        public ChitietTU()
        {
            InitializeComponent();
        }

        private void ChitietTU_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nhanVienDB.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.nhanVienDB.NhanVien);

        }
        public string matu { get; set; }
        public DateTime ngaylap { get; set; }
        public string manv { get; set; }
        public int sotien { get; set; }
        public string noidung { get; set; }

        private void ThemTU2_Click(object sender, EventArgs e)
        {
            //Num = txtstt.Text;
            matu = tbMaTU.Text;
            ngaylap = dtpTU.Value;
            manv = cbMaNV.SelectedValue.ToString().Trim();
            sotien = Convert.ToInt32(tbSoTienTU.Text);
            noidung = tbMoTa.Text;
            this.Close();
        }
    }
}
