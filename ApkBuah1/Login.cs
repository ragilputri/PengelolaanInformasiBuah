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
    public partial class Login : Form
    {
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private DataSet ds;

        Koneksi koneksi = new Koneksi();
        HashCode hc = new HashCode();

        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from tbl_user join tbl_role on tbl_user.RoleID = '"+comboBox1.SelectedValue.ToString()+"' where tbl_user.Username = '" + txtUsername.Text + "' and tbl_user.Pass = '" + txtPass.Text + "'", conn);
            //cmd = new SqlCommand("select * from tbl_user where Username = '" + txtUsername.Text + "' and Pass = '" + hc.PashHash(txtPass.Text) + "'", conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {

                MenuUtama.menu.LName.Text = (string)dr["RoleName"] +" "+(string)dr["Username"];
                if (comboBox1.Text == "Admin")
                {
                    MenuUtama.menu.panelterkunci.Visible = false;
                    MenuUtama.menu.bnLogin.Enabled = false;
                    MenuUtama.menu.btnsignin.Enabled = false;
                    MenuUtama.menu.PanelLogin.Visible = true;
                    MenuUtama.menu.panelMaster.Visible = true;
                    MenuUtama.menu.LDataMaster.Visible = true;
                }
                else if (comboBox1.Text == "Operator")
                {
                    MenuUtama.menu.panelterkunci.Visible = false;
                    MenuUtama.menu.bnLogin.Enabled = false;
                    MenuUtama.menu.btnsignin.Enabled = false;
                    MenuUtama.menu.PanelLogin.Visible = true;
                    MenuUtama.menu.btnDataMaster.Enabled = false;
                    MenuUtama.menu.btnTransaksi.Enabled = false;
                    MenuUtama.menu.btnhistory.Enabled = true;
                }
                else if (comboBox1.Text == "Kasir")
                {
                    MenuUtama.menu.panelterkunci.Visible = false;
                    MenuUtama.menu.bnLogin.Enabled = false;
                    MenuUtama.menu.btnsignin.Enabled = false;
                    MenuUtama.menu.PanelLogin.Visible = true;
                    MenuUtama.menu.btnDataMaster.Enabled = false;
                    MenuUtama.menu.btnTransaksi.Enabled = true;
                    MenuUtama.menu.btnhistory.Enabled = false;
                }
                // MenuUtama.menu.loginToolStripMenuItem.Enabled = false;
                /// MenuUtama.menu.signInToolStripMenuItem.Enabled = false;
                // MenuUtama.menu.logoutToolStripMenuItem.Enabled = true;
                // MenuUtama.menu.manageToolStripMenuItem.Enabled = true;
                // MenuUtama.menu.transactionToolStripMenuItem.Enabled = true;
                // MenuUtama.menu.historyToolStripMenuItem.Enabled = true;
                // MenuUtama.menu.Snama.Text = (string)dr["Username"];
                this.Hide();

            }
            else
            {
                MessageBox.Show("Akun Tidak Terdaftar");
            }
            conn.Close();
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
        void ShowData()
        {
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from tbl_role", conn);
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "RoleID";
            comboBox1.DisplayMember = "RoleName";
            conn.Close();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            ShowData();
        }
    }
}
