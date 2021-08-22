using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginReg.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}
        [Required]
        [MaxLength(2)]
        public string FirstName {get;set;}
        [Required]
        [MaxLength(2)]
        public string LastName {get;set;}
        [Required]
        [EmailAddress]
        public string Email {get;set;}
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Must hae 8 characters for password")]
        public string Password {get;set;}
        [NotMapped]
        [Required]
        [MaxLength(8)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string Confirm {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}