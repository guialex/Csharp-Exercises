using System;

namespace ContagemApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            verificaOpcao();
            
        }

        private static void verificaOpcao()
        {
            int opcao = 0;
            do
            { 
                opcao = contagem(pegaNum());

            } while (opcao != 0);
            
        }

        private static int pegaNum()
        {
            Console.WriteLine("Diz um numero ai meu estimado: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        private static int contagem(int num)
        {
            int opcao;
            for(int i = 1; i <= num; i++)
            {
                Console.WriteLine(i);
            }
            do
            {
                Console.WriteLine("Tu quer executar a contagem de novo? \n" + "1 = Sim 0 = Não \n");
                opcao = Convert.ToInt32(Console.ReadLine());
                if (opcao != 1 && opcao != 0)
                {
                    Console.WriteLine("digita 1 ou 0 ai meu \n");
                }
            } while (opcao != 1 && opcao != 0);
            return Convert.ToInt32(opcao);
        }
    }
}
