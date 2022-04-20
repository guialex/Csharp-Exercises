using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPOO
{
    class Gato : Animal
    {
        public override void Andar()
        {
            Console.WriteLine("... gato andando mas nem faz barulho essa porra");
        }
    

        public override void EmitirSom()
        {
            Console.WriteLine("MIAU! MIAU! SOU UM GATO CÊ É DOIDO");
        }
    }
}
