using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class ATRIBUTOS
{
    public string PREFIATR { get; set; } = null!;

    public string CODATR { get; set; } = null!;

    public string? DESCRIPCION { get; set; }

    public int? POSICION { get; set; }

    public int? LARGO { get; set; }

    public byte? SEGURIDAD { get; set; }

    public virtual ICollection<ATRIBUTOSVAL> ATRIBUTOSVAL { get; set; } = new List<ATRIBUTOSVAL>();

    public virtual ICollection<BL_LEGAJOSATRIBUTOS> BL_LEGAJOSATRIBUTOS { get; set; } = new List<BL_LEGAJOSATRIBUTOS>();

    public virtual ICollection<BL_PERSONASATRIBUTOS> BL_PERSONASATRIBUTOS { get; set; } = new List<BL_PERSONASATRIBUTOS>();

    public virtual ICollection<BL_SUCESOS> BL_SUCESOS { get; set; } = new List<BL_SUCESOS>();

    public virtual ICollection<BL_SUCESOSCLASES> BL_SUCESOSCLASES { get; set; } = new List<BL_SUCESOSCLASES>();

    public virtual ICollection<RH_CapacitacionesAtributos> RH_CapacitacionesAtributos { get; set; } = new List<RH_CapacitacionesAtributos>();

    public virtual ICollection<RH_ElementosAtributos> RH_ElementosAtributos { get; set; } = new List<RH_ElementosAtributos>();
}
