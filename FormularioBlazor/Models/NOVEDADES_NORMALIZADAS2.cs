using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class NOVEDADES_NORMALIZADAS2
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

    public bool AfectaIng { get; set; }

    public bool AfectaAnt { get; set; }

    public bool AfectaInd { get; set; }

    public bool AfectaEgr { get; set; }

    public short CodEmp { get; set; }
}
