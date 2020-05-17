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
    public partial class frmTKB : Form
    {
        public frmTKB()
        {
            InitializeComponent();
        }
        KetNoiDatabase db = new KetNoiDatabase();
        bool themmoi = false;
        public void MoDK()
        {
            txtmon.ReadOnly = false;
            txtthu.ReadOnly = false;
            txttiet.ReadOnly = false;
            cbbbgiaovien.Enabled = true;
        }
        public void DongDK()
        {
            txttiet.ReadOnly = true;
            txtmon.ReadOnly = true;
            txtthu.ReadOnly = true;
            cbbbgiaovien.Enabled = false;
        }
        public void setNull()
        {
            txtmon.Text = "";
            txtthu.Text = "";
            txttiet.Text = "";
            cbbbgiaovien.Text = "";
            cbbmalop.Text = "";
        }
        public void setStart()
        {
            setNull();
            DongDK();
            btnsua.Enabled = true;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnLuu.Enabled = false;
            cbbmalop.Enabled = true;
            themmoi = false;
            
        }
        private void FrmTKB_Load(object sender, EventArgs e)
        {
            DongDK();
            btnLuu.Enabled = false;
            db.loadComboBox(cbbmalop, "select MaLopHoc from LopHoc ");
            db.loadComboBox(cbbbgiaovien, "SELECT ID_GV FROM GiaoVien ");
            
        }

        private void Cbbmalop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tkb = "EXEC TKB @malop='" + cbbmalop.Text + "'";
            db.loadDataGridView(dgvtkb, tkb);

        }

        private void Btnthem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            MoDK();
            setNull();
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnLuu.Enabled = true;
           

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
            i = e.RowIndex;            
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
            string delete = "DELETE FROM DayHoc WHERE MonHoc = N'" + mon + "'AND ID_GV = N'" + magv + "' AND MaLopHoc=N'" + malop + "' AND  Thu =N'" + thu + "'AND Tiet=N'" + tiet + "'";
            db.ThucThiKetNoi(delete);
            //db.loadDataGridView(dgvtkb, "SELECT * FROM dbo.DayHoc");


        }
        private void Btnsua_Click(object sender, EventArgs e)
        {
            deletetkb();
            cbbmalop.Enabled = false;
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            btnLuu.Enabled = true;
            MoDK();            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(cbbmalop.Text == "" || txtmon.Text == "" || txtthu.Text == "" || txttiet.Text == "")
            {
                MessageBox.Show("Thông tin nhập chưa đầy đủ !!");
                return;
            }
            else
            {
                if (themmoi == true)
                {
                    try
                    {
                        string malop = cbbmalop.Text.TrimEnd();
                        string magv = cbbbgiaovien.Text.TrimEnd();
                        string thu = txtthu.Text.TrimEnd();
                        string tiet = txttiet.Text.TrimEnd();
                        string mon = txtmon.Text.TrimEnd();

                        if (cbbmalop.Text.Length != 0 && cbbbgiaovien.Text.Length != 0 && txtthu.Text.Length != 0 && txttiet.Text.Length != 0)
                        {
                            bool check = db.Check(cbbmalop.Text, "SELECT MaLopHoc FROM DayHoc WHERE Thu = N'" + thu + "' AND Tiet =N'" + tiet + "'");
                            if (check == false)
                            {
                                db.ThucThiKetNoi("INSERT DayHoc(MonHoc, ID_GV, MaLopHoc, Thu, Tiet) VALUES (N'" + mon + "', '" + magv + "', '" + malop + "', N'" + thu + "', N'" + tiet + "')");
                                MessageBox.Show("Thêm hoàn tất!");
                                db.loadDataGridView(dgvtkb, "EXEC TKB @malop = '" + malop + "'");
                                setStart();
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
                else
                {
                    try
                    {
                        string malop = cbbmalop.Text.Trim();
                        string magv = cbbbgiaovien.Text.Trim();
                        string thu = txtthu.Text.Trim();
                        string tiet = txttiet.Text.Trim();
                        string mon = txtmon.Text.Trim();

                        if (cbbmalop.Text.Length != 0 && cbbbgiaovien.Text.Length != 0 && txtthu.Text.Length != 0 && txttiet.Text.Length != 0)
                        {
                            bool check = db.Check(malop, "SELECT MaLopHoc FROM DayHoc");
                            if (check == true)
                            {

                                db.ThucThiKetNoi("INSERT dbo.DayHoc(MonHoc, ID_GV, MaLopHoc, Thu, Tiet) VALUES (N'" + mon + "', '" + magv + "', '" + malop + "', N'" + thu + "', N'" + tiet + "')");
                                MessageBox.Show("Sửa thông tin cho TKB hoàn tất!");                               
                                db.loadDataGridView(dgvtkb, "EXEC TKB @malop = '" + malop + "'");
                                setStart();

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
                        MessageBox.Show("Đã xảy ra lỗi!!!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
            }

            
            
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {            
            DialogResult ys = MessageBox.Show("Bạn có muốn xóa  không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(ys == DialogResult.Yes)
            {
                string malop = cbbmalop.Text.Trim();
                string magv = cbbbgiaovien.Text.Trim();
                string thu = txtthu.Text.Trim();
                string tiet = txttiet.Text.Trim();
                string mon = txtmon.Text.Trim();
                string delete = "DELETE FROM dbo.DayHoc WHERE MonHoc = N'" + mon + "'AND ID_GV = N'" + magv + "' AND MaLopHoc=N'" + malop + "' AND  Thu =N'" + thu + "'AND Tiet=N'" + tiet + "'";
                db.ThucThiKetNoi(delete);            
                db.loadDataGridView(dgvtkb, "EXEC TKB @malop = '" + malop + "'");
                MessageBox.Show("Xóa hoàn tất!");
                setStart();
            }
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

