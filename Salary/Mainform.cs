using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Data.SqlClient;

namespace Salary
{
    public partial class Mainform : Form
    {
        private Dangnhap previousLoginForm; // Lưu trữ form đăng nhập cũ
        //private Dangnhap loginForm;
        public Mainform()
        {
            InitializeComponent();
            // Tạo instance của form đăng nhập
            //loginForm = new Dangnhap();
            // Hiển thị form đăng nhập
            //loginForm.ShowDialog();
            //thử
            UpdateLoggedInUser();
        }
        private string connectionString = @"Data Source=ALICEWANG\SQLEXPRESS01;Initial Catalog=HRPayrollDB;Integrated Security=True;MultipleActiveResultSets=True;Connect Timeout=0;Max Pool Size=500;TrustServerCertificate=True;";
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult chon = MessageBox.Show("Đăng xuất (Yes/No)?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);//Hỏi xác nhận if(chon == DialogResult.Yes) //NSD đã chọn Yes 
            if (chon == DialogResult.Yes)
            {
                this.Close(); //Đóng Form này 
            }
        }
        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nhansu fr = new Nhansu();
            fr.ShowDialog();
        }
        private void Mainform_Load(object sender, EventArgs e)
        {
            UpdateLoggedInUser();
        }
        public void SetData(string getlogin)
        {
            lbllogin.Text = getlogin;
        }
        private void UpdateLoggedInUser()
        {
            if (Dangnhap.typeRole == "MemberNS" || Dangnhap.typeRole == "AdminNS")
            {
                DanhmucNS.Visible = true;
            }
            if (Dangnhap.typeRole == "AdminKT" || Dangnhap.typeRole == "MemberKT")
            {
                kẾTOÁNToolStripMenuItem.Visible = true;
                nGHIỆPVỤToolStripMenuItem.Visible = true;
            }
            if (Dangnhap.typeRole == "AdminIT" || Dangnhap.typeRole == "MemberIT")
            {
                DanhmucNS.Visible = true;
                QLTK.Visible = true;
            }
            if (Dangnhap.typeRole == "GD" || Dangnhap.typeRole == "PGD")
            {
                QLTK.Visible = true;
                kẾTOÁNToolStripMenuItem.Visible = true;
                nGHIỆPVỤToolStripMenuItem.Visible = true;
                DanhmucNS.Visible = true;
            }
            if (Dangnhap.typeRole == "Member")
            {
                nGHIỆPVỤToolStripMenuItem.Visible = true;
            }
        }

