using EcommerceApp.Services.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceApp.Models.Entities;
using EcommerceApp.Context;

namespace EcommerceApp.Services.Repository
{
    public class SubCategoryRepository : ISubCategory
    {
        private readonly ECommerceContext _context;

        public SubCategoryRepository(ECommerceContext context)
        {
            _context = context;
        }

        public int Count()
        {
            return _context.SubCategory.Count();
        }

        public void Delete(int subCategoryId)
        {
            var subCategory = GetById(subCategoryId);
            if (subCategory != null)
            {
                _context.SubCategory.Remove(subCategory);
            }
        }

        public IEnumerable<SubCategory> GetAll()
        {
            return _context.SubCategory.Select(sc => sc);
        }

        public SubCategory GetById(int subCategoryId)
        {
            return _context.SubCategory.FirstOrDefault(sc => sc.SubCategoryId == subCategoryId);
        }

        public void Insert(SubCategory subCategory)
        {
            _context.SubCategory.Add(subCategory);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(SubCategory subCategory)
        {
            _context.SubCategory.Update(subCategory);
        }
    }
}
