using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class AlertaTipos
{
    public int IdTipoAlerta { get; set; }

    public int IdCategoria { get; set; }

    public string TipoNombre { get; set; } = null!;
}
