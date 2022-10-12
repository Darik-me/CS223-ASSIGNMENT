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
namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
//DATA GRID VIEW, ERROR PROVIDERS AND STUFF, REGEX
        private void button_add_Click(object sender, EventArgs e)
        {
          
            Propertiess p= new Propertiess();
            //try
           // {
                p.itemID=int.Parse(text_itemid.Text);
               // p.datee = dateTimePicker1.Text;
                p.inventnum=int.Parse(text_sku.Text);
                p.objectName = text_objname.Text;
                p.count = int.Parse(text_count.Text);
                p.price= int.Parse(text_price.Text);
                p.save();
           

            //}
            /*catch (Exception e1)
            {
                MessageBox.Show("sth");
                
            }*/
       
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void isAvailable_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message="";
            foreach(var item in checkedListBox1.SelectedItems)
            {
                
                message=message+ item.ToString();
               
            }
            MessageBox.Show(message);
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.BackColor= Color.Aqua;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panel1.BackColor = Color.DarkBlue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 screen=new Form2();
            this.Hide();
            screen.Show();
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void disp_Click(object sender, EventArgs e)
        {
            Display d= new Display();
            d.Show();
        }
    }
}
