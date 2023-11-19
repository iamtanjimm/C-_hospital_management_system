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

namespace Final_Term_Project
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(Localdb)\\local;database=Final term project;Integrated Security=True");
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_back_from6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3();
            f.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_addemp_Click(object sender, EventArgs e)
        {


            int emp_ID = Convert.ToInt32(textBox_empid.Text);
            String Emp_Name = textBox_empname.Text;
            int Emp_Age = Convert.ToInt32(textBox_empage.Text);
            String Emp_Working_As = textBox_workingas.Text;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(Localdb)\\local;database=Final term project;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into form6 values ('" + emp_ID + "','" + Emp_Name + "','" + Emp_Age + "','" + Emp_Working_As + "');";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            MessageBox.Show(" Data Saved!");


        }

private void button_showemp_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from form6";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
