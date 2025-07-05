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
    public partial class ChitietTKC1 : Form
    {
        public ChitietTKC1()
        {
            InitializeComponent();
        }

        private void ChitietTKC1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chiTietTKC1DB.ChiTietTKC1' table. You can move, or remove it, as needed.
            this.chiTietTKC1TableAdapter.Fill(this.chiTietTKC1DB.ChiTietTKC1);
            // TODO: This line of code loads data into the 'dMTKC1DB.DanhMucTKC1' table. You can move, or remove it, as needed.
            this.danhMucTKC1TableAdapter.Fill(this.dMTKC1DB.DanhMucTKC1);
            // TODO: This line of code loads data into the 'chiTietTKC1DB.ChiTietTKC1' table. You can move, or remove it, as needed.
            //this.chiTietTKC1TableAdapter.Fill(this.chiTietTKC1DB.ChiTietTKC1);

        }

        private void ThemCTTKC1_Click(object sender, EventArgs e)
        {
            int thanglap = cbThangCTTKC1.SelectedIndex + 1;
            string namlap = cbNamCTTKC1.SelectedItem.ToString();
            string STK = CbSTHCT1.SelectedValue.ToString().Trim();
            DateTime ngaygs = dtpNHTCTTKC1.Value;

            int thangTruoc = (thanglap - 1 + 12) % 12; // Lấy tháng trước đó
            // In ra câu truy vấn để kiểm tra
            string queryDDK = "SELECT DuDauKy FROM HeThongTKC1 WHERE MaTKC1 = '" + STK + "' AND MONTH(NgayDK) = '" + thangTruoc.ToString() + "' AND YEAR(NgayDK) = '" + namlap + "'";
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
                    tbCTTKC1.Text = SD.ToString();
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
                        chiTietTKC1TableAdapter.Insert(STK, SttBT, ngaygs, ngayct, SoCT, DienGiai, TKDU, PSNo, PSCo, SDNo, SDCo);

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
            this.chiTietTKC1TableAdapter.Fill(this.chiTietTKC1DB.ChiTietTKC1);
            MessageBox.Show("Thêm xong, mời xem!");
        }
        private int? GetNullableInt(DataRow row, string columnName)
        {
            return row[columnName] != DBNull.Value ? Convert.ToInt32(row[columnName]) : (int?)null;
        }
        private string GetString(DataRow row, string columnName)
        {
            return row[columnName] != DBNull.Value ? Convert.ToString(row[columnName]) : null;
        }

        private void btnXemCTTKC1_Click(object sender, EventArgs e)
        {
            int thanglap = cbThangCTTKC1.SelectedIndex + 1;
            string namlap = cbNamCTTKC1.SelectedItem.ToString();
            string STK = CbSTHCT1.SelectedValue.ToString().Trim();
            DataTable dtCTTKC1 = new DataTable();
            dtCTTKC1 = ConnectSQL.Load("SELECT * FROM ChiTietTKC1 WHERE MONTH(NgayGS) = '" + thanglap.ToString() + "' and YEAR(NgayGS) = '" + namlap + "' and MaTKC1 = '" + STK + "'");
            dtgvCTTKC1.DataSource = dtCTTKC1;
            this.chiTietTKC1TableAdapter.Fill(this.chiTietTKC1DB.ChiTietTKC1);
        }
    }
}
