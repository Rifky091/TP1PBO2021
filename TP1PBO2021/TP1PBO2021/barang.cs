using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TP1PBO2021
{
    class barang
    {
        public barang()
        {

        }
        public string gambar { get; set; }
        public string nama { get; set; }
        public string jenis { get; set; }
        public int harga { get; set; }
        public int id { get; set; }
        public barang(string gambar, string nama, string jenis, int harga, int id)
        {
            this.gambar = gambar;
            this.nama = nama;
            this.jenis = jenis;
            this.harga = harga;
            this.id = id;
        }

    }

    
}
