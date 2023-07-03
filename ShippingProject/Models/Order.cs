using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShippingProject.Models
{
    public class Order
    {
        [Key]
        public string Id_Order { get; set; }
        public string Address_trader { get; set; }
        public string phone_trader { get; set; }
        public string Notes { get; set; }
        public bool Order_Status { get; set; } = false;
        public string Client_Name { get; set; }
        public string Total_weight { get; set; }
        public string oreder_salary_from_trader { get; set; }
        public string Email { get; set; }
        public bool flag_of_villagee { get; set; }
        public string Village_Name { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey(nameof(city))]
        public string? Id_City { get; set; }
        [ForeignKey(nameof(branches))]
        public string? Id_Branch { get; set; }
        public virtual Branches? branches { get; set; }
        [ForeignKey(nameof(Governates))]
        public string? Id_Governate { get; set; }
        public virtual Governates? Governates { get; set; }
        public virtual Cities? city { get; set; }
        public string Phone { get; set; }
        [ForeignKey(nameof(type_Of_Paid))]
        public string? Id_type_paid { get; set;}
        public virtual Type_Of_Paid? type_Of_Paid { get; set; }
        [ForeignKey(nameof(type_Of_Shipping))]
        public string? Id_Type_Shipping { get; set; }
        public virtual Type_Of_Shipping? type_Of_Shipping { get; set; }

        [ForeignKey(nameof(representive))]
        public string ?Id_representive { get; set; }
        public virtual representive? representive { get; set; }
        public virtual ICollection<Employee_Order> Employee_Order { get; set; }
        public virtual ICollection<Product> product { get; set; }






    }
}
