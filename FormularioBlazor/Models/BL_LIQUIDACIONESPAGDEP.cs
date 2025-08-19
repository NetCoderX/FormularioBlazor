using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_LIQUIDACIONESPAGDEP
{
    public string? PagoLugar { get; set; }

    public DateTime? PagoFecha { get; set; }

    public string? UltDepBanco { get; set; }

    public DateTime? UltDepMesCorresp { get; set; }

    public DateTime? UltDepFecha { get; set; }

    public string? ReciboTexto { get; set; }

    public int IdLiquidacion { get; set; }
}
