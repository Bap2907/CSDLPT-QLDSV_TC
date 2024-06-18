using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLDSV_TC.views;

namespace QLDSV_TC.views
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {   
            InitializeComponent();
            if (Program.mGroup.Equals("PGV"))
            {
                ribbonQuanLyKhoa_PGV.Visible = true;
                ribbonQuanLyKhoa_PGV.Enabled = true;
                reportPagePGV_Khoa.Visible = true;
                reportPagePGV_Khoa.Enabled = true;
                barBtnTaoLogin.Enabled = true;
                ribbonControl1.SelectedPage = ribbonPageQuanLy;
                btnHocPhi.Enabled = false;
                ribbonSinhVien.Visible = false;
                barDtnReportDongHP.Enabled = false;
            }
            else if ((Program.mGroup.Equals("KHOA")))
            {
                ribbonQuanLyKhoa_PGV.Visible = true;
                ribbonQuanLyKhoa_PGV.Enabled = true;
                reportPagePGV_Khoa.Visible = true;
                reportPagePGV_Khoa.Enabled = true;
                barBtnTaoLogin.Enabled = true;
                ribbonControl1.SelectedPage = ribbonPageQuanLy;
                btnHocPhi.Enabled = false;
                ribbonSinhVien.Visible = false;
                barDtnReportDongHP.Enabled = false;
            }
            else if (Program.mGroup.Equals("SV"))
            {
                ribbonSinhVien.Visible = true;
                ribbonPageBaoCao.Visible = false;
                ribbonPageQuanLy.Visible = false;
                barBtnTaoLogin.Visibility = BarItemVisibility.Never;
                ribbonControl1.SelectedPage = ribbonSinhVien;
            }
            else if (Program.mGroup.Equals("PKT"))
            {

                ribbonQuanLyPKT.Visible = true;
                ribbonQuanLyPKT.Enabled = true;
                ribbonQuanLyKhoa_PGV.Enabled = false;
                reportPagePKT.Visible = true;
                reportPagePKT.Enabled = true;
                barBtnTaoLogin.Enabled = true;
                ribbonSinhVien.Visible = false;
                reportPagePGV_Khoa.Enabled = false;
            }
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnDX_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialog = XtraMessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo!", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                foreach (Form frm in this.MdiChildren)
                    frm.Close();
                Program.frmMain.Dispose();
                Program.Login.Visible = true;
                Program.bdsDSPM.RemoveFilter();
                Program.Login.loadAgain();

            }
        }

        private void barButtonXEMDIEM_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(views.frmXemDiem));
            if (frm != null) frm.Activate();
            else
            {
                frmXemDiem frmxemdiem = new frmXemDiem();
                frmxemdiem.MdiParent = this;
                frmxemdiem.Show();

            }
        }

        private void barButtonDANGKYLTC_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(views.frmDangKyLTC));
            if (frm != null) frm.Activate();
            else
            {
                frmDangKyLTC frmDkLTC = new frmDangKyLTC();
                frmDkLTC.MdiParent = this;
                frmDkLTC.Show();

            }
        }

        private void barButtonMonHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(views.frmMH));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmMH = new frmMH();
                Program.frmMH.MdiParent = this;
                Program.frmMH.WindowState = FormWindowState.Maximized;
                Program.frmMH.Show();

            }
        }

        private void barButtonLTC_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(views.frmLTC));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmLTC = new frmLTC();
                Program.frmLTC.MdiParent = this;
                Program.frmLTC.WindowState = FormWindowState.Maximized;
                Program.frmLTC.Show();

            }
        }

        private void barButtonNhapDiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(views.frmNhapDiem));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmNhapDiem = new frmNhapDiem();
                Program.frmNhapDiem.MdiParent = this;
                Program.frmNhapDiem.WindowState = FormWindowState.Maximized;
                Program.frmNhapDiem.Show();
            }
        }

        private void barButtonClass_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(views.frmClass));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmClass = new frmClass();
                Program.frmClass.MdiParent = this;
                Program.frmClass.WindowState = FormWindowState.Maximized;
                Program.frmClass.Show();
            }
        }

        private void btnDX_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            DialogResult dialog = XtraMessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo!", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                foreach (Form frm in this.MdiChildren)
                    frm.Close();
                Program.frmMain.Dispose();
                Program.Login.Visible = true;
                Program.bdsDSPM.RemoveFilter();
                Program.Login.loadAgain();

            }
        }
    }
}
