using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RHV_Cancelaciones
{
    public int? IdOcurrencia { get; set; }

    public int? IdPlan { get; set; }

    public int IdPersona { get; set; }

    public string? Tipo { get; set; }

    public int? IdCapEva { get; set; }

    public int? IdObservaciones { get; set; }
}
