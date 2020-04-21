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
    public partial class frmHocSinh : Form
    {
        KetNoiDatabase db = new KetNoiDatabase();
        public frmHocSinh()
        {
            InitializeComponent();
        }
        public int temp = 0; //bien dung nhan biet lua chon chuc nang
        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            db.loadDataGridView(dgvHocSinh, "SELECT * FROM dbo.HocSinh");
            db.loadComboBox(cbbMaLop, "SELECT MaLopHoc FROM dbo.LopHoc");
            btnLuu.Enabled = false;
        }
        private void dgvHocSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvHocSinh.CurrentRow.Index;
            txtMaHS.Text = dgvHocSinh.Rows[i].Cells[0].Value.ToString();
            txtTenHS.Text = dgvHocSinh.Rows[i].Cells[1].Value.ToString();
            cbbGioiTinh.Text = dgvHocSinh.Rows[i].Cells[2].Value.ToString();
            dtpNgaySinh.Text = dgvHocSinh.Rows[i].Cells[3].Value.ToString();
            txtQueQuan.Text = dgvHocSinh.Rows[i].Cells[4].Value.ToString();
            cbbMaLop.Text = dgvHocSinh.Rows[i].Cells[5].Value.ToString();
        }
        public void OpenButtonClick()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnTimKiem.Enabled = true;
        }
        

        private void cbbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MaLop = cbbMaLop.SelectedItem.ToString();
            db.loadDataGridView(dgvHocSinh, "SELECT * FROM dbo.HocSinh WHERE MaLopHoc=N'"+MaLop+"'");
            
        }

        public void Clear()
        {
            txtMaHS.Clear();
            txtTenHS.Clear();
            txtQueQuan.Clear();
            cbbGioiTinh.Text = "";
            dtpNgaySinh.Value = DateTime.Today;
            cbbMaLop.Text = "";
        }

        
        
        public void ThemHocSinh()
        {
            try
            {
                string maHS = txtMaHS.Text.Trim();
                string tenHS = txtTenHS.Text.Trim();
                string gioiTinh = cbbGioiTinh.Text.Trim();
                string queQuan = txtQueQuan.Text.Trim();
                string ngaySinh = dtpNgaySinh.Value.ToShortDateString();
                string maLop = cbbMaLop.Text.Trim();

                if (maHS.Length != 0 && tenHS.Length != 0 && gioiTinh.Length != 0 && queQuan.Length != 0 && maLop.Length != 0)
                {
                    bool check = db.Check(maHS, "SELECT ID_HS FROM dbo.HocSinh");
                    if (check == false)
                    {

                        string insert = "INSERT INTO dbo.HocSinh( ID_HS ,HoTen ,GioiTinh ,NgaySinh ,QueQuan ,MaLopHoc)"
                         + "VALUES(N'" + maHS + "', N'" + tenHS + "', N'" + gioiTinh + "', '" + ngaySinh + "', N'" + queQuan + "', N'" + maLop + "')";

                        //string insert = "INSERT dbo.HocSinh(ID_HS, HoTen, GioiTinh, NgaySinh, QueQuan, MaLopHoc)" +
                        //"VALUES('" + maHS + "', N'" + tenHS + "', N'" + gioiTinh + "', '" + ngaySinh + "', N'" + queQuan + "', '" + maLop + "')";
                        db.ThucThiKetNoi(insert);
                        MessageBox.Show("Thêm học sinh " + tenHS + " hoàn tất!");
                        dgvHocSinh.DataSource = null;
                        db.loadDataGridView(dgvHocSinh, "SELECT * FROM dbo.HocSinh WHERE ID_HS=N'" + maHS + "'");

                    }
                    else
                    {
                        MessageBox.Show("Mã " + maHS + " đã tồn tại!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa điền đầy đủ thông tin!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SuaHocSinh()
        {
            try
            {
                string maHS = txtMaHS.Text.Trim();
                string tenHS = txtTenHS.Text.Trim();
                string gioiTinh = cbbGioiTinh.Text.Trim();
                string queQuan = txtQueQuan.Text.Trim();
                string ngaySinh = dtpNgaySinh.Value.ToShortDateString();
                string maLop = cbbMaLop.Text.Trim();

                if (maHS.Length != 0 && tenHS.Length != 0 && gioiTinh.Length != 0 && queQuan.Length != 0 && maLop.Length != 0)
                {
                    bool check = db.Check(maHS, "SELECT ID_HS FROM dbo.HocSinh");
                    if (check == true)
                    {

                        string update = "UPDATE dbo.HocSinh SET HoTen = N'"+tenHS+"', GioiTinh = N'"+gioiTinh+"', NgaySinh='"+ngaySinh+"', QueQuan=N'"+queQuan+"', MaLopHoc=N'"+maLop+"' WHERE ID_HS=N'"+maHS+"'";
                        db.ThucThiKetNoi(update);
                        MessageBox.Show("Sửa thông tin cho " + maHS + " hoàn tất!");
                        dgvHocSinh.DataSource = null;
                        db.loadDataGridView(dgvHocSinh, "SELECT * FROM dbo.HocSinh WHERE ID_HS=N'" + maHS + "'");

                    }
                    else
                    {
                        MessageBox.Show("Mã " + maHS + " không tồn tại!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa điền đầy đủ thông tin!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Clear();
            temp = 1;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnTimKiem.Enabled = false;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            temp = 2;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnTimKiem.Enabled = false;
            txtMaHS.ReadOnly = true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
      
            DialogResult ys = MessageBox.Show("Bạn có muốn xóa "+txtTenHS.Text.Trim()+" không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ys == DialogResult.Yes)
            {
                string del = "DELETE FROM dbo.HocSinh WHERE ID_HS=N'" + txtMaHS.Text.Trim() + "'";
                db.ThucThiKetNoi(del);
                MessageBox.Show("Xóa " + txtMaHS.Text.Trim() + " hoàn tất!");
                db.loadDataGridView(dgvHocSinh, "SELECT * FROM dbo.HocSinh");
                Clear();
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnTimKiem.Enabled = true;

            txtMaHS.Enabled = true;
            txtTenHS.Enabled = true;
            txtQueQuan.ReadOnly = true;
            cbbGioiTinh.Enabled = false;
            cbbMaLop.Enabled = false;
            dtpNgaySinh.Enabled = false;

        }
        private void tkMa_Click(object sender, EventArgs e)
        {
            txtTenHS.Clear();
            string timkiem = "SELECT * FROM dbo.HocSinh WHERE ID_HS=N'" + txtMaHS.Text.Trim() + "'";
            db.loadDataGridView(dgvHocSinh, timkiem);
        }
        private void tkTen_Click(object sender, EventArgs e)
        {
            txtMaHS.Clear();
            string timkiem = "SELECT * FROM dbo.HocSinh WHERE HoTen LIKE N'%" + txtTenHS.Text.Trim() + "%'";
            db.loadDataGridView(dgvHocSinh, timkiem);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenButtonClick();
        }
        private void exitSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenButtonClick();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            switch (temp)
            {
                case 0:
                    {
                        break;
                    }
                case 1: //Thêm
                    {
                        ThemHocSinh();
                        OpenButtonClick();//Mở lại các bị nút ẩn 
                        break;
                    }
                case 2: //Sửa
                    {
                        SuaHocSinh();
                        OpenButtonClick();//Mở lại các bị nút ẩn 
                        break;
                    }
              
               
                default: break;
            }
        }

        private void txtMaHS_TextChanged(object sender, EventArgs e)
        {

        }
        private void MaHS_TextChanged(object sender, EventArgs e)
        {
            txtTenHS.Clear();
            string timkiem = "SELECT * FROM dbo.HocSinh WHERE ID_HS=N'" + txtMaHS.Text.Trim() + "'";
            db.loadDataGridView(dgvHocSinh, timkiem);
        }
        private void txtTenHS_TextChanged(object sender, EventArgs e)
        {


        }

        
    }
}
