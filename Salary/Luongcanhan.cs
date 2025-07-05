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
    public partial class Luongcanhan : Form
    {
        public Luongcanhan()
        {
            InitializeComponent();
            dtgvLCN.CellFormatting += dtgvLCN_CellFormatting_1;
        }

        private void Luongcanhan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toiThieuVungDB.ToiThieuVung' table. You can move, or remove it, as needed.
            this.toiThieuVungTableAdapter.Fill(this.toiThieuVungDB.ToiThieuVung);
            // TODO: This line of code loads data into the 'chamDiemDB.ChamDiem' table. You can move, or remove it, as needed.
            this.chamDiemTableAdapter.Fill(this.chamDiemDB.ChamDiem);
            // TODO: This line of code loads data into the 'luongCNDB.LuongCN' table. You can move, or remove it, as needed.
            //this.luongCNTableAdapter.Fill(this.luongCNDB.LuongCN);
        }

        private void ThemLCN_Click(object sender, EventArgs e)
        {
            int LuongTTV = (int)cbTTV.SelectedValue;
            int thanglap = cbThang.SelectedIndex + 1;
            string namlap = cbNam.SelectedItem.ToString();
            string MaKL = thanglap.ToString() + namlap;
            string ngaylap = dtpNgaylap.Text.Trim();
            DateTime dateTime = dtpNgaylap.Value;
            DataTable dtChamCong = new DataTable();
            dtChamCong = ConnectSQL.Load("SELECT MaNV, SttCC, TongCong, TongPhep, TCNT, TCNNT, TCNNL FROM ChamCong WHERE MONTH(NgayLap) = '" + thanglap.ToString() + "' and YEAR(NgayLap) = '" + namlap + "'");
            foreach (DataRow row in dtChamCong.Rows)
            {
                double TCNT = Convert.ToDouble(row["TCNT"]);
                double TCNNT = Convert.ToDouble(row["TCNNT"]);
                double TCNNL = Convert.ToDouble(row["TCNNL"]);
                string CotMaNV = row["MaNV"].ToString();
                string Ngaylap = ngaylap;
                int SttCC = Convert.ToInt32(row["SttCC"]);
                double NgayCH = Convert.ToDouble("26");
                double NgayCTT = Convert.ToDouble(row["TongCong"]) + Convert.ToDouble(row["TongPhep"]);
                //int ToongDiem = Convert.ToInt32
                DataTable dtHopDong = new DataTable();
                dtHopDong = ConnectSQL.Load("SELECT SttHDLD, LuongCB FROM HopDongLD WHERE MaNV = '" + row["MaNV"].ToString() + "'");
                foreach (DataRow row2 in dtHopDong.Rows)
                {
                    int SttHDLD = Convert.ToInt32(row2["SttHDLD"]);
                    int LuongCB = Convert.ToInt32(row2["LuongCB"]);
                    int LuongCB2 = (int)((int)Math.Max(LuongTTV, LuongCB));
                    DataTable dtChamDiem = new DataTable();
                    dtChamDiem = ConnectSQL.Load("SELECT (9+SUM(ISNULL(Diem, 0))) as 'TongDiem', ChamCong.MaNV FROM ChamDiem RIGHT JOIN ChamCong ON ChamDiem.MaNV = ChamCong.MaNV " +
                    "and month(ChamDiem.NgayLap) = '" + thanglap.ToString() + "' and year(ChamDiem.NgayLap) = '" + namlap + "' WHERE ChamCong.MaNV = '" + row["MaNV"].ToString() + "' " +
                    "AND month(ChamCong.NgayLap) =  '" + thanglap.ToString() + "' and year(ChamCong.NgayLap) = '" + namlap + "' GROUP BY ChamCong.MaNV");
                    foreach (DataRow row3 in dtChamDiem.Rows)
                    {
                        DataTable dtThangDG = new DataTable();
                        dtThangDG = ConnectSQL.Load("SELECT SttTDG, MucTT, MucTD, HeSo FROM ThangDG");
                        //if (row3["TongDiem"] != null)
                        //{
                        int TongDiemXet = Convert.ToInt32(row3["TongDiem"]);
                        foreach (DataRow row4 in dtThangDG.Rows) 
                        {
                            int SttTDG = Convert.ToInt32(row4["SttTDG"]);
                            double HeSo = Convert.ToDouble(row4["HeSo"]);
                            if (TongDiemXet <= Convert.ToInt32(row4["MucTD"]) && TongDiemXet > Convert.ToInt32(row4["MucTT"]))
                            {
                                DataTable dtNhanVien = new DataTable();
                                dtNhanVien = ConnectSQL.Load("SELECT TinhTrang FROM NhanVien where MaNV = '" + row["MaNV"].ToString() + "'");
                                foreach (DataRow row5 in dtNhanVien.Rows)
                                {
                                    if (row5["TinhTrang"].ToString() == "Thử việc")
                                    {
                                        int LuongTheoNC = Convert.ToInt32((((LuongCB2 * 0.85) / NgayCH) * NgayCTT) * HeSo);
                                        int LuongTC = Convert.ToInt32((LuongCB2 * 0.85 / NgayCH / 8) * (TCNT * 1.5 + TCNNT * 2 + TCNNL * 3));
                                        int LuongTCKhongTT = LuongTC - Convert.ToInt32((LuongCB2 * 0.85 / NgayCH / 8) * (TCNT + TCNNT+ TCNNL));
                                        try
                                        {
                                            //@Code_Employee,@Name,@Sex,@DateOfBirth,@IDno,@PhoneNum,@Email,@TaxIDNum,@CodePo,@CodeDe,@Union,@Condition,@EnteringDate
                                            luongCNTableAdapter.Insert(dateTime, CotMaNV, SttHDLD, LuongCB2, SttCC, SttTDG, NgayCH, NgayCTT, LuongTheoNC, LuongTC, LuongTCKhongTT, MaKL);
                                            ////////TRYYYYYYYYYYYYYYYYYYY
                                            //DataTable dtUpdateCD = new DataTable();
                                            //dtUpdateCD = ConnectSQL.Load("SELECT SttCD, SttLCN FROM ChamDiem WHERE MaNV = '" + row["MaNV"].ToString() + "'");
                                            //foreach (DataRow row6 in dtUpdateCD.Rows)
                                            //{
                                            //    int SttCD = Convert.ToInt32(row6["SttCD"]);
                                            //    int SttLCN2 = Convert.ToInt32(row6["SttLCN"]);
                                            //    chamDiemTableAdapter.Update(SttLCN2, SttCD);
                                            //}
                                        }
                                        catch (System.Exception ex) { MessageBox.Show("CÓ LỖI KHI TẠO BẢNG LƯƠNG CÁ NHÂN MỚI " + ex.Message); }
                                    }
                                    else 
                                    {
                                        int LuongTheoNC = Convert.ToInt32(((LuongCB2 / NgayCH) * NgayCTT) * HeSo);
                                        int LuongTC = Convert.ToInt32((LuongCB2 / NgayCH / 8) * (TCNT * 1.5 + TCNNT * 2 + TCNNL * 3));
                                        int LuongTCKhongTT = LuongTC - Convert.ToInt32((LuongCB2 / NgayCH / 8) * (TCNT + TCNNT + TCNNL));
                                        try
                                        {
                                            //@Code_Employee,@Name,@Sex,@DateOfBirth,@IDno,@PhoneNum,@Email,@TaxIDNum,@CodePo,@CodeDe,@Union,@Condition,@EnteringDate
                                            luongCNTableAdapter.Insert(dateTime, CotMaNV, SttHDLD, LuongCB2, SttCC, SttTDG, NgayCH, NgayCTT, LuongTheoNC, LuongTC, LuongTCKhongTT, MaKL);
                                        }
                                        catch (System.Exception ex) { MessageBox.Show("CÓ LỖI KHI TẠO BẢNG LƯƠNG CÁ NHÂN MỚI " + ex.Message); }
                                    }
                                }
                            }
                        }
                    }
                }    
            }
            //this.chamDiemTableAdapter.Fill(this.chamDiemDB.ChamDiem);
            this.luongCNTableAdapter.Fill(this.luongCNDB.LuongCN);
            MessageBox.Show("Thêm xong, mời xem!");
        }

        private void btnXemLCN_Click(object sender, EventArgs e)
        {
            int thanglap = cbThang.SelectedIndex + 1;
            string namlap = cbNam.SelectedItem.ToString();
            DataTable dtLuongCN = new DataTable();
            dtLuongCN = ConnectSQL.Load("SELECT * FROM LuongCN WHERE MONTH(NgayLap) = '" + thanglap.ToString() + "' and YEAR(NgayLap) = '" + namlap + "'");
            dtgvLCN.DataSource = dtLuongCN;
            this.luongCNTableAdapter.Fill(this.luongCNDB.LuongCN);
        }

        private void dtgvLCN_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra xem đang xử lý cột số tiền
            if (dtgvLCN.Columns[e.ColumnIndex].Name == "TongLuong") // Thay "ColumnName" bằng tên cột số tiền của bạn
            {
                if (e.Value != null)
                {
                    // Định dạng giá trị sang chuỗi số tiền
                    int intValue;
                    if (int.TryParse(e.Value.ToString(), out intValue))
                    {
                        e.Value = intValue.ToString("N0");
                        //Console.WriteLine(e.Value);
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        private void btnXoaBangLuong_Click(object sender, EventArgs e)
        {
            //Hỏi xác nhận
            DialogResult ch = MessageBox.Show("Bạn muốn xóa bảng lương cá nhân " + SttLCN.Trim() + " không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //Xóa
            if (ch == DialogResult.Yes)
            {
                try
                {
                    luongCNTableAdapter.Delete(Convert.ToInt32(SttLCN));
                    MessageBox.Show("Đã xóa!");
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Có lỗi XÓA sản phẩm: " + ex.Message);
                    RBTVBangLuong fr = new RBTVBangLuong(SttLCN);
                    fr.ShowDialog();
                }
            }
            try
            {
                // Tai ds cac MH vao DataGridView ben duoi theo Nhom MH da chon trong ComboBox phia tren
                this.luongCNTableAdapter.Fill(this.luongCNDB.LuongCN);
            }
            catch (System.Exception) { } //bat moi he thong = tranh truong hop ctr bi dung  dot ngot
        }
        public string SttLCN;
        private void dtgvLCN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvLCN.Rows[e.RowIndex];
                //Try try try
                SttLCN = row.Cells[0].Value.ToString();
            }
        }
    }
}
