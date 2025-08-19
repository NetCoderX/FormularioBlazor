using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class FmtJoinsExp
{
    public string TipoFmt { get; set; } = null!;

    public int CodJoin { get; set; }

    public string? TextJoin { get; set; }

    public virtual FmtTiposExp TipoFmtNavigation { get; set; } = null!;
}
