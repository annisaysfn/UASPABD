
namespace UASPABD
{
    partial class FormPemasukan
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textHarga = new System.Windows.Forms.TextBox();
            this.textKet = new System.Windows.Forms.TextBox();
            this.combKategori = new System.Windows.Forms.ComboBox();
            this.dtTanggal = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textCari = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idpemasukanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keteranganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pemasukanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uASPABDDataSet = new UASPABD.UASPABDDataSet();
            this.btnTambah = new System.Windows.Forms.Button();
            this.pemasukanTableAdapter = new UASPABD.UASPABDDataSetTableAdapters.PemasukanTableAdapter();
            this.btnTotal = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemasukanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uASPABDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pemasukan Toko";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textHarga);
            this.groupBox1.Controls.Add(this.textKet);
            this.groupBox1.Controls.Add(this.combKategori);
            this.groupBox1.Controls.Add(this.dtTanggal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(65, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 260);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Pemasukan";
            // 
            // textHarga
            // 
            this.textHarga.Location = new System.Drawing.Point(152, 177);
            this.textHarga.Name = "textHarga";
            this.textHarga.Size = new System.Drawing.Size(200, 26);
            this.textHarga.TabIndex = 9;
            // 
            // textKet
            // 
            this.textKet.Location = new System.Drawing.Point(152, 137);
            this.textKet.Name = "textKet";
            this.textKet.Size = new System.Drawing.Size(200, 26);
            this.textKet.TabIndex = 8;
            // 
            // combKategori
            // 
            this.combKategori.FormattingEnabled = true;
            this.combKategori.Location = new System.Drawing.Point(152, 97);
            this.combKategori.Name = "combKategori";
            this.combKategori.Size = new System.Drawing.Size(146, 28);
            this.combKategori.TabIndex = 7;
            // 
            // dtTanggal
            // 
            this.dtTanggal.CustomFormat = "MM-dd-yyyy";
            this.dtTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTanggal.Location = new System.Drawing.Point(152, 55);
            this.dtTanggal.Name = "dtTanggal";
            this.dtTanggal.Size = new System.Drawing.Size(146, 26);
            this.dtTanggal.TabIndex = 6;
            this.dtTanggal.Value = new System.DateTime(2021, 7, 18, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Harga";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Keterangan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kategori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tanggal";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHapus);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnUbah);
            this.groupBox2.Controls.Add(this.btnSimpan);
            this.groupBox2.Location = new System.Drawing.Point(541, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 145);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aksi";
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.CadetBlue;
            this.btnHapus.Location = new System.Drawing.Point(33, 90);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(100, 30);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.CadetBlue;
            this.btnClear.Location = new System.Drawing.Point(162, 90);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.BackColor = System.Drawing.Color.CadetBlue;
            this.btnUbah.Location = new System.Drawing.Point(162, 40);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(100, 30);
            this.btnUbah.TabIndex = 1;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = false;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSimpan.Location = new System.Drawing.Point(33, 40);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(100, 30);
            this.btnSimpan.TabIndex = 0;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textCari);
            this.groupBox3.Location = new System.Drawing.Point(541, 261);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(291, 87);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pencarian";
            // 
            // textCari
            // 
            this.textCari.Location = new System.Drawing.Point(22, 39);
            this.textCari.Name = "textCari";
            this.textCari.Size = new System.Drawing.Size(240, 26);
            this.textCari.TabIndex = 0;
            this.textCari.TextChanged += new System.EventHandler(this.textCari_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpemasukanDataGridViewTextBoxColumn,
            this.tanggalDataGridViewTextBoxColumn,
            this.kategoriDataGridViewTextBoxColumn,
            this.keteranganDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pemasukanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 425);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(844, 304);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // idpemasukanDataGridViewTextBoxColumn
            // 
            this.idpemasukanDataGridViewTextBoxColumn.DataPropertyName = "id_pemasukan";
            this.idpemasukanDataGridViewTextBoxColumn.HeaderText = "id_pemasukan";
            this.idpemasukanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idpemasukanDataGridViewTextBoxColumn.Name = "idpemasukanDataGridViewTextBoxColumn";
            this.idpemasukanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tanggalDataGridViewTextBoxColumn
            // 
            this.tanggalDataGridViewTextBoxColumn.DataPropertyName = "tanggal";
            this.tanggalDataGridViewTextBoxColumn.HeaderText = "tanggal";
            this.tanggalDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tanggalDataGridViewTextBoxColumn.Name = "tanggalDataGridViewTextBoxColumn";
            // 
            // kategoriDataGridViewTextBoxColumn
            // 
            this.kategoriDataGridViewTextBoxColumn.DataPropertyName = "kategori";
            this.kategoriDataGridViewTextBoxColumn.HeaderText = "kategori";
            this.kategoriDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kategoriDataGridViewTextBoxColumn.Name = "kategoriDataGridViewTextBoxColumn";
            // 
            // keteranganDataGridViewTextBoxColumn
            // 
            this.keteranganDataGridViewTextBoxColumn.DataPropertyName = "keterangan";
            this.keteranganDataGridViewTextBoxColumn.HeaderText = "keterangan";
            this.keteranganDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.keteranganDataGridViewTextBoxColumn.Name = "keteranganDataGridViewTextBoxColumn";
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "harga";
            this.hargaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            // 
            // pemasukanBindingSource
            // 
            this.pemasukanBindingSource.DataMember = "Pemasukan";
            this.pemasukanBindingSource.DataSource = this.uASPABDDataSet;
            // 
            // uASPABDDataSet
            // 
            this.uASPABDDataSet.DataSetName = "UASPABDDataSet";
            this.uASPABDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.CadetBlue;
            this.btnTambah.Location = new System.Drawing.Point(65, 371);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(150, 35);
            this.btnTambah.TabIndex = 5;
            this.btnTambah.Text = "Tambah Data";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // pemasukanTableAdapter
            // 
            this.pemasukanTableAdapter.ClearBeforeFill = true;
            // 
            // btnTotal
            // 
            this.btnTotal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTotal.Location = new System.Drawing.Point(541, 371);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(150, 35);
            this.btnTotal.TabIndex = 7;
            this.btnTotal.Text = "Total Pemasukan";
            this.btnTotal.UseVisualStyleBackColor = false;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Green;
            this.lblTotal.Location = new System.Drawing.Point(715, 376);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 22);
            this.lblTotal.TabIndex = 8;
            // 
            // FormPemasukan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(908, 751);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormPemasukan";
            this.Text = "FormPemasukan";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPemasukan_FormClosed);
            this.Load += new System.EventHandler(this.FormPemasukan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemasukanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uASPABDDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textHarga;
        private System.Windows.Forms.TextBox textKet;
        private System.Windows.Forms.ComboBox combKategori;
        private System.Windows.Forms.DateTimePicker dtTanggal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textCari;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTambah;
        private UASPABDDataSet uASPABDDataSet;
        private System.Windows.Forms.BindingSource pemasukanBindingSource;
        private UASPABDDataSetTableAdapters.PemasukanTableAdapter pemasukanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpemasukanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keteranganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Label lblTotal;
    }
}