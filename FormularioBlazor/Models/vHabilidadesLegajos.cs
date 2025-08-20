using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vHabilidadesLegajos
{
    public int? IdPersona { get; set; }

    public int IdHabilidad { get; set; }

    public string Codigo { get; set; } = null!;

    public string? Descripcion { get; set; }
}
