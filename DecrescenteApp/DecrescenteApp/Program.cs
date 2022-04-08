using System;

namespace DecrescenteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            decresceNum(pegaNum());
        }

        private static int pegaNum()
        {
            Console.WriteLine("Opa fala um numero ai");
            return Convert.ToInt32(Console.ReadLine());
        }

        private static void decresceNum(int num)
        {
            for(;num >= 0; num--)
            {
                Console.WriteLine(num.ToString());
            }
        }
    }
}
