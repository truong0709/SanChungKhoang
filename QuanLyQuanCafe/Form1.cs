using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DevComponents.DotNetBar;
using QuanLyQuanCafe.UserControl;

namespace QuanLyQuanCafe
{
    public partial class Form1 : Form
    {
        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        //private static extern IntPtr CreateRoundRectRgn
        // (
        //       int nLeftRect,
        //       int nTopRect,
        //       int nRightRect,
        //       int nBottomRect,
        //       int nWidthEllipse,
        //       int nHeightEllipse

        // );


        public Form1()
        {
            InitializeComponent();
            
        }
        private void LoadMenu()
        {
            pnl_Menu_Trangchu.Height = 191;
            pnl_Caidat.Height = 35;
            pnl_Dangxuat.Height = 35;
            timer1.Enabled = true;
            lbl_Time.Text = string.Format("{0:dd-MM-yyyy hh:mm:ss:tt }", DateTime.Now);
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            //Frm_Login frm_Login = new Frm_Login();
            //frm_Login.ShowDialog();
            LoadMenu();

        }

        bool trangThai = false;
        string tieudeTab;

        public Form1 frm;
        public delegate void _deDongTab();


        private bool CheckOpentabs(string name)
        {
            for (int i = 0; i < tabControlTaiChinh.Tabs.Count; i++)
            {
                if (tabControlTaiChinh.Tabs[i].Text == name)
                {
                    tabControlTaiChinh.SelectedTabIndex = i;
                    return true;
                }

            }
            return false;
        }

        private void dongTab()
        {
            foreach (TabItem item in tabControlTaiChinh.Tabs)
            {
                if (item.IsSelected)
                {
                    tabControlTaiChinh.Tabs.Remove(item);
                    return;
                }
            }

        }

        private void tabControlTaiChinh_TabItemClose(object sender, DevComponents.DotNetBar.TabStripActionEventArgs e)
        {
            TabItem t = tabControlTaiChinh.SelectedTab;
            tabControlTaiChinh.Tabs.Remove(t);
        }

        private void btn_Thitruong_Click(object sender, EventArgs e)
        {
            this.trangThai = true;
            this.tieudeTab = "Thị trường";

            if (!CheckOpentabs(tieudeTab))
            {
                TabItem t = tabControlTaiChinh.CreateTab(tieudeTab);
                t.Name = "UC_ThiTruong";

                UC_ThiTruong fThiTruong = new UC_ThiTruong()
                {
                    dongTab = new UC_ThiTruong._deDongTab(dongTab),
                    frm = this,
                    TopLevel = false,
                    Dock = DockStyle.Fill,
                };
                t.AttachedControl.Controls.Add(fThiTruong);
                fThiTruong.Show();

                tabControlTaiChinh.SelectedTabIndex = tabControlTaiChinh.Tabs.Count - 1;
            }
        }


        private void btn_Giaodich_Click(object sender, EventArgs e)
        {
            this.trangThai = true;
            this.tieudeTab = "Giao Dịch";

            if (!CheckOpentabs(tieudeTab))
            {
                TabItem t = tabControlTaiChinh.CreateTab(tieudeTab);
                t.Name = "UC_GiaoDich";

                UC_GiaoDich fGiaoDich = new UC_GiaoDich()
                {
                    dongTab = new UC_GiaoDich._deDongTab(dongTab),
                    frm = this,
                    TopLevel = false,
                    Dock = DockStyle.Fill,
                };
                t.AttachedControl.Controls.Add(fGiaoDich);
                fGiaoDich.Show();

                tabControlTaiChinh.SelectedTabIndex = tabControlTaiChinh.Tabs.Count - 1;
            }
        }

        private void btn_Thunhap_Click(object sender, EventArgs e)
        {
            this.trangThai = true;
            this.tieudeTab = "Thu Nhập";

            if (!CheckOpentabs(tieudeTab))
            {
                TabItem t = tabControlTaiChinh.CreateTab(tieudeTab);
                t.Name = "UC_ThuNhap";

                UC_ThuNhap fThuNhap = new UC_ThuNhap()
                {
                    dongTab = new UC_ThuNhap._deDongTab(dongTab),
                    frm = this,
                    TopLevel = false,
                    Dock = DockStyle.Fill,
                };
                t.AttachedControl.Controls.Add(fThuNhap);
                fThuNhap.Show();

                tabControlTaiChinh.SelectedTabIndex = tabControlTaiChinh.Tabs.Count - 1;
            }
        }

        private void btn_Lienhe_Click(object sender, EventArgs e)
        {
            this.trangThai = true;
            this.tieudeTab = "Liên Hệ";

            if (!CheckOpentabs(tieudeTab))
            {
                TabItem t = tabControlTaiChinh.CreateTab(tieudeTab);
                t.Name = "UC_LienHe";

                UC_LienHe fLienHe = new UC_LienHe()
                {
                    dongTab = new UC_LienHe._deDongTab(dongTab),
                    frm = this,
                    TopLevel = false,
                    Dock = DockStyle.Fill,
                };
                t.AttachedControl.Controls.Add(fLienHe);
                fLienHe.Show();

                tabControlTaiChinh.SelectedTabIndex = tabControlTaiChinh.Tabs.Count - 1;
            }
        }

