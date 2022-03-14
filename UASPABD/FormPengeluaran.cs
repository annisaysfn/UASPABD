using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
//menambahkan data provider utk SQL Server
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UASPABD
{
    /// <summary>
    /// main class
    /// </summary>
    /// <remarks>form untuk mencatat data pengeluaran toko</remarks>
    public partial class FormPengeluaran : Form
    {
        //Menggunakan SqlConnection untuk koneksi ke database
        SqlConnection con = new SqlConnection("Data Source =ANNISAYASFA\\MSSQLSERVER01; Initial Catalog = UASPABD; User Id =sa; Password=222222;");
        int idpeng; //deklarasi idpeng
        /// <summary>
        /// metode yang dibuat dan dikelola secara otomatis oleh desainer Windows Forms dan mendefinisikan semua yang Anda lihat di form
        /// </summary>
        public FormPengeluaran()
        {
            InitializeComponent();
            clear(); //memanggil method clear
        }

        /// <summary>
        /// method clear
        /// </summary>
        /// <remarks>method ini untuk mengosongkan kolom yang sudah terisi</remarks>
        private void clear()
        {
            Kategoricbx(); //memanggil method Kategoricbx
            dtTanggal.Value = DateTime.Today; //mengeset datetimepicker menjadi hariini
            textKet.Text = ""; //mengosongkan text box Keterangan
            textHarga.Text = ""; //mengosongkan text box harga
            idpeng = 0; //mengeset idpeng 0
            btnSimpan.Enabled = false; //menonaktifkan btnSimpan
            btnHapus.Enabled = true; //mengaktifkan btnHapus
            btnUbah.Enabled = true; //mengaktifkan btnUbah
        }

        /// <summary>
        /// method Kategoricbx
        /// </summary>
        /// <remarks>method ini untuk menentukan isi dari combobox kategori Pengeluaran</remarks>
        private void Kategoricbx()
        {
            con.Open(); //membuka koneksi
            //Menggunakan SqlCommand untuk mengeksekusi perintah SQL
            SqlCommand cmd = new SqlCommand("select nama_kategori from dbo.KategoriPengeluaran", con);
            //Menggunakan SqlDataAdapter untuk menghubungkan dataset
            SqlDataAdapter da = new SqlDataAdapter("select nama_kategori from dbo.KategoriPengeluaran", con);
            DataSet ds = new DataSet(); //membuat objek dataset
            da.Fill(ds); //mengisi dataset
            cmd.ExecuteReader(); //menghasilkan semua record nama_kategori dari tabel KategoriPengeluaran
            con.Close(); //menutup koneksi

            //menampilkan nama_kategori di list
            combKategori.DisplayMember = "nama_kategori";
            //mengambil nilai id_kategori
            combKategori.ValueMember = "id_kategori";
            //mengatur dataset
            combKategori.DataSource = ds.Tables[0];
        }

        /// <summary>
        /// method TampilDgv
        /// </summary>
        /// <remarks>method ini untuk menentukan isi dari DataGridView di form Pengeluaran</remarks>
        public void TampilDgv()
        {
            try
            {   //membuka koneksi
                con.Open();
                DataTable dt = new DataTable(); //membuat objek datatable
                //Menggunakan SqlDataAdapter untuk menghubungkan datatable
                SqlDataAdapter adapt = new SqlDataAdapter("Select * from Pengeluaran", con);
                adapt.Fill(dt); //mengisi datatable
                dataGridView1.DataSource = dt; //mengatur datatable pada datagridview
                con.Close(); //menutup koneksi
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// method CreatePengeluaran
        /// </summary>
        /// <remarks>method untuk membuat data Pengeluaran Keuangan Toko</remarks>
        public void CreatePengeluaran()
        {
            if (textHarga.Text != "") //jika textbox harga terisi
            {
                con.Open(); //membuka koneksi
                //Menggunakan SqlCommand untuk mengeksekusi perintah SQL
                SqlCommand cmd = new SqlCommand("insert into Pengeluaran(tanggal,kategori,keterangan,harga) values(@tanggal,@kategori,@keterangan,@harga)", con);
                //menambahkan nilai dtTanggal ke tanggal
                cmd.Parameters.AddWithValue("@tanggal", dtTanggal.Value);
                //menambahkan text pada combKategori ke kategori
                cmd.Parameters.AddWithValue("@kategori", combKategori.Text);
                //menambahkan text pada textKet ke keterangan
                cmd.Parameters.AddWithValue("@keterangan", textKet.Text);
                //menambahkan text pada textHarga ke harga
                cmd.Parameters.AddWithValue("@harga", textHarga.Text);
                //ExecuteNonQuery untuk mengeksekusi fungsi create
                cmd.ExecuteNonQuery();
                con.Close(); //menutup koneksi

                //menampilkan pesan bahwa data berhasil dibuat
                MessageBox.Show("Data berhasil dimasukkan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TampilDgv(); //memanggil method TampilDgv
                clear(); //memanggil method clear
            }
            else //jika text harga kosong
            {   //menampilkan pesan bahwa kolom harga wajib diisi
                MessageBox.Show("Kolom Harga wajib diisi",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// method UbahPengeluaran
        /// </summary>
        /// <remarks>method untuk mengubah atau mengedit data Pengeluaran Keuangan Toko</remarks>
        public void UbahPengeluaran()
        {
            if (idpeng != 0) //jika idpeng tidak sama dengan 0
            {    //menampilkan pesan konfirmasi, apabila user click Yes maka akan berlanjut.
                if (MessageBox.Show("Apakah Anda yakin ingin mengubah data ini?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    //Menggunakan SqlCommand untuk mengeksekusi perintah SQL
                    SqlCommand cmd = new SqlCommand("update Pengeluaran set tanggal=@tanggal,kategori=@kategori,keterangan=@keterangan,harga=@harga where id_pengeluaran=@id", con);
                    con.Open(); //membuka koneksi
                    //menambahkan nilai idpeng ke id
                    cmd.Parameters.AddWithValue("@id", idpeng);
                    //menambahkan nilai dtTanggal ke tanggal
                    cmd.Parameters.AddWithValue("@tanggal", dtTanggal.Value);
                    //menambahkan text pada combKategori ke kategori
                    cmd.Parameters.AddWithValue("@kategori", combKategori.Text);
                    //menambahkan text pada textKet ke keterangan
                    cmd.Parameters.AddWithValue("@keterangan", textKet.Text);
                    //menambahkan text pada textHarga ke harga
                    cmd.Parameters.AddWithValue("@harga", textHarga.Text);
                    //ExecuteNonQuery untuk mengeksekusi fungsi update
                    cmd.ExecuteNonQuery();
                    con.Close(); //menutup koneksi

                    //menampilkan pesan bahwa data berhasil diubah
                    MessageBox.Show("Data berhasil diubah", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TampilDgv(); //memanggil method TampilDgv
                    clear(); //memanggil method clear
                }
            }
            else //jika idpeng = 0 atau tidak ada data yang terpilih
            {
                //menampilkan pesan untuk memilih data terlebih dahulu
                MessageBox.Show("Pilih data yang ingin diubah",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// method HapusPengeluaran
        /// </summary>
        /// <remarks>method untuk menghapus data Pengeluaran Keuangan Toko</remarks>
        public void HapusPengeluaran()
        { //jika idpeng tidak sama dengan 0
            if (idpeng != 0)
            {    //menampilkan pesan konfirmasi, apabila user click Yes maka akan berlanjut
                if (MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    //Menggunakan SqlCommand untuk mengeksekusi perintah SQL
                    SqlCommand cmd = new SqlCommand("delete Pengeluaran where id_pengeluaran=@id", con);
                    con.Open(); //membuka koneksi
                    //menambahkan nilai idpeng ke id
                    cmd.Parameters.AddWithValue("@id", idpeng);
                    //ExecuteNonQuery untuk mengeksekusi fungsi delete
                    cmd.ExecuteNonQuery();
                    //menutup koneksi
                    con.Close();

                    //menampilkan pesan bahwa data berhasil dihapus
                    MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TampilDgv(); //memanggil method TampilDgv
                    clear(); //memanggil method clear
                }
            }
            else //jika idpeng = 0 atau tidak ada data yang terpilih
            {
                //menampilkan pesan untuk memilih data terlebih dahulu
                MessageBox.Show("Pilih data yang ingin dihapus",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// apabila kolom pada datagridview diklik
        /// </summary>
        /// <param name="sender">berisi referensi kontrol yang terdapat event di dalamnya</param>
        /// <param name="e">berisi data informasi dari event</param>
        /// <remarks>method untuk mengeset kolom data pengeluaran yang dipilih dari datagridview</remarks>
        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            //mendapatkan nilai id
            idpeng = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            //mendapatkan nilai sel kolom 1 untuk dtTanggal.Text
            dtTanggal.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            //mendapatkan nilai sel kolom 2 untuk combKategori.Text
            combKategori.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            //mendapatkan nilai sel kolom 3 untuk textKet.Text
            textKet.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            //mendapatkan nilai sel kolom 4 untuk textHarga.Text
            textHarga.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        /// <summary>
        /// apabila kolom pencarian digunakan
        /// </summary>
        /// <param name="sender">berisi referensi kontrol yang terdapat event di dalamnya</param>
        /// <param name="e">berisi data informasi dari event</param>
        /// <remarks>method untuk mencari data pengeluaran</remarks>
        private void textCari_TextChanged(object sender, EventArgs e)
        {
            con.Open(); //membuka koneksi
            //Menggunakan SqlDataAdapter untuk menghubungkan datatable
            SqlDataAdapter adapt = new SqlDataAdapter("select * from Pengeluaran where kategori like '%" + textCari.Text + "%' or keterangan like '%" + textCari.Text +
                "%' or harga like '%" + textCari.Text + "%'", con);
            //membuat objek datatable
            DataTable dt = new DataTable();
            //mengisi datatable
            adapt.Fill(dt);
            //mengatur datatable pada datagridview
            dataGridView1.DataSource = dt;
            //menutup koneksi
            con.Close();
        }

        /// <summary>
        /// apabila button Simpan diklik
        /// </summary>
        /// <param name="sender">berisi referensi kontrol yang terdapat event di dalamnya</param>
        /// <param name="e">berisi data informasi dari event</param>
        /// <remarks>method CreatePengeluaran akan dipanggil jika button Simpan diklik</remarks>
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            CreatePengeluaran(); //memanggil method CreatePengeluaran
        }

        /// <summary>
        /// apabila form Pengeluaran terbuka
        /// </summary>
        /// <param name="sender">berisi referensi kontrol yang terdapat event di dalamnya</param>
        /// <param name="e">berisi data informasi dari event</param>
        private void FormPengeluaran_Load(object sender, EventArgs e)
        {
            //mengeset datagridview dgn tabel Pengeluaran scr manual
            this.pengeluaranTableAdapter.Fill(this.uASPABDDataSet1.Pengeluaran);
            TampilDgv(); //memanggil method TampilDgv
        }

        /// <summary>
        /// apabila button Tambah diklik
        /// </summary>
        /// <param name="sender">berisi referensi kontrol yang terdapat event di dalamnya</param>
        /// <param name="e">berisi data informasi dari event</param>
        /// <remarks>button Simpan akan diaktifkan sedangkan button Ubah dan Hapus akan dinonaktifkan jika button Tambah diklik</remarks>
        private void btnTambah_Click(object sender, EventArgs e)
        {
            btnSimpan.Enabled = true; //mengaktifkan btnSimpan
            btnUbah.Enabled = false; //menonaktifkan btnUbah
            btnHapus.Enabled = false; //menonaktifkan btnHapus
        }

        /// <summary>
        /// apabila button Hapus diklik
        /// </summary>
        /// <param name="sender">berisi referensi kontrol yang terdapat event di dalamnya</param>
        /// <param name="e">berisi data informasi dari event</param>
        /// <remarks>method HapusPengeluaran akan dipanggil jika button Hapus diklik</remarks>
        private void btnHapus_Click(object sender, EventArgs e)
        {
            HapusPengeluaran(); //memanggil method HapusPengeluaran
        }

        /// <summary>
        /// apabila button Ubah diklik
        /// </summary>
        /// <param name="sender">berisi referensi kontrol yang terdapat event di dalamnya</param>
        /// <param name="e">berisi data informasi dari event</param>
        /// <remarks>method UbahPengeluaran akan dipanggil jika button Ubah diklik</remarks>
        private void btnUbah_Click(object sender, EventArgs e)
        {
            UbahPengeluaran(); //memanggil method UbahPengeluaran
        }

        /// <summary>
        /// apabila button Clear diklik
        /// </summary>
        /// <param name="sender">berisi referensi kontrol yang terdapat event di dalamnya</param>
        /// <param name="e">berisi data informasi dari event</param>
        /// <remarks>method clear akan dipanggil jika button Clear diklik</remarks>
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear(); //memanggil method clear
        }

        /// <summary>
        /// apabila button Total diklik
        /// </summary>
        /// <param name="sender">berisi referensi kontrol yang terdapat event di dalamnya</param>
        /// <param name="e">berisi data informasi dari event</param>
        /// <remarks>method ini berfungsi untuk menampilkan total pengeluaran keuangan toko sesuai dari database</remarks>
        private void btnTotal_Click(object sender, EventArgs e)
        {
            //mengeset lblTotal jadi 0
            lblTotal.Text = "0";
            //perulangan untuk menghitung total yang ada pada kolom harga di datagridview
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                lblTotal.Text = Convert.ToString(double.Parse(lblTotal.Text) + double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()));
            }
        }

        /// <summary>
        /// apabila close pada FormPengeluaran diklik
        /// </summary>
        /// <param name="sender">berisi referensi kontrol yang terdapat event di dalamnya</param>
        /// <param name="e">berisi data informasi dari event</param>
        /// <remarks>jika menutup FormPengeluaran, maka form akan kembali ke FormMenu</remarks>
        private void FormPengeluaran_FormClosed(object sender, FormClosedEventArgs e)
        {
            //membuat objek mn
            FormMenu mn = new FormMenu();
            mn.Show(); //menampilkan FormMenu
            this.Hide(); //menyembunyikan FormPengeluaran
        }
    }
}
