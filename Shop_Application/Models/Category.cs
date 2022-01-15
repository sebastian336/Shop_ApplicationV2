using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop_Application.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Wprowadz nazwe kategorii")]
        [StringLength(100)]
        public string NameCategory { get; set; }
        [Required(ErrorMessage = "Wprowadz opis kategorii")]
        [StringLength(2000)]
        public string CategoryDescription { get; set; }
        public string NameFileIcon { get; set; }

       public virtual ICollection<Car>? Cars { get; set; }

    }
}
