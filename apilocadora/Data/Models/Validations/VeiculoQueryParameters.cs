using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace apilocadora.Data.Models.Validations
{
    public class VeiculoQueryParameters
    { 
        [Required]
        [RegularExpression(@"(^[a-zA-Z]{3}[0-9]{4}$|^[a-zA-Z]{3}[0-9]{1}[a-zA-Z]{1}[0-9]{2}$)", 
            ErrorMessage = "A placa informada não é valida.")]
        public string CarPlateNumber { get; set; }
    }
}