using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch34_day7
{
    class A
    {
        public A()
        {
            Console.WriteLine("Hello");
        }
    }

    class B:A
    {
        public B()
        {
            Console.WriteLine("Hi");
        }
    }

    class C:B
    {
        public C()
        {
            Console.WriteLine("How are You");
        }
    }

    class Inheri_Constructor
    {
        static void Main(string[] args)
        {
            C ob = new C();
        }
    }
}
