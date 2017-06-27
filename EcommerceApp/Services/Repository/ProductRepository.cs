using EcommerceApp.Services.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceApp.Models.Entities;
using EcommerceApp.Context;

namespace EcommerceApp.Services.Repository
{
    public class ProductRepository : IProduct
    {
        private readonly ECommerceContext _context;

        public ProductRepository(ECommerceContext context)
        {
            _context = context;
        }
        public int Count()
        {
            return _context.Product.Count();
        }

        public void Delete(int productId)
        {
            var product = GetById(productId);
            if (product != null)
            {
                _context.Product.Remove(product);
            }
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Product.Select(p => p);
        }

        public Product GetById(int productId)
        {
            return _context.Product.FirstOrDefault(p => p.ProductId == productId);
        }

        public void Insert(Product product)
        {
            _context.Product.Add(product);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Product product)
        {
            _context.Product.Update(product);
        }
    }
}
