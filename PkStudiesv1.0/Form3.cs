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
    
    public partial class Form3 : MetroFramework.Forms.MetroForm
    {
        Double slope;
        Double y1, y2, x2, x1;
        public Form3()
        {
            InitializeComponent();  
        }
        public Form3(string message,string message1,string message2,string message3)
        {
            InitializeComponent();
            y1 = Convert.ToDouble(message);
            y2 = Convert.ToDouble(message1);
            x1 = Convert.ToDouble(message2);
            x2 = Convert.ToDouble(message3);
        }

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox2;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length== 0 || textBox2.Text=="0")
            {
                MessageBox.Show("Enter a valid amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else
            {
                Double num = y1 - y2;
                Double num1 = x2 - x1;
                slope = num / num1;

                textBox11.Text = slope.ToString();
                Double kE = slope * 2.303;
                textBox16.Text = kE.ToString("#.###");
                Double th = 0.693 / kE;
                textBox13.Text = th.ToString("#.###");
                Double no = y1 - (slope * x1);
                textBox18.Text = no.ToString("#.###");
                Double deno = Math.Pow(10, no);

                Double entry = Convert.ToDouble(textBox2.Text);
                Double vd = (entry / (deno)) * 1000;
                ;
                textBox12.Text = vd.ToString("#.###");
                Double cl = kE * vd;
                textBox15.Text = cl.ToString("#.###");
                Double auc = deno / kE;
                textBox14.Text = auc.ToString("#.###");
            }
        }
    }
}
