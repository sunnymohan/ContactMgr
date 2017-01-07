using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace ContactManager.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Person> Contacts { get; set; }
        public DbSet<Gender> Genders { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}