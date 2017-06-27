using EcommerceApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApp.Services.Infrastructure
{
    public interface ISubCategory
    {
        IEnumerable<SubCategory> GetAll();

        SubCategory GetById(int subCategoryId);

        void Insert(SubCategory subCategory);

        void Update(SubCategory subCategory);

        void Delete(int subCategoryId);

        int Count();

        void Save();
    }
}
