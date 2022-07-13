using AutoMapper;
using ClaseAcceso;
using ClaseModelo.Dto.TipoDocumento;
using ClaseServicio.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiResources.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoDocumentoController : ControllerBase
    {
        private TipoDocumentoService service;
        public TipoDocumentoController(AcopioDbContext context)
        {
            service = new TipoDocumentoService(context);
        }

        [HttpGet("listado")]
        public Task<IEnumerable<TipoDocumentoDto>> Get()
        {
            return service.list();
        }

    }
}
