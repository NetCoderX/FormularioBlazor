using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_NOVEDADESDOCUMENTOS
{
    public int IdOcurrencia { get; set; }

    public int Secuencia { get; set; }

    public int? IdLegajo { get; set; }

    public string? CodAtr { get; set; }

    public string? CodAtrVal { get; set; }

    public string Titulo { get; set; } = null!;

    public byte[] Texto { get; set; } = null!;

    public string? Extension { get; set; }
}
