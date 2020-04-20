using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_GV_HS_THPT.GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnHocSinh_Click(object sender, EventArgs e)
        {
            frmHocSinh hs = new frmHocSinh();
            hs.ShowDialog();
        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            frmGiaoVien gv = new frmGiaoVien();
            gv.ShowDialog();
        }

        private void btnTKB_Click(object sender, EventArgs e)
        {
            frmTKB tkb = new frmTKB();
            tkb.ShowDialog();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmGiaoDien gd = new frmGiaoDien();
            gd.Show();
            this.Hide();
        }

        private void btnHuongDan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon !!!");
        }
    }
}
