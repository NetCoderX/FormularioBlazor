using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vOrdenNovedades
{
    public int IdTransaccion { get; set; }

    public int IdOcurrencia { get; set; }

    public int? IdLiqTipo { get; set; }

    public DateTime? FechaDesde { get; set; }

    public DateTime? FechaHasta { get; set; }

    public short CodEmp { get; set; }
}
