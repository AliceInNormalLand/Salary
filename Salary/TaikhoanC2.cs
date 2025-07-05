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
    public partial class TaikhoanC2 : Form
    {
        public TaikhoanC2()
        {
            InitializeComponent();
        }

        private void TaikhoanC2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hTTKC2DB.HeThongTKC2' table. You can move, or remove it, as needed.
            this.heThongTKC2TableAdapter.Fill(this.hTTKC2DB.HeThongTKC2);
            // TODO: This line of code loads data into the 'dMTKC2DB.DanhMucTKC2' table. You can move, or remove it, as needed.
            this.danhMucTKC2TableAdapter.Fill(this.dMTKC2DB.DanhMucTKC2);

        }

        private void ThemBangLuong_Click(object sender, EventArgs e)
        {
            //int thanglap = cbThangHTTK2.SelectedIndex + 1;
            //string namlap = cbNamHTTK2.SelectedItem.ToString();
            string STK = CbSTK2.SelectedValue.ToString().Trim();
            //string SDDK = tbSDDK.ToString().Trim();
            int SDDK = int.Parse(tbSDDK.Text);
            //string ngaylap = dtpNgaylapBL.Text.Trim();
            DateTime ngaydk = dtpNDK2.Value;
            DataTable dtData = ConnectSQL.Load(@"
            SELECT TinhChat
            FROM DanhMucTKC2
            WHERE MaTKC2 = '" + STK + "'");
            foreach (DataRow row in dtData.Rows)
            {
                string tinhchat = Convert.ToString(row["TinhChat"]);
                int DuDauKy = SDDK;
                int? DuNo = tinhchat == "Dư nợ" ? (int?)Convert.ToInt32(SDDK) : null;
                int? DuCo = tinhchat == "Dư có" ? (int?)Convert.ToInt32(SDDK) : null;
                try
                {
                    // Thêm giá trị vào DataTable của DataGridView
                    heThongTKC2TableAdapter.Insert(ngaydk, STK, DuDauKy, DuNo, DuCo);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("CÓ LỖI KHI TẠO DANH SÁCH BẢNG LƯƠNG MỚI " + ex.Message);
                }
            }
            // Hiển thị DataTable mới trên DataGridView
            this.heThongTKC2TableAdapter.Fill(this.hTTKC2DB.HeThongTKC2);
            MessageBox.Show("Thêm xong, mời xem!");
        }
    }
}
