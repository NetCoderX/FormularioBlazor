using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class AtributosValAdic
{
    public string CODATR { get; set; } = null!;

    public string CODATRVAL { get; set; } = null!;

    public string DESCRIPCION { get; set; } = null!;

    public int? DEFECTO { get; set; }
}
