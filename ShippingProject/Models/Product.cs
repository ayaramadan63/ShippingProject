using System.ComponentModel.DataAnnotations;

namespace ShippingProject.Models
{
    public class Product
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string weight { get; set; }
        public string Quantity { get; set; }

        public string? Id_Order { get; set; }
        public virtual Order? order { get; set; }
    }
}
