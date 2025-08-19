using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_LIQUIDACIONESDET_SIMULACION
{
    public int IdLiquidacion { get; set; }

    public short SecLiquidacion { get; set; }

    public int IdLegajo { get; set; }

    public int IdConcepto { get; set; }

    public decimal Importe { get; set; }

    public int? CodCueDeu { get; set; }

    public int? CodCueAcr { get; set; }

    public string? CentroA { get; set; }

    public string? CentroB { get; set; }

    public decimal? Cantidad { get; set; }

    public byte? Auxiliar { get; set; }

    public string? Observacion { get; set; }
}
