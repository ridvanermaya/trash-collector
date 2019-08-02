using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TrashCollector.Web.Models;

namespace TrashCollector.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TrashCollector.Web.Models.DAddress> DAddress { get; set; }
        public DbSet<TrashCollector.Web.Models.DCustomer> DCustomer { get; set; }
        public DbSet<TrashCollector.Web.Models.DEmployee> DEmployee { get; set; }
    }
}
