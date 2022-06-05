using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_Takip_Otomasyonu_Data.DAL.Tables
{
    public class UrunTablosu
    {
        [Key]
        public int UrunId { get; set; }
        public string Ad { get; set; }
        public int Adet { get; set; }
        public DateTime EklemeTarihi { get; set; }
        [ForeignKey("personelTablosu")]
        public int EkleyenKisi { get; set; }

        public PersonelTablosu personelTablosu { get; set; }
    }
}
