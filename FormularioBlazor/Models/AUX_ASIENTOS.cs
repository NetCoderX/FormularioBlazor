using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class AUX_ASIENTOS
{
    public DateTime Fecha { get; set; }

    public int IdTalonario { get; set; }

    public DateTime? FechaEval { get; set; }

    public string DescripLiq { get; set; } = null!;

    public DateTime MesLiq { get; set; }

    public int CodEmp { get; set; }

    public int IdLiquidacion { get; set; }

    public int? IdLiqTipo { get; set; }
}
