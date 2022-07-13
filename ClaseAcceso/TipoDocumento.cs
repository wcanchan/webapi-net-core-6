using System;
using System.Collections.Generic;

namespace ClaseAcceso
{
    public partial class TipoDocumento
    {
        public string CodigoTipoDocumento { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? NombreCorto { get; set; }
        public bool Activo { get; set; }
    }
}
