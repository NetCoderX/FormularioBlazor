using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class ATRIBUTOSVAL
{
    public string CODATR { get; set; } = null!;

    public string CODATRVAL { get; set; } = null!;

    public string DESCRIPCION { get; set; } = null!;

    public byte[]? TIMESTAMP { get; set; }

    public byte? DEFECTO { get; set; }

    public virtual ICollection<BL_LEGAJOSATRIBUTOS> BL_LEGAJOSATRIBUTOS { get; set; } = new List<BL_LEGAJOSATRIBUTOS>();

    public virtual ICollection<BL_PERSONASATRIBUTOS> BL_PERSONASATRIBUTOS { get; set; } = new List<BL_PERSONASATRIBUTOS>();

    public virtual ICollection<BL_SECURITY_SETEO> BL_SECURITY_SETEO { get; set; } = new List<BL_SECURITY_SETEO>();

    public virtual ATRIBUTOS CODATRNavigation { get; set; } = null!;

    public virtual ICollection<RH_CapacitacionesAtributos> RH_CapacitacionesAtributos { get; set; } = new List<RH_CapacitacionesAtributos>();

    public virtual ICollection<RH_ElementosAtributos> RH_ElementosAtributos { get; set; } = new List<RH_ElementosAtributos>();
}
