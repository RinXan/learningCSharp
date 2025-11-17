using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum Operation
    {
        ADD,
        SUB,
        MULTIPLY
    }
    static class MyMath
    {
        private static int counter = 0;
        public const double PI = 3.14159265;
        public const double E = 2.71828183;
        public static int GetCounter()
        {
            return counter;
        }

        public static double Magic(double x, double y, Operation op)
        {
            double result = 0;
            switch (op)
            {
                case Operation.ADD: result = x + y; break;
                case Operation.SUB: result = x - y; break;
                case Operation.MULTIPLY: result = x * y; break;
            }
            counter++;
            return result;
        }

        public static int Add(int x, int y) 
        {
            counter++;
            return x + y; 
        }
        public static int Subtract(int x, int y) 
        {
            counter++;
            return x - y; 
        }
        public static int Multiply(int x, int y) 
        { 
            counter++;
            return x * y;
        }
        public static double Divide(double x, double y) 
        { 
            counter++;
            return x / y; 
        }
    }
}
