using EcommerceApp.Services.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceApp.Models.Entities;
using EcommerceApp.Context;

namespace EcommerceApp.Services.Repository
{
    public class CategoryRepository : ICategory
    {
        private readonly ECommerceContext _context;

        public CategoryRepository(ECommerceContext context)
        {
            _context = context;
        }

        public int Count()
        {
            return _context.Category.Count();
        }

        public void Delete(int categoryId)
        {
            var category = GetById(categoryId);
            if (category != null)
            {
                _context.Category.Remove(category);
            }
        }

        public IEnumerable<Category> GetAll()
        {
            return _context.Category.Select(c => c);
        }

        public Category GetById(int categoryId)
        {
            return _context.Category.FirstOrDefault(c => c.CategoryId == categoryId);
        }

        public void Insert(Category category)
        {
            _context.Category.Add(category);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Category category)
        {
            _context.Category.Update(category);
        }
    }
}
