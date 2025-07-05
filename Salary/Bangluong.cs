using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text.pdf.parser;

namespace Salary
{
    public partial class Bangluong : Form
    {
        public Bangluong()
        {
            InitializeComponent();
            UpdateLoggedInUser();
            // Đặt sự kiện khi thay đổi kích thước của GroupBox
            groupBox1.SizeChanged += groupBox1_SizeChanged;
        }
        private string connectionString = @"Data Source=ALICEWANG\SQLEXPRESS01;Initial Catalog=HRPayrollDB;Integrated Security=True;MultipleActiveResultSets=True;Connect Timeout=0;Max Pool Size=500;TrustServerCertificate=True;";
        private void Bangluong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bangLuongDB.BangLuong' table. You can move, or remove it, as needed.
            //this.bangLuongTableAdapter.Fill(this.bangLuongDB.BangLuong);
        }
        private void UpdateLoggedInUser()
        {
            if (Dangnhap.typeRole == "AdminKT" || Dangnhap.typeRole == "MemberKT" || Dangnhap.typeRole == "AdminIT" || Dangnhap.typeRole == "MemberIT" || Dangnhap.typeRole == "AdminNS" || Dangnhap.typeRole == "MemberNS" || Dangnhap.typeRole == "Member")
            {
                tinhTrangDuyetDataGridViewCheckBoxColumn.Visible = false;
                btnBoDuyetTatCa.Visible = false;
                btnDuyetTatCa.Visible = false;
                XetDuyet.Visible = false;
            }
        }
        private void ThemBangLuong_Click(object sender, EventArgs e)
        {
            int thanglap = cbThangBL.SelectedIndex + 1;
            string namlap = cbNamBL.SelectedItem.ToString();
            string MaKL = thanglap.ToString() + namlap;
            string ngaylap = dtpNgaylapBL.Text.Trim();
            DateTime ngaylap2 = dtpNgaylapBL.Value;
            DataTable dtData = ConnectSQL.Load(@"
            SELECT LuongCN.SttLCN, LuongCN.MaNV, TenNV, BaoHiemVaCongDoan.SttBH, SttTTNCN, LuongTheoNC, LuongTC, LuongTCKhongTT, PhuCapAn, PhuCapDiLai, PhuCapDienThoai, TongBH, ThueTNCN, DoanPhi , SUM(ISNULL(SoTien, 0)) as 'TongTamUng', BHXHNV, BHYTNV, BHTNNV, LuongCN.LuongCB, NgayCongCH, NgayCongTT
            FROM LuongCN
            LEFT JOIN BaoHiemVaCongDoan ON LuongCN.SttLCN = BaoHiemVaCongDoan.SttLCN
            LEFT JOIN ThueTNCN ON LuongCN.SttLCN = ThueTNCN.SttLCN
            LEFT JOIN HopDongLD on LuongCN.SttHDLD = HopDongLD.SttHDLD
            LEFT JOIN NhanVien on LuongCN.MaNV = NhanVien.MaNV
            LEFT JOIN TamUng on LuongCN.MaNV = TamUng.MaNV and LuongCN.MaKL = TamUng.MaKL
            WHERE MONTH(LuongCN.NgayLap) = '" + thanglap.ToString() + "' AND YEAR(LuongCN.NgayLap) = '" + namlap + @"'
            GROUP BY LuongCN.SttLCN, LuongCN.MaNV, TenNV, BaoHiemVaCongDoan.SttBH, SttTTNCN, LuongTheoNC, LuongTC, LuongTCKhongTT, PhuCapAn, PhuCapDiLai, PhuCapDienThoai, TongBH, ThueTNCN, DoanPhi, BHXHNV, BHYTNV, BHTNNV, LuongCN.LuongCB, NgayCongCH, NgayCongTT");

            // Tạo DataTable mới
            //DataTable dtNew = new DataTable();
            DataColumn columnSttBL = new DataColumn("SttBL", typeof(int));
            columnSttBL.AutoIncrement = true;
            columnSttBL.AutoIncrementSeed = 1; // Giá trị bắt đầu của số tự động tăng
            dtNew.Columns.Add(columnSttBL);
            dtNew.Columns.Add("NgayLap", typeof(DateTime));
            dtNew.Columns.Add("MaNV", typeof(string));
            dtNew.Columns.Add("TenNV", typeof(string));
            dtNew.Columns.Add("LuongCB", typeof(int));
            dtNew.Columns.Add("NgayCongCH", typeof(double));
            dtNew.Columns.Add("NgayCongTT", typeof(double));
            dtNew.Columns.Add("LuongTheoNC", typeof(int));
            dtNew.Columns.Add("LuongTC", typeof(int));
            dtNew.Columns.Add("PhuCapAn", typeof(int));
            dtNew.Columns.Add("PhuCapDiLai", typeof(int));
            dtNew.Columns.Add("PhuCapDienThoai", typeof(int));
            dtNew.Columns.Add("TongLuong", typeof(int));
            dtNew.Columns.Add("BHXHNV", typeof(int));
            dtNew.Columns.Add("BHYTNV", typeof(int));
            dtNew.Columns.Add("BHTNNV", typeof(int));
            dtNew.Columns.Add("ThueTNCN", typeof(int));
            dtNew.Columns.Add("DoanPhi", typeof(int));
            dtNew.Columns.Add("TongTamUng", typeof(int));
            dtNew.Columns.Add("MaKL", typeof(string));
            dtNew.Columns.Add("LuongTN", typeof(int));

            foreach (DataRow row in dtData.Rows)
            {
                string MaNV = Convert.ToString(row["MaNV"]);
                string TenNV = Convert.ToString(row["TenNV"]);
                int LuongCB = Convert.ToInt32(row["LuongCB"]);
                double NgayCongCH = Convert.ToDouble(row["NgayCongCH"]);
                double NgayCongTT = Convert.ToDouble(row["NgayCongTT"]);
                int BHXHNV = Convert.ToInt32(row["BHXHNV"]);
                int BHYTNV = Convert.ToInt32(row["BHYTNV"]);
                int BHTNNV = Convert.ToInt32(row["BHTNNV"]);
                int LuongTheoNC = Convert.ToInt32(row["LuongTheoNC"]);
                int LuongTC = Convert.ToInt32(row["LuongTC"]);
                int PhuCapAn = Convert.ToInt32(row["PhuCapAn"]);
                int PhuCapDiLai = Convert.ToInt32(row["PhuCapDiLai"]);
                int PhuCapDienThoai = Convert.ToInt32(row["PhuCapDienThoai"]);
                int TongBH = Convert.ToInt32(row["TongBH"]);
                int ThueTNCN = row["ThueTNCN"] != DBNull.Value ? Convert.ToInt32(row["ThueTNCN"]) : 0;
                int DoanPhi = Convert.ToInt32(row["DoanPhi"]);
                int TongTamUng = Convert.ToInt32(row["TongTamUng"]);
                int TongLuong = LuongTheoNC + LuongTC + PhuCapAn + PhuCapDienThoai + PhuCapDiLai;
                int LuongTN = TongLuong - TongBH - ThueTNCN - DoanPhi - TongTamUng;

                // Thêm dữ liệu vào DataTable mới
                dtNew.Rows.Add(null, ngaylap2, MaNV, TenNV, LuongCB, NgayCongCH, NgayCongTT, LuongTheoNC, LuongTC, PhuCapAn, PhuCapDiLai, PhuCapDienThoai, TongLuong, BHXHNV, BHYTNV, BHTNNV, ThueTNCN, DoanPhi, TongTamUng, MaKL, LuongTN);
                int SttLCN = Convert.ToInt32(row["SttLCN"]);
                int SttBH = Convert.ToInt32(row["SttBH"]);
                int? SttTTNCN = row["SttTTNCN"] != DBNull.Value ? (int?)Convert.ToInt32(row["SttTTNCN"]) : null;
                try
                {
                    // Thêm giá trị vào DataTable của DataGridView
                    bangLuongTableAdapter.Insert(ngaylap, SttLCN, SttBH, SttTTNCN, TongLuong, LuongTN, MaKL);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("CÓ LỖI KHI TẠO DANH SÁCH BẢNG LƯƠNG MỚI " + ex.Message);
                }
            }
            // Hiển thị DataTable mới trên DataGridView
            dtgvBangLuong.DataSource = dtNew;
            this.bangLuongTableAdapter.Fill(this.bangLuongDB.BangLuong);
            MessageBox.Show("Thêm xong, mời xem!");
        }
        private DataTable dtNew = new DataTable(); // Khai báo biến DataTable ở mức độ lớp để có thể sử dụng nhiều hàm
        private void UpdateDataTable(int thanglap, string namlap)
        {
            DataTable dtData2 = ConnectSQL.Load(@"
            SELECT BangLuong.SttBL, BangLuong.NgayLap, LuongCN.MaNV, TenNV, LuongCN.LuongCB, NgayCongCH, NgayCongTT, LuongTheoNC, LuongTC, PhuCapAn, PhuCapDiLai, PhuCapDienThoai, TongLuong, BHXHNV, BHYTNV, BHTNNV, ThueTNCN, DoanPhi, SUM(ISNULL(SoTien, 0)) as 'TongTamUng', LuongTN, BangLuong.MaKL, TinhTrangDuyet
            FROM LuongCN
            LEFT JOIN BaoHiemVaCongDoan ON LuongCN.SttLCN = BaoHiemVaCongDoan.SttLCN
            LEFT JOIN ThueTNCN ON LuongCN.SttLCN = ThueTNCN.SttLCN
            LEFT JOIN HopDongLD on LuongCN.SttHDLD = HopDongLD.SttHDLD
            LEFT JOIN NhanVien on LuongCN.MaNV = NhanVien.MaNV
            LEFT JOIN BangLuong on LuongCN.SttLCN = BangLuong.SttLCN
            LEFT JOIN TamUng on LuongCN.MaNV = TamUng.MaNV and LuongCN.MaKL = TamUng.MaKL
            WHERE MONTH(LuongCN.NgayLap) = '" + thanglap.ToString() + "' AND YEAR(LuongCN.NgayLap) = '" + namlap + @"'
            GROUP BY LuongCN.SttLCN, BangLuong.SttBL, BangLuong.NgayLap, LuongCN.MaNV, TenNV, LuongCN.LuongCB, NgayCongCH, NgayCongTT, LuongTheoNC, LuongTC, PhuCapAn, PhuCapDiLai, PhuCapDienThoai, TongLuong, BHXHNV, BHYTNV, BHTNNV,  ThueTNCN, DoanPhi, BangLuong.MaKL, LuongTN, TinhTrangDuyet");
            try
            {
                dtgvBangLuong.DataSource = dtData2;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("CÓ LỖI KHI XEM BẢNG LƯƠNG!" + ex.Message);
            }
        }
        private void BtnXemBL_Click_1(object sender, EventArgs e)
        {
            int thanglap = cbThangBL.SelectedIndex + 1;
            string namlap = cbNamBL.SelectedItem.ToString();

            // Cập nhật DataTable dtNew
            UpdateDataTable(thanglap, namlap);

            // Hiển thị DataTable mới trên DataGridView
            //dtgvBangLuong.DataSource = dtNew;
        }
        private void UpdateDatabase(int SttBL, string TTD)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Replace "YourTableName" and "YourColumnName" with your actual table and column names
                string updateQuery = $"UPDATE BangLuong SET TinhTrangDuyet = @TinhTrangDuyet WHERE SttBL = @SttBL";

                using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                {
                    // Kiểm tra giá trị null trước khi ép kiểu
                    object TinhTrangDuyetValue = (TTD != null) ? (object)TTD : DBNull.Value;
                    cmd.Parameters.AddWithValue("@TinhTrangDuyet", TinhTrangDuyetValue);
                    cmd.Parameters.AddWithValue("@SttBL", SttBL);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void XetDuyet_Click(object sender, EventArgs e)
        {
            int thanglap = cbThangBL.SelectedIndex + 1;
            string namlap = cbNamBL.SelectedItem.ToString();
            foreach (DataGridViewRow row in dtgvBangLuong.Rows)
            {
                // Lấy giá trị của ô checkbox
                object checkboxCellValue = row.Cells["tinhTrangDuyetDataGridViewCheckBoxColumn"].Value;
                // Kiểm tra nếu giá trị là DBNull.Value hoặc null, trả về false
                bool checkboxValue = (checkboxCellValue != DBNull.Value && checkboxCellValue != null) ? Convert.ToBoolean(checkboxCellValue) : false;
                // Sử dụng giá trị của checkboxValue như bạn cần
                string TTD = checkboxValue ? "true" : null; // Set TTD to "true" if checkboxValue is true, otherwise set to null
                int SttBL = Convert.ToInt32(row.Cells[0].Value);
                // Perform the database update
                UpdateDatabase(SttBL, TTD);
            }
            MessageBox.Show("Đã duyệt những nhân viên được chọn!");
            UpdateDataTable(thanglap, namlap);
        }
        private SqlCommand lenh = new SqlCommand();
        private SqlDataAdapter da = new SqlDataAdapter();
        private void btnExport_Click(object sender, EventArgs e)
        {
            // Declare SqlConnection if not declared already
            SqlConnection connection = new SqlConnection(@"Data Source = ALICEWANG\SQLEXPRESS01; Initial Catalog = HRPayrollDB; Integrated Security = True; MultipleActiveResultSets = True; Connect Timeout = 0; Max Pool Size = 500; TrustServerCertificate = True;");

            // Set the connection for the SqlCommand
            lenh.Connection = connection;
            //Kết xuất nguồn dữ liệu cho Report
            int thanglap = cbThangBL.SelectedIndex + 1;
            //int namlap = (int)cbNamBL.SelectedItem;
            //int? namlap = cbNamBL.SelectedItem != DBNull.Value ? (int?)cbNamBL.SelectedItem : null;
            string namlap = cbNamBL.SelectedItem.ToString();
            lenh.CommandText = "SELECT BangLuong.NgayLap, sum(TongLuong) as 'TongLuong', sum(LuongTN) as 'LuongTN' , TenPB, month(BangLuong.NgayLap) as 'Thang', year(BangLuong.NgayLap) as 'Nam', " +
                " sum(ISNULL(ThueTNCN, 0)) as 'ThueTNCN', sum(DoanPhi) as 'DoanPhi' , sum(BHXHNV) as 'BHXHNV', sum(BHYTNV) as 'BHYTNV', sum(BHTNNV) as 'BHTNNV'," +
                " sum(BHXHDN) as 'BHXHDN', sum(BHYTDN) as 'BHYTDN', sum(BHTNDN) as 'BHTNDN', sum(KinhPhiCD) as 'KinhPhiCD'" +
                " FROM BangLuong LEFT JOIN BaoHiemVaCongDoan ON BangLuong.SttBH = BaoHiemVaCongDoan.SttBH LEFT JOIN LuongCN ON BangLuong.SttLCN = LuongCN.SttLCN" +
                " LEFT JOIN ThueTNCN ON BangLuong.SttTTNCN = ThueTNCN.SttTTNCN LEFT JOIN NhanVien on " +
                " LuongCN.MaNV = NhanVien.MaNV LEFT JOIN Phongban on NhanVien.MaPB = Phongban.MaPB WHERE MONTH(BangLuong.NgayLap) = @thanglap" +
                " AND YEAR(BangLuong.NgayLap) = @namlap GROUP BY TenPB, BangLuong.NgayLap";
            lenh.Parameters.Clear();
            lenh.Parameters.AddWithValue("@thanglap", thanglap);
            lenh.Parameters.AddWithValue("@namlap", namlap);
            da.SelectCommand = lenh;
            DataTable dt = new DataTable("BangLuongIn");
            da.Fill(dt);
            //Gán nguồn dữ liệu cho Crystal Report
            rptBangLuong baocaoluong = new rptBangLuong();
            baocaoluong.SetDataSource(dt);
            //HIển thị báo cáo
            frmInBangLuong frmibl = new frmInBangLuong();
            frmibl.crystalReportViewerBaoCaoLuong.ReportSource = baocaoluong;
            frmibl.ShowDialog();
        }

        private void btnDuyetTatCa_Click(object sender, EventArgs e)
        {
            int thanglap = cbThangBL.SelectedIndex + 1;
            string namlap = cbNamBL.SelectedItem.ToString();
            foreach (DataGridViewRow row in dtgvBangLuong.Rows)
            {
                // Lấy giá trị của ô checkbox
                object checkboxCellValue = row.Cells["tinhTrangDuyetDataGridViewCheckBoxColumn"].Value;
                // Kiểm tra nếu giá trị là DBNull.Value hoặc null, trả về false
                bool checkboxValue = (checkboxCellValue != DBNull.Value && checkboxCellValue != null) ? true : true;
                // Sử dụng giá trị của checkboxValue như bạn cần
                string TTD = checkboxValue ? "true" : null; // Set TTD to "true" if checkboxValue is true, otherwise set to null
                int SttBL = Convert.ToInt32(row.Cells[0].Value);
                // Perform the database update
                UpdateDatabase(SttBL, TTD);
            }
            // Cập nhật DataTable dtNew
            MessageBox.Show("Đã duyệt tất cả!");
            UpdateDataTable(thanglap, namlap);
        }

        private void groupBox1_SizeChanged(object sender, EventArgs e)
        {
            // Khi kích thước của GroupBox thay đổi, tỷ lệ lại kích thước các controls bên trong
            ResizeControlsInsideGroupBox();
        }
        private void ResizeControlsInsideGroupBox()
        {
            // Tính toán kích thước mới của các controls bên trong GroupBox
            int newWidth = groupBox1.ClientSize.Width;
            int newHeight = groupBox1.ClientSize.Height;

            // Phóng to DataGridView
            dtgvBangLuong.Size = new System.Drawing.Size(newWidth - 10, newHeight - 120);

            //// Cập nhật vị trí của các button
            int gB2X = newWidth - 300;
            int gB2Y = newHeight - 790;
            groupBox2.Location = new System.Drawing.Point(gB2X, gB2Y);
        }

        private void btnBoDuyetTatCa_Click(object sender, EventArgs e)
        {
            int thanglap = cbThangBL.SelectedIndex + 1;
            string namlap = cbNamBL.SelectedItem.ToString();
            foreach (DataGridViewRow row in dtgvBangLuong.Rows)
            {
                // Lấy giá trị của ô checkbox
                object checkboxCellValue = row.Cells["tinhTrangDuyetDataGridViewCheckBoxColumn"].Value;
                // Kiểm tra nếu giá trị là DBNull.Value hoặc null, trả về false
                bool checkboxValue = (checkboxCellValue != DBNull.Value && checkboxCellValue != null) ? false : false;
                // Sử dụng giá trị của checkboxValue như bạn cần
                string TTD = checkboxValue ? "false" : null; // Set TTD to "true" if checkboxValue is true, otherwise set to null
                int SttBL = Convert.ToInt32(row.Cells[0].Value);
                // Perform the database update
                UpdateDatabase(SttBL, TTD);
            }
            // Cập nhật DataTable dtNew
            MessageBox.Show("Đã bỏ duyệt tất cả!");
            UpdateDataTable(thanglap, namlap);
        }

        private void BtnButToan_Click(object sender, EventArgs e)
        {
            ButToan fr = new ButToan();
            fr.BtnLapBTBL.Visible = !fr.BtnLapBTBL.Visible;
            fr.ShowDialog();
        }
    }
}

