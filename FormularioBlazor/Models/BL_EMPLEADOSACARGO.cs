using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_EMPLEADOSACARGO
{
    public int IdManager { get; set; }

    public int IdLegajo { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual BL_LEGAJOS IdLegajoNavigation { get; set; } = null!;

    public virtual BL_LEGAJOS IdManagerNavigation { get; set; } = null!;
}
