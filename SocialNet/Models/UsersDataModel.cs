using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SocialNet.Models
{
    public class UsersDataModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string Nik { get; set; }
        [DataType(DataType.EmailAddress)]
        public string UserEmailAddress { get; set; }
        public string Sex { get; set; }
        public string Contacts { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
        public Cities City { get; set; }

        public string AboutMyself { get; set; }
    }
}