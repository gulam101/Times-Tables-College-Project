using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timetableles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = ""; //Clears the label in the start

            int counter; //Sets up the loop variable
            int result;

            for (counter = 1;
                counter <= 12; counter++)
            {
                result = counter * 1;
                label1.Text += counter.ToString() + "x1 = " +
                    result.ToString() + "\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = ""; //Clears the label in the start

            int counter; //Sets up the loop variable
            int result;

            for (counter = 1;
                counter <= 12; counter++)
            {
                result = counter * 2;
                label1.Text += counter.ToString() + "x2 = " +
                    result.ToString() + "\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = ""; //Clears the label in the start

            int counter; //Sets up the loop variable
            int result;

            for (counter = 1;
                counter <= 12; counter++)
            {
                result = counter * 3;
                label1.Text += counter.ToString() + "x3 = " +
                    result.ToString() + "\n";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                label1.Text = ""; //Clears the label in the start

                int counter; //Sets up the loop variable
                int result;

                for (counter = 1;
                    counter <= 12; counter++)
                {
                    result = counter * 4;
                    label1.Text += counter.ToString() + "x4 = " +
                        result.ToString() + "\n";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = ""; //Clears the label in the start

            int counter; //Sets up the loop variable
            int result;

            for (counter = 1;
                counter <= 12; counter++)
            {
                result = counter * 5;
                label1.Text += counter.ToString() + "x5 = " +
                    result.ToString() + "\n";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = ""; //Clears the label in the start

            int counter; //Sets up the loop variable
            int result;

            for (counter = 1;
                counter <= 12; counter++)
            {
                result = counter * 6;
                label1.Text += counter.ToString() + "x6 = " +
                    result.ToString() + "\n";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = ""; //Clears the label in the start

            int counter; //Sets up the loop variable
            int result;

            for (counter = 1;
                counter <= 12; counter++)
            {
                result = counter * 7;
                label1.Text += counter.ToString() + "x7 = " +
                    result.ToString() + "\n";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = ""; //Clears the label in the start

            int counter; //Sets up the loop variable
            int result;

            for (counter = 1;
                counter <= 12; counter++)
            {
                result = counter * 8;
                label1.Text += counter.ToString() + "x8 = " +
                    result.ToString() + "\n";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = ""; //Clears the label in the start

            int counter; //Sets up the loop variable
            int result;

            for (counter = 1;
                counter <= 12; counter++)
            {
                result = counter * 9;
                label1.Text += counter.ToString() + "x9 = " +
                    result.ToString() + "\n";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = ""; //Clears the label in the start

            int counter; //Sets up the loop variable
            int result;

            for (counter = 1;
                counter <= 12; counter++)
            {
                result = counter * 10;
                label1.Text += counter.ToString() + "x10 = " +
                    result.ToString() + "\n";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = ""; //Clears the label in the start

            int counter; //Sets up the loop variable
            int result;

            for (counter = 1;
                counter <= 12; counter++)
            {
                result = counter * 11;
                label1.Text += counter.ToString() + "x11 = " +
                    result.ToString() + "\n";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = ""; //Clears the label in the start

            int counter; //Sets up the loop variable
            int result;

            for (counter = 1;
                counter <= 12; counter++)
            {
                result = counter * 12;
                label1.Text += counter.ToString() + "x12 = " +
                    result.ToString() + "\n";
            }
        }

        private void ExitCmd_Click(object sender, EventArgs e)
        {
           var ConfirmBox = MessageBox.Show("Are you sure you want to exit the application?", "Are you sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (ConfirmBox == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}