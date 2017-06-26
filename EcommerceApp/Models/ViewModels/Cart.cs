using EcommerceApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApp.Models.ViewModels
{
    public class Cart
    {
        public List<CartItem> CartItems { get; set; } = new List<CartItem>();
    }
}
