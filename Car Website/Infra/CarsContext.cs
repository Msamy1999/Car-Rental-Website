using Car_Website.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Website.Infra
{
    public class CarsContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CarDB;Data Source=.");
        }


        public DbSet<Types> Types { get; set; }
    }
}
