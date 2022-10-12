using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            StartPosition= FormStartPosition.CenterScreen;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            this.Hide();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = txt_user.Text;
            string password = txt_password.Text;
            if (username != "admin" || password != "admin")
            {
                MessageBox.Show("Wrong Username or Password");
            }
            else
            {
                Form1 screen = new Form1();
                this.Hide();
                screen.Show();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
