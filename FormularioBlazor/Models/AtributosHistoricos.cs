using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class AtributosHistoricos
{
    public int IdLiquidacion { get; set; }

    public int IdLegajo { get; set; }

    public DateTime MesLiq { get; set; }

    public string CodAtr { get; set; } = null!;

    public string? Descripcion { get; set; }
}
