using System.ComponentModel.DataAnnotations;

namespace eticaret.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required] //gerekli boş bıraklamaz. don't be empty
        public string Name { get; set; }
    }
}
