using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_AUDITORIA_MAESTROS
{
    public int IdMaestro { get; set; }

    public string CodMaestro { get; set; } = null!;

    public string Maestro { get; set; } = null!;
}
