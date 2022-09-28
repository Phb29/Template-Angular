using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tamplete.domain.entites;

namespace Tamplate.data.Extention
{
    public static class Seeding
    {
        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<Usuario>().HasData(
                new Usuario { Id = Guid.NewGuid(), Name = "User Default" });
            return builder;
        }
    }
}