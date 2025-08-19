using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class AlertaTiposEstado
{
    public int IdEstado { get; set; }

    public string Estado { get; set; } = null!;
}
