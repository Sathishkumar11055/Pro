using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch34_day7
{
    class Student
    {
        protected string sname;
        protected int roll;

        public void getstudentdetails()
        {
            Console.WriteLine("Enter roll and name");
            sname = Console.ReadLine();
            roll = Convert.ToInt32(Console.ReadLine());
        }

        public void display()
        {
            Console.WriteLine("Roll   = "+roll);
            Console.WriteLine("Name   = "+sname);
        }
    }

    class CoursDetails : Student
    {
        protected string coursename;
        protected int[] marks = new int[3];

        public void getmarks()
        {
            Console.WriteLine("Enter course name");
            coursename = Console.ReadLine();
            Console.WriteLine("Enter Marks");
            for(int i = 0; i < marks.Length; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void display()
        {
            base.display();
            Console.WriteLine("Course Nmae    = "+coursename);
            for(int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine("Marks [" +i+"]    = "+ marks[i]);
            }
        }
        
    }

    class Report:CoursDetails
    {
        int total, per;

        public Report()
        {
            total = 0;
            per = 0;
        }

        public void cal()
        {
            for (int i = 0; i < marks.Length;total += marks[i],i++) ;
            per = total / marks.Length; 
        }

        public void display()
        {
            base.display();
            Console.WriteLine("Total      = "+total);
            Console.WriteLine("Percentage = "+per);
        }
    }

    class Multi_level
    {
        static void Main(string[] args)
        {
            Report ob = new Report();
            ob.getstudentdetails();
            ob.getmarks();
            ob.cal();
            ob.display();
        }
    }
}
