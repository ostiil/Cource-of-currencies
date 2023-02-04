using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Contexts
{
    public class DbContextIntagrator : DbContext
    {
        public DbSet<Users> Users { get; set; }

        public DbSet<Currency> Currencies { get; set; }
        /*public DbContextIntagrator(DbContextOptions<DbContextIntagrator> connection) : base(connection) 
        {
            Database.EnsureCreated();
        }*/

        public DbContextIntagrator()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = TPC\\SQLEXPRESS; Initial Catalog = demo; Integrated Security = True; TrustServerCertificate=True");
        }
    }
}
