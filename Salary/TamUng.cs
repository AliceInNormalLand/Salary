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
    public partial class TamUng : Form
    {
        public TamUng()
        {
            InitializeComponent();
        }

        private void TamUng_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tamUngDB.TamUng' table. You can move, or remove it, as needed.
            this.tamUngTableAdapter.Fill(this.tamUngDB.TamUng);
        }

        public string MaTU;
        private void ThemTU_Click_1(object sender, EventArgs e)
        {
            ChitietTU fr = new ChitietTU();
            fr.ThemTU2.DialogResult = DialogResult.OK;
            fr.ShowDialog();
            if (fr.DialogResult == DialogResult.OK)
            {
                // Lấy dữ liệu từ Form 2
                DateTime Ngaylap = fr.ngaylap;
                int thang = Ngaylap.Month;
                int nam = Ngaylap.Year;
                string ManTU = fr.matu;
                string MaNV = fr.manv;
                string Noidung = fr.noidung;
                int SoTien = fr.sotien;
                string MaKL = Convert.ToString(thang) + Convert.ToString(nam);
                try
                {
                    //@Code_Employee,@Name,@Sex,@DateOfBirth,@IDno,@PhoneNum,@Email,@TaxIDNum,@CodePo,@CodeDe,@Union,@Condition,@EnteringDate
                    tamUngTableAdapter.Insert(Ngaylap, ManTU, MaNV, Noidung, SoTien, MaKL);
                    MessageBox.Show("Thêm xong, mời xem!");
                }
                catch (System.Exception ex) { MessageBox.Show("CÓ LỖI KHI THÊM NGƯỜI PHỤ THUỘC MỚI " + ex.Message); }
                try
                {
                    //employeeDB.Employee.AcceptChanges(); 
                    this.tamUngTableAdapter.Fill(this.tamUngDB.TamUng);
                }
                catch (System.Exception) { }
            }
        }

        private void XoaTU_Click(object sender, EventArgs e)
        {
            DataDelete(MaTU);
            //B1: Hỏi xác nhận 
            DialogResult ch = MessageBox.Show("Bạn muốn xóa phiếu tạm ứng: " + MaTU + " không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //B2: XÓA
            if (ch == DialogResult.Yes)
            {
                try
                {
                    tamUngTableAdapter.Delete(MaTU);
                    MessageBox.Show("Đã xóa!");
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("CÓ LỖI XÓA PHIẾU TẠM ỨNG: " + ex.Message);
                }
            }
            //B3: Tải BD lên DataGridView sau khi xóa
            try
            {
                this.tamUngTableAdapter.Fill(this.tamUngDB.TamUng);
            }
            catch (System.Exception) { } //bat moi he thong = tranh truong hop ctr bi dung  dot ngot
        }

        private void BtnButToan_Click(object sender, EventArgs e)
        {
            ButToan fr = new ButToan();
            fr.BtnLapBTTU.Visible = !fr.BtnLapBTTU.Visible;
            fr.ShowDialog();
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvTU.Rows[e.RowIndex];
                //Try try try
                MaTU = row.Cells[2].Value.ToString();
            }
        }
        private void DataDelete(string MaTU)
        {
            DataTable dtDelete = new DataTable();
            dtDelete = ConnectSQL.Load("SELECT * FROM TamUng WHERE MaTU = '" + MaTU + "'");
        }
    }
}
