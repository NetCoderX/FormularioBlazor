using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_RECIBOS_AUDITORIAWEB
{
    public int IdSecuencia { get; set; }

    public int IdLiquidacion { get; set; }

    public int IdLegajo { get; set; }

    public short? IdAccion { get; set; }

    public DateTime Fecha { get; set; }

    public DateTime? Firmado_Fecha { get; set; }

    public string? Observacion { get; set; }
}
