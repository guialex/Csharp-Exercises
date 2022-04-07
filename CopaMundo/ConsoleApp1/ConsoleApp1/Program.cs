using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            verificaOpcao(pegarOpcao());
        }

        private static int pegarOpcao()
        {

            Console.WriteLine("Fala ai meu consagrado \n" + "Quem ganhou a Copa de 2014?");
            Console.WriteLine("1. ARGÉLIA \n" + "2. PERU \n" + "3. ALEMANHA \n" + "4. BRASIL \n");

            return Convert.ToInt32(Console.ReadLine());
        }

        private static void verificaOpcao(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Errou! HAHAHAHA");
                    break;
                case 2:
                    Console.WriteLine("Errou! HAHAHAHA");
                    break;
                case 3:
                    Console.WriteLine("Acertou mizeravi! Parabéns!");
                    break;
                case 4:
                    Console.WriteLine("Errou! HAHAHAHA");
                    break;
                default:
                    Console.WriteLine("Esqueceu do 7x1 é?");
                    break;
            }
        }
    }
}
