using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class FormatosExp
{
    public string codFmt { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string TipoFmt { get; set; } = null!;

    public bool SaltoLinea { get; set; }

    public bool? QuitarBlancos { get; set; }

    public virtual FmtTiposExp TipoFmtNavigation { get; set; } = null!;
}
