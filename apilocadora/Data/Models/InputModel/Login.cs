using System.ComponentModel.DataAnnotations;

namespace apilocadora.Data.Models.InputModel
{
    public class Login
    {
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Você deve inserir um e-mail valido.")]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(32, MinimumLength = 6, ErrorMessage = "A senha deve ter entre 6 e 32 caracteres.")]
        public string Password { get; set; }
    }
}