using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class FmtControlesAlias
{
    public short CodProg { get; set; }

    public string CodFmt { get; set; } = null!;

    public string Control { get; set; } = null!;

    public string Valor { get; set; } = null!;

    public string Alias { get; set; } = null!;
}
