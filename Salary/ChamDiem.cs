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

namespace Salary
{
    public partial class ChamDiem : Form
    {
        public ChamDiem()
        {
            InitializeComponent();
        }

        private void DanhgiaNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chamDiemDB.ChamDiem' table. You can move, or remove it, as needed.
            this.chamDiemTableAdapter.Fill(this.chamDiemDB.ChamDiem);
        }


        private void ThemDiem_Click(object sender, EventArgs e)
        {
            ChitietCD fr = new ChitietCD();
            //fr.SuaCD2.Visible = false;
            fr.ThemCD2.DialogResult = DialogResult.OK;
            fr.ShowDialog();
            if (fr.DialogResult == DialogResult.OK)
            {
                // Lấy dữ liệu từ Form 2
                DateTime ngaylap = fr.NgayLap;
                string NgayLapCD = ngaylap.ToString("yyyy-MM-dd");
                string manv = fr.manv.Trim();
                int danhgia = fr.DanhGia;
                string ghichu = fr.GhiChu.Trim();
                double diem = fr.Diem;
                string makl = ngaylap.Month.ToString().Trim() + ngaylap.Year.ToString().Trim();
                try
                {
                    chamDiemTableAdapter.Insert(NgayLapCD, manv, danhgia, diem, ghichu, makl);
                    MessageBox.Show("Thêm xong, mời xem!");
                }
                catch (System.Exception ex) { MessageBox.Show("CÓ LỖI KHI THÊM NHÂN VIÊN MỚI " + ex.Message); }
                try
                {
                    //employeeDB.Employee.AcceptChanges(); 
                    this.chamDiemTableAdapter.Fill(this.chamDiemDB.ChamDiem);
                }
                catch (System.Exception) { }
            }
        }
        
        private void DataDelete(string SttCD)
        {
            DataTable dtDelete = new DataTable();
            dtDelete = ConnectSQL.Load("SELECT * FROM ChamDiem WHERE SttCD = '" + SttCD + "'");
        }
        private void XoaDiem_Click(object sender, EventArgs e)
        {
            DataDelete(SttCD);
            //B1: Hỏi xác nhận 
            DialogResult ch = MessageBox.Show("Bạn muốn xóa thông tin chấm điểm có số thứ tự:" + SttCD + " không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //B2: XÓA
            if (ch == DialogResult.Yes)
            {
                int SttCD2 = Convert.ToInt32(SttCD);
                try
                {
                    chamDiemTableAdapter.Delete(SttCD2);
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
                this.chamDiemTableAdapter.Fill(this.chamDiemDB.ChamDiem);
            }
            catch (System.Exception) { }
        }
        public string SttCD;
        private void dtgvChamDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvChamDiem.Rows[e.RowIndex];
                //Try try try
                SttCD = row.Cells[0].Value.ToString();
            }
        }

        private void BtnThueTNCN_Click(object sender, EventArgs e)
        {
            int thanglap = cbThang.SelectedIndex + 1;
            string namlap = cbNam.SelectedItem.ToString();

            // Cập nhật DataTable dtNew
            UpdateDataTable(thanglap, namlap);
        }

