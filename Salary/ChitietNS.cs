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
    public partial class ChitietNS : Form
    {
        public ChitietNS()
        {
            InitializeComponent();
        }
        public void SetData(string manv, string tennv, string gioitinh, string ngaysinh, string socmnd, string sdt, string mail, string masothue, string chucvu, string phongban, bool congdoan, string tinhtrang, string ngayvaolam)
        {
            txtmnv.Text = manv;
            txthvtnv.Text = tennv;
            txtgt.Text = gioitinh;
            dtpns.Text = ngaysinh;
            txtcv.Text = chucvu;
            txtpb.Text = phongban;
            txtcccd.Text = socmnd;
            txtsdt.Text = sdt;
            txtemail.Text = mail;
            txtmst.Text = masothue;
            txttt.Text = tinhtrang;
            dtpnvl.Text = ngayvaolam;
            cbcd.Checked = congdoan;
        }

        private void ChitietNS_Load(object sender, EventArgs e)
        {

        }
        public string MaNV { get; set; }
        //public string Num { get; set; }
        public string TenNV { get; set; }
        public string GioiTinh { get; set; }
        public string NgaySinh { get; set; }
        public string ChucVu { get; set; }
        public string PhongBan { get; set; }
        public string SoCMND { get; set; }
        public string SDT { get; set; }
        public string Mail { get; set; }
        public string MaSoThue { get; set; }
        public string TinhTrang { get; set; }
        public string NgayVaoLam { get; set; }
        public bool CongDoan { get; set; }
        private void ThemNS2_Click(object sender, EventArgs e)
        {
            //Num = txtstt.Text;
            MaNV = txtmnv.Text;
            TenNV = txthvtnv.Text;
            GioiTinh = txtgt.Text;
            NgaySinh = dtpns.Text;
            ChucVu = txtcv.Text;
            PhongBan = txtpb.Text;
            SoCMND = txtcccd.Text;
            SDT = txtsdt.Text;
            Mail = txtemail.Text;
            MaSoThue = txtmst.Text;
            TinhTrang = txttt.Text;
            NgayVaoLam = dtpnvl.Text;
            CongDoan = cbcd.Checked;
            this.Close();
        }

        private void SuaNS2_Click(object sender, EventArgs e)
        {
            //Num = txtstt.Text;
            TenNV = txthvtnv.Text;
            GioiTinh = txtgt.Text;
            NgaySinh = dtpns.Text;
            ChucVu = txtcv.Text;
            PhongBan = txtpb.Text;
            SoCMND = txtcccd.Text;
            SDT = txtsdt.Text;
            Mail = txtemail.Text;
            MaSoThue = txtmst.Text;
            TinhTrang = txttt.Text;
            NgayVaoLam = dtpnvl.Text;
            CongDoan = cbcd.Checked;
            this.Close();
        }
    }
}
