using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Calculator
    {


        public void printWlcome()
        {
            Console.WriteLine("Welcome to Calculator world");
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int multiply (int a, int b=1)
        {
            return a * b;
        }
    }
}
