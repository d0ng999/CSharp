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
using System.Collections;
using AnimalShelter;

namespace AnimalShelter
{
    internal partial class Form1 : Form
    {
        public List<Customer> Customers = new List<Customer>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateCustomer_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer(CusNewFirstName.Text, CusNewLastName.Text,
            DateTime.Parse(CusNewBirthday.Text));

            cus.Address = CusNewAddress.Text;
            cus.Description = CusNewDescription.Text;

            CusList.Rows.Add(cus.FirstName, cus.Age, cus.IsQulified);

            Customers.Add(cus);
            CusNewFirstName.Text = "";
            CusNewLastName.Text = "";
            CusNewBirthday.Text = "";
            CusNewAddress.Text = "";
            CusNewDescription.Text = "";
        }

        public void ShowDetails(Customer cus)
        {
            CusFullName.Text = cus.FullName;
            CusAge.Text = cus.Age.ToString();
            CusAddress.Text = cus.Address;
            CusDescription.Text = cus.Description;
            CusIsQulified.Text = cus.IsQulified.ToString();
        }

        private void CusList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string firstName = (string)CusList.Rows[e.RowIndex].Cells[0].Value;

            foreach (Customer cus in Customers)
            {
                if (cus.FirstName == firstName)
                {
                    ShowDetails(cus);
                    break;
                }
            }

            CusDetailPanel.Show();
            CusNewPanel.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CusListPanel.Dock = DockStyle.Fill;
            CusDetailPanel.Dock = DockStyle.Right;
            CusNewPanel.Dock = DockStyle.Right;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CusNewPanel.Show();
            CusDetailPanel.Hide();
        }
    }
}

//private void button1_Click(object sender, EventArgs e)
//{
//    ArrayList arrayList = new ArrayList();
//    arrayList.Add(0);
//    arrayList.Add("Hi");
//    arrayList.Add(new Customer("First", "Last", new DateTime(2000, 2, 2));
//    arrayList.Add(3);

//    arrayList.Insert(2, 2); // 인덱스가 2인 곳에 2를 집어넣는다.

//    arrayList.Remove(2); // 2라는 값을 가진 인덱스를 제거
//    arrayList.RemoveAt(1); // 인덱스가 1인 값을 제거

//    int sum = 0;
//    for (int index = 0; index < arrayList.Count; index++)
//    {
//        int num = (int)arrayList[index];
//        // int형으로 만들어 주는 이유는 ArrayList의 값의 자료형태는
//        // object를 사용한다.
//        // object는 int, string, float등 모든 자료형이 가능한 형태이다.
//        sum += num;
//    }

//    //List<T> // T에 저장 관리를 할 타입이 온다.

//    //int[] intArray = new int[5];
//    //// 5개의 저장공간을 가진 int형 배열
//    //ArrayList arrayList1 = new ArrayList();
//    // ArrayList라는 클래스를 생성
//    List<int> intList = new List<int>();
//    // 여기 List<int>는 ArrayList와 정확하게 동일한 기능을 가지지만,
//    // ArrayList는 object 타입이고, List<int>는 오직 int만 집어넣을 수 있다.
//    // List<type>은 형변환 없이 미리 지정해서 사용하는 용도
//    // 이유는 형변환을 해줄 때, 그 배열의 크기가 커지면 용량이 커져서 느려질 수 있다.
//    intList.Add(1);
//    intList.Add(2);
//    // 선언시에 int만을 저장하기로 선언했기에, 다른 타입은 저장 불가능

//    int sum2 = 0;
//    for (int index = 0; index < intList.Count; index++)
//    {
//        int value = intList[index];
//        sum2 += value;
//    }
//}