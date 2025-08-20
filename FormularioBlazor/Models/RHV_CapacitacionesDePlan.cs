using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RHV_CapacitacionesDePlan
{
    public int? IdCapacitacion { get; set; }

    public string? CodigoCap { get; set; }

    public string? DescripcionCap { get; set; }

    public int IdPlanCap { get; set; }

    public string? Codigo { get; set; }

    public string? Descripcion { get; set; }

    public string? AsistentesPersonas { get; set; }

    public short? CodEmp { get; set; }

    public short? Estado { get; set; }
}
