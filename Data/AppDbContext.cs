using CharitizeMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CharitizeMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cause> Causes { get; set; }
        public DbSet<CauseCategory> CauseCategories { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventRegistration> EventRegistrations { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<NewsletterSubscriber> NewsletterSubscribers { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Volunteer> Volunteers { get; set; }



        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Donation>()
        //        .HasOne(d => d.Cause)
        //        .WithMany(c => c.Donations)
        //        .HasForeignKey(d => d.CauseId)
        //        .OnDelete(DeleteBehavior.Restrict);
 


        //}



    }




}
