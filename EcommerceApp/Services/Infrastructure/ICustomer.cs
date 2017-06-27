using EcommerceApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApp.Services.Infrastructure
{
    public interface ICustomer
    {
        IEnumerable<Customer> GetAll();

        Customer GetById(int customerId);

        void Insert(Customer customer);

        void Update(Customer customer);

        void Delete(int customerId);

        void Save();
    }
}
