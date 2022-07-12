﻿using System;
using System.Collections.Generic;

namespace ClaseAcceso
{
    public partial class DuenoMuestra
    {
        public DuenoMuestra()
        {
            LoteCodigos = new HashSet<LoteCodigo>();
            LoteMuestreos = new HashSet<LoteMuestreo>();
            Muestras = new HashSet<Muestra>();
        }

        public int IdDuenoMuestra { get; set; }
        public string CodigoTipoDocumento { get; set; } = null!;
        public string Numero { get; set; } = null!;
        public string Nombres { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string Email { get; set; } = null!;
        public bool Activo { get; set; }

        public virtual TipoDocumento CodigoTipoDocumentoNavigation { get; set; } = null!;
        public virtual ICollection<LoteCodigo> LoteCodigos { get; set; }
        public virtual ICollection<LoteMuestreo> LoteMuestreos { get; set; }
        public virtual ICollection<Muestra> Muestras { get; set; }
    }
}
