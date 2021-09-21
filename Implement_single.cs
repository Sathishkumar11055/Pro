using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch34_day7
{
    class Implement_single:Shape_single
    {
        float area, peri;

        void calculate()
        {
            area = len * bred;
            peri = 2 * (len + bred);
        }

        void display()
        {
            Console.WriteLine("LENGTH        = " + len);
            Console.WriteLine("BREADTH       = " + bred);
            Console.WriteLine("AREA          = " + area);
            Console.WriteLine("PERIMETER     = " + peri);
        }

        static void Main(string[] args)
        {
            Implement_single ob = new Implement_single();
            ob.getlen();
            ob.getbred();
            ob.calculate();
            ob.display();
        }
    }
}
