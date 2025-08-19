using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class AU_CODIGOSFORMATOS
{
    public string CodFormato { get; set; } = null!;

    public string? Masters { get; set; }

    public string? Descripcion { get; set; }
}
