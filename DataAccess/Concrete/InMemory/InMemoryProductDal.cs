﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            // Oracle,Sql Server, Postgres, MongoDb gibi veri tabanlarından geliyormuş gibi simule ettik.

            _products = new List<Product> {
            new Product{ProductId=1, CategoryId=1, ProductName="Bardak", UnitPrice=15, UnitsInStock=15},
            new Product{ProductId=1, CategoryId=1, ProductName="Kamera", UnitPrice=500, UnitsInStock=3},
            new Product{ProductId=1, CategoryId=1, ProductName="Telefon", UnitPrice=1500, UnitsInStock=2},
            new Product{ProductId=1, CategoryId=1, ProductName="Klavye", UnitPrice=150, UnitsInStock=65},
            new Product{ProductId=1, CategoryId=1, ProductName="Fare", UnitPrice=85, UnitsInStock=1},
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            // LINQ = LANGUAGE INTEGRATED QUERY - DİLE GÖMÜLÜ SORGULAMA

            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId); // Bu kod = Foreach
           
            _products.Remove(productToDelete);

            //Product productToDelete = null;  // LINQ olmasaydı bu yöntemle listeye tek tek dolaşıp eşleşen product ı bulur.
            //foreach (var p in _products)
            //{
            //    if (product.ProductId == p.ProductId)
            //    {
            //        productToDelete = p;
            //    }
            //}
        }

        public List<Product> GetAll() // Burda veritabanındaki datayı business a atkarmak gerek.
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList(); 
            // Where koşulu içindeki şarta uyan bütün elemanları yeni bir liste haline getirir ve onu döndürür.
        }

        public void Update(Product product)
        {
            // Gönderdiğim ürün ıd sine sahip olan listedeki ürünü bul.

            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductId = product.ProductId;
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

        }
    }
}
