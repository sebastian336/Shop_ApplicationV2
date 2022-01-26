using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop_Application.Models
{
    public class PlacementOfOrder
    {
        [Key]
        public int Id { get; set; }
        public int PriceOfBuy { get; set; }
    
        [ForeignKey("Order")]
        public virtual int OrderId { get; set; }
        public virtual Order? Order { get; set; }
    }
}
