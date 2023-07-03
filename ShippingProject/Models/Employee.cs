using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShippingProject.Models
{
    public class Employee
    {
        [Key]

        public string ID { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }

        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsDeleted { get; set; }
        [ForeignKey(nameof(branches))]
        public string Id_Branch { get; set; }
        public virtual Branches? branches { get; set; }

        public virtual ICollection<Employee_Order> Employee_Order { get; set; }



    }
}
