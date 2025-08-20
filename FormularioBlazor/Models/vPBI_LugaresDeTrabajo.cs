using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vPBI_LugaresDeTrabajo
{
    public int IdLugar { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string? LugarDeTrabajo { get; set; }
}
