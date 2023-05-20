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

    
    public class InterviewsDbContext: DbContext
    {

        public InterviewsDbContext(DbContextOptions<InterviewsDbContext> options) : base(options) 
        { 

        }
        public DbSet<Interviewer> Interviewers { get; set; }
        public DbSet<Interviews> Interviews { get; set; }
        public DbSet<InterviewTypeLookUps> InterviewTypeLookUps { get; set;}

    }
}
