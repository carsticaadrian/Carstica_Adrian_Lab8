using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Carstica_Adrian_Lab8.Models;

namespace Carstica_Adrian_Lab8.Data
{
    public class Carstica_Adrian_Lab8Context : DbContext
    {
        public Carstica_Adrian_Lab8Context (DbContextOptions<Carstica_Adrian_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Carstica_Adrian_Lab8.Models.Book> Book { get; set; }

        public DbSet<Carstica_Adrian_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Carstica_Adrian_Lab8.Models.Category> Category { get; set; }
    }
}
