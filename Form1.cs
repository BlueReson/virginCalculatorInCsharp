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
        string calTotal;
        int num1;
        int num2;
        string options;
        int result;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // bttn 1 ...    Button Clics ----------------------
        {
            textBox1.Text = textBox1.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e) // ... bttn 9
        {
            textBox1.Text = textBox1.Text + button9.Text;
        }

        private void button10_Click(object sender, EventArgs e) // 0 button
        {
            textBox1.Text = textBox1.Text + button10.Text;
        }

                    

        /*private void button11_Click(object sender, EventArgs e) // ←   --- operators ------------------------------------------------
        {

        }*/

        private void button12_Click(object sender, EventArgs e) // ,
        {
            
        }
        
        private void button13_Click(object sender, EventArgs e) // =
        {
            num2 = int.Parse(textBox1.Text);

            if (options == "+") result = num1 + num2;
            if (options == "-") result = num1 - num2;
            if (options == "*") result = num1 * num2;
            if (options == "/") result = num1 / num2;
            if (options == "%") result = num1 % num2;
            
            calTotal = result + "";
        }
        private void button14_Click(object sender, EventArgs e) // +
        {
            options = "+";
            num1 = int.Parse(textBox1.Text);
            textBox2.Text = num1.ToString();

            textBox1.Text = (""); 
        }
        private void button15_Click(object sender, EventArgs e) // -
        {
            options = "-";
            num1 = int.Parse(textBox1.Text);
            textBox2.Text = num1.ToString();

            textBox1.Text = ("");
        }

        private void button16_Click(object sender, EventArgs e) // *
        {
            options = "*";
            num1 = int.Parse(textBox1.Text);
            textBox2.Text = num1.ToString();

            textBox1.Text = ("");
        }

        private void button17_Click(object sender, EventArgs e) // /
        {

            options = "/";
            num1 = int.Parse(textBox1.Text);
            textBox2.Text = num1.ToString();

            textBox1.Text = ("");
        }

        private void button18_Click(object sender, EventArgs e) // C
        {
                      
        }

        private void button19_Click(object sender, EventArgs e) // CE
        {
            textBox1.Clear();
            textBox2.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }

        private void button20_Click(object sender, EventArgs e)  // %     
        {

            options = "%";
            num1 = int.Parse(textBox1.Text);
            textBox2.Text = num1.ToString();

            textBox1.Text = ("");
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
                    
                }
                   
                // ---------------------------------------------- 
        }

        
    }
}
     




