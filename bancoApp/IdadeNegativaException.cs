using System;
using System.Collections.Generic;
using System.Text;

namespace bancoApp
{
    class IdadeNegativaException : Exception
    {
        public IdadeNegativaException() : base("A idade não pode ser negativa bicho \n")
        {
        }
    }
}
