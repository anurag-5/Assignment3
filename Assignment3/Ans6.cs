using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Ans6
    {
        static void Main(string[] args)
        {
            student s=new student();
            Console.WriteLine("Enter no of sudentes");
            int n=Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                s.read();
                s.calculate();
                s.display();
            }
            
        }
    }
    public class student
    {
        int i=1;
        int id;
        string name;
        int[] mark = new int[3];
        int total;
        public void read()
        {
            Console.WriteLine("Enter student {0} details",i);
            Console.WriteLine("Enter Id :");
            id =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name :");
            name =Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Marks :");
            Console.WriteLine("Enter Mark1 :");
            mark[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Mark2 :");
            mark[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Mark2 :");
            mark[2] = Convert.ToInt32(Console.ReadLine());
        }
        public void calculate()
        {   
            total = mark[0] + mark[1] + mark[2];
        }
        public void display()
        {
            Console.WriteLine("Student {0} details",i);
            Console.WriteLine("Id :"+id);
            Console.WriteLine("Name :"+name);
            Console.WriteLine("Mark1 :"+mark[0]);
            Console.WriteLine("Mark2 :"+mark[1]);
            Console.WriteLine("Mark3 :"+mark[2]);
            Console.WriteLine("Total mark :"+total);
            i++;
        }
    }
}
