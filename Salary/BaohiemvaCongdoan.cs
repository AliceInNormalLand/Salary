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

//namespace Salary
//{
//    public partial class Baohiem : Form
//    {
//        public Baohiem()
//        {
//            InitializeComponent();
//        }

//        private void Baohiem_Load(object sender, EventArgs e)
//        {
//            DataTable dtInsurances = new DataTable();
//            dtInsurances = ConnectSQL.Load("SELECT * FROM Insurances");
//            dtgvBaohiem.DataSource = dtInsurances;
//            if (dtgvBaohiem.Rows.Count > 0)
//            {
//                var row = this.dtgvBaohiem.Rows[0];
//                DataAccountingIn(row.Cells[1].Value.ToString());
//            }
//            else
//            {
//                DataAccountingIn("");
//            }
//        }
//        private void DataAccountingIn(string IDInsurances)
//        {
//            DataTable dtAccountingIn = new DataTable();
//            dtAccountingIn = ConnectSQL.Load("SELECT * FROM AccountingIn WHERE IDInsurances = '" + IDInsurances + "'");
//            dtgvHTBHNV.DataSource = dtAccountingIn;
//        }

//        private void dtgvBaohiem_CellClick(object sender, DataGridViewCellEventArgs e)
//        {
//            if (e.RowIndex >= 0)
//            {
//                DataGridViewRow row = this.dtgvBaohiem.Rows[e.RowIndex];
//                DataAccountingIn(row.Cells[1].Value.ToString());
//            }
//        }
//    }
//}

//namespace Salary
//{
//    public partial class Baohiem : Form
//    {
//        public Baohiem()
//        {
//            InitializeComponent();
//        }

//        private void Baohiem_Load(object sender, EventArgs e)
//        {
//            DataTable dtInsurances = new DataTable();
//            dtInsurances = ConnectSQL.Load("SELECT * FROM Insurances");
//            dtgvBaohiem.DataSource = dtInsurances;
//            if (dtgvBaohiem.Rows.Count > 0)
//            {
//                var row = this.dtgvBaohiem.Rows[0];
//                int IDInsurances;
//                if (int.TryParse(row.Cells[1].Value.ToString(), out IDInsurances))
//                {
//                    DataAccountingIn(IDInsurances);
//                }
//                else
//                {
//                    DataAccountingIn(0);
//                }
//            }
//            else
//            {
//                DataAccountingIn(0);
//            }
//        }

//        private void DataAccountingIn(int IDInsurances)
//        {
//            DataTable dtAccountingIn = new DataTable();
//            dtAccountingIn = ConnectSQL.Load("SELECT * FROM AccountingIn WHERE IDInsurances = " + IDInsurances);
//            dtgvHTBHNV.DataSource = dtAccountingIn;
//        }

//        private void dtgvBaohiem_CellClick(object sender, DataGridViewCellEventArgs e)
//        {
//            if (e.RowIndex >= 0)
//            {
//                DataGridViewRow row = this.dtgvBaohiem.Rows[e.RowIndex];
//                int IDInsurances;
//                if (int.TryParse(row.Cells[1].Value.ToString(), out IDInsurances))
//                {
//                    DataAccountingIn(IDInsurances);
//                }
//                else
//                {
//                    DataAccountingIn(0);
//                }
//            }
//        }
//    }
//}

namespace Salary
{
    public partial class BaohiemvaCongdoan : Form
    {
        //DataTable dtInsurances;
        public BaohiemvaCongdoan()
        {
            InitializeComponent();
        }

        private void Baohiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toiThieuVungDB.ToiThieuVung' table. You can move, or remove it, as needed.
            this.toiThieuVungTableAdapter.Fill(this.toiThieuVungDB.ToiThieuVung);
            // TODO: This line of code loads data into the 'bHvaCDDB.BaoHiemVaCongDoan' table. You can move, or remove it, as needed.
            //this.baoHiemVaCongDoanTableAdapter.Fill(this.bHvaCDDB.BaoHiemVaCongDoan);
        }
       

