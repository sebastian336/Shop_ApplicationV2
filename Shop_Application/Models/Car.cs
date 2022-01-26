using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop_Application.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        
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
        private int _PriceOfCar = 5;
        public int PriceOfCar { get { return this._PriceOfCar; } set { this._PriceOfCar = value; } }
        public bool WearOfCar { get; set; }
        public bool Hide { get; set; }
        [ForeignKey("Category")]
        public virtual int CategoryId { get; set; }
        public virtual Category? Category { get; set; }

        public virtual ICollection<PlacementOfOrder>? PlacementOfOrders { get; set; }
        public virtual ICollection<Order>? Orders { get; set; }
    }
}
