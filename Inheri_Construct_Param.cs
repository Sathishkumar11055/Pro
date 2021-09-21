using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch34_day7
{
    class X
    {
        public X(int x)
        {
            Console.WriteLine("X = "+x);
        }
    }

    class Y:X
    {
        public Y(int x, int y):base(x)
        {
            Console.WriteLine("Y = " + y);
        }
    }

    class Z:Y
    {
        public Z(int x, int y, int z):base(x, y)
        {
            Console.WriteLine("Z = " + z);
        }
    }

    class Inheri_Construct_Param
    {
        static void Main(string[] args)
        {
            Z ob = new Z(11, 22, 44);
        }
       
    }
}
