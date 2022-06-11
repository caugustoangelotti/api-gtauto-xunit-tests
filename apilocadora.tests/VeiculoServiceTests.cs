using System;
using System.Threading.Tasks;
using apilocadora.Data.Models;
using apilocadora.Repositories;
using apilocadora.Services;
using FluentAssertions;
using Moq;
using Xunit;

namespace apilocadora.tests
{
    public class VeiculoServiceTests
    {
        private readonly VeiculoService _sut;
        private readonly Mock<IVeiculoRepository> _veiculoRepository;

        public VeiculoServiceTests()
        {
            _veiculoRepository = new Mock<IVeiculoRepository>();
            _sut = new VeiculoService(_veiculoRepository.Object);
        }

        [Fact]
        public async Task GetVehicleByIdAsync_WithUnexistentId_ReturnsNull()
        {
            _veiculoRepository.Setup(repo => repo.GetVehicleByIdAsync(It.IsAny<Guid>()))
                .ReturnsAsync((Veiculo)null);
            
            var actionResult = await _sut.GetVehicleByIdAsync(Guid.NewGuid());

            actionResult.Should().BeNull("Because vehicle is not in database");
        }

        [Fact]
        public async Task GetVehicleByIdAsync_WithExistentId_ReturnsExpectedVehicle()
        {
            Veiculo expectedVehicle = new Veiculo{
                IdVeiculo = Guid.NewGuid(),
                Categoria = "luxo",
                Modelo = "ferrari",
                Placa = "obj1654"
            };

            _veiculoRepository.Setup(repo => repo.GetVehicleByIdAsync(It.IsAny<Guid>()))
                .ReturnsAsync(expectedVehicle);
            
            var actionResult = await _sut.GetVehicleByIdAsync(It.IsAny<Guid>());

            actionResult.Should().NotBeNull();
            actionResult.Should().BeEquivalentTo(
                expectedVehicle,
                options => options.ComparingByMembers<Veiculo>());
        }

        [Fact]
        public async Task GetVehicleByIdAsync_ShouldBeCalledOnce()
        {
            _veiculoRepository.Setup(repo => repo.GetVehicleByIdAsync(It.IsAny<Guid>()))
                .ReturnsAsync((Veiculo)null);
            
            var actionResult = await _sut.GetVehicleByIdAsync(It.IsAny<Guid>());

            _veiculoRepository.Verify(x => x.GetVehicleByIdAsync(It.IsAny<Guid>()), Times.Exactly(1));
        }
    }
}