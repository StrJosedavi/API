using Microsoft.AspNetCore.Mvc;

namespace CursoAPI.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserServiceFactory _serviceFactory;
        private UserMapper _mapper;

        public UserController(IUserServiceFactory serviceFactory)
        {
            _serviceFactory = serviceFactory;
            _mapper = new UserMapper();
        }

        /// <summary>
        /// Cria um usuário.
        /// </summary>
        /// <param name="UserRequest">Body da requisição</param>
        /// <returns>Confirmação de uma requisição bem-sucedida</returns>
        /// <response code="200">Confirmação de uma requisição bem-sucedida</response>
        /// <response code="400">Erro de validação encontrada</response>

        [HttpPost("[action]")]
        public IActionResult CreateUser([FromBody] UserRequest userRequest)
        {
            UserRequest userReq = _mapper.Map(userRequest);

            IUserService userService = _serviceFactory.Create();
            UserService userService = userService.Save(userReq);

            Response response = ResponseMapper.Map(true, result);
            return Ok(response);
        }
    }
}