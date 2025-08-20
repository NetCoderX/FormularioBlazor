using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class Formatos
{
    public string codFmt { get; set; } = null!;

    public string? Descripcion { get; set; }

    public short CodProg { get; set; }
}
