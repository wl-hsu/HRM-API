using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Infrastructure.Data
{

    
    public class RecruitingDbContext: DbContext
    {

        public RecruitingDbContext(DbContextOptions<RecruitingDbContext> options) : base(options) 
        { 

        }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Candidate> Candidates { get; set; }

        public DbSet<JobStatusLookUp> JobStatusLookUp { get; set;}

        public DbSet<Submission> Submissions { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Candidate>(ConfigureCandidate);
        //}

        //private void ConfigureCandidate(EntityTypeBuilder<Candidate> builder)
        //{
        //    builder.HasKey(x => x.Id);
        //    builder.Property(x => x.FirstName).HasMaxLength(100);
        //    builder.HasIndex(x => x.Email).IsUnique();
        //    builder.Property(x => x.CreateOn).HasDefaultValueSql("getdate()");

        //}
    }
}
