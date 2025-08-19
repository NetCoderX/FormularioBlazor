using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class AU_TIPOS
{
    public int IdTipo { get; set; }

    public string? CodTipo { get; set; }

    public string? Descripcion { get; set; }

    public string? Formato { get; set; }

    public int? Longitud { get; set; }
}
