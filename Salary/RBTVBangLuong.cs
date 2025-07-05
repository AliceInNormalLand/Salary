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
    public partial class RBTVBangLuong : Form
    {
        public RBTVBangLuong()
        {
            InitializeComponent();
        }
        static string SttLCN = "";
        private void RBTVBangLuong_Load(object sender, EventArgs e)
        {
            try
            {
                this.baoHiemVaCongDoanTableAdapter.Fill(this.bHvaCD2DB.BaoHiemVaCongDoan, Convert.ToInt32(SttLCN));
            }
            catch (System.Exception) { }
            // TODO: This line of code loads data into the '_1G108HVBL_KhoTPNKDSCTPN.CHITIETPN' table. You can move, or remove it, as needed.
            try
            {
                this.thueTNCNTableAdapter.Fill(this.thueTNCN2DB.ThueTNCN, Convert.ToInt32(SttLCN));
            }
            catch (System.Exception) { }
            // TODO: This line of code loads data into the '_1G108HVBL_KhoTPNKDSTK.TONKHO' table. You can move, or remove it, as needed.
            try
            {

                this.bangLuongTableAdapter.Fill(this.bangLuong2DB.BangLuong, Convert.ToInt32(SttLCN));
            }
            catch (System.Exception) { }
            MessageBox.Show("Bạn muốn xóa bảng lương cá nhân số: " + SttLCN + ". Tuy nhiên bảng lương cá nhân này còn ràng buộc toàn vẹn cần phải xử lý trước khi xóa.");
        }
        public RBTVBangLuong(string SttLCN1)
        {
            InitializeComponent();
            SttLCN = SttLCN1; //lấy mã tp từ tham số xuống
        }

        private void btnXoaThue_Click(object sender, EventArgs e)
        {
            //B1: HỎI XÁC NHẬN
            DialogResult ch = MessageBox.Show("Xóa tất cả chứng từ thuế có liên quan đến bảng lương cá nhân có số thứ tự:" + SttLCN + " đúng không(Y/N)?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);//Hỏi xác nhận
                                                                                                                                                                        //B2: XÓA nếu NSD Yes  [Nên Try...catch...: tránh phát sinh lỗi dừng đột ngột chương trình
            if (ch == DialogResult.Yes)
            {
                try
                {
                    thueTNCNTableAdapter.Delete(Convert.ToInt32(SttLCN));
                    MessageBox.Show("Xóa xong !");
                }
                catch (System.Exception ex) { MessageBox.Show("Có lỗi =" + ex.Message); }
            }//if(Yes)
            try
            {
                this.thueTNCNTableAdapter.Fill(this.thueTNCN2DB.ThueTNCN, Convert.ToInt32(SttLCN));
            }
            catch (System.Exception) { }

        }

        private void btnXoaBHCD_Click(object sender, EventArgs e)
        {
            //B1: HỎI XÁC NHẬN
            DialogResult ch = MessageBox.Show("Xóa tất cả thông tin chi phí bảo hiểm và công đoàn có liên quan đến bảng lương cá nhân có số thứ tự:" + SttLCN + " đúng không(Y/N)?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);//Hỏi xác nhận
                                                                                                                                                                        //B2: XÓA nếu NSD Yes  [Nên Try...catch...: tránh phát sinh lỗi dừng đột ngột chương trình
            if (ch == DialogResult.Yes)
            {
                try
                {
                    baoHiemVaCongDoanTableAdapter.Delete(Convert.ToInt32(SttLCN));
                    MessageBox.Show("Xóa xong !");
                }
                catch (System.Exception ex) { MessageBox.Show("Có lỗi =" + ex.Message); }
            }//if(Yes)
             //B3: TẢI DL SAU KHI XÓA LÊN DATAGRIDVIEWCTNV
            try
            {
                this.baoHiemVaCongDoanTableAdapter.Fill(this.bHvaCD2DB.BaoHiemVaCongDoan, Convert.ToInt32(SttLCN));
            }
            catch (System.Exception) { }
        }

        private void btnXoaBangLuong_Click(object sender, EventArgs e)
        {
            //B1: HỎI XÁC NHẬN
            DialogResult ch = MessageBox.Show("Xóa tất cả thông tin của bảng lương có liên quan đến bảng lương cá nhân có số thứ tự:" + SttLCN + " đúng không(Y/N)?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);//Hỏi xác nhận
                                                                                                                                                                        //B2: XÓA nếu NSD Yes  [Nên Try...catch...: tránh phát sinh lỗi dừng đột ngột chương trình
            if (ch == DialogResult.Yes)
            {
                try
                {
                    bangLuongTableAdapter.Delete(Convert.ToInt32(SttLCN));
                    MessageBox.Show("Xóa xong !");
                }
                catch (System.Exception ex) { MessageBox.Show("Có lỗi =" + ex.Message); }
            }//if(Yes)
            try
            {
                this.bangLuongTableAdapter.Fill(this.bangLuong2DB.BangLuong, Convert.ToInt32(SttLCN));
            }
            catch (System.Exception) { }


        }
    }
}
