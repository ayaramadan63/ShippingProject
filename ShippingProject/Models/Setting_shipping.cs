using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShippingProject.Models
{
    public class Setting_shipping
    {
        [Key]
        public string Id { get; set; }
        public string village_shipping { get; set; }
        public string regular_shipping { get; set; }

        [ForeignKey(nameof(order))]
        public string order_id { get; set; }
        public virtual Order? order { get; set; }
    }
}
