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
    public partial class FormPelanggan : Form
    {
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private DataSet ds;

        Koneksi koneksi = new Koneksi();
        string proses;
        public FormPelanggan()
        {
            InitializeComponent();
        }
        void ShowData()
        {
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from tbl_pelanggan", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "tbl_pelanggan");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "tbl_pelanggan";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            conn.Close();
        }

        void EnabledText()
        {
            txtKodePlg.Enabled = true;
            txtNamaPlg.Enabled = true;
            txtPhonePlg.Enabled = true;
            txtAlamatPlg.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            btnInput.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }
        void DisabledText()
        {
            txtKodePlg.Enabled = false;
            txtNamaPlg.Enabled = false;
            txtPhonePlg.Enabled = false;
            txtAlamatPlg.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            btnInput.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }

        void ClearText()
        {
            txtKodePlg.Clear();
            txtNamaPlg.Clear();
            txtPhonePlg.Clear();
            txtAlamatPlg.Clear();
        }

        void Disablederror()
        {
            ErrorNama.Visible = false;
            ErrorKode.Visible = false;
            ErrorPhone.Visible = false;
            ErrorAlamat.Visible = false;
        }
        private void FormPelanggan_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            EnabledText();
            txtKodePlg.Focus();
            proses = "input";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EnabledText();
            txtKodePlg.Focus();
            proses = "update";
            btnSave.Text = "Update";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EnabledText();
            txtKodePlg.Focus();
            proses = "delete";
            btnSave.Text = "Delete";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSave.Text = "Save";
            ClearText();
            DisabledText();
            Disablederror();
        }

        private void txtKodePlg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (proses == "input")
                {
                    SqlConnection conn = koneksi.GetConn();
                    conn.Open();
                    cmd = new SqlCommand("select * from tbl_pelanggan where KodePlg = '" + txtKodePlg.Text + "'", conn);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        txtNamaPlg.Text = (string)dr["NamaPlg"];
                        txtPhonePlg.Text = (string)dr["PhonePlg"];
                        txtAlamatPlg.Text = (string)dr["AlamatPlg"];

                        btnSave.Enabled = false;
                    }
                    else
                    {
                        txtNamaPlg.Focus();
                    }
                    conn.Close();
                }
                else if (proses == "update")
                {
                    SqlConnection conn = koneksi.GetConn();
                    conn.Open();
                    cmd = new SqlCommand("select * from tbl_pelanggan where KodePlg = '" + txtKodePlg.Text + "'", conn);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        txtNamaPlg.Text = (string)dr["NamaPlg"];
                        txtPhonePlg.Text = (string)dr["PhonePlg"];
                        txtAlamatPlg.Text = (string)dr["AlamatPlg"];

                    }
                    else
                    {
                        MessageBox.Show("Data tidak ditemukan");
                    }
                    conn.Close();
                }
                else if (proses == "delete")
                {
                    SqlConnection conn = koneksi.GetConn();
                    conn.Open();
                    cmd = new SqlCommand("select * from tbl_pelanggan where KodePlg = '" + txtKodePlg.Text + "'", conn);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        txtNamaPlg.Text = (string)dr["NamaPlg"];
                        txtPhonePlg.Text = (string)dr["PhonePlg"];
                        txtAlamatPlg.Text = (string)dr["AlamatPlg"];

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
                txtKodePlg.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKodePlg.Text))
            {
                ErrorKode.Visible = true;
                txtKodePlg.Focus();
            }
            else if (string.IsNullOrEmpty(txtNamaPlg.Text))
            {
                ErrorNama.Visible = true;
                txtNamaPlg.Focus();
            }
            else if (string.IsNullOrEmpty(txtPhonePlg.Text))
            {
                ErrorPhone.Visible = true;
                txtPhonePlg.Focus();
            }
            else if (string.IsNullOrEmpty(txtAlamatPlg.Text))
            {
                ErrorAlamat.Visible = true;
                txtAlamatPlg.Focus();
            }
            else
            {
                Disablederror();

                if (proses == "input")
                {
                    SqlConnection conn = koneksi.GetConn();
                    conn.Open();
                    cmd = new SqlCommand("insert into tbl_pelanggan (KodePlg, NamaPlg, PhonePlg, AlamatPlg) values ('" + txtKodePlg.Text + "', '" + txtNamaPlg.Text + "', '" + txtPhonePlg.Text + "', '" + txtAlamatPlg.Text + "')", conn);
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
                    cmd = new SqlCommand("Update tbl_pelanggan set NamaPlg = '" + txtNamaPlg.Text + "', PhonePlg = '" + txtPhonePlg.Text + "', AlamatPlg = '" + txtAlamatPlg.Text + "' where KodePlg = '" + txtKodePlg.Text + "'", conn);
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
                        cmd = new SqlCommand("delete tbl_pelanggan where KodePlg = '" + txtKodePlg.Text + "'", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Berhasil Menghapus Data");
                        ShowData();
                        ClearText();
                        DisabledText();
                        conn.Close();
                    }
                    else
                    {
                        txtKodePlg.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Perintah Tidak Ditemukan");
                    txtKodePlg.Focus();
                }
            }
        }

        private void txtPhonePlg_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
    }
}
