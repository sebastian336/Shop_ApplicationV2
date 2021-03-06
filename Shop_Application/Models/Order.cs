using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop_Application.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Wprowadz imie")]
        [StringLength(20)]
        public string NameCustomer { get; set; }
        [Required(ErrorMessage = "Wprowadz Nazwisko")]
        [StringLength(20)]
        public string SurnameCustomer { get; set; }
        [Required(ErrorMessage = "Wprowadz Miasto")]
        [StringLength(100)]
        public string City { get; set; }
        [Required(ErrorMessage = "Wprowadz Ulice")]
        [StringLength(100)]
        public string Street { get; set; }
        [Required(ErrorMessage = "Wprowadz Numer telefonu")]
        [StringLength(100)]
        public string Phone { get; set; }
        public string Comment { get; set; }
        public DateTime DateOfAdd { get; set; } = DateTime.Now;

        [ForeignKey("Car")]
        public virtual int CarId { get; set; }
        public virtual Car? Car { get; set; }

        public int PriceOfOrder { get; set; }

    List<PlacementOfOrder> PlacementsOfOrder { get; set; }
        public virtual ICollection<PlacementOfOrder>? PlacementOfOrders { get; set; }

    }
   
}

