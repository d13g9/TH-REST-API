using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTAPITH.Model
{
    public class THContext: DbContext
    {
        public THContext(DbContextOptions<THContext> options)
           : base(options)
        {
        }

        public DbSet<BaseProfile> BaseProfile { get; set; }
        public DbSet<Vagas> vagas  { get; set; }
        public DbSet<Applyances> applyances{ get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeProfile>()
                .HasBaseType<BaseProfile>()
                .ToTable("Employee");

            modelBuilder.Entity<EmployerProfile>()
                .HasBaseType<BaseProfile>()
                .ToTable("Employer");

         }


    }
}
