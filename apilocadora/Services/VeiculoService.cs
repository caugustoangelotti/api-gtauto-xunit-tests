using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using apilocadora.Data.Models;
using apilocadora.Repositories;

namespace apilocadora.Services
{
    public class VeiculoService : IVeiculoService
    {
        private readonly IVeiculoRepository _veiculoRepository;
        public VeiculoService(IVeiculoRepository veiculoRepository)
        {
            _veiculoRepository = veiculoRepository;
        }

        public async Task<Veiculo> GetVehicleByIdAsync(Guid idVeiculo)
        {
            var queryVeiculo = await _veiculoRepository.GetVehicleByIdAsync(idVeiculo);

            return queryVeiculo;
        }

        public async Task<IEnumerable<Veiculo>> GetVehiclesAsync(int pagina, int quantidade)
        {
            var queryVeiculos = await _veiculoRepository.GetVehiclesAsync(pagina, quantidade);
            
            return queryVeiculos;
        }

        public async Task<IEnumerable<Veiculo>> GetVehiclesByCategoryAsync(string categoryName, int pagina, int quantidade)
        {
            var queryVeiculos = await _veiculoRepository.GetVehiclesByCategoryAsync(categoryName, pagina, quantidade);
            
            return queryVeiculos;
        }

        public async Task<IEnumerable<Veiculo>> GetVehiclesByModelAsync(string modelName, int pagina, int quantidade)
        {
            var queryVeiculos = await _veiculoRepository.GetVehiclesByModelAsync(modelName, pagina, quantidade);
            
            return queryVeiculos;
        }

        public async Task<Veiculo> GetVehicleByPlateNumberAsync(string plateNumber)
        {
            var queryVeiculo = await _veiculoRepository.GetVehicleByPlateNumberAsync(plateNumber);

            return queryVeiculo;
        }

        public void Dispose()
        {
            _veiculoRepository.Dispose();
        }
    }
}