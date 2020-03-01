using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sample2
    {
            // java X -> C#은 있는거
            // 값 타입, 참조 타입 -> C++ 개념
            // Java는 기본 자료형은 값 타입, 그 외에는 항상 참조 타입
            // C#은 언어 차원에서 자유롭게 고를 수 있다.

            
            // C++ struct랑 class랑 사실상 거의 동일하다
            // C#은 struct랑 class랑 다르다!
            // struct는 값 타입 - (int) 
            // class는 참조 타입
        struct A // 값 타입! 
        {
            public int value;
        }

        class B2
        {
        }

        class B // 참조 탑인
        {
            public int value = 0;
            B2 b = new B2();
        }

        static void Main(string[] args)
        {
            // int, double, char 등 같은 기본 자료형 -> struct -> value type
            // struct도 -> value type
            // class는 -> reference type (c -> 포인터 개념)
            // string 도 reference type
            A a = new A();
            funco(a); // boxing 
            funcA(ref a);
            Console.WriteLine(a.value);

            //int a = 1;
            //func2(ref a);
            //Console.WriteLine(a);

            //B b; // = new B(); // 원래라면 생성 해야합니다!
            //funcout(out b); // out을 썼으니까, 함수 내에서 내용을 채워 줄 겁니다! 따라서 생성이 필요없습니다
            //Console.WriteLine(b.value);

            // c에서는 malloc, c++에서는 new 하면 heap 공간에 생깁니다.
            // 지역변수는 stack 공간에 생깁니다
            // value를 지역변수에 할당하면 stack 공간에 생깁니다
        }

        static void func(ref B v) // 참조도 이런식으로 바꿀 수 있습니다!
        {
            v = new B();
            v.value = 3;
        }
        static void funcout(out B v) // 참조도 이런식으로 바꿀 수 있습니다! 
                                                        // 결국에는 참조값이랑 똑같은데, 언어측면에서 안에서 만들어주는걸 알려줍니다!
        {
            v = new B();
            v.value = 3;
        }

        // v에다 복사! (복사본의 값을 변경하기 때문에 바뀌지 않는다)
        static void func2(ref int v) // ref : 레퍼런스! 참조값을 넘겨라! (value 타입 때 많이 씀)
        {
            v = 2;
        }

        static void funcA(ref A v) 
        {
            int a;

            v.value = 2;

            A a2 = new A();
        }

        static void funco(object o )
        {
            Console.WriteLine(o);
        }
    }
}
