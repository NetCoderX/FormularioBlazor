using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class vAtributosLeg
{
    public int IDLegajo { get; set; }

    public string CodAtr { get; set; } = null!;

    public string Atributo { get; set; } = null!;

    public string Valor { get; set; } = null!;
}
