using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch34_day7
{
    class PersonalInfo
    {
        protected string ssid, name, age;

        public void getdata()
        {
            Console.WriteLine("Enter Ssid, Name and Age");
            ssid = Console.ReadLine();
            name = Console.ReadLine();
            age = Console.ReadLine();
        }
        public void disp()
        {
            Console.WriteLine("SSID        = "+ssid);
            Console.WriteLine("NAME        = "+name);
            Console.WriteLine("AGE         = "+age);
        }
    }

    class EmployeeInfo
    {
        PersonalInfo emp;
        protected string empid, desig;
        
        public EmployeeInfo()
        {
            emp = new PersonalInfo();
        }
        public void getdata()
        {
            emp.getdata();
            Console.WriteLine("Emp Id and Desig");
            empid = Console.ReadLine();
            desig = Console.ReadLine();
        }
        public void disp()
        {
            emp.disp();
            Console.WriteLine("EMPID      = " + empid);
            Console.WriteLine("DESIG      = " + desig);
        } 
    }
    class AggregateImp
    {
        static void Main(string[] args)
        {
            EmployeeInfo ob = new EmployeeInfo();
            ob.getdata();
            ob.disp();
        }
    }
}
