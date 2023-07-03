using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShippingProject.Models
{
    public class Trader
    {
        //private string GenerateUniqueId()
        //{
        //    Guid guid = Guid.NewGuid();
        //    return guid.ToString();
        //}
        //public Trader()
        //{
        //    ID = GenerateUniqueId();
        //}

        [Key]
        public string ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public double? Per_Rejected_order { get; set; }

        public bool? IsDeleted { get; set; }

        [ForeignKey(nameof(city))]
        public string Id_City { get; set; }
        [ForeignKey(nameof(branches))]
        public string Id_Branch { get; set; }
        public virtual Branches branches { get; set; }
        [ForeignKey(nameof(Governates))]
        public string Id_Governate { get; set; }
        public virtual Governates Governates { get; set; }
        public virtual Cities city { get; set; }





    }
}
