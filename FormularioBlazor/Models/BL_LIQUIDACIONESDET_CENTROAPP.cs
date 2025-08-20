using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_LIQUIDACIONESDET_CENTROAPP
{
    public int IdLiquidacion { get; set; }

    public int IdLegajo { get; set; }

    public int IdConcepto { get; set; }

    public string? CentroA { get; set; }

    public string? CentroB { get; set; }

    public decimal? Importe { get; set; }

    public string TipoProrrateo { get; set; } = null!;

    public decimal? Cantidad { get; set; }

    public virtual BL_LIQUIDACIONESDET BL_LIQUIDACIONESDET { get; set; } = null!;
}
