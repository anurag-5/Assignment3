using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Ans2
    {
        static void Main(string[] args)
        {
            Class2 class2 = new Class2();
            class2.display();
            Class1 class1 = new Class1();
            class1.display();
        }
    }

        public class Class1
        {
            public void display()
            {
                Console.WriteLine("from class 1");
            }
        }
        public class Class2 : Class1
        {
            public void display()
            {
                Console.WriteLine("from class 2");
            }
        }
    
}
