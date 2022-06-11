using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using apilocadora.Data.Models;

namespace apilocadora.Repositories
{
    public interface IVeiculoRepository : IDisposable
    {
        Task<Veiculo> GetVehicleByIdAsync(Guid idVeiculo);
        Task<Veiculo> GetVehicleByPlateNumberAsync(string plateNumber);
        Task<IEnumerable<Veiculo>> GetVehiclesAsync(int pagina, int quantidade);
        Task<IEnumerable<Veiculo>> GetVehiclesByCategoryAsync(string categoryName, int pagina, int quantidade);
        Task<IEnumerable<Veiculo>> GetVehiclesByModelAsync(string modelName, int pagina, int quantidade);
    }
}