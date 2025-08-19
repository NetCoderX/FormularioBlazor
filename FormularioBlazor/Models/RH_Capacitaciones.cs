using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_Capacitaciones
{
    public int IdCapacitacion { get; set; }

    public string Codigo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public bool EsExterna { get; set; }

    public short CantidadEtapas { get; set; }

    public string TipoEvidencia { get; set; } = null!;

    public int? IdEvidencia { get; set; }

    public short? CodEmp { get; set; }

    public int? Duracion { get; set; }

    public virtual ICollection<RH_AlternativasCapacitaciones> RH_AlternativasCapacitaciones { get; set; } = new List<RH_AlternativasCapacitaciones>();

    public virtual ICollection<RH_CapacitacionesAtributos> RH_CapacitacionesAtributos { get; set; } = new List<RH_CapacitacionesAtributos>();

    public virtual ICollection<RH_CapacitacionesEvaluaciones> RH_CapacitacionesEvaluaciones { get; set; } = new List<RH_CapacitacionesEvaluaciones>();

    public virtual ICollection<RH_CapacitacionesProveedores> RH_CapacitacionesProveedores { get; set; } = new List<RH_CapacitacionesProveedores>();

    public virtual ICollection<RH_ElementosCapacitaciones> RH_ElementosCapacitaciones { get; set; } = new List<RH_ElementosCapacitaciones>();

    public virtual ICollection<RH_PlanesCapacitaciones> RH_PlanesCapacitaciones { get; set; } = new List<RH_PlanesCapacitaciones>();

    public virtual ICollection<RH_PlanesProveedores> RH_PlanesProveedores { get; set; } = new List<RH_PlanesProveedores>();
}
