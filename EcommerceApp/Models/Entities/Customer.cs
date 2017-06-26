
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApp.Models.Entities
{
    [Table("Customer")]
    public class Customer
    {
        [ScaffoldColumn(false)]
        public int CustomerId { get; set; }

        [Required]
        public string CustomerName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }

        [DataType(DataType.PostalCode)]
        public int PostalCode { get; set; }

        [EmailAddress]
        public string EmailAddress { get; set; }
        public DateTime? DateEntered { get; set; }

        public virtual ICollection<CartItem> CartItems { get; set; } = new HashSet<CartItem>();
        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();
    }
}
