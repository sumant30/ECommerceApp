using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceApp.Models.Entities
{
    [Table("SubCategory")]
    public class SubCategory
    {
        public int SubCategoryId { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name ="SubCategory Name")]
        public string SubCategoryName { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}