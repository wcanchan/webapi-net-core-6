using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseModelo.Dto.TipoDocumento
{
    public class TipoDocumentoDto
    {
        public TipoDocumentoDto(string codigoTipoDocumento, string nombreCorto)
        {
            CodigoTipoDocumento = codigoTipoDocumento;
            NombreCorto = nombreCorto;
        }
        public string CodigoTipoDocumento { get; set; } = null!;
        public string? NombreCorto { get; set; }
    }
}
