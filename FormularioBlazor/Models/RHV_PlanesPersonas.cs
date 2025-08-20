using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RHV_PlanesPersonas
{
    public string Tipo { get; set; } = null!;

    public int IdPlan { get; set; }

    public int? IdEsquemaDePlan { get; set; }

    public string? Codigo { get; set; }

    public string? Descripcion { get; set; }

    public string? AsistentesPersonas { get; set; }

    public short? CodEmp { get; set; }
}
