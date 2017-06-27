using EcommerceApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApp.Services.Infrastructure
{
    public interface IOrderLine
    {
        IEnumerable<OrderLine> GetAll();

        OrderLine GetById(int orderLineId);

        void Insert(OrderLine orderLine);

        void Update(OrderLine orderLine);

        int Count();

        void Save();
    }
}
