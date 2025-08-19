using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_FUNCIONESEXTERNAS
{
    public string CODIGO { get; set; } = null!;

    public string DESCRIPCION { get; set; } = null!;

    public byte TIPO { get; set; }

    public string? PARAMETROS { get; set; }

    public string COMMANDTEXT { get; set; } = null!;

    public byte COMMANDTYPE { get; set; }

    public string? SINTAXIS { get; set; }

    public string TIPOFECHA { get; set; } = null!;
}
