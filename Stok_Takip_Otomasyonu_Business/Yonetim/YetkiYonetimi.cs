using Stok_Takip_Otomasyonu_Business.Interfaces;
using Stok_Takip_Otomasyonu_Data.DAL.Tables;
using Stok_Takip_Otomasyonu_DataAccess.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_Takip_Otomasyonu_Business.Yonetim
{
    public class YetkiYonetimi : IListeleGuncelle<YetkiTablosu>,ISearch<YetkiTablosu>
    {
        DatabaseEntities db = new DatabaseEntities();
        public YetkiTablosu Add(YetkiTablosu entity)
        {
            var result = db.yetkiTablosu.Add(entity);
            db.SaveChanges();
            return result;
        }

        public void Delete(YetkiTablosu entity)
        {
            db.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();

        }

        public List<YetkiTablosu> GetAll()
        {
            return db.yetkiTablosu.ToList();
        }

        public List<YetkiTablosu> Search(string value)
        {
            return db.yetkiTablosu.Where(x => x.Ad.Contains(value)).ToList();
        }

        public void Update(YetkiTablosu entity)
        {
            db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

        }
    }
}
