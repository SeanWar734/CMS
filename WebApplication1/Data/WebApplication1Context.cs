using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class WebApplication1Context : DbContext
    {
        public WebApplication1Context (DbContextOptions<WebApplication1Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplication1.Data.Contact> Contact { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Contact>().HasData
                (

                    new Contact
                    {
                        Id =Guid.Parse("12345678-1234-1234-1234-123456123456"),
                        BirthDate = DateTime.Parse("11/4/1969"),
                        FirstName = "Pedro",
                        LastName = "Penduko",
                        PhoneNumber = "734-867-5309"
                    },

                     new Contact
                     {
                         Id = Guid.Parse("87654321-4321-4321-4321-654321654321"),
                         BirthDate = DateTime.Parse("2/14/1971"),
                         FirstName = "Julian",
                         LastName = "Talisman",
                         PhoneNumber = "734-112-2334"
                     }
                ) ;
        }
    }
}
