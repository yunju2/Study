using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sample5
    {
        class A
        {
            public void Func() { }
        }
        public static void Main()
        {
            A a = new A();
            // 원래 null은 class같이 참조 타입만 쓸 수 있음
            a = null;

            if (a != null)
            {
                a.Func();
            }

            // 위에 내용을 한줄로 표현가능
            a?.Func();


            //int a = default(int); // 내부적으로 0을 넣음. 참조는 널
            // 그렇다면은 값 타입에 null을 넣게하는 방법은 없을까?
            // nullable

            int? v2 = null;
            // Nullable<int>이러한 자료형이고
            // 내부적이로 int와 bool 가지고있어서 null 여부를 체크해주는게 끝!

            // null - 무효하다? 없다
            // int* p = NULL (사실상 0)
            // null을 넣었다는 의미는 p 값은 아무것도 없다! 라고 관례적으로 정의 해놓음
            // 그렇기 때문에 null이라는 의미는 없다, 혹은 무효하다 라는 느낌
            int? v = Func();
            if (v == null)
            {
                Console.WriteLine("오류가 있습니다");
                // 근데 -1이 필요할 수도 있고,
                // 혹은 각 사람마다 예외 값을 다르게 던질 수 있잖아
                // 공통적으로 오류 혹은 없다고 똑같이 던지면 어떨까?
            }

            int v3 = 0;
            if (v != null)
            {
                v3 = 1;
            }

            // null이 없으면 v 값을 주고, 아니면 1을 준다 (null 있으면)
            v3 = v ?? 1;
        }

        static int? Func()
        {
            // 함수가 잘못되었을때
            if (true)
            {
                return null;
            }
        }
    }
}
