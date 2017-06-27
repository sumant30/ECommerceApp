using EcommerceApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApp.Services.Infrastructure
{
    public interface ICartItem
    {
        IEnumerable<CartItem> GetAll();

        CartItem GetById(int cartItemId);

        void Insert(CartItem cartItem);

        void Update(CartItem cartItem);

        void Delete(int cartItemId);

        int Count();

        void Save();
    }
}
