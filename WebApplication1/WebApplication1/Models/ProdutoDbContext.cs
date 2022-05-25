using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ProdutoDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        public ProdutoDbContext(DbContextOptions <ProdutoDbContext> options) : base(options)
        {

        }
    }
}
