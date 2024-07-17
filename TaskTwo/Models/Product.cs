using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaskTwo.Models
{
    public class Product
    {
        public int Id { get; set; }



        [Required]
        [StringLength(50)]
        public string ProductName { get; set; }

        [Required]
        public decimal ProductPrice { get; set; }
        [NotMapped]
        public IFormFile? ImageFile { get; set; }

        public string ProductImage { get; set; }

        [StringLength(250)]
        public string ProductDescription { get; set; } = string.Empty;
        [Required]
        public int ProductCategoryID { get; set; }

        [ForeignKey("ProductCategoryID")]
        public Category Category { get; set; }
    }
}
