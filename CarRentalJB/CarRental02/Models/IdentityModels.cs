using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CarRental02.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarBrand> CarBrands { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<CarType> CarTypes { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Member> Members { get; set; }
        //public DbSet<Reservation> Reservations { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<CarRental02.Models.City> Cities { get; set; }

        //public System.Data.Entity.DbSet<CarRental02.ViewModels.SearchCarViewModel> SearchCarViewModels { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Reservation>().HasRequired(t => t.Car).WithMany(
            //  p => p.Reservations).HasForeignKey(t => t.Car).WillCascadeOnDelete(false);
            //modelBuilder.Entity<Reservation>().HasRequired(t => t.Car).WithMany(
            //  p => p.Reservations).HasForeignKey(t => t.Car).WillCascadeOnDelete(false);
            //modelBuilder.Entity<Reservation>().HasRequired(p => p.Car);
        }


    }
}