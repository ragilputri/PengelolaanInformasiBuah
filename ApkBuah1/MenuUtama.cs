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
    public partial class MenuUtama : Form
    {
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private DataSet ds;

        Koneksi koneksi = new Koneksi();
        public static MenuUtama menu;
        public MenuUtama()
        {
            InitializeComponent();
        }

        void MenuTerkunci()
        {
            panelterkunci.Visible = true;
            PanelTransaksi.Visible = false;
            PanelHistory.Visible = false;
            panelMaster.Visible = false;
            PanelLogin.Visible = false;

            LDataMaster.Visible = false;
            Lhistory.Visible = false;
            Ltransaksi.Visible = false;

            menu = this;

        }

        private void MenuUtama_Load(object sender, EventArgs e)
        {
            MenuTerkunci();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void signInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registrasi rg = new Registrasi();
            rg.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  logoutToolStripMenuItem.Enabled = false;
          //  manageToolStripMenuItem.Enabled = false;
          //  transactionToolStripMenuItem.Enabled = false;
          //  historyToolStripMenuItem.Enabled = false;
          //  loginToolStripMenuItem.Enabled = true;
          //  signInToolStripMenuItem.Enabled = true;
          //  Snama.Text = "";
        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBarang barang = new FormBarang();
            barang.ShowDialog();
        }

        private void pelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPelanggan plg = new FormPelanggan();
            plg.ShowDialog();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSupplier sup = new FormSupplier();
            sup.ShowDialog();
        }

        private void penjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPenjualan penjualan = new FormPenjualan();
            penjualan.ShowDialog();
        }

        private void pembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPembelian pembelian = new FormPembelian();
            pembelian.ShowDialog();
        }

        private void transaksiPenjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryPenjualan hpenjualan = new HistoryPenjualan();
            hpenjualan.ShowDialog();
        }

        private void transaksiPembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryPembelian hp = new HistoryPembelian();
            hp.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Registrasi rg = new Registrasi();
            rg.ShowDialog();
        }

        private void btnDataMaster_Click(object sender, EventArgs e)
        {
            if(PanelLogin.Visible == true)
            {
                LDataMaster.Visible = true;
                Ltransaksi.Visible = false;
                Lhistory.Visible = false;

                panelMaster.Visible = true;
                PanelTransaksi.Visible = false;
                PanelHistory.Visible = false;
                panelterkunci.Visible = false;
            }
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            if (PanelLogin.Visible == true)
            {
                LDataMaster.Visible = false;
                Ltransaksi.Visible = true;
                Lhistory.Visible = false;

                panelMaster.Visible = true;
                PanelTransaksi.Visible = true;
                PanelHistory.Visible = false;
                panelterkunci.Visible = false;
            }
        }

        private void btnhistory_Click(object sender, EventArgs e)
        {
            if (PanelLogin.Visible == true)
            {
                LDataMaster.Visible = false;
                Ltransaksi.Visible = false;
                Lhistory.Visible = true;

                panelMaster.Visible = false;
                PanelTransaksi.Visible = false;
                PanelHistory.Visible = true;
                panelterkunci.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LDataMaster.Visible = false;
            Ltransaksi.Visible = false;
            Lhistory.Visible = false;

            panelMaster.Visible = false;
            PanelTransaksi.Visible = false;
            PanelHistory.Visible = false;
            panelterkunci.Visible = true;
            PanelLogin.Visible = false;

            bnLogin.Enabled = true;
            btnsignin.Enabled = true;
        }

        private void btnBarang_Click(object sender, EventArgs e)
        {
            FormBarang brg = new FormBarang();
            brg.ShowDialog();
        }

        private void btnPelanggan_Click(object sender, EventArgs e)
        {
            FormPelanggan plg = new FormPelanggan();
            plg.ShowDialog();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            FormSupplier sup = new FormSupplier();
            sup.ShowDialog();
        }

        private void btnPenjualan_Click(object sender, EventArgs e)
        {
            FormPenjualan pj = new FormPenjualan();
            pj.ShowDialog();
        }

        private void btnPembelian_Click(object sender, EventArgs e)
        {
            FormPembelian fb = new FormPembelian();
            fb.ShowDialog();
        }

        private void btnHisPenjualan_Click(object sender, EventArgs e)
        {
            HistoryPenjualan hpj = new HistoryPenjualan();
            hpj.ShowDialog();
        }

        private void btnHisPembelian_Click(object sender, EventArgs e)
        {
            HistoryPembelian hp = new HistoryPembelian();
            hp.ShowDialog();
        }
    }
}
