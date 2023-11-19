using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Term_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button_Login_Click(object sender, EventArgs e)
        { String uid = textBox_USID.Text;
            String pass = textBox_Pass.Text;
            if (uid =="admin" && pass=="admin")
            {
                MessageBox.Show("Log in Successfully");
                this.Hide();
                Form3 f = new Form3();
                f.Show();
               



            }
            else
            {
                MessageBox.Show("Wrong Input");
                textBox_Pass.Clear();
                textBox_USID.Clear();
            }
            
        }

        private void textBox_Pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_USID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
