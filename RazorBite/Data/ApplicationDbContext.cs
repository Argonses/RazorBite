using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RazorBite.Models;
using System.Reflection.Emit;

namespace RazorBite.Data
{
	public class ApplicationDbContext : IdentityDbContext<IdentityUser>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

            builder.Entity<Order>()
            .HasOne(b => b.ApplicationUser)
            .WithMany()
            .HasForeignKey(b => b.ApplicationUserId)
            .OnDelete(DeleteBehavior.Restrict);
        }

		public DbSet<Review> Reviews { get; set; }
		public DbSet<ApplicationUser> ApplicationUsers { get; set; }
		public DbSet<Order> Orders { get; set; }
	}
}
