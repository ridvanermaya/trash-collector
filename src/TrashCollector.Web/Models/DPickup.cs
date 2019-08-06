using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace TrashCollector.Web.Models
{
    [Table("Pickup")]
    public class DPickup
    {
        [Key]
        public int PickupId { get; set; }
        [Display(Name = "Pickup Date")]
        public DateTime PickupDate { get; set; }
        [Display(Name = "Customer Id")]
        public int CustomerId { get; set; }
        [Display(Name = "Employee Id")]
        public int EmployeeId { get; set; }
        public string Message { get; set; }
    }
}