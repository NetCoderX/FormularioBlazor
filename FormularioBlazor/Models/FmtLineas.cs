using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class FmtLineas
{
    public string codFmt { get; set; } = null!;

    public short CodProg { get; set; }

    public string Control { get; set; } = null!;

    public short colInicio { get; set; }

    public short Longitud { get; set; }

    public bool Alias { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual FmtControles FmtControles { get; set; } = null!;

    public virtual Formatos codFmtNavigation { get; set; } = null!;
}
