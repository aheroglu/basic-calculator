using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Variables ------------------------------->
        double firstNumber, secondNumber, result;
        bool firstNumberStatus, secondNumberStatus;
        string oprt;
        // <----------------------------------------- 

        void Start()
        {
            input.Text = "0";
            //input.ReadOnly = true;
            firstNumberStatus = true;
            secondNumberStatus = false;
            //Yeni kod
            int sayi = 3;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Start();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (input.Text == "0" && firstNumberStatus == true)
            {
                input.Text = "0";
            }
            else
            {
                input.Text = input.Text + "0";
            }


        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (input.Text == "0" && firstNumberStatus == true)
            {
                input.Text = "1";
                firstNumberStatus = false;
            }
            else
            {
                input.Text = input.Text + "1";
                firstNumberStatus = false;
            }


        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (input.Text == "0" && firstNumberStatus == true)
            {
                input.Text = "2";
            }
            else
            {
                input.Text = input.Text + "2";
            }


        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (input.Text == "0" && firstNumberStatus == true)
            {
                input.Text = "3";
            }
            else
            {
                input.Text = input.Text + "3";
            }


        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (input.Text == "0" && firstNumberStatus == true)
            {
                input.Text = "4";
            }
            else
            {
                input.Text = input.Text + "4";
            }


        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (input.Text == "0" && firstNumberStatus == true)
            {
                input.Text = "5";
            }
            else
            {
                input.Text = input.Text + "5";
            }


        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (input.Text == "0" && firstNumberStatus == true)
            {
                input.Text = "6";
            }
            else
            {
                input.Text = input.Text + "6";
            }


        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (input.Text == "0" && firstNumberStatus == true)
            {
                input.Text = "7";
            }
            else
            {
                input.Text = input.Text + "7";
            }


        }
        private void btn8_Click(object sender, EventArgs e)
        {
            if (input.Text == "0" && firstNumberStatus == true)
            {
                input.Text = "8";
            }
            else
            {
                input.Text = input.Text + "8";
            }


        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (input.Text == "0" && firstNumberStatus == true)
            {
                input.Text = "9";
            }
            else
            {
                input.Text = input.Text + "9";
            }

        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            if (input.Text.Contains(","))
            {
                btnComma.Enabled = false;
            }

            else
            {
                input.Text = input.Text + ",";
            }

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            input.Text = "";
            firstNumber = 0;
            secondNumber = 0;
            firstNumberStatus = true;
            firstNumberStatus = false;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            oprt = "+";
            firstNumber = Convert.ToDouble(input.Text);
            firstNumberStatus = false;
            input.Clear();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            oprt = "-";
            firstNumber = Convert.ToDouble(input.Text);
            firstNumberStatus = false;
            input.Clear();
        }

        private void btnCross_Click(object sender, EventArgs e)
        {
            oprt = "*";
            firstNumber = Convert.ToDouble(input.Text);
            firstNumberStatus = false;
            input.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            oprt = "/";
            firstNumber = Convert.ToDouble(input.Text);
            firstNumberStatus = false;
            input.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            secondNumber = Convert.ToDouble(input.Text);

            if (oprt == "+")
            {
                result = firstNumber + secondNumber;
                result = Math.Round(result, 2);
                input.Text = Convert.ToString(result);
            }

            if (oprt == "-")
            {
                result = firstNumber - secondNumber;
                result = Math.Round(result, 2);
                input.Text = Convert.ToString(result);
            }

            if (oprt == "*")
            {
                result = firstNumber * secondNumber;
                result = Math.Round(result, 2);
                input.Text = Convert.ToString(result);
            }

            if (oprt == "/")
            {
                result = firstNumber / secondNumber;
                result = Math.Round(result, 2);
                input.Text = Convert.ToString(result);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


    }
}
