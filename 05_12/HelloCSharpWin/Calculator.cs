using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharpWin
{
    public enum Operators { Add, Sub, Multi, Div }

    public partial class Calculator : Form
    {
        public double Result = 0;
        // public double Result1 = 0;
        public bool isNewNum = true;
        public Operators Opt = Operators.Add;

        public Calculator()
        {
            InitializeComponent();
        }

        private void NumberBtn1_Click(object sender, EventArgs e)
            // sender가 버튼의 숫자를 그대로 가져온다.
            // object는 double가 될 수 있고, string이 될 수 있음
        {
            Button numButton = (Button)sender;
            // sender를 (Button)이라는 클래스 타입으로 바꿔서 numButton에 넣어준다.
            SetNum(numButton.Text);  
        }

        public void SetNum(string num)
        {
            if (isNewNum)
            {
                NumScreen.Text = num;
                isNewNum = false;
            }
            else if (NumScreen.Text == "0")
            {
                NumScreen.Text = num;
            }
            else
            {
                NumScreen.Text += num;
            }
            
        }

        private void NumPlus_Click(object sender, EventArgs e)
        {
            if (isNewNum == false)
            {
                double num = double.Parse(NumScreen.Text);
                if (Opt == Operators.Add)
                    Result += num;
                else if (Opt == Operators.Sub)
                    Result -= num;
                else if (Opt == Operators.Multi)
                    Result *= num;
                else if (Opt == Operators.Div)
                    Result = Result / num;

                NumScreen.Text = Result.ToString();
                isNewNum = true;
            }
             
            Button optButton = (Button)sender;
            if (optButton.Text == "+")
                Opt = Operators.Add;
            else if (optButton.Text == "-")
                Opt = Operators.Sub;
            else if (optButton.Text == "*")
                Opt = Operators.Multi;
            else if (optButton.Text == "/")
                Opt = Operators.Div;
        }

        private void NumClear_Click(object sender, EventArgs e)
        {
            Result = 0;
            isNewNum = true;
            Opt = Operators.Add;

            NumScreen.Text = "0";
        }

        private void SqurNum_Click(object sender, EventArgs e)
        {
                double num = double.Parse(NumScreen.Text);
                Result = num * num;

                NumScreen.Text = Result.ToString();
                isNewNum = true;
        }

        private void SmallNum_Click(object sender, EventArgs e)
        {
                double num = double.Parse(NumScreen.Text);
                Result = 1 / num;

                NumScreen.Text = Result.ToString();
                isNewNum = true;
        }
    }
}
