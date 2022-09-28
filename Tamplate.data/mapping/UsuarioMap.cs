using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tamplete.domain.entites;

namespace Tamplate.data.mapping
{
  public class UsuarioMap:IEntityTypeConfiguration<Usuario>
    {
        

        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();
        }
    }
}
