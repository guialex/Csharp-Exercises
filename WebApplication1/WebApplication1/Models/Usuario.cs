using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Idade { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }
    }
}