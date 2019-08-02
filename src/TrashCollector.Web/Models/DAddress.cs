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
        public string AddressTitle { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateAbbreviation { get; set; }
        public int ZipCode { get; set; }
        [ForeignKey(nameof(UserId))]
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
    }
}