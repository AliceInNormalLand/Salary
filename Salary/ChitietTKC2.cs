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
    public partial class ChitietTKC2 : Form
    {
        public ChitietTKC2()
        {
            InitializeComponent();
        }

        private void ChitietTKC2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chitietTKC2DB.ChiTietTKC2' table. You can move, or remove it, as needed.
            this.chiTietTKC2TableAdapter.Fill(this.chitietTKC2DB.ChiTietTKC2);
            // TODO: This line of code loads data into the 'chiTietTKC2DB.ChiTietTKC2' table. You can move, or remove it, as needed.
            //this.chiTietTKC2TableAdapter.Fill(this.chiTietTKC2DB.ChiTietTKC2);
            // TODO: This line of code loads data into the 'dMTKC2DB.DanhMucTKC2' table. You can move, or remove it, as needed.
            this.danhMucTKC2TableAdapter.Fill(this.dMTKC2DB.DanhMucTKC2);

        }
        private string GetString(DataRow row, string columnName)
        {
            return row[columnName] != DBNull.Value ? Convert.ToString(row[columnName]) : null;
        }
        private void ThemCTTKC2_Click(object sender, EventArgs e)
        {
            int thanglap = cbThangCTTKC2.SelectedIndex + 1;
            string namlap = cbNamCTTKC2.SelectedItem.ToString();
            string STK = CbSTHCT2.SelectedValue.ToString().Trim();
            DateTime ngaygs = dtpNHTCTTKC2.Value;

            int thangTruoc = (thanglap - 1 + 12) % 12; // Lấy tháng trước đó
            // In ra câu truy vấn để kiểm tra
            string queryDDK = "SELECT DuDauKy FROM HeThongTKC2 WHERE MaTKC2 = '" + STK + "' AND MONTH(NgayDK) = '" + thangTruoc.ToString() + "' AND YEAR(NgayDK) = '" + namlap + "'";
            Console.WriteLine("Query for DuDauKy: " + queryDDK);
            DataTable dtDDK = ConnectSQL.Load(queryDDK);
            int SD = 0;
            // Kiểm tra xem có dữ liệu từ truy vấn hay không
            if (dtDDK.Rows.Count > 0)
            {
                // Lặp qua các dòng của DataTable để lấy giá trị DuDauKy
                foreach (DataRow row in dtDDK.Rows)
                {
                    SD = Convert.ToInt32(row["DuDauKy"]);
                    // Hiển thị giá trị SoDu trong TextBox
                    tbCTTKC2.Text = SD.ToString();
                }
            }
            else
            {
                Console.WriteLine("No data for DuDauKy found.");
            }
            DataTable dtData = ConnectSQL.Load(@"
            SELECT SttBT, Ngaylap, TKNo, TKCo, Sotien, SttUNC, SttBL, SttBH, SttTTNCN, MaTU, Noidung
            FROM ButToan
            WHERE MONTH(NgayLap) = '" + thanglap.ToString() + "' AND YEAR(NgayLap) = '" + namlap + @"' and (TKNo = '" + STK + @"' or TKCo = '" + STK + @"')");

            foreach (DataRow row in dtData.Rows)
            {
                int SttBT = Convert.ToInt32(row["SttBT"]);
                DateTime ngayct = Convert.ToDateTime(row["Ngaylap"]);
                int? SttUNC = GetNullableInt(row, "SttUNC");
                int? SttBL = GetNullableInt(row, "SttBL");
                int? SttBH = GetNullableInt(row, "SttBH");
                int? SttTTNCN = GetNullableInt(row, "SttTTNCN");
                string MaTU = GetString(row, "MaTU");
                string TKNo = Convert.ToString(row["TKNo"]).Trim();
                string TKCo = Convert.ToString(row["TKCo"]).Trim();
                string DienGiai = Convert.ToString(row["Noidung"]);

                if (SttUNC != null || SttBL != null || SttBH != null || SttTTNCN != null || MaTU != null)
                {
                    string SoCT = (
                        SttUNC.HasValue ? SttUNC.ToString().Trim() :
                        SttBL.HasValue ? SttBL.ToString().Trim() :
                        SttBH.HasValue ? SttBH.ToString().Trim() :
                        SttTTNCN.HasValue ? SttTTNCN.ToString().Trim() :
                        MaTU);
                    int PSNo = TKNo == STK ? Convert.ToInt32(row["Sotien"]) : 0;
                    int PSCo = TKCo == STK ? Convert.ToInt32(row["Sotien"]) : 0;
                    string TKDU = TKNo == STK ? TKCo : TKNo;
                    int SDNo = TKNo == STK ? SD + PSNo : 0;
                    int SDCo = TKCo == STK ? SD + PSCo : 0;

                    try
                    {
                        // Thêm giá trị vào DataTable của DataGridView
                        chiTietTKC2TableAdapter.Insert(STK, SttBT, ngaygs, ngayct, SoCT, DienGiai, TKDU, PSNo, PSCo, SDNo, SDCo);

                        // Cập nhật giá trị SD cho vòng lặp tiếp theo
                        SD = TKNo == STK ? SD + PSNo : SD + PSCo;
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("CÓ LỖI KHI TẠO MỚI " + ex.Message);
                    }
                }
            }

            // Hiển thị DataTable mới trên DataGridView
            this.chiTietTKC2TableAdapter.Fill(this.chitietTKC2DB.ChiTietTKC2);
            MessageBox.Show("Thêm xong, mời xem!");
        }
        private int? GetNullableInt(DataRow row, string columnName)
        {
            return row[columnName] != DBNull.Value ? Convert.ToInt32(row[columnName]) : (int?)null;
        }

        private void btnXemCTTKC2_Click(object sender, EventArgs e)
        {
            int thanglap = cbThangCTTKC2.SelectedIndex + 1;
            string namlap = cbNamCTTKC2.SelectedItem.ToString();
            string STK = CbSTHCT2.SelectedValue.ToString().Trim();
            DataTable dtCTTKC2 = new DataTable();
            dtCTTKC2 = ConnectSQL.Load("SELECT * FROM ChiTietTKC2 WHERE MONTH(NgayGS) = '" + thanglap.ToString() + "' and YEAR(NgayGS) = '" + namlap + "' and MaTKC2 = '" + STK + "'");
            dtgvCTTKC2.DataSource = dtCTTKC2;
            this.chiTietTKC2TableAdapter.Fill(this.chitietTKC2DB.ChiTietTKC2);
        }
        private SqlCommand lenh = new SqlCommand();
        private SqlDataAdapter da = new SqlDataAdapter();
        private void btnExport_Click(object sender, EventArgs e)
        {
                SqlConnection connection = new SqlConnection(@"Data Source = ALICEWANG\SQLEXPRESS01; Initial Catalog = HRPayrollDB; Integrated Security = True; MultipleActiveResultSets = True; Connect Timeout = 0; Max Pool Size = 500; TrustServerCertificate = True;");

                // Set the connection for the SqlCommand
                lenh.Connection = connection;
                //Kết xuất nguồn dữ liệu cho Report
                int thanglap = cbThangCTTKC2.SelectedIndex + 1;
                string STK = CbSTHCT2.SelectedValue.ToString().Trim();
                string namlap = cbNamCTTKC2.SelectedItem.ToString();
                lenh.CommandText = "SELECT ChiTietTKC2.MaTKC2, NgayGS, NgayCT, SoCT, DienGiai, TKDU, PSNo, PSCo, SDNo, SDCo, ISNULL(DuNo,0) as 'DuNo', " +
                "ISNULL(DuCo,0) as 'DuCo', month(NgayGS) as 'Thang', year(NgayGS) as 'Nam', TenTK FROM ChiTietTKC2 LEFT JOIN DanhMucTKC2 on " +
                "ChiTietTKC2.MaTKC2 = DanhMucTKC2.MaTKC2 LEFT JOIN HeThongTKC2 on " +
                "ChiTietTKC2.MaTKC2 = HeThongTKC2.MaTKC2 WHERE Month(NgayGS) = @thanglap AND Year(NgayGS) = @namlap AND ChiTietTKC2.MaTKC2 = @STK";
                lenh.Parameters.Clear();
                lenh.Parameters.AddWithValue("@thanglap", thanglap);
                lenh.Parameters.AddWithValue("@namlap", namlap);
                lenh.Parameters.AddWithValue("@STK", STK);
                da.SelectCommand = lenh;
                DataTable dt = new DataTable("BangLuongIn");
                da.Fill(dt);
                //Gán nguồn dữ liệu cho Crystal Report
                rptSoChiTiet baocaochitiet = new rptSoChiTiet();
                baocaochitiet.SetDataSource(dt);
                //HIển thị báo cáo
                frmInChiTietTK2 frmInChiTiet = new frmInChiTietTK2();
                frmInChiTiet.crystalReportViewerInSCTTK.ReportSource = baocaochitiet;
                frmInChiTiet.ShowDialog();
        }
    }
}