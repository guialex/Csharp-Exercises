using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class UsuarioDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public UsuarioDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
