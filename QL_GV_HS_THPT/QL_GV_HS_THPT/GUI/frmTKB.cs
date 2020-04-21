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
    public partial class frmTKB : Form
    {
        public frmTKB()
        {
            InitializeComponent();
        }
        KetNoiDatabase db = new KetNoiDatabase();
        private void FrmTKB_Load(object sender, EventArgs e)
        {
            db.loadComboBox(cbbmalop, "select MaLopHoc from LopHoc ");
            db.loadComboBox(cbbbgiaovien, "SELECT ID_GV FROM dbo.GiaoVien ");
        }

        private void Cbbmalop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tkb = "EXEC TKB @malop='" + cbbmalop.Text + "'";
            db.loadDataGridView(dgvtkb, tkb);

        }

        private void Btnthem_Click(object sender, EventArgs e)
        {
            if (btnthem.Text == "Thêm")
            {
                cbbmalop.Text = "";
                txtthu.Clear();
                txttiet.Clear();
                cbbbgiaovien.Text = "";
                btnsua.Enabled = false;
                btnxoa.Enabled = false;
                btnthem.Text = "Lưu";
            }
            else
            {
                btnthem.Text = "Thêm";
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
                try
                {
                    string malop = cbbmalop.Text.Trim();
                    string magv = cbbbgiaovien.Text.Trim();
                    string thu = txtthu.Text.Trim();
                    string tiet = txttiet.Text.Trim();
                    string mon = txtmon.Text.Trim();

                    if (cbbmalop.Text.Length != 0 && cbbbgiaovien.Text.Length != 0 && txtthu.Text.Length != 0 && txttiet.Text.Length != 0)
                    {
                        bool check = db.Check(cbbmalop.Text, "SELECT MaLopHoc FROM dbo.DayHoc WHERE Thu = N'" + thu + "' AND Tiet =N'" + tiet + "'");
                        if (check == false)
                        {
                            db.ThucThiKetNoi("INSERT dbo.DayHoc(MonHoc, ID_GV, MaLopHoc, Thu, Tiet) VALUES (N'" + mon + "', '" + magv + "', '" + malop + "', N'" + thu + "', N'" + tiet + "')");
                            MessageBox.Show("Thêm hoàn tất!");
                            db.loadDataGridView(dgvtkb, "EXEC TKB @malop = '" + malop + "'");
                        }
                        else
                        {
                            MessageBox.Show("Không thể thêm!" + txtthu.Text + " đã có tiết " + txttiet + ".", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hãy điền đủ thông tin!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                catch
                {
                    MessageBox.Show("Đã xảy ra lỗi!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }

        private void Cbbbgiaovien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Dgvtkb_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int i;
            i = dgvtkb.CurrentRow.Index;
            txtthu.Text = dgvtkb.Rows[i].Cells[0].Value.ToString();
            txttiet.Text = dgvtkb.Rows[i].Cells[1].Value.ToString();
            txtmon.Text = dgvtkb.Rows[i].Cells[2].Value.ToString();
            cbbbgiaovien.Text = dgvtkb.Rows[i].Cells[3].Value.ToString();
        }
        public void deletetkb()
        {
            string malop = cbbmalop.Text.Trim();
            string magv = cbbbgiaovien.Text.Trim();
            string thu = txtthu.Text.Trim();
            string tiet = txttiet.Text.Trim();
            string mon = txtmon.Text.Trim();
       
                string delete = "DELETE FROM dbo.DayHoc WHERE MonHoc = N'" + mon + "'AND ID_GV = N'" + magv + "' AND MaLopHoc=N'" + malop + "' AND  Thu =N'" + thu + "'AND Tiet=N'" + tiet + "'";
                db.ThucThiKetNoi(delete);
                db.loadDataGridView(dgvtkb, "SELECT * FROM dbo.DayHoc");
                
            
        }
        private void Btnsua_Click(object sender, EventArgs e)
        {
            string malop = cbbmalop.Text.Trim();
            string magv = cbbbgiaovien.Text.Trim();
            string thu = txtthu.Text.Trim();
            string tiet = txttiet.Text.Trim();
            string mon = txtmon.Text.Trim();
            if (btnthem.Text == "Sửa")
            {

                deletetkb();
                btnthem.Enabled = false;
                btnxoa.Enabled = false;
                btnsua.Text = "Hoàn tất";
            }
            else
            {
                btnsua.Text = "Sửa";
                btnthem.Enabled = true;
                btnxoa.Enabled = true;
                try
                { 
                    if (cbbmalop.Text.Length != 0 && cbbbgiaovien.Text.Length != 0 && txtthu.Text.Length != 0 && txttiet.Text.Length != 0)
                    {
                        bool check = db.Check(malop, "SELECT MaLopHoc FROM dbo.DayHoc");
                        if (check == true)
                        {

                            db.ThucThiKetNoi("INSERT dbo.DayHoc(MonHoc, ID_GV, MaLopHoc, Thu, Tiet) VALUES (N'" + mon + "', '" + magv + "', '" + malop + "', N'" + thu + "', N'" + tiet + "')");
                            MessageBox.Show("Sửa hoàn tất!");
                            db.loadDataGridView(dgvtkb, "EXEC TKB @malop = '" + malop + "'");

                        }
                        else
                        {
                            MessageBox.Show("Lớp học không tồn tại!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        }

        private void Btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult ys = MessageBox.Show("Bạn có muốn xóa  không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            deletetkb();
            MessageBox.Show("Xóa hoàn tất!");

        }
    }
}

