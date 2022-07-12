﻿using System;
using System.Collections.Generic;

namespace ClaseAcceso
{
    public partial class CheckList
    {
        public int IdCheckList { get; set; }
        public int IdModulo { get; set; }
        public int IdItemCheck { get; set; }
        public bool Mandatorio { get; set; }
        public bool Activo { get; set; }

        public virtual ItemCheck IdItemCheckNavigation { get; set; } = null!;
        public virtual Modulo IdModuloNavigation { get; set; } = null!;
    }
}
