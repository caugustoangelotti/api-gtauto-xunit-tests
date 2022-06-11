using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace apilocadora.Data.Models
{
    public class User
    {
        public Guid IdUser { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        [NotMapped]
        public string JwtToken { get; set; }

    }
}