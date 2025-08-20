using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_LIQUIDACIONESATRS
{
    public int IdLiquidacion { get; set; }

    public int IdLegajo { get; set; }

    public string Parametro { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string CodAtr { get; set; } = null!;

    public string? CodAtrVal { get; set; }

    public DateTime MesLiq { get; set; }

    public int IdLiqTipo { get; set; }
}
