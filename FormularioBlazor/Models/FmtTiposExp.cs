using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class FmtTiposExp
{
    public string TipoFmt { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string FromTablas { get; set; } = null!;

    public string Alias { get; set; } = null!;

    public short TiempoEspera { get; set; }

    public virtual ICollection<FmtControlesExp> FmtControlesExp { get; set; } = new List<FmtControlesExp>();

    public virtual ICollection<FormatosExp> FormatosExp { get; set; } = new List<FormatosExp>();
}
