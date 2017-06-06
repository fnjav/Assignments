using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Uppgift3
{
    public class GaragetContext : DbContext
    {
        /// <summary>
        /// Entity framework database
        /// </summary>
        /// <param name="options">options</param>
        public GaragetContext(DbContextOptions<GaragetContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Student>().ToTable("Student");
        }
    }
}
