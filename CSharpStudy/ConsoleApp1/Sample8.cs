using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sample8
    {
        class Test
        {
            // static 생성자
            // static 개념이 인스턴스 상관없이 딱 하나
            // Test라는 것 자체를 쓸 때 최초 1회만 호출
            // static이라는 것은 객체 종속적이지 않습니다.
            int v;
            public static int Value { get; set; }
            
            // static 생성자는 실제 객체 생성자가 아니라, 사용하려고 할 때 최초 1회만 불리는 함수입니다
            static  Test()
            {
                //v = 1; // 대체 누굴껄 써야하지??? 알수가 없다! 오류
                Value = 1; // static 변수는 딱 하나밖에 없기 때문에 static 생성자에서 쓸 수 있습니다

                Console.WriteLine("Static Test");
            }

            // 생성자 : 각 객체가 생성될 때 호출되는 함수
            public Test(int v)
            {
                Console.WriteLine("Test" + v);
            }

            // 소멸자 : 객체가 소멸될 때 호출되는 함수
            ~Test()
            {
                Console.WriteLine("~Test");
            }
        }

        public static void Main()
        {
            var v1 = Test.Value;
            Test t1 = new Test(1); // t1이라는 객체
            Test t2 = new Test(2); // t2이라는 객체
            // static은 t1이든 t2든 객체종속적이 아니기 때문에 신경을 쓰지 않습니다
        }
    }
}
