using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPOO
{
    class Cachorro : Animal
    {
        public override void Andar()
        {
            Console.WriteLine("tic tic tic tic... cachorro andando");
        }

        public override void EmitirSom()
        {
            Console.WriteLine("AUUU! AUUU! CHEGOU O CACHORRO ME DA COMIDA AI BICHO");
        }
    }
}
