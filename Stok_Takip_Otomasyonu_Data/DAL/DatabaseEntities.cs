using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using Stok_Takip_Otomasyonu_Data.DAL.Tables;

namespace Stok_Takip_Otomasyonu_DataAccess.DAL
{
    public class DatabaseEntities : DbContext
    {
        public DatabaseEntities()
        {
            Database.SetInitializer<DatabaseEntities>(null);
        }
        public DbSet<PersonelTablosu> personelTablosu { get; set; }
        public DbSet<UrunTablosu> urunTablosu { get; set; }
        public DbSet<YetkiTablosu> yetkiTablosu { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonelTablosu>().ToTable("PersonelTablosu");
            modelBuilder.Entity<UrunTablosu>().ToTable("UrunTablosu");
            modelBuilder.Entity<YetkiTablosu>().ToTable("YetkiTablosu");
        }
    }
}
