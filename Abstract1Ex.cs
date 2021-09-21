using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch34_day7
{
    abstract class MyAbstract
    {
        protected string roll, name;
        public void getdata()
        {
            Console.WriteLine("Enter roll & name");
            roll = Console.ReadLine();
            name = Console.ReadLine();
        }

        abstract public void display(); 
    }

    class MyChild : MyAbstract
    {
        string per;
        
        public void getper()
        {
            Console.WriteLine("Enter Per");
            per = Console.ReadLine();
        }

        public override void display()
        {
            Console.WriteLine("Roll       = "+roll);
            Console.WriteLine("Name       = " + name);
            Console.WriteLine("Per        = " + per);
        }
    }
    class Abstract1Ex
    {
        static void Main(string[] args)
        {
            MyChild ob = new MyChild();
            ob.getdata();
            ob.getper();
            ob.display();

            MyAbstract ob1 = new MyChild();
            ob1.getdata();
            ob1.display();
        }
        
    }
}
