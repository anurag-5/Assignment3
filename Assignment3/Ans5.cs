﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Ans5
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.input();
            b.purchase();
            b.display();
            Console.ReadLine();
        }
    }
    class Book
    {
        public int BOOKNO;
        public string BOOKTITLE;
        public float PRICE;

        public void input()
        {
            Console.Write("Enter Book No: ");
            BOOKNO = int.Parse(Console.ReadLine());
            Console.Write("Enter Book Title: ");
            BOOKTITLE = Console.ReadLine();
            Console.Write("Enter Price: ");
            PRICE = int.Parse(Console.ReadLine());
        }



        public void purchase()
        {
            Console.Write("Enter the number of copies to be purchased: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Total cost to be paid: {0}", TOTALCOST(n));
        }
        public float TOTALCOST(int n)
        {
            return PRICE * n;
        }

        public void display()
        {
            Console.WriteLine("Book No: {0}", BOOKNO);
            Console.WriteLine("Book Title: {0}", BOOKTITLE);
            Console.WriteLine("Price: {0}", PRICE);
        }
    }
}