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
    public partial class TaikhoanDN : Form
    {
        public TaikhoanDN()
        {
            InitializeComponent();
        }

        private void TaikhoanDN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dangNhapDB.DangNhap' table. You can move, or remove it, as needed.
            this.dangNhapTableAdapter.Fill(this.dangNhapDB.DangNhap);
        }

        private void ThemTKDN_Click(object sender, EventArgs e)
        {
            ChiTietTKDN fr = new ChiTietTKDN();
            fr.btnSuaTKDN2.Visible = false;
            fr.btnThemTKDN2.DialogResult = DialogResult.OK;
            fr.ShowDialog();
            if (fr.DialogResult == DialogResult.OK)
            {
                // Lấy dữ liệu từ Form 2
                string TenDN = fr.tkdangnhap;
                string MatKhau = fr.matkhau;
                bool HoatDong = fr.hoatdong;
                string LoaiTK = fr.loai;
                string MaNV = fr.manv;
                try
                {
                    dangNhapTableAdapter.Insert(TenDN, MatKhau, HoatDong, LoaiTK, MaNV);
                    MessageBox.Show("Thêm xong, mời xem!");
                }
                catch (System.Exception ex) { MessageBox.Show("CÓ LỖI KHI THÊM TÀI KHOẢN ĐĂNG NHẬP MỚI " + ex.Message); }
                try
                {
                    //employeeDB.Employee.AcceptChanges(); 
                    this.dangNhapTableAdapter.Fill(this.dangNhapDB.DangNhap);
                }
                catch (System.Exception) { }
            }
        }
        public string SttDN;
        private void DataDelete(string SttDN)
        {
            DataTable dtDelete = new DataTable();
            dtDelete = ConnectSQL.Load("SELECT * FROM DangNhap WHERE SttDN = '" + SttDN + "'");
        }
        private void XoaTKDN_Click(object sender, EventArgs e)
        {
            DataDelete(SttDN);
            //B1: Hỏi xác nhận 
            DialogResult ch = MessageBox.Show("Bạn muốn xóa thông tin đăng nhập có số thứ tự:" + SttDN + "không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //B2: XÓA
            if (ch == DialogResult.Yes)
            {
                int SttDN2 = Convert.ToInt32(SttDN);
                try
                {
                    dangNhapTableAdapter.Delete(SttDN2);
                    MessageBox.Show("Đã xóa!");
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("CÓ LỖI XÓA THÔNG TIN: " + ex.Message);
                }
            }
            //B3: Tải BD lên DataGridView sau khi xóa
            try
            {
                this.dangNhapTableAdapter.Fill(this.dangNhapDB.DangNhap);
            }
            catch (System.Exception) { }
        }

        private void SuaTKDN_Click(object sender, EventArgs e)
        {
            ChiTietTKDN fr = new ChiTietTKDN();
            fr.btnThemTKDN2.Visible = false;
            fr.SetData(TenDN, MatKhau, HoatDong, Loai, MaNV);
            fr.btnSuaTKDN2.DialogResult = DialogResult.OK;
            fr.ShowDialog();
            if (fr.DialogResult == DialogResult.OK)
            {
                // Lấy dữ liệu từ Form 2
                string TenDN1 = fr.tkdangnhap;
                string MatKhau1 = fr.matkhau;
                bool HoatDong1 = fr.hoatdong;
                string Loai1 = fr.loai;
                string MaNV1 = fr.manv;
                int SttDN3 = Convert.ToInt32(SttDN);
                try
                {
                    // Gọi phương thức Update với các giá trị mới
                    dangNhapTableAdapter.Update(TenDN1, MatKhau1, HoatDong1, Loai1, MaNV1, SttDN3);
                    MessageBox.Show("Cập nhật thành công!");
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("CÓ LỖI KHI CẬP NHẬT TÀI KHOẢN ĐĂNG NHẬP: " + ex.Message);
                }
                try
                {
                    //employeeDB.Employee.AcceptChanges();
                    this.dangNhapTableAdapter.Fill(this.dangNhapDB.DangNhap);
                }
                catch (System.Exception) { }
            }
        }
        public string TenDN;
        public string MatKhau;
        public bool HoatDong;
        public string Loai;
        public string MaNV;
        private void dtgvTKNH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvTKDN.Rows[e.RowIndex];
                //Try try try
                SttDN = row.Cells[0].Value.ToString();
                TenDN = row.Cells[1].Value.ToString();
                MatKhau = row.Cells[2].Value.ToString();
                HoatDong = Convert.ToBoolean(row.Cells[3].Value);
                Loai = row.Cells[4].Value.ToString();
                MaNV = row.Cells[5].Value.ToString();
            }
        }
    }
}
