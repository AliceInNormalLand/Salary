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
    public partial class TaikhoanC1 : Form
    {
        public TaikhoanC1()
        {
            InitializeComponent();
        }

        private void TaikhoanC1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hTTKC1DB.HeThongTKC1' table. You can move, or remove it, as needed.
            this.heThongTKC1TableAdapter.Fill(this.hTTKC1DB.HeThongTKC1);
            // TODO: This line of code loads data into the 'dMTKC1DB.DanhMucTKC1' table. You can move, or remove it, as needed.
            this.danhMucTKC1TableAdapter.Fill(this.dMTKC1DB.DanhMucTKC1);
        }

        private void ThemBangLuong_Click(object sender, EventArgs e)
        {
            string STK = CbTKC1.SelectedValue.ToString().Trim();
            //string SDDK = tbSDDK.ToString().Trim();
            int SDDK = int.Parse(tbSDDK.Text);
            //string ngaylap = dtpNgaylapBL.Text.Trim();
            DateTime ngaydk = dtpNDK1.Value;
            DataTable dtData = ConnectSQL.Load(@"
            SELECT TinhChat
            FROM DanhMucTKC1
            WHERE MaTKC1 = '" + STK + "'");
            foreach (DataRow row in dtData.Rows)
            {
                string tinhchat = Convert.ToString(row["TinhChat"]);
                int DuDauKy = SDDK;
                int? DuNo = tinhchat == "Dư nợ" ? (int?)Convert.ToInt32(SDDK) : null;
                int? DuCo = tinhchat == "Dư có" ? (int?)Convert.ToInt32(SDDK) : null;
                try
                {
                    // Thêm giá trị vào DataTable của DataGridView
                    heThongTKC1TableAdapter.Insert(ngaydk, STK, DuDauKy, DuNo, DuCo);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("CÓ LỖI KHI TẠO DANH SÁCH BẢNG LƯƠNG MỚI " + ex.Message);
                }
            }
            // Hiển thị DataTable mới trên DataGridView
            this.heThongTKC1TableAdapter.Fill(this.hTTKC1DB.HeThongTKC1);
            MessageBox.Show("Thêm xong, mời xem!");
        }
    }
}
