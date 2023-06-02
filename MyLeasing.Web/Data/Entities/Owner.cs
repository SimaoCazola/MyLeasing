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
        [Display(Name = "Document")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Document { get; set; }
        [Display(Name = "First Name")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string LastName { get; set; }
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Address { get; set; }
    
        [Required]
        [DisplayName("Fixed Phone")]
        public string? FixedPhone { get; set; }

        [Required]
        [DisplayName("Cell Phone")]
        public string? Cellphone { get; set; }

        public string FullName => $"{FirstName} {LastName}";
        public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}";
        public User User { get; set; }


    }
}
