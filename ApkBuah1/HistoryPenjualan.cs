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
    public partial class HistoryPenjualan : Form
    {
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private DataSet ds;

        Koneksi koneksi = new Koneksi();
        public HistoryPenjualan()
        {
            InitializeComponent();
        }

        void ShowData()
        {
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from tbl_penjualan join tbl_barang on tbl_penjualan.Kode_Barang = tbl_barang.KodeBrg", conn);
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["NoNota"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["Kode_Barang"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["NamaBrg"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["HargaBrg"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["Jumlah"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = Convert.ToInt32(item["HargaBrg"]) * Convert.ToInt32(item["Jumlah"]);

            }
            conn.Close();
        }

        void FoundData()
        {
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from tbl_penjualan join tbl_barang on tbl_penjualan.Kode_Barang = tbl_barang.KodeBrg where tbl_penjualan.NoNota = '" + tstSeacrh.Text+"'", conn);
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["NoNota"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["Kode_Barang"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["NamaBrg"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["HargaBrg"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["Jumlah"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = Convert.ToInt32(item["HargaBrg"]) * Convert.ToInt32(item["Jumlah"]);

            }
            conn.Close();
        }

        void TotalAll()
        {
            try
            {
                int total = 0;
                for(int i =0; i<dataGridView1.Rows.Count; i++)
                {
                    total += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                }
                txtTotalAll.Text = total.ToString();
            }
            catch
            {
                txtTotalAll.Text = "0";
            }
        }

        void ClearText()
        {
            txtKodePlg.Clear();
            txtNamaPlg.Clear();
            txtPhonePlg.Clear();
            txtAlamatPlg.Clear();

        }
        private void HistoryPenjualan_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            ShowData();
            TotalAll();
        }

        private void tstSeacrh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                SqlConnection conn = koneksi.GetConn();
                conn.Open();

                cmd = new SqlCommand("select * from tbl_penjualan left join tbl_pelanggan on tbl_penjualan.Kode_Pelanggan = tbl_pelanggan.KodePlg where tbl_penjualan.NoNota = '"+tstSeacrh.Text+"'", conn);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {

                    dataGridView1.Rows.Clear();
                    FoundData();
                    TotalAll();

                    if ((string)dr["Kode_Pelanggan"] == "")
                    {
                      txtKodePlg.Text = "Tidak Ada Data Pelanggan";
                      
                    }
                    else if((string)dr["kode_pelanggan"] != "")
                    {
                        txtKodePlg.Text = (string)dr["KodePlg"];
                        txtNamaPlg.Text = (string)dr["NamaPlg"];
                        txtPhonePlg.Text = (string)dr["PhonePlg"];
                        txtAlamatPlg.Text = (string)dr["AlamatPlg"];

                    }
                }
                else
                {
                    MessageBox.Show("Data Tidak Ditemukan");
                    dataGridView1.Rows.Clear();
                    ShowData();
                    ClearText();
                    TotalAll();

                }
            }
        }

        private void tstSeacrh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKodePlg_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void DVPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("NOTA TRSANSAKSI PENJUALAN TOKO BUAH ZEGAARRR", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(20, 0));
            e.Graphics.DrawString("Nama Pelanggan : " + txtNamaPlg.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(25, 80));
            e.Graphics.DrawString("No Hp Pelanggan : " + txtPhonePlg.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(25, 110));
            e.Graphics.DrawString("Alamat Pelanggan : " + txtAlamatPlg.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(25, 140));

            e.Graphics.DrawString("No Nota : " + tstSeacrh.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(25, 180));

            e.Graphics.DrawString("---------------------------------------------------------------------------", new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(25, 230));
            e.Graphics.DrawString("Barang", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, 260));
            e.Graphics.DrawString("Harga", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(300, 260));
            e.Graphics.DrawString("Jumlah", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(480, 260));
            e.Graphics.DrawString("Total", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(680, 260));
            e.Graphics.DrawString("----------------------------------------------------------------------------", new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(25, 280));

            int ypos = 325;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                e.Graphics.DrawString((string)dataGridView1.Rows[i].Cells[2].Value, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(30, ypos));
                e.Graphics.DrawString((string)dataGridView1.Rows[i].Cells[3].Value, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(300, ypos));
                e.Graphics.DrawString((string)dataGridView1.Rows[i].Cells[4].Value, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(480, ypos));
                e.Graphics.DrawString((string)dataGridView1.Rows[i].Cells[5].Value.ToString(), new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(680, ypos));

                ypos += 30;
            }
            e.Graphics.DrawString("----------------------------------------------------------------------------", new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(25, ypos));

            e.Graphics.DrawString("Total : " + txtTotalAll.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(620, ypos + 30));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DVPrintPreviewDialog.Document = DVPrintDocument;
            DVPrintPreviewDialog.ShowDialog();
        }
    }
}
