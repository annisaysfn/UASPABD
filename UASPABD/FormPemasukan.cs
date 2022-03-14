using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//menambahkan data provider utk SQL Server
using System.Data.SqlClient;
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
    /// <remarks>form untuk mencatat data pemasukan toko</remarks>
    public partial class FormPemasukan : Form
    {
        //Menggunakan SqlConnection untuk koneksi ke database
        SqlConnection con = new SqlConnection("Data Source =ANNISAYASFA\\MSSQLSERVER01; Initial Catalog = UASPABD; User Id =sa; Password=222222;");
        int idpem; //deklarasi idpem
        /// <summary>
        /// metode yang dibuat dan dikelola secara otomatis oleh desainer Windows Forms dan mendefinisikan semua yang Anda lihat di form
        /// </summary>
        public FormPemasukan()
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
            idpem = 0; //mengeset idpem 0
            btnSimpan.Enabled = false; //menonaktifkan btnSimpan
            btnHapus.Enabled = true; //mengaktifkan btnHapus
            btnUbah.Enabled = true; //mengaktifkan btnUbah
        }

        /// <summary>
        /// method Kategoricbx
        /// </summary>
        /// <remarks>method ini untuk menentukan isi dari combobox kategori Pemasukan</remarks>
        private void Kategoricbx()
        {
            //membuka koneksi
            con.Open();
            //Menggunakan SqlCommand untuk mengeksekusi perintah SQL
            SqlCommand cmd = new SqlCommand("select nama_kategori from dbo.KategoriPemasukan", con);
            //Menggunakan SqlDataAdapter untuk menghubungkan dataset
            SqlDataAdapter da = new SqlDataAdapter("select nama_kategori from dbo.KategoriPemasukan", con);
            //membuat objek dataset
            DataSet ds = new DataSet();
            //mengisi dataset
            da.Fill(ds);
            //menghasilkan semua record nama_kategori dari tabel KategoriPemasukan
            cmd.ExecuteReader();
            //menutup koneksi
            con.Close();

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
        /// <remarks>method ini untuk menentukan isi dari DataGridView di form Pemasukan</remarks>
        public void TampilDgv()
        {
            try
            {
                con.Open(); //membuka koneksi
                DataTable dt = new DataTable(); //membuat objek datatable
                //Menggunakan SqlDataAdapter untuk menghubungkan datatable
                SqlDataAdapter adapt = new SqlDataAdapter("Select * from Pemasukan", con);
                //mengisi datatable
                adapt.Fill(dt);
                //mengatur datatable pada datagridview
                dataGridView1.DataSource = dt;
                //menutup koneksi
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// method CreatePemasukan
        /// </summary>
        /// <remarks>method untuk membuat data Pemasukan Keuangan Toko</remarks>
        public void CreatePemasukan()
        {
            if (textHarga.Text != "") //jika textbox harga terisi
            {
                con.Open(); //membuka koneksi
                //Menggunakan SqlCommand untuk mengeksekusi perintah SQL
                SqlCommand cmd = new SqlCommand("insert into Pemasukan(tanggal,kategori,keterangan,harga) values(@tanggal,@kategori,@keterangan,@harga)", con);
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
                //menutup koneksi
                con.Close();

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
        /// method UbahPemasukan
        /// </summary>
        /// <remarks>method untuk mengubah atau mengedit data Pemasukan Keuangan Toko</remarks>
        public void UbahPemasukan()
        {
            //jika idpem tidak sama dengan 0
            if (idpem != 0)
            {   //menampilkan pesan konfirmasi, apabila user click Yes maka akan berlanjut.
                if (MessageBox.Show("Apakah Anda yakin ingin mengubah data ini?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    //Menggunakan SqlCommand untuk mengeksekusi perintah SQL
                    SqlCommand cmd = new SqlCommand("update Pemasukan set tanggal=@tanggal,kategori=@kategori,keterangan=@keterangan,harga=@harga where id_pemasukan=@id", con);
                    //membuka koneksi
                    con.Open();
                    //menambahkan nilai idpem ke id
                    cmd.Parameters.AddWithValue("@id", idpem);
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
                    //menutup koneksi
                    con.Close();

                    //menampilkan pesan bahwa data berhasil diubah
                    MessageBox.Show("Data berhasil diubah", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TampilDgv(); //memanggil method TampilDgv
                    clear(); //memanggil method clear
                }
            }
            else //jika idpem = 0 atau tidak ada data yang terpilih
            {
                //menampilkan pesan untuk memilih data terlebih dahulu
                MessageBox.Show("Pilih data yang ingin diubah",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// method HapusPemasukan
        /// </summary>
        /// <remarks>method untuk menghapus data Pemasukan Keuangan Toko</remarks>
        public void HapusPemasukan()
        {   //jika idpem tidak sama dengan 0
            if (idpem != 0)
            {   //menampilkan pesan konfirmasi, apabila user click Yes maka akan berlanjut
                if (MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    //Menggunakan SqlCommand untuk mengeksekusi perintah SQL
                    SqlCommand cmd = new SqlCommand("delete Pemasukan where id_pemasukan=@id", con);
                    con.Open(); //membuka koneksi
                    cmd.Parameters.AddWithValue("@id", idpem); //menambahkan nilai idpem ke id
                    cmd.ExecuteNonQuery(); //ExecuteNonQuery untuk mengeksekusi fungsi delete
                    con.Close(); //menutup koneksi

                    //menampilkan pesan bahwa data berhasil dihapus
                    MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TampilDgv(); //memanggil method TampilDgv
                    clear(); //memanggil method clear
                }
            }
            else //jika idpem = 0 atau tidak ada data yang terpilih
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
        /// <remarks>method untuk mengeset kolom data pemasukan yang dipilih dari datagridview</remarks>
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //mendapatkan nilai id
            idpem = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
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
        /// <remarks>method untuk mencari data pemasukan</remarks>
        private void textCari_TextChanged(object sender, EventArgs e)
        {
            con.Open(); //membuka koneksi
            //Menggunakan SqlDataAdapter untuk menghubungkan datatable
            SqlDataAdapter adapt = new SqlDataAdapter("select * from Pemasukan where kategori like '%" + textCari.Text + "%' or keterangan like '%" + textCari.Text +
                "%' or harga like '%" + textCari.Text + "%'", con);
            //membuat objek datatable
            DataTable dt = new DataTable();
            //mengisi datatable
            adapt.Fill(dt);
            //mengatur datatable pada datagridview
            dataGridView1.DataSource = dt;
            con.Close(); //menutup koneksi
        }

        /// <summary>
        /// apabila button Simpan diklik
        /// </summary>
        /// <param name="sender">berisi referensi kontrol yang terdapat event di dalamnya</param>
        /// <param name="e">berisi data informasi dari event</param>
        /// <remarks>method CreatePemasukan akan dipanggil jika button Simpan diklik</remarks>
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            CreatePemasukan(); //memanggil method CreatePemasukan
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
        /// apabila form Pemasukan terbuka
        /// </summary>
        /// <param name="sender">berisi referensi kontrol yang terdapat event di dalamnya</param>
        /// <param name="e">berisi data informasi dari event</param>
        private void FormPemasukan_Load(object sender, EventArgs e)
        {
            this.pemasukanTableAdapter.Fill(this.uASPABDDataSet.Pemasukan); //mengeset datagridview dgn tabel Pemasukan scr manual 
            TampilDgv(); //memanggil method TampilDgv
        }

        /// <summary>
        /// apabila button Hapus diklik
        /// </summary>
        /// <param name="sender">berisi referensi kontrol yang terdapat event di dalamnya</param>
        /// <param name="e">berisi data informasi dari event</param>
        /// <remarks>method HapusPemasukan akan dipanggil jika button Hapus diklik</remarks>
        private void btnHapus_Click(object sender, EventArgs e)
        {
            HapusPemasukan(); //memanggil method HapusPemasukan
        }

        /// <summary>
        /// apabila button Ubah diklik
        /// </summary>
        /// <param name="sender">berisi referensi kontrol yang terdapat event di dalamnya</param>
        /// <param name="e">berisi data informasi dari event</param>
        /// <remarks>method UbahPemasukan akan dipanggil jika button Ubah diklik</remarks>
        private void btnUbah_Click(object sender, EventArgs e)
        {
            UbahPemasukan(); //memanggil method UbahPemasukan
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
        /// <remarks>method ini berfungsi untuk menampilkan total pemasukan keuangan toko sesuai dari database</remarks>
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
        /// apabila close pada FormPemasukan diklik
        /// </summary>
        /// <param name="sender">berisi referensi kontrol yang terdapat event di dalamnya</param>
        /// <param name="e">berisi data informasi dari event</param>
        /// <remarks>jika menutup FormPemasukan, maka form akan kembali ke FormMenu</remarks>
        private void FormPemasukan_FormClosed(object sender, FormClosedEventArgs e)
        {
            //membuat objek mn
            FormMenu mn = new FormMenu();
            //menampilkan FormMenu
            mn.Show();
            this.Hide(); //menyembunyikan FormPemasukan
        }
    }
}
