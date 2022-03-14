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
    /// <remarks>form untuk login</remarks>
    public partial class FormLogin : Form
    {
        /// <summary>
        /// metode yang dibuat dan dikelola secara otomatis oleh desainer Windows Forms dan mendefinisikan semua yang Anda lihat di form
        /// </summary>
        public FormLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// apabila button login diklik
        /// </summary>
        /// <param name="sender">berisi referensi kontrol yang terdapat event di dalamnya</param>
        /// <param name="e">berisi data informasi dari event</param>
        /// <remarks>method ini akan memeriksa apakah akun yang login terdaftar di database atau tidak</remarks>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Menggunakan SqlConnection untuk koneksi ke database
            SqlConnection conn = new SqlConnection(@"Data Source=ANNISAYASFA\MSSQLSERVER01;Initial Catalog=UASPABD;Integrated Security=True");
            //Menggunakan SqlDataAdapter untuk menghubungkan dataset/datatable
            SqlDataAdapter sda = new SqlDataAdapter("select count (*) from Login_user where nama_user = '" + textUser.Text + "' and password_user = '" + textPass.Text + "'", conn);
            //membuat datatable
            DataTable dt = new DataTable();
            //mengisi datatable
            sda.Fill(dt);
            //untuk memverifikasi apakah username dan password sesuai dengan tabel
            if (dt.Rows[0][0].ToString() == "1")
            {
                //mengarahkan ke FormMenu apabila nama dan password sesuai
                this.Hide(); //menyembunyikan FormLogin
                FormMenu mn = new FormMenu(); //membuat objek mn
                mn.Show(); //menampilkan FormMenu
            }
            else //jika username dan password tidak sesuai dengan tabel
            {
                //memunculkan pesan warning jika username dan password tidak sesuai
                MessageBox.Show("Mohon cek kembali username dan password",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// apabila button Close diklik
        /// </summary>
        /// <param name="sender">berisi referensi kontrol yang terdapat event di dalamnya</param>
        /// <param name="e">berisi data informasi dari suatu event</param>
        /// <remarks>method yang berfungsi untuk menutup form</remarks>
        private void btnClose_Click(object sender, EventArgs e)
        {
            //menutup seluruh form atau mengakhirinya
            this.Close();
        }
    }
}