        private void UpdateDataTable(int thanglap, string namlap)
        {

            DataTable dtData2 = ConnectSQL.Load(@"
            SELECT *
            FROM ChamDiem
            WHERE MONTH(NgayLap) = '" + thanglap.ToString() + "' AND YEAR(NgayLap) = '" + namlap + @"'");
            try
            {
                dtgvChamDiem.DataSource = dtData2;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("CÓ LỖI KHI XEM BẢNG CHẤM ĐIỂM!" + ex.Message);
            }

        }
        private SqlCommand lenh2 = new SqlCommand();
        private SqlDataAdapter da2 = new SqlDataAdapter();
        private void btnExport_Click(object sender, EventArgs e)
        {
            // Declare SqlConnection if not declared already
            SqlConnection connection = new SqlConnection(@"Data Source = ALICEWANG\SQLEXPRESS01; Initial Catalog = HRPayrollDB; Integrated Security = True; MultipleActiveResultSets = True; Connect Timeout = 0; Max Pool Size = 500; TrustServerCertificate = True;");

            // Set the connection for the SqlCommand
            lenh2.Connection = connection;
            //Kết xuất nguồn dữ liệu cho Report
            int thanglap = cbThang.SelectedIndex + 1;
            //int namlap = (int)cbNamBL.SelectedItem;
            //int? namlap = cbNamBL.SelectedItem != DBNull.Value ? (int?)cbNamBL.SelectedItem : null;
            string namlap = cbNam.SelectedItem.ToString();
            //lenh2.CommandText = "SELECT Month(ChamCong.NgayLap) as 'Thang', Year(ChamCong.NgayLap) as 'Nam',TenNV, TenPB, TenCV, (9 + SUM(ISNULL(Diem, 0))) as 'TongDiem' From ChamCong LEFT JOIN ChamDiem on " +
            //"ChamCong.MaNV = ChamDiem.MaNV and month(ChamDiem.NgayLap) = @thanglap AND YEAR(ChamDiem.NgayLap) = @namlap LEFT JOIN NhanVien on ChamCong.MaNV = NhanVien.MaNV LEFT JOIN PhongBan on NhanVien.MaPB = PhongBan.MaPB " +
            //"LEFT JOIN ChucVu on NhanVien.MaCV = ChucVu.MaCV WHERE month(ChamCong.NgayLap) = @thanglap AND YEAR(ChamCong.NgayLap) = @namlap Group by ChamCong.NgayLap,TenNV, TenPB, TenCV, ChamCong.MaNV Order by ChamCong.MaNV";
            lenh2.CommandText = "SELECT Month(ChamCong.NgayLap) as 'Thang', Year(ChamCong.NgayLap) as 'Nam', TenNV, TenPB, TenCV, (9 + SUM(ISNULL(Diem, 0))) " +
                "as 'TongDiem', Xeploai, Heso FROM ThangDG, ChamCong LEFT JOIN ChamDiem ON ChamCong.MaNV = ChamDiem.MaNV AND MONTH(ChamDiem.NgayLap) = @thanglap AND YEAR(ChamDiem.NgayLap) = @namlap " +
                "LEFT JOIN NhanVien ON ChamCong.MaNV = NhanVien.MaNV LEFT JOIN PhongBan ON NhanVien.MaPB = PhongBan.MaPB LEFT JOIN ChucVu ON " +
                "NhanVien.MaCV = ChucVu.MaCV WHERE MONTH(ChamCong.NgayLap) = @thanglap AND YEAR(ChamCong.NgayLap) = @namlap GROUP BY ChamCong.NgayLap, TenNV, TenPB, TenCV, ChamCong.MaNV, Xeploai, " +
                "MucTD, MucTT, Heso HAVING Heso IN(SELECT Heso FROM ThangDG WHERE ((9 + COALESCE(SUM(ISNULL(Diem, 0)), 0)) <= MucTD AND(9 + COALESCE" +
                "(SUM(ISNULL(Diem, 0)), 0)) > MucTT) OR ((9 + COALESCE(SUM(ISNULL(Diem, 0)), 0)) > (SELECT MAX(MucTT) FROM ThangDG))) ORDER BY ChamCong.MaNV";
            lenh2.Parameters.Clear();
            lenh2.Parameters.AddWithValue("@thanglap", thanglap);
            lenh2.Parameters.AddWithValue("@namlap", namlap);
            da2.SelectCommand = lenh2;
            DataTable dt = new DataTable("ChamDiemIn");
            da2.Fill(dt);
            //Gán nguồn dữ liệu cho Crystal Report
            rptChamDiemCC baocaodiemchuyencan = new rptChamDiemCC();
            baocaodiemchuyencan.SetDataSource(dt);
            //HIển thị báo cáo
            frmInChamDiemCC frmInChamDiem = new frmInChamDiemCC();
            frmInChamDiem.crystalReportViewerChamDiemCC.ReportSource = baocaodiemchuyencan;
            frmInChamDiem.ShowDialog();
        }
    }
}
