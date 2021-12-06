using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe.UserControl
{
    public partial class UC_ThuNhap : Form
    {
        public UC_ThuNhap()
        {
            InitializeComponent();
        }

        public Form1 frm;
        public delegate void _deDongTab();
        public _deDongTab dongTab;

        private void UC_Thunhap_Load(object sender, EventArgs e)
        {

        }

        

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            dongTab();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
