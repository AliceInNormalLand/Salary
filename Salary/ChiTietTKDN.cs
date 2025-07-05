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
    public partial class ChiTietTKDN : Form
    {
        public ChiTietTKDN()
        {
            InitializeComponent();
        }

        public string tkdangnhap { get; set; }
        //public string Num { get; set; }
        public string matkhau { get; set; }
        public bool hoatdong { get; set; }
        public string loai;
        public string manv;
        private void btnThemTKDN2_Click(object sender, EventArgs e)
        {
            tkdangnhap = tbTDN.Text;
            matkhau = tbMK.Text; 
            hoatdong = ckbTTHD.Checked;
            loai = cbLTK.SelectedItem.ToString().Trim();
            manv = cbMNV.SelectedValue.ToString().Trim();
            this.Close();
        }
        public void SetData(string tkdangnhap, string matkhau, bool hoatdong, string loai, string manv)
        {
            tbTDN.Text = tkdangnhap;
            tbMK.Text = matkhau;
            ckbTTHD.Checked = hoatdong;
            cbLTK.SelectedItem = loai;
            // Load dữ liệu nhân viên từ CSDL
            DataTable nhanvien = ConnectSQL.Load(@"SELECT * FROM NhanVien WHERE MaNV = '" + manv + @"'");

            // Kiểm tra nếu có dữ liệu
            if (nhanvien.Rows.Count > 0)
            {
                // Thiết lập nguồn dữ liệu cho ComboBox nếu có dữ liệu
                cbMNV.DataSource = nhanvien;
                cbMNV.DisplayMember = "MaNV"; // Thay thế bằng tên cột phù hợp để hiển thị
                cbMNV.ValueMember = "MaNV";        // Thay thế bằng tên cột phù hợp cho giá trị

                // Set giá trị được chọn trong ComboBox
                cbMNV.SelectedValue = manv;
            }
            else
            {
                MessageBox.Show("Không có mã nhân viên này!");
                // Xử lý khi không tìm thấy dữ liệu
                // (ví dụ: hiển thị thông báo, thiết lập giá trị mặc định, hoặc làm điều gì đó phù hợp với ứng dụng của bạn)
                // Ví dụ:
                cbMNV.DataSource = null;
                cbMNV.Items.Clear();
                cbMNV.Text = "Không có dữ liệu";
            }
        }
        private void btnSuaTKDN2_Click(object sender, EventArgs e)
        {
            tkdangnhap = tbTDN.Text;
            matkhau = tbMK.Text;
            hoatdong = ckbTTHD.Checked;
            loai = cbLTK.SelectedItem.ToString().Trim();
            manv = cbMNV.SelectedValue.ToString().Trim();
            this.Close();
        }

        private void ChiTietTKDN_Load(object sender, EventArgs e)
        {
            this.nhanVienTableAdapter.Fill(this.nhanVienDB.NhanVien);
        }
    }
}
