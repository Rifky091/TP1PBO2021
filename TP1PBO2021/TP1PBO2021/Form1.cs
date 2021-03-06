using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1PBO2021
{
    public partial class Form1 : Form
    {
       
        Form2 f2;
        public Form1()
        {
            InitializeComponent();
            f2 = new Form2();
       
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            if (password.Text == "pbo123")
            {
                this.Hide();
                f2.Show();
            }
            else {
                string message = "Password yang anda masukkan salah!";
                string title = "Warning!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
