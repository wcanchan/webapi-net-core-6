using ClaseAcceso;
using ClaseModelo.Dto.TipoDocumento;
using ClaseNegocio.TipoDocumentoBs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseServicio.TipoDocumentoServ
{
    public class TipoDocumentoService
    {
        private readonly AcopioDbContext _context;
        private readonly TipoDocumentoBusiness _business;
        public TipoDocumentoService(AcopioDbContext context) {
            _context = context;
            _business = new TipoDocumentoBusiness();
        }
        public async IEnumerable<TipoDocumentoDto> list()
        {
            IEnumerable<TipoDocumento> readers = await _context.TipoDocumentos.ToListAsync();
            
            return  ;
        }
    }
}
