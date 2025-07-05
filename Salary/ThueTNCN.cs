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
    public partial class ThueTNCN : Form
    {
        public ThueTNCN()
        {
            InitializeComponent();
        }

        private void ThueTNCN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thueTNCNDB.ThueTNCN' table. You can move, or remove it, as needed.
            //this.thueTNCNTableAdapter.Fill(this.thueTNCNDB.ThueTNCN);
        }
        private void ThemThueTNCN_Click(object sender, EventArgs e)
        {
            int thanglap = cbThangThue.SelectedIndex + 1;
            string namlap = cbNamThue.SelectedItem.ToString();
            string MaKL = thanglap.ToString() + namlap;
            DateTime dateTime = dtpNgaylapThue.Value;
            DataTable dtData = ConnectSQL.Load(@"
            SELECT LuongCN.SttLCN, PhuCapAn, LuongTheoNC, LuongTC, LuongTCKhongTT, LuongCN.MaNV, SttBH, TongBH, MaGTGC, TongGTGC, MAX(GiamTruGiaCanh.NgayLap) AS MaxNgayLap
            FROM LuongCN
            LEFT JOIN BaoHiemVaCongDoan ON LuongCN.SttLCN = BaoHiemVaCongDoan.SttLCN
            RIGHT JOIN GiamTruGiaCanh ON LuongCN.MaNV = GiamTruGiaCanh.MaNV
            LEFT JOIN HopDongLD on LuongCN.SttHDLD = HopDongLD.SttHDLD
            WHERE GiamTruGiaCanh.NgayLap = (
                    SELECT MAX(NgayLap) 
                    FROM GiamTruGiaCanh 
                    WHERE GiamTruGiaCanh.MaNV = LuongCN.MaNV
                )
                AND MONTH(LuongCN.NgayLap) = '" + thanglap.ToString() + "' AND YEAR(LuongCN.NgayLap) = '" + namlap + @"'
            GROUP BY LuongCN.SttLCN, LuongTheoNC, LuongCN.MaNV, SttBH, TongBH, MaGTGC, TongGTGC, PhuCapAn, LuongTC, LuongTCKhongTT");
            foreach (DataRow row in dtData.Rows)
            {
                int SttLCN = Convert.ToInt32(row["SttLCN"]);
                int ThuNhapCT = Convert.ToInt32(row["LuongTheoNC"]) + Convert.ToInt32(row["LuongTC"]) - Convert.ToInt32(row["LuongTCKhongTT"]) + Convert.ToInt32(row["PhuCapAn"]) - Math.Min(730000, Convert.ToInt32(row["PhuCapAn"]));
                int TongBH = Convert.ToInt32(row["TongBH"]);
                int SttBH = Convert.ToInt32(row["SttBH"]);
                string MaGTGC = Convert.ToString(row["MaGTGC"]);
                int TongGTGC = Convert.ToInt32(row["TongGTGC"]);
                int ThuNhapTT = ThuNhapCT - TongBH - TongGTGC;
                if (ThuNhapTT > 0)
                {
                    DataTable dtNhanVien = new DataTable();
                    dtNhanVien = ConnectSQL.Load("SELECT TinhTrang FROM NhanVien where MaNV = '" + row["MaNV"].ToString() + "'");
                    foreach (DataRow row5 in dtNhanVien.Rows)
                    {
                        if (row5["TinhTrang"].ToString() == "Chính thức")
                        {
                            DataTable dtData3 = ConnectSQL.Load("SELECT SttQD, LuongTT, LuongTD, ThueSuat, LuyTien FROM QuyDinhTT");
                            foreach (DataRow row3 in dtData3.Rows)
                            {
                                if (ThuNhapTT > Convert.ToInt32(row3["LuongTT"]) && (row3["LuongTD"] == null || ThuNhapTT <= Convert.ToInt32(row3["LuongTD"])))
                                {
                                    int SttQD = Convert.ToInt32(row3["SttQD"]);
                                    double ThueSuat = Convert.ToDouble(row3["ThueSuat"]);
                                    int LuyTien = Convert.ToInt32(row3["LuyTien"]);
                                    int ThueTNCN = Convert.ToInt32(ThuNhapTT * ThueSuat - LuyTien);
                                    try
                                    {
                                        thueTNCNTableAdapter.Insert(dateTime, ThuNhapCT, SttBH, MaGTGC, SttLCN, ThuNhapTT, SttQD, ThueTNCN, MaKL);
                                    }
                                    catch (System.Exception ex)
                                    {
                                        MessageBox.Show("CÓ LỖI KHI TẠO DANH SÁCH ĐÓNG THUẾ MỚI " + ex.Message);
                                    }
                                }
                            }
                        }
                        else
                        {
                            int? SttQD = null;
                            double ThueSuat = 0.1;
                            int ThueTNCN = Convert.ToInt32(ThuNhapTT * ThueSuat);
                            try
                            {
                                thueTNCNTableAdapter.Insert(dateTime, ThuNhapCT, SttBH, MaGTGC, SttLCN, ThuNhapTT, SttQD, ThueTNCN, MaKL);
                            }
                            catch (System.Exception ex)
                            {
                                MessageBox.Show("CÓ LỖI KHI TẠO DANH SÁCH ĐÓNG THUẾ MỚI " + ex.Message);
                            }
                        }
                    }
                }
            }
            this.thueTNCNTableAdapter.Fill(this.thueTNCNDB.ThueTNCN);
            MessageBox.Show("Thêm xong, mời xem!");
        }

        private void BtnButToan_Click(object sender, EventArgs e)
        {
            ButToan fr = new ButToan();
            fr.BtnLapBTThue.Visible = !fr.BtnLapBTThue.Visible;
            fr.ShowDialog();
        }

        private void BtnThueTNCN_Click(object sender, EventArgs e)
        {
            int thanglap = cbThangThue.SelectedIndex + 1;
            string namlap = cbNamThue.SelectedItem.ToString();

            // Cập nhật DataTable dtNew
            UpdateDataTable(thanglap, namlap);
        }
        private void UpdateDataTable(int thanglap, string namlap)
        {

            DataTable dtData2 = ConnectSQL.Load(@"
            SELECT *
            FROM ThueTNCN
            WHERE MONTH(NgayLap) = '" + thanglap.ToString() + "' AND YEAR(NgayLap) = '" + namlap + @"'");
            try
            {
                dtgvThueTNCN.DataSource = dtData2;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("CÓ LỖI KHI XEM BẢNG THUẾ THU NHẬP CÁ NHÂN!" + ex.Message);
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
            int thanglap = cbThangThue.SelectedIndex + 1;
            //int namlap = (int)cbNamBL.SelectedItem;
            //int? namlap = cbNamBL.SelectedItem != DBNull.Value ? (int?)cbNamBL.SelectedItem : null;
            string namlap = cbNamThue.SelectedItem.ToString();
            lenh2.CommandText = "SELECT TenNV, ThueTNCN.NgayLap, ThuNhapCT, ThuNhapTT, ISNULL(ThueSuat*100, 10) as 'ThueSuat', TinhTrang, ThueTNCN, " +
                " month(ThueTNCN.NgayLap) as 'Thang', year(ThueTNCN.NgayLap) as 'Nam'" +
                " FROM ThueTNCN LEFT JOIN LuongCN ON ThueTNCN.SttLCN = LuongCN.SttLCN" +
                " LEFT JOIN NhanVien on LuongCN.MaNV = NhanVien.MaNV " +
                " LEFT JOIN QuyDinhTT on ThueTNCN.SttQD = QuyDinhTT.SttQD WHERE MONTH(ThueTNCN.NgayLap) = @thanglap" +
                " AND YEAR(ThueTNCN.NgayLap) = @namlap";
            lenh2.Parameters.Clear();
            lenh2.Parameters.AddWithValue("@thanglap", thanglap);
            lenh2.Parameters.AddWithValue("@namlap", namlap);
            da2.SelectCommand = lenh2;
            DataTable dt = new DataTable("ThueTNCNIn");
            da2.Fill(dt);
            //Gán nguồn dữ liệu cho Crystal Report
            rptThueTNCN baocaothue = new rptThueTNCN();
            baocaothue.SetDataSource(dt);
            //HIển thị báo cáo
            frmInThueTNCN frmithue = new frmInThueTNCN();
            frmithue.crystalReportViewerThueTNCN.ReportSource = baocaothue;
            frmithue.ShowDialog();
        }
        private void DataDelete(string SttTTNCN)
        {
            DataTable dtDelete = new DataTable();
            dtDelete = ConnectSQL.Load("SELECT * FROM ThueTNCN WHERE SttTTNCN = '" + SttTTNCN + "'");
        }
        public string SttTTNCN;
        private void XoaDiem_Click(object sender, EventArgs e)
        {
            DataDelete(SttTTNCN);
            //B1: Hỏi xác nhận 
            DialogResult ch = MessageBox.Show("Bạn muốn xóa thông tin thuế thu nhập cá nhân có số thứ tự:" + SttTTNCN + " không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //B2: XÓA
            if (ch == DialogResult.Yes)
            {
                int SttTTNCN2 = Convert.ToInt32(SttTTNCN);
                try
                {
                    thueTNCNTableAdapter.Delete(SttTTNCN2);
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
                this.thueTNCNTableAdapter.Fill(this.thueTNCNDB.ThueTNCN);
            }
            catch (System.Exception) { }
        }

        private void dtgvThueTNCN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvThueTNCN.Rows[e.RowIndex];
                //Try try try
                SttTTNCN = row.Cells[0].Value.ToString();
            }
        }
    }
}
