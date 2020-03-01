using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sample1
    {
        static void Main(string[] args)
        {
            int a = 0;
            //object c = func(a); // a -> object : boxing
            //int v = (int)c; // object -> a : unboxing

            // int -> 문자열서 합치려면 object가 필요 -> ToString() -> boxing
            string st2 = a.ToString(); // string 바로 만들기 때문에 boxing 불필요
            string st = string.Format("abc : {0}", st2);
            Console.WriteLine(st);

            // 값 타입을 object로 바꿀일이 있을때는 무조건 박싱이 일어난다
        }

        // C#의 모든 클래스는 object로 부터 상속 받은 상태이다
        // JAVA도 모든 클래스는 object로부터 상속 받았다.
        // 따라서, 모든 객체나 변수는 object로 변환 가능해야한다 (언어 측면에서)
        // 그렇기 때문에 값 타입을 object로 넘기면 object로 만들고 감싸야해서 boxing이 일어난다
        // 이 내용을 다시 값 타입으로 바꾸면 언박싱
        // 언박싱하고 남은 내용은 쓰레기로 바뀐다
        // 따라서 계속 많이 일어나면 성능이 좋지 않다.

        static object func(object o)
        {
            Console.WriteLine("func");
            return o;
        }
    }
}
