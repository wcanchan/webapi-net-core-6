using ClaseModelo.Dto.Ventas;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiResources.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentasController : ControllerBase
    {
        [HttpPost("resumenVenta")]
        public VentaDto obtenerResumen()
        {
            return new VentaDto();
        }
    }
}
