
namespace UASPABD
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.pictPemasukan = new System.Windows.Forms.PictureBox();
            this.pictPengeluaran = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictPemasukan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictPengeluaran)).BeginInit();
            this.SuspendLayout();
            // 
            // pictPemasukan
            // 
            this.pictPemasukan.Image = ((System.Drawing.Image)(resources.GetObject("pictPemasukan.Image")));
            this.pictPemasukan.Location = new System.Drawing.Point(148, 158);
            this.pictPemasukan.Name = "pictPemasukan";
            this.pictPemasukan.Size = new System.Drawing.Size(120, 120);
            this.pictPemasukan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictPemasukan.TabIndex = 0;
            this.pictPemasukan.TabStop = false;
            this.pictPemasukan.Click += new System.EventHandler(this.pictPemasukan_Click);
            // 
            // pictPengeluaran
            // 
            this.pictPengeluaran.Image = ((System.Drawing.Image)(resources.GetObject("pictPengeluaran.Image")));
            this.pictPengeluaran.Location = new System.Drawing.Point(350, 158);
            this.pictPengeluaran.Name = "pictPengeluaran";
            this.pictPengeluaran.Size = new System.Drawing.Size(120, 120);
            this.pictPengeluaran.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictPengeluaran.TabIndex = 1;
            this.pictPengeluaran.TabStop = false;
            this.pictPengeluaran.Click += new System.EventHandler(this.pictPengeluaran_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(160, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pemasukan";
            this.label1.Click += new System.EventHandler(this.pictPemasukan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(360, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pengeluaran";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 16F);
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(190, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Keuangan Toko";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(630, 387);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictPengeluaran);
            this.Controls.Add(this.pictPemasukan);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictPemasukan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictPengeluaran)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictPemasukan;
        private System.Windows.Forms.PictureBox pictPengeluaran;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}