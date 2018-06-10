using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PkStudiesv1._0
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Hide();

            Form2 form2 = new Form2();
            form2.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Hide();

            Form3 form3 = new Form3();
            form3.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
