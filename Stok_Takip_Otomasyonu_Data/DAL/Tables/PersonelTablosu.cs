using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_Takip_Otomasyonu_Data.DAL.Tables
{
    public class PersonelTablosu
    {
        [Key]
        public int PersonelId { get; set; }
        public string Ad { get; set; }
        public string TcNo { get; set; }
        public string TelNo { get; set; }
        public DateTime BaslamaTarihi { get; set; }
        [ForeignKey("YetkiTablosu")]
        public int Yetki { get; set; }
        public string KullaniciAdi { get; set; }
        public string KullaniciSifre { get; set; }

        public YetkiTablosu YetkiTablosu { get; set; }
        public IEnumerable<UrunTablosu> UrunTablosu { get; set; }
    }
}
