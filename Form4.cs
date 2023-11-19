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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button_doctorlist_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from form7";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button_back_from4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3();
            f.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("Data Source=(Localdb)\\local;database=Final term project;Integrated Security=True");
        private void button_adddoctor_Click(object sender, EventArgs e)
        {
           try
            {
                String Doctors_ID = textBox_DN.Text;
                String Doctors_Name = textBox_Did.Text;
                String Doctors_specialities = textBox_DS.Text;
                

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(Localdb)\\local;database=Final term project;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "insert into form7 values ('" + Doctors_ID + "','" + Doctors_Name + "','" + Doctors_specialities + "');";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                MessageBox.Show(" Data Saved!");

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from form7";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                //DataSet ds = new DataSet();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
           catch (Exception)
            {
               MessageBox.Show("Invalid Data Format ");
            }
            textBox_DN.Clear();
            textBox_Did.Clear();
            textBox_DS.Clear();

          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_doctorsidsearch_Click(object sender, EventArgs e)
        {
            String DocID = textBox_doctorsidsearch.Text;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from form7 where Doctors_Name = '" + DocID + "' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button_deletedoctor_Click(object sender, EventArgs e)
        {
            String DocID = textBox_Did.Text;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from form7 where Doctors_ID = '" + DocID + "' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            MessageBox.Show("Deleted Successfully");


            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from form7";
            cmd.ExecuteNonQuery();
            //DataTable dt = new DataTable();
            //DataSet ds = new DataSet();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void textBox_doctorsidsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox_DS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
