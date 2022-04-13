using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 1;
            int result = 0;

            while(result <= 144)
            {
                result = num1 + num2;
                Console.WriteLine(num1.ToString() + "+" + num2.ToString() + " = " + result.ToString());
                num2 = num1;
                num1 = result;

            }
        }
    }
}
