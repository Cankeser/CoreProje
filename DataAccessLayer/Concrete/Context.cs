using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-MV2GLCC\\SQLEXPRESS;database=CoreProjeDB; Integrated security=true");


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>().HasData(new Admin
            {
                ID = 1,
                LastDate = DateTime.Now, 
                Name = "Can",
                Password = "202cb962ac59075b964b07152d234b70",
                Surname = "Keser",
                UserName = "can"
            });
        }
        public DbSet<About> abouts { get; set; }
        public DbSet<Contact> contacts { get; set; }
        public DbSet<Experience> experiences { get; set; }
        public DbSet<Feature> features { get; set; }
        public DbSet<Message> messages { get; set; }
        public DbSet<Portfolio> portfolios { get; set; }
        public DbSet<Service> services { get; set; }
        public DbSet<Skill> skills { get; set; }
        public DbSet<Testimonial> testimonials { get; set; }
        public DbSet<Admin> admins { get; set; }
     
    }
}
