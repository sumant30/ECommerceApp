using EcommerceApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApp.Services.Infrastructure
{
    public interface ICategory
    {
        IEnumerable<Category> GetAll();

        Category GetById(int categoryId);

        void Insert(Category category);

        void Update(Category category);

        void Delete(int categoryId);

        int Count();

        void Save();
    }
}
