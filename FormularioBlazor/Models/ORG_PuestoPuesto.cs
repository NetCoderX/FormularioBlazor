using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class ORG_PuestoPuesto
{
    public int IdPuesto { get; set; }

    public int IdPuestoHijo { get; set; }

    public int IdEstructura { get; set; }

    public virtual ORG_Estructuras IdEstructuraNavigation { get; set; } = null!;

    public virtual ORG_Puestos IdPuestoHijoNavigation { get; set; } = null!;

    public virtual ORG_Puestos IdPuestoNavigation { get; set; } = null!;
}
