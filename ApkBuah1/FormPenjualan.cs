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
    public partial class FormPenjualan : Form
    {
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private DataSet ds;

        Koneksi koneksi = new Koneksi();
        public FormPenjualan()
        {
            InitializeComponent();
        }

        private void txtKodePlg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
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
                    MessageBox.Show("Data Tidak Ditemukan");
                }
                conn.Close();
            }
            
        }

        private void LinkPelanggan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormPelanggan fp = new FormPelanggan();
            fp.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToLongDateString();
        }

        void NoNota()
        {
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            long hitung;
            string urutan;
            cmd = new SqlCommand("select NoNota from tbl_penjualan where NoNota in(select max(NoNota) from tbl_penjualan) order by NoNota desc", conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                hitung = Convert.ToInt64(dr["NoNota"]) + 1;
                string kodeurutan = "0000" + hitung;
                urutan = DateTime.Now.ToString("ddMMyyyy") + kodeurutan.Substring(kodeurutan.Length - 4, 4);
            }
            else
            {
                urutan = DateTime.Now.ToString("ddMMyyyy") + "0001";
            }
            txtNoNota.Text = urutan.ToString();
            conn.Close();
        }

        void ClearText()
        {
            txtKodeBrg.Clear();
            txtNamaBrg.Clear();
            txtMerkBrg.Clear();
            txtHargaBrg.Clear();
            txtJumlahBrg.Clear();
            txtTotal.Clear();

        }

        void ClearPlg()
        {
            txtKodePlg.Clear();
            txtNamaPlg.Clear();
            txtPhonePlg.Clear();
            txtAlamatPlg.Clear();
        }

        void TotalAll()
        {
            
            try
            {
                int jumlah = 0;
                for (int i=0; i<dataGridView1.Rows.Count; i++)
                {
                    
                    jumlah += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                }

                txtTotalAll.Text = jumlah.ToString();
            }
            catch
            {
                txtTotalAll.Text = "0";
            }
        }

        private void FormPenjualan_Load(object sender, EventArgs e)
        {
            NoNota();
            TotalAll();
        }

        private void txtKodeBrg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                SqlConnection conn = koneksi.GetConn();
                conn.Open();
                cmd = new SqlCommand("select * from tbl_barang where KodeBrg = '" + txtKodeBrg.Text + "'", conn);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    if ((DateTime)dr["TglExp"] <= DateTime.Now && dr["JumlahBrg"].ToString() != "0")
                    {
                        MessageBox.Show("Barang Exired");
                    }
                    else if((DateTime)dr["TglExp"] > DateTime.Now && dr["JumlahBrg"].ToString() == "0")
                    {
                        MessageBox.Show("Barang Habis");
                    }
                    else if((DateTime)dr["TglExp"] <= DateTime.Now && dr["JumlahBrg"].ToString() == "0")
                    {
                        MessageBox.Show("Barang Expired dan Habis");
                    }
                    else if((DateTime)dr["TglExp"] > DateTime.Now && dr["JumlahBrg"].ToString() != "0")
                    {
                        txtNamaBrg.Text = (string)dr["NamaBrg"];
                        txtMerkBrg.Text = (string)dr["MerkBrg"];
                        txtHargaBrg.Text = (string)dr["HargaBrg"];

                        txtJumlahBrg.Focus();
                    }
                    

                }
                else
                {
                    MessageBox.Show("Data Tidak Ditemukan");
                }
                conn.Close();
            }
        }

        private void txtJumlahBrg_TextChanged(object sender, EventArgs e)
        {
            int hasil;
            try
            {
                hasil = Convert.ToInt32(txtHargaBrg.Text) * Convert.ToInt32(txtJumlahBrg.Text);
                txtTotal.Text = hasil.ToString();
            }
            catch
            {
                txtTotal.Text = "0";
            }
            
        }

        private void txtJumlahBrg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {

                SqlConnection conn = koneksi.GetConn();
                conn.Open();
                cmd = new SqlCommand("select * from tbl_barang where KodeBrg = '" + txtKodeBrg.Text + "'", conn);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    if (Convert.ToInt32(txtJumlahBrg.Text) > Convert.ToInt32(dr["JumlahBrg"]))
                    {
                        MessageBox.Show("Persediaan Barang Hanya " + dr["JumlahBrg"] + "");
                    }
                    else
                    {
                        dataGridView1.Rows.Add(txtKodeBrg.Text, txtNamaBrg.Text, txtMerkBrg.Text, txtHargaBrg.Text, txtJumlahBrg.Text, txtTotal.Text);
                        ClearText();
                        txtKodeBrg.Focus();
                        TotalAll();
                    }
                }
                conn.Close();

                
            }
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            TotalAll();
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
            if(MessageBox.Show("Yakin Membatalkan Transaksi?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                dataGridView1.Rows.Clear();
                ClearText();
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
            else
            {
                if(MessageBox.Show("Yakin ingin simpan dan cetak nota?","Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    SqlConnection conn = koneksi.GetConn();
                    conn.Open();
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        cmd = new SqlCommand("insert into tbl_penjualan (NoNota, TglNota, Kode_Barang, Kode_Pelanggan, Harga, Jumlah) values ('" + txtNoNota.Text + "', '" + txtDate.Text + "', '" + dataGridView1.Rows[i].Cells[0].Value + "', '" + txtKodePlg.Text + "', '" + dataGridView1.Rows[i].Cells[3].Value + "', '" + dataGridView1.Rows[i].Cells[4].Value + "')", conn);
                        cmd.ExecuteNonQuery();
                    }
                    DVPrintPreviewDialog.Document = DVPrintDocument;
                    DVPrintPreviewDialog.ShowDialog();
                    conn.Close();
                    dataGridView1.Rows.Clear();
                    ClearText();
                    ClearPlg();
                    txtTotalAll.Text = "0";
                    txtBayar.Text = "0";
                    txtKembalian.Text = "0";
                }
                

            }
        }

        private void DVPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("NOTA TRSANSAKSI PENJUALAN TOKO FRUITYBOX", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(20, 0));
            e.Graphics.DrawString("Nama Pelanggan : " +txtNamaPlg.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(25, 80));
            e.Graphics.DrawString("No Hp Pelanggan : " + txtPhonePlg.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(25, 110));
            e.Graphics.DrawString("Alamat Pelanggan : " + txtAlamatPlg.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(25, 140));

            e.Graphics.DrawString("No Nota : " + txtNoNota.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(25, 180));
            e.Graphics.DrawString("Tanggal : " + txtDate.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(280, 180));

            e.Graphics.DrawString("---------------------------------------------------------------------------", new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(25, 230));
            e.Graphics.DrawString("Barang", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 260));
            e.Graphics.DrawString("Harga", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(300, 260));
            e.Graphics.DrawString("Jumlah", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(480, 260));
            e.Graphics.DrawString("Total", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(680, 260));
            e.Graphics.DrawString("----------------------------------------------------------------------------", new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(25, 280));

            int ypos = 325;
            for(int i=0; i<dataGridView1.Rows.Count; i++)
            {
                e.Graphics.DrawString((string)dataGridView1.Rows[i].Cells[1].Value +" "+ (string)dataGridView1.Rows[i].Cells[2].Value, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, ypos));
                e.Graphics.DrawString((string)dataGridView1.Rows[i].Cells[3].Value, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(300, ypos));
                e.Graphics.DrawString((string)dataGridView1.Rows[i].Cells[4].Value, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(480, ypos));
                e.Graphics.DrawString((string)dataGridView1.Rows[i].Cells[5].Value, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(680, ypos));

                ypos += 30;
            }

            e.Graphics.DrawString("----------------------------------------------------------------------------", new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(25, ypos));

            e.Graphics.DrawString("Total : " + txtTotalAll.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(620, ypos + 30));
            e.Graphics.DrawString("Bayar : " + txtBayar.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(620, ypos+80));
            e.Graphics.DrawString("Kembalian : " + txtKembalian.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(600, ypos+110));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DVPrintPreviewDialog.Document = DVPrintDocument;
            DVPrintPreviewDialog.ShowDialog();
        }
    }
}
