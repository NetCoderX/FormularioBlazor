using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_VARIABLESGANANCIAS
{
    public int IdVariable { get; set; }

    public string CodVariable { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string? TipoAcum { get; set; }
}
