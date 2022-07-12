﻿using System;
using System.Collections.Generic;

namespace ClaseAcceso
{
    public partial class Muestra
    {
        public int IdMuestra { get; set; }
        public int IdTurno { get; set; }
        public string? UserNameSupervisor { get; set; }
        public DateTimeOffset? FechaMuestreo { get; set; }
        public string CodigoLote { get; set; } = null!;
        public int? IdCancha { get; set; }
        public int IdProveedor { get; set; }
        public int? IdDuenoMuestra { get; set; }
        public bool? LlevaGrueso { get; set; }
        public float Tmh { get; set; }
        public int? IdMuestraCondicion { get; set; }
        public int? IdMuestraEstado { get; set; }
        public string UserNameCreate { get; set; } = null!;
        public DateTimeOffset CreateDate { get; set; }
        public string? UserNameUpdate { get; set; }
        public DateTimeOffset? UpdateDate { get; set; }
        public bool Activo { get; set; }

        public virtual Maestro? IdCanchaNavigation { get; set; }
        public virtual DuenoMuestra? IdDuenoMuestraNavigation { get; set; }
        public virtual Maestro? IdMuestraCondicionNavigation { get; set; }
        public virtual Maestro? IdMuestraEstadoNavigation { get; set; }
        public virtual Proveedor IdProveedorNavigation { get; set; } = null!;
        public virtual Maestro IdTurnoNavigation { get; set; } = null!;
    }
}
