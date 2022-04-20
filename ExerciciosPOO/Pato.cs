using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPOO
{
    class Pato : Animal
    {
        public override void Andar()
        {
            Console.WriteLine("clap clap clap...pato andando parece que ta batendo palma");
        }
    

        public override void EmitirSom()
        {
            Console.WriteLine("QUACK! QUACK! MANO EU SOU UM PATO MAS QUEM NÃO É?");
        }
    }
}
