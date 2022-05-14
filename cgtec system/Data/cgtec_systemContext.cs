using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using cgtec_system.Models;

namespace cgtec_system.Data
{
    public class cgtec_systemContext : DbContext
    {
        public cgtec_systemContext (DbContextOptions<cgtec_systemContext> options)
            : base(options)
        {
        }

        public DbSet<cgtec_system.Models.Cliente>? Cliente { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Cliente>().HasKey(m => m.Id);
            base.OnModelCreating(builder);
        }
    }
}
