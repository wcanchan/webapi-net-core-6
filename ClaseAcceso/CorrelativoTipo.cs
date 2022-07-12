﻿using System;
using System.Collections.Generic;

namespace ClaseAcceso
{
    public partial class CorrelativoTipo
    {
        public CorrelativoTipo()
        {
            Correlativos = new HashSet<Correlativo>();
        }

        public string CodigoCorrelativoTipo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public bool Activo { get; set; }

        public virtual ICollection<Correlativo> Correlativos { get; set; }
    }
}
