using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    // Çıplak Klas Kalmasın. Classes need inheritances. Concrete klasöründeki sınıflar bir veri tabanı tablosuna karşılık gelir.
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
