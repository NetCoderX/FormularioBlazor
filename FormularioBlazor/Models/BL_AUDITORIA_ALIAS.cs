using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_AUDITORIA_ALIAS
{
    public byte Tabla { get; set; }

    public string Campo { get; set; } = null!;

    public string? Alias { get; set; }
}
