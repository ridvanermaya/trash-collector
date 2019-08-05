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
        public DateTime PickupDate { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public string Message { get; set; }
    }
}