using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_NOVEDADESSUSPENDIDAS
{
    public int IdSuspension { get; set; }

    public int IdOcurrencia { get; set; }

    public int? IdLegajo { get; set; }

    public DateTime NoLiqFechaDesde { get; set; }

    public DateTime? NoLiqFechaHasta { get; set; }

    public int? IdLiqTipo { get; set; }

    public string Estado { get; set; } = null!;

    public DateTime? FechaReg { get; set; }
}
