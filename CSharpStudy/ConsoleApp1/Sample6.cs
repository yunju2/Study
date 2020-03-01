using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sample6
    {
        class A
        {
            //private int v1;
            //public int v1;
            public int Value { get; set; } // property 라고 합니다
            // 외부에서 배열처럼 쓸 수 있게 해줌 : indexer
            public int this[int index] 
            { 
                get
                {
                    return index+1;
                }
            }

            public A(int v = 1)
            {
                Value = v;
            }

            // 객체지향 측면에서 Set, Get Method로 제공해야한다
            // 1. 제한을 둬서 유지보수 용이하다
            // set/get 둘다 모두 쓰게 될경우에 그냥 변수를 public으로 놔도 되지 않을까??
            // 2. 수정이 필요할 때 부작용이 적고 안전하다
            // 객체지향 공부할 때 set, get method 두는 습관
            
            //public int setValue(int v)
            //{
            //    if (v < 0)
            //    {
            //        Console.WriteLine("Error!");
            //        //throw new Exception("Error!");
            //        return;
            //    }
            //    value = v;
            //}

            //public int getValue()
            //{
            //    return value;
            //}
        }

        public static void Main()
        {
            A a = new A();
            a.Value = 1;
            
            int v = a[1];
            Console.WriteLine(a.Value);
        }
    }
}
