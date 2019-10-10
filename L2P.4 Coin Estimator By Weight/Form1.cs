using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L2P._4_Coin_Estimator_By_Weight
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            //ruft die umrechnungsfunktion und fragt die einzelnen Textboxes nach inhalt ab
            Umrechnung();



            Double.TryParse(richTextBox1.Text, out double white);
            richTextBox71.Text = Convert.ToString(Math.Round(white / (120 * Umrechnung())));
            richTextBox61.Text = Convert.ToString(Math.Round((white / (120 * Umrechnung())) / 50));


            Double.TryParse(richTextBox2.Text, out double gray);
            richTextBox72.Text = Convert.ToString(Math.Round(gray / (155 * Umrechnung())));
            richTextBox62.Text = Convert.ToString(Math.Round((gray / (155 * Umrechnung())) / 50));



            Double.TryParse(richTextBox3.Text, out double red);
            richTextBox73.Text = Convert.ToString(Math.Round(red / (195 * Umrechnung())));
            richTextBox63.Text = Convert.ToString(Math.Round((red / (195 * Umrechnung())) / 50));


            Double.TryParse(richTextBox4.Text, out double blue);
            richTextBox74.Text = Convert.ToString(Math.Round(blue / (164 * Umrechnung())));
            richTextBox64.Text = Convert.ToString(Math.Round((blue / (164 * Umrechnung())) / 40));



            Double.TryParse(richTextBox5.Text, out double orange);
            richTextBox75.Text = Convert.ToString(Math.Round(orange / (233.2 * Umrechnung())));
            richTextBox65.Text = Convert.ToString(Math.Round((orange / (233.2 * Umrechnung())) / 40));



            double.TryParse(richTextBox6.Text, out double green);
            richTextBox76.Text = Convert.ToString(Math.Round(green / (313.2 * Umrechnung())));
            richTextBox66.Text = Convert.ToString(Math.Round((green / (313.2 * Umrechnung())) / 40));



            Double.TryParse(richTextBox7.Text, out double yellow);
            richTextBox77.Text = Convert.ToString(Math.Round(yellow / (189.3 * Umrechnung())));
            richTextBox67.Text = Convert.ToString(Math.Round((yellow / (189.3 * Umrechnung())) / 25));

            Double.TryParse(richTextBox8.Text, out double purple);
            richTextBox78.Text = Convert.ToString(Math.Round(purple / (207.5 * Umrechnung())));
            richTextBox68.Text = Convert.ToString(Math.Round((purple / (207.5 * Umrechnung())) / 25));



        }

        private double Umrechnung()
        {
            if (checkBox1.Checked == true && checkBox2.Checked == false)
            {
                label21.Text = " ";

                const double umrechnugsfaktor = 1;      //umrechnung bleibt in gramm
                return umrechnugsfaktor;
            }


            else if (checkBox1.Checked == false && checkBox2.Checked == true)
            {
                label21.Text = " ";
                const double umrechnugsfaktor = 0.00220462;    //umrechnung von gramm in pounds
                return umrechnugsfaktor;
            }
            else
            {
                label21.Text = "Nur eine Maßeinheit auswählen";
                const double umrechnugsfaktor = 1;
                return umrechnugsfaktor;
            }
        }

        private void checkBox2_CheckedChanged_2(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox2.Checked == false)
            {
                label51.Text = "gramm";
                label52.Text = "gramm";
                label53.Text = "gramm";
                label54.Text = "gramm";
                label55.Text = "gramm";
                label56.Text = "gramm";
                label57.Text = "gramm";
                label58.Text = "gramm";
            }
            else if (checkBox1.Checked == false && checkBox2.Checked == true)
            {
                label51.Text = "pound";
                label52.Text = "pound";
                label53.Text = "pound";
                label54.Text = "pound";
                label55.Text = "pound";
                label56.Text = "pound";
                label57.Text = "pound";
                label58.Text = "pound";
            }
        }

        private void richTextBox16_TextChanged(object sender, EventArgs e)
        {

        }
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {

                foreach (Control c in this.Controls)

                    if (c is RichTextBox)

                        (c as RichTextBox).Clear();

            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}





/*              [Project] Coin Estimator By Weight
         Color 	Denomination 	Count 	Total Value 	Weight (g)
	    White 	1c 	50 	€0.50 	                                     120
	    Gray 	2c 	50 	€1.00 	                                     155
	    Red 	5c 	50 	€2.50 	                                      195
	    Blue 	10c 	40 	€4.00 	                                 164
	    Orange 	20c 	40 	€8.00 	                                      233.2
	    Green 	50c 	40 	€20.00 	                                    313.2
	    Yellow 	€1 	25 	€25.00 	                                    189.3
	    Purple 	€2 	25 	€50.00 	207.5  */
