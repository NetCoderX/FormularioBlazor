using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class NOVEDADES_NORMALIZADAS3
{
    public int IdOcurrencia { get; set; }

    public int? IdSuceso { get; set; }

    public DateTime? FecDesde { get; set; }

    public DateTime? FecHasta { get; set; }

    public decimal? Importe { get; set; }

    public int? IdSituacion { get; set; }

    public string Tratamiento { get; set; } = null!;

    public int? IdLegajo { get; set; }

    public string? codAtr { get; set; }

    public string? CodAtrval { get; set; }

    public string? FechaAfectada { get; set; }
}
