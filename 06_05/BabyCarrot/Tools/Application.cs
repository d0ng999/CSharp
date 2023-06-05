using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyCarrot.Tools
{
    public static class Application
    {
        public static string Root
        {
            get
            {
                // 루트 폴더로 리턴해주는 구문
                return AppDomain.CurrentDomain.BaseDirectory;
            }
        }
    }
}
