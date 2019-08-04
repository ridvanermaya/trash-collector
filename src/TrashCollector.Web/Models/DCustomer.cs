using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace TrashCollector.Web.Models
{
    [Table("Customer")]
    public class DCustomer
    {
        [Key]
        public int CustomerId { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Pickup Day")]
        public DayOfWeek PickUpDay { get; set; }
        [Display(Name = "One Time Pick Up Date")]
        public DateTime? OneTimePickUpDate { get; set; }
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
    }
}