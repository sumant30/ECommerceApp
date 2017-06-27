using EcommerceApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApp.Services.Infrastructure
{
    public interface IProduct
    {
        IEnumerable<Product> GetAll();

        Product GetById(int productId);

        void Insert(Product product);

        void Update(Product product);

        void Delete(int productId);

        int Count();

        void Save();
    }
}
