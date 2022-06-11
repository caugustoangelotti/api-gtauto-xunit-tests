using System;

namespace apilocadora.Data.Models
{
    public class Veiculo
    {
        public Guid IdVeiculo { get; set; }
        public string Categoria { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
    }
}