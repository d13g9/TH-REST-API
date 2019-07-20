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

        public DbSet<AddressProfile> tbEndereco { get; set; }
        public DbSet<Jobs> tbVagas { get; set; }
        public DbSet<JobTitles> tbCargos { get; set; }
        public DbSet<LoginProfile> tbLogin { get; set; }
        public DbSet<PeopleProfile> tbPessoas { get; set; }
        public DbSet<BaseProfile> BaseProfile { get; set; }
        public DbSet<EmployeeJobs> tbCargosEmpregado { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AddressProfile>()
                .HasBaseType<BaseProfile>()
                .ToTable("AddressProfile");

            modelBuilder.Entity<JobTitles>()
                .HasBaseType<BaseProfile>()
                .ToTable("JobTitles");

            modelBuilder.Entity<PeopleProfile>()
                .HasBaseType<BaseProfile>()
                .ToTable("PeopleProfile");

            modelBuilder.Entity<Jobs>()
                .HasBaseType<BaseProfile>()
                .ToTable("Jobs");

            modelBuilder.Entity<LoginProfile>()
                .HasBaseType<BaseProfile>()
                .ToTable("LoginProfile");

            modelBuilder.Entity<EmployeeJobs>()
                .HasBaseType<BaseProfile>()
                .ToTable("EmployeeJobs");
        }


    }
}
