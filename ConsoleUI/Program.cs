using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    // SOLID PRENSIPLERI
    // Open Closed Principle
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal()); // Bu ben "InMemory" veya "EntityFramework" çalışıcam demek.
            
            foreach (var product in productManager.GetByUnitPrice(28,100))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
