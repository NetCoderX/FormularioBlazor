using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_AUDITORIA_CONSULTA
{
    public int Id { get; set; }

    public string Maestro { get; set; } = null!;

    public string Detalle { get; set; } = null!;

    public string Campo { get; set; } = null!;
}
