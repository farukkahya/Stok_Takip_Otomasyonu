using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_Takip_Otomasyonu_Business.Interfaces
{
    public interface IListeleGuncelle<T> : IEkleSil<T>
    {
        List<T> GetAll();
        void Update(T entity);
    }
}
