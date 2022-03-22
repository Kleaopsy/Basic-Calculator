using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int num1,num2 , operators, equal;
        string num2Me;
        bool startUp = true;
        Button button;
        public void numbers(object Sender ,EventArgs e)
        {
            button = (Sender as Button);
            if (startUp)
            {
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
            }
            else
            {
                num2Me += button.Text;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = true;
            }
            textBox1.Text += button.Text;
        }

        public void operations(object Sender, EventArgs e)
        {
            button = (Sender as Button);
            num1 = Convert.ToInt32(textBox1.Text);
            textBox1.Text += " " + button.Text + " ";

            switch (button.Text)
            {
                case "+":
                    operators = 1;
                    break;
                case "-":
                    operators = 2;
                    break;
                case "*":
                    operators = 3;
                    break;
                case "/":
                    operators = 4;
                    break;
            }

            startUp = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
        }
        public void equalsTo(object Sender, EventArgs e)
        {
            num2 = Convert.ToInt32(num2Me);

            switch (operators)
            {
                case 1:
                    equal = num1 + num2;
                    break;
                case 2:
                    equal = num1 - num2;
                    break;
                case 3:
                    equal = num1 * num2;
                    break;
                case 4:
                    equal = num1 / num2;
                    break;
            }
            textBox1.Text += "  = " + equal.ToString();
        }

        public void C(object Sender, EventArgs e)
        {
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            textBox1.Text = string.Empty;
            startUp = true;
        }
    }
}
