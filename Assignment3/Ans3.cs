using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Ans3
    {
        static void Main(string[] args)
        {
            Ans3 ans3 = new Ans3();
            ans3.fun();
        }
        public void fun()
        {
            int Count=0;
            Console.WriteLine("Enter a string");
            string str=Convert.ToString(Console.ReadLine());
            for(int i=0;i<str.Length;i++)
            {

                if (str[i]==' ')
                {
                    Count++;
                }
            }
            Console.WriteLine("Number of spaces in the string"+Count);
            Console.ReadKey();  
            

        }
    }
}
