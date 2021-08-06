using Kayıt_Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access
{
    public class KayıtDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder); 
            optionsBuilder.UseSqlServer("Server=MSI; Database=KayıtDb;uid=sa;pwd=1234");
        }
         public DbSet<Kayıt> Kayıts { get; set; }

    }
}
