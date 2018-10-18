using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReproForSelectManyEfBug
{
    public class ReproDbContext : DbContext
    {
        public ReproDbContext() : base(new DbContextOptionsBuilder<ReproDbContext>().UseSqlServer("Server=localhost;Database=ReproForSelectManyEfBug;Integrated Security=true").Options)
        {

        }

        public DbSet<Parent> Parents { get; set; }
        public DbSet<Child> Children { get; set; }
    }
}
