using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SimpleCalculator
{
    public partial class Form1 : Form
    {

        float a, b;
        int count;
        double numericAnswer1;
        bool znak = true;
        int factorial = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void OutputDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void KeyZero_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = OutputDisplay.Text + 0;
        }

        private void KeyOne_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = OutputDisplay.Text + 1;
        }

        private void KeyTwo_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = OutputDisplay.Text + 2;
        }

        private void KeyThree_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = OutputDisplay.Text + 3;
        }

        private void KeyFour_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = OutputDisplay.Text + 4;
        }

        private void KeyFive_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = OutputDisplay.Text + 5;
        }

        private void KeySix_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = OutputDisplay.Text + 6;
        }

        private void KeySeven_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = OutputDisplay.Text + 7;
        }

        private void KeyEight_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = OutputDisplay.Text + 8;
        }

        private void KeyNine_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = OutputDisplay.Text + 9;
        }

        private void KeyPlus_Click(object sender, EventArgs e)
        {
            a = float.Parse(OutputDisplay.Text);
            OutputDisplay.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
            znak = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void KeyEqual_Click(object sender, EventArgs e)
        {
            calculate();
            
        }

        private void KeyPoint_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = OutputDisplay.Text + ",";
        }

        private void KeyMinus_Click(object sender, EventArgs e)
        {
            a = float.Parse(OutputDisplay.Text);
            OutputDisplay.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
            znak = true;
        }

        private void KeyMultiply_Click(object sender, EventArgs e)
        {
            a = float.Parse(OutputDisplay.Text);
            OutputDisplay.Clear();
            count = 3;
            label1.Text = a.ToString() + "*";
            znak = true;
        }

        private void KeyDivide_Click(object sender, EventArgs e)
        {
            a = float.Parse(OutputDisplay.Text);
            OutputDisplay.Clear();
            count = 4;
            label1.Text = a.ToString() + "/";
            znak = true;
        }

        private void KeyClear_Click(object sender, EventArgs e)
        {
            OutputDisplay.Clear();
            OutputDisplay.Text = "";
            label1.Text = "";
        }

        private void KeyExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void KeyDate_Click(object sender, EventArgs e)
        {
            DateTime curDate = new DateTime();
            curDate = DateTime.Now;

            OutputDisplay.Text = String.Concat(curDate.ToShortDateString(), " ", curDate.ToLongTimeString());

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = float.Parse(OutputDisplay.Text);
            OutputDisplay.Clear();
            count = 7;
            label1.Text = a.ToString() + "/" + 1;
            znak = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = float.Parse(OutputDisplay.Text);
            OutputDisplay.Clear();
            count = 6;
            label1.Text = "sqrt" + a.ToString();
            znak = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = float.Parse(OutputDisplay.Text);
            OutputDisplay.Clear();
            count = 5;
            label1.Text = "pow" + a.ToString();
            znak = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = float.Parse(OutputDisplay.Text);
            OutputDisplay.Clear();
            count = 8;
            label1.Text = a.ToString() + "*" + a.ToString();
            znak = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            a = float.Parse(OutputDisplay.Text);
            OutputDisplay.Clear();
            label1.Text = a.ToString() + "!";
            for (int i = 2; i <= a; i++)
            {
                factorial = factorial * i;
            }
            count = 9;
            znak = true;
        }
        

        private void KeySign_Click(object sender, EventArgs e)
        {
            if (OutputDisplay.Text[0] == '-')
                OutputDisplay.Text = OutputDisplay.Text.Remove(0, 1);
            else
                OutputDisplay.Text = "-" + OutputDisplay.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            a = float.Parse(OutputDisplay.Text);
            OutputDisplay.Clear();
            count = 10;
            label1.Text = a.ToString() + "Cub";
            znak = true;
        }

        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(OutputDisplay.Text);
                    OutputDisplay.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(OutputDisplay.Text);
                    OutputDisplay.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(OutputDisplay.Text);
                    OutputDisplay.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(OutputDisplay.Text);
                    OutputDisplay.Text = b.ToString();
                    break;
                case 5:
                    numericAnswer1 = Math.Pow(a, float.Parse(OutputDisplay.Text));
                    OutputDisplay.Text = numericAnswer1.ToString();
                    break;

                case 6:
                    numericAnswer1 = Math.Sqrt(a);
                    OutputDisplay.Text = numericAnswer1.ToString();
                    break;

                case 7:
                    b = 1 / a;
                    OutputDisplay.Text = b.ToString();
                    break;

                case 8:
                    numericAnswer1 = Math.Pow (a, 2);
                    OutputDisplay.Text = numericAnswer1.ToString();
                    break;
                case 9:
                    b = factorial;
                    OutputDisplay.Text = b.ToString();
                    break;
                case 10:
                    numericAnswer1 = Math.Pow(a, 1/3f);
                    OutputDisplay.Text = numericAnswer1.ToString();
                    break;
                default:
                    break;
            }

        }

    }
}
