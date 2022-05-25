namespace ApkBuah1
{
    partial class FormBarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBarang));
            this.btnSave = new System.Windows.Forms.Button();
            this.txtKodeBrg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNamaBrg = new System.Windows.Forms.TextBox();
            this.txtMerkBrg = new System.Windows.Forms.TextBox();
            this.txtSatuan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHargaBrg = new System.Windows.Forms.TextBox();
            this.txtJumlahBrg = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dateExp = new System.Windows.Forms.DateTimePicker();
            this.ErrorKode = new System.Windows.Forms.Label();
            this.ErrorNama = new System.Windows.Forms.Label();
            this.ErrorMrk = new System.Windows.Forms.Label();
            this.ErrorSatuan = new System.Windows.Forms.Label();
            this.ErrorHarga = new System.Windows.Forms.Label();
            this.errorJumlah = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(698, 567);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 39);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtKodeBrg
            // 
            this.txtKodeBrg.Enabled = false;
            this.txtKodeBrg.Location = new System.Drawing.Point(134, 393);
            this.txtKodeBrg.Name = "txtKodeBrg";
            this.txtKodeBrg.Size = new System.Drawing.Size(273, 26);
            this.txtKodeBrg.TabIndex = 1;
            this.txtKodeBrg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKodeBrg_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "FORM BARANG";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(946, 258);
            this.dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 506);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Merk";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 567);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Satuan";
            // 
            // txtNamaBrg
            // 
            this.txtNamaBrg.Enabled = false;
            this.txtNamaBrg.Location = new System.Drawing.Point(134, 448);
            this.txtNamaBrg.Name = "txtNamaBrg";
            this.txtNamaBrg.Size = new System.Drawing.Size(273, 26);
            this.txtNamaBrg.TabIndex = 8;
            // 
            // txtMerkBrg
            // 
            this.txtMerkBrg.Enabled = false;
            this.txtMerkBrg.Location = new System.Drawing.Point(134, 506);
            this.txtMerkBrg.Name = "txtMerkBrg";
            this.txtMerkBrg.Size = new System.Drawing.Size(273, 26);
            this.txtMerkBrg.TabIndex = 9;
            // 
            // txtSatuan
            // 
            this.txtSatuan.Enabled = false;
            this.txtSatuan.Location = new System.Drawing.Point(134, 567);
            this.txtSatuan.Name = "txtSatuan";
            this.txtSatuan.Size = new System.Drawing.Size(273, 26);
            this.txtSatuan.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(573, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Harga";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(573, 451);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Jumlah";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(573, 509);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tgl Exp";
            // 
            // txtHargaBrg
            // 
            this.txtHargaBrg.Enabled = false;
            this.txtHargaBrg.Location = new System.Drawing.Point(698, 387);
            this.txtHargaBrg.Name = "txtHargaBrg";
            this.txtHargaBrg.Size = new System.Drawing.Size(273, 26);
            this.txtHargaBrg.TabIndex = 14;
            this.txtHargaBrg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHargaBrg_KeyPress);
            // 
            // txtJumlahBrg
            // 
            this.txtJumlahBrg.Enabled = false;
            this.txtJumlahBrg.Location = new System.Drawing.Point(698, 448);
            this.txtJumlahBrg.Name = "txtJumlahBrg";
            this.txtJumlahBrg.Size = new System.Drawing.Size(273, 26);
            this.txtJumlahBrg.TabIndex = 15;
            this.txtJumlahBrg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJumlahBrg_KeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(879, 567);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 39);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(532, 630);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(92, 39);
            this.btnInput.TabIndex = 18;
            this.btnInput.Text = "Input";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(698, 630);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 39);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(879, 630);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 39);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dateExp
            // 
            this.dateExp.Enabled = false;
            this.dateExp.Location = new System.Drawing.Point(698, 509);
            this.dateExp.Name = "dateExp";
            this.dateExp.Size = new System.Drawing.Size(273, 26);
            this.dateExp.TabIndex = 21;
            // 
            // ErrorKode
            // 
            this.ErrorKode.AutoSize = true;
            this.ErrorKode.ForeColor = System.Drawing.Color.Red;
            this.ErrorKode.Location = new System.Drawing.Point(413, 396);
            this.ErrorKode.Name = "ErrorKode";
            this.ErrorKode.Size = new System.Drawing.Size(13, 20);
            this.ErrorKode.TabIndex = 22;
            this.ErrorKode.Text = "!";
            this.ErrorKode.Visible = false;
            // 
            // ErrorNama
            // 
            this.ErrorNama.AutoSize = true;
            this.ErrorNama.ForeColor = System.Drawing.Color.Red;
            this.ErrorNama.Location = new System.Drawing.Point(413, 451);
            this.ErrorNama.Name = "ErrorNama";
            this.ErrorNama.Size = new System.Drawing.Size(13, 20);
            this.ErrorNama.TabIndex = 23;
            this.ErrorNama.Text = "!";
            this.ErrorNama.Visible = false;
            // 
            // ErrorMrk
            // 
            this.ErrorMrk.AutoSize = true;
            this.ErrorMrk.ForeColor = System.Drawing.Color.Red;
            this.ErrorMrk.Location = new System.Drawing.Point(413, 506);
            this.ErrorMrk.Name = "ErrorMrk";
            this.ErrorMrk.Size = new System.Drawing.Size(13, 20);
            this.ErrorMrk.TabIndex = 24;
            this.ErrorMrk.Text = "!";
            this.ErrorMrk.Visible = false;
            // 
            // ErrorSatuan
            // 
            this.ErrorSatuan.AutoSize = true;
            this.ErrorSatuan.ForeColor = System.Drawing.Color.Red;
            this.ErrorSatuan.Location = new System.Drawing.Point(413, 570);
            this.ErrorSatuan.Name = "ErrorSatuan";
            this.ErrorSatuan.Size = new System.Drawing.Size(13, 20);
            this.ErrorSatuan.TabIndex = 25;
            this.ErrorSatuan.Text = "!";
            this.ErrorSatuan.Visible = false;
            // 
            // ErrorHarga
            // 
            this.ErrorHarga.AutoSize = true;
            this.ErrorHarga.ForeColor = System.Drawing.Color.Red;
            this.ErrorHarga.Location = new System.Drawing.Point(977, 390);
            this.ErrorHarga.Name = "ErrorHarga";
            this.ErrorHarga.Size = new System.Drawing.Size(13, 20);
            this.ErrorHarga.TabIndex = 26;
            this.ErrorHarga.Text = "!";
            this.ErrorHarga.Visible = false;
            // 
            // errorJumlah
            // 
            this.errorJumlah.AutoSize = true;
            this.errorJumlah.ForeColor = System.Drawing.Color.Red;
            this.errorJumlah.Location = new System.Drawing.Point(977, 451);
            this.errorJumlah.Name = "errorJumlah";
            this.errorJumlah.Size = new System.Drawing.Size(13, 20);
            this.errorJumlah.TabIndex = 27;
            this.errorJumlah.Text = "!";
            this.errorJumlah.Visible = false;
            // 
            // FormBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 695);
            this.Controls.Add(this.errorJumlah);
            this.Controls.Add(this.ErrorHarga);
            this.Controls.Add(this.ErrorSatuan);
            this.Controls.Add(this.ErrorMrk);
            this.Controls.Add(this.ErrorNama);
            this.Controls.Add(this.ErrorKode);
            this.Controls.Add(this.dateExp);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtJumlahBrg);
            this.Controls.Add(this.txtHargaBrg);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSatuan);
            this.Controls.Add(this.txtMerkBrg);
            this.Controls.Add(this.txtNamaBrg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKodeBrg);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBarang";
            this.Load += new System.EventHandler(this.FormBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtKodeBrg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNamaBrg;
        private System.Windows.Forms.TextBox txtMerkBrg;
        private System.Windows.Forms.TextBox txtSatuan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHargaBrg;
        private System.Windows.Forms.TextBox txtJumlahBrg;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DateTimePicker dateExp;
        private System.Windows.Forms.Label ErrorKode;
        private System.Windows.Forms.Label ErrorNama;
        private System.Windows.Forms.Label ErrorMrk;
        private System.Windows.Forms.Label ErrorSatuan;
        private System.Windows.Forms.Label ErrorHarga;
        private System.Windows.Forms.Label errorJumlah;
    }
}