using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            classificaPeso(IMC(pegarAltura(), pegarPeso()));
        }

        private static void classificaPeso(double IMC)
        {
            switch (IMC)
            {
                case double aux when aux < 18.5:
                    Console.WriteLine("Você está abaixo do peso");
                    break;
                case double aux when aux >= 18.5 && aux <= 24.9:
                    Console.WriteLine("Você está com peso normal");
                    break;
                case double aux when aux >= 25 && aux <= 29.9:
                    Console.WriteLine("Você está com sobrepeso");
                    break;
                case double aux when aux >= 30 && aux <= 34.9:
                    Console.WriteLine("Você está com obesidade grau I");
                    break;
                case double aux when aux >= 35 && aux <= 39.9:
                    Console.WriteLine("Você está com obesidade grau II");
                    break;
                case double aux when aux >= 40:
                    Console.WriteLine("Você está com obesidade grau III");
                    break;
                default:
                    Console.WriteLine("Classifcação não encontrada");
                    break;
            }
            //if (IMC < 18.5)
            //{
            //    Console.WriteLine("Você está abaixo do peso");

            //}
            //else if (IMC >= 18.5 && IMC <= 24.9)
            //{
            //    Console.WriteLine("Você está com peso normal");

            //}
            //else if (IMC >= 25 && IMC <= 29.9)
            //{
            //    Console.WriteLine("Você está com sobrepeso");

            //}
            //else if (IMC >= 30 && IMC <= 34.9)
            //{
            //    Console.WriteLine("Você está com obesidade grau I");

            //}
            //else if (IMC >= 35 && IMC <= 39.9)
            //{
            //    Console.WriteLine("Você está com obesidade grau II");
            //}
            //else if (IMC >= 40)
            //{
            //    Console.WriteLine("Você está com obesidade grau III");
            //}
        }

        public static double pegarPeso()
        {
            Console.WriteLine("Opa, me fala ai teu peso");
            return Convert.ToDouble(Console.ReadLine());
        }

        public static double pegarAltura()
        {
            Console.WriteLine("Bicho, qual tua altura?");
            return Convert.ToDouble(Console.ReadLine());
        }

        public static double IMC(double altura, double peso)
        {
            double IMC = peso / (altura * altura);
            Console.WriteLine("Cara, teu IMC é: " + IMC.ToString());
            return IMC;
        }
    }
}
