using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;

namespace Blog.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string adminName { get; set; }
        public string adminSurname { get; set; }
        public string adminEmail { get; set; }
        public DateTime adminDate { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<ImagePath> ImagePaths { get; set; }
    }
}