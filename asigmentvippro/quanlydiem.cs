using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace asigmentvippro
{
    public partial class quanlydiem : Form
    {
        public quanlydiem()
        {
            InitializeComponent();
        }
        public quanlydiem( string min)
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
            command.CommandText = "select *from bangdiem";
            adapter.SelectCommand = command;
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void quanlydiem_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            load();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dangnhap min = new dangnhap();
            min.Show();
        }
        public float diemtrungbinh { get; set; }
        public void diem() {  
       float gt1=float.Parse(textBox3.Text);
        float gt2=float.Parse(textBox4.Text);
         float   gt3=float.Parse(textBox5.Text);
            float diemtb=(gt1+gt2+gt3)/3;
            label10.Text = diemtb.ToString();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            connection.CreateCommand();
            command.CommandText = "insert into bangdiem values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            command.ExecuteNonQuery();
            load();
           diem();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.CreateCommand();
            command.CommandText = "update bangdiem set masinhvien='" + textBox1.Text + "',hoten='" + textBox2.Text + "',tienganh= '" + textBox3.Text + "',tinhoc='" + textBox4.Text + "',GDTC='" + textBox5.Text + "' where masinhvien='" + textBox1.Text + "' ";
            command.ExecuteNonQuery();
            load();
            diem();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection.CreateCommand();
            command.CommandText = "delete from bangdiem where masinhvien='" + textBox1.Text + "' ";
            command.ExecuteNonQuery();
            load();
            diem();
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
            diem();
        }

        private void button5_Click(object sender, EventArgs e)
        {   
            connection.CreateCommand();
            command.CommandText = "select * from bangdiem where masinhvien='" + textBox1.Text + "' ";
            command.ExecuteNonQuery();  
            diem();
        }
    }
}
