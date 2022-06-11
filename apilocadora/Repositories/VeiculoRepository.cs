using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilocadora.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace apilocadora.Repositories
{
    public class VeiculoRepository : IVeiculoRepository
    {
        private readonly AppEfCoreDbContext _context;

        public VeiculoRepository(AppEfCoreDbContext context)
        {
            _context = context;
        }

        public async Task<Veiculo> GetVehicleByIdAsync(Guid idVeiculo)
        {
            var queryVeiculo = await _context.Veiculos
                                .FirstOrDefaultAsync(k => k.IdVeiculo == idVeiculo);

            return queryVeiculo;
        }

        public async Task<IEnumerable<Veiculo>> GetVehiclesAsync(int pagina, int quantidade)
        {
            var queryVeiculos = await _context.Veiculos
                                .Skip((pagina - 1) * quantidade)
                                .Take(quantidade)
                                .ToListAsync();
            return queryVeiculos;
        }

        public async Task<IEnumerable<Veiculo>> GetVehiclesByCategoryAsync(string categoryName, int pagina, int quantidade)
        {
            var queryVeiculos = await _context.Veiculos
                                .Where(q => q.Categoria == categoryName)
                                .Skip((pagina - 1) * quantidade)
                                .Take(quantidade)
                                .ToListAsync();
            return queryVeiculos;
        }

        public async Task<IEnumerable<Veiculo>> GetVehiclesByModelAsync(string modelName, int pagina, int quantidade)
        {
            var queryVeiculos = await _context.Veiculos
                                .Where(q => q.Modelo == modelName)
                                .Skip((pagina - 1) * quantidade)
                                .Take(quantidade)
                                .ToListAsync();
            return queryVeiculos;
        }

        public async Task<Veiculo> GetVehicleByPlateNumberAsync(string plateNumber)
        {
            var queryVeiculo = await _context.Veiculos
                                .FirstOrDefaultAsync(k => k.Placa == plateNumber);
            
            return queryVeiculo;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}