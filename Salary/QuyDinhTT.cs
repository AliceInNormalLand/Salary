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
    public partial class QuyDinhTT : Form
    {
        public QuyDinhTT()
        {
            InitializeComponent();
        }

        private void QuyDinhTT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quyDinhTTDB.QuyDinhTT' table. You can move, or remove it, as needed.
            this.quyDinhTTTableAdapter.Fill(this.quyDinhTTDB.QuyDinhTT);

        }
    }
}
