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
                Console.WriteLine("Digita a quantidade que tu quer sacar: \n");
                saldo -= Convert.ToDouble(Console.ReadLine());
            }
            return saldo;

        }

        public double depositaDinheiro(double saldo)
        {
            Console.WriteLine("Digita a quantidade que tu quer depositar: ");
            return saldo += Convert.ToInt32(Console.ReadLine());
        }
    }
}
