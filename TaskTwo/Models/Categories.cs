using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaskTwo.Models
{
    public class Category
    {
        public int Id { get; set; }


        [NotMapped]
        public IFormFile? ImageFile { get; set; }


        [Required]
        [StringLength(25)]
        public string CategoryName { get; set; }

        public string CategoryImage { get; set; }

        
    }
}
