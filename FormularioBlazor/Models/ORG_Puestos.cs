using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class ORG_Puestos
{
    public int IdPuesto { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<ORG_CarpetaPuesto> ORG_CarpetaPuesto { get; set; } = new List<ORG_CarpetaPuesto>();

    public virtual ICollection<ORG_PuestoPersona> ORG_PuestoPersona { get; set; } = new List<ORG_PuestoPersona>();

    public virtual ICollection<ORG_PuestoPuesto> ORG_PuestoPuestoIdPuestoHijoNavigation { get; set; } = new List<ORG_PuestoPuesto>();

    public virtual ICollection<ORG_PuestoPuesto> ORG_PuestoPuestoIdPuestoNavigation { get; set; } = new List<ORG_PuestoPuesto>();
}
