using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace TrashCollector.Web.Models
{
    [Table("Address")]
    public class DAddress
    {
        [Key]
        public int AddressId { get; set; }
        [Display(Name = "Address Title")]
        public string AddressTitle { get; set; }
        [Display(Name = "Address Line 1")]
        public string AddressLine1 { get; set; }
        [Display(Name = "Address Line 2")]
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        [Display(Name = "State Abbreviation")]
        public string StateAbbreviation { get; set; }
        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
    }
}