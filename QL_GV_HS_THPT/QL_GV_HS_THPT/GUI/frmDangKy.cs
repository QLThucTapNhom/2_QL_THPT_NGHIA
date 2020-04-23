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
    public partial class frmDangKy : Form
    {
        KetNoiDatabase dt = new KetNoiDatabase();
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {

        }
        public bool IsNumber(string str)
        {
            foreach (Char c in str)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtmk.Text == "" || txtmk2.Text == "" || txtten.Text == "")
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin");
            }
            else if (IsNumber(txtid.Text) == false) {
                MessageBox.Show("Số điện thoại không chính xác");
            }
            else
            {
                string id = txtid.Text.Trim();
                bool check = dt.Check(id, "select ID_TaiKhoan from TaiKhoan");
                if (check == false)
                {
                    if (txtmk.Text == txtmk2.Text)
                    {
                        string insert = "INSERT dbo.TaiKhoan(ID_TaiKhoan, TenTaiKhoan, MatKhau) VALUES ('" + txtid.Text + "','" + txtten.Text + "','" + txtmk.Text + "')";
                        dt.ThucThiKetNoi(insert);
                        frmGiaoDien gd = new frmGiaoDien();
                        gd.Show();
                        MessageBox.Show("Đăng ký thành công bạn có thể đăng nhập ngay");

                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không trùng nhau !!");
                    }

                }
                else
                {
                    MessageBox.Show("Tài khoản đã tồn tại");
                }
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtmk.Text = "";
            txtmk2.Text = "";
            txtten.Text = "";
            txtten.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
