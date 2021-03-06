using System;
using System.Runtime.Serialization;

namespace bancoApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente user = new Cliente(pegarNome(), pegarIdade());
            saudacaoUser(user.nomeUser);
            operacaoBanco(user.nomeUser, user.conta);
          
        }

        private static void operacaoBanco(string nomeUser, ContaBancaria conta)
        {
            int opcao = 0;
            do
            {
                opcao = pegaOpcao(nomeUser, conta.saldo);
                
                if (opcao == 3)
                {
                    conta.saldo = conta.depositaDinheiro(conta.saldo);

                }else if (opcao == 2)
                {
                    conta.saldo = conta.sacaDinheiro(conta.saldo);

                }else if (opcao == 1)
                {
                    Console.WriteLine("Saindo...");
                }
                else
                {
                    Console.WriteLine("Não existe essa opcão, digita de novo ai campeão \n");
                }

            } while (opcao != 1);
        }

        private static string pegarNome()
        {
            Console.WriteLine("Por favor informe o teu nome meu consagrado");
            return Console.ReadLine();
        }

        private static int pegarIdade()
        {
            int idade = 0;
            try
            {
                Console.WriteLine("Por favor informe a tua idade meu estimado");
                idade = Convert.ToInt32(Console.ReadLine());
                if(idade < 0)
                {
                    throw new IdadeNegativaException();
                }
                else
                {
                    return idade;
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("tu informou uma idade inválida, digita de novo ai \n");
                return pegarIdade();
            }
            catch (IdadeNegativaException ex)
            {
                Console.WriteLine(ex.Message);
                return pegarIdade();
            }

        }

        private static int pegaOpcao(string nomeUser, double saldo)
        {
            try
            {
                Console.WriteLine("Teu saldo é de: " + saldo);
                Console.WriteLine("O que tu quer fazer?");
                Console.WriteLine("3 = Depositar | 2 = Sacar | 1 = Sair");
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Não existe essa opcão, digita de novo ai campeão");
                return pegaOpcao(nomeUser, saldo);
            }
            
        }

        private static void saudacaoUser(string nomeUser)
        {
            Console.WriteLine("Fala " + nomeUser + "! " + " Bem vindo ao teu sistema de banco meu maraja! \n");
        }

    }
}
