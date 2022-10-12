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
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
            Propertiess p = new Propertiess();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Propertiess.getallprop();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
