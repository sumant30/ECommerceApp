using EcommerceApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceApp.Models.Entities
{
    [Table("Order")]
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime? OrderDate { get; set; }
        public decimal OrderTotal { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customers { get; set; }

        public virtual ICollection<OrderLine> OrderLines { get; set; } = new HashSet<OrderLine>();
    }
}