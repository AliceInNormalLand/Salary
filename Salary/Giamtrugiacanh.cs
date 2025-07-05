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
    public partial class Giamtrugiacanh : Form
    {
        public Giamtrugiacanh()
        {
            InitializeComponent();
        }

        private void Giamtrugiacanh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'giamTruGiaCanhDB.GiamTruGiaCanh' table. You can move, or remove it, as needed.
            this.giamTruGiaCanhTableAdapter.Fill(this.giamTruGiaCanhDB.GiamTruGiaCanh);

        }

        private void ThemGTGC_Click(object sender, EventArgs e)
        {

        }

        private void ThemGTGC_Click_1(object sender, EventArgs e)
        {
            string NgayLap = dtpGTGC.Text;
            string MaNV = txtbNV.Text;
            string MaGTGC = txtbMaGTGC.Text;
            //DateTime StartDate = DateTime.Parse(fr.StartDate);
            //DateTime Birth = DateTime.Parse(fr.Birth);
            try
            {
                //@Code_Employee,@Name,@Sex,@DateOfBirth,@IDno,@PhoneNum,@Email,@TaxIDNum,@CodePo,@CodeDe,@Union,@Condition,@EnteringDate
                giamTruGiaCanhTableAdapter.Insert(NgayLap, MaGTGC, MaNV);
                MessageBox.Show("Thêm xong, mời xem!");
            }
            catch (System.Exception ex) { MessageBox.Show("CÓ LỖI KHI THÊM THÔNG TIN GIẢM TRỪ GIA CẢNH MỚI " + ex.Message); }
            try
            {
                //employeeDB.Employee.AcceptChanges(); 
                this.giamTruGiaCanhTableAdapter.Fill(this.giamTruGiaCanhDB.GiamTruGiaCanh);
            }
            catch (System.Exception) { }
        }

        //private void ThemGTGC_Click(object sender, EventArgs e)
        //{
        //    ChitietGTGC fr = new ChitietGTGC();
        //    fr.SuaGTGC2.Enabled = false;
        //    fr.ShowDialog();
        //}

        //private void SuaGTGC_Click(object sender, EventArgs e)
        //{
        //    ChitietGTGC fr = new ChitietGTGC();
        //    fr.SuaGTGC2.Enabled = false;
        //    fr.ShowDialog();
        //}
    }
}
