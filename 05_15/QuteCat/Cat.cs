using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuteCat
{
    public class Cat
    {
        public string Name;
        public int Age;

        private int Happiness = 50;

        public Cat(string name, int age) // 기본 생성자이다.
        {
            this.Name = name; // this는 내부에서 사용할 수 있는 키워드
            // this는 그 클래스의 현재 인스턴스를 가리킨다.
            // 따라서, this.Name은 클래스 초반부에서 생성한 인스턴스를 말한다.
            // 만약, 인스턴스의 변수명과 생성자에 사용되는 매개변수의 명이
            // 같게 되면, 이는 컴파일상에서 오류를 일으킬 수 있는
            // 상황이 되기 때문이다. 
            this.Age = age;
        }

        public void GetBored()
        {
            Happiness -= 10;

            if (Happiness < 0)
                Happiness = 0;
        }

        public void Play()
        {
            Happiness += 10;

            if (Happiness > 100) 
                Happiness = 100;

        }

        public void Eat()
        {
            Happiness += 20;
            if (Happiness > 100)
                Happiness = 100;

        }

        public string Express()
        {
            string message = "";
            if (Happiness >= 80)
                message = "I'm very happy";
            else if (Happiness >= 60)
                message = "I'm happy";
            else if (Happiness >= 40)
                message = "I'm so so";
            else if (Happiness >= 20)
                message = "I'm gloomy";
            else
                message = "I'm sad";

            return this.Name + " : " + message;
        }
    } 
}
