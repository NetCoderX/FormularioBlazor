using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class AUX_LINASIENTOS
{
    public int Secuencia { get; set; }

    public int CodCue { get; set; }

    public decimal? Debe { get; set; }

    public decimal? Haber { get; set; }

    public string? CentroA { get; set; }

    public string? CentroB { get; set; }

    public int IdLiquidacion { get; set; }
}
