using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_PlanesResponsables
{
    public int IdPlanCap { get; set; }

    public int IdResponsable { get; set; }

    public string? Descripcion { get; set; }

    public string? Responsables { get; set; }

    public string? ResponsablesPersonas { get; set; }

    public virtual RH_PlanesDeCapacitacion IdPlanCapNavigation { get; set; } = null!;

    public virtual ICollection<RH_PlanesCapacitaciones> RH_PlanesCapacitaciones { get; set; } = new List<RH_PlanesCapacitaciones>();

    public virtual ICollection<RH_PlanesProveedores> RH_PlanesProveedores { get; set; } = new List<RH_PlanesProveedores>();
}
