using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
//using OfficeOpenXml.Table;
using Excel = Microsoft.Office.Interop.Excel;

namespace Salary
{
    public partial class ChamCong : Form
    {
        public ChamCong()
        {
            InitializeComponent();
        }

        private void ChamCong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chamCongDB.ChamCong' table. You can move, or remove it, as needed.
            //this.chamCongTableAdapter.Fill(this.chamCongDB.ChamCong);
        }


        public string NgayLap;
        public string MaNV;
        public double MotNgay;
        public double NuaNgay;
        public double TongCong;
        public double TongPhep;
        public double PhepToiDa;
        public double TangCaNT;
        public double TangCaNNT;
        public double TangCaNNL;
        public string MaKyLuong;
        int GetValue(string str)
        {
            // base case: empty string
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            // convert the input string to uppercase
            str = str.ToUpper();

            int value = 0;
            foreach (char ch in str)
            {
                value = value * 26 + (ch - 'A' + 1);
            }

            return value;
        }

        private void ImportExcel(string path)
        {
            using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(path)))
            {
                ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[0];
                DataTable dataTable = new DataTable();
                string[] targetColumnValues = { "E", "J", "GO", "GP", "GQ", "GR", "GA", "GB", "GC" };
                // Giả sử e là một tham số trong sự kiện, bạn cần thay thế e bằng tên tham số thực tế của sự kiện
                for (int i = excelWorksheet.Dimension.Start.Row + 7; i <= excelWorksheet.Dimension.End.Row; i++)
                {
                    // Lấy giá trị từ ô ở các cột quan tâm
                    //NgayLap = Convert.ToString(excelWorksheet.Cells[i, 5].Value);
                    // Lấy giá trị từ ô ở cột quan tâm
                    DateTime ngayLapExcel = excelWorksheet.Cells[i, 4].GetValue<DateTime>();
                    // Chuyển đổi ngày thành chuỗi
                    string NgayLap = ngayLapExcel.ToString("yyyy-MM-dd"); // Định dạng có thể thay đổi tùy theo định dạng của SQL datetime
                    MaNV = Convert.ToString(excelWorksheet.Cells[i, GetValue("E")].Value);
                    MotNgay = Convert.ToDouble(excelWorksheet.Cells[i, GetValue("GO")].Value);
                    NuaNgay = Convert.ToDouble(excelWorksheet.Cells[i, GetValue("GP")].Value);
                    TongCong = Convert.ToDouble(excelWorksheet.Cells[i, GetValue("GQ")].Value);
                    TongPhep = Convert.ToDouble(excelWorksheet.Cells[i, GetValue("GR")].Value);
                    PhepToiDa = Convert.ToDouble(excelWorksheet.Cells[i, GetValue("J")].Value);
                    TangCaNT = Convert.ToDouble(excelWorksheet.Cells[i, GetValue("GA")].Value);
                    TangCaNNT = Convert.ToDouble(excelWorksheet.Cells[i, GetValue("GB")].Value);
                    TangCaNNL = Convert.ToDouble(excelWorksheet.Cells[i, GetValue("GC")].Value);
                    MaKyLuong = ngayLapExcel.Month.ToString() + ngayLapExcel.Year.ToString();
                    if (MaNV != null && MaNV != "") {
                        try
                        {
                            // Thêm dữ liệu vào database (đây giả sử chamCongTableAdapter.Insert là hàm thêm dữ liệu)
                            chamCongTableAdapter.Insert(NgayLap, MaNV.Trim(), MotNgay, NuaNgay, TongCong, TongPhep, PhepToiDa, TangCaNT, TangCaNNT, TangCaNNL, MaKyLuong); // Thêm các biến cần thiết
                        }
                        catch (System.Exception ex)
                        {
                            MessageBox.Show("CÓ LỖI KHI IMPORT " + ex.Message);
                        } 
                    }
                    try
                    {
                        // Update lại DataGridView sau khi thêm dữ liệu
                        this.chamCongTableAdapter.Fill(this.chamCongDB.ChamCong);
                    }
                    catch (System.Exception) { }
                }
            }
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Import Excel";
            openFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ImportExcel(openFileDialog.FileName);
                    MessageBox.Show("Nạp file Excel thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nạp file Excel không thành công!\n" + ex.Message);
                }
            }
        }

        private void btnXemLCN_Click(object sender, EventArgs e)
        {
            int thanglap = cbThang.SelectedIndex + 1;
            string namlap = cbNam.SelectedItem.ToString();
            DataTable dtChamCong = new DataTable();
            dtChamCong = ConnectSQL.Load("SELECT * FROM ChamCong WHERE MONTH(NgayLap) = '" + thanglap.ToString() + "' and YEAR(NgayLap) = '" + namlap + "'");
            dataGridViewChamCong.DataSource = dtChamCong;
            this.chamCongTableAdapter.Fill(this.chamCongDB.ChamCong);
        }
    }
}
