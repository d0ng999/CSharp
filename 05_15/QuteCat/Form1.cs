using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuteCat
{
    public partial class Form1 : Form
    {
        private Cat MyCat = new Cat("Lucas", 1); 
        // private Cat MyCat = new Cat();
        // 이 형태가 기본적인 생성자이다.
        // 기본 생성자는 클래스 내부에 생성자가 없을 때, 생성되는 것이고,
        // 만약 클래스에 생성자가 있다면, 기본적인 생성자는 생성불가능이다.
        // 클래스에 내부에 생성자가 없어도 기본적으로 생성되는 값
        


        public Form1()
        {
            InitializeComponent();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            MyCat.Play();
            CatScreen.Text = MyCat.Express();
        }

        private void Feed_Click(object sender, EventArgs e)
        {
            MyCat.Eat();
            CatScreen.Text = MyCat.Express();
        }

        private void CatTimer_Tick(object sender, EventArgs e)
        {
            MyCat.GetBored();
            CatScreen.Text = MyCat.Express();

        }
    }
}
