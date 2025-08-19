using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vRegistroVacAnuales
{
    public int IdLiquidacion { get; set; }

    public int IdLegajo { get; set; }

    public DateTime MesLiq { get; set; }

    public string Nombre { get; set; } = null!;

    public DateTime? FecBaseAnt { get; set; }

    public int DiasLiq { get; set; }

    public decimal ImporteLiq { get; set; }

    public DateOnly? LicFecDesde { get; set; }

    public DateOnly? LicFecHasta { get; set; }
}
