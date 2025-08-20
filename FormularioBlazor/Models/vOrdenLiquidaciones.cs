using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vOrdenLiquidaciones
{
    public int IdTransaccion { get; set; }

    public int IdLiquidacion { get; set; }

    public int IdLegajo { get; set; }

    public int IdLiqTipo { get; set; }

    public DateTime FechaDesde { get; set; }

    public DateTime FechaHasta { get; set; }

    public short CodEmp { get; set; }
}