        private void hợpĐồngLaoĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hopdong fr = new Hopdong();
            fr.ShowDialog();
        }

        private void tàiKhoảnNgânHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TKNH fr = new TKNH();
            fr.ShowDialog();
        }

        private void đăngNhậpTàiKhoảnKhácToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dangnhap fr1 = new Dangnhap();
            // Đóng form hiện tại
            fr1.Show();
            //this.Close();
        }

        private void QLTK_Click(object sender, EventArgs e)
        {
            TaikhoanDN fr = new TaikhoanDN();
            
            fr.ShowDialog();
        }

        private void chứcVụToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Chucvu fr = new Chucvu();
            fr.ShowDialog();
        }

        private void phòngBanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Phongban fr = new Phongban();
            fr.ShowDialog();
        }

        private void giảmTrừGiaCảnhToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Giamtrugiacanh fr = new Giamtrugiacanh();
            fr.ShowDialog();
        }

        private void tínhBảoHiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaohiemvaCongdoan fr = new BaohiemvaCongdoan();
            fr.ShowDialog();
        }

        private void biểuTínhThuếTNCNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuyDinhTT fr = new QuyDinhTT();
            fr.ShowDialog();
        }

        

        private void lươngCơSởToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LuongCS fr = new LuongCS();
            fr.ShowDialog();
        }

        private void lươngTốiThiểuVùngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LuongTTV fr = new LuongTTV();
            fr.ShowDialog();
        }

        private void bảngĐánhGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhGia fr = new DanhGia();
            fr.ShowDialog();
        }

        private void thangĐánhGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThangDG fr = new ThangDG();
            fr.ShowDialog();
        }


        private void tínhThuếTNCNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThueTNCN fr = new ThueTNCN();
            fr.ShowDialog();
        }

        private void tạmỨngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TamUng fr = new TamUng();
            fr.ShowDialog();
        }

        private void lươngCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Luongcanhan fr = new Luongcanhan();
            fr.ShowDialog();
        }

        private void bảngLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bangluong fr = new Bangluong();
            fr.ShowDialog();
        }

        private void chấmCôngToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ChamCong fr = new ChamCong();
            fr.ShowDialog();
        }

        private void chấmĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChamDiem fr = new ChamDiem();
            fr.ShowDialog();
        }

        private void ủyNhiệmChiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UyNhiemChi fr = new UyNhiemChi();
            fr.ShowDialog();
        }


        private void bútToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ButToan fr = new ButToan();
            fr.ShowDialog();
        }


        private void danhMụcTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhmucTK fr = new DanhmucTK();
            fr.ShowDialog();
        }

        private void chiTiếtTKCấp1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChitietTKC1 fr = new ChitietTKC1();
            fr.ShowDialog();
        }

        private void hệThốngTàiKhoảnCấp1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TaikhoanC1 fr = new TaikhoanC1();
            fr.ShowDialog();
        }

        private void chiTiếtTàiKhoảnCấp2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChitietTKC2 fr = new ChitietTKC2();
            fr.ShowDialog();
        }
        private void hệThốngTàiKhoảnCấp2ToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            TaikhoanC2 fr = new TaikhoanC2();
            fr.ShowDialog();
        }

        private void thoátChươngTrìnhToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult chon = MessageBox.Show("Thoát toàn bộ chương trình (Yes/No)?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question); //Hỏi xác nhận 
            if (chon == DialogResult.Yes) //NSD đã chọn Yes 
            {
                Application.Exit(); //Thoát toàn bộ chương trính 
            }

        }
        static bool CheckOldPassword(string username, string oldPassword, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM DangNhap WHERE TenDN = @Username AND MatKhau = @OldPassword";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@OldPassword", oldPassword);

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }

        static bool ChangePassword(string username, string newPassword, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE DangNhap SET MatKhau = @NewPassword WHERE TenDN = @Username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@NewPassword", newPassword);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }
        private void DoiMatKhau()
        {
            // Gọi form đổi mật khẩu và hiển thị nó
            using (var doiMatKhauForm = new DoiMatKhau())
            {
                // Kiểm tra xem form đổi mật khẩu đã được xác nhận (OK) hay chưa
                if (doiMatKhauForm.ShowDialog() == DialogResult.OK)
                {
                    // Lấy thông tin từ form đổi mật khẩu
                    string username = doiMatKhauForm.Username;
                    string oldPassword = doiMatKhauForm.OldPassword;
                    string newPassword = doiMatKhauForm.NewPassword;
                    // Kiểm tra mật khẩu cũ trùng khớp
                    if (!CheckOldPassword(username, oldPassword, connectionString))
                    {
                        MessageBox.Show("Mật khẩu cũ không đúng. Đổi mật khẩu thất bại.");
                        return;
                    }

                    // Kiểm tra mật khẩu mới không giống mật khẩu cũ
                    if (oldPassword == newPassword)
                    {
                        MessageBox.Show("Mật khẩu mới không được giống mật khẩu cũ. Đổi mật khẩu thất bại.");
                        return;
                    }

                    // Thực hiện cập nhật mật khẩu trong cơ sở dữ liệu
                    if (ChangePassword(username, newPassword, connectionString))
                    {
                        MessageBox.Show("Đổi mật khẩu thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu thất bại.");
                    }
                    // Thực hiện xử lý đổi mật khẩu ở đây
                    // ...
                }
            }
        }
        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhau();
            //MessageBox.Show("Đổi mật khẩu thành công!");
        }

        private void dANHMỤCToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
