using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class VISTAATRIBUTOSEMP
{
    public string PREFIATR { get; set; } = null!;

    public string CODATR { get; set; } = null!;

    public string DESCRIPCION { get; set; } = null!;

    public int? POSICION { get; set; }

    public int? LARGO { get; set; }

    public byte? SEGURIDAD { get; set; }

    public short codemp { get; set; }
}
