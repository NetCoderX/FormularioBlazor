using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vAUDI_CONCEPTOS_DET2
{
    public int IdConcepto { get; set; }

    public int idLiqtipo { get; set; }

    public string? Liquidación { get; set; }

    public string? Cuenta_Debe { get; set; }

    public string? Cuenta_Haber { get; set; }
}
