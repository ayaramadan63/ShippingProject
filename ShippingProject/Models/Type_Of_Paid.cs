using System.ComponentModel.DataAnnotations;

namespace ShippingProject.Models
{
    public class Type_Of_Paid
    {
        [Key]

        public string Id  { get; set; }
        public string Name { get; set; }
        public virtual Order order { get; set; }


    }
}
