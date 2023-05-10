using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp
{
    internal class Program
    {
        static void Main(string[] args)
            // args = arguments 배열
        {
            Console.WriteLine("Hello CSharp");
            // WriteLine은 개행이 마지막에 있다.
            Console.WriteLine("Hello " + args[0] + " 입니다");
            // 여기서는 실행하면 args의 인자가 없는 상황이라서 실행하면 에러가 남
            // cmd에서 해봐야함
        }
    }
}
