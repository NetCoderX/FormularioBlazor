using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vTodasLasVariables
{
    public int? Id { get; set; }

    public string? Codigo { get; set; }

    public string? Descripcion { get; set; }

    public string Eliminado { get; set; } = null!;
}
