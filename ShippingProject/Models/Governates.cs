using System.ComponentModel.DataAnnotations;

namespace ShippingProject.Models
{
    public class Governates
    {
        private string GenerateUniqueId()
        {
            Guid guid = Guid.NewGuid();
            return guid.ToString();
        }
        public Governates()
        {
            Id = GenerateUniqueId();
        }
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<Cities>? cities { get; set; }
        public virtual ICollection<Trader>? traders { get; set; }
        public virtual ICollection<representive>? representive { get; set; }

        public virtual Order? order { get; set; }


    }
}
