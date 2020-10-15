using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Data
{
    public class Contact
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        public DateTime BirthDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        public override String ToString()
        {
            return "Name: " + this.FirstName + " " + this.LastName + " | Phone Number: " + this.PhoneNumber + " | Birth Date: " + this.BirthDate;
        }
    }
}
