using System;
using System.Collections.Generic;
using System.Text;

namespace bancoApp
{
    class Cliente
    {
        public string nomeUser { get; set; }

        public int idadeUser { get; set; }

        public ContaBancaria conta { get; set; }

        public Cliente(string nomeUser, int idadeUser)
        {
            this.nomeUser = nomeUser;
            this.idadeUser = idadeUser;
            this.conta = new ContaBancaria();
        }
       
    }
}
