using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class Evidencias
{
    public string TipoEvidencia { get; set; } = null!;

    public int? IdOcurrencia { get; set; }

    public int? IdCapacitacion { get; set; }

    public int? IdPersona { get; set; }

    public int? IdEvidencia { get; set; }
}
