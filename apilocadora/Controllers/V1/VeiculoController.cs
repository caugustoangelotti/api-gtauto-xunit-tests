using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using apilocadora.Data.Models;
using apilocadora.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace apilocadora.Controllers.V1
{
    [Authorize]
    [Route("api/v1/veiculos")]
    [ApiController]
    public class VeiculoController : ControllerBase
    {
        private readonly IVeiculoService _veiculoService;
        public VeiculoController(IVeiculoService veiculoService)
        {
            _veiculoService = veiculoService;
        }
        
        /// <summary>
        /// Busca um veiculo pelo id.
        /// </summary>
        /// <param name="idVeiculo">Id do veiculo.</param>
        /// <response code="200">Retorna o veiculo procurado.</response>
        /// <response code="400">Campos requeridos não foram informados</response>
        /// <response code="401">O token de autenticação não foi informado ou é invalido.</response>
        /// <response code="404">Caso não exista um veiculo com esse Id.</response>
        [Authorize]
        [HttpGet]
        [Route("{idVeiculo:Guid}")]
        public async Task<ActionResult<Veiculo>> GetVehicleByIdAsync([FromRoute] Guid idVeiculo)
        {
            var veiculo = await _veiculoService.GetVehicleByIdAsync(idVeiculo);

            if (veiculo == null){
                return NotFound(new {erro = new {message = "Veiculo não encontrado."}});
            }

            return Ok(veiculo);
        }

        /// <summary>
        /// Busca um veiculo pela placa. Ex:(hvh1234, bra2e19)
        /// </summary>
        /// <param name="carPlateNumber">Placa do veiculo.</param>
        /// <response code="200">Retorna o veiculo procurado.</response>
        /// <response code="400">Campos requeridos não foram informados ou não são validos</response>
        /// <response code="401">O token de autenticação não foi informado ou é invalido.</response>
        /// <response code="404">Caso não exista um veiculo com essa placa</response>
        [Authorize]
        [HttpGet]
        [Route("{carPlateNumber}")]
        public async Task<ActionResult<Veiculo>> GetVehicleByPlateNumberAsync([RegularExpression(@"(^[a-zA-Z]{3}[0-9]{4}$|^[a-zA-Z]{3}[0-9]{1}[a-zA-Z]{1}[0-9]{2}$)", 
            ErrorMessage = "A placa informada não é valida."), BindRequired] string carPlateNumber)
        {
            if (!this.ModelState.IsValid){
                return BadRequest(new {erro = new {message = "A placa fornecida é invalida."}});
            }

            var queryVeiculo = await _veiculoService.GetVehicleByPlateNumberAsync(carPlateNumber);

            if (queryVeiculo == null){
                return NotFound(new {erro = new {message = "Veiculo não encontrado."}});
            }

            return Ok(queryVeiculo);
        }

        /// <summary>
        /// Paginação da lista de veiculos.
        /// </summary>
        /// <param name="page">Pagina desejada.</param>
        /// <param name="count">Quantidade de veiculos por pagina.</param>
        /// <response code="200">Retorna uma lista com a quantidade desejada de veiculos.</response>
        /// <response code="401">O token de autenticação não foi informado ou é invalido.</response>
        [Authorize]
        [HttpGet]
        public async Task<ActionResult<List<Veiculo>>> GetVehiclesAsync([FromQuery, Range(1, int.MaxValue)] int page = 1, [FromQuery, Range(1, int.MaxValue)] int count = 5)
        {
            var queryVeiculos = await _veiculoService.GetVehiclesAsync(page, count);

            if (queryVeiculos == null){
                return NotFound(new {erro = new {message = "Veiculos não encontrados."}});
            }

            return Ok(queryVeiculos);
        }

        /// <summary>
        /// Paginação da lista de veiculos por categoria.
        /// </summary>
        /// <param name="categoryName">Categoria dos veiculos. Ex:(Luxo, Economico, Utiliatario).</param>
        /// <param name="page">Pagina desejada.</param>
        /// <param name="count">Quantidade de veiculos por pagina.</param>
        /// <response code="200">Retorna uma lista com a quantidade desejada de veiculos.</response>
        /// <response code="401">O token de autenticação não foi informado ou é invalido.</response>
        [Authorize]
        [HttpGet]
        [Route("categorias")]
        public async Task<ActionResult<List<Veiculo>>> GetVehiclesByCategoryAsync
            ([FromQuery, BindRequired] string categoryName, [FromQuery, Range(1, int.MaxValue)] int page = 1, [FromQuery, Range(1, int.MaxValue)] int count = 5)
        {
            var queryVeiculos = await _veiculoService.GetVehiclesByCategoryAsync(categoryName, page, count);

            if (queryVeiculos == null){
                return NotFound(new {erro = new {message = "Veiculos não encontrados."}});
            }

            return Ok(queryVeiculos);
        }

        /// <summary>
        /// Paginação da lista de veiculos por modelo.
        /// </summary>
        /// <param name="modelName">Modelo dos veiculos.</param>
        /// <param name="page">Pagina desejada.</param>
        /// <param name="count">Quantidade de veiculos por pagina.</param>
        /// <response code="200">Retorna uma lista com a quantidade desejada de veiculos.</response>
        /// <response code="401">O token de autenticação não foi informado ou é invalido.</response>
        
        [Authorize]
        [HttpGet]
        [Route("modelos")]
        public async Task<ActionResult<List<Veiculo>>> GetVehiclesByModelAsync
            ([FromQuery, BindRequired] string modelName, [FromQuery, Range(1, int.MaxValue)] int page = 1, [FromQuery, Range(1, int.MaxValue)] int count = 5)
        {
            var queryVeiculos = await _veiculoService.GetVehiclesByModelAsync(modelName, page, count);

            if (queryVeiculos == null){
                return NotFound(new {erro = new {message = "Veiculos não encontrados."}});
            }

            return Ok(queryVeiculos);
        }
    }
}