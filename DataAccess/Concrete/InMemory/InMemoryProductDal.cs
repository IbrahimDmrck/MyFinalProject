using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=5,UnitsInStock=20},
                new Product{ProductId=2,CategoryId=1,ProductName="Sürahi",UnitPrice=10,UnitsInStock=10},
                new Product{ProductId=3,CategoryId=1,ProductName="Tepsi",UnitPrice=3,UnitsInStock=5},
                new Product{ProductId=4,CategoryId=2,ProductName="Telefon",UnitPrice=2000,UnitsInStock=25},
                new Product{ProductId=5,CategoryId=2,ProductName="Laptop",UnitPrice=3000,UnitsInStock=15},
                new Product{ProductId=6,CategoryId=2,ProductName="Tablet",UnitPrice=1500,UnitsInStock=8}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);

            _products.Remove(productToDelete);
           
        }

        public List<Product> GetAll()
        {
            return _products;
        }


        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}
