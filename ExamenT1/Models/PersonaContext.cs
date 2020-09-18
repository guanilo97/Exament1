using ExamenT1.Models.Maps;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenT1.Models
{
    public class PersonaContext:DbContext
    {
        public DbSet<Personas> personas { get; set; }
        public PersonaContext(DbContextOptions<PersonaContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new PersonasMap());
        }

    }
}
