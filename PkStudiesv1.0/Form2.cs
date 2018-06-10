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
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        List<TextBox> Conc = new List<TextBox>();
        List<TextBox> Times = new List<TextBox>();
        List<TextBox> LogC = new List<TextBox>();
        public Form2()
        {
            InitializeComponent();
            LogC.Add(l1);LogC.Add(l2);LogC.Add(l3);LogC.Add(l4);LogC.Add(l5);LogC.Add(l6);LogC.Add(l7);LogC.Add(l8);LogC.Add(l9);LogC.Add(l10);
            Times.Add(t1); Times.Add(t2); Times.Add(t3); Times.Add(t4); Times.Add(t5);Times.Add(t6);Times.Add(t7);Times.Add(t8);Times.Add(t9);Times.Add(t10);
            Conc.Add(c1);Conc.Add(c2);Conc.Add(c3);Conc.Add(c4);Conc.Add(c5);Conc.Add(c6);Conc.Add(c7);Conc.Add(c8);Conc.Add(c9);Conc.Add(c10);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < numericUpDown1.Value; i++)
                Conc[i].Enabled = Times[i].Enabled = true;

            for (; i < 10; i++)
                Conc[i].Enabled = Times[i].Enabled = false;

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void Value_OnFocus(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Equals("0"))
                ((TextBox)sender).Text = string.Empty;

        }

        private void Value_LeaveFocus(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Equals(string.Empty))
                ((TextBox)sender).Text = "0";
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (c1.Text == "0" && c2.Text == "0")
            {
                MessageBox.Show("No Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                l1.Text = (Math.Log10(Convert.ToDouble(c1.Text))).ToString("#.##");
                l2.Text = (Math.Log10(Convert.ToDouble(c2.Text))).ToString("#.##");
                l3.Text = (Math.Log10(Convert.ToDouble(c3.Text))).ToString("#.##");
                l4.Text = (Math.Log10(Convert.ToDouble(c4.Text))).ToString("#.##");
                l5.Text = (Math.Log10(Convert.ToDouble(c5.Text))).ToString("#.##");
                l6.Text = (Math.Log10(Convert.ToDouble(c6.Text))).ToString("#.##");
                l7.Text = (Math.Log10(Convert.ToDouble(c7.Text))).ToString("#.##");
                l8.Text = (Math.Log10(Convert.ToDouble(c8.Text))).ToString("#.##");
                l9.Text = (Math.Log10(Convert.ToDouble(c9.Text))).ToString("#.##");
                l10.Text = (Math.Log10(Convert.ToDouble(c10.Text))).ToString("#.##");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (this.chart1.ChartAreas)[0].AxisX.Title = "Time";
            (this.chart1.ChartAreas)[0].AxisY.Title = "LogC";
            if (Convert.ToDouble(this.l1.Text) != double.NegativeInfinity)
            {
                this.chart1.Series["Analysis"].Points.AddXY(this.t1.Text, this.l1.Text);
            }
            if (Convert.ToDouble(this.l2.Text) != double.NegativeInfinity)
            {
                this.chart1.Series["Analysis"].Points.AddXY(this.t2.Text, this.l2.Text);
            }
            if (Convert.ToDouble(this.l3.Text) != double.NegativeInfinity)
            {
                this.chart1.Series["Analysis"].Points.AddXY(this.t3.Text, this.l3.Text);
            }
            if (Convert.ToDouble(this.l4.Text) != double.NegativeInfinity)
            {
                this.chart1.Series["Analysis"].Points.AddXY(this.t4.Text, this.l4.Text);
            }
            if (Convert.ToDouble(this.l5.Text) != double.NegativeInfinity)
            {
                this.chart1.Series["Analysis"].Points.AddXY(this.t5.Text, this.l5.Text);
            }
            if (Convert.ToDouble(this.l6.Text) != double.NegativeInfinity)
            {
                this.chart1.Series["Analysis"].Points.AddXY(this.t6.Text, this.l6.Text);
            }
            if (Convert.ToDouble(this.l7.Text) != double.NegativeInfinity)
            {
                this.chart1.Series["Analysis"].Points.AddXY(this.t7.Text, this.l7.Text);
            }
            if (Convert.ToDouble(this.l8.Text) != double.NegativeInfinity)
            {
                this.chart1.Series["Analysis"].Points.AddXY(this.t8.Text, this.l8.Text);
            }
            if (Convert.ToDouble(this.l9.Text) != double.NegativeInfinity)
            {
                this.chart1.Series["Analysis"].Points.AddXY(this.t9.Text, this.l9.Text);
            }
            if (Convert.ToDouble(this.l10.Text) != double.NegativeInfinity)
            {
                this.chart1.Series["Analysis"].Points.AddXY(this.t10.Text, this.l10.Text);
            }

            

        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if(t1.Text=="0" && t2.Text == "0")
            {
                MessageBox.Show("Enter some input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Chart implemented successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form3 form3 = new Form3(l1.Text, l2.Text, t1.Text, t2.Text);
                form3.Show();
            }
            
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

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (var money in Times)
            {
                money.Text = "0";
            }
            foreach (var con in Conc)
            {
                con.Text = "0";
            }
            foreach (var log in LogC)
            {
                log.Text = null;
            }
            numericUpDown1.Value = 0;
        }
    }
}
