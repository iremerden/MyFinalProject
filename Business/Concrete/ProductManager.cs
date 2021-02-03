using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal; // INJECTION. Soyut nesneyle bağlantı kurucaz. Ne "InMemory" nede "EntityFramework" lafı geçecek.

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            // İŞ KODLARI (if kodları var.)
            // Bir iş sınıfı başka bir iş sınıfını newlemez bunun için injection yapmalıyız.

            return _productDal.GetAll();
        }
    }
}
