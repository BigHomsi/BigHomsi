using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InlämningMin
{
    public partial class Form1 : Form
    {

        //Hej Github
        bool harkomma = false;
        double första = 0;
        double andra = 0;

        public Form1()
        {
            InitializeComponent();



        }

        private void Siffra_Click(object sender, EventArgs e)
        {

            Button nubutton = (Button)sender;

            richTextBox1.Text += nubutton.Text;


        }



        private void LikaMed_Click(object sender, EventArgs e)
        {
            andra = double.Parse(richTextBox1.Text);

            double sum = första + andra;

            richTextBox1.Text = sum.ToString();



        }

        private void Button4_Click(object sender, EventArgs e)
        {
            
            richTextBox1.Text = (1 / double.Parse(richTextBox1.Text)).ToString();

        }

        private void Komma_Click(object sender, EventArgs e)
        {
            if (harkomma == false)
            {
                richTextBox1.Text += ",";
                harkomma = true;
            }
        }

        private void Plus_Click(object sender, EventArgs e)
        {
           

        }


        private void Minus_Click(object sender, EventArgs e)
        {
            första = double.Parse(richTextBox1.Text);

            Reset();
        }

        private void Multiplikation_Click(object sender, EventArgs e)
        {

        }

        private void Division_Click(object sender, EventArgs e)
        {

        }

        private void Ta_bort_Click(object sender, EventArgs e)
        {

        }

        private void Ta_bort_en_rad_Click(object sender, EventArgs e)
        {

        }

        private void Ta_bort_allt_i_minne_Click(object sender, EventArgs e)
        {

            Reset_Allt();

        }

        private void Minus_tecken_Click(object sender, EventArgs e)
        {

        }

        private void Roten_ur_Click(object sender, EventArgs e)
        {

            richTextBox1.Text = Math.Sqrt(double.Parse(richTextBox1.Text)).ToString();


        }

        private void Prosent_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = ((double.Parse(richTextBox1.Text)) / 100).ToString();

        }

        //
        //
        
          private void Reset()
        {
            richTextBox1.Clear();
            harkomma = false;
        }
        private void Reset_Allt()
        {
            första = 0;
            andra = 0;
            Reset();
        }

        private void Plus()
        {
            första = double.Parse(richTextBox1.Text);
           

            andra = double.Parse(richTextBox1.Text);

            double sum = första + andra;

            richTextBox1.Text = sum.ToString();

        }
    
    }
}

