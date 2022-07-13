using System;
using System.Collections.Generic;

namespace ClaseAcceso
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? Nombres { get; set; }
        public int IdTipoDocumento { get; set; }
        public string NroDocumento { get; set; } = null!;
        public int Activo { get; set; }
    }
}
