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
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }
        public string Username { get; private set; }
        public string OldPassword { get; private set; }
        public string NewPassword { get; private set; }
        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void BtnDMK_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các trường nhập liệu
            Username = textBoxUsername.Text;
            OldPassword = textBoxOldPassword.Text;
            NewPassword = textBoxNewPassword.Text;

            // Kiểm tra và xác nhận rằng các giá trị đã được nhập (có thể thêm kiểm tra khác nếu cần)
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(OldPassword) || string.IsNullOrEmpty(NewPassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Đánh dấu là form đã được xác nhận (OK)
            DialogResult = DialogResult.OK;

            // Đóng form
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {

        }
    }
}
