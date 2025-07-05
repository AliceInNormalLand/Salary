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
    public partial class ChitietNPT : Form
    {
        public ChitietNPT()
        {
            InitializeComponent();
        }
        public void SetData2(string MaNVduocchon)
        {
            txtmnvnpt.Text = MaNVduocchon;
            // Cập nhật các TextBox và các control khác tương ứng với các giá trị truyền vào
        }

        /// <summary>
        /// SỬA
        /// </summary>
        /// <param name="num"></param>
        /// <param name="code"></param>
        /// <param name="name"></param>
        /// <param name="sex"></param>
        /// <param name="birth"></param>
        /// <param name="idnum"></param>
        /// <param name="phone"></param>
        /// <param name="mail"></param>
        /// <param name="idtax"></param>
        /// <param name="position"></param>
        /// <param name="department"></param>
        /// <param name="union"></param>
        /// <param name="condition"></param>
        /// <param name="startdate"></param>
        public void SetData3(string ngaylapnpt, string manpt, string tennpt, string ngaysinh, string gioitinh, string sdt, string moiquanhe, string SoCMNDNPT, string MaNVduocchon)
        {
            dptngaylap.Text = ngaylapnpt;
            txtmanpt.Text = manpt;
            txthvtnpt.Text = tennpt;
            dtpnpt.Text = ngaysinh;
            txtgtnpt.Text = gioitinh;
            txtsdtnpt.Text = sdt;
            txtmqhnpt.Text = moiquanhe;
            txtcccdnpt.Text = SoCMNDNPT;
            txtmnvnpt.Text = MaNVduocchon;
            // Cập nhật các TextBox và các control khác tương ứng với các giá trị truyền vào
        }
        public string MaNPT { get; set; }
        public string NgayLapNPT { get; set; }
        public string TenNPT { get; set; }
        public string GioiTinhNPT { get; set; }
        public string NgaySinhNPT { get; set; }
        public string MoiQuanHe { get; set; }
        public string SoCMNDNPT { get; set; }
        public string SDTNPT { get; set; }
        public string MaNVDuocChon { get; set; }


        private void ThemNPT2_Click(object sender, EventArgs e)
        {
            //Num = txtsttnpt.Text;
            NgayLapNPT = dptngaylap.Text;
            MaNPT = txtmanpt.Text;
            TenNPT = txthvtnpt.Text;
            GioiTinhNPT = txtgtnpt.Text;
            NgaySinhNPT = dtpnpt.Text;
            MoiQuanHe = txtmqhnpt.Text;
            SoCMNDNPT = txtcccdnpt.Text;
            SDTNPT = txtsdtnpt.Text;
            MaNVDuocChon = txtmnvnpt.Text;
            this.Close();
        }

        /// <summary>
        /// SỬA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SuaNPT2_Click(object sender, EventArgs e)
        {
            //Num = txtsttnpt.Text;
            NgayLapNPT = dptngaylap.Text;
            MaNPT = txtmanpt.Text;
            TenNPT = txthvtnpt.Text;
            NgaySinhNPT = dtpnpt.Text;
            GioiTinhNPT = txtgtnpt.Text;
            SDTNPT = txtsdtnpt.Text;
            MoiQuanHe = txtmqhnpt.Text;
            SoCMNDNPT = txtcccdnpt.Text;
            MaNVDuocChon = txtmnvnpt.Text;
            this.Close();
        }

        private void ChitietNPT_Load(object sender, EventArgs e)
        {

        }
    }
}
