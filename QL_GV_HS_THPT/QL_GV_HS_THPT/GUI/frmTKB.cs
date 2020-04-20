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
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (cbbmalop.SelectedItem == null)
            {
                MessageBox.Show("Hãy chọn mã lớp!");
            }
            else
            {
                string tkb = "EXEC TKB @malop='" + cbbmalop.Text + "'";
                db.loadDataGridView(dgvtkb, tkb);
                dgvtkb.Columns[0].Width = 115;
                dgvtkb.Columns[1].Width = 115;
                dgvtkb.Columns[2].Width = 115;
                dgvtkb.Columns[3].Width = 150;
            }
        }
    }
}
