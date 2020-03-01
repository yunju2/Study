using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Parent
    {
        public int v;
        public void func()
        {
            Console.WriteLine("Parent");
        }
    }

    public class Child : Parent
    {
        public int v;
        public void func2()
        {
            Console.WriteLine("Child");
        }
    }

    class Sample9
    {
        static void Main()
        {
            Parent p = new Child();
            func(p);
        }

        static void func(Parent p)
        {
            // child일까? parent일까?
            // 강제 캐스팅. 단점 : 타입을 명확히 알고 있어야한다
            //Child c = (Child)p;

            if (p is Child)
            {
                Console.WriteLine("Child 입니다");
            }

            Child c = p as Child;
            if (c == null)
            {
                Console.WriteLine("Child가 아닙니다");
            }
            else
            {
                c.func2();
            }
        }
    }
}