        private void ThemBHvaCD_Click_1(object sender, EventArgs e)
        {
            int thanglap = cbThangBH.SelectedIndex + 1;
            string namlap = cbNamBH.SelectedItem.ToString();
            string MaKL = thanglap.ToString() + namlap;
            string ngaylap = dtpNgaylapBH.Text.Trim();
            DateTime dateTime = dtpNgaylapBH.Value;
            int LuongTTV = (int)cbVung.SelectedValue;
            DataTable dtLuongCN = new DataTable();
            dtLuongCN = ConnectSQL.Load("SELECT SttLCN, LuongCB, MaNV FROM LuongCN WHERE MONTH(NgayLap) = '" + thanglap.ToString() + "' and YEAR(NgayLap) = '" + namlap + "'");
            foreach (DataRow row in dtLuongCN.Rows)
            {
                int SttLCN = Convert.ToInt32(row["SttLCN"]);
                int LuongCB = Convert.ToInt32(row["LuongCB"]);
                DataTable dtLuongCS = new DataTable();
                dtLuongCS = ConnectSQL.Load("SELECT SttLCS, MucCS FROM LuongCS WHERE Ngayhieuluc <= '" + dateTime + "' AND Ngayhieuluc = (SELECT MAX(Ngayhieuluc) FROM LuongCS);");
                foreach (DataRow row2 in dtLuongCS.Rows)
                {
                    int SttLCS = Convert.ToInt32(row2["SttLCS"]);
                    int MucCS = Convert.ToInt32(row2["MucCS"]);
                    DataTable dtLuongTTV = new DataTable();
                    dtLuongTTV = ConnectSQL.Load("SELECT SttTTV, LuongTTV FROM ToiThieuVung WHERE LuongTTV = '" + LuongTTV.ToString() + "'");
                    foreach (DataRow row3 in dtLuongTTV.Rows)
                    {
                        int SttTTV = Convert.ToInt32(row3["SttTTV"]);
                        int MucTTV = Convert.ToInt32(row3["LuongTTV"]);
                        DataTable dtCongDoan = new DataTable();
                        dtCongDoan = ConnectSQL.Load("SELECT CongDoan FROM NhanVien WHERE MaNV = '" + row["MaNV"].ToString() + "'");
                        foreach (DataRow row4 in dtCongDoan.Rows)
                        {
                            int BHXHNV = (int)((int)Math.Min(LuongCB, 20 * MucCS) * 0.08);
                            int BHXHDN = (int)((int)Math.Min(LuongCB, 20 * MucCS) * 0.175);
                            int BHYTNV = (int)((int)Math.Min(LuongCB, 20 * MucCS) * 0.015);
                            int BHYTDN = (int)((int)Math.Min(LuongCB, 20 * MucCS) * 0.03);
                            int BHTNNV = (int)((int)Math.Min(LuongCB * 0.01, 20 * MucTTV));
                            int BHTNDN = (int)((int)Math.Min(LuongCB * 0.01, 20 * MucTTV));
                            bool ThamgiaCD = Convert.ToBoolean(row4["CongDoan"]);
                            if (ThamgiaCD == true)
                            {
                                int TongBH = BHXHNV + BHYTNV + BHTNNV;
                                int DoanPhi = (int)((int)Math.Min(LuongCB * 0.01, 0.1 * MucCS));
                                int KinhphiCD = (int)((int)Math.Min(LuongCB, 20 * MucCS) * 0.02);
                                try
                                {
                                    //@Code_Employee,@Name,@Sex,@DateOfBirth,@IDno,@PhoneNum,@Email,@TaxIDNum,@CodePo,@CodeDe,@Union,@Condition,@EnteringDate
                                    baoHiemVaCongDoanTableAdapter.Insert(ngaylap, SttLCS, SttTTV, SttLCN, BHXHNV, BHXHDN, BHYTNV, BHYTDN, BHTNNV, BHTNDN, TongBH, DoanPhi, KinhphiCD, MaKL);
                                }
                                catch (System.Exception ex) { MessageBox.Show("CÓ LỖI KHI TẠO DANH SÁCH ĐÓNG BẢO HIỂM VÀ CÔNG ĐOÀN MỚI " + ex.Message); }
                            }
                            if (ThamgiaCD == false)
                            {
                                int TongBH = BHXHNV + BHYTNV + BHTNNV;
                                int DoanPhi = 0;
                                int KinhphiCD = (int)((int)Math.Min(LuongCB, 20 * MucCS) * 0.02);
                                try
                                {
                                    //@Code_Employee,@Name,@Sex,@DateOfBirth,@IDno,@PhoneNum,@Email,@TaxIDNum,@CodePo,@CodeDe,@Union,@Condition,@EnteringDate
                                    baoHiemVaCongDoanTableAdapter.Insert(ngaylap, SttLCS, SttTTV, SttLCN, BHXHNV, BHXHDN, BHYTNV, BHYTDN, BHTNNV, BHTNDN, TongBH, DoanPhi, KinhphiCD, MaKL);
                                }
                                catch (System.Exception ex) { MessageBox.Show("CÓ LỖI KHI TẠO DANH SÁCH ĐÓNG BẢO HIỂM VÀ CÔNG ĐOÀN MỚI " + ex.Message); }
                            }
                        }
                    }
                }
            }
            this.baoHiemVaCongDoanTableAdapter.Fill(this.bHvaCDDB.BaoHiemVaCongDoan);
            MessageBox.Show("Thêm xong, mời xem!");
        }
        private void BtnButToan_Click(object sender, EventArgs e)
        {
            ButToan fr = new ButToan();
            fr.BtnLapBTBH.Visible = !fr.BtnLapBTBH.Visible;
            fr.ShowDialog();
        }

