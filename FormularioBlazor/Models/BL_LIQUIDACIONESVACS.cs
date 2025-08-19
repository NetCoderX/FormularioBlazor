using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_LIQUIDACIONESVACS
{
    public int IdLiquidacion { get; set; }

    public int IdLegajo { get; set; }

    public int IdOcurrencia { get; set; }

    public int DiasLiq { get; set; }

    public decimal ImporteLiq { get; set; }

    public DateOnly? LicFecDesde { get; set; }

    public DateOnly? LicFecHasta { get; set; }
}
