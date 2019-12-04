using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string lab = string.Empty;
        string a = string.Empty;
        string b = string.Empty;
        char op;
        double result = 0.0;
        public Form1()
        {
            InitializeComponent();
            listBox1.SelectedIndex = 0;
            textBox2.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void seven_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text = input;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text = input;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text = input;
        }

        private void four_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text = input;
        }

        private void five_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text = input;
        }

        private void six_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text = input;
        }

        private void one_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text = input;
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text = input;
        }

        private void three_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text = input;
        }

        private void decPoint_Click(object sender, EventArgs e)
        {
            if (!input.Contains("."))
            {
                this.textBox1.Text = "";
                input += ".";
                this.textBox1.Text = input;
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text = input;
        }

        private void negative_Click(object sender, EventArgs e)
        {
            if (input == "")
            {
                this.textBox1.Text = "";
                input += "-";
                this.textBox1.Text = input;
            }
        }

        private void divBy_Click(object sender, EventArgs e)
        {
            if (input != "")
            {
                a = input;
                op = '/';
                input = string.Empty;
                lab = string.Empty;
                lab += a + op;
                label1.Text = lab;
            }
        }

        private void mulBy_Click(object sender, EventArgs e)
        {
            if (input != "")
            {
                a = input;
                op = '*';
                input = string.Empty;
                lab = string.Empty;
                lab += a + op;
                label1.Text = lab;
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (input != "")
            {
                a = input;
                op = '-';
                input = string.Empty;
                lab = string.Empty;
                lab += a + op;
                label1.Text = lab;
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (input != "")
            {
                a = input;
                op = '+';
                input = string.Empty;
                lab = string.Empty;
                lab += a + op;
                label1.Text = lab;
            }
        }

        private void equals_Click(object sender, EventArgs e)
        {
            b = input;
            double numA = Convert.ToDouble(a);
            double numB = Convert.ToDouble(b);
            lab = string.Empty;
            lab += a + op + b + "=";

            if(op == '/')
            {
                if(numB != 0)
                {
                    result = numA / numB;
                    label1.Text = lab;
                    textBox1.Text = result.ToString();
                    input = result.ToString();
                }
                else
                {
                    textBox1.Text = "Div by 0 error";
                }
            }
            else if(op == '*')
            {
                result = numA * numB;
                label1.Text = lab;
                textBox1.Text = result.ToString();
                input = result.ToString();
            }
            else if (op == '+')
            {
                result = numA + numB;
                label1.Text = lab;
                textBox1.Text = result.ToString();
                input = result.ToString();
            }
            else if (op == '-')
            {
                result = numA - numB;
                label1.Text = lab;
                textBox1.Text = result.ToString();
                input = result.ToString();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.a = string.Empty;
            this.b = string.Empty;
            label1.Text = "";
        }

        private void pi_Click(object sender, EventArgs e)
        {
            a = input;
            double numA = Convert.ToDouble(a);
            lab = string.Empty;
            lab += "π" + a;
            result = numA * 3.14159;
            label1.Text = lab;
            textBox1.Text = result.ToString();
            input = result.ToString();
        }

        private void sqrRoot_Click(object sender, EventArgs e)
        {
            a = input;
            double numA = Convert.ToDouble(a);
            lab = string.Empty;
            lab += "√" + a;
            result = Math.Sqrt(numA);
            label1.Text = lab;
            textBox1.Text = result.ToString();
            input = result.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == 0)
            {
                radioButton1.Text = "Pounds to Euros";
                radioButton2.Text = "Euros to Pounds";
            }
            else if(listBox1.SelectedIndex == 1)
            {
                radioButton1.Text = "Fahrenheit to Celcius";
                radioButton2.Text = "Celcius to Fahrenheit";
            }
            else if(listBox1.SelectedIndex == 2)
            {
                radioButton1.Text = "Feet to Inches";
                radioButton2.Text = "Inches to Feet";
            }
        }

        private void convert_Click(object sender, EventArgs e)
        {
            int decCount = 0;
            int count = 0;
            for(int i = 0; i<textBox2.Text.Length; i++)
            {
                if(i == 0 && textBox2.Text[i] == '-')
                {
                    count++;
                }
                else if (textBox2.Text[i] == '.' && decCount == 0)
                {
                    decCount++;
                    count++;
                }
                else if (Char.IsDigit(textBox2.Text[i]))
                {
                    count++;
                }
            }
            bool canConvert = count == textBox2.Text.Length;
            if (canConvert)
            {
                double val = Convert.ToDouble(textBox2.Text);
                if (listBox1.SelectedIndex == 0)
                {
                    if (radioButton1.Checked)
                    {
                        val = (val / 79) * 100;
                    }
                    else if (radioButton2.Checked)
                    {
                        val *= 0.79;
                    }
                }
                else if (listBox1.SelectedIndex == 1)
                {
                    if (radioButton1.Checked)
                    {
                        val = (val - 32) * 5 / 9;
                    }
                    else if (radioButton2.Checked)
                    {
                        val = (val * 9 / 5) + 32;
                    }
                }
                else if (listBox1.SelectedIndex == 2)
                {
                    if (radioButton1.Checked)
                    {
                        val *= 12;
                    }
                    else if (radioButton2.Checked)
                    {
                        val /= 12;
                    }
                }
                textBox2.Text = val.ToString();
            }
        }

        private void convClear_Click(object sender, EventArgs e)
        {
            textBox2.Text = "0";
        }
    }
}
