﻿using System;
using System.Collections.Generic;

namespace ClaseAcceso
{
    public partial class LoteBalanza
    {
        public LoteBalanza()
        {
            LoteCodigos = new HashSet<LoteCodigo>();
            Tickets = new HashSet<Ticket>();
        }

        public int IdLoteBalanza { get; set; }
        public string CodigoLote { get; set; } = null!;
        public int IdConcesion { get; set; }
        public int IdProveedor { get; set; }
        public DateTimeOffset FechaIngreso { get; set; }
        public DateTimeOffset? FechaAcopio { get; set; }
        public int IdEstadoTipoMaterial { get; set; }
        public string CantidadSacos { get; set; } = null!;
        public float Tmh100 { get; set; }
        public float TmhBase { get; set; }
        public float Tmh { get; set; }
        public int IdEstado { get; set; }
        public string Observacion { get; set; } = null!;
        public int PorcentajeCheckList { get; set; }
        public string UserNameCreate { get; set; } = null!;
        public DateTimeOffset CreateDate { get; set; }
        public string? UserNameUpdate { get; set; }
        public DateTimeOffset? UpdateDate { get; set; }
        public bool Activo { get; set; }

        public virtual Concesion IdConcesionNavigation { get; set; } = null!;
        public virtual Maestro IdEstadoNavigation { get; set; } = null!;
        public virtual Maestro IdEstadoTipoMaterialNavigation { get; set; } = null!;
        public virtual Proveedor IdProveedorNavigation { get; set; } = null!;
        public virtual ICollection<LoteCodigo> LoteCodigos { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
