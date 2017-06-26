using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceApp.Models.Entities
{
    [Table("OrderLine")]
    public class OrderLine
    {
        public int OrderLineId { get; set; }
        public int? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }

        [Range(1,100)]
        public decimal? Price { get; set; }

        public int? OrderId { get; set; }
        public virtual Order Orders { get; set; }

        public int? ProductId { get; set; }
        public Product Products { get; set; }
    }
}