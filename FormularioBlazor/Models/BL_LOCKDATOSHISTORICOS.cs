using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_LOCKDATOSHISTORICOS
{
    public int IdLiqTipo { get; set; }

    public DateTime MesLiq { get; set; }

    public string ComputerName { get; set; } = null!;

    public short CodEmp { get; set; }

    public int IdLiquidacion { get; set; }
}
