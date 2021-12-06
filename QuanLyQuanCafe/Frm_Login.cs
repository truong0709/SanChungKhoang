using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }
        

        private void btn_Dangnhap_Click(object sender, EventArgs e)
        {
            //Form1 frm = new Form1();
            //frm.ShowDialog();
        }

        private void btn_Dangky_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }
    }

}
