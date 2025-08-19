using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_LSD_DET
{
    public int NroLiqAFIP { get; set; }

    public int IdLinea { get; set; }

    public string? TipoReg { get; set; }

    public string? Linea { get; set; }

    public virtual BL_LSD_CAB NroLiqAFIPNavigation { get; set; } = null!;
}
