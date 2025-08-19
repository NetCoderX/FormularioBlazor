using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class ORG_CarpetaCarpeta
{
    public int IdCarpeta { get; set; }

    public int IdCarpetaHijo { get; set; }

    public int IdEstructura { get; set; }

    public virtual ORG_Carpetas IdCarpetaHijoNavigation { get; set; } = null!;

    public virtual ORG_Carpetas IdCarpetaNavigation { get; set; } = null!;

    public virtual ORG_Estructuras IdEstructuraNavigation { get; set; } = null!;
}
