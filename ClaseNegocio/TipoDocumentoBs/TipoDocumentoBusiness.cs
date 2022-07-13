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
        public TipoDocumentoBusiness()
        {

        }
        public IEnumerable<TipoDocumentoDto> list(IEnumerable<TipoDocumento> tipoDocumentos)
        {
            List<TipoDocumentoDto> list = new List<TipoDocumentoDto>();
            foreach (var tipoDocumento in tipoDocumentos)
            {
                list.Add(new TipoDocumentoDto(tipoDocumento.CodigoTipoDocumento , tipoDocumento.NombreCorto));
            }
            return list;
         }
    }
}
