using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sample7
    {
        class Test
        {
            // static은 클래스당 하나만 존재합니다 (사실상 전역변수)
            public static int Value;

            public int v;
            public string name;
            //public double b;
            //.....
            public void setValue(int a2)
            {
                Value = a2;
                //base.

                this.v = a2;
            }
        }

        public static void Main()
        {
            //Test t1 = new Test();
            //t1.setValue(0);

            //Test t2 = new Test();
            //t1.setValue(1);

            //Test t3 = new Test();
            //t1.setValue(2);
            
            //Test t4 = new Test();
            //t1.setValue(3);
            Test[] t = new Test[10]; // 여기에 Test 참조할 내용이 10개 들어갈겁니다

            for (int i = 0; i < 10; ++i)
            {
                t[i] = new Test(); // 각자 테스트를 만들어줍니다
            }

            for (int i = 0; i < 10; ++i)
            {
                Test temp = t[i];
                temp.setValue(i); // 각 Test 객체마다 setValue 함수를 호출합니다.
                
                // 객체 하나 = 인스턴스
                // 이거 하나하나 인스턴스라는 개념
            }


            Console.WriteLine(Test.Value);

            // 배열에 각자 int v를 따로따로 가지고 있지만
            // static인 Value는 모든 클래스가 하나만 가지고 있습니다

            foreach (var i in t)
            {
                Console.WriteLine(i.v);
            }

        }
    }
}