        private void btn_Baomat_Click(object sender, EventArgs e)
        {
            this.trangThai = true;
            this.tieudeTab = "Bảo Mật";

            if (!CheckOpentabs(tieudeTab))
            {
                TabItem t = tabControlTaiChinh.CreateTab(tieudeTab);
                t.Name = "UC_BaoMat";

                UC_BaoMat fBaoMat = new UC_BaoMat()
                {
                    dongTab = new UC_BaoMat._deDongTab(dongTab),
                    frm = this,
                    TopLevel = false,
                    Dock = DockStyle.Fill,
                };
                t.AttachedControl.Controls.Add(fBaoMat);
                fBaoMat.Show();

                tabControlTaiChinh.SelectedTabIndex = tabControlTaiChinh.Tabs.Count - 1;
            }
        }

        private void btn_Doimatkhau_Click(object sender, EventArgs e)
        {
            this.trangThai = true;
            this.tieudeTab = "Đổi Mật Khẩu";

            if (!CheckOpentabs(tieudeTab))
            {
                TabItem t = tabControlTaiChinh.CreateTab(tieudeTab);
                t.Name = "UC_DoiMatKhau";

                UC_DoiMatKhau fDoiMatKhau = new UC_DoiMatKhau()
                {
                    dongTab = new UC_DoiMatKhau._deDongTab(dongTab),
                    frm = this,
                    TopLevel = false,
                    Dock = DockStyle.Fill,
                };
                t.AttachedControl.Controls.Add(fDoiMatKhau);
                fDoiMatKhau.Show();

                tabControlTaiChinh.SelectedTabIndex = tabControlTaiChinh.Tabs.Count - 1;
            }
        }

        private void btn_Quyenriengtu_Click(object sender, EventArgs e)
        {
            this.trangThai = true;
            this.tieudeTab = "Quyền Riêng Tư";

            if (!CheckOpentabs(tieudeTab))
            {
                TabItem t = tabControlTaiChinh.CreateTab(tieudeTab);
                t.Name = "UC_QuyenRiengTu";

                UC_QuyenRiengTu fQuyenRiengTu = new UC_QuyenRiengTu()
                {
                    dongTab = new UC_QuyenRiengTu._deDongTab(dongTab),
                    frm = this,
                    TopLevel = false,
                    Dock = DockStyle.Fill,
                };
                t.AttachedControl.Controls.Add(fQuyenRiengTu);
                fQuyenRiengTu.Show();

                tabControlTaiChinh.SelectedTabIndex = tabControlTaiChinh.Tabs.Count - 1;
            }
        }

        private void btn_Saoluu_Click(object sender, EventArgs e)
        {

            this.trangThai = true;
            this.tieudeTab = "Sao Lưu Phục Hồi";

            if (!CheckOpentabs(tieudeTab))
            {
                TabItem t = tabControlTaiChinh.CreateTab(tieudeTab);
                t.Name = "UC_SaoLuu";

                UC_SaoLuu fSaoLuu = new UC_SaoLuu()
                {
                    dongTab = new UC_SaoLuu._deDongTab(dongTab),
                    frm = this,
                    TopLevel = false,
                    Dock = DockStyle.Fill,
                };
                t.AttachedControl.Controls.Add(fSaoLuu);
                fSaoLuu.Show();

                tabControlTaiChinh.SelectedTabIndex = tabControlTaiChinh.Tabs.Count - 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Trangchu_Click(object sender, EventArgs e)
        {
            if(pnl_Menu_Trangchu.Height == 191)
            {
                pnl_Menu_Trangchu.Height = 35;
            }else
            {
                pnl_Menu_Trangchu.Height = 191;
                pnl_Caidat.Height = 35;
                pnl_Dangxuat.Height = 35;
                pnl_Menu.Width = 186;

            }
        }

        private void btn_Caidat_Click(object sender, EventArgs e)
        {
            if (pnl_Caidat.Height == 191)
            {
                pnl_Caidat.Height = 35;
            }
            else
            {
                pnl_Menu_Trangchu.Height = 35;
                pnl_Caidat.Height = 191;
                pnl_Dangxuat.Height = 35;
                pnl_Menu.Width = 186;

            }
        }

        private void pcb_Menu_Click(object sender, EventArgs e)
        {
            if(pnl_Menu.Width == 186)
            {
                pnl_Menu.Width = 35;
                pnl_Menu_Trangchu.Height = 35;
                pnl_Caidat.Height = 35;
                pnl_Dangxuat.Height = 35;
            }
            else
            {
                pnl_Menu.Width = 186;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn tắt chương trình 30 tỷ hay không?","Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)== DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Time.Text = string.Format("{0:dd-MM-yyyy hh:mm:ss:tt }", DateTime.Now);
        }

        

        private void btn_Dangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
