using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            copaMundo();
        }

        private static void copaMundo()
        {
            int opcao = 0;
            do
            {
                Console.WriteLine("Fala ai meu consagrado \n" + "Quem ganhou a Copa de 2014?");
                Console.WriteLine("1. ARGÉLIA \n" + "2. PERU \n" + "3. ALEMANHA \n" + "4. BRASIL \n");
                opcao = Convert.ToInt32(Console.ReadLine());
                if(opcao != 3)
                {
                    Console.WriteLine("errou bicho, tenta de novo \n");
                }
            } while (opcao != 3);
            Console.WriteLine("Acertou carai! vlw flw"); ;
        }
    }
}
