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
            Console.WriteLine("Enter a string");
            string str = Convert.ToString(Console.ReadLine());
            ans3.fun(str);
        }
        public void fun(string str)
        {
            int Count=0;
            
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
