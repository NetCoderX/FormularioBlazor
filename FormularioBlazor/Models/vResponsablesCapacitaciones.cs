using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vResponsablesCapacitaciones
{
    public int IdPlanCap { get; set; }

    public string? PlanCap { get; set; }

    public int IdCapacitacion { get; set; }

    public string? Capacitacion { get; set; }

    public int IdResponsable { get; set; }

    public string? ResponsablesPersonas { get; set; }

    public int IdPersona { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public short Empresa { get; set; }
}
