using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class FmtControles
{
    public short CodProg { get; set; }

    public string Control { get; set; } = null!;

    public string Titulo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public byte Obligatoria { get; set; }

    public byte EsClave { get; set; }
}
