using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzPzCalculator
{
    public partial class Form1 : Form
    {

        enum OPERATOR
        {
            ADD,
            SUBTRACT,
            MULTIPLY,
            DIVIDE
        };

        int Value1 = 0;
        int Value2 = 0;
        OPERATOR OperationToPerform;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Value1 = Int32.Parse(textBox1.Text);
            textBox1.Text = "";
            OperationToPerform = OPERATOR.ADD;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Value1 = Int32.Parse(textBox1.Text);
            textBox1.Text = "";
            OperationToPerform = OPERATOR.SUBTRACT;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Value1 = Int32.Parse(textBox1.Text);
            textBox1.Text = "";
            OperationToPerform = OPERATOR.MULTIPLY;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Value1 = Int32.Parse(textBox1.Text);
            textBox1.Text = "";
            OperationToPerform = OPERATOR.DIVIDE;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Value2 = Int32.Parse(textBox1.Text);
            switch(OperationToPerform)
            {
                case OPERATOR.ADD:
                {
                    int temp = Value1 + Value2;
                    textBox1.Text = "";
                    textBox1.Text = temp.ToString();
                    break;
                }

                case OPERATOR.SUBTRACT:
                {
                    int temp = Value1 - Value2;
                    textBox1.Text = "";
                    textBox1.Text = temp.ToString();
                    break;
                }

                case OPERATOR.MULTIPLY:
                {
                    int temp = Value1 * Value2;
                    textBox1.Text = "";
                    textBox1.Text = temp.ToString();
                    break;
                }
                    
                case OPERATOR.DIVIDE:
                {
                    int temp = Value1 / Value2;
                    textBox1.Text = "";
                    textBox1.Text = temp.ToString();
                    break;
                }
                
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Value1 = 0;
            Value2 = 0;
            textBox1.Text = "";
        }
    }
}
