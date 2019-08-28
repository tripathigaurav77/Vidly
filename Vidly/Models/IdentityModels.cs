using Microsoft.AspNet.Identity.EntityFramework;

namespace Vidly.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public System.Data.Entity.DbSet<Customer> Customers { get; set; }
        public System.Data.Entity.DbSet<Movie> Movies { get; set; }
        public System.Data.Entity.DbSet<MembershipType> MembershipTypes{ get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }
}