using AutoMapper;
using ClaseAcceso;
using ClaseModelo.Dto.TipoDocumento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseNegocio.Mapping
{
    public class TipoDocumentoProfile: Profile
    {
        public TipoDocumentoProfile()
        {
            CreateMap<TipoDocumento, TipoDocumentoDto>()
                    .ReverseMap();
        }
    }
}
