using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalShelter
{
    public partial class Form1 : Form
    {
        public Customer Cus1;
        public Customer Cus2;

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateCustomer_Click(object sender, EventArgs e)
        {
            Customer[] customerArray = new Customer[5];
            
            

            Cus1 = new Customer(CusNewFirstName.Text, CusNewLastName.Text,
            DateTime.Parse(CusNewBirthday.Text));
            Cus1.Address = CusNewAddress.Text;
            Cus1.Description = CusNewDescription.Text;

            CusFullName.Text = Cus1.FullName;
            CusAddress.Text = Cus1.Address;
            CusAge.Text = Cus1.Age.ToString(); //속성을 나타내는 방법
            // 이 속성은 바로 위의 GetAge()함수를 쓴 것과 동일한 값을 나타낸다.
            CusDescription.Text = Cus1.Description;
            CusIsQulified.Text = Cus1.IsQulified.ToString();
            // 날짜와 시간을 저장하는 구조체(클래스와 비슷)
            //DateTime date = new DateTime(2023, 2, 5); // 생성자(연도, 월, 일)
            //DateTime Current = DateTime.Now; // 현재의 날짜와 시간이 저장이 된다.
        }
    }
}
   
