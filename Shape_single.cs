using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch34_day7
{
    class Shape_single
    {
        protected float len, bred, rad;

        public void getlen()
        {
            Console.WriteLine("\nEnter len  = ");
            len = float.Parse(Console.ReadLine());
        }

        public void getbred()
        {
            Console.WriteLine("\nEnter bred  = ");
            bred = float.Parse(Console.ReadLine());
        }

        public void getrad()
        {
            Console.WriteLine("\nEnter rad  = ");
            rad = float.Parse(Console.ReadLine());
        }
    }
}
