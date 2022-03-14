using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    /// <remarks>form untuk memilih menu pemasukan atau pengeluaran</remarks>
    public partial class FormMenu : Form
    {
        /// <summary>
        /// metode yang dibuat dan dikelola secara otomatis oleh desainer Windows Forms dan mendefinisikan semua yang Anda lihat di form
        /// </summary>
        public FormMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// apabila gambar Pemasukan diklik
        /// </summary>
        /// <param name="sender">berisi referensi kontrol yang terdapat event di dalamnya</param>
        /// <param name="e">berisi data informasi dari event</param>
        /// <remarks>method ini akan mengarahkan admin ke form Pemasukan</remarks>
        private void pictPemasukan_Click(object sender, EventArgs e)
        {
            //mengarahkan ke FormPemasukan
            this.Hide(); //menyembunyikan FormMenu
            FormPemasukan fpem = new FormPemasukan(); //membuat objek fpem
            fpem.Show(); //menampilkan FormPemasukan
        }

        /// <summary>
        /// apabila gambar Pengeluaran diklik
        /// </summary>
        /// <param name="sender">berisi referensi kontrol yang terdapat event di dalamnya</param>
        /// <param name="e">berisi data informasi dari event</param>
        /// <remarks>method ini akan mengarahkan admin ke form Pengeluaran</remarks>
        private void pictPengeluaran_Click(object sender, EventArgs e)
        {
            //mengarahkan ke FormPengeluaran
            this.Hide(); //menyembunyikan FormMenu
            FormPengeluaran fpeng = new FormPengeluaran(); //membuat objek fpeng
            fpeng.Show(); //menampilkan FormPengeluaran
        }
    }
}
