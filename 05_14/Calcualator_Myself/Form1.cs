using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Calcualator_Myself
{
    
    public enum Operators { Add, Sub, Multi, Div, Equal, Double, Sqrt, OneDiv };

    public partial class Form1 : Form
    {
        public bool isNewNum = true;
        public Operators Opt = Operators.Add;
        public double Result = 0;
        public bool ishave = true;
 

        public Form1()
        {
            InitializeComponent();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            SetNum(numButton.Text);
        }

        public void SetNum(string num)
        {
            if (isNewNum)
            {
                NumScreen1.Text = num;
                if (ishave = NumScreen2.Text.Contains("="))
                {
                    NumScreen2.Text = "";
                }
                if (Result == 0)
                {
                    NumScreen2.Text = "";
                }

                NumScreen2.Text += num;

                isNewNum = false;
            }

            else
            {
                NumScreen1.Text += num;
                NumScreen2.Text += num;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double num = double.Parse(NumScreen1.Text);

            if (isNewNum == false)
            {

                if (Opt == Operators.Add)
                {
                    Result += num;
                }
                else if (Opt == Operators.Sub)
                {
                    Result -= num;
                }
                else if (Opt == Operators.Multi)
                {
                    Result *= num;
                }
                else if (Opt == Operators.Div)
                {
                    Result /= num;
                }
                else if (Opt == Operators.Equal)
                {
                    NumScreen1.Text = Result.ToString();
                    Result = num;
                }

                isNewNum = true;
            }

            NumScreen1.Text = Result.ToString();

            Button mark = (Button)sender;

            if (mark.Text == "+")
            {
                Opt = Operators.Add;
                NumScreen2.Text += mark.Text;

            }
            else if (mark.Text == "-")
            {
                Opt = Operators.Sub;
                NumScreen2.Text += mark.Text;

            }
            else if(mark.Text == "*")
            {
                Opt = Operators.Multi;
                NumScreen2.Text += mark.Text;

            }
            else if(mark.Text == "/")
            {
                Opt = Operators.Div;
                NumScreen2.Text += mark.Text;

            }
            else if (mark.Text == "=")
            {
                Opt = Operators.Equal;
                MatchCollection matches = Regex.Matches(NumScreen2.Text, "=");
                int cnt = matches.Count;

                if (cnt == 1)
                {
                    NumScreen2.Text = NumScreen2.Text;
                }
                else
                {
                    NumScreen2.Text += mark.Text;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NumScreen1.Text = "0";
            NumScreen2.Text = "";
            Result = 0;
            isNewNum = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double num = double.Parse(NumScreen1.Text);
            Result = 1 / num;
            NumScreen1.Text = Result.ToString();
            NumScreen2.Text = ("1/" + num);
            isNewNum = true;
            Result = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double num = double.Parse(NumScreen1.Text);
            Result = num * num;
            NumScreen1.Text = Result.ToString();
            NumScreen2.Text = ("sqr(" + num + ")");
            isNewNum = true;
            Result = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double num = double.Parse(NumScreen1.Text);
            Result = Math.Sqrt(num);
            NumScreen1.Text = Result.ToString();
            NumScreen2.Text = ("sqrt(" + num + ")");
            isNewNum = true;
            Result = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumScreen1.Text = "0";
            isNewNum = true;
        }
    }
}
