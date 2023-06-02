using MyLeasing.Web.Data.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net;


namespace MyLeasing.Common
{
    public class Owner : IEntity
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "The field {0} can contain {1}Characters length.")]
        [DisplayName("Document*")]
        public string Document { get; set; }

        [Required]
        [DisplayName("First Name*")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name*")]
        public string LastName { get; set; }

        [Required]
        [DisplayName("Fixed Phone")]
        public string? FixedPhone { get; set; }

        [Required]
        [DisplayName("Cell Phone")]
        public string? Cellphone { get; set; }

        [Required]
        [DisplayName("Address")]
        public string? Address { get; set; }

        [DisplayName("Owner Name")]

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public User User { get; set; }


    }
}
