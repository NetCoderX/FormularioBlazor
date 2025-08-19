using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vOrgPuestosLegajos
{
    public string CodEmp { get; set; } = null!;

    public int IdPuesto { get; set; }

    public string? NombrePuesto { get; set; }

    public int IdPersona { get; set; }

    public string CodPersona { get; set; } = null!;

    public string NombrePersona { get; set; } = null!;

    public int? IdLegajo { get; set; }

    public string? CodLegajo { get; set; }
}
