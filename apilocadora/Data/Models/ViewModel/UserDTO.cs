using System;

namespace apilocadora.Data.Models.ViewModel
{
    public class UserDTO
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
    }
}