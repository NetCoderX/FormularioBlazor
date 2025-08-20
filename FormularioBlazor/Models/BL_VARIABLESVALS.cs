using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_VARIABLESVALS
{
    public int IdLiquidacion { get; set; }

    public int IdLegajo { get; set; }

    public string CodVariable { get; set; } = null!;

    public decimal Valor { get; set; }

    public virtual BL_LIQUIDACIONES IdLiquidacionNavigation { get; set; } = null!;
}
