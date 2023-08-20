using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuWebsite1.Models
{
    public class DuDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=DuWebsite;Trusted_Connection=true");
        }
        public DbSet<Duyuru> Duyurular { get; set; }
        public DbSet<Admin> Kullanıcılar { get; set; }

        //internal Duyuru SingleOrDefault(Func<object, bool> p)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
