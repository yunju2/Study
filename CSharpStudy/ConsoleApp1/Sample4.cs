using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sample4
    {
        // c++ : 추상클래스 (뒤늦게)
        // java : interface, 추상클래스
        // C# : interface, 추상클래스
        // 목적 : 사실상 class랑 동일하지만 사용을 좀더 쉽게 해줌

        // 객체지향에서 나오는 개념
        // 접근제한자를 잘 활용하자. 왜 ?? 향후에 유지보수에 좋음
        class Parent
        {
            // virtual : 이 함수는 자식클래스에서 재정의 될 수 있다라고 알려줌
            // private : 그 클래스에서만 쓸 수 있고
            // protected : 자식 클래스도 쓸 수 있고
            // public : 외부에서도 쓸 수 있고
            // internal : 도메인 기준.. 다른 프로그램에서 가져다 쓸 수 있나?? 
            // (예를들면 외부 dll에서 쓸때 내용을 다른 프로그램에서 쓸수있게 할까?)
            public void pfunc()
            {
                Console.WriteLine("Parent's pfunc");
            }

            public virtual void func()
            {
                Console.WriteLine("Parent func");
            }
        }

        class Child : Parent
        {
            // new : virtual, override 개념은 쓰기 싫고 함수를 재정의하고 싶을 때!
            public new void pfunc()
            {
                Console.WriteLine("Child's pfunc");
            }

            // overloading : 함수 이름이 같은거
            public void func1()
            {
                pfunc();
            }
            public void func1(int a)
            {
            }

            // override : Child.func() 이것만 아니라 다른 클래스에서 호출해도 이게 호출될수 있다 느낌?
            // 부모의 virtual 함수를 재정의 함
            public override void func()
            {
                Console.WriteLine("Child func");
            }
        }

        public static void Main()
        {
            Parent c = new Child();
            c.pfunc();

            Parent c2 = new Parent();
            c2.pfunc();
        }

        // 인터페이스는 행동만 정의해둠
        //interface Worker
        //{
        //    // 자식에 있는 함수가 재정의해서 쓸 예정
        //    void work();
        //}

        abstract class Worker
        {
            public void Do()
            {
                Console.WriteLine("DO");
            }

            // 추상 클래스 : 몇개 내용의 함수만 내가 구현 안함 (나머지는 되어있을 수 있음)
            // 클래스지만, 일부 행동은 내가 정의 안함
            public abstract void work();
        }


        class Car : Worker
        {
            public override void work()
            {
                base.Do();
            }
        }

        class Person : Worker
        {
            public override void work()
            {
                base.Do();
            }
        }

        static void func(Worker o)
        {
            o.work(); 
        }
    }
}
