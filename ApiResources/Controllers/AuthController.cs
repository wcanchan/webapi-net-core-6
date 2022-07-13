using ClaseAcceso;
using ClaseModelo.Dto.Login;
using ClaseServicio.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiResources.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private AuthService service;

        public AuthController(AcopioDbContext context)
        {
            service = new AuthService(context);
        }

        [HttpPost("login")]
        public LoginDto login([FromBody] LoginBodyDto value)
        {
            return service.login(value);
        }
    }
}
