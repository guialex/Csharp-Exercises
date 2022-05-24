using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        static bool token = false;
        private readonly UsuarioDbContext _context;
        public UsuarioController(UsuarioDbContext context)
        {
            _context = context;
        }

        [HttpGet("[action]")]
        public bool Login(string email, string senha)
        {
            var usuario = _context
                .Usuarios
                .FirstOrDefault(x => x.Email == email && x.Senha == senha);
            if (usuario == null)
            {
                return false;
            }
            else
            {
                token = true;
                return token;
            }
        }

        [HttpPost("[action]")]
        public void CriarUser(string nome, int idade, string email, string senha)
        {
            var usuario = new Usuario();
            usuario.Email = email;
            usuario.Senha = senha;
            usuario.Nome = nome;
            usuario.Idade = idade;
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            
        }

        [HttpPost("[action]")]
        public void ExcluirUser(int id)
        {
            if (token == true)
            {
                var usuario = _context
               .Usuarios
               .FirstOrDefault(x => x.Id == id);
                _context.Usuarios.Remove(usuario);
                _context.SaveChanges();
            } 
           
        }
    }
}
