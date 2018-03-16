using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverringVsMethodShadowing
{ 

    class A
    {

        public virtual void CallMethod() { Method(); }
        protected virtual void Method() { Console.WriteLine("A"); }
    }

    class B : A
    {

        protected override void Method() { Console.WriteLine("B"); }
    }

    class C : B
    {

        protected new virtual void Method() { Console.WriteLine("C"); }
    }

    class D : C
    {

        protected override void Method() { Console.WriteLine("D"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            C obj = new D();
            obj.CallMethod();
            Console.ReadLine();
        }
    }
}
