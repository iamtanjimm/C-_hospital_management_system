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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_back_from5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3();
            f.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("Data Source=(Localdb)\\local;database=Final term project;Integrated Security=True");
        private void button_showpatients_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from form5";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button_addpatient_Click(object sender, EventArgs e)
        {
           try
            { 
            String Patient_ID = textBox_patientid.Text;
            String Patient_Name = textBox_patientName.Text;
            String Doctors_Name = textBox_DoctorsName.Text;
            String Patient_Age = textBox_patientage.Text;
            String Patient_Gender = textBox_patientgender.Text;


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(Localdb)\\local;database=Final term project;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into form5 values ('" + Patient_ID + "','" + Patient_Name + "','" + Doctors_Name + "','" + Patient_Age + "','" + Patient_Gender + "');";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            MessageBox.Show(" Data Saved!");
        }
           catch (Exception)
            {
               MessageBox.Show("Invalid Data Format ");
            }
            
        }

        private void button_deletepatient_Click(object sender, EventArgs e)
        {
            int Patient_ID = Convert.ToInt32(textBox_patientid.Text);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from form5 where Patient_ID = '" + Patient_ID + "' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            MessageBox.Show("Deleted Successfully");
        }

        private void textBox_patientage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
