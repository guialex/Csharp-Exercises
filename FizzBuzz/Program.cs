using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            fizzBuzz();
        }

        private static void fizzBuzz()
        {
             for(int i = 1; i <= 100; i++){
                verificaParam(i);
            }
        }

        private static void verificaParam(int num)
        {
             if(num % 3 == 0 && num % 5 ==0){
                 System.Console.WriteLine("FizzBuzz");
             }else if(num % 3 == 0){
                 System.Console.WriteLine("Fizz");
             }else if(num % 5 == 0){
                 System.Console.WriteLine("Buzz");
             }else{
                 System.Console.WriteLine(num.ToString());
             }
        }
    }
}
