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

        public DbContextIntagrator(DbContextOptions<DbContextIntagrator> connection) 
        {
        }
    }
}
