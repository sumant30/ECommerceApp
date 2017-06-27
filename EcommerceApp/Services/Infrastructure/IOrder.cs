using EcommerceApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApp.Services.Infrastructure
{
    public interface IOrder
    {
        IEnumerable<Order> GetAll();

        Order GetById(int orderId);

        void Delete(int orderId);

        int Count();

        void Save();
    }
}
