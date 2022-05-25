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
    public partial class FormPembelian : Form
    {
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private DataSet ds;

        Koneksi koneksi = new Koneksi();

        public FormPembelian()
        {
            InitializeComponent();
        }

        void NoFaktur()
        {
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            long hitung;
            string urutan;
            cmd = new SqlCommand("select NoFaktur from tbl_pembelian where NoFaktur in(select max(NoFaktur) from tbl_pembelian) order by NoFaktur desc", conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                hitung = Convert.ToInt64(dr["NoFaktur"]) + 1;
                string kodeurutan = "0000" + hitung;
                urutan = DateTime.Now.ToString("ddMMyyyy") + kodeurutan.Substring(kodeurutan.Length - 4, 4);
            }
            else
            {
                urutan = DateTime.Now.ToString("ddMMyyyy") + "0001";
            }
            txtNoFaktur.Text = urutan.ToString();
            conn.Close();
        }
        void ClearText()
        {
            txtKodeBrg.Clear();
            txtNamaBrg.Clear();
            txtMrkBrg.Clear();
            txtHargaBrg.Clear();
            txtHargaBeli.Clear();
            txtJumlah.Clear();
            txtTotal.Clear();

        }

        void ClearSup()
        {
            txtKodeSup.Clear();
            txtNamaSup.Clear();
            txtPhoneSup.Clear();
            txtAlamatSup.Clear();
            txtDescSup.Clear();
        }

        void TotalAll()
        {

            try
            {
                int jumlah = 0;
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {

                    jumlah += Convert.ToInt32(dataGridView2.Rows[i].Cells[6].Value);
                }

                txtTotalAll.Text = jumlah.ToString();
            }
            catch
            {
                txtTotalAll.Text = "0";
            }
        }

        private void FormPembelian_Load(object sender, EventArgs e)
        {
            NoFaktur();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToLongDateString();
        }

        private void txtKodeSup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
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
                    MessageBox.Show("Data Tidak Ditemukan");
                }
                conn.Close();
            }
        }

        private void linkSupplier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSupplier fs = new FormSupplier();
            fs.ShowDialog();
        }

        private void txtKodeBrg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SqlConnection conn = koneksi.GetConn();
                conn.Open();
                cmd = new SqlCommand("select * from tbl_barang where KodeBrg = '" + txtKodeBrg.Text + "'", conn);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    
                    txtNamaBrg.Text = (string)dr["NamaBrg"];
                    txtMrkBrg.Text = (string)dr["MerkBrg"];
                    txtHargaBrg.Text = (string)dr["HargaBrg"];

                    txtHargaBeli.Focus();

                }
                else
                {
                    MessageBox.Show("Data Tidak Ditemukan");
                }
                conn.Close();
            }
        }

        private void txtJumlah_TextChanged(object sender, EventArgs e)
        {
            int hasil;
            try
            {
                hasil = Convert.ToInt32(txtHargaBeli.Text) * Convert.ToInt32(txtJumlah.Text);
                txtTotal.Text = hasil.ToString();
            }
            catch
            {
                txtTotal.Text = "0";
            }
        }

        private void txtJumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                dataGridView2.Rows.Add(txtKodeBrg.Text, txtNamaBrg.Text, txtMrkBrg.Text, txtHargaBrg.Text,txtHargaBeli.Text, txtJumlah.Text, txtTotal.Text);
                ClearText();
                txtKodeBrg.Focus();
                TotalAll();
            }
        }

        private void txtBayar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int hasil;
                hasil = Convert.ToInt32(txtBayar.Text) - Convert.ToInt32(txtTotalAll.Text);
                txtKembalian.Text = hasil.ToString();
            }
            catch
            {
                txtKembalian.Text = "0";
            }
        }

        private void txtBayar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin Membatalkan Transaksi?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                dataGridView2.Rows.Clear();
                ClearText();
                ClearSup();
                txtTotalAll.Text = "0";
                txtBayar.Text = "0";
                txtKembalian.Text = "0";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTotalAll.Text == "")
            {
                MessageBox.Show("Belum ada data");
            }
            else if (Convert.ToInt32(txtBayar.Text) < Convert.ToInt32(txtTotalAll.Text))
            {
                MessageBox.Show("Pembayaran Kurang");
            }
            else if (string.IsNullOrEmpty(txtKodeSup.Text))
            {
                MessageBox.Show("Belum Mengisi Form Supplier");
            }
            else
            {
                if (MessageBox.Show("Yakin ingin simpan dan cetak nota?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    SqlConnection conn = koneksi.GetConn();
                    conn.Open();
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        cmd = new SqlCommand("insert into tbl_pembelian (NoFaktur, TglFaktur, Kode_Barang, Kode_Supplier, HargaBeli, JumlahBeli) values ('" + txtNoFaktur.Text + "', '" + txtDate.Text + "', '" + dataGridView2.Rows[i].Cells[0].Value + "', '" + txtKodeSup.Text + "', '" + dataGridView2.Rows[i].Cells[4].Value + "', '" + dataGridView2.Rows[i].Cells[5].Value + "')", conn);
                        cmd.ExecuteNonQuery();
                    }
                    DVPrintPreviewDialog.Document = DVPrintDocument;
                    DVPrintPreviewDialog.ShowDialog();
                    conn.Close();
                    dataGridView2.Rows.Clear();
                    ClearText();
                    ClearSup();
                    txtTotalAll.Text = "0";
                    txtBayar.Text = "0";
                    txtKembalian.Text = "0";
                }


            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DVPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("NOTA TRSANSAKSI PEMBELIAN TOKO BUAH ZEGAARRR", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(20, 0));
            e.Graphics.DrawString("Nama Supplier : " + txtNamaSup.Text + "-" + txtDescSup.Text , new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(25, 80));
            e.Graphics.DrawString("No Hp Supplier : " + txtPhoneSup.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(25, 110));
            e.Graphics.DrawString("Alamat Supplier : " + txtAlamatSup.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(25, 140));

            e.Graphics.DrawString("No Nota : " + txtNoFaktur.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(25, 180));
            e.Graphics.DrawString("Tanggal : " + txtDate.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(280, 180));

            e.Graphics.DrawString("---------------------------------------------------------------------------", new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(25, 230));
            e.Graphics.DrawString("Barang", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 260));
            e.Graphics.DrawString("Harga", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(300, 260));
            e.Graphics.DrawString("Jumlah", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(480, 260));
            e.Graphics.DrawString("Total", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(680, 260));
            e.Graphics.DrawString("----------------------------------------------------------------------------", new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(25, 280));

            int ypos = 325;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                e.Graphics.DrawString((string)dataGridView2.Rows[i].Cells[1].Value + " " + (string)dataGridView2.Rows[i].Cells[2].Value, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, ypos));
                e.Graphics.DrawString((string)dataGridView2.Rows[i].Cells[4].Value, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(300, ypos));
                e.Graphics.DrawString((string)dataGridView2.Rows[i].Cells[5].Value, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(480, ypos));
                e.Graphics.DrawString((string)dataGridView2.Rows[i].Cells[6].Value, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(680, ypos));

                ypos += 30;
            }
            e.Graphics.DrawString("----------------------------------------------------------------------------", new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(25, ypos));

            e.Graphics.DrawString("Total : " + txtTotalAll.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(620, ypos + 30));
            e.Graphics.DrawString("Bayar : " + txtBayar.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(620, ypos + 80));
            e.Graphics.DrawString("Kembalian : " + txtKembalian.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(600, ypos + 110));
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.Rows.RemoveAt(dataGridView2.CurrentCell.RowIndex);
            TotalAll();
        }
    }
}
