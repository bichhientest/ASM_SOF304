using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asigmentvippro
{
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }
        public dangnhap(string mmin) {
            InitializeComponent();
        }
        private void dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="dao tao"&& textBox2.Text == "lovesontungmtp") {
                quanlysinhvien sv = new quanlysinhvien();
                sv.Show(); 
                
            }
           else if (textBox1.Text == "thay tan" && textBox2.Text == "loveblackpin")
            {
                quanlydiem sv = new quanlydiem();
                sv.Show();
            }
            else
            {
                MessageBox.Show("thong tin sai!");
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
