using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class AcumuladoresHistoricos
{
    public int? IdLiquidacion { get; set; }

    public int IdLegajo { get; set; }

    public DateTime MesLiq { get; set; }

    public int IdAcumulador { get; set; }

    public decimal? Valor { get; set; }
}
