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

namespace ApkBuah1
{
    public partial class Registrasi : Form
    {
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private DataSet ds;

        Koneksi koneksi = new Koneksi();
        HashCode hc = new HashCode();

        public Registrasi()
        {
            InitializeComponent();
        }



        private void Registrasi_Load(object sender, EventArgs e)
        {
            ShowData();
        }
        void ShowData()
        {
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from tbl_menu", conn);
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                checkedListBox1.Items.Add(item["MenuName"].ToString()); 
            }
            conn.Close();
        }

        private void btnSignin_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = koneksi.GetConn();
                conn.Open();
                string HakAkses = "";


                //string hk  = "";
                for (int i =0; i<checkedListBox1.CheckedIndices.Count; i++)
                {
                    HakAkses += Convert.ToString(checkedListBox1.CheckedIndices[i]) + ",";
                }
                HakAkses = HakAkses.TrimEnd(',');

                //SqlCommand Role = new SqlCommand("insert into tbl_role (MenuID) values ('" + HakAkses + "')", conn);
                cmd = new SqlCommand("insert into tbl_user (Username, Pass) values ('" + txtUsername.Text + "','" + hc.PashHash(txtPass.Text) + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Membuat Akun, Silahkan Login!");
                this.Hide();
                conn.Close();
                Login lg = new Login();
                lg.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Gagal Membuat Akun, Coba Lagi!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }
    }
}
