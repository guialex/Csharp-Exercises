using System;
using System.Collections.Generic;

namespace ArrayToList
{
    class Program
    {
        static void Main(string[] args)
        {
            var array1 = new int[] { 1,2,3,4,5,6,7,8,9,10};
            //Console.WriteLine(array1.Length);
            var lista1 = new List<int> { };

            for (int i = 0; i < array1.Length; i++)
            {
                lista1.Add(array1[i] * 10);

                Console.WriteLine(array1[i].ToString() + "," + lista1[i].ToString());
                Console.WriteLine(" ");
            }
        }
    }
}
