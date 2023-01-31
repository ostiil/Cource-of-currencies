using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Contexts
{
    public class ContextFactory : IDesignTimeDbContextFactory<DbContextIntagrator>
    {
        public DbContextIntagrator CreateDbContext(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder<DbContextIntagrator>();
            optionBuilder.UseSqlServer("Data Source=TPC\\SQLEXPRESS;Initial Catalog=demo;Integrated Security=True");
            return new DbContextIntagrator(optionBuilder.Options);
        }
    }
}
