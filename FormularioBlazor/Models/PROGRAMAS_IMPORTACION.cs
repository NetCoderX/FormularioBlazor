using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class PROGRAMAS_IMPORTACION
{
    public short CODPROG { get; set; }

    public string DESCRIPCION { get; set; } = null!;

    public string PROGRAMA { get; set; } = null!;

    public string? PROGRAMAWEB { get; set; }
}
