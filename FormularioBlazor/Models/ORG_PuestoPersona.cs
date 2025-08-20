using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class ORG_PuestoPersona
{
    public int IdPuesto { get; set; }

    public int IdPersonaHijo { get; set; }

    public int IdEstructura { get; set; }

    public virtual ORG_Estructuras IdEstructuraNavigation { get; set; } = null!;

    public virtual BL_PERSONAS IdPersonaHijoNavigation { get; set; } = null!;

    public virtual ORG_Puestos IdPuestoNavigation { get; set; } = null!;
}
