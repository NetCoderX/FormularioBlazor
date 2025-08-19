using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class GETATRIBUTOS
{
    public string codatr { get; set; } = null!;

    public string prefiatr { get; set; } = null!;

    public string descripcion { get; set; } = null!;

    public int? posicion { get; set; }

    public int? largo { get; set; }

    public short? codemp { get; set; }
}
