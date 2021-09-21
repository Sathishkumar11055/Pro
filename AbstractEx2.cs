using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch34_day7
{
    abstract class One
    {
        protected int x;
        public void getdata()
        {
            Console.WriteLine("Enter X = ");
            x = Convert.ToInt32(Console.ReadLine());
        }
        abstract public void printme();
    }

    abstract class Two : One
    {
        protected int y;
        public void getYdata()
        {
            Console.WriteLine("Enter y = ");
            y = Convert.ToInt32(Console.ReadLine());
        }
    }

    class Three : Two
    {
        public override void printme()
        {
            Console.WriteLine("Value of x = "+x+"\nValue of y = "+y);
        }
    }

    class AbstractEx2
    {
        static void Main(string[] args)
        {
            Three ob = new Three();
            ob.getdata();
            ob.getYdata();
            ob.printme();

        }
    }
}
