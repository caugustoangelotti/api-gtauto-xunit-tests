using System;
using System.Threading.Tasks;
using apilocadora.Data.Models;
using apilocadora.Data.Models.InputModel;
using apilocadora.Services.Security;
using apilocadora.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using apilocadora.Data.Models.ViewModel;

namespace apilocadora.Controllers.V1
{
    [Authorize]
    [Route("api/v1/security")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IJwtAuthManager _authHandler;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public LoginController(IJwtAuthManager tokenHandler, IUserService userService, IMapper mapper)
        {   
            _authHandler = tokenHandler;
            _userService = userService;
            _mapper = mapper;
        }

        /// <summary>
        /// Verifica Informaçõs de login.
        /// </summary>
        /// <response code="200">Retorna token de autenticação do usuario.</response>
        /// <response code="400">Usuario não autenticado, pois algum campo requirido não foi informado.</response>
        /// <response code="401">Acesso negado as credenciais estão incorretas</response>
        /// <response code="404">Acesso negado usuario não encontrado</response>
        [AllowAnonymous]
        [HttpPost]
        [Route("auth")]
        public async Task<ActionResult<UserDTO>> AuthUserAsync([FromBody] Login userInputData)
        {
            User user = await _userService.GetUserByEmailAsync(userInputData.Email);
            if (user == null){
                return NotFound(new {erro = new { message = "Usuario não encontrado."}});
            }
            
            if (!(await _authHandler.AuthAsync(userInputData.Password, user.PasswordHash))){
                return Unauthorized(new {erro = new { message = "Senha incorreta."}});
            }

            var userJwtToken = await _authHandler.GetJwtTokenAsync(new TokenClaims{Email = user.Email});

            user.JwtToken = userJwtToken;    
            
            UserDTO authUserData = _mapper.Map<UserDTO>(user);
            return Ok(authUserData);  
        }

        /// <summary>
        /// Registra Novos usuarios.
        /// </summary>
        /// <response code="200">Novo usuario foi cadastrado e o token foi retornado.</response>
        /// <response code="400">As senhas não conferem, ou algum campo requerido não foi informado</response>
        /// <response code="401">Retornado quando o acesso foi negado pois o login esta incorreto ou usuario já esta cadastrado.</response>
        [AllowAnonymous]
        [HttpPost]
        [Route("register")]
        public async Task<ActionResult<UserDTO>> RegisterUserAsync([FromBody] Register userRegisterData)
        {

            if (!(await _authHandler.ArePasswordsEqualsAsync(userRegisterData.Password, userRegisterData.ConfirmPassword))){
                return BadRequest(new {erro = new { message = "As senhas são diferentes."}});
            }

            User queryUser = await _userService.GetUserByEmailAsync(userRegisterData.Email);

            if (!(queryUser == null)){
                return Unauthorized(new {erro = new { message = "Usuario Já Cadastrado."}});
            }
            
            string newUserPasswordHash = await _authHandler.GetEncryptedPasswordAsync(userRegisterData.Password);
            string newUserJwtToken = await _authHandler.GetJwtTokenAsync(new TokenClaims{Email = userRegisterData.Email});

            User newUser = new User{
                IdUser = Guid.NewGuid(),
                Email = userRegisterData.Email,
                PasswordHash = newUserPasswordHash,
                JwtToken = newUserJwtToken
            };
            
            await _userService.AddUserAsync(newUser);

            UserDTO authUserData = _mapper.Map<UserDTO>(newUser);
            return Ok(authUserData);
        }
    }
}