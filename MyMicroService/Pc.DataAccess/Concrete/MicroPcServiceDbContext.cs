using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Pc.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc.DataAccess.Concrete
{
    public class MicroPcServiceDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ProductDB;Trusted_Connection=true");
        }

        public DbSet<Product>? Products { get; set; }
    }
}
