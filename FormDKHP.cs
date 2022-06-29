using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DangKyTinChi
{
    public partial class frmDKHP : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        DataTable dtNhom = new DataTable();
        DataTable dtBC = new DataTable();
        string sql, constr;
        int i;
        Boolean AddnewFlag = false;
        private void frmDKHP_Load(object sender, EventArgs e)
        {
            constr = "Data Source=PHUDUC;Initial Catalog=DKTC;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();

            sql = "Select MaHP,TenHP,MonTQ,SoTC,SoLHP from tblDKHP";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            tblDKHP.DataSource = dt;
            sql = "Select Distinct MaHP From tblDKHP";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dtNhom);
            /*txtMaHP.DataSource = dtNhom;
            txtMaHP.DisplayMember = "MaHP";*/
            NapCT();
        }
        private void NapCT()
        {
            i = tblDKHP.CurrentRow.Index;
            txtMaHP.Text = tblDKHP.Rows[i].Cells["MaHP"].Value.ToString(); //lấy dữ liệu từ dòng ô chỉ định
            txtTenHP.Text = tblDKHP.Rows[i].Cells["TenHP"].Value.ToString();
            txtMonTQ.Text = tblDKHP.Rows[i].Cells["MonTQ"].Value.ToString();
            txtSoTC.Text = tblDKHP.Rows[i].Cells["SoTC"].Value.ToString();
            txtSoLHP.Text = tblDKHP.Rows[i].Cells["SoLHP"].Value.ToString();

        }
        public frmDKHP()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {

        }

        private void tblDKHP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }
        private void tblDKHP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }
       
    }
}
