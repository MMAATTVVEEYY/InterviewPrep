using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class InterviewPrepDbContext:DbContext
    {
        public InterviewPrepDbContext(DbContextOptions options):base(options) 
        {
            Database.EnsureCreated();
        }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Theme> Themes { get; set; }
    }
}
