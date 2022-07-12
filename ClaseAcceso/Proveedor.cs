﻿using System;
using System.Collections.Generic;

namespace ClaseAcceso
{
    public partial class Proveedor
    {
        public Proveedor()
        {
            LoteBalanzas = new HashSet<LoteBalanza>();
            LoteMuestreos = new HashSet<LoteMuestreo>();
            Muestras = new HashSet<Muestra>();
            ProveedorConcesions = new HashSet<ProveedorConcesion>();
        }

        public int IdProveedor { get; set; }
        public string Ruc { get; set; } = null!;
        public string RazonSocial { get; set; } = null!;
        public string? CodigoUbigeo { get; set; }
        public string Direccion { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string Email { get; set; } = null!;
        public bool Activo { get; set; }

        public virtual Ubigeo? CodigoUbigeoNavigation { get; set; }
        public virtual ICollection<LoteBalanza> LoteBalanzas { get; set; }
        public virtual ICollection<LoteMuestreo> LoteMuestreos { get; set; }
        public virtual ICollection<Muestra> Muestras { get; set; }
        public virtual ICollection<ProveedorConcesion> ProveedorConcesions { get; set; }
    }
}
