using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenT1.Models.Maps
{
    public class PersonasMap : IEntityTypeConfiguration<Personas>
    {
        public void Configure(EntityTypeBuilder<Personas> builder)
        {
            // throw new NotImplementedException();
            builder.ToTable("Persona");
            builder.HasKey(o => o.Id_persona);
        }
    }
}
