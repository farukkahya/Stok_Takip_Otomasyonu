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
    public class PersonelYonetimi : IListeleGuncelle<PersonelTablosu>, ISearch<PersonelTablosu>
    {
        DatabaseEntities db = new DatabaseEntities();
        public PersonelTablosu Add(PersonelTablosu entity)
        {
            var result = db.personelTablosu.Add(entity);
            db.SaveChanges();
            return result;
        }

        public void Delete(PersonelTablosu entity)
        {
            db.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();

        }

        public List<PersonelTablosu> GetAll()
        {
            return db.personelTablosu.ToList();
        }

        public List<PersonelTablosu> Search(string value)
        {
            return db.personelTablosu.Where(x => x.Ad.Contains(value)).ToList();
        }

        public void Update(PersonelTablosu entity)
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
