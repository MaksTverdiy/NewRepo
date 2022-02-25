using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    
    public partial class Form1 : Form
    {
        float a, b;
        int oper;
        bool znak = true;
        string key_unlock;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Обработчик оператора "+"
            if (key_unlock == "unlock")
            {
                a = float.Parse(textBox1.Text);
                textBox1.Clear();
                oper = 1;
                label1.Text = a.ToString() + "+";
                znak = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Обработчик оператора "/"
            if (key_unlock == "unlock")
            {
                a = float.Parse(textBox1.Text);
                textBox1.Clear();
                oper = 4;
                label1.Text = a.ToString() + "/";
                znak = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if (znak == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            // Обработчик цифровой кнопки "0"

            textBox1.Text = textBox1.Text + 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // Обработчик цифровой кнопки "1"

            textBox1.Text = textBox1.Text + 1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // Обработчик цифровой кнопки "2"

            textBox1.Text = textBox1.Text + 2;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Обработчик цифровой кнопки "3"

            textBox1.Text = textBox1.Text + 3;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // Обработчик цифровой кнопки "4"

            textBox1.Text = textBox1.Text + 4;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // Обработчик цифровой кнопки "5"

            textBox1.Text = textBox1.Text + 5;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Обработчик цифровой кнопки "6"

            textBox1.Text = textBox1.Text + 6;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // Обработчик цифровой кнопки "7"

            textBox1.Text = textBox1.Text + 7;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Обработчик цифровой кнопки "8"

            textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Обработчик цифровой кнопки "9"

            textBox1.Text = textBox1.Text + 9;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Обработчик оператора "-"
            if (key_unlock == "unlock")
            {
                a = float.Parse(textBox1.Text);
                textBox1.Clear();
                oper = 2;
                label1.Text = a.ToString() + "-";
                znak = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Обработчик оператора "*"
            if (key_unlock == "unlock")
            {
                a = float.Parse(textBox1.Text);
                textBox1.Clear();
                oper = 3;
                label1.Text = a.ToString() + "*";
                znak = true;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // вызов функции
            calculate();
            label1.Text = "";

        }
        private void calculate()
        {
            switch (oper)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:

                    if (float.Parse(textBox1.Text) == 0)
                    { textBox1.Text = "Делить на 0 нельзя!"; }
                    else
                    {
                        b = a / float.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                    }
                    break;
                default:
                    break;
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            key_unlock = textBox2.Text;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

    }
}

