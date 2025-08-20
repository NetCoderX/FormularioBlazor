using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_ALIASTIPOLIQ
{
    public string TipoLiq { get; set; } = null!;

    public int AliasLiq { get; set; }

    public string? Descripcion { get; set; }
}
