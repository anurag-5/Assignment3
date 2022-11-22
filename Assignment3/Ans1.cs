using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment3
{
    internal class Ans1
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = new Student();
            Console.WriteLine("Call by first instance");
            student1.displaydetails();
            Console.WriteLine("Call by second instance");
            student2.displaydetails();
        }
    }
    public class Student
    {
        
        int rollno;
        string name;
        public Student()
        {
            Console.WriteLine("Enter Name");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter roll number");
            rollno = Convert.ToInt32(Console.ReadLine());

        }
        public void displaydetails()
        {
            Console.WriteLine("Name :"+name);
            Console.WriteLine("rollno :"+rollno);
        }
    }
}
