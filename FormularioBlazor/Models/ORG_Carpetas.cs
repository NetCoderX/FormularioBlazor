using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class ORG_Carpetas
{
    public int IdCarpeta { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<ORG_CarpetaCarpeta> ORG_CarpetaCarpetaIdCarpetaHijoNavigation { get; set; } = new List<ORG_CarpetaCarpeta>();

    public virtual ICollection<ORG_CarpetaCarpeta> ORG_CarpetaCarpetaIdCarpetaNavigation { get; set; } = new List<ORG_CarpetaCarpeta>();

    public virtual ICollection<ORG_CarpetaPersona> ORG_CarpetaPersona { get; set; } = new List<ORG_CarpetaPersona>();

    public virtual ICollection<ORG_CarpetaPuesto> ORG_CarpetaPuesto { get; set; } = new List<ORG_CarpetaPuesto>();
}
