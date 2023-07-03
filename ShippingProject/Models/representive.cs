using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShippingProject.Models
{
    public class representive
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string type_of_discount { get; set; }
        public string company_percantage { get; set; }

        [ForeignKey(nameof(branches))]
        public string Id_Branch { get; set; }
        public virtual Branches? branches { get; set; }
        [ForeignKey(nameof(Governates))]
        public string Id_Governate { get; set; }
        public virtual Governates? Governates { get; set; }

    }
}
