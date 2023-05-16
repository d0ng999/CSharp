using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AnimalShelter
{
    internal class Customer
    {
        public string FirstName;
        public string LastName;
        private DateTime _Birthday;
        //private int _Age;
        private bool _isQulified;
        public string Address;
        public string Description;


        public Customer(string firstName, string lastName, DateTime birthday)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this._Birthday = birthday;

            this._isQulified = Age >= 18;
        }

        public DateTime Birthday
        {
            get { return _Birthday; }
            set 
            { 
                _Birthday = value; 
                _isQulified = Age >= 18;
            }
        }

        //public int GetAge()
        //{
        //    return _Age;
        //}
        //public void SetAge(int age)
        //{
        //    _Age = age;
        //    _isQulified = _Age >= 18;
        //}
        // 아래의 속성이 위의 Get함수와 Set함수를 합친것과 동일하다.
        // Get매서드는 매개변수가 없는 것이여야 속성으로 만들어 줄 수 있다.
        // Set매서드는 매개변수가 1개 이여야하고,
        // 필드의 데이터 타입과 같은 형태여야 한다.
        public int Age // 속성 = Get함수와 Set함수를 합친
        {
            get { return DateTime.Now.Year - _Birthday.Year; }
            //set
            //{
            //    _Age = value;
            //    // 여기서 value는 int형으로 들어온 매개변수가 된다.
            //    _isQulified = value >= 18;
            //}
        }

        //public bool GetIsQulified()
        //{
        //    return this._isQulified;
        //}

        public bool IsQulified // set이 없는 속성은 보호할 수 있는 장점이 된다.
        {
            get { return this._isQulified; }
            // get만 있고, set이 없는 경우에는 이 값이 보호된다.
            // 이유는, 읽기 전용이 되어서 건들이지 못한다.
        }

        //public string GetFullName()
        //{
        //    return FirstName + " " + LastName;
        //}

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

    }
}
