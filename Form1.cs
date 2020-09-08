using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p
{
    public partial class Form1 : Form
    {
        Double resultatValue=0;
        String operation = "";
        bool isoperation = false;
 
        public Form1()
        {
           
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Calculator";
        }

      

        private void btnClick(object sender, EventArgs e)
        {

            if ( (textBox1.Text == "0") || (isoperation) ) {
                textBox1.Clear();
            }
            isoperation = false;
            Button b = (Button)sender;

            if(b.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + b.Text;
            }else
                textBox1.Text = textBox1.Text + b.Text;



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void operationClick(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            operation = b.Text;
            resultatValue = Double.Parse(textBox1.Text);
            label.Text = resultatValue + " " + operation;
            isoperation = true;
        }

        private void resultat(object sender, EventArgs e)
        {
            switch(operation)
            {
                case "+" :
                    textBox1.Text = (resultatValue + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (resultatValue - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (resultatValue * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/" :
                    textBox1.Text = (resultatValue / Double.Parse(textBox1.Text)).ToString();
              
                    break;

            }
            resultatValue = Double.Parse(textBox1.Text);
          
        }

        private void aclear(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultatValue = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
