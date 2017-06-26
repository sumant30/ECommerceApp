using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceApp.Models.Entities
{   
    [Table("Picture")]
    public class Picture
    {
        public int PictureId { get; set; }

        [StringLength(100)]
        public string FileName { get; set; }

      
    }
}