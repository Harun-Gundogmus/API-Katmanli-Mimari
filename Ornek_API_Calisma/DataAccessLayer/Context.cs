using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=LAPTOP-5ETPORJT;Database=APICalismaDB;Trusted_Connection=true;");
        }
        public DbSet<Ogrenci> OgrenciTablosu { get; set; }
    }
}
