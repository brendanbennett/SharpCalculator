using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class SharpCalculator : Form
    {
        public void inputNum(int number)
        {
            if (display.Text != "0")
            {
                string[] displayJoin = new string[] { display.Text, number.ToString() };
                display.Text = string.Join("", displayJoin);
            }
            else
            {
                display.Text = number.ToString();
            }
        }
        public SharpCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            inputNum(5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inputNum(7);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inputNum(8);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            inputNum(4);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            inputNum(6);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            inputNum(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            inputNum(1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            inputNum(2);
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            inputNum(3);
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            inputNum(0);
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (display.Text.Length <= 1)
            {
                display.Text = "0";
            }
            else if (display.Text != "0")
            {
                display.Text = display.Text.Substring(0, display.Text.Length - 1);
            }
            
        }

        private void clearEntry_Click(object sender, EventArgs e)
        {
            display.Text = "0";
        }
    }
    
}
