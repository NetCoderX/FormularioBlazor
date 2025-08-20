using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vHabilidadesAlternativas
{
    public int? IdPersona { get; set; }

    public int IdHabilidad { get; set; }

    public string Codigo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public int? IdAlternativa { get; set; }

    public int? IdDocumento { get; set; }

    public int? IdEvaluacion { get; set; }

    public int? IdCapacitacion { get; set; }

    public int? IdOcurrencia { get; set; }
}
