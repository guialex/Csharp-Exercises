﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Quantidade { get; set; }
    }
}
