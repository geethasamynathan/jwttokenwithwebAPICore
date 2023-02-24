using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebAPIwithIdenity.Models;
using WebAPIwithIdenity.Repository;

namespace WebAPIwithIdenity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository repository;

        public AccountController(IAccountRepository _repository)
        {
            repository = _repository;
        }
        [HttpPost("signup")]
         public async Task<IActionResult> SignUp(Signup signup)
        {
            var result=await repository.SignUpAsync(signup);
            if(result.Succeeded)
            {
                return Ok(result.Succeeded);
            }
            return Unauthorized();
        }

        [HttpPost("login")]
        public async Task<IActionResult> SignIn([FromBody] Login login)
        {
            var result = await repository.LoginAsync(login);
            if (string.IsNullOrEmpty(result))
            {
                return  Unauthorized();
            }
            return Ok(result);
        }
    }
}
