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
    public partial class HistoryPembelian : Form
    {
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private DataSet ds;

        Koneksi koneksi = new Koneksi();

        public HistoryPembelian()
        {
            InitializeComponent();
        }

        void ShowData()
        {
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from tbl_pembelian join tbl_barang on tbl_pembelian.Kode_Barang = tbl_barang.KodeBrg", conn);
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["NoFaktur"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["Kode_Barang"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["NamaBrg"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["HargaBeli"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["JumlahBeli"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = Convert.ToInt32(item["HargaBeli"]) * Convert.ToInt32(item["JumlahBeli"]);

            }
            conn.Close();
        }

        void FoundData()
        {
            SqlConnection conn = koneksi.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from tbl_pembelian join tbl_barang on tbl_pembelian.Kode_Barang = tbl_barang.KodeBrg where tbl_pembelian.NoFaktur = '" + tstSeacrh.Text + "'", conn);
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["NoFaktur"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["Kode_Barang"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["NamaBrg"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["HargaBeli"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["JumlahBeli"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = Convert.ToInt32(item["HargaBeli"]) * Convert.ToInt32(item["JumlahBeli"]);

            }
            conn.Close();
        }

        void ClearText()
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
                int total = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
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

        private void HistoryPembelian_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            ShowData();
            TotalAll();
        }

        private void tstSeacrh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SqlConnection conn = koneksi.GetConn();
                conn.Open();

                cmd = new SqlCommand("select * from tbl_pembelian join tbl_supplier on tbl_pembelian.Kode_Supplier = tbl_supplier.KodeSup where tbl_pembelian.NoFaktur = '" + tstSeacrh.Text + "'", conn);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {

                    dataGridView1.Rows.Clear();
                    FoundData();
                    txtKodeSup.Text = (string)dr["KodeSup"];
                    txtNamaSup.Text = (string)dr["NamaSup"];
                    txtPhoneSup.Text = (string)dr["PhoneSup"];
                    txtAlamatSup.Text = (string)dr["AlamatSup"];
                    txtDescSup.Text = (string)dr["DescSup"];
                    TotalAll();
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

        private void DVPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("NOTA TRSANSAKSI PEMBELIAN TOKO BUAH ZEGAARRR", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(20, 0));
            e.Graphics.DrawString("Nama Supplier : " + txtNamaSup.Text + "-" + txtDescSup.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(25, 80));
            e.Graphics.DrawString("No Hp Supplier : " + txtPhoneSup.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(25, 110));
            e.Graphics.DrawString("Alamat Supplier : " + txtAlamatSup.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(25, 140));

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
