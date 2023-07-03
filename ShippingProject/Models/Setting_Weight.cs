using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShippingProject.Models
{
    public class Setting_Weight
    {
        [Key]

        public string Id { get; set; }
        public double weight_shipping { get; set; }
        public double Extra_weight { get; set; }
        [ForeignKey(nameof(order))]
        public string order_id { get; set; }
        public virtual Order? order { get; set; }

    }
}
