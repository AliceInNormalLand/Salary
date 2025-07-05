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
    public partial class LuongCS : Form
    {
        public LuongCS()
        {
            InitializeComponent();
        }
        // khai báo một bảng chứ thông tin của CompanyExpenses
        //DataTable dtCompanyExpenses;

        private void LuongCS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'luongCSDB.LuongCS' table. You can move, or remove it, as needed.
            this.luongCSTableAdapter.Fill(this.luongCSDB.LuongCS);
        }
        //private void ChiphiDN_Load(object sender, EventArgs e)
        //{
        //    
        //    // Khi chạy màn lên form này thì sẽ truyền vào dữ liệu cho bảng vừa được khai báo ở trên  dtCompanyExpenses
        //    dtCompanyExpenses = new DataTable();
        //    // gán cho  dtCompanyExpenses bằng giá trị của bảng với câu select đc truyền vào
        //    dtCompanyExpenses = ConnectSQL.table("SELECT * FROM CompanyExpenses"); 
        //    // truyền vào gridview
        //    dtgvCPDN.DataSource = dtCompanyExpenses;
        //    if (dtgvCPDN.Rows.Count > 0)
        //    {
        //        // lấy ra đc id của dòng đầu tiên của bảng CompanyExpenses
        //        string id  = dtCompanyExpenses.Rows[0][0].ToString();
        //        // truyền vào id để lấy dữ liệu tương ứng từ hàm  DataAccountingExp
        //        DataAccountingExp(id);
        //    }
        //    else
        //    {
        //        DataAccountingExp("0");
        //    }
        //}
        //private void DataAccountingExp(string  IDCompanyExp)
        //{
        //    // tương tự như lấy thông tin ở bảng trên
        //    DataTable dtAccountingExp = new DataTable();
        //    dtAccountingExp = ConnectSQL.table("SELECT * FROM AccountingExp WHERE IDCompanyExp = '"+IDCompanyExp+"' " );
        //    dtgvHTCPDN.DataSource = dtAccountingExp;
        //}

        //private void dtgvCPDN_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    // nếu như gridview trên có giá trị
        //    if (e.RowIndex >= 0)
        //    {
        //        // lấy ra thông tin id tương ứng với dòng đc chọn
        //        string id = dtCompanyExpenses.Rows[e.RowIndex][0].ToString();
        //        // truyền vào id tương ứng để lấy ra dữ liệu bnarg DataAccountingExp
        //        DataAccountingExp(id);
        //    }
        //}
    }
}
