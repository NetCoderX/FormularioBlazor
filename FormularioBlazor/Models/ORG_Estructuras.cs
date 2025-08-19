using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class ORG_Estructuras
{
    public int IdEstructura { get; set; }

    public int IdOrganigrama { get; set; }

    public string? Nombre { get; set; }

    public bool EsOrganigrama { get; set; }

    public int? IdRaiz { get; set; }

    public virtual ORG_Principal IdOrganigramaNavigation { get; set; } = null!;

    public virtual ICollection<ORG_CarpetaCarpeta> ORG_CarpetaCarpeta { get; set; } = new List<ORG_CarpetaCarpeta>();

    public virtual ICollection<ORG_CarpetaPersona> ORG_CarpetaPersona { get; set; } = new List<ORG_CarpetaPersona>();

    public virtual ICollection<ORG_CarpetaPuesto> ORG_CarpetaPuesto { get; set; } = new List<ORG_CarpetaPuesto>();

    public virtual ICollection<ORG_PuestoPersona> ORG_PuestoPersona { get; set; } = new List<ORG_PuestoPersona>();

    public virtual ICollection<ORG_PuestoPuesto> ORG_PuestoPuesto { get; set; } = new List<ORG_PuestoPuesto>();
}
