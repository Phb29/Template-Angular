using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamplate.data.Extention;
using Tamplate.data.mapping;
using tamplete.domain.entites;

namespace Tamplate.data.Context
{
    public class TamplateContext : DbContext
    {
        public TamplateContext(DbContextOptions<TamplateContext> option) : base(option)
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.SeedData();
            base.OnModelCreating(modelBuilder);
        }
    }
}
