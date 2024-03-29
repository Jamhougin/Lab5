﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//James Hall
//c00007006
//Dec 2019

namespace Lab5
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string lab = string.Empty;
        string a = string.Empty;
        string b = string.Empty;
        char op = 'x';
        double result = 0.0;
        bool sumStr = false;//Used to check if and operator invokes the equals onClick
        public Form1()
        {
            InitializeComponent();
            listBox1.SelectedIndex = 0;
            textBox2.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void enterNum(string n)
        {
            this.textBox1.Text = "";
            input += n;
            this.textBox1.Text = input;
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            enterNum("7");
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            enterNum("8");
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            enterNum("9");
        }

        private void Four_Click(object sender, EventArgs e)
        {
            enterNum("4");
        }

        private void Five_Click(object sender, EventArgs e)
        {
            enterNum("5");
        }

        private void Six_Click(object sender, EventArgs e)
        {
            enterNum("6");
        }

        private void One_Click(object sender, EventArgs e)
        {
            enterNum("1");
        }

        private void Two_Click(object sender, EventArgs e)
        {
            enterNum("2");
        }

        private void Three_Click(object sender, EventArgs e)
        {
            enterNum("3");
        }

        private void DecPoint_Click(object sender, EventArgs e)
        {
            if (!input.Contains("."))
            {
                enterNum(".");
            }
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            enterNum("0");
        }

        private void Negative_Click(object sender, EventArgs e)
        {
            if (input != "")
            { 
                double negPlus = Convert.ToDouble(input);
                negPlus = negPlus * -1;
                input = negPlus.ToString();
                this.textBox1.Text = input;

            }
        }

        private void opChange(char o)
        {
            a = input;
            op = o;
            input = string.Empty;
            lab = string.Empty;
            lab += a + op;
            label1.Text = lab;
            sumStr = true;
        }

        private void DivBy_Click(object sender, EventArgs e)
        {
            if (input != "")
            {
                if (sumStr)
                {
                    Equals_Click(null, EventArgs.Empty);
                }
                opChange('/');
            }
        }

        private void MulBy_Click(object sender, EventArgs e)
        {
            if (input != "")
            {
                if (sumStr)
                {
                    Equals_Click(null, EventArgs.Empty);
                }
                opChange('*');
            }
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (input != "")
            {
                if (sumStr)
                {
                    Equals_Click(null, EventArgs.Empty);
                }
                opChange('-');
            }
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            if (input != "")
            {
                if (sumStr)
                {
                    Equals_Click(null, EventArgs.Empty);
                }
                opChange('+');
            }
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            //Following bool checks for letters in input and a caused by sqrt of negative number returning "NaN"
            bool hasLet = !input.Any(x => char.IsLetter(x)) && !a.Any(x => char.IsLetter(x));
            if (hasLet && input != "" && op != 'x')
            {
                b = input;
                double numA = Convert.ToDouble(a);
                double numB = Convert.ToDouble(b);
                lab = string.Empty;
                lab += a + op + b + "=";

                if (op == '/')
                {
                    if (numB != 0)
                    {
                        result = numA / numB;
                    }
                    else
                    {
                        textBox1.Text = "Div by 0 error";
                        return;
                    }
                }
                else if (op == '*')
                {
                    result = numA * numB;
                }
                else if (op == '+')
                {
                    result = numA + numB;
                }
                else if (op == '-')
                {
                    result = numA - numB;
                }
                label1.Text = lab;
                textBox1.Text = result.ToString();
                input = result.ToString();
                sumStr = false;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.a = string.Empty;
            this.b = string.Empty;
            op = 'x';
            label1.Text = "";
            sumStr = false;
        }

        private void Pi_Click(object sender, EventArgs e)
        {
            bool hasLet = !input.Any(x => char.IsLetter(x)) && !a.Any(x => char.IsLetter(x));
            if (hasLet && input != "")
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
        }

        private void SqrRoot_Click(object sender, EventArgs e)
        {
            bool hasLet = !input.Any(x => char.IsLetter(x)) && !a.Any(x => char.IsLetter(x));
            if (hasLet && input != "")
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
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void Convert_Click(object sender, EventArgs e)
        {
            int decCount = 0;
            int count = 0;
            //Loop and following bool check string to be converted for valid double format
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
            else
            {
                textBox2.Text = "Eh, Number Lad!!";
            }
        }

        private void ConvClear_Click(object sender, EventArgs e)
        {
            textBox2.Text = "0";
        }
    }
}
