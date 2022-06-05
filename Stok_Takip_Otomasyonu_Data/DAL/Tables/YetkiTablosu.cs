using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_Takip_Otomasyonu_Data.DAL.Tables
{
    public class YetkiTablosu
    {
        [Key]
        public int YetkiId { get; set; }
        public string Ad { get; set; }

        public IEnumerable<PersonelTablosu> PersonelTablosu { get; set; }
    }
}
