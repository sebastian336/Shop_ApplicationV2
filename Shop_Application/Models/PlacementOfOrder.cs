using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop_Application.Models
{
    public class PlacementOfOrder
    {
        [Key]
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int PriceOfBuy { get; set; }

        [ForeignKey("Car")]
        public virtual int CarId { get; set; }
        public virtual Car? Car { get; set; }

        [ForeignKey("Order")]
        public virtual int OrderId { get; set; }
        public virtual Order? Order { get; set; }
    }
}
