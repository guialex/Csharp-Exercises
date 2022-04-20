using System;

namespace ExerciciosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var animais = new Animal[] { new Pato(), new Gato(), new Cachorro() };



            foreach (var item in animais)
            {
                item.EmitirSom();
                item.Andar();
                Console.WriteLine("\n");
               
            }
           

        }
    }
}
