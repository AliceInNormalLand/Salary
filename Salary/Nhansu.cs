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
    public partial class Nhansu : Form
    {
        public Nhansu()
        {
            InitializeComponent();
            // Đặt StartPosition của Form thành CenterScreen
            this.StartPosition = FormStartPosition.CenterScreen;

            // Đặt AutoSize của Form thành true
            //this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.groupBox1.Anchor = AnchorStyles.None; // Để giữ nguyên vị trí giữa
            this.groupBox2.Anchor = AnchorStyles.None; // Để giữ nguyên vị trí giữa
            //this.txtMK.Anchor = AnchorStyles.None; // Để giữ nguyên vị trí giữa
            //this.label2.Anchor = AnchorStyles.None; // Để giữ nguyên vị trí giữa
            //this.label3.Anchor = AnchorStyles.None; // Để giữ nguyên vị trí giữa
            //this.BtnDangnhap.Anchor = AnchorStyles.None; // Để giữ nguyên vị trí giữa
        }

        private void Nhansu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nguoiPhuThuocDB.NguoiPhuThuoc' table. You can move, or remove it, as needed.
            this.nguoiPhuThuocTableAdapter.Fill(this.nguoiPhuThuocDB.NguoiPhuThuoc);
            // TODO: This line of code loads data into the 'nhanVienDB.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.nhanVienDB.NhanVien);
            DataTable  dtNhanVien = new DataTable();
            dtNhanVien = ConnectSQL.Load("SELECT * FROM NhanVien");
            dtgvNV.DataSource = dtNhanVien;
            if (dtgvNV.Rows.Count > 0)
            {
                var row = this.dtgvNV.Rows[0];
                DataNguoiPhuThuoc(row.Cells[1].Value.ToString());
            }
            else
            {
                DataNguoiPhuThuoc("");
            } 
        }
        //Để hiện ra bảng
        private void DataNguoiPhuThuoc(string MaNV)
        {
            DataTable dtNguoiPhuThuoc = new DataTable();
            dtNguoiPhuThuoc = ConnectSQL.Load("SELECT * FROM NguoiPhuThuoc WHERE MaNV = '" + MaNV + "'");
            dtgvNPT.DataSource = dtNguoiPhuThuoc;
        }
        //
        //private string selectedCodeEmployee;
        public string ChonMaNV;
        public string STT1;
        public string TenNV1;
        public string GioiTinh1;
        public string NgaySinh1;
        public string ChucVu1;
        public string PhongBan1;
        public string SoCMND1;
        public string SDT1;
        public string Mail1;
        public string MaSoThue1;
        public string TinhTrang1;
        public string NgayVaoLam1;
        public bool CongDoan1;
        //NPT
        public string STT2;
        public string NgayLap2;
        public string ChonMaNPT;
        public string TenNPT;
        public string GioiTinh2;
        public string NgaySinh2;
        public string SoCMND2;
        public string SDT2;
        public string MoiQuanHe2;
        //
        private void dtgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvNV.Rows[e.RowIndex];
                //Try try try
                ChonMaNV = row.Cells[1].Value.ToString();
                //Code1 = row.Cells[1].Value.ToString();
                DataNguoiPhuThuoc(ChonMaNV);
                //DataDependents(row.Cells[1].Value.ToString());
                DataDelete(ChonMaNV);
                STT1 = row.Cells[0].Value.ToString();
                TenNV1 = row.Cells[2].Value.ToString();
                GioiTinh1 = row.Cells[3].Value.ToString();
                NgaySinh1 = row.Cells[4].Value.ToString();
                SoCMND1 = row.Cells[5].Value.ToString();
                SDT1 = row.Cells[6].Value.ToString();
                Mail1 = row.Cells[7].Value.ToString();
                MaSoThue1 = row.Cells[8].Value.ToString();
                ChucVu1 = row.Cells[9].Value.ToString();
                PhongBan1 = row.Cells[10].Value.ToString();
                CongDoan1 = Convert.ToBoolean(row.Cells[11].Value);
                TinhTrang1 = row.Cells[12].Value.ToString();
                NgayVaoLam1 = row.Cells[13].Value.ToString();
            }
        }
        /// <summary>
        /// SỬA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgvNPT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvNPT.Rows[e.RowIndex];
                //Try try try
                ChonMaNPT = row.Cells[2].Value.ToString();
                //Code1 = row.Cells[1].Value.ToString();
                //DataDependents(selectedCodeDependents);
                //DataDependents(row.Cells[1].Value.ToString());
                DataDelete(ChonMaNPT);
                STT2 = row.Cells[0].Value.ToString();
                NgayLap2 = row.Cells[1].Value.ToString();
                TenNPT = row.Cells[3].Value.ToString();
                NgaySinh2 = row.Cells[4].Value.ToString();
                GioiTinh2 = row.Cells[5].Value.ToString();
                SDT2 = row.Cells[6].Value.ToString();
                MoiQuanHe2 = row.Cells[7].Value.ToString();
                SoCMND2 = row.Cells[8].Value.ToString();
                ChonMaNV = row.Cells[9].Value.ToString();
            }
        }
        private void ThemNV_Click(object sender, EventArgs e)
        {
            ChitietNS fr = new ChitietNS();
            fr.SuaNS2.Visible = false;
            fr.ThemNS2.DialogResult = DialogResult.OK;
            fr.ShowDialog();
            if (fr.DialogResult == DialogResult.OK)
            {
                // Lấy dữ liệu từ Form 2
                string ChonMaNV = fr.MaNV;
                string TenNV1 = fr.TenNV;
                string GioiTinh1 = fr.GioiTinh;
                string NgaySinh1 = fr.NgaySinh;
                string SoCMND1 = fr.SoCMND;
                string SDT1 = fr.SDT;
                string Mail = fr.Mail;
                string MaSoThue1 = fr.MaSoThue;
                string ChucVu1 = fr.ChucVu;
                string PhongBan1 = fr.PhongBan;
                bool CongDoan1 = fr.CongDoan;
                string TinhTrang1 = fr.TinhTrang;
                string NgayVaoLam1 = fr.NgayVaoLam;
                //DateTime StartDate = DateTime.Parse(fr.StartDate);
                //DateTime Birth = DateTime.Parse(fr.Birth);
                try
                {
                    //@Code_Employee,@Name,@Sex,@DateOfBirth,@IDno,@PhoneNum,@Email,@TaxIDNum,@CodePo,@CodeDe,@Union,@Condition,@EnteringDate
                    nhanVienTableAdapter.Insert(ChonMaNV, TenNV1, GioiTinh1, NgaySinh1, SoCMND1, SDT1, Mail, MaSoThue1, ChucVu1, PhongBan1, CongDoan1, TinhTrang1, NgayVaoLam1);
                    MessageBox.Show("Thêm xong, mời xem!");
                }
                catch (System.Exception ex) { MessageBox.Show("CÓ LỖI KHI THÊM NHÂN VIÊN MỚI " + ex.Message); }
                try
                {
                    //employeeDB.Employee.AcceptChanges(); 
                    this.nhanVienTableAdapter.Fill(this.nhanVienDB.NhanVien);
                }
                catch (System.Exception) { }
                //DataTable dtNhanVien = new DataTable();
                //dtNhanVien = ConnectSQL.Load("SELECT * FROM NhanVien");
                //dtgvNV.DataSource = dtNhanVien;
            }
        }
        private void SuaNV_Click(object sender, EventArgs e)
        {
            ChitietNS fr = new ChitietNS();
            fr.ThemNS2.Visible = false;
            fr.SetData(ChonMaNV, TenNV1, GioiTinh1, NgaySinh1, SoCMND1, SDT1, Mail1, MaSoThue1, ChucVu1, PhongBan1, CongDoan1, TinhTrang1, NgayVaoLam1);
            fr.SuaNS2.DialogResult = DialogResult.OK;
            fr.txtmnv.Enabled = false;
            fr.ShowDialog();
            if (fr.DialogResult == DialogResult.OK)
            {
                // Lấy dữ liệu từ Form 2
                string TenNV1 = fr.TenNV;
                string GioiTinh1 = fr.GioiTinh;
                string NgaySinh1 = fr.NgaySinh;
                string SoCMND1 = fr.SoCMND;
                string SDT1 = fr.SDT;
                string Mail = fr.Mail;
                string MaSoThue1 = fr.MaSoThue;
                string ChucVu1 = fr.ChucVu;
                string PhongBan1 = fr.PhongBan;
                bool CongDoan1 = fr.CongDoan;
                string TinhTrang1 = fr.TinhTrang;
                string NgayVaoLam1 = fr.NgayVaoLam;
                try
                {
                    // Gọi phương thức Update với các giá trị mới
                    nhanVienTableAdapter.Update(TenNV1, GioiTinh1, NgaySinh1, SoCMND1, SDT1, Mail, MaSoThue1, ChucVu1, PhongBan1, CongDoan1, TinhTrang1, NgayVaoLam1, ChonMaNV);
                    MessageBox.Show("Cập nhật thành công!");
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("CÓ LỖI KHI CẬP NHẬT NHÂN SỰ: " + ex.Message);
                }
                try
                {
                    this.nhanVienTableAdapter.Fill(this.nhanVienDB.NhanVien);
                }
                catch (System.Exception) { }
            }
        }

        //fr.SetDataNPT(selectedCodeEmployee);
        //fr.SuaNPT2.Enabled = false;
        //fr.txtsttnpt.Enabled = false;
        

        //DataTable dtDependents = new DataTable();
        //dtDependents = ConnectSQL.Load("SELECT * FROM Dependents WHERE Code_Employee = '" + selectedCodeEmployee + "'");
        //dtgvNPT.DataSource = dtDependents;

        //DataTable dtDependents = new DataTable();
        //dtDependents = ConnectSQL.Load("SELECT * FROM Dependents");
        //dtgvNPT.DataSource = dtDependents;


        //try
        //try
        //{
        //    //employeeDB.Employee.AcceptChanges(); 
        //    this.employeeTableAdapter.Fill(this.employeeDB.Employee);
        //}
        //catch (System.Exception) { }
        //if (dtgvNV.Rows.Count > 0)
        //{
        //    var row = this.dtgvNV.Rows[0];
        //    DataDependents(row.Cells[1].Value.ToString());
        //}
        //else
        //{
        //    DataDependents("");
        //}

        /// <summary>
        /// SỬA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
                

        private void DataDelete(string MaNV)
        {
            DataTable dtDelete = new DataTable();
            dtDelete = ConnectSQL.Load("SELECT * FROM NhanVien WHERE MaNV = '" + MaNV + "'");
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            DataDelete(ChonMaNV);
            //B1: Hỏi xác nhận 
            DialogResult ch = MessageBox.Show("Bạn muốn xóa nhân viên :" + ChonMaNV + " không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //B2: XÓA
            if (ch == DialogResult.Yes)
            {
                try
                {
                    nhanVienTableAdapter.Delete(ChonMaNV);
                    MessageBox.Show("Đã xóa!");
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("CÓ LỖI XÓA NHÂN SỰ: " + ex.Message);
                }
            }
            //B3: Tải BD lên DataGridView sau khi xóa
            try
            {
                this.nhanVienTableAdapter.Fill(this.nhanVienDB.NhanVien);
            }
            catch (System.Exception) { } 
        }

        
        private void ThemNPT_Click_1(object sender, EventArgs e)
        {
            ChitietNPT fr = new ChitietNPT();
            fr.SuaNPT2.Visible = false;
            //fr.txtmanpt.Enabled = false;
            fr.SetData2(ChonMaNV);
            fr.ThemNPT2.DialogResult = DialogResult.OK;
            fr.ShowDialog();
            if (fr.DialogResult == DialogResult.OK)
            {
                // Kiểm tra dữ liệu trước khi thêm vào cơ sở dữ liệu
                if (string.IsNullOrWhiteSpace(fr.NgayLapNPT) || string.IsNullOrWhiteSpace(fr.MaNPT) || string.IsNullOrWhiteSpace(fr.TenNPT))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin người phụ thuộc.");
                    return; // Ngăn chặn việc thêm khi thiếu thông tin
                }
                // Lấy dữ liệu từ Form 2
                string Ngaylap = fr.NgayLapNPT;
                string Manpt = fr.MaNPT;
                string Tennpt = fr.TenNPT;
                string Ngaysinhnpt = fr.NgaySinhNPT;
                string Gioitinhnpt = fr.GioiTinhNPT;
                string Sdtnpt = fr.SDTNPT;
                string Moiquanhenpt = fr.MoiQuanHe;
                string Socmndnpt = fr.SoCMNDNPT;
                string Manvduocchon = fr.MaNVDuocChon;
                try
                {
                    //@Code_Employee,@Name,@Sex,@DateOfBirth,@IDno,@PhoneNum,@Email,@TaxIDNum,@CodePo,@CodeDe,@Union,@Condition,@EnteringDate
                    nguoiPhuThuocTableAdapter.Insert(Ngaylap, Manpt, Tennpt, Ngaysinhnpt, Gioitinhnpt, Sdtnpt, Moiquanhenpt, Socmndnpt, Manvduocchon);
                    MessageBox.Show("Thêm xong, mời xem!");
                }
                catch (System.Exception ex) { MessageBox.Show("CÓ LỖI KHI THÊM NGƯỜI PHỤ THUỘC MỚI " + ex.Message); }
                try
                {
                    //employeeDB.Employee.AcceptChanges(); 
                    this.nguoiPhuThuocTableAdapter.Fill(this.nguoiPhuThuocDB.NguoiPhuThuoc);
                }
                catch (System.Exception) { }
            }
        }

        private void XoaNPT_Click(object sender, EventArgs e)
        {
            DataDelete(ChonMaNPT);
            //B1: Hỏi xác nhận 
            DialogResult ch = MessageBox.Show("Bạn muốn xóa người phụ thuộc: " + TenNPT + " không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //B2: XÓA
            if (ch == DialogResult.Yes)
            {
                try
                {
                    nguoiPhuThuocTableAdapter.Delete(ChonMaNPT);
                    MessageBox.Show("Đã xóa!");
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("CÓ LỖI XÓA NGƯỜI PHỤ THUỘC: " + ex.Message);
                }
            }
            //B3: Tải BD lên DataGridView sau khi xóa
            try
            {
                this.nguoiPhuThuocTableAdapter.Fill(this.nguoiPhuThuocDB.NguoiPhuThuoc);
                DataNguoiPhuThuoc(ChonMaNV);
            }
            catch (System.Exception) { } //bat moi he thong = tranh truong hop ctr bi dung  dot ngot
        }

        private void SuaNPT_Click_1(object sender, EventArgs e)
        {
            ChitietNPT fr = new ChitietNPT();
            fr.ThemNPT2.Visible = false;
            fr.SetData3(NgayLap2, ChonMaNPT, TenNPT, NgaySinh2, GioiTinh2, SDT2, MoiQuanHe2, SoCMND2, ChonMaNV);
            fr.SuaNPT2.DialogResult = DialogResult.OK;
            fr.txtmanpt.Enabled = false;
            fr.ShowDialog();
            if (fr.DialogResult == DialogResult.OK)
            {
                // Lấy dữ liệu từ Form 2
                string Ngaylapnpt = fr.NgayLapNPT;
                string Manpt = fr.MaNPT;
                string Tennpt = fr.TenNPT;
                string Ngaysinhnpt = fr.NgaySinhNPT;
                string Gioitinhnpt = fr.GioiTinhNPT;
                string Sodienthoainpt = fr.SDTNPT;
                string Moiquanhe = fr.MoiQuanHe;
                string SoCMNDnpt = fr.SoCMNDNPT;
                string MaNVduocchon = fr.MaNVDuocChon;
                try
                {
                    // Gọi phương thức Update với các giá trị mới
                    nguoiPhuThuocTableAdapter.Update(Ngaylapnpt, Manpt, Tennpt, Ngaysinhnpt, Gioitinhnpt, Sodienthoainpt, Moiquanhe, SoCMNDnpt, MaNVduocchon);
                    MessageBox.Show("Cập nhật thành công!");
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("CÓ LỖI KHI CẬP NHẬT NGƯỜI PHỤ THUỘC: " + ex.Message);
                }
                try
                {
                    //employeeDB.Employee.AcceptChanges();
                    this.nguoiPhuThuocTableAdapter.Fill(this.nguoiPhuThuocDB.NguoiPhuThuoc);
                    DataNguoiPhuThuoc(ChonMaNV);
                }
                catch (System.Exception) { }

                //DataTable dtDependents = new DataTable();
                //dtDependents = ConnectSQL.Load("SELECT * FROM Dependents");
                //dtgvNPT.DataSource = dtDependents;
            }
        }
    }
}

