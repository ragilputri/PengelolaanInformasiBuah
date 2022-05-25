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
    public partial class FormSupplier : Form
    {
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private DataSet ds;

        Koneksi koneksi = new Koneksi();
        string proses;
        public FormSupplier()
        {
            InitializeComponent();
        }

        void ShowData()
        {
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from tbl_supplier", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "tbl_supplier");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "tbl_supplier";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            conn.Close();
        }

        void EnabledText()
        {
            txtKodeSup.Enabled = true;
            txtNamaSup.Enabled = true;
            txtPhoneSup.Enabled = true;
            txtAlamatSup.Enabled = true;
            txtDescSup.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            btnInput.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }
        void DisabledText()
        {
            txtKodeSup.Enabled = false;
            txtNamaSup.Enabled = false;
            txtPhoneSup.Enabled = false;
            txtAlamatSup.Enabled = false;
            txtDescSup.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            btnInput.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }

        void ClearText()
        {
            txtKodeSup.Clear();
            txtNamaSup.Clear();
            txtPhoneSup.Clear();
            txtAlamatSup.Clear();
            txtDescSup.Clear();
        }

        void Disablederror()
        {
            ErrorNama.Visible = false;
            ErrorKode.Visible = false;
            ErrorPhone.Visible = false;
            ErrorAlamat.Visible = false;
            ErrorDesc.Visible = false;
        }

        private void FormSupplier_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            EnabledText();
            txtKodeSup.Focus();
            proses = "input";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EnabledText();
            txtKodeSup.Focus();
            proses = "update";
            btnSave.Text = "Update";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EnabledText();
            txtKodeSup.Focus();
            proses = "delete";
            btnSave.Text = "Delete";
        }

        private void txtKodeSup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (proses == "input")
                {
                    SqlConnection conn = koneksi.GetConn();
                    conn.Open();
                    cmd = new SqlCommand("select * from tbl_supplier where KodeSup = '" + txtKodeSup.Text + "'", conn);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        txtNamaSup.Text = (string)dr["NamaSup"];
                        txtPhoneSup.Text = (string)dr["PhoneSup"];
                        txtAlamatSup.Text = (string)dr["AlamatSup"];
                        txtDescSup.Text = (string)dr["DescSup"];

                        btnSave.Enabled = false;
                    }
                    else
                    {
                        txtNamaSup.Focus();
                    }
                    conn.Close();
                }
                else if (proses == "update")
                {
                    SqlConnection conn = koneksi.GetConn();
                    conn.Open();
                    cmd = new SqlCommand("select * from tbl_supplier where KodeSup = '" + txtKodeSup.Text + "'", conn);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        txtNamaSup.Text = (string)dr["NamaSup"];
                        txtPhoneSup.Text = (string)dr["PhoneSup"];
                        txtAlamatSup.Text = (string)dr["AlamatSup"];
                        txtDescSup.Text = (string)dr["DescSup"];
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
                    cmd = new SqlCommand("select * from tbl_supplier where KodeSup = '" + txtKodeSup.Text + "'", conn);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        txtNamaSup.Text = (string)dr["NamaSup"];
                        txtPhoneSup.Text = (string)dr["PhoneSup"];
                        txtAlamatSup.Text = (string)dr["AlamatSup"];
                        txtDescSup.Text = (string)dr["DescSup"];

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
                txtKodeSup.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKodeSup.Text))
            {
                ErrorKode.Visible = true;
                txtKodeSup.Focus();
            }
            else if (string.IsNullOrEmpty(txtNamaSup.Text))
            {
                ErrorNama.Visible = true;
                txtNamaSup.Focus();
            }
            else if (string.IsNullOrEmpty(txtPhoneSup.Text))
            {
                ErrorPhone.Visible = true;
                txtPhoneSup.Focus();
            }
            else if (string.IsNullOrEmpty(txtAlamatSup.Text))
            {
                ErrorAlamat.Visible = true;
                txtAlamatSup.Focus();
            }
            else if (string.IsNullOrEmpty(txtDescSup.Text))
            {
                ErrorDesc.Visible = true;
                txtDescSup.Focus();
            }
            else
            {
                Disablederror();

                if (proses == "input")
                {
                    SqlConnection conn = koneksi.GetConn();
                    conn.Open();
                    cmd = new SqlCommand("insert into tbl_supplier (KodeSup, NamaSup, PhoneSup, AlamatSup, DescSup) values ('" + txtKodeSup.Text + "', '" + txtNamaSup.Text + "', '" + txtPhoneSup.Text + "', '" + txtAlamatSup.Text + "', '"+txtDescSup.Text+"')", conn);
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
                    cmd = new SqlCommand("Update tbl_supplier set NamaSup = '" + txtNamaSup.Text + "', PhoneSup = '" + txtPhoneSup.Text + "', AlamatSup = '" + txtAlamatSup.Text + "', DescSup = '"+txtDescSup.Text+"' where KodeSup = '" + txtKodeSup.Text + "'", conn);
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
                        cmd = new SqlCommand("delete tbl_supplier where KodeSup = '" + txtKodeSup.Text + "'", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Berhasil Menghapus Data");
                        ShowData();
                        ClearText();
                        DisabledText();
                        conn.Close();
                    }
                    else
                    {
                        txtKodeSup.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Perintah Tidak Ditemukan");
                    txtKodeSup.Focus();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSave.Text = "Save";
            ClearText();
            DisabledText();
            Disablederror();
        }

        private void txtPhoneSup_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
    }
}
