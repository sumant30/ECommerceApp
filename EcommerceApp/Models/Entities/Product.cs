using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceApp.Models.Entities
{
    [Table("Product")]
    public class Product
    {
        public int ProductId { get; set; }

        [Required,Display(Name ="Product Name")]
        public string ProductName { get; set; }

        public string Details { get; set; }
        public decimal UnitPrice { get; set; }
        public int? UnitsInStock { get; set; }
        public byte[] ProductImagePath { get; set; }

       
        public virtual ICollection<CartItem> CartItems { get; set; } = new HashSet<CartItem>();

        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }


        public virtual ICollection<OrderLine> OrderLines { get; set; } = new HashSet<OrderLine>();

        public int? PictureId { get; set; }
        public virtual ICollection<Picture> Pictures { get; set; }
    }
}