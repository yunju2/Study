using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Test1
    {
        public class Child 
        {
            // 전역변수 느낌
            // static은 결국 인스턴스(객체)랑 무관한 독립적인 존재?
            public static int t = 2;
            public int v;

            static Child()
            {
                t = 5;
                Console.WriteLine("Static 생성자");
            }
            public Child()
            {
                Console.WriteLine("생성자");
            }

            public void set()
            {
                t = 2;
            }

            public void print()
            {
                Console.WriteLine($"T: {t} / V: {v}");
            }
        }

        static void Main()
        {
            Console.WriteLine(Child.t);

            // Child를 담을 공간을 만듭니다 (배열 생성)
            Child[] ch = new Child[10];

            for(int i = 0; i < 10; ++i)
            {
                // 실제 배열 하나하나에 Child 객체를 만듭니다
                ch[i] = new Child();
                // 값을 설정합니다
                ch[i].v = i;
            }
            ch[0].set();
            //List<Child> chs = new List<Child>();
            foreach(var c in ch)
            {
                c.print();
            }
        }

    }
}
