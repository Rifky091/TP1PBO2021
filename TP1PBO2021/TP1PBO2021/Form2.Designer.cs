
namespace TP1PBO2021
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.jenisBarang = new System.Windows.Forms.ComboBox();
            this.listHarga = new System.Windows.Forms.ComboBox();
            this.Cari = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnKatalog = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.viewpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.viewBox = new System.Windows.Forms.Panel();
            this.btnBeli = new System.Windows.Forms.Button();
            this.lblHarga = new System.Windows.Forms.Label();
            this.lblnama = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblKet = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.viewpanel.SuspendLayout();
            this.viewBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // jenisBarang
            // 
            this.jenisBarang.FormattingEnabled = true;
            this.jenisBarang.Items.AddRange(new object[] {
            "Elektronik",
            "Pakaian",
            "Makanan"});
            this.jenisBarang.Location = new System.Drawing.Point(11, 73);
            this.jenisBarang.Name = "jenisBarang";
            this.jenisBarang.Size = new System.Drawing.Size(121, 21);
            this.jenisBarang.TabIndex = 3;
            this.jenisBarang.Text = "Jenis Barang";
            this.jenisBarang.SelectedIndexChanged += new System.EventHandler(this.jenisBarang_SelectedIndexChanged);
            // 
            // listHarga
            // 
            this.listHarga.FormattingEnabled = true;
            this.listHarga.Items.AddRange(new object[] {
            "100000 - 200000",
            "200000 - 500000",
            "500000 - 1000000"});
            this.listHarga.Location = new System.Drawing.Point(11, 110);
            this.listHarga.Name = "listHarga";
            this.listHarga.Size = new System.Drawing.Size(121, 21);
            this.listHarga.TabIndex = 4;
            this.listHarga.Text = "Harga";
            this.listHarga.SelectedIndexChanged += new System.EventHandler(this.Harga_SelectedIndexChanged);
            // 
            // Cari
            // 
            this.Cari.Location = new System.Drawing.Point(11, 154);
            this.Cari.Name = "Cari";
            this.Cari.Size = new System.Drawing.Size(75, 23);
            this.Cari.TabIndex = 5;
            this.Cari.Text = "Cari";
            this.Cari.UseVisualStyleBackColor = true;
            this.Cari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(492, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "NIM : 1904051";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(492, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nama : M. Rifky Maulana";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Cari);
            this.panel1.Controls.Add(this.listHarga);
            this.panel1.Controls.Add(this.jenisBarang);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 509);
            this.panel1.TabIndex = 28;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Kembali";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnKatalog);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Location = new System.Drawing.Point(156, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 76);
            this.panel2.TabIndex = 29;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnHome.ImageKey = "013-wood cabin.png";
            this.btnHome.ImageList = this.imageList1;
            this.btnHome.Location = new System.Drawing.Point(42, 22);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(131, 26);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.Home_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "013-wood cabin.png");
            this.imageList1.Images.SetKeyName(1, "047-wallet.png");
            this.imageList1.Images.SetKeyName(2, "002-airplane.png");
            // 
            // btnKatalog
            // 
            this.btnKatalog.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnKatalog.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnKatalog.ImageKey = "047-wallet.png";
            this.btnKatalog.ImageList = this.imageList1;
            this.btnKatalog.Location = new System.Drawing.Point(191, 22);
            this.btnKatalog.Name = "btnKatalog";
            this.btnKatalog.Size = new System.Drawing.Size(123, 26);
            this.btnKatalog.TabIndex = 1;
            this.btnKatalog.Text = "        Web Katalog";
            this.btnKatalog.UseVisualStyleBackColor = false;
            this.btnKatalog.Click += new System.EventHandler(this.btnWeb_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLogout.ImageKey = "002-airplane.png";
            this.btnLogout.ImageList = this.imageList1;
            this.btnLogout.Location = new System.Drawing.Point(329, 22);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(111, 26);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "      Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // viewpanel
            // 
            this.viewpanel.Controls.Add(this.viewBox);
            this.viewpanel.Location = new System.Drawing.Point(162, 110);
            this.viewpanel.Name = "viewpanel";
            this.viewpanel.Size = new System.Drawing.Size(685, 399);
            this.viewpanel.TabIndex = 30;
            this.viewpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.viewpanel_Paint);
            // 
            // viewBox
            // 
            this.viewBox.Controls.Add(this.btnBeli);
            this.viewBox.Controls.Add(this.lblHarga);
            this.viewBox.Controls.Add(this.lblnama);
            this.viewBox.Controls.Add(this.pictureBox);
            this.viewBox.Location = new System.Drawing.Point(3, 3);
            this.viewBox.Name = "viewBox";
            this.viewBox.Size = new System.Drawing.Size(122, 191);
            this.viewBox.TabIndex = 0;
            this.viewBox.Paint += new System.Windows.Forms.PaintEventHandler(this.viewBox_Paint);
            // 
            // btnBeli
            // 
            this.btnBeli.Location = new System.Drawing.Point(14, 155);
            this.btnBeli.Name = "btnBeli";
            this.btnBeli.Size = new System.Drawing.Size(90, 23);
            this.btnBeli.TabIndex = 3;
            this.btnBeli.Text = "Beli";
            this.btnBeli.UseVisualStyleBackColor = true;
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Location = new System.Drawing.Point(11, 132);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(66, 13);
            this.lblHarga.TabIndex = 2;
            this.lblHarga.Text = "Rp. 750.000";
            // 
            // lblnama
            // 
            this.lblnama.AutoSize = true;
            this.lblnama.Location = new System.Drawing.Point(11, 110);
            this.lblnama.Name = "lblnama";
            this.lblnama.Size = new System.Drawing.Size(52, 13);
            this.lblnama.TabIndex = 1;
            this.lblnama.Text = "Keyboard";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::TP1PBO2021.Properties.Resources._0;
            this.pictureBox.Location = new System.Drawing.Point(14, 15);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(94, 82);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.imgItem_Click);
            // 
            // lblKet
            // 
            this.lblKet.AutoSize = true;
            this.lblKet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblKet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKet.Location = new System.Drawing.Point(411, 79);
            this.lblKet.Name = "lblKet";
            this.lblKet.Size = new System.Drawing.Size(117, 24);
            this.lblKet.TabIndex = 1;
            this.lblKet.Text = "Daftar Barang :";
            this.lblKet.UseCompatibleTextRendering = true;
            this.lblKet.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(411, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 24);
            this.label3.TabIndex = 31;
            this.label3.Text = "Detail Barang :";
            this.label3.UseCompatibleTextRendering = true;
            this.label3.UseMnemonic = false;
            this.label3.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 521);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblKet);
            this.Controls.Add(this.viewpanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.viewpanel.ResumeLayout(false);
            this.viewBox.ResumeLayout(false);
            this.viewBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnKatalog;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ComboBox jenisBarang;
        private System.Windows.Forms.ComboBox listHarga;
        private System.Windows.Forms.Button Cari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel viewpanel;
        private System.Windows.Forms.Panel viewBox;
        private System.Windows.Forms.Label lblnama;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnBeli;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.Label lblKet;
        public System.Windows.Forms.Label label3;
    }
}