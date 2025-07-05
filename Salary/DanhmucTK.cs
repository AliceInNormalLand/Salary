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
    public partial class DanhmucTK : Form
    {
        public DanhmucTK()
        {
            InitializeComponent();

        }

        private void DanhmucTK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vwTKC1vaTKC2DB.vwTK1vaTK2' table. You can move, or remove it, as needed.
            this.vwTK1vaTK2TableAdapter.Fill(this.vwTKC1vaTKC2DB.vwTK1vaTK2);
        }
    }
}
