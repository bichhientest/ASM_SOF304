using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace asigmentvippro
{
    public partial class quanlysinhvien : Form
    {
        public quanlysinhvien()
        {
            InitializeComponent();
        }
        public quanlysinhvien(string min)
        {
            InitializeComponent();
        }
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        string str = @"Data Source=LAPTOP-CKN1UE62\MAIVANMINH;Initial Catalog=fpl_daotao;Integrated Security=True";
        DataTable dt = new DataTable();
        void load()
        {
            command = connection.CreateCommand();
            command.CommandText = "select *from hocsinh";
            adapter.SelectCommand = command;
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void quanlysinhvien_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                connection.CreateCommand();
                command.CommandText = "insert into hocsinh values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','"+ textBox5.Text + "','" + textBox6.Text + "')";
                command.ExecuteNonQuery();
                load();
            
            
           
           
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
               
            i = dataGridView1.CurrentRow.Index;
            
            textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.CreateCommand();
            command.CommandText = "update hocsinh set masinhvien='" + textBox1.Text + "',hoten='" + textBox2.Text + "',email= '" + textBox3.Text + "',soDT='" + textBox4.Text + "',gioitinh='"+ textBox5.Text + "',dia_chi='"+textBox6.Text+"' where masinhvien='" + textBox1.Text + "' ";
            command.ExecuteNonQuery();
            load();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection.CreateCommand();
            command.CommandText = "delete from hocsinh where masinhvien='" + textBox1.Text + "' ";
            command.ExecuteNonQuery();
            load();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dangnhap min=new dangnhap();
            min.Show();
        }
    }
}
