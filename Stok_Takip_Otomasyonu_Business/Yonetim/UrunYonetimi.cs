using Stok_Takip_Otomasyonu_Business.Interfaces;
using Stok_Takip_Otomasyonu_Data.DAL.Tables;
using Stok_Takip_Otomasyonu_DataAccess.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_Takip_Otomasyonu_Business.Yonetim
{
    public class UrunYonetimi : IListeleGuncelle<UrunTablosu>, ISearch<UrunTablosu>
    {
        DatabaseEntities db = new DatabaseEntities();
        public UrunTablosu Add(UrunTablosu entity)
        {
            var result = db.urunTablosu.Add(entity);
            db.SaveChanges();
            return result;
        }

        public void Delete(UrunTablosu entity)
        {
            db.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }

        public List<UrunTablosu> GetAll()
        {
            return db.urunTablosu.ToList();
        }

        public List<UrunTablosu> Search(string value)
        {
            return db.urunTablosu.Where(x => x.Ad.Contains(value)).ToList();
        }

        public void Update(UrunTablosu entity)
        {
            db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            bool saveFailed;
            do
            {
                saveFailed = false;

                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    saveFailed = true;

                    ex.Entries.Single().Reload();
                }

            } while (saveFailed);
        }
    }
}
