using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_GV_HS_THPT;

namespace QL_GV_HS_THPT.GUI
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        KetNoiDatabase data = new KetNoiDatabase();
        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTaiKhoan.Text.TrimEnd();
            string password = txtMatKhau.Text.TrimEnd();
            bool check = data.Check(password, "SELECT MatKhau FROM TaiKhoan WHERE TenTaiKhoan ='" + username + "'");

            if (txtTaiKhoan.Text != "" && txtMatKhau.Text != "" && check == true)
            {             
                frmMain main = new frmMain();                
                main.Show();                
                this.Hide();                  
            }
            else
            {
                MessageBox.Show("Thong tin không chính xác !!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtTaiKhoan.Clear();
                txtMatKhau.Clear();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void ckbHienMK_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void frmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmGiaoDien gd = new frmGiaoDien();
            gd.Show();
        }

       

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
