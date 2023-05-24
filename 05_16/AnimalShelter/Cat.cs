using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    internal class Cat : Pet
    {
        public Cat(int petId, string name, string color, string gender)
            : base(petId, name, color, gender) // 상속을 받은 경우
            // 자식 클래스에는 base(매개변수)를 써준다.
        {
        }

        public override string MakeSound() 
            // 부모클래스에서 같은 이름의 메서드
            // 가상 메서드를 활용하려면 자식 클래스에 override를 사용해주어야
            // 한다.
        {
            return "야옹";
        }

        public string Scracth()
        {
            return "햝퀴기";
        }

    }
}
