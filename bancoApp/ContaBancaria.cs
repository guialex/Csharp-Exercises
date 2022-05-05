using System;
using System.Collections.Generic;
using System.Text;

namespace bancoApp
{
    class ContaBancaria
    {
        public int Conta { get; set; }
        public double saldo { get; set; }

        public double sacaDinheiro(double saldo)
        {
            if (saldo <= 0)
            {
                Console.WriteLine("Tu não tem saldo pra sacar, deposita algo ai.. \n");
            }
            else
            {
                try
                {
                    Console.WriteLine("Digita a quantidade que tu quer sacar: \n");
                    saldo -= Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Tu digitou uma quantidade inválida ai meu \n");
                    return sacaDinheiro(saldo);
                }
            }
            return saldo;
        }

        public double depositaDinheiro(double saldo)
        {
            try
            {
                Console.WriteLine("Digita a quantidade que tu quer depositar: ");
                return saldo += Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Tu digitou uma quantidade inválida ai meu \n");
                return depositaDinheiro(saldo);
            }

        }
    }
}
