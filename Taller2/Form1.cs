using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double iva;
            double total;
            iva = double.Parse(txtprecio.Text) * 0.19;
            total = double.Parse(txtprecio.Text) + iva;
            lbliva2.Text = iva.ToString();
            lbliva4.Text = total.ToString();

        }
    }
}
