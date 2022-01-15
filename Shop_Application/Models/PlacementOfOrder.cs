using System.ComponentModel.DataAnnotations;

namespace Shop_Application.Models
{
    public class PlacementOfOrder
    {
        [Key]
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int CarId { get; set; }
        public int Quantity { get; set; }
        public int PriceOfBuy { get; set; }

        public virtual Car Car { get; set; }
        public virtual Order Order { get; set; }
    }
}
