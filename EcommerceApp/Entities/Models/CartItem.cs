
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceApp.Models.Entities
{
    [Table("CartItem")]
    public class CartItem
    {
        [Key]
        public int CartId { get; set; }
        public int? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Price { get; set; }

        public int? CustomerId { get; set; }
        public virtual  Customer Customers { get; set; }

        public int? ProductId { get; set; }
        public virtual Product Products { get; set; }
    }
}