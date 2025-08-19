using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_PlanesCapacitaciones
{
    public int IdPlanCap { get; set; }

    public int IdResponsable { get; set; }

    public int IdCapacitacion { get; set; }

    public DateTime? FecEstimada { get; set; }

    public int? DuracionEst { get; set; }

    public decimal? CostoEst { get; set; }

    public string? Asistentes { get; set; }

    public string? AsistentesPersonas { get; set; }

    public virtual RH_Capacitaciones IdCapacitacionNavigation { get; set; } = null!;

    public virtual RH_PlanesResponsables RH_PlanesResponsables { get; set; } = null!;
}
