using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vPBI_CentrosB
{
    public int IdCentroAp { get; set; }

    public string CenPrefi { get; set; } = null!;

    public string CodCen { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string CentroAx { get; set; } = null!;

    public string CentroDesc { get; set; } = null!;
}
