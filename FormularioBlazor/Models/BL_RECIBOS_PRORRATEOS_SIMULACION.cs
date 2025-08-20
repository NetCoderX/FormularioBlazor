using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_RECIBOS_PRORRATEOS_SIMULACION
{
    public int IdLiquidacion { get; set; }

    public int IdLegajo { get; set; }

    public DateTime Mes { get; set; }

    public int IdConcepto { get; set; }

    public decimal? Importe { get; set; }

    public decimal ImporteGan { get; set; }
}
