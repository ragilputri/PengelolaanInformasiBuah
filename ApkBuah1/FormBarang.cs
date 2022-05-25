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
    public partial class FormBarang : Form
    {
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private DataSet ds;

        Koneksi koneksi = new Koneksi();
        string proses;
        public FormBarang()
        {
            InitializeComponent();
        }

        void ShowData()
        {
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from tbl_barang", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "tbl_barang");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "tbl_barang";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            conn.Close();
        }

        void EnabledText()
        {
            txtKodeBrg.Enabled = true;
            txtNamaBrg.Enabled = true;
            txtMerkBrg.Enabled = true;
            txtSatuan.Enabled = true;
            txtHargaBrg.Enabled = true;
            txtJumlahBrg.Enabled = true;
            dateExp.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            btnInput.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }
        void DisabledText()
        {
            txtKodeBrg.Enabled = false;
            txtNamaBrg.Enabled = false;
            txtMerkBrg.Enabled = false;
            txtSatuan.Enabled = false;
            txtHargaBrg.Enabled = false;
            txtJumlahBrg.Enabled = false;
            dateExp.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            btnInput.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }

        void ClearText()
        {
            txtKodeBrg.Clear();
            txtNamaBrg.Clear();
            txtMerkBrg.Clear();
            txtSatuan.Clear();
            txtHargaBrg.Clear();
            txtJumlahBrg.Clear();
        }

        void Disablederror()
        {
            errorJumlah.Visible = false;
            ErrorHarga.Visible = false;
            ErrorKode.Visible = false;
            ErrorMrk.Visible = false;
            ErrorNama.Visible = false;
            ErrorSatuan.Visible = false;
        }

        private void FormBarang_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            EnabledText();
            txtKodeBrg.Focus();
            proses = "input";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EnabledText();
            txtKodeBrg.Focus();
            proses = "update";
            btnSave.Text = "Update";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EnabledText();
            txtKodeBrg.Focus();
            proses = "delete";
            btnSave.Text = "Delete";
        }

        private void txtKodeBrg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                if(proses == "input")
                {
                    SqlConnection conn = koneksi.GetConn();
                    conn.Open();
                    cmd = new SqlCommand("select * from tbl_barang where KodeBrg = '" + txtKodeBrg.Text + "'", conn);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        txtNamaBrg.Text = (string)dr["NamaBrg"];
                        txtMerkBrg.Text = (string)dr["MerkBrg"];
                        txtSatuan.Text = (string)dr["SatuanBrg"];
                        txtHargaBrg.Text = (string)dr["HargaBrg"];
                        txtJumlahBrg.Text = dr["JumlahBrg"].ToString();
                        dateExp.Value = (DateTime)dr["TglExp"];

                        btnSave.Enabled = false;
                    }
                    else
                    {
                        txtNamaBrg.Focus();
                    }
                    conn.Close();
                }
                else if(proses == "update")
                {
                    SqlConnection conn = koneksi.GetConn();
                    conn.Open();
                    cmd = new SqlCommand("select * from tbl_barang where KodeBrg = '" + txtKodeBrg.Text + "'", conn);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        txtNamaBrg.Text = (string)dr["NamaBrg"];
                        txtMerkBrg.Text = (string)dr["MerkBrg"];
                        txtSatuan.Text = (string)dr["SatuanBrg"];
                        txtHargaBrg.Text = (string)dr["HargaBrg"];
                        txtJumlahBrg.Text = dr["JumlahBrg"].ToString();
                        dateExp.Value = (DateTime)dr["TglExp"];

                    }
                    else
                    {
                        MessageBox.Show("Data tidak ditemukan");
                    }
                    conn.Close();
                }
                else if(proses == "delete")
                {
                    SqlConnection conn = koneksi.GetConn();
                    conn.Open();
                    cmd = new SqlCommand("select * from tbl_barang where KodeBrg = '" + txtKodeBrg.Text + "'", conn);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        txtNamaBrg.Text = (string)dr["NamaBrg"];
                        txtMerkBrg.Text = (string)dr["MerkBrg"];
                        txtSatuan.Text = (string)dr["SatuanBrg"];
                        txtHargaBrg.Text = (string)dr["HargaBrg"];
                        txtJumlahBrg.Text = dr["JumlahBrg"].ToString();
                        dateExp.Value = (DateTime)dr["TglExp"];

                    }
                    else
                    {
                        MessageBox.Show("Data tidak ditemukan");
                    }
                    conn.Close();
                }
            }
            else
            {
                txtKodeBrg.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSave.Text = "Save";
            ClearText();
            DisabledText();
            Disablederror();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKodeBrg.Text))
            {
                ErrorKode.Visible = true;
                txtKodeBrg.Focus();
            }
            else if (string.IsNullOrEmpty(txtNamaBrg.Text))
            {
                ErrorNama.Visible = true;
                txtNamaBrg.Focus();
            }
            else if (string.IsNullOrEmpty(txtMerkBrg.Text))
            {
                ErrorMrk.Visible = true;
                txtMerkBrg.Focus();
            }
            else if (string.IsNullOrEmpty(txtSatuan.Text))
            {
                ErrorSatuan.Visible = true;
                txtSatuan.Focus();
            }
            else if (string.IsNullOrEmpty(txtHargaBrg.Text))
            {
                ErrorHarga.Visible = true;
                txtHargaBrg.Focus();
            }
            else if (string.IsNullOrEmpty(txtJumlahBrg.Text))
            {
                errorJumlah.Visible = true;
                txtJumlahBrg.Focus();
            }
            else
            {
                Disablederror();

                if (proses == "input")
                {
                    SqlConnection conn = koneksi.GetConn();
                    conn.Open();
                    cmd = new SqlCommand("insert into tbl_barang (KodeBrg, NamaBrg, MerkBrg, SatuanBrg, HargaBrg, JumlahBrg, TglExp) values ('" + txtKodeBrg.Text + "', '" + txtNamaBrg.Text + "', '" + txtMerkBrg.Text + "', '" + txtSatuan.Text + "', '" + txtHargaBrg.Text + "', '" + txtJumlahBrg.Text + "', '" + this.dateExp.Value.ToString("dd/MM/yyyy") + "')", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Berhasil Menyimpan Data");
                    ShowData();
                    ClearText();
                    DisabledText();
                    conn.Close();
                }
                else if (proses == "update")
                {
                    SqlConnection conn = koneksi.GetConn();
                    conn.Open();
                    cmd = new SqlCommand("Update tbl_barang set NamaBrg = '" + txtNamaBrg.Text + "', MerkBrg = '" + txtMerkBrg.Text + "', SatuanBrg = '" + txtSatuan.Text + "', HargaBrg = '" + txtHargaBrg.Text + "', JumlahBrg = '" + txtJumlahBrg.Text + "', TglExp = '" + this.dateExp.Value.ToString("dd/MM/yyyy") + "' where KodeBrg = '" + txtKodeBrg.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Berhasil Memperbarui Data");
                    ShowData();
                    ClearText();
                    DisabledText();
                    conn.Close();
                }
                else if (proses == "delete")
                {
                    if (MessageBox.Show("Yakin Menghapus Data Ini?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        SqlConnection conn = koneksi.GetConn();
                        conn.Open();
                        cmd = new SqlCommand("delete tbl_barang where KodeBrg = '" + txtKodeBrg.Text + "'", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Berhasil Menghapus Data");
                        ShowData();
                        ClearText();
                        DisabledText();
                        conn.Close();
                    }
                    else
                    {
                        txtKodeBrg.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Perintah Tidak Ditemukan");
                    txtKodeBrg.Focus();
                }
            }

            
        }

        private void txtJumlahBrg_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtHargaBrg_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
    }
}
