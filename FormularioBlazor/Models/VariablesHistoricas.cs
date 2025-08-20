using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class VariablesHistoricas
{
    public int IdLiquidacion { get; set; }

    public int IdLegajo { get; set; }

    public DateTime MesLiq { get; set; }

    public string CodVariable { get; set; } = null!;

    public decimal? Valor { get; set; }
}
