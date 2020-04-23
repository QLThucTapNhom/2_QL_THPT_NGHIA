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
    public partial class frmGiaoVien : Form
    {

        KetNoiDatabase db = new KetNoiDatabase();
        public frmGiaoVien()
        {
            InitializeComponent();
        }
        public int temp = 0;

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            db.loadDataGridView(drvGV, "SELECT * FROM dbo.GiaoVien");
            btnLuu.Enabled = false;
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd-MM-yyyy";
        }

        private void drvGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = drvGV.CurrentRow.Index;
            txtMaGV.Text = drvGV.Rows[i].Cells[0].Value.ToString();
            txtTenGV.Text = drvGV.Rows[i].Cells[1].Value.ToString();
            cbbGioiTinh.Text = drvGV.Rows[i].Cells[2].Value.ToString();
            dtpNgaySinh.Text = drvGV.Rows[i].Cells[3].Value.ToString();
            txtQueQuan.Text = drvGV.Rows[i].Cells[4].Value.ToString();
            txtTrinhDo.Text = drvGV.Rows[i].Cells[5].Value.ToString();
            txtSDT.Text = drvGV.Rows[i].Cells[6].Value.ToString();
        }
        public void Clear()
        {
            txtMaGV.Clear();
            txtTenGV.Clear();
            txtQueQuan.Clear();
            cbbGioiTinh.Text = "";
            dtpNgaySinh.Value = DateTime.Today;
            txtTrinhDo.Clear();
            txtSDT.Clear();
        }
        public void OpenButton()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnTimKiem.Enabled = true;
        }
        public void ReadOnlyFasle()
        {
            txtMaGV.Enabled = true;
            txtMaGV.ReadOnly = false;
            txtTenGV.Enabled = true;
            txtQueQuan.ReadOnly = false;
            cbbGioiTinh.Enabled = true;
            txtTrinhDo.Enabled = true;
            txtSDT.Enabled = true;
            dtpNgaySinh.Enabled = true;
        }
        public void ThemGiaoVien()
        {
            try
            {
                string maGV = txtMaGV.Text.Trim();
                string tenGV = txtTenGV.Text.Trim();
                string gioiTinh = cbbGioiTinh.Text.Trim();
                string queQuan = txtQueQuan.Text.Trim();
                string ngaySinh = dtpNgaySinh.Value.ToShortDateString();
                string trinhDo = txtTrinhDo.Text.Trim();
                string sdt = txtTrinhDo.Text.Trim();

                if (maGV.Length != 0 && tenGV.Length != 0 && gioiTinh.Length != 0 && queQuan.Length != 0 && trinhDo.Length != 0 && sdt.Length != 0)
                {
                    bool check = db.Check(maGV, "SELECT ID_GV FROM dbo.GiaoVien");
                    if (check == false)
                    {

                        string insert = "INSERT INTO dbo.GiaoVien( ID_GV ,HoTen ,GioiTinh ,NgaySinh ,QueQuan ,TrinhDo ,SDT)"
                        + "VALUES  ( N'" + maGV + "' , N'" + tenGV + "' , N'" + gioiTinh + "' , '" + ngaySinh + "' , N'" + queQuan + "' , N'" + trinhDo + "' , '" + sdt + "' )";
                        db.ThucThiKetNoi(insert);
                        MessageBox.Show("Thêm GV " + tenGV + " hoàn tất!");
                        drvGV.DataSource = null;
                        db.loadDataGridView(drvGV, "SELECT * FROM dbo.GiaoVien WHERE ID_GV=N'" + maGV + "'");

                    }
                    else
                    {
                        MessageBox.Show("Mã " + maGV + " đã tồn tại!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa điền đầy đủ thông tin!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi!", "");
            }
        }
        public void SuaGiaoVien()
        {
            try
            {
                string maGV = txtMaGV.Text.Trim();
                string tenGV = txtTenGV.Text.Trim();
                string gioiTinh = cbbGioiTinh.Text.Trim();
                string queQuan = txtQueQuan.Text.Trim();
                string ngaySinh = dtpNgaySinh.Value.ToShortDateString();
                string trinhDo = txtTrinhDo.Text.Trim();
                string sdt = txtTrinhDo.Text.Trim();

                if (maGV.Length != 0 && tenGV.Length != 0 && gioiTinh.Length != 0 && queQuan.Length != 0 && trinhDo.Length != 0 && sdt.Length != 0)
                {
                    bool check = db.Check(maGV, "SELECT ID_GV FROM dbo.GiaoVien");
                    if (check == true)
                    {

                        string update = "UPDATE dbo.GiaoVien SET HoTen=N'" + tenGV + "' ,GioiTinh=N'" + gioiTinh + "' ,"
                            + "NgaySinh='" + ngaySinh + "' ,QueQuan=N'" + queQuan + "' ,TrinhDo=N'" + trinhDo + "' ,SDT=N'" + sdt + "' WHERE ID_GV=N'" + maGV + "'";
                        db.ThucThiKetNoi(update);
                        MessageBox.Show("Sửa thông tin GV: " + maGV + " hoàn tất!");
                        drvGV.DataSource = null;
                        db.loadDataGridView(drvGV, "SELECT * FROM dbo.GiaoVien WHERE ID_GV=N'" + maGV + "'");

                    }
                    else
                    {
                        MessageBox.Show("Mã " + maGV + " Không tồn tại!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa điền đầy đủ thông tin!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi!", "");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Clear();
            temp = 1;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnTimKiem.Enabled = false;
            drvGV.DataSource = null;
            db.loadDataGridView(drvGV, "SELECT * FROM dbo.GiaoVien");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            temp = 2;

            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnTimKiem.Enabled = false;
            txtMaGV.ReadOnly = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ys = MessageBox.Show("Bạn có muốn xóa " + txtTenGV.Text.Trim() + " không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ys == DialogResult.Yes)
            {
                string dayhoc = "DELETE FROM dbo.DayHoc WHERE ID_GV = N'" + txtMaGV.Text.Trim() + "'";
                db.ThucThiKetNoi(dayhoc);
                string del = "DELETE FROM dbo.GiaoVien WHERE ID_GV = N'" + txtMaGV.Text.Trim() + "'";                
                db.ThucThiKetNoi(del);
                MessageBox.Show("Xóa " + txtMaGV.Text.Trim() + " hoàn tất!");
                db.loadDataGridView(drvGV, "SELECT * FROM dbo.GiaoVien");
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

            txtMaGV.Enabled = true;
            txtTenGV.Enabled = true;
            txtQueQuan.ReadOnly = true;
            cbbGioiTinh.Enabled = false;
            txtTrinhDo.Enabled = false;
            txtSDT.Enabled = false;
            dtpNgaySinh.Enabled = false;
        }

        private void tkMa_Click(object sender, EventArgs e)
        {
            txtTenGV.Clear();
            string timkiem = "SELECT * FROM dbo.GiaoVien WHERE ID_GV=N'" + txtMaGV.Text.Trim() + "'";
            db.loadDataGridView(drvGV, timkiem);
        }

        private void tkTen_Click(object sender, EventArgs e)
        {
            txtMaGV.Clear();
            string timkiem = "SELECT * FROM dbo.GiaoVien WHERE HoTen LIKE N'%" + txtTenGV.Text.Trim() + "%'";
            db.loadDataGridView(drvGV, timkiem);
        }

        private void exitSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenButton();
            ReadOnlyFasle();
            db.loadDataGridView(drvGV, "SELECT * FROM dbo.GiaoVien");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            switch (temp)
            {
                case 0: break;
                case 1:
                    {
                        ThemGiaoVien();
                        OpenButton();
                        ReadOnlyFasle();
                        break;
                    }
                case 2:
                    {
                        SuaGiaoVien();
                        OpenButton();
                        ReadOnlyFasle();
                        break;
                    }
                default: break;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult t = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (t == DialogResult.Yes)
            {
                Clear();
                OpenButton();
                db.loadDataGridView(drvGV, "SELECT * FROM dbo.GiaoVien");
            }
        }
    }
}
