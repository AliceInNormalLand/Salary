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
    public partial class ChitietCD : Form
    {
        public ChitietCD()
        {
            InitializeComponent();
        }

        private void ChitietCD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nhanVienDB.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.nhanVienDB.NhanVien);
            // TODO: This line of code loads data into the 'danhGiaDB.Danhgia' table. You can move, or remove it, as needed.
            this.danhgiaTableAdapter.Fill(this.danhGiaDB.Danhgia);

        }

        public DateTime NgayLap { get; set; }
        //public string Num { get; set; }
        public string manv { get; set; }
        public int DanhGia { get; set; }
        public string GhiChu { get; set; }
        public int Diem { get; set; }
        private void ThemCD2_Click(object sender, EventArgs e)
        {
            //DateTime selectedDate2 = dtpCD.Value;
            //NgayLap = selectedDate2.ToString("yyyy-MM-dd");
            //NgayLapBT = DtpBT.Value;
            //Num = txtstt.Text;
            NgayLap = dtpCD.Value;
            manv = cbMaNV.SelectedValue.ToString().Trim();
            DanhGia = CbDG.SelectedIndex + 1;
            GhiChu = CbGhiChu.SelectedValue.ToString().Trim();
            Diem = (int)CbDiem.SelectedValue;
            this.Close();
        }
    }
}
