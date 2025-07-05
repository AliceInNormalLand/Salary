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
    public partial class UyNhiemChi : Form
    {
        public UyNhiemChi()
        {
            InitializeComponent();
        }

        private void UyNhiemChi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uyNhiemChiDB.UyNhiemChi' table. You can move, or remove it, as needed.
            this.uyNhiemChiTableAdapter.Fill(this.uyNhiemChiDB.UyNhiemChi);
        }

        private DataTable dtNew1 = new DataTable();
        private DataTable dtNew2 = new DataTable();
        private DataTable dtNew3 = new DataTable();
        private DataTable dtNew4 = new DataTable(); // Khai báo biến DataTable ở mức độ lớp để có thể sử dụng nhiều hàm
        private void UyNhiemChi_Click(object sender, EventArgs e)
        {
            int thanglap = CbThangCT.SelectedIndex + 1;
            string namlap = CbNamCT.SelectedItem.ToString();
            string ngaylap = dtpNgaylapUNC.Text.Trim();
            string noidungchon = CbChonCT.SelectedItem.ToString();
            DateTime ngaylap2 = dtpNgaylapUNC.Value;
            if (noidungchon == "Tạm ứng lương")
            {
                sttTTNCNDataGridViewTextBoxColumn.Visible = false;
                sttBLDataGridViewTextBoxColumn.Visible = false;
                MaSoThue.Visible = false;
                //maTUDataGridViewTextBoxColumn.Visible = false;
                sttBHDataGridViewTextBoxColumn.Visible = false;
                sttTKNHDataGridViewTextBoxColumn.Visible = false;
                DataTable dtData = ConnectSQL.Load(@"
                SELECT MaTU, SoTien, MoTa, SoTKNH, TenTKNH, TenNH, SttTKNH
                FROM TamUng
                LEFT JOIN TaiKhoanNH on TamUng.MaNV = TaiKhoanNH.MaNV
                WHERE MONTH(NgayLap) = '" + thanglap.ToString() + "' AND YEAR(NgayLap) = '" + namlap + @"'");
                // Tạo DataTable mới
                //DataTable dtNew = new DataTable();
                DataColumn columnSttUNC = new DataColumn("SttUNC", typeof(int));
                columnSttUNC.AutoIncrement = true;
                columnSttUNC.AutoIncrementSeed = 1; // Giá trị bắt đầu của số tự động tăng
                dtNew2.Columns.Add(columnSttUNC);
                dtNew2.Columns.Add("Ngaylap", typeof(DateTime));
                dtNew2.Columns.Add("Noidung", typeof(string));
                dtNew2.Columns.Add("Sotien", typeof(int));
                dtNew2.Columns.Add("SttTTNCN", typeof(int));
                dtNew2.Columns.Add("SttBL", typeof(int));
                dtNew2.Columns.Add("MaTU", typeof(string));
                dtNew2.Columns.Add("SttBH", typeof(int));
                dtNew2.Columns.Add("SttTKNH", typeof(int));
                dtNew2.Columns.Add("SoTKNH", typeof(string));
                dtNew2.Columns.Add("TenTKNH", typeof(string));
                dtNew2.Columns.Add("TenNH", typeof(string));
                foreach (DataRow row in dtData.Rows)
                {
                    string NoiDung = Convert.ToString(row["MoTa"]);
                    int SoTien = Convert.ToInt32(row["SoTien"]);
                    int? SttTTNCN = null;
                    int? SttBL = null;
                    string MaTU = Convert.ToString(row["MaTU"]).Trim();
                    int? SttBH = null;
                    int SttTKNH = Convert.ToInt32(row["SttTKNH"]);
                    string SoTKNH = Convert.ToString(row["SoTKNH"]);
                    string TenTKNH = Convert.ToString(row["TenTKNH"]);
                    string TenNH = Convert.ToString(row["TenNH"]);
                    // Thêm dữ liệu vào DataTable mới
                    dtNew2.Rows.Add(null, ngaylap2, NoiDung, SoTien, SttTTNCN, SttBL, MaTU, SttBH, SttTKNH, SoTKNH, TenTKNH, TenNH);
                    try
                    {
                        // Thêm giá trị vào DataTable của DataGridView
                        uyNhiemChiTableAdapter.Insert(ngaylap2, NoiDung, SoTien, SttTTNCN, SttBL, MaTU, SttBH, SttTKNH);
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("CÓ LỖI KHI TẠO DANH SÁCH BẢNG LƯƠNG MỚI " + ex.Message);
                    }
                }
                // Hiển thị DataTable mới trên DataGridView
                dtgvUNC.DataSource = dtNew2;
                // Calculate the sum of "SoTien" column
                int totalSoTien = dtNew2.AsEnumerable().Sum(row => row.Field<int>("SoTien"));
                // Set the sum to the TextBox
                tbTongTien.Text = totalSoTien.ToString();
                tbTongTien.Enabled = false;
                this.uyNhiemChiTableAdapter.Fill(this.uyNhiemChiDB.UyNhiemChi);
                MessageBox.Show("Thêm xong, mời xem!");
            }
            if (noidungchon == "Bảng lương")
            {
                sttTTNCNDataGridViewTextBoxColumn.Visible = false;
                MaSoThue.Visible = false;
                //sttBLDataGridViewTextBoxColumn.Visible = false;
                maTUDataGridViewTextBoxColumn.Visible = false;
                sttBHDataGridViewTextBoxColumn.Visible = false;
                sttTKNHDataGridViewTextBoxColumn.Visible = false;
                DataTable dtData = ConnectSQL.Load(@"
                SELECT SttBL, LuongTN, SoTKNH, TenNV, TenTKNH, TenNH, SttTKNH
                FROM BangLuong
                LEFT JOIN LuongCN on BangLuong.SttLCN = LuongCN.SttLCN
                LEFT JOIN TaiKhoanNH on LuongCN.MaNV = TaiKhoanNH.MaNV
                LEFT JOIN NhanVien on LuongCN.MaNV = NhanVien.MaNV
                WHERE MONTH(BangLuong.NgayLap) = '" + thanglap.ToString() + "' AND YEAR(BangLuong.NgayLap) = '" + namlap + @"'");
                // Tạo DataTable mới
                //DataTable dtNew = new DataTable();
                DataColumn columnSttUNC = new DataColumn("SttUNC", typeof(int));
                columnSttUNC.AutoIncrement = true;
                columnSttUNC.AutoIncrementSeed = 1; // Giá trị bắt đầu của số tự động tăng
                dtNew1.Columns.Add(columnSttUNC);
                dtNew1.Columns.Add("Ngaylap", typeof(DateTime));
                dtNew1.Columns.Add("Noidung", typeof(string));
                dtNew1.Columns.Add("Sotien", typeof(int));
                dtNew1.Columns.Add("SttTTNCN", typeof(int));
                dtNew1.Columns.Add("SttBL", typeof(int));
                dtNew1.Columns.Add("MaTU", typeof(string));
                dtNew1.Columns.Add("SttBH", typeof(int));
                dtNew1.Columns.Add("SttTKNH", typeof(int));
                dtNew1.Columns.Add("SoTKNH", typeof(string));
                dtNew1.Columns.Add("TenTKNH", typeof(string));
                dtNew1.Columns.Add("TenNH", typeof(string));
                foreach (DataRow row in dtData.Rows)
                {
                    string NoiDung = "Trả lương nhân viên: " + Convert.ToString(row["TenNV"]);
                    int SoTien = Convert.ToInt32(row["LuongTN"]);
                    int? SttTTNCN = null;
                    int SttBL = Convert.ToInt32(row["SttBL"]);
                    string MaTU = null;
                    int? SttBH = null;
                    int SttTKNH = Convert.ToInt32(row["SttTKNH"]);
                    string SoTKNH = Convert.ToString(row["SoTKNH"]);
                    string TenTKNH = Convert.ToString(row["TenTKNH"]);
                    string TenNH = Convert.ToString(row["TenNH"]);
                    // Thêm dữ liệu vào DataTable mới
                    dtNew1.Rows.Add(null, ngaylap2, NoiDung, SoTien, SttTTNCN, SttBL, MaTU, SttBH, SttTKNH, SoTKNH, TenTKNH, TenNH);
                    try
                    {
                        // Thêm giá trị vào DataTable của DataGridView
                        uyNhiemChiTableAdapter.Insert(ngaylap2, NoiDung, SoTien, SttTTNCN, SttBL, MaTU, SttBH, SttTKNH);
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("CÓ LỖI KHI TẠO DANH SÁCH BẢNG LƯƠNG MỚI " + ex.Message);
                    }
                }
                // Hiển thị DataTable mới trên DataGridView
                dtgvUNC.DataSource = dtNew1;
                // Calculate the sum of "SoTien" column
                int totalSoTien = dtNew1.AsEnumerable().Sum(row => row.Field<int>("SoTien"));
                // Set the sum to the TextBox
                tbTongTien.Text = totalSoTien.ToString();
                tbTongTien.Enabled = false;
                this.uyNhiemChiTableAdapter.Fill(this.uyNhiemChiDB.UyNhiemChi);
                MessageBox.Show("Thêm xong, mời xem!");
            }
            if (noidungchon == "Thuế thu nhập cá nhân")
            {
                //sttTTNCNDataGridViewTextBoxColumn.Visible = false;
                sttBLDataGridViewTextBoxColumn.Visible = false;
                maTUDataGridViewTextBoxColumn.Visible = false;
                sttBHDataGridViewTextBoxColumn.Visible = false;
                sttTKNHDataGridViewTextBoxColumn.Visible = false;
                SoTKNH.Visible = false;
                TenTKNH.Visible = false;
                TenNH.Visible = false;
                DataTable dtData = ConnectSQL.Load(@"
                SELECT SttTTNCN, ThueTNCN, NhanVien.TenNV, MaSoThue, SttTKNH, SoTKNH, TenTKNH, TenNH
                FROM ThueTNCN
                LEFT JOIN LuongCN ON ThueTNCN.SttLCN = LuongCN.SttLCN
                LEFT JOIN NhanVien ON LuongCN.MaNV = NhanVien.MaNV
                LEFT JOIN TaiKhoanNH ON LoaiTK = N'KBNN'
                WHERE MONTH(ThueTNCN.NgayLap) = '" + thanglap.ToString() + "' AND YEAR(ThueTNCN.NgayLap) = '" + namlap + @"'");
                // Tạo DataTable mới
                //DataTable dtNew = new DataTable();
                DataColumn columnSttUNC = new DataColumn("SttUNC", typeof(int));
                columnSttUNC.AutoIncrement = true;
                columnSttUNC.AutoIncrementSeed = 1; // Giá trị bắt đầu của số tự động tăng
                dtNew3.Columns.Add(columnSttUNC);
                dtNew3.Columns.Add("Ngaylap", typeof(DateTime));
                dtNew3.Columns.Add("Noidung", typeof(string));
                dtNew3.Columns.Add("Sotien", typeof(int));
                dtNew3.Columns.Add("SttTTNCN", typeof(int));
                dtNew3.Columns.Add("MaSoThue", typeof(string));
                dtNew3.Columns.Add("SttBL", typeof(int));
                dtNew3.Columns.Add("MaTU", typeof(string));
                dtNew3.Columns.Add("SttBH", typeof(int));
                dtNew3.Columns.Add("SttTKNH", typeof(int));
                dtNew3.Columns.Add("SoTKNH", typeof(string));
                dtNew3.Columns.Add("TenTKNH", typeof(string));
                dtNew3.Columns.Add("TenNH", typeof(string));
                foreach (DataRow row in dtData.Rows)
                {
                    string NoiDung = "Tiền thuế TNCN của nhân viên: " + Convert.ToString(row["TenNV"]);
                    int SoTien = Convert.ToInt32(row["ThueTNCN"]);
                    int SttTTNCN = Convert.ToInt32(row["SttTTNCN"]); 
                    int? SttBL = null;
                    string MaTU = null;
                    int? SttBH = null;
                    int SttTKNH = Convert.ToInt32(row["SttTKNH"]);
                    string MaSoThue = Convert.ToString(row["MaSoThue"]);
                    string SoTKNH = Convert.ToString(row["SoTKNH"]);
                    string TenTKNH = Convert.ToString(row["TenTKNH"]);
                    string TenNH = Convert.ToString(row["TenNH"]);
                    // Thêm dữ liệu vào DataTable mới
                    dtNew3.Rows.Add(null, ngaylap2, NoiDung, SoTien, SttTTNCN, MaSoThue, SttBL, MaTU, SttBH, SttTKNH, SoTKNH, TenTKNH, TenNH);
                    try
                    {
                        // Thêm giá trị vào DataTable của DataGridView
                        uyNhiemChiTableAdapter.Insert(ngaylap2, NoiDung, SoTien, SttTTNCN, SttBL, MaTU, SttBH, SttTKNH);
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("CÓ LỖI KHI TẠO DANH SÁCH THUẾ MỚI " + ex.Message);
                    }
                }
                // Hiển thị DataTable mới trên DataGridView
                dtgvUNC.DataSource = dtNew3;
                // Calculate the sum of "SoTien" column
                int totalSoTien = dtNew3.AsEnumerable().Sum(row => row.Field<int>("SoTien"));
                // Set the sum to the TextBox
                tbTongTien.Text = totalSoTien.ToString();
                tbTongTien.Enabled = false;
                this.uyNhiemChiTableAdapter.Fill(this.uyNhiemChiDB.UyNhiemChi);
                MessageBox.Show("Thêm xong, mời xem!");
            }
            if (noidungchon == "Bảo hiểm và kinh phí công đoàn")
            {
                sttTTNCNDataGridViewTextBoxColumn.Visible = false;
                sttBLDataGridViewTextBoxColumn.Visible = false;
                maTUDataGridViewTextBoxColumn.Visible = false;
                MaSoThue.Visible = false;
                //sttBHDataGridViewTextBoxColumn.Visible = false;
                sttTKNHDataGridViewTextBoxColumn.Visible = false;
                BHXH.Visible = true;
                BHYT.Visible = true;
                BHTN.Visible = true;
                KPCD.Visible = true;
                DataTable dtData = ConnectSQL.Load(@"
                SELECT SttBH, BHXHDN, BHYTDN, BHTNDN, KinhPhiCD, SoTKNH, TenNV, TenTKNH, TenNH, SttTKNH, TongBH
                FROM BaoHiemVaCongDoan
                LEFT JOIN LuongCN on BaoHiemVaCongDoan.SttLCN = LuongCN.SttLCN
                LEFT JOIN TaiKhoanNH ON LoaiTK = N'KBNN'
                LEFT JOIN NhanVien on LuongCN.MaNV = NhanVien.MaNV
                WHERE MONTH(BaoHiemVaCongDoan.NgayLap) = '" + thanglap.ToString() + "' AND YEAR(BaoHiemVaCongDoan.NgayLap) = '" + namlap + @"'");
                // Tạo DataTable mới
                //DataTable dtNew = new DataTable();
                DataColumn columnSttUNC = new DataColumn("SttUNC", typeof(int));
                columnSttUNC.AutoIncrement = true;
                columnSttUNC.AutoIncrementSeed = 1; // Giá trị bắt đầu của số tự động tăng
                dtNew4.Columns.Add(columnSttUNC);
                dtNew4.Columns.Add("Ngaylap", typeof(DateTime));
                dtNew4.Columns.Add("Noidung", typeof(string));
                dtNew4.Columns.Add("Sotien", typeof(int));
                dtNew4.Columns.Add("SttTTNCN", typeof(int));
                dtNew4.Columns.Add("SttBL", typeof(int));
                dtNew4.Columns.Add("MaTU", typeof(string));
                dtNew4.Columns.Add("SttBH", typeof(int));
                dtNew4.Columns.Add("SttTKNH", typeof(int));
                dtNew4.Columns.Add("SoTKNH", typeof(string));
                dtNew4.Columns.Add("TenTKNH", typeof(string));
                dtNew4.Columns.Add("TenNH", typeof(string));
                dtNew4.Columns.Add("BHXH", typeof(int));
                dtNew4.Columns.Add("BHYT", typeof(int));
                dtNew4.Columns.Add("BHTN", typeof(int));
                dtNew4.Columns.Add("KPCD", typeof(int));
                foreach (DataRow row in dtData.Rows)
                {
                    string NoiDung = "Tiền bảo hiểm và công đoàn của nhân viên: " + Convert.ToString(row["TenNV"]);
                    int SoTien = Convert.ToInt32(row["TongBH"]) + Convert.ToInt32(row["KinhPhiCD"]);
                    int? SttTTNCN = null;
                    int? SttBL = null;
                    string MaTU = null;
                    int SttBH = Convert.ToInt32(row["SttBH"]);
                    int SttTKNH = Convert.ToInt32(row["SttTKNH"]);
                    string SoTKNH = Convert.ToString(row["SoTKNH"]);
                    string TenTKNH = Convert.ToString(row["TenTKNH"]);
                    string TenNH = Convert.ToString(row["TenNH"]);
                    int BHXH = Convert.ToInt32(row["BHXHDN"]);
                    int BHYT = Convert.ToInt32(row["BHYTDN"]);
                    int BHTN = Convert.ToInt32(row["BHTNDN"]);
                    int KPCD = Convert.ToInt32(row["KinhPhiCD"]);
                    // Thêm dữ liệu vào DataTable mới
                    dtNew4.Rows.Add(null, ngaylap2, NoiDung, SoTien, SttTTNCN, SttBL, MaTU, SttBH, SttTKNH, SoTKNH, TenTKNH, TenNH, BHXH, BHYT, BHTN, KPCD);
                    try
                    {
                        // Thêm giá trị vào DataTable của DataGridView
                        uyNhiemChiTableAdapter.Insert(ngaylap2, NoiDung, SoTien, SttTTNCN, SttBL, MaTU, SttBH, SttTKNH);
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("CÓ LỖI KHI TẠO DANH SÁCH CHI PHÍ BÁO HIỂM VÀ CÔNG ĐOÀN MỚI " + ex.Message);
                    }
                }
                // Hiển thị DataTable mới trên DataGridView
                dtgvUNC.DataSource = dtNew4;
                // Calculate the sum of "SoTien" column
                int totalSoTien = dtNew4.AsEnumerable().Sum(row => row.Field<int>("SoTien"));
                // Set the sum to the TextBox
                tbTongTien.Text = totalSoTien.ToString();
                tbTongTien.Enabled = false;
                this.uyNhiemChiTableAdapter.Fill(this.uyNhiemChiDB.UyNhiemChi);
                MessageBox.Show("Thêm xong, mời xem!");
            }
        }

        private void BtnButToan_Click(object sender, EventArgs e)
        {
            ButToan fr = new ButToan();
            fr.BtnLapBTUNC.Visible = !fr.BtnLapBTUNC.Visible;
            fr.ShowDialog();
        }

        private void btnXemLCN_Click(object sender, EventArgs e)
        {

            int thanglap = CbThangCT.SelectedIndex + 1;
            string namlap = CbNamCT.SelectedItem.ToString();
            string ngaylap = dtpNgaylapUNC.Text.Trim();
            string noidungchon = CbChonCT.SelectedItem.ToString();
            DateTime ngaylap2 = dtpNgaylapUNC.Value;
            if (noidungchon == "Tạm ứng lương")
            {
                sttTTNCNDataGridViewTextBoxColumn.Visible = false;
                sttBLDataGridViewTextBoxColumn.Visible = false;
                MaSoThue.Visible = false;
                //maTUDataGridViewTextBoxColumn.Visible = false;
                sttBHDataGridViewTextBoxColumn.Visible = false;
                sttTKNHDataGridViewTextBoxColumn.Visible = false;
                DataTable dtData = ConnectSQL.Load(@"
                SELECT UyNhiemChi.MaTU, UyNhiemChi.SoTien, MoTa, SoTKNH, TenTKNH, TenNH, UyNhiemChi.SttTKNH, SttUNC
                FROM TamUng
                LEFT JOIN TaiKhoanNH on TamUng.MaNV = TaiKhoanNH.MaNV
                LEFT JOIN UyNhiemChi on TamUng.MaTU = UyNhiemChi.MaTU
                WHERE MONTH(UyNhiemChi.NgayLap) = '" + thanglap.ToString() + "' AND YEAR(UyNhiemChi.NgayLap) = '" + namlap + @"'");
                // Tạo DataTable mới
                dtNew2.Columns.Add("SttUNC", typeof(int));
                dtNew2.Columns.Add("Ngaylap", typeof(DateTime));
                dtNew2.Columns.Add("Noidung", typeof(string));
                dtNew2.Columns.Add("Sotien", typeof(int));
                dtNew2.Columns.Add("SttTTNCN", typeof(int));
                dtNew2.Columns.Add("SttBL", typeof(int));
                dtNew2.Columns.Add("MaTU", typeof(string));
                dtNew2.Columns.Add("SttBH", typeof(int));
                dtNew2.Columns.Add("SttTKNH", typeof(int));
                dtNew2.Columns.Add("SoTKNH", typeof(string));
                dtNew2.Columns.Add("TenTKNH", typeof(string));
                dtNew2.Columns.Add("TenNH", typeof(string));
                foreach (DataRow row in dtData.Rows)
                {
                    string NoiDung = Convert.ToString(row["MoTa"]);
                    int SoTien = Convert.ToInt32(row["SoTien"]);
                    int SttUNC = Convert.ToInt32(row["SttUNC"]);
                    int? SttTTNCN = null;
                    int? SttBL = null;
                    string MaTU = Convert.ToString(row["MaTU"]).Trim();
                    int? SttBH = null;
                    int SttTKNH = Convert.ToInt32(row["SttTKNH"]);
                    string SoTKNH = Convert.ToString(row["SoTKNH"]);
                    string TenTKNH = Convert.ToString(row["TenTKNH"]);
                    string TenNH = Convert.ToString(row["TenNH"]);
                    // Thêm dữ liệu vào DataTable mới
                    dtNew2.Rows.Add(SttUNC, ngaylap2, NoiDung, SoTien, SttTTNCN, SttBL, MaTU, SttBH, SttTKNH, SoTKNH, TenTKNH, TenNH);
                   
                }
                // Hiển thị DataTable mới trên DataGridView
                dtgvUNC.DataSource = dtNew2;
                // Calculate the sum of "SoTien" column
                int totalSoTien = dtNew2.AsEnumerable().Sum(row => row.Field<int>("SoTien"));
                // Set the sum to the TextBox
                tbTongTien.Text = totalSoTien.ToString();
                tbTongTien.Enabled = false;
                //this.uyNhiemChiTableAdapter.Fill(this.uyNhiemChiDB.UyNhiemChi);
            }
            if (noidungchon == "Bảng lương")
            {
                sttTTNCNDataGridViewTextBoxColumn.Visible = false;
                MaSoThue.Visible = false;
                //sttBLDataGridViewTextBoxColumn.Visible = false;
                maTUDataGridViewTextBoxColumn.Visible = false;
                sttBHDataGridViewTextBoxColumn.Visible = false;
                sttTKNHDataGridViewTextBoxColumn.Visible = false;
                DataTable dtData = ConnectSQL.Load(@"
                SELECT UyNhiemChi.SttBL, LuongTN, SoTKNH, TenNV, TenTKNH, TenNH, UyNhiemChi.SttTKNH, SttUNC
                FROM BangLuong
                LEFT JOIN LuongCN on BangLuong.SttLCN = LuongCN.SttLCN
                LEFT JOIN TaiKhoanNH on LuongCN.MaNV = TaiKhoanNH.MaNV
                LEFT JOIN NhanVien on LuongCN.MaNV = NhanVien.MaNV
                LEFT JOIN UyNhiemChi on BangLuong.SttBL = UyNhiemChi.SttBL
                WHERE MONTH(BangLuong.NgayLap) = '" + thanglap.ToString() + "' AND YEAR(BangLuong.NgayLap) = '" + namlap + @"'");
                // Tạo DataTable mới
                dtNew1.Columns.Add("SttUNC", typeof(int));
                dtNew1.Columns.Add("Ngaylap", typeof(DateTime));
                dtNew1.Columns.Add("Noidung", typeof(string));
                dtNew1.Columns.Add("Sotien", typeof(int));
                dtNew1.Columns.Add("SttTTNCN", typeof(int));
                dtNew1.Columns.Add("SttBL", typeof(int));
                dtNew1.Columns.Add("MaTU", typeof(string));
                dtNew1.Columns.Add("SttBH", typeof(int));
                dtNew1.Columns.Add("SttTKNH", typeof(int));
                dtNew1.Columns.Add("SoTKNH", typeof(string));
                dtNew1.Columns.Add("TenTKNH", typeof(string));
                dtNew1.Columns.Add("TenNH", typeof(string));
                foreach (DataRow row in dtData.Rows)
                {
                    string NoiDung = "Trả lương nhân viên: " + Convert.ToString(row["TenNV"]);
                    int SoTien = Convert.ToInt32(row["LuongTN"]);
                    int SttUNC = Convert.ToInt32(row["SttUNC"]);
                    int? SttTTNCN = null;
                    int SttBL = Convert.ToInt32(row["SttBL"]);
                    string MaTU = null;
                    int? SttBH = null;
                    int SttTKNH = Convert.ToInt32(row["SttTKNH"]);
                    string SoTKNH = Convert.ToString(row["SoTKNH"]);
                    string TenTKNH = Convert.ToString(row["TenTKNH"]);
                    string TenNH = Convert.ToString(row["TenNH"]);
                    // Thêm dữ liệu vào DataTable mới
                    dtNew1.Rows.Add(SttUNC, ngaylap2, NoiDung, SoTien, SttTTNCN, SttBL, MaTU, SttBH, SttTKNH, SoTKNH, TenTKNH, TenNH);
                    
                }
                // Hiển thị DataTable mới trên DataGridView
                dtgvUNC.DataSource = dtNew1;
                // Calculate the sum of "SoTien" column
                int totalSoTien = dtNew1.AsEnumerable().Sum(row => row.Field<int>("SoTien"));
                // Set the sum to the TextBox
                tbTongTien.Text = totalSoTien.ToString();
                tbTongTien.Enabled = false;
                //this.uyNhiemChiTableAdapter.Fill(this.uyNhiemChiDB.UyNhiemChi);
            }
            if (noidungchon == "Thuế thu nhập cá nhân")
            {
                //sttTTNCNDataGridViewTextBoxColumn.Visible = false;
                sttBLDataGridViewTextBoxColumn.Visible = false;
                maTUDataGridViewTextBoxColumn.Visible = false;
                sttBHDataGridViewTextBoxColumn.Visible = false;
                sttTKNHDataGridViewTextBoxColumn.Visible = false;
                SoTKNH.Visible = false;
                TenTKNH.Visible = false;
                TenNH.Visible = false;
                DataTable dtData = ConnectSQL.Load(@"
                SELECT UyNhiemChi.SttTTNCN, ThueTNCN, NhanVien.TenNV, MaSoThue, UyNhiemChi.SttTKNH, SoTKNH, TenTKNH, TenNH, SttUNC
                FROM ThueTNCN
                LEFT JOIN LuongCN ON ThueTNCN.SttLCN = LuongCN.SttLCN
                LEFT JOIN NhanVien ON LuongCN.MaNV = NhanVien.MaNV
                LEFT JOIN UyNhiemChi on ThueTNCN.SttTTNCN = UyNhiemChi.SttTTNCN
                LEFT JOIN TaiKhoanNH ON LoaiTK = N'KBNN'
                WHERE MONTH(ThueTNCN.NgayLap) = '" + thanglap.ToString() + "' AND YEAR(ThueTNCN.NgayLap) = '" + namlap + @"'");
                // Tạo DataTable mới
                dtNew3.Columns.Add("SttUNC", typeof(int));
                dtNew3.Columns.Add("Ngaylap", typeof(DateTime));
                dtNew3.Columns.Add("Noidung", typeof(string));
                dtNew3.Columns.Add("Sotien", typeof(int));
                dtNew3.Columns.Add("SttTTNCN", typeof(int));
                dtNew3.Columns.Add("MaSoThue", typeof(string));
                dtNew3.Columns.Add("SttBL", typeof(int));
                dtNew3.Columns.Add("MaTU", typeof(string));
                dtNew3.Columns.Add("SttBH", typeof(int));
                dtNew3.Columns.Add("SttTKNH", typeof(int));
                dtNew3.Columns.Add("SoTKNH", typeof(string));
                dtNew3.Columns.Add("TenTKNH", typeof(string));
                dtNew3.Columns.Add("TenNH", typeof(string));
                foreach (DataRow row in dtData.Rows)
                {
                    string NoiDung = "Tiền thuế TNCN của nhân viên: " + Convert.ToString(row["TenNV"]);
                    int SoTien = Convert.ToInt32(row["ThueTNCN"]);
                    int SttUNC = Convert.ToInt32(row["SttUNC"]);
                    int SttTTNCN = Convert.ToInt32(row["SttTTNCN"]);
                    int? SttBL = null;
                    string MaTU = null;
                    int? SttBH = null;
                    int SttTKNH = Convert.ToInt32(row["SttTKNH"]);
                    string MaSoThue = Convert.ToString(row["MaSoThue"]);
                    string SoTKNH = Convert.ToString(row["SoTKNH"]);
                    string TenTKNH = Convert.ToString(row["TenTKNH"]);
                    string TenNH = Convert.ToString(row["TenNH"]);
                    // Thêm dữ liệu vào DataTable mới
                    dtNew3.Rows.Add(SttUNC, ngaylap2, NoiDung, SoTien, SttTTNCN, MaSoThue, SttBL, MaTU, SttBH, SttTKNH, SoTKNH, TenTKNH, TenNH);
                   
                }
                // Hiển thị DataTable mới trên DataGridView
                dtgvUNC.DataSource = dtNew3;
                // Calculate the sum of "SoTien" column
                int totalSoTien = dtNew3.AsEnumerable().Sum(row => row.Field<int>("SoTien"));
                // Set the sum to the TextBox
                tbTongTien.Text = totalSoTien.ToString();
                tbTongTien.Enabled = false;
                //this.uyNhiemChiTableAdapter.Fill(this.uyNhiemChiDB.UyNhiemChi);
            }
            if (noidungchon == "Bảo hiểm và kinh phí công đoàn")
            {
                sttTTNCNDataGridViewTextBoxColumn.Visible = false;
                sttBLDataGridViewTextBoxColumn.Visible = false;
                maTUDataGridViewTextBoxColumn.Visible = false;
                MaSoThue.Visible = false;
                //sttBHDataGridViewTextBoxColumn.Visible = false;
                sttTKNHDataGridViewTextBoxColumn.Visible = false;
                BHXH.Visible = true;
                BHYT.Visible = true;
                BHTN.Visible = true;
                KPCD.Visible = true;
                DataTable dtData = ConnectSQL.Load(@"
                SELECT UyNhiemChi.SttBH, BHXHDN, BHYTDN, BHTNDN, KinhPhiCD, SoTKNH, TenNV, TenTKNH, TenNH, UyNhiemChi.SttTKNH, TongBH, SttUNC
                FROM BaoHiemVaCongDoan
                LEFT JOIN LuongCN on BaoHiemVaCongDoan.SttLCN = LuongCN.SttLCN
                LEFT JOIN UyNhiemChi on BaoHiemVaCongDoan.SttBH = UyNhiemChi.SttBH
                LEFT JOIN TaiKhoanNH ON LoaiTK = N'KBNN'
                LEFT JOIN NhanVien on LuongCN.MaNV = NhanVien.MaNV
                WHERE MONTH(BaoHiemVaCongDoan.NgayLap) = '" + thanglap.ToString() + "' AND YEAR(BaoHiemVaCongDoan.NgayLap) = '" + namlap + @"'");
                // Tạo DataTable mới
                dtNew4.Columns.Add("SttUNC", typeof(int));
                dtNew4.Columns.Add("Ngaylap", typeof(DateTime));
                dtNew4.Columns.Add("Noidung", typeof(string));
                dtNew4.Columns.Add("Sotien", typeof(int));
                dtNew4.Columns.Add("SttTTNCN", typeof(int));
                dtNew4.Columns.Add("SttBL", typeof(int));
                dtNew4.Columns.Add("MaTU", typeof(string));
                dtNew4.Columns.Add("SttBH", typeof(int));
                dtNew4.Columns.Add("SttTKNH", typeof(int));
                dtNew4.Columns.Add("SoTKNH", typeof(string));
                dtNew4.Columns.Add("TenTKNH", typeof(string));
                dtNew4.Columns.Add("TenNH", typeof(string));
                dtNew4.Columns.Add("BHXH", typeof(int));
                dtNew4.Columns.Add("BHYT", typeof(int));
                dtNew4.Columns.Add("BHTN", typeof(int));
                dtNew4.Columns.Add("KPCD", typeof(int));
                foreach (DataRow row in dtData.Rows)
                {
                    string NoiDung = "Tiền bảo hiểm và công đoàn của nhân viên: " + Convert.ToString(row["TenNV"]);
                    int SoTien = Convert.ToInt32(row["TongBH"]) + Convert.ToInt32(row["KinhPhiCD"]);
                    int SttUNC = Convert.ToInt32(row["SttUNC"]);
                    int? SttTTNCN = null;
                    int? SttBL = null;
                    string MaTU = null;
                    int SttBH = Convert.ToInt32(row["SttBH"]);
                    int SttTKNH = Convert.ToInt32(row["SttTKNH"]);
                    string SoTKNH = Convert.ToString(row["SoTKNH"]);
                    string TenTKNH = Convert.ToString(row["TenTKNH"]);
                    string TenNH = Convert.ToString(row["TenNH"]);
                    int BHXH = Convert.ToInt32(row["BHXHDN"]);
                    int BHYT = Convert.ToInt32(row["BHYTDN"]);
                    int BHTN = Convert.ToInt32(row["BHTNDN"]);
                    int KPCD = Convert.ToInt32(row["KinhPhiCD"]);
                    // Thêm dữ liệu vào DataTable mới
                    dtNew4.Rows.Add(SttUNC, ngaylap2, NoiDung, SoTien, SttTTNCN, SttBL, MaTU, SttBH, SttTKNH, SoTKNH, TenTKNH, TenNH, BHXH, BHYT, BHTN, KPCD);
                }
                // Hiển thị DataTable mới trên DataGridView
                dtgvUNC.DataSource = dtNew4;
                // Calculate the sum of "SoTien" column
                int totalSoTien = dtNew4.AsEnumerable().Sum(row => row.Field<int>("SoTien"));
                // Set the sum to the TextBox
                tbTongTien.Text = totalSoTien.ToString();
                tbTongTien.Enabled = false;
                //this.uyNhiemChiTableAdapter.Fill(this.uyNhiemChiDB.UyNhiemChi);
            }
        }
    }
}
