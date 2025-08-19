using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_LIQUIDACIONESVARS
{
    public int IdLiquidacion { get; set; }

    public int IdLegajo { get; set; }

    public string Parametro { get; set; } = null!;

    public decimal Importe { get; set; }

    public string? Descripcion { get; set; }

    public DateTime MesLiq { get; set; }

    public int IdLiqTipo { get; set; }

    public string CodVariable { get; set; } = null!;
}