        private void BtnBHvaCD_Click(object sender, EventArgs e)
        {
            int thanglap = cbThangBH.SelectedIndex + 1;
            string namlap = cbNamBH.SelectedItem.ToString();

            // Cập nhật DataTable dtNew
            UpdateDataTable(thanglap, namlap);
        }
        private void UpdateDataTable(int thanglap, string namlap)
        {

            DataTable dtData2 = ConnectSQL.Load(@"
            SELECT *
            FROM BaoHiemVaCongDoan
            WHERE MONTH(NgayLap) = '" + thanglap.ToString() + "' AND YEAR(NgayLap) = '" + namlap + @"'");
            try
            {
                dtgvBaohiem.DataSource = dtData2;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("CÓ LỖI KHI XEM BẢNG THUẾ THU NHẬP CÁ NHÂN!" + ex.Message);
            }

        }
        private SqlCommand lenh1 = new SqlCommand();
        private SqlDataAdapter da1 = new SqlDataAdapter();
        private void btnExport_Click(object sender, EventArgs e)
        {
            // Declare SqlConnection if not declared already
            SqlConnection connection = new SqlConnection(@"Data Source = ALICEWANG\SQLEXPRESS01; Initial Catalog = HRPayrollDB; Integrated Security = True; MultipleActiveResultSets = True; Connect Timeout = 0; Max Pool Size = 500; TrustServerCertificate = True;");

            // Set the connection for the SqlCommand
            lenh1.Connection = connection;
            //Kết xuất nguồn dữ liệu cho Report
            int thanglap = cbThangBH.SelectedIndex + 1;
            //int namlap = (int)cbNamBL.SelectedItem;
            //int? namlap = cbNamBL.SelectedItem != DBNull.Value ? (int?)cbNamBL.SelectedItem : null;
            string namlap = cbNamBH.SelectedItem.ToString();
            lenh1.CommandText = "SELECT TenNV, BaoHiemVaCongDoan.NgayLap, month(BaoHiemVaCongDoan.NgayLap) as 'Thang', year(BaoHiemVaCongDoan.NgayLap) as 'Nam', " +
                " DoanPhi , BHXHNV, BHYTNV, BHTNNV," +
                " BHXHDN, BHYTDN, BHTNDN, KinhPhiCD" +
                " FROM BaoHiemVaCongDoan LEFT JOIN LuongCN ON BaoHiemVaCongDoan.SttLCN = LuongCN.SttLCN" +
                " LEFT JOIN NhanVien on " +
                " LuongCN.MaNV = NhanVien.MaNV WHERE MONTH(BaoHiemVaCongDoan.NgayLap) = @thanglap" +
                " AND YEAR(BaoHiemVaCongDoan.NgayLap) = @namlap";
            lenh1.Parameters.Clear();
            lenh1.Parameters.AddWithValue("@thanglap", thanglap);
            lenh1.Parameters.AddWithValue("@namlap", namlap);
            da1.SelectCommand = lenh1;
            DataTable dt = new DataTable("BangLuongIn");
            da1.Fill(dt);
            //Gán nguồn dữ liệu cho Crystal Report
            rptBaoHiem baocaobaohiem = new rptBaoHiem();
            baocaobaohiem.SetDataSource(dt);
            //HIển thị báo cáo
            frmInBaoHiem frmibh = new frmInBaoHiem();
            frmibh.crystalReportViewerBaoHiem.ReportSource = baocaobaohiem;
            frmibh.ShowDialog();
        }
    }
}

