using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1PBO2021.Properties;

namespace TP1PBO2021
{
    public partial class Form2 : Form
    {
        List<barang> barang = new List<barang>();
        private int hargaMin = -1;
        private int hargaMax = -1;
        public string jenis = null;
        public Form2()
        {
            InitializeComponent();
            setbarang();
            vBarang();
        }
        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void btnWeb_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.tokopedia.com/");
        }
        Panel cBox(string gambar, string nama, int harga, int id)
        {
            //membuat box-box / panel untuk barang2
            Panel viewBox = new Panel();

            PictureBox img = cImg(gambar);
            viewBox.Controls.Add(img);
            
            Label lbnama = cName(nama);
            viewBox.Controls.Add(lbnama);

            Label lbharga = cHarga(harga);
            viewBox.Controls.Add(lbharga);

            Button btbeli = cBeli(id);
            viewBox.Controls.Add(btbeli);

            viewBox.Location = new System.Drawing.Point(23, 20);
            viewBox.Name = "viewBox";
            viewBox.Size = new System.Drawing.Size(122, 191);
            viewBox.TabIndex = 0;
            return viewBox;
        }

        PictureBox cImg(string gambar)
        {
            //membuat picture box
            PictureBox pictureBox = new PictureBox();

            pictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(gambar);
            pictureBox.Location = new System.Drawing.Point(14, 15);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new System.Drawing.Size(94, 82);
            pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;

            return pictureBox;
        }

        Label cName(string name)
        {
            //membuat label nama
            Label lblnama = new Label();

            lblnama.AutoSize = true;
            lblnama.Location = new System.Drawing.Point(11, 110);
            lblnama.Name = "lblnama";
            lblnama.Size = new System.Drawing.Size(52, 13);
            lblnama.TabIndex = 1;
            lblnama.Text = name;

            return lblnama;
        }

        Label cHarga(int harga)
        {
            //membuat label harga
            Label lblHarga = new Label();

            lblHarga.AutoSize = true;
            lblHarga.Location = new System.Drawing.Point(11, 132);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new System.Drawing.Size(66, 13);
            lblHarga.TabIndex = 2;
            lblHarga.Text = "Rp." + harga.ToString();

            return lblHarga;
        }
        Button cBeli(int id)
        {
            //membuat button beli
            Button btnBeli = new Button();

            btnBeli.Location = new System.Drawing.Point(14, 155);
            btnBeli.Name = id.ToString();
            btnBeli.Size = new System.Drawing.Size(90, 23);
            btnBeli.TabIndex = 3;
            btnBeli.Text = "Beli";
            btnBeli.UseVisualStyleBackColor = true;
            btnBeli.Click += new System.EventHandler(btnBeli_Click);

            return btnBeli;
        }       
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }
        void jenisBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.jenis = jenisBarang.SelectedItem.ToString();
        }
        void setbarang()
        {
            this.barang.Add(new barang("0", "Keyboard", "Elektronik", 399000, 0));
            this.barang.Add(new barang("5f1fdcdacafc4", "Sate", "Makanan", 150000, 1));
            this.barang.Add(new barang("images","Kebaya", "Pakaian", 350000, 2));
            this.barang.Add(new barang("1","VGA Card", "Elektronik", 750000, 3));
            this.barang.Add(new barang("dered-5457-3583442-1", "Kemeja", "Pakaian", 100000, 4));
        }

        void Harga_SelectedIndexChanged(object sender, EventArgs e)
        {
            string price = listHarga.SelectedItem.ToString();
            if (price == "100000 - 200000")
            {
                this.hargaMin = 100000;
                this.hargaMax = 200000;
            }
            else if (price == "200000 - 500000")
            {
                this.hargaMin = 200000;
                this.hargaMax = 500000;
            }
            else if (price == "500000 - 1000000")
            {
                this.hargaMin = 500000;
                this.hargaMax = 1000000;
            }
            
        }
        void vBarang()
        {   
            lblKet.Text = "Daftar Barang :";
            viewpanel.Controls.Clear();
            foreach (var view in this.barang)
            {
                if (view.jenis == this.jenis)
                {
                    if (this.hargaMin <= view.harga && this.hargaMax >= view.harga)
                    {
                        viewpanel.Controls.Add(cBox(view.gambar, view.nama, view.harga, view.id));

                    }
                    else if (this.hargaMin == -1)
                    {
                        viewpanel.Controls.Add(cBox(view.gambar, view.nama, view.harga, view.id));

                    }
                }
                else if (this.jenis == null)
                {
                    if (this.hargaMin <= view.harga && this.hargaMax >= view.harga)
                    {
                        viewpanel.Controls.Add(cBox(view.gambar, view.nama, view.harga, view.id));
                    }
                    else if (this.hargaMin == -1)
                    {
                        viewpanel.Controls.Add(cBox(view.gambar, view.nama, view.harga, view.id));
                    }
                }
            }
        }
        private void btnCari_Click(object sender, EventArgs e)
        {
            vBarang();//munculkan item
        }

        //Action ketika button beli di klik
        public void btnBeli_Click(object sender, EventArgs e)
        {
            string btnBeli = (sender as Button).Name;
            foreach (var barang in this.barang)
            {
                if (barang.id.ToString() == btnBeli)
                {
                    jenis = barang.jenis;
                    hargaMax = barang.harga;
                    hargaMin = barang.harga;
                }
            }
            lblKet.Visible = false;
            label3.Visible = true;
            jenisBarang.Visible = false;
            listHarga.Visible = false;
            Cari.Visible = false;
            button2.Visible = true;
            vBarang();
        }

        private void viewBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void imgItem_Click(object sender, EventArgs e)
        {

        }

        private void viewpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBeli_Click_1(object sender, EventArgs e)
        {

        }
    }
}
