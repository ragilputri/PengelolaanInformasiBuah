namespace ApkBuah1
{
    partial class FormSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSupplier));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtDescSup = new System.Windows.Forms.TextBox();
            this.txtAlamatSup = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhoneSup = new System.Windows.Forms.TextBox();
            this.txtNamaSup = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKodeSup = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.ErrorKode = new System.Windows.Forms.Label();
            this.ErrorNama = new System.Windows.Forms.Label();
            this.ErrorPhone = new System.Windows.Forms.Label();
            this.ErrorAlamat = new System.Windows.Forms.Label();
            this.ErrorDesc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(883, 569);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 39);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(702, 569);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 39);
            this.btnUpdate.TabIndex = 40;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(536, 569);
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
            this.btnCancel.Location = new System.Drawing.Point(883, 506);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 39);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtDescSup
            // 
            this.txtDescSup.Enabled = false;
            this.txtDescSup.Location = new System.Drawing.Point(702, 448);
            this.txtDescSup.Name = "txtDescSup";
            this.txtDescSup.Size = new System.Drawing.Size(273, 26);
            this.txtDescSup.TabIndex = 37;
            // 
            // txtAlamatSup
            // 
            this.txtAlamatSup.Enabled = false;
            this.txtAlamatSup.Location = new System.Drawing.Point(702, 387);
            this.txtAlamatSup.Name = "txtAlamatSup";
            this.txtAlamatSup.Size = new System.Drawing.Size(273, 26);
            this.txtAlamatSup.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(577, 451);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Desc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(577, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Alamat";
            // 
            // txtPhoneSup
            // 
            this.txtPhoneSup.Enabled = false;
            this.txtPhoneSup.Location = new System.Drawing.Point(138, 506);
            this.txtPhoneSup.Name = "txtPhoneSup";
            this.txtPhoneSup.Size = new System.Drawing.Size(273, 26);
            this.txtPhoneSup.TabIndex = 31;
            this.txtPhoneSup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneSup_KeyPress);
            // 
            // txtNamaSup
            // 
            this.txtNamaSup.Enabled = false;
            this.txtNamaSup.Location = new System.Drawing.Point(138, 448);
            this.txtNamaSup.Name = "txtNamaSup";
            this.txtNamaSup.Size = new System.Drawing.Size(273, 26);
            this.txtNamaSup.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 506);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Phone";
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
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "FORM SUPPLIER";
            // 
            // txtKodeSup
            // 
            this.txtKodeSup.Enabled = false;
            this.txtKodeSup.Location = new System.Drawing.Point(138, 393);
            this.txtKodeSup.Name = "txtKodeSup";
            this.txtKodeSup.Size = new System.Drawing.Size(273, 26);
            this.txtKodeSup.TabIndex = 23;
            this.txtKodeSup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKodeSup_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(702, 506);
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
            this.ErrorNama.Location = new System.Drawing.Point(417, 448);
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
            this.ErrorPhone.Location = new System.Drawing.Point(417, 506);
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
            this.ErrorAlamat.Location = new System.Drawing.Point(981, 390);
            this.ErrorAlamat.Name = "ErrorAlamat";
            this.ErrorAlamat.Size = new System.Drawing.Size(13, 20);
            this.ErrorAlamat.TabIndex = 45;
            this.ErrorAlamat.Text = "!";
            this.ErrorAlamat.Visible = false;
            // 
            // ErrorDesc
            // 
            this.ErrorDesc.AutoSize = true;
            this.ErrorDesc.ForeColor = System.Drawing.Color.Red;
            this.ErrorDesc.Location = new System.Drawing.Point(981, 451);
            this.ErrorDesc.Name = "ErrorDesc";
            this.ErrorDesc.Size = new System.Drawing.Size(13, 20);
            this.ErrorDesc.TabIndex = 46;
            this.ErrorDesc.Text = "!";
            this.ErrorDesc.Visible = false;
            // 
            // FormSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 654);
            this.Controls.Add(this.ErrorDesc);
            this.Controls.Add(this.ErrorAlamat);
            this.Controls.Add(this.ErrorPhone);
            this.Controls.Add(this.ErrorNama);
            this.Controls.Add(this.ErrorKode);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtDescSup);
            this.Controls.Add(this.txtAlamatSup);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPhoneSup);
            this.Controls.Add(this.txtNamaSup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKodeSup);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSupplier";
            this.Load += new System.EventHandler(this.FormSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtDescSup;
        private System.Windows.Forms.TextBox txtAlamatSup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhoneSup;
        private System.Windows.Forms.TextBox txtNamaSup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKodeSup;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label ErrorKode;
        private System.Windows.Forms.Label ErrorNama;
        private System.Windows.Forms.Label ErrorPhone;
        private System.Windows.Forms.Label ErrorAlamat;
        private System.Windows.Forms.Label ErrorDesc;
    }
}