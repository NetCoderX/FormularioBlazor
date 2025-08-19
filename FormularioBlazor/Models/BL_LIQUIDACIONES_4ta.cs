using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_LIQUIDACIONES_4ta
{
    public int? IdLiquidacion { get; set; }

    public int IdLegajo { get; set; }

    public decimal? Valor { get; set; }

    public DateTime MesPago { get; set; }

    public string? Codigo4ta { get; set; }

    public int Id4ta { get; set; }

    public string? Descripcion4ta { get; set; }

    public DateTime FechaYHora { get; set; }
}
