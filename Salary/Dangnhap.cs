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

namespace Salary
{
    public partial class Dangnhap : Form
    {
        public string loggedInUser;
        //private string loggedInUser;
        public Dangnhap()
        {
            InitializeComponent();
            // Đặt StartPosition của Form thành CenterScreen
            this.StartPosition = FormStartPosition.CenterScreen;

            // Đặt AutoSize của Form thành true
            //this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            // Đảm bảo các điều khiển bên trong Form không thay đổi vị trí khi Form thay đổi kích thước
            // Ví dụ:
            this.label1.Anchor = AnchorStyles.None; // Để giữ nguyên vị trí giữa
            this.txtTDN.Anchor = AnchorStyles.None; // Để giữ nguyên vị trí giữa
            this.txtMK.Anchor = AnchorStyles.None; // Để giữ nguyên vị trí giữa
            this.label2.Anchor = AnchorStyles.None; // Để giữ nguyên vị trí giữa
            //this.label3.Anchor = AnchorStyles.None; // Để giữ nguyên vị trí giữa
            this.BtnDangnhap.Anchor = AnchorStyles.None; // Để giữ nguyên vị trí giữa

        }
        public static string typeRole;
        private void BtnDangnhap_Click(object sender, EventArgs e)
        {
            string tk = txtTDN.Text;
            string mk = txtMK.Text;
            DataTable dt = new DataTable();
            dt = ConnectSQL.Load("select * from DangNhap where TenDN = '" + tk + "' and MatKhau ='" + mk + "' ");
            if (dt.Rows.Count > 0)
            {
                typeRole = dt.Rows[0][4].ToString();
                loggedInUser = txtTDN.Text;
                Mainform fr = new Mainform();
                fr.SetData(loggedInUser);
                fr.ShowDialog();
                txtTDN.Text = "";
                txtMK.Text = "";
                    //loggedInUser = txtTDN.Text;
                    //this.Close();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu hoặc tên đăng nhập");
            }    
           
        }
        public string GetLoggedInUser()
        {
            return loggedInUser;
        }
        private void Dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void txtTDN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
