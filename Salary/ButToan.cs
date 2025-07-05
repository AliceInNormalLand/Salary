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
    public partial class ButToan : Form
    {
        public ButToan()
        {
            InitializeComponent();
        }

        private void ButToan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vw2DB.vwTK1vaTK2' table. You can move, or remove it, as needed.
            this.vwTK1vaTK2TableAdapter1.Fill(this.vw2DB.vwTK1vaTK2);
            // TODO: This line of code loads data into the 'vwTKC1vaTKC2DB.vwTK1vaTK2' table. You can move, or remove it, as needed.
            this.vwTK1vaTK2TableAdapter.Fill(this.vwTKC1vaTKC2DB.vwTK1vaTK2);
            // TODO: This line of code loads data into the 'butToanDB.ButToan' table. You can move, or remove it, as needed.
            //this.butToanTableAdapter.Fill(this.butToanDB.ButToan);
        }
        public string ThangLapCT;
        public string NamLapCT;
        public string NgayLapCT;
        public DateTime NgayLapBT;
        public string Noidung;
        public string TKNo;
        public string TKCo;
        public int SoTien;
        public string MaKL;
        public int? SttUNC;
        public int? SttBL;
        public int? SttTTNCN;
        public string MaTU;
        public int? SttBH;
        public string TenNV;
        private void BtnLapBTTU_Click(object sender, EventArgs e)
        {
            DateTime selectedDate2 = DtpCT.Value;
            NgayLapCT = selectedDate2.ToString("yyyy-MM-dd");
            NgayLapBT = DtpBT.Value;
            TKNo = CbTKNo.SelectedValue.ToString().Trim();
            TKCo = CbTKCo.SelectedValue.ToString().Trim();
            DataTable dtPhieuTU = ConnectSQL.Load("SELECT MaTU, SoTien, MaKL, MoTa, TenNV FROM TamUng join NhanVien on TamUng.MaNV = NhanVien.MaNV WHERE NgayLap = '" + NgayLapCT + "'");
            int rowCount = 0; // Đặt rowCount bên ngoài vòng lặp
            int hasNewData = 0;
            foreach (DataRow row in dtPhieuTU.Rows)
            {
                // Lấy giá trị của MaTU từ dòng hiện tại của dtPhieuTU
                MaTU = Convert.ToString(row["MaTU"]);

                // Kiểm tra xem MaTU đã tồn tại trong bảng ButToan hay không
                DataTable dtButToan = ConnectSQL.Load("SELECT * FROM ButToan where MaTU = '" + MaTU + "'");

                rowCount = dtButToan.Rows.Count; // Gán rowCount bằng số dòng trong dtButToan

                if (rowCount == 0) // Chỉ thêm mới khi không có dòng nào trong dtButToan
                {
                    hasNewData++; // Đặt hasNewData thành true nếu có dữ liệu mới được thêm vào
                    SoTien = Convert.ToInt32(row["SoTien"]);
                    MaKL = Convert.ToString(row["MaKL"]);
                    SttUNC = null;
                    SttBL = null;
                    SttTTNCN = null;
                    SttBH = null;
                    Noidung = Convert.ToString(row["MoTa"]) + " của nhân viên: " + Convert.ToString(row["TenNV"]);

                    try
                    {
                        // Thêm giá trị vào DataTable của DataGridView
                        butToanTableAdapter.Insert(NgayLapBT, Noidung, TKNo, TKCo, SoTien, MaKL, SttUNC, SttBL, SttTTNCN, MaTU, SttBH);
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("CÓ LỖI KHI TẠO BÚT TOÁN MỚI " + ex.Message);
                    }
                }
            }
            if (hasNewData > 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
            {
                MessageBox.Show("Đã tạo bút toán cho phiếu tạm ứng!");
            }
            if (hasNewData == 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
            {
                MessageBox.Show("Đã tồn tại hạch toán hoặc không có phiếu tạm ứng!");
            }
            this.butToanTableAdapter.Fill(this.butToanDB.ButToan);
            dtgvButToan.Refresh();
        }

        private void BtnLapBTBL_Click(object sender, EventArgs e)
        {
            DateTime selectedDate2 = DtpCT.Value;
            NgayLapCT = selectedDate2.ToString("yyyy-MM-dd");
            NgayLapBT = DtpBT.Value;
            TKNo = CbTKNo.SelectedValue.ToString().Trim();
            TKCo = CbTKCo.SelectedValue.ToString().Trim();
            //TÀI KHOẢN PHẢI TRẢ NHÂN VIÊN
            if (TKCo == "334")
            {
                if (TKNo == "641")
                {
                    DataTable dtBangLuong = ConnectSQL.Load("SELECT SttBL, TongLuong, BangLuong.MaKL, TenNV FROM BangLuong join LuongCN on BangLuong.SttLCN = LuongCN.SttLCN join NhanVien on LuongCN.MaNV = NhanVien.MaNV WHERE MaPB = 'KD' and MaCV = 'NV' and BangLuong.NgayLap = '" + NgayLapCT + "'");
                    int rowCount = 0; // Đặt rowCount bên ngoài vòng lặp
                    int hasNewData = 0;
                    foreach (DataRow row in dtBangLuong.Rows)
                    {
                        SttBH = null;
                        SttBL = Convert.ToInt32(row["SttBL"]);
                        SttUNC = null;
                        SttBL = null;
                        SttTTNCN = null;
                        MaTU = null;
                        SoTien = Convert.ToInt32(row["TongLuong"]);
                        Noidung = "Lương của nhân viên: " + Convert.ToString(row["TenNV"]);
                        MaKL = Convert.ToString(row["MaKL"]);
                        DataTable dtButToan = ConnectSQL.Load("SELECT * FROM ButToan where SttBL = '" + SttBL + "' AND TKNo = '641'");
                        rowCount = dtButToan.Rows.Count; // Gán rowCount bằng số dòng trong dtButToan
                        if (rowCount == 0) // Chỉ thêm mới khi không có dòng nào trong dtButToan
                        {
                            hasNewData++;
                            //Noidung = Convert.ToString(row["MoTa"]) + " của nhân viên: " + Convert.ToString(row["TenNV"]);
                            try
                            {
                                // Thêm giá trị vào DataTable của DataGridView
                                butToanTableAdapter.Insert(NgayLapBT, Noidung, TKNo, TKCo, SoTien, MaKL, SttUNC, SttBL, SttTTNCN, MaTU, SttBH);
                            }
                            catch (System.Exception ex)
                            {
                                MessageBox.Show("CÓ LỖI KHI TẠO BÚT TOÁN MỚI " + ex.Message);
                            }
                        }
                    }
                    if (hasNewData > 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
                    {
                        MessageBox.Show("Đã tạo bút toán cho bảng lương của nhân viên này!");
                    }
                    if (hasNewData == 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
                    {
                        MessageBox.Show("Đã tồn tại hạch toán hoặc không có thông tin về chi phí này!");
                    }
                    this.butToanTableAdapter.Fill(this.butToanDB.ButToan);
                    dtgvButToan.Refresh();
                }
                if (TKNo == "642")
                {
                    DataTable dtBangLuong1 = ConnectSQL.Load("SELECT SttBL, TongLuong, BangLuong.MaKL, TenNV FROM BangLuong join LuongCN on BangLuong.SttLCN = LuongCN.SttLCN join NhanVien on LuongCN.MaNV = NhanVien.MaNV WHERE (MaPB = 'BGD' or MaCV = 'TP' or MaCV = 'PP') and BangLuong.NgayLap = '" + NgayLapCT + "'");
                    int rowCount1 = 0; // Đặt rowCount bên ngoài vòng lặp
                    int hasNewData1 = 0;
                    foreach (DataRow row1 in dtBangLuong1.Rows)
                    {
                        SttBH = null;
                        SttBL = Convert.ToInt32(row1["SttBL"]);
                        SttUNC = null;
                        SttTTNCN = null;
                        MaTU = null;
                        SoTien = Convert.ToInt32(row1["TongLuong"]);
                        Noidung = "Lương của nhân viên: " + Convert.ToString(row1["TenNV"]);
                        MaKL = Convert.ToString(row1["MaKL"]);
                        DataTable dtButToan1 = ConnectSQL.Load("SELECT * FROM ButToan where SttBL = '" + SttBL + "' AND TKNo = '627'");
                        rowCount1 = dtButToan1.Rows.Count; // Gán rowCount bằng số dòng trong dtButToan
                        if (rowCount1 == 0) // Chỉ thêm mới khi không có dòng nào trong dtButToan
                        {
                            hasNewData1++;
                            //Noidung = Convert.ToString(row["MoTa"]) + " của nhân viên: " + Convert.ToString(row["TenNV"]);
                            try
                            {
                                // Thêm giá trị vào DataTable của DataGridView
                                butToanTableAdapter.Insert(NgayLapBT, Noidung, TKNo, TKCo, SoTien, MaKL, SttUNC, SttBL, SttTTNCN, MaTU, SttBH);
                            }
                            catch (System.Exception ex)
                            {
                                MessageBox.Show("CÓ LỖI KHI TẠO BÚT TOÁN MỚI " + ex.Message);
                            }
                        }
                    }
                    if (hasNewData1 > 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
                    {
                        MessageBox.Show("Đã tạo bút toán cho bảng lương của nhân viên này!");
                    }
                    if (hasNewData1 == 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
                    {
                        MessageBox.Show("Đã tồn tại hạch toán hoặc không có thông tin về chi phí này!");
                    }
                    this.butToanTableAdapter.Fill(this.butToanDB.ButToan);
                    dtgvButToan.Refresh();
                }
                if (TKNo == "627")
                {
                    DataTable dtBangLuong2 = ConnectSQL.Load("SELECT SttBL, TongLuong, BangLuong.MaKL, TenNV FROM BangLuong join LuongCN on BangLuong.SttLCN = LuongCN.SttLCN join NhanVien on LuongCN.MaNV = NhanVien.MaNV WHERE (MaPB = 'IT' or MaPB = 'KH' or MaPB = 'KT' or MaPB = 'NS' or MaPB = 'TC') and MaCV = 'NV' and BangLuong.NgayLap = '" + NgayLapCT + "'");
                    int rowCount2 = 0; // Đặt rowCount bên ngoài vòng lặp
                    int hasNewData2 = 0;
                    foreach (DataRow row2 in dtBangLuong2.Rows)
                    {
                        SttBH = null;
                        SttBL = Convert.ToInt32(row2["SttBL"]);
                        SttUNC = null;
                        SttTTNCN = null;
                        MaTU = null;
                        SoTien = Convert.ToInt32(row2["TongLuong"]);
                        Noidung = "Lương của nhân viên: " + Convert.ToString(row2["TenNV"]);
                        MaKL = Convert.ToString(row2["MaKL"]);
                        DataTable dtButToan2 = ConnectSQL.Load("SELECT * FROM ButToan where SttBL = '" + SttBL + "' AND TKNo = '627'");
                        rowCount2 = dtButToan2.Rows.Count; // Gán rowCount bằng số dòng trong dtButToan
                        if (rowCount2 == 0) // Chỉ thêm mới khi không có dòng nào trong dtButToan
                        {
                            hasNewData2++;
                            //Noidung = Convert.ToString(row["MoTa"]) + " của nhân viên: " + Convert.ToString(row["TenNV"]);
                            try
                            {
                                // Thêm giá trị vào DataTable của DataGridView
                                butToanTableAdapter.Insert(NgayLapBT, Noidung, TKNo, TKCo, SoTien, MaKL, SttUNC, SttBL, SttTTNCN, MaTU, SttBH);
                            }
                            catch (System.Exception ex)
                            {
                                MessageBox.Show("CÓ LỖI KHI TẠO BÚT TOÁN MỚI " + ex.Message);
                            }
                        }
                    }
                    if (hasNewData2 > 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
                    {
                        MessageBox.Show("Đã tạo bút toán cho bảng lương của nhân viên này!");
                    }
                    if (hasNewData2 == 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
                    {
                        MessageBox.Show("Đã tồn tại hạch toán hoặc không có thông tin về chi phí này!");
                    }
                    this.butToanTableAdapter.Fill(this.butToanDB.ButToan);
                    dtgvButToan.Refresh();
                }
            }
        }

        private void BtnLapBTThue_Click(object sender, EventArgs e)
        {
            DateTime selectedDate2 = DtpCT.Value;
            NgayLapCT = selectedDate2.ToString("yyyy-MM-dd");
            NgayLapBT = DtpBT.Value;
            TKNo = CbTKNo.SelectedValue.ToString().Trim();
            TKCo = CbTKCo.SelectedValue.ToString().Trim();
            DataTable dtPhieuTU = ConnectSQL.Load("SELECT SttTTNCN, ThueTNCN, ThueTNCN.MaKL, TenNV FROM ThueTNCN join LuongCN on ThueTNCN.SttLCN = LuongCN.SttLCN join NhanVien on LuongCN.MaNV = NhanVien.MaNV WHERE ThueTNCN.NgayLap = '" + NgayLapCT + "'");
            int rowCount = 0; // Đặt rowCount bên ngoài vòng lặp
            int hasNewData = 0;
            foreach (DataRow row in dtPhieuTU.Rows)
            {
                // Lấy giá trị của MaTU từ dòng hiện tại của dtPhieuTU
                SttTTNCN = Convert.ToInt32(row["SttTTNCN"]);

                // Kiểm tra xem MaTU đã tồn tại trong bảng ButToan hay không
                DataTable dtButToan = ConnectSQL.Load("SELECT * FROM ButToan where SttTTNCN = '" + SttTTNCN + "'");

                rowCount = dtButToan.Rows.Count; // Gán rowCount bằng số dòng trong dtButToan

                if (rowCount == 0) // Chỉ thêm mới khi không có dòng nào trong dtButToan
                {
                    hasNewData++; // Đặt hasNewData thành true nếu có dữ liệu mới được thêm vào
                    SoTien = Convert.ToInt32(row["ThueTNCN"]);
                    MaKL = Convert.ToString(row["MaKL"]);
                    SttUNC = null;
                    SttBL = null;
                    SttBH = null;
                    Noidung = " Thuế thu nhập cá nhân của nhân viên: " + Convert.ToString(row["TenNV"]);
                    MaTU = null;
                    try
                    {
                        // Thêm giá trị vào DataTable của DataGridView
                        butToanTableAdapter.Insert(NgayLapBT, Noidung, TKNo, TKCo, SoTien, MaKL, SttUNC, SttBL, SttTTNCN, MaTU, SttBH);
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("CÓ LỖI KHI TẠO BÚT TOÁN MỚI " + ex.Message);
                    }
                }
            }
            if (hasNewData > 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
            {
                MessageBox.Show("Đã tạo bút toán cho chi phí thuế TNCN!");
            }
            if (hasNewData == 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
            {
                MessageBox.Show("Đã tồn tại hạch toán hoặc không có thông tin về thuế thu nhập cá nhân!");
            }
            this.butToanTableAdapter.Fill(this.butToanDB.ButToan);
            dtgvButToan.Refresh();
        }

        private void BtnLapBTUNC_Click(object sender, EventArgs e)
        {
            DateTime selectedDate2 = DtpCT.Value;
            NgayLapCT = selectedDate2.ToString("yyyy-MM-dd");
            NgayLapBT = DtpBT.Value;
            TKNo = CbTKNo.SelectedValue.ToString().Trim();
            TKCo = CbTKCo.SelectedValue.ToString().Trim();
            DataTable dtPhieuUNC = ConnectSQL.Load("SELECT SttUNC, SoTien, MaKL, Noidung FROM UyNhiemChi WHERE Ngaylap = '" + NgayLapCT + "'");
            int rowCount = 0; // Đặt rowCount bên ngoài vòng lặp
            int hasNewData = 0;
            foreach (DataRow row in dtPhieuUNC.Rows)
            {
                // Lấy giá trị của MaTU từ dòng hiện tại của dtPhieuTU
                SttUNC = Convert.ToInt32(row["SttUNC"]);

                // Kiểm tra xem MaTU đã tồn tại trong bảng ButToan hay không
                DataTable dtButToan = ConnectSQL.Load("SELECT * FROM ButToan where SttUNC = '" + SttUNC + "'");

                rowCount = dtButToan.Rows.Count; // Gán rowCount bằng số dòng trong dtButToan

                if (rowCount == 0) // Chỉ thêm mới khi không có dòng nào trong dtButToan
                {
                    hasNewData++; // Đặt hasNewData thành true nếu có dữ liệu mới được thêm vào
                    SoTien = Convert.ToInt32(row["SoTien"]);
                    MaKL = Convert.ToString(row["MaKL"]);
                    MaTU = null;
                    SttBL = null;
                    SttTTNCN = null;
                    SttBH = null;
                    Noidung = Convert.ToString(row["Noidung"]);
                    try
                    {
                        // Thêm giá trị vào DataTable của DataGridView
                        butToanTableAdapter.Insert(NgayLapBT, Noidung, TKNo, TKCo, SoTien, MaKL, SttUNC, SttBL, SttTTNCN, MaTU, SttBH);
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("CÓ LỖI KHI TẠO BÚT TOÁN MỚI " + ex.Message);
                    }
                }
            }
            if (hasNewData > 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
            {
                MessageBox.Show("Đã tạo bút toán cho ủy nhiệm chi!");
            }
            if (hasNewData == 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
            {
                MessageBox.Show("Đã tồn tại hạch toán hoặc không có thông tin ủy nhiệm chi!");
            }
            this.butToanTableAdapter.Fill(this.butToanDB.ButToan);
            dtgvButToan.Refresh();
        }

        private void BtnLapBTBH_Click(object sender, EventArgs e)
        {
            DateTime selectedDate2 = DtpCT.Value;
            NgayLapCT = selectedDate2.ToString("yyyy-MM-dd");
            NgayLapBT = DtpBT.Value;
            TKNo = CbTKNo.SelectedValue.ToString().Trim();
            TKCo = CbTKCo.SelectedValue.ToString().Trim();
            //TÀI KHOẢN PHẢI TRẢ NHÂN VIÊN
            if (TKNo == "334")
            {
                if (TKCo == "3383")
                {
                    DataTable dtBaoHiemXH = ConnectSQL.Load("SELECT SttBH, BHXHNV, BaoHiemVaCongDoan.MaKL, TenNV FROM BaoHiemVaCongDoan join LuongCN on BaoHiemVaCongDoan.SttLCN = LuongCN.SttLCN join NhanVien on LuongCN.MaNV = NhanVien.MaNV WHERE BaoHiemVaCongDoan.NgayLap = '" + NgayLapCT + "'");
                    int rowCount = 0; // Đặt rowCount bên ngoài vòng lặp
                    int hasNewData = 0;
                    foreach (DataRow row in dtBaoHiemXH.Rows)
                    {
                        SttBH = Convert.ToInt32(row["SttBH"]);
                        SttUNC = null;
                        SttBL = null;
                        SttTTNCN = null;
                        MaTU = null;
                        SoTien = Convert.ToInt32(row["BHXHNV"]);
                        Noidung = "Chi phí bảo hiểm xã hội của nhân viên: " + Convert.ToString(row["TenNV"]);
                        MaKL = Convert.ToString(row["MaKL"]);
                        DataTable dtButToan = ConnectSQL.Load("SELECT * FROM ButToan where SttBH = '" + SttBH + "' AND TKCo = '3383'");
                        rowCount = dtButToan.Rows.Count; // Gán rowCount bằng số dòng trong dtButToan
                        if (rowCount == 0) // Chỉ thêm mới khi không có dòng nào trong dtButToan
                        {
                            hasNewData++;
                            //Noidung = Convert.ToString(row["MoTa"]) + " của nhân viên: " + Convert.ToString(row["TenNV"]);
                            try
                            {
                                // Thêm giá trị vào DataTable của DataGridView
                                butToanTableAdapter.Insert(NgayLapBT, Noidung, TKNo, TKCo, SoTien, MaKL, SttUNC, SttBL, SttTTNCN, MaTU, SttBH);
                            }
                            catch (System.Exception ex)
                            {
                                MessageBox.Show("CÓ LỖI KHI TẠO BÚT TOÁN MỚI " + ex.Message);
                            }
                        }
                    }
                    if (hasNewData > 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
                    {
                        MessageBox.Show("Đã tạo bút toán cho chi phí bảo hiểm này!");
                    }
                    if (hasNewData == 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
                    {
                        MessageBox.Show("Đã tồn tại hạch toán hoặc không có thông tin về chi phí này!");
                    }
                    this.butToanTableAdapter.Fill(this.butToanDB.ButToan);
                    dtgvButToan.Refresh();
                }
                if (TKCo == "3384")
                {
                    DataTable dtBaoHiemYT = ConnectSQL.Load("SELECT SttBH, BHYTNV, BaoHiemVaCongDoan.MaKL, TenNV FROM BaoHiemVaCongDoan join LuongCN on BaoHiemVaCongDoan.SttLCN = LuongCN.SttLCN join NhanVien on LuongCN.MaNV = NhanVien.MaNV WHERE BaoHiemVaCongDoan.NgayLap = '" + NgayLapCT + "'");
                    int rowCount = 0; // Đặt rowCount bên ngoài vòng lặp
                    int hasNewData = 0;
                    foreach (DataRow row in dtBaoHiemYT.Rows)
                    {
                        SttBH = Convert.ToInt32(row["SttBH"]);
                        SttUNC = null;
                        SttBL = null;
                        SttTTNCN = null;
                        MaTU = null;
                        SoTien = Convert.ToInt32(row["BHYTNV"]);
                        Noidung = "Chi phí bảo hiểm y tế của nhân viên: " + Convert.ToString(row["TenNV"]);
                        MaKL = Convert.ToString(row["MaKL"]);
                        DataTable dtButToan = ConnectSQL.Load("SELECT * FROM ButToan where SttBH = '" + SttBH + "' AND TKCo = '3384'");
                        rowCount = dtButToan.Rows.Count; // Gán rowCount bằng số dòng trong dtButToan
                        if (rowCount == 0) // Chỉ thêm mới khi không có dòng nào trong dtButToan
                        {
                            hasNewData++;
                            //Noidung = Convert.ToString(row["MoTa"]) + " của nhân viên: " + Convert.ToString(row["TenNV"]);
                            try
                            {
                                // Thêm giá trị vào DataTable của DataGridView
                                butToanTableAdapter.Insert(NgayLapBT, Noidung, TKNo, TKCo, SoTien, MaKL, SttUNC, SttBL, SttTTNCN, MaTU, SttBH);
                            }
                            catch (System.Exception ex)
                            {
                                MessageBox.Show("CÓ LỖI KHI TẠO BÚT TOÁN MỚI " + ex.Message);
                            }
                        }
                    }
                    if (hasNewData > 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
                    {
                        MessageBox.Show("Đã tạo bút toán cho chi phí bảo hiểm này!");
                    }
                    if (hasNewData == 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
                    {
                        MessageBox.Show("Đã tồn tại hạch toán hoặc không có thông tin về chi phí này!");
                    }
                    this.butToanTableAdapter.Fill(this.butToanDB.ButToan);
                    dtgvButToan.Refresh();
                }
                if (TKCo == "3386")
                {
                    DataTable dtBaoHiemTN = ConnectSQL.Load("SELECT SttBH, BHTNNV, BaoHiemVaCongDoan.MaKL, TenNV FROM BaoHiemVaCongDoan join LuongCN on BaoHiemVaCongDoan.SttLCN = LuongCN.SttLCN join NhanVien on LuongCN.MaNV = NhanVien.MaNV WHERE BaoHiemVaCongDoan.NgayLap = '" + NgayLapCT + "'");
                    int rowCount = 0; // Đặt rowCount bên ngoài vòng lặp
                    int hasNewData = 0;
                    foreach (DataRow row in dtBaoHiemTN.Rows)
                    {
                        SttBH = Convert.ToInt32(row["SttBH"]);
                        SttUNC = null;
                        SttBL = null;
                        SttTTNCN = null;
                        MaTU = null;
                        SoTien = Convert.ToInt32(row["BHTNNV"]);
                        Noidung = "Chi phí bảo hiểm thất nghiệp của nhân viên: " + Convert.ToString(row["TenNV"]);
                        MaKL = Convert.ToString(row["MaKL"]);
                        DataTable dtButToan = ConnectSQL.Load("SELECT * FROM ButToan where SttBH = '" + SttBH + "' AND TKCo = '3386'");
                        rowCount = dtButToan.Rows.Count; // Gán rowCount bằng số dòng trong dtButToan
                        if (rowCount == 0) // Chỉ thêm mới khi không có dòng nào trong dtButToan
                        {
                            hasNewData++;
                            //Noidung = Convert.ToString(row["MoTa"]) + " của nhân viên: " + Convert.ToString(row["TenNV"]);
                            try
                            {
                                // Thêm giá trị vào DataTable của DataGridView
                                butToanTableAdapter.Insert(NgayLapBT, Noidung, TKNo, TKCo, SoTien, MaKL, SttUNC, SttBL, SttTTNCN, MaTU, SttBH);
                            }
                            catch (System.Exception ex)
                            {
                                MessageBox.Show("CÓ LỖI KHI TẠO BÚT TOÁN MỚI " + ex.Message);
                            }
                        }
                    }
                    if (hasNewData > 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
                    {
                        MessageBox.Show("Đã tạo bút toán cho chi phí bảo hiểm này!");
                    }
                    if (hasNewData == 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
                    {
                        MessageBox.Show("Đã tồn tại hạch toán hoặc không có thông tin về chi phí này!");
                    }
                    this.butToanTableAdapter.Fill(this.butToanDB.ButToan);
                    dtgvButToan.Refresh();
                }
            }
            //TÀI KHOẢN CHI PHÍ BÁN HÀNG
            if (TKNo == "641")
            {
                if (TKCo == "3383")
                {
                    DataTable dtBaoHiemXH = ConnectSQL.Load("SELECT SttBH, BHXHDN, BaoHiemVaCongDoan.MaKL, TenNV FROM BaoHiemVaCongDoan join LuongCN on BaoHiemVaCongDoan.SttLCN = LuongCN.SttLCN join NhanVien on LuongCN.MaNV = NhanVien.MaNV WHERE MaPB = 'KD' and MaCV = 'NV' and BaoHiemVaCongDoan.NgayLap = '" + NgayLapCT + "'");
                    int rowCount = 0; // Đặt rowCount bên ngoài vòng lặp
                    int hasNewData = 0;
                    foreach (DataRow row in dtBaoHiemXH.Rows)
                    {
                        SttBH = Convert.ToInt32(row["SttBH"]);
                        SttUNC = null;
                        SttBL = null;
                        SttTTNCN = null;
                        MaTU = null;
                        SoTien = Convert.ToInt32(row["BHXHDN"]);
                        Noidung = "Chi phí bảo hiểm xã hội công ty trả cho nhân viên: " + Convert.ToString(row["TenNV"]);
                        MaKL = Convert.ToString(row["MaKL"]);
                        DataTable dtButToan = ConnectSQL.Load("SELECT * FROM ButToan where SttBH = '" + SttBH + "' AND TKCo = '3383'");
                        rowCount = dtButToan.Rows.Count; // Gán rowCount bằng số dòng trong dtButToan
                        if (rowCount == 0) // Chỉ thêm mới khi không có dòng nào trong dtButToan
                        {
                            hasNewData++;
                            //Noidung = Convert.ToString(row["MoTa"]) + " của nhân viên: " + Convert.ToString(row["TenNV"]);
                            try
                            {
                                // Thêm giá trị vào DataTable của DataGridView
                                butToanTableAdapter.Insert(NgayLapBT, Noidung, TKNo, TKCo, SoTien, MaKL, SttUNC, SttBL, SttTTNCN, MaTU, SttBH);
                            }
                            catch (System.Exception ex)
                            {
                                MessageBox.Show("CÓ LỖI KHI TẠO BÚT TOÁN MỚI " + ex.Message);
                            }
                        }
                    }
                    if (hasNewData > 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
                    {
                        MessageBox.Show("Đã tạo bút toán cho chi phí bảo hiểm này!");
                    }
                    if (hasNewData == 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
                    {
                        MessageBox.Show("Đã tồn tại hạch toán hoặc không có thông tin về chi phí này!");
                    }
                    this.butToanTableAdapter.Fill(this.butToanDB.ButToan);
                    dtgvButToan.Refresh();
                }
                if (TKCo == "3384")
                {
                    DataTable dtBaoHiemYT = ConnectSQL.Load("SELECT SttBH, BHYTDN, BaoHiemVaCongDoan.MaKL, TenNV FROM BaoHiemVaCongDoan join LuongCN on BaoHiemVaCongDoan.SttLCN = LuongCN.SttLCN join NhanVien on LuongCN.MaNV = NhanVien.MaNV WHERE MaPB = 'KD' and MaCV = 'NV' and BaoHiemVaCongDoan.NgayLap = '" + NgayLapCT + "'");
                    int rowCount = 0; // Đặt rowCount bên ngoài vòng lặp
                    int hasNewData = 0;
                    foreach (DataRow row in dtBaoHiemYT.Rows)
                    {
                        SttBH = Convert.ToInt32(row["SttBH"]);
                        SttUNC = null;
                        SttBL = null;
                        SttTTNCN = null;
                        MaTU = null;
                        SoTien = Convert.ToInt32(row["BHYTDN"]);
                        Noidung = "Chi phí bảo hiểm y tế công ty trả cho nhân viên: " + Convert.ToString(row["TenNV"]);
                        MaKL = Convert.ToString(row["MaKL"]);
                        DataTable dtButToan = ConnectSQL.Load("SELECT * FROM ButToan where SttBH = '" + SttBH + "' AND TKCo = '3384'");
                        rowCount = dtButToan.Rows.Count; // Gán rowCount bằng số dòng trong dtButToan
                        if (rowCount == 0) // Chỉ thêm mới khi không có dòng nào trong dtButToan
                        {
                            hasNewData++;
                            //Noidung = Convert.ToString(row["MoTa"]) + " của nhân viên: " + Convert.ToString(row["TenNV"]);
                            try
                            {
                                // Thêm giá trị vào DataTable của DataGridView
                                butToanTableAdapter.Insert(NgayLapBT, Noidung, TKNo, TKCo, SoTien, MaKL, SttUNC, SttBL, SttTTNCN, MaTU, SttBH);
                            }
                            catch (System.Exception ex)
                            {
                                MessageBox.Show("CÓ LỖI KHI TẠO BÚT TOÁN MỚI " + ex.Message);
                            }
                        }
                    }
                    if (hasNewData > 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
                    {
                        MessageBox.Show("Đã tạo bút toán cho chi phí bảo hiểm này!");
                    }
                    if (hasNewData == 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
                    {
                        MessageBox.Show("Đã tồn tại hạch toán hoặc không có thông tin về chi phí này!");
                    }
                    this.butToanTableAdapter.Fill(this.butToanDB.ButToan);
                    dtgvButToan.Refresh();
                }
                if (TKCo == "3386")
                {
                    DataTable dtBaoHiemTN = ConnectSQL.Load("SELECT SttBH, BHTNDN, BaoHiemVaCongDoan.MaKL, TenNV FROM BaoHiemVaCongDoan join LuongCN on BaoHiemVaCongDoan.SttLCN = LuongCN.SttLCN join NhanVien on LuongCN.MaNV = NhanVien.MaNV WHERE MaPB = 'KD' and MaCV = 'NV' and BaoHiemVaCongDoan.NgayLap = '" + NgayLapCT + "'");
                    int rowCount = 0; // Đặt rowCount bên ngoài vòng lặp
                    int hasNewData = 0;
                    foreach (DataRow row in dtBaoHiemTN.Rows)
                    {
                        SttBH = Convert.ToInt32(row["SttBH"]);
                        SttUNC = null;
                        SttBL = null;
                        SttTTNCN = null;
                        MaTU = null;
                        SoTien = Convert.ToInt32(row["BHTNDN"]);
                        Noidung = "Chi phí bảo hiểm thất nghiệp công ty trả cho nhân viên: " + Convert.ToString(row["TenNV"]);
                        MaKL = Convert.ToString(row["MaKL"]);
                        DataTable dtButToan = ConnectSQL.Load("SELECT * FROM ButToan where SttBH = '" + SttBH + "' AND TKCo = '3386'");
                        rowCount = dtButToan.Rows.Count; // Gán rowCount bằng số dòng trong dtButToan
                        if (rowCount == 0) // Chỉ thêm mới khi không có dòng nào trong dtButToan
                        {
                            hasNewData++;
                            //Noidung = Convert.ToString(row["MoTa"]) + " của nhân viên: " + Convert.ToString(row["TenNV"]);
                            try
                            {
                                // Thêm giá trị vào DataTable của DataGridView
                                butToanTableAdapter.Insert(NgayLapBT, Noidung, TKNo, TKCo, SoTien, MaKL, SttUNC, SttBL, SttTTNCN, MaTU, SttBH);
                            }
                            catch (System.Exception ex)
                            {
                                MessageBox.Show("CÓ LỖI KHI TẠO BÚT TOÁN MỚI " + ex.Message);
                            }
                        }
                    }
                    if (hasNewData > 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
                    {
                        MessageBox.Show("Đã tạo bút toán cho chi phí bảo hiểm này!");
                    }
                    if (hasNewData == 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
                    {
                        MessageBox.Show("Đã tồn tại hạch toán hoặc không có thông tin về chi phí này!");
                    }
                    this.butToanTableAdapter.Fill(this.butToanDB.ButToan);
                    dtgvButToan.Refresh();
                }
                if (TKCo == "3382")
                {
                    DataTable dtBaoHiemTN = ConnectSQL.Load("SELECT SttBH, KinhPhiCD, BaoHiemVaCongDoan.MaKL, TenNV FROM BaoHiemVaCongDoan join LuongCN on BaoHiemVaCongDoan.SttLCN = LuongCN.SttLCN join NhanVien on LuongCN.MaNV = NhanVien.MaNV WHERE MaPB = 'KD' and MaCV = 'NV' and BaoHiemVaCongDoan.NgayLap = '" + NgayLapCT + "'");
                    int rowCount = 0; // Đặt rowCount bên ngoài vòng lặp
                    int hasNewData = 0;
                    foreach (DataRow row in dtBaoHiemTN.Rows)
                    {
                        SttBH = Convert.ToInt32(row["SttBH"]);
                        SttUNC = null;
                        SttBL = null;
                        SttTTNCN = null;
                        MaTU = null;
                        SoTien = Convert.ToInt32(row["KinhPhiCD"]);
                        Noidung = "Kinh phí công đoàn cho nhân viên: " + Convert.ToString(row["TenNV"]);
                        MaKL = Convert.ToString(row["MaKL"]);
                        DataTable dtButToan = ConnectSQL.Load("SELECT * FROM ButToan where SttBH = '" + SttBH + "' AND TKCo = '3382'");
                        rowCount = dtButToan.Rows.Count; // Gán rowCount bằng số dòng trong dtButToan
                        if (rowCount == 0) // Chỉ thêm mới khi không có dòng nào trong dtButToan
                        {
                            hasNewData++;
                            //Noidung = Convert.ToString(row["MoTa"]) + " của nhân viên: " + Convert.ToString(row["TenNV"]);
                            try
                            {
                                // Thêm giá trị vào DataTable của DataGridView
                                butToanTableAdapter.Insert(NgayLapBT, Noidung, TKNo, TKCo, SoTien, MaKL, SttUNC, SttBL, SttTTNCN, MaTU, SttBH);
                            }
                            catch (System.Exception ex)
                            {
                                MessageBox.Show("CÓ LỖI KHI TẠO BÚT TOÁN MỚI " + ex.Message);
                            }
                        }
                    }
                    if (hasNewData > 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
                    {
                        MessageBox.Show("Đã tạo bút toán cho chi phí bảo hiểm này!");
                    }
                    if (hasNewData == 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
                    {
                        MessageBox.Show("Đã tồn tại hạch toán hoặc không có thông tin về chi phí này!");
                    }
                    this.butToanTableAdapter.Fill(this.butToanDB.ButToan);
                    dtgvButToan.Refresh();
                }
                //TÀI KHOẢN CHI PHÍ QUẢN LÝ DOANH NGHIỆP
                if (TKNo == "642")
                {
                    if (TKCo == "3383")
                    {
                        DataTable dtBaoHiemXH = ConnectSQL.Load("SELECT SttBH, BHXHDN, BaoHiemVaCongDoan.MaKL, TenNV FROM BaoHiemVaCongDoan join LuongCN on BaoHiemVaCongDoan.SttLCN = LuongCN.SttLCN join NhanVien on LuongCN.MaNV = NhanVien.MaNV WHERE (MaPB = 'BGD' or MaCV = 'TP' or MaCV = 'PP') and BaoHiemVaCongDoan.NgayLap = '" + NgayLapCT + "'");
                        int rowCount = 0; // Đặt rowCount bên ngoài vòng lặp
                        int hasNewData = 0;
                        foreach (DataRow row in dtBaoHiemXH.Rows)
                        {
                            SttBH = Convert.ToInt32(row["SttBH"]);
                            SttUNC = null;
                            SttBL = null;
                            SttTTNCN = null;
                            MaTU = null;
                            SoTien = Convert.ToInt32(row["BHXHDN"]);
                            Noidung = "Chi phí bảo hiểm xã hội công ty trả cho nhân viên: " + Convert.ToString(row["TenNV"]);
                            MaKL = Convert.ToString(row["MaKL"]);
                            DataTable dtButToan = ConnectSQL.Load("SELECT * FROM ButToan where SttBH = '" + SttBH + "' AND TKCo = '3383'");
                            rowCount = dtButToan.Rows.Count; // Gán rowCount bằng số dòng trong dtButToan
                            if (rowCount == 0) // Chỉ thêm mới khi không có dòng nào trong dtButToan
                            {
                                hasNewData++;
                                //Noidung = Convert.ToString(row["MoTa"]) + " của nhân viên: " + Convert.ToString(row["TenNV"]);
                                try
                                {
                                    // Thêm giá trị vào DataTable của DataGridView
                                    butToanTableAdapter.Insert(NgayLapBT, Noidung, TKNo, TKCo, SoTien, MaKL, SttUNC, SttBL, SttTTNCN, MaTU, SttBH);
                                }
                                catch (System.Exception ex)
                                {
                                    MessageBox.Show("CÓ LỖI KHI TẠO BÚT TOÁN MỚI " + ex.Message);
                                }
                            }
                        }
                        if (hasNewData > 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
                        {
                            MessageBox.Show("Đã tạo bút toán cho chi phí bảo hiểm này!");
                        }
                        if (hasNewData == 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
                        {
                            MessageBox.Show("Đã tồn tại hạch toán hoặc không có thông tin về chi phí này!");
                        }
                        this.butToanTableAdapter.Fill(this.butToanDB.ButToan);
                        dtgvButToan.Refresh();
                    }
                    if (TKCo == "3384")
                    {
                        DataTable dtBaoHiemYT = ConnectSQL.Load("SELECT SttBH, BHYTDN, BaoHiemVaCongDoan.MaKL, TenNV FROM BaoHiemVaCongDoan join LuongCN on BaoHiemVaCongDoan.SttLCN = LuongCN.SttLCN join NhanVien on LuongCN.MaNV = NhanVien.MaNV WHERE (MaPB = 'BGD' or MaCV = 'TP' or MaCV = 'PP') and BaoHiemVaCongDoan.NgayLap = '" + NgayLapCT + "'");
                        int rowCount = 0; // Đặt rowCount bên ngoài vòng lặp
                        int hasNewData = 0;
                        foreach (DataRow row in dtBaoHiemYT.Rows)
                        {
                            SttBH = Convert.ToInt32(row["SttBH"]);
                            SttUNC = null;
                            SttBL = null;
                            SttTTNCN = null;
                            MaTU = null;
                            SoTien = Convert.ToInt32(row["BHYTDN"]);
                            Noidung = "Chi phí bảo hiểm y tế công ty trả cho nhân viên: " + Convert.ToString(row["TenNV"]);
                            MaKL = Convert.ToString(row["MaKL"]);
                            DataTable dtButToan = ConnectSQL.Load("SELECT * FROM ButToan where SttBH = '" + SttBH + "' AND TKCo = '3384'");
                            rowCount = dtButToan.Rows.Count; // Gán rowCount bằng số dòng trong dtButToan
                            if (rowCount == 0) // Chỉ thêm mới khi không có dòng nào trong dtButToan
                            {
                                hasNewData++;
                                //Noidung = Convert.ToString(row["MoTa"]) + " của nhân viên: " + Convert.ToString(row["TenNV"]);
                                try
                                {
                                    // Thêm giá trị vào DataTable của DataGridView
                                    butToanTableAdapter.Insert(NgayLapBT, Noidung, TKNo, TKCo, SoTien, MaKL, SttUNC, SttBL, SttTTNCN, MaTU, SttBH);
                                }
                                catch (System.Exception ex)
                                {
                                    MessageBox.Show("CÓ LỖI KHI TẠO BÚT TOÁN MỚI " + ex.Message);
                                }
                            }
                        }
                        if (hasNewData > 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
                        {
                            MessageBox.Show("Đã tạo bút toán cho chi phí bảo hiểm này!");
                        }
                        if (hasNewData == 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
                        {
                            MessageBox.Show("Đã tồn tại hạch toán hoặc không có thông tin về chi phí này!");
                        }
                        this.butToanTableAdapter.Fill(this.butToanDB.ButToan);
                        dtgvButToan.Refresh();
                    }
                    if (TKCo == "3386")
                    {
                        DataTable dtBaoHiemTN = ConnectSQL.Load("SELECT SttBH, BHTNDN, BaoHiemVaCongDoan.MaKL, TenNV FROM BaoHiemVaCongDoan join LuongCN on BaoHiemVaCongDoan.SttLCN = LuongCN.SttLCN join NhanVien on LuongCN.MaNV = NhanVien.MaNV WHERE (MaPB = 'BGD' or MaCV = 'TP' or MaCV = 'PP') and BaoHiemVaCongDoan.NgayLap = '" + NgayLapCT + "'");
                        int rowCount = 0; // Đặt rowCount bên ngoài vòng lặp
                        int hasNewData = 0;
                        foreach (DataRow row in dtBaoHiemTN.Rows)
                        {
                            SttBH = Convert.ToInt32(row["SttBH"]);
                            SttUNC = null;
                            SttBL = null;
                            SttTTNCN = null;
                            MaTU = null;
                            SoTien = Convert.ToInt32(row["BHTNDN"]);
                            Noidung = "Chi phí bảo hiểm thất nghiệp công ty trả cho nhân viên: " + Convert.ToString(row["TenNV"]);
                            MaKL = Convert.ToString(row["MaKL"]);
                            DataTable dtButToan = ConnectSQL.Load("SELECT * FROM ButToan where SttBH = '" + SttBH + "' AND TKCo = '3386'");
                            rowCount = dtButToan.Rows.Count; // Gán rowCount bằng số dòng trong dtButToan
                            if (rowCount == 0) // Chỉ thêm mới khi không có dòng nào trong dtButToan
                            {
                                hasNewData++;
                                //Noidung = Convert.ToString(row["MoTa"]) + " của nhân viên: " + Convert.ToString(row["TenNV"]);
                                try
                                {
                                    // Thêm giá trị vào DataTable của DataGridView
                                    butToanTableAdapter.Insert(NgayLapBT, Noidung, TKNo, TKCo, SoTien, MaKL, SttUNC, SttBL, SttTTNCN, MaTU, SttBH);
                                }
                                catch (System.Exception ex)
                                {
                                    MessageBox.Show("CÓ LỖI KHI TẠO BÚT TOÁN MỚI " + ex.Message);
                                }
                            }
                        }
                        if (hasNewData > 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
                        {
                            MessageBox.Show("Đã tạo bút toán cho chi phí bảo hiểm này!");
                        }
                        if (hasNewData == 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
                        {
                            MessageBox.Show("Đã tồn tại hạch toán hoặc không có thông tin về chi phí này!");
                        }
                        this.butToanTableAdapter.Fill(this.butToanDB.ButToan);
                        dtgvButToan.Refresh();
                    }
                    if (TKCo == "3382")
                    {
                        DataTable dtKinhPhiCD = ConnectSQL.Load("SELECT SttBH, KinhPhiCD, BaoHiemVaCongDoan.MaKL, TenNV FROM BaoHiemVaCongDoan join LuongCN on BaoHiemVaCongDoan.SttLCN = LuongCN.SttLCN join NhanVien on LuongCN.MaNV = NhanVien.MaNV WHERE (MaPB = 'BGD' or MaCV = 'TP' or MaCV = 'PP') and BaoHiemVaCongDoan.NgayLap = '" + NgayLapCT + "'");
                        int rowCount = 0; // Đặt rowCount bên ngoài vòng lặp
                        int hasNewData = 0;
                        foreach (DataRow row in dtKinhPhiCD.Rows)
                        {
                            SttBH = Convert.ToInt32(row["SttBH"]);
                            SttUNC = null;
                            SttBL = null;
                            SttTTNCN = null;
                            MaTU = null;
                            SoTien = Convert.ToInt32(row["KinhPhiCD"]);
                            Noidung = "Kinh phí công đoàn cho nhân viên: " + Convert.ToString(row["TenNV"]);
                            MaKL = Convert.ToString(row["MaKL"]);
                            DataTable dtButToan = ConnectSQL.Load("SELECT * FROM ButToan where SttBH = '" + SttBH + "' AND TKCo = '3382'");
                            rowCount = dtButToan.Rows.Count; // Gán rowCount bằng số dòng trong dtButToan
                            if (rowCount == 0) // Chỉ thêm mới khi không có dòng nào trong dtButToan
                            {
                                hasNewData++;
                                //Noidung = Convert.ToString(row["MoTa"]) + " của nhân viên: " + Convert.ToString(row["TenNV"]);
                                try
                                {
                                    // Thêm giá trị vào DataTable của DataGridView
                                    butToanTableAdapter.Insert(NgayLapBT, Noidung, TKNo, TKCo, SoTien, MaKL, SttUNC, SttBL, SttTTNCN, MaTU, SttBH);
                                }
                                catch (System.Exception ex)
                                {
                                    MessageBox.Show("CÓ LỖI KHI TẠO BÚT TOÁN MỚI " + ex.Message);
                                }
                            }
                        }
                        if (hasNewData > 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
                        {
                            MessageBox.Show("Đã tạo bút toán cho chi phí bảo hiểm này!");
                        }
                        if (hasNewData == 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
                        {
                            MessageBox.Show("Đã tồn tại hạch toán hoặc không có thông tin về chi phí này!");
                        }
                        this.butToanTableAdapter.Fill(this.butToanDB.ButToan);
                        dtgvButToan.Refresh();
                    }
                }
                //TÀI KHOẢN CHI PHÍ SẢN XUẤT CHUNG
                if (TKNo == "627")
                {
                    if (TKCo == "3383")
                    {
                        DataTable dtBaoHiemXH = ConnectSQL.Load("SELECT SttBH, BHXHDN, BaoHiemVaCongDoan.MaKL, TenNV FROM BaoHiemVaCongDoan join LuongCN on BaoHiemVaCongDoan.SttLCN = LuongCN.SttLCN join NhanVien on LuongCN.MaNV = NhanVien.MaNV WHERE (MaPB = 'IT' or MaPB = 'KH' or MaPB = 'KT' or MaPB = 'NS' or MaPB = 'TC') and MaCV = 'NV' and BaoHiemVaCongDoan.NgayLap = '" + NgayLapCT + "'");
                        int rowCount = 0; // Đặt rowCount bên ngoài vòng lặp
                        int hasNewData = 0;
                        foreach (DataRow row in dtBaoHiemXH.Rows)
                        {
                            SttBH = Convert.ToInt32(row["SttBH"]);
                            SttUNC = null;
                            SttBL = null;
                            SttTTNCN = null;
                            MaTU = null;
                            SoTien = Convert.ToInt32(row["BHXHDN"]);
                            Noidung = "Bảo hiểm xã hội của nhân viên: " + Convert.ToString(row["TenNV"]);
                            MaKL = Convert.ToString(row["MaKL"]);
                            DataTable dtButToan = ConnectSQL.Load("SELECT * FROM ButToan where SttBH = '" + SttBH + "' AND TKCo = '3383'");
                            rowCount = dtButToan.Rows.Count; // Gán rowCount bằng số dòng trong dtButToan
                            if (rowCount == 0) // Chỉ thêm mới khi không có dòng nào trong dtButToan
                            {
                                hasNewData++;
                                //Noidung = Convert.ToString(row["MoTa"]) + " của nhân viên: " + Convert.ToString(row["TenNV"]);
                                try
                                {
                                    // Thêm giá trị vào DataTable của DataGridView
                                    butToanTableAdapter.Insert(NgayLapBT, Noidung, TKNo, TKCo, SoTien, MaKL, SttUNC, SttBL, SttTTNCN, MaTU, SttBH);
                                }
                                catch (System.Exception ex)
                                {
                                    MessageBox.Show("CÓ LỖI KHI TẠO BÚT TOÁN MỚI " + ex.Message);
                                }
                            }
                        }
                        if (hasNewData > 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
                        {
                            MessageBox.Show("Đã tạo bút toán cho chi phí bảo hiểm này!");
                        }
                        if (hasNewData == 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
                        {
                            MessageBox.Show("Đã tồn tại hạch toán hoặc không có thông tin về chi phí này!");
                        }
                        this.butToanTableAdapter.Fill(this.butToanDB.ButToan);
                        dtgvButToan.Refresh();
                    }
                    if (TKCo == "3384")
                    {
                        DataTable dtBaoHiemYT = ConnectSQL.Load("SELECT SttBH, BHYTDN, BaoHiemVaCongDoan.MaKL, TenNV FROM BaoHiemVaCongDoan join LuongCN on BaoHiemVaCongDoan.SttLCN = LuongCN.SttLCN join NhanVien on LuongCN.MaNV = NhanVien.MaNV WHERE (MaPB = 'IT' or MaPB = 'KH' or MaPB = 'KT' or MaPB = 'NS' or MaPB = 'TC') and MaCV = 'NV' and BaoHiemVaCongDoan.NgayLap = '" + NgayLapCT + "'");
                        int rowCount = 0; // Đặt rowCount bên ngoài vòng lặp
                        int hasNewData = 0;
                        foreach (DataRow row in dtBaoHiemYT.Rows)
                        {
                            SttBH = Convert.ToInt32(row["SttBH"]);
                            SttUNC = null;
                            SttBL = null;
                            SttTTNCN = null;
                            MaTU = null;
                            SoTien = Convert.ToInt32(row["BHYTDN"]);
                            Noidung = "Chi phí bảo hiểm y tế công ty trả cho nhân viên: " + Convert.ToString(row["TenNV"]);
                            MaKL = Convert.ToString(row["MaKL"]);
                            DataTable dtButToan = ConnectSQL.Load("SELECT * FROM ButToan where SttBH = '" + SttBH + "' AND TKCo = '3384'");
                            rowCount = dtButToan.Rows.Count; // Gán rowCount bằng số dòng trong dtButToan
                            if (rowCount == 0) // Chỉ thêm mới khi không có dòng nào trong dtButToan
                            {
                                hasNewData++;
                                //Noidung = Convert.ToString(row["MoTa"]) + " của nhân viên: " + Convert.ToString(row["TenNV"]);
                                try
                                {
                                    // Thêm giá trị vào DataTable của DataGridView
                                    butToanTableAdapter.Insert(NgayLapBT, Noidung, TKNo, TKCo, SoTien, MaKL, SttUNC, SttBL, SttTTNCN, MaTU, SttBH);
                                }
                                catch (System.Exception ex)
                                {
                                    MessageBox.Show("CÓ LỖI KHI TẠO BÚT TOÁN MỚI " + ex.Message);
                                }
                            }
                        }
                        if (hasNewData > 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
                        {
                            MessageBox.Show("Đã tạo bút toán cho chi phí bảo hiểm này!");
                        }
                        if (hasNewData == 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
                        {
                            MessageBox.Show("Đã tồn tại hạch toán hoặc không có thông tin về chi phí này!");
                        }
                        this.butToanTableAdapter.Fill(this.butToanDB.ButToan);
                        dtgvButToan.Refresh();
                    }
                    if (TKCo == "3386")
                    {
                        DataTable dtBaoHiemTN = ConnectSQL.Load("SELECT SttBH, BHTNDN, BaoHiemVaCongDoan.MaKL, TenNV FROM BaoHiemVaCongDoan join LuongCN on BaoHiemVaCongDoan.SttLCN = LuongCN.SttLCN join NhanVien on LuongCN.MaNV = NhanVien.MaNV WHERE (MaPB = 'IT' or MaPB = 'KH' or MaPB = 'KT' or MaPB = 'NS' or MaPB = 'TC') and MaCV = 'NV' and BaoHiemVaCongDoan.NgayLap = '" + NgayLapCT + "'");
                        int rowCount = 0; // Đặt rowCount bên ngoài vòng lặp
                        int hasNewData = 0;
                        foreach (DataRow row in dtBaoHiemTN.Rows)
                        {
                            SttBH = Convert.ToInt32(row["SttBH"]);
                            SttUNC = null;
                            SttBL = null;
                            SttTTNCN = null;
                            MaTU = null;
                            SoTien = Convert.ToInt32(row["BHTNDN"]);
                            Noidung = "Chi phí bảo hiểm thất nghiệp công ty trả cho nhân viên: " + Convert.ToString(row["TenNV"]);
                            MaKL = Convert.ToString(row["MaKL"]);
                            DataTable dtButToan = ConnectSQL.Load("SELECT * FROM ButToan where SttBH = '" + SttBH + "' AND TKCo = '3386'");
                            rowCount = dtButToan.Rows.Count; // Gán rowCount bằng số dòng trong dtButToan
                            if (rowCount == 0) // Chỉ thêm mới khi không có dòng nào trong dtButToan
                            {
                                hasNewData++;
                                //Noidung = Convert.ToString(row["MoTa"]) + " của nhân viên: " + Convert.ToString(row["TenNV"]);
                                try
                                {
                                    // Thêm giá trị vào DataTable của DataGridView
                                    butToanTableAdapter.Insert(NgayLapBT, Noidung, TKNo, TKCo, SoTien, MaKL, SttUNC, SttBL, SttTTNCN, MaTU, SttBH);
                                }
                                catch (System.Exception ex)
                                {
                                    MessageBox.Show("CÓ LỖI KHI TẠO BÚT TOÁN MỚI " + ex.Message);
                                }
                            }
                        }
                        if (hasNewData > 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
                        {
                            MessageBox.Show("Đã tạo bút toán cho chi phí bảo hiểm này!");
                        }
                        if (hasNewData == 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
                        {
                            MessageBox.Show("Đã tồn tại hạch toán hoặc không có thông tin về chi phí này!");
                        }
                        this.butToanTableAdapter.Fill(this.butToanDB.ButToan);
                        dtgvButToan.Refresh();
                    }
                    if (TKCo == "3382")
                    {
                        DataTable dtBaoHiemTN = ConnectSQL.Load("SELECT SttBH, KinhPhiCD, BaoHiemVaCongDoan.MaKL, TenNV FROM BaoHiemVaCongDoan join LuongCN on BaoHiemVaCongDoan.SttLCN = LuongCN.SttLCN join NhanVien on LuongCN.MaNV = NhanVien.MaNV WHERE (MaPB = 'IT' or MaPB = 'KH' or MaPB = 'KT' or MaPB = 'NS' or MaPB = 'TC') and MaCV = 'NV' and BaoHiemVaCongDoan.NgayLap = '" + NgayLapCT + "'");
                        int rowCount = 0; // Đặt rowCount bên ngoài vòng lặp
                        int hasNewData = 0;
                        foreach (DataRow row in dtBaoHiemTN.Rows)
                        {
                            SttBH = Convert.ToInt32(row["SttBH"]);
                            SttUNC = null;
                            SttBL = null;
                            SttTTNCN = null;
                            MaTU = null;
                            SoTien = Convert.ToInt32(row["KinhPhiCD"]);
                            Noidung = "Kinh phí công đoàn cho nhân viên: " + Convert.ToString(row["TenNV"]);
                            MaKL = Convert.ToString(row["MaKL"]);
                            DataTable dtButToan = ConnectSQL.Load("SELECT * FROM ButToan where SttBH = '" + SttBH + "' AND TKCo = '3382'");
                            rowCount = dtButToan.Rows.Count; // Gán rowCount bằng số dòng trong dtButToan
                            if (rowCount == 0) // Chỉ thêm mới khi không có dòng nào trong dtButToan
                            {
                                hasNewData++;
                                //Noidung = Convert.ToString(row["MoTa"]) + " của nhân viên: " + Convert.ToString(row["TenNV"]);
                                try
                                {
                                    // Thêm giá trị vào DataTable của DataGridView
                                    butToanTableAdapter.Insert(NgayLapBT, Noidung, TKNo, TKCo, SoTien, MaKL, SttUNC, SttBL, SttTTNCN, MaTU, SttBH);
                                }
                                catch (System.Exception ex)
                                {
                                    MessageBox.Show("CÓ LỖI KHI TẠO BÚT TOÁN MỚI " + ex.Message);
                                }
                            }
                        }
                        if (hasNewData > 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
                        {
                            MessageBox.Show("Đã tạo bút toán cho chi phí bảo hiểm này!");
                        }
                        if (hasNewData == 0) // Chỉ hiển thị MessageBox nếu có ít nhất một dòng mới được thêm vào
                        {
                            MessageBox.Show("Đã tồn tại hạch toán hoặc không có thông tin về chi phí này!");
                        }
                        this.butToanTableAdapter.Fill(this.butToanDB.ButToan);
                        dtgvButToan.Refresh();
                    }
                }
            }
        }

        private void btnXemLCN_Click(object sender, EventArgs e)
        {
            int thanglap = cbThang.SelectedIndex + 1;
            string namlap = cbNam.SelectedItem.ToString();
            DataTable dtBT = new DataTable();
            dtBT = ConnectSQL.Load("SELECT * FROM ButToan WHERE MONTH(NgayLap) = '" + thanglap.ToString() + "' and YEAR(NgayLap) = '" + namlap + "'");
            dtgvButToan.DataSource = dtBT;
            this.butToanTableAdapter.Fill(this.butToanDB.ButToan);
        }
    }
}
