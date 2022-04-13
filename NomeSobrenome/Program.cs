using System;

namespace NomeSobrenome
{
    class Program
    {
        static void Main(string[] args)
        {
            var nome = new string[,] {
            {"",""},
            {"",""},
            {"",""},
            {"",""},
            {"",""},
            };
            //inserirNomes();

            for (int linha = 0; linha < nome.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < nome.GetLength(1); coluna++)
                {
                    Console.WriteLine("Digite um nome ou um sobrenome");
                    nome[linha, coluna] = Console.ReadLine();
                    //Console.WriteLine(nome[linha, coluna]);
                }
            }

            Console.WriteLine("-----------------------");

            for (int linha = 0; linha < nome.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < nome.GetLength(1); coluna++)
                {
                    Console.Write(nome[linha, coluna] + " ");
                }
                Console.WriteLine(" ");
            }

        }

       // private static void inserirNomes()
      //  {
//throw new NotImplementedException();
       // }
    }
}
