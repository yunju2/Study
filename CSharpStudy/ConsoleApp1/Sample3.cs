using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sample3
    {
        public static void Main()
        {
            int a = 2;
            // string.Format("a :  {1} {0}", a, 5);
            // $"a : {a} {5}"
            // @"c:\abc\def"

            // char 배열
            string abc = "abc";
            // string abc = new string("abc");
            abc = "def";
            // 별도의 객체를 만드는 것 사실상
            // C# 스트링은 불변 객체이다 (내용이 바뀌지 않는다)

            abc = "def"; // 내용이 바뀌는게 아니라 가리키는 대상이 바뀌는 것
        }
    }
}
