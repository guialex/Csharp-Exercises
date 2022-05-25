using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoDbContext _context;
        public ProdutoController(ProdutoDbContext context)
        {
            _context = context;
        }

        [HttpPost("[action]")]
        public void CriarProduto(string nome, int quantidade)
        {
            var produto = new Produto();
            produto.Nome = nome;
            produto.Quantidade = quantidade;
            _context.Produtos.Add(produto);
            _context.SaveChanges();

        }
    }
}
