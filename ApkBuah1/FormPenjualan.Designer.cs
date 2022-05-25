namespace ApkBuah1
{
    partial class FormPenjualan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPenjualan));
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKodePlg = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LinkPelanggan = new System.Windows.Forms.LinkLabel();
            this.txtPhonePlg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAlamatPlg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNamaPlg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNoNota = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKodeBrg = new System.Windows.Forms.TextBox();
            this.txtNamaBrg = new System.Windows.Forms.TextBox();
            this.txtMerkBrg = new System.Windows.Forms.TextBox();
            this.txtHargaBrg = new System.Windows.Forms.TextBox();
            this.txtJumlahBrg = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTotalAll = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtKembalian = new System.Windows.Forms.TextBox();
            this.txtBayar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DVPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.DVPrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(851, 633);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 33);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "FORM PENJUALAN";
            // 
            // txtKodePlg
            // 
            this.txtKodePlg.Location = new System.Drawing.Point(28, 65);
            this.txtKodePlg.Name = "txtKodePlg";
            this.txtKodePlg.Size = new System.Drawing.Size(228, 26);
            this.txtKodePlg.TabIndex = 2;
            this.txtKodePlg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKodePlg_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(432, 270);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(504, 201);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Kode";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nama";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Merk";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Harga";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Jumlah";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Total";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Action";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column7.Text = "Delete";
            this.Column7.UseColumnTextForButtonValue = true;
            this.Column7.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kode";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LinkPelanggan);
            this.groupBox1.Controls.Add(this.txtPhonePlg);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAlamatPlg);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNamaPlg);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtKodePlg);
            this.groupBox1.Location = new System.Drawing.Point(29, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(913, 180);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pelanggan";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LinkPelanggan
            // 
            this.LinkPelanggan.AutoSize = true;
            this.LinkPelanggan.Location = new System.Drawing.Point(24, 125);
            this.LinkPelanggan.Name = "LinkPelanggan";
            this.LinkPelanggan.Size = new System.Drawing.Size(160, 20);
            this.LinkPelanggan.TabIndex = 11;
            this.LinkPelanggan.TabStop = true;
            this.LinkPelanggan.Text = "Don\'t Have Account?";
            this.LinkPelanggan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkPelanggan_LinkClicked);
            // 
            // txtPhonePlg
            // 
            this.txtPhonePlg.Location = new System.Drawing.Point(358, 139);
            this.txtPhonePlg.Name = "txtPhonePlg";
            this.txtPhonePlg.Size = new System.Drawing.Size(228, 26);
            this.txtPhonePlg.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(675, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Alamat";
            // 
            // txtAlamatPlg
            // 
            this.txtAlamatPlg.Location = new System.Drawing.Point(679, 65);
            this.txtAlamatPlg.Name = "txtAlamatPlg";
            this.txtAlamatPlg.Size = new System.Drawing.Size(228, 26);
            this.txtAlamatPlg.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nama";
            // 
            // txtNamaPlg
            // 
            this.txtNamaPlg.Location = new System.Drawing.Point(358, 65);
            this.txtNamaPlg.Name = "txtNamaPlg";
            this.txtNamaPlg.Size = new System.Drawing.Size(228, 26);
            this.txtNamaPlg.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kode";
            // 
            // txtNoNota
            // 
            this.txtNoNota.Enabled = false;
            this.txtNoNota.Location = new System.Drawing.Point(29, 269);
            this.txtNoNota.Name = "txtNoNota";
            this.txtNoNota.Size = new System.Drawing.Size(183, 26);
            this.txtNoNota.TabIndex = 12;
            // 
            // txtDate
            // 
            this.txtDate.Enabled = false;
            this.txtDate.Location = new System.Drawing.Point(218, 269);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(183, 26);
            this.txtDate.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nama";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Merk";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 465);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Harga";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 510);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Jumlah";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 556);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Total";
            // 
            // txtKodeBrg
            // 
            this.txtKodeBrg.Location = new System.Drawing.Point(134, 318);
            this.txtKodeBrg.Name = "txtKodeBrg";
            this.txtKodeBrg.Size = new System.Drawing.Size(228, 26);
            this.txtKodeBrg.TabIndex = 12;
            this.txtKodeBrg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKodeBrg_KeyPress);
            // 
            // txtNamaBrg
            // 
            this.txtNamaBrg.Location = new System.Drawing.Point(134, 367);
            this.txtNamaBrg.Name = "txtNamaBrg";
            this.txtNamaBrg.Size = new System.Drawing.Size(228, 26);
            this.txtNamaBrg.TabIndex = 19;
            // 
            // txtMerkBrg
            // 
            this.txtMerkBrg.Location = new System.Drawing.Point(134, 414);
            this.txtMerkBrg.Name = "txtMerkBrg";
            this.txtMerkBrg.Size = new System.Drawing.Size(228, 26);
            this.txtMerkBrg.TabIndex = 20;
            // 
            // txtHargaBrg
            // 
            this.txtHargaBrg.Location = new System.Drawing.Point(134, 465);
            this.txtHargaBrg.Name = "txtHargaBrg";
            this.txtHargaBrg.Size = new System.Drawing.Size(228, 26);
            this.txtHargaBrg.TabIndex = 21;
            // 
            // txtJumlahBrg
            // 
            this.txtJumlahBrg.Location = new System.Drawing.Point(134, 510);
            this.txtJumlahBrg.Name = "txtJumlahBrg";
            this.txtJumlahBrg.Size = new System.Drawing.Size(228, 26);
            this.txtJumlahBrg.TabIndex = 22;
            this.txtJumlahBrg.TextChanged += new System.EventHandler(this.txtJumlahBrg_TextChanged);
            this.txtJumlahBrg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJumlahBrg_KeyPress);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(134, 556);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(228, 26);
            this.txtTotal.TabIndex = 23;
            // 
            // txtTotalAll
            // 
            this.txtTotalAll.Location = new System.Drawing.Point(623, 493);
            this.txtTotalAll.Name = "txtTotalAll";
            this.txtTotalAll.Size = new System.Drawing.Size(313, 26);
            this.txtTotalAll.TabIndex = 24;
            this.txtTotalAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(441, 496);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Total";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(708, 633);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 33);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtKembalian
            // 
            this.txtKembalian.Location = new System.Drawing.Point(708, 588);
            this.txtKembalian.Name = "txtKembalian";
            this.txtKembalian.Size = new System.Drawing.Size(228, 26);
            this.txtKembalian.TabIndex = 12;
            this.txtKembalian.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBayar
            // 
            this.txtBayar.Location = new System.Drawing.Point(445, 588);
            this.txtBayar.Name = "txtBayar";
            this.txtBayar.Size = new System.Drawing.Size(228, 26);
            this.txtBayar.TabIndex = 27;
            this.txtBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBayar.TextChanged += new System.EventHandler(this.txtBayar_TextChanged);
            this.txtBayar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBayar_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(447, 562);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "Nominal";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(704, 565);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 20);
            this.label14.TabIndex = 28;
            this.label14.Text = "Kembalian";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(432, 525);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(515, 159);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pembayaran";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DVPrintDocument
            // 
            this.DVPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.DVPrintDocument_PrintPage);
            // 
            // DVPrintPreviewDialog
            // 
            this.DVPrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.DVPrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.DVPrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.DVPrintPreviewDialog.Enabled = true;
            this.DVPrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("DVPrintPreviewDialog.Icon")));
            this.DVPrintPreviewDialog.Name = "DVPrintPreviewDialog";
            this.DVPrintPreviewDialog.Visible = false;
            // 
            // FormPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 696);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtBayar);
            this.Controls.Add(this.txtKembalian);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTotalAll);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtJumlahBrg);
            this.Controls.Add(this.txtHargaBrg);
            this.Controls.Add(this.txtMerkBrg);
            this.Controls.Add(this.txtNamaBrg);
            this.Controls.Add(this.txtKodeBrg);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtNoNota);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPenjualan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPenjualan";
            this.Load += new System.EventHandler(this.FormPenjualan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKodePlg;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel LinkPelanggan;
        private System.Windows.Forms.TextBox txtPhonePlg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAlamatPlg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNamaPlg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNoNota;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtKodeBrg;
        private System.Windows.Forms.TextBox txtNamaBrg;
        private System.Windows.Forms.TextBox txtMerkBrg;
        private System.Windows.Forms.TextBox txtHargaBrg;
        private System.Windows.Forms.TextBox txtJumlahBrg;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTotalAll;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtKembalian;
        private System.Windows.Forms.TextBox txtBayar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Drawing.Printing.PrintDocument DVPrintDocument;
        private System.Windows.Forms.PrintPreviewDialog DVPrintPreviewDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
    }
}