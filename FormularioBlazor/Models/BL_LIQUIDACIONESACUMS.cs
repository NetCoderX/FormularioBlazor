using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_LIQUIDACIONESACUMS
{
    public int? IdLiquidacion { get; set; }

    public int IdLegajo { get; set; }

    public string? Parametro { get; set; }

    public string? Descripcion { get; set; }

    public int IdAcumulador { get; set; }

    public decimal? Valor { get; set; }

    public DateTime MesLiq { get; set; }

    public int IdLiqTipo { get; set; }
}
