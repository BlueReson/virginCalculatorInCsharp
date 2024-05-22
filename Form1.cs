using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace virginCalculatorInCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Varibles ---------------------------------------------------------------------------
        string first = "", second = "", memory = "", userInput = "";
        char function;
        double result = 0.0;
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // bttn 1 ...    ----------------- Button Clics ----------------------
        {
            calculatorDisplay.Text = ""; // resets default value 0
            userInput += button1.Text; // ads buttom value i.e. "1"
            calculatorDisplay.Text += userInput; // update userinput

        }

        private void button2_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += button2.Text;
            calculatorDisplay.Text += userInput;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += button3.Text;
            calculatorDisplay.Text += userInput;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += button4.Text;
            calculatorDisplay.Text += userInput;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += button5.Text;
            calculatorDisplay.Text += userInput;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += button6.Text;
            calculatorDisplay.Text += userInput;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += button7.Text;
            calculatorDisplay.Text += userInput;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += button8.Text;
            calculatorDisplay.Text += userInput;
        }

        private void button9_Click(object sender, EventArgs e) // ... bttn 9
        {
            calculatorDisplay.Text = "";
            userInput += button9.Text;
            calculatorDisplay.Text += userInput;
        }

        private void button10_Click(object sender, EventArgs e) // 0 button
        {
            calculatorDisplay.Text = "";
            userInput += button10.Text;
            calculatorDisplay.Text += userInput;
        } // -------------------------------------------- end of bttn numbers-------------------


        private void button11_Click_1(object sender, EventArgs e) // backspace
        {

        }


        private void button12_Click(object sender, EventArgs e) // .
        {
            calculatorDisplay.Text += calculatorDisplay.Text + button12.Text;
        }

        private void button13_Click(object sender, EventArgs e) // =
        {
            second = userInput;
            double firstNum , secondNum ;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);
                        
            // add
            if (function == '+')
            {
                result = firstNum + secondNum;
                calculatorDisplay.Text = result.ToString();
                memory = firstNum.ToString();
                textBox2.Text += memory;
            }
            // minus
            else if (function == '-')
            { 
                result= firstNum - secondNum;
                calculatorDisplay.Text = result.ToString();
                memory = firstNum.ToString();
                textBox2.Text += memory;
            }
            // multiply
            else if (function == '*')
            {
                result= firstNum * secondNum;
                calculatorDisplay.Text = result.ToString();
                memory = firstNum.ToString();
                textBox2.Text += memory;
            }
            // devide
            else if (function == '/')
            {
                if (secondNum == '0')
                {
                    calculatorDisplay.Text = "Syntax Error! try again";
                }
                else 
                {
                    result =  firstNum / secondNum;
                    calculatorDisplay.Text = result.ToString();
                    memory = firstNum.ToString();
                    textBox2.Text += memory;
                }
            }
            // modulo
            else if (function == '%')
            {
                result = firstNum % secondNum;
                calculatorDisplay.Text = result.ToString();
                memory = firstNum.ToString();
                textBox2.Text += memory;
            }
        }
        private void button14_Click(object sender, EventArgs e) // +
        {
            function = '+';
            first = userInput;
            userInput = "";
        }
        private void button15_Click(object sender, EventArgs e) // -
        {
            function = '-';
            first = userInput;
            userInput = "";
        }

        private void button16_Click(object sender, EventArgs e) // *
        {
            function = '*';
            first = userInput;
            userInput = "";
            // num1 = int.Parse(calculatorDisplay.Text);
            // textBox2.Text = num1.ToString();
            // 
            // calculatorDisplay.Text = ("");
        }

        private void button17_Click(object sender, EventArgs e) // /
        {
            function = '/';
            first = userInput;
            userInput = "";

            // ptions = "/";
            // um1 = int.Parse(calculatorDisplay.Text);
            // extBox2.Text = num1.ToString();
            // 
            // alculatorDisplay.Text = ("");
        }

        private void button18_Click(object sender, EventArgs e) // C
        {
            first = "";
            second = "";
            memory = userInput;
            textBox2.Text = memory;
            userInput = "";
            result = 0.0;
            calculatorDisplay.Text = "";

        }

        private void button19_Click(object sender, EventArgs e) // Get / set Memory
        {
        if (Int32.Parse(memory) == 0) 
            {
                textBox2.Text = "def memory";
                userInput = "";

            }
        else // 
            { 
                calculatorDisplay.Text += memory; // store previous entry to memory
                userInput += memory; 
            }
        }
        private void button20_Click(object sender, EventArgs e)  // %     
        {
            function = '%';
            first = userInput;
            userInput = "";
        }
            // ----------------------------------------------------------------------- operators ------------------------------------------------

            /*private void Form1_Keydown(object sender, KeyEventArgs e) //
            {

                if (e.KeyCode == (Keys.NumPad1) || e.KeyCode == (Keys.D1))
                {
                    button1_Click(sender, e);
                }
            } 

            private void Form1_KeyDown(object sender, KeyEventArgs e) // 
            {
                if (e.KeyCode == (Keys.NumPad1) || e.KeyCode == (Keys.D1))
                {
                    button1_Click(sender, e);
                }
            } */

            private void Form1_Keydown(object sender, KeyEventArgs e) // -------- numbers on keyboard events ----
        {
            switch (((Form)sender).Name)
            {
                case "1":
                    if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
                    {
                        button1_Click(sender, e);
                    }
                    break;
                case "2":
                    if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
                    {
                        button2_Click(sender, e);
                    }
                    break;
                case "3":
                    if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
                    {
                        button3_Click(sender, e);
                    }
                    break;
                case "4":
                    if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
                    {
                        button4_Click(sender, e);
                    }
                    break;
                case "5":
                    if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
                    {
                        button5_Click(sender, e);
                    }
                    break;
                case "6":
                    if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
                    {
                        button6_Click(sender, e);
                    }
                    break;
                case "7":
                    if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
                    {
                        button7_Click(sender, e);
                    }
                    break;
                case "8":
                    if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
                    {
                        button8_Click(sender, e);
                    }
                    break;
                case "9":
                    if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
                    {
                        button9_Click(sender, e);
                    }
                    break;
                case "0":
                    if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
                    {
                        button10_Click(sender, e);
                    }
                    break;
                case "return": // backspace
                    if (e.KeyCode == Keys.Return)
                    {
                        button11_Click_1(sender, e);
                    }
                    break;
                case "=":                                                     // ----------------------------- keyboard events ---------------------
                    if (e.KeyCode == Keys.Home || e.KeyCode == Keys.Enter)
                    {
                        button13_Click(sender, e);
                    }
                    break;
                case "+":
                    if (e.KeyCode == Keys.Add)
                    {
                        button14_Click(sender, e);
                    }
                    break;
                case "-":
                    if (e.KeyCode == Keys.Subtract)
                    {
                        button15_Click(sender, e);
                    }
                    break;
                case "*":
                    if (e.KeyCode == Keys.Multiply)
                    {
                        button16_Click(sender, e);
                    }
                    break;
                case "/":
                    if (e.KeyCode == Keys.Divide)
                    {
                        button17_Click(sender, e);
                    }
                    break;
                case "C":
                    if (e.KeyCode == Keys.C)
                    {
                        button18_Click(sender, e);
                    }
                    break;
                case "M+":
                    if (e.KeyCode == Keys.M)
                    {
                        button19_Click(sender, e);
                    }
                    break;
            }
        }
    }
}// ---------------------------------------------- 

