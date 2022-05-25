namespace ApkBuah1
{
    partial class FormPelanggan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPelanggan));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtAlamatPlg = new System.Windows.Forms.TextBox();
            this.txtPhonePlg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNamaPlg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKodePlg = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.ErrorKode = new System.Windows.Forms.Label();
            this.ErrorNama = new System.Windows.Forms.Label();
            this.ErrorPhone = new System.Windows.Forms.Label();
            this.ErrorAlamat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(883, 573);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 39);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(702, 573);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 39);
            this.btnUpdate.TabIndex = 40;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(536, 573);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(92, 39);
            this.btnInput.TabIndex = 39;
            this.btnInput.Text = "Input";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(883, 510);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 39);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtAlamatPlg
            // 
            this.txtAlamatPlg.Enabled = false;
            this.txtAlamatPlg.Location = new System.Drawing.Point(702, 448);
            this.txtAlamatPlg.Name = "txtAlamatPlg";
            this.txtAlamatPlg.Size = new System.Drawing.Size(273, 26);
            this.txtAlamatPlg.TabIndex = 37;
            // 
            // txtPhonePlg
            // 
            this.txtPhonePlg.Enabled = false;
            this.txtPhonePlg.Location = new System.Drawing.Point(702, 387);
            this.txtPhonePlg.Name = "txtPhonePlg";
            this.txtPhonePlg.Size = new System.Drawing.Size(273, 26);
            this.txtPhonePlg.TabIndex = 36;
            this.txtPhonePlg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhonePlg_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(577, 451);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Alamat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(577, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Phone";
            // 
            // txtNamaPlg
            // 
            this.txtNamaPlg.Enabled = false;
            this.txtNamaPlg.Location = new System.Drawing.Point(138, 448);
            this.txtNamaPlg.Name = "txtNamaPlg";
            this.txtNamaPlg.Size = new System.Drawing.Size(273, 26);
            this.txtNamaPlg.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Kode";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(946, 258);
            this.dataGridView1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "FORM PELANGGAN";
            // 
            // txtKodePlg
            // 
            this.txtKodePlg.Enabled = false;
            this.txtKodePlg.Location = new System.Drawing.Point(138, 393);
            this.txtKodePlg.Name = "txtKodePlg";
            this.txtKodePlg.Size = new System.Drawing.Size(273, 26);
            this.txtKodePlg.TabIndex = 23;
            this.txtKodePlg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKodePlg_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(702, 510);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 39);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ErrorKode
            // 
            this.ErrorKode.AutoSize = true;
            this.ErrorKode.ForeColor = System.Drawing.Color.Red;
            this.ErrorKode.Location = new System.Drawing.Point(417, 396);
            this.ErrorKode.Name = "ErrorKode";
            this.ErrorKode.Size = new System.Drawing.Size(13, 20);
            this.ErrorKode.TabIndex = 42;
            this.ErrorKode.Text = "!";
            this.ErrorKode.Visible = false;
            // 
            // ErrorNama
            // 
            this.ErrorNama.AutoSize = true;
            this.ErrorNama.ForeColor = System.Drawing.Color.Red;
            this.ErrorNama.Location = new System.Drawing.Point(417, 451);
            this.ErrorNama.Name = "ErrorNama";
            this.ErrorNama.Size = new System.Drawing.Size(13, 20);
            this.ErrorNama.TabIndex = 43;
            this.ErrorNama.Text = "!";
            this.ErrorNama.Visible = false;
            // 
            // ErrorPhone
            // 
            this.ErrorPhone.AutoSize = true;
            this.ErrorPhone.ForeColor = System.Drawing.Color.Red;
            this.ErrorPhone.Location = new System.Drawing.Point(975, 390);
            this.ErrorPhone.Name = "ErrorPhone";
            this.ErrorPhone.Size = new System.Drawing.Size(13, 20);
            this.ErrorPhone.TabIndex = 44;
            this.ErrorPhone.Text = "!";
            this.ErrorPhone.Visible = false;
            // 
            // ErrorAlamat
            // 
            this.ErrorAlamat.AutoSize = true;
            this.ErrorAlamat.ForeColor = System.Drawing.Color.Red;
            this.ErrorAlamat.Location = new System.Drawing.Point(975, 451);
            this.ErrorAlamat.Name = "ErrorAlamat";
            this.ErrorAlamat.Size = new System.Drawing.Size(13, 20);
            this.ErrorAlamat.TabIndex = 45;
            this.ErrorAlamat.Text = "!";
            this.ErrorAlamat.Visible = false;
            // 
            // FormPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 649);
            this.Controls.Add(this.ErrorAlamat);
            this.Controls.Add(this.ErrorPhone);
            this.Controls.Add(this.ErrorNama);
            this.Controls.Add(this.ErrorKode);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtAlamatPlg);
            this.Controls.Add(this.txtPhonePlg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNamaPlg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKodePlg);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPelanggan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPelanggan";
            this.Load += new System.EventHandler(this.FormPelanggan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtAlamatPlg;
        private System.Windows.Forms.TextBox txtPhonePlg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNamaPlg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKodePlg;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label ErrorKode;
        private System.Windows.Forms.Label ErrorNama;
        private System.Windows.Forms.Label ErrorPhone;
        private System.Windows.Forms.Label ErrorAlamat;
    }
}