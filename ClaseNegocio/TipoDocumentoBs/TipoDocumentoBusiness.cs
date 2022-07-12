using AutoMapper;
using ClaseAcceso;
using ClaseModelo.Dto.TipoDocumento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseNegocio.TipoDocumentoBs
{
    public class TipoDocumentoBusiness
    {
        protected readonly IMapper? _mapper;
        public TipoDocumentoBusiness(IMapper mapper)
        {
            _mapper = mapper;
        }
        public IEnumerable<TipoDocumentoDto> list(IEnumerable<TipoDocumento> tipoDocumentos)
        {
            return _mapper.Map<IEnumerable<TipoDocumentoDto>>(tipoDocumentos);
        }
    }
}
