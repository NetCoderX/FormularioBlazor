using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_NOVEDADESEVENTUAL
{
    public int idOcurrencia { get; set; }

    public string CodEmpEventual { get; set; } = null!;

    public int? idLiqTipo { get; set; }

    public DateTime Periodo { get; set; }

    public string Factura { get; set; } = null!;

    public DateTime? FecOcurrencia { get; set; }

    public decimal? TotalFactura { get; set; }

    public short? Quincena { get; set; }

    public string? Observacion { get; set; }
}
