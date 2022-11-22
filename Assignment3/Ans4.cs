using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Ans4
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();

            myStack.Push(25);
            myStack.Push(20);
            myStack.Push(35);
            myStack.Push(10);
            myStack.DisplayStack();
            myStack.Peek();
            Console.WriteLine("Item popped from Stack : {0}", myStack.Pop());
            myStack.DisplayStack();
            myStack.Peek();
            Console.WriteLine("Item popped from Stack : {0}", myStack.Pop());
            myStack.DisplayStack();
        }
        public class Stack
        {
            static readonly int MAX = 1000;
            int top=-1;
            int[] stack = new int[MAX];



            public void Push(int data)
            {
                if (top >= MAX)
                {
                    Console.WriteLine("Stack Overflow");
                    
                }
                else
                {
                    stack[++top] = data;
                    
                }
            }

            internal int Pop()
            {
                if (top < 0)
                {
                    Console.WriteLine("Stack Underflow");
                    return 0;
                }
                else
                {
                    int value = stack[top--];
                    return value;
                }
            }

            public void Peek()
            {
                if (top < 0)
                {
                    Console.WriteLine("Stack Underflow");
                    
                }
                else
                    Console.WriteLine("The topmost element of Stack is : {0}", stack[top]);
            }

            public void DisplayStack()
            {
                if (top < 0)
                {
                    Console.WriteLine("Stack Underflow");
                    return;
                }
                else
                {
                    Console.WriteLine("Items in the Stack are :");
                    for (int i = top; i >= 0; i--)
                    {
                        Console.WriteLine(stack[i]);
                    }
                }
            }
        }
    }
}
