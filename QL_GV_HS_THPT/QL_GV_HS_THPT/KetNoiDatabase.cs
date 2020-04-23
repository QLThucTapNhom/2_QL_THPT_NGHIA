using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QL_GV_HS_THPT
{
    public class KetNoiDatabase
    {
        public static SqlConnection connection = new SqlConnection(@"Data Source=ADMIN;Initial Catalog=HeThong_QuanLyHocTap;Integrated Security=True");
        SqlDataAdapter sqlDataAdapter;
        SqlDataReader sqlDataReader;
        DataSet dataSet = new DataSet();        
        SqlCommand sqlCommand;
        

        public static void MoKetNoi()
        {
            connection.Open();
        }
        public void NgatKetNoi()
        {
            connection.Close();
        }
        public void ThucThiKetNoi(string str)
        {
            MoKetNoi();
            sqlCommand = new SqlCommand(str, connection);
            sqlCommand.ExecuteNonQuery();
            NgatKetNoi();
        }
        //public void loadDataGridView(DataGridView dgv, string str)
        //{
        //    dataSet.Clear();
        //    sqlDataAdapter = new SqlDataAdapter(str, connection);
        //    sqlDataAdapter.Fill(dataSet, "query");
        //    dgv.DataSource = dataSet.Tables[0];
        //}
        public void loadDataGridView(DataGridView dg, string strselect)
        {
            MoKetNoi();
            DataTable table = new DataTable();
            sqlDataAdapter = new SqlDataAdapter(strselect, connection);
            table.Clear();
            sqlDataAdapter.Fill(table);
            dg.DataSource = table;
            NgatKetNoi();
        }
        public void loadComboBox(ComboBox cbb, string str)
        {
            MoKetNoi();
            sqlCommand = new SqlCommand(str, connection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                cbb.Items.Add(sqlDataReader[0].ToString());
            }
            NgatKetNoi();
        }
        public void loadComboBox_Show(ComboBox cbb, string str)
        {
            MoKetNoi();
            sqlCommand = new SqlCommand(str, connection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                cbb.Text = (sqlDataReader[0].ToString());
            }
            NgatKetNoi();
        }
        public void loadTextBox(TextBox ttb, string str)
        {
            MoKetNoi();
            sqlCommand = new SqlCommand(str, connection);
            sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.Read())
            {
                ttb.Text = sqlDataReader[0].ToString();
            }
            NgatKetNoi();
        }

        public bool Check(string temp, string sql)
        {

            MoKetNoi();
            bool check = false;
            sqlCommand = new SqlCommand(sql, connection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                if (sqlDataReader[0].ToString().Trim() == temp)
                    check = true;
            }
            NgatKetNoi();
            return check;
        }
    }
}
