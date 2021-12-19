using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Martin_Manuel_Lab5.Models;

namespace Martin_Manuel_Lab5.Data
{
    public class Martin_Manuel_Lab5Context : DbContext
    {
        public Martin_Manuel_Lab5Context (DbContextOptions<Martin_Manuel_Lab5Context> options)
            : base(options)
        {
        }

        public DbSet<Martin_Manuel_Lab5.Models.Book> Book { get; set; }

        public DbSet<Martin_Manuel_Lab5.Models.Publisher> Publisher { get; set; }

        public DbSet<Martin_Manuel_Lab5.Models.Category> Category { get; set; }

        public DbSet<Martin_Manuel_Lab5.Models.BookCategory> BookCategory { get; set; }
    }
}
