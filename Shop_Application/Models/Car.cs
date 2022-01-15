using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop_Application.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Wprowadz marke auta")]
        [StringLength(100)]
        public string CarMark { get; set; }
        [Required(ErrorMessage = "Wprowadz model auta")]
        [StringLength(100)]
        public string CarModel { get; set; }
        public DateTime YearOfProduction { get; set; }
        public string NameOfPicture { get; set; }
        [Required(ErrorMessage = "Wprowadz opis auta")]
        [StringLength(2000)]
        public string CarDescription { get; set; }
        public int PriceOfCar { get; set; }
        public bool WearOfCar { get; set; }
        public bool Hide { get; set; }
        //[ForeignKey("Category")]
        public virtual Category Category { get; set; }
    }
}
