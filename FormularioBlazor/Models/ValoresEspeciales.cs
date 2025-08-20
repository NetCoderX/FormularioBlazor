using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class ValoresEspeciales
{
    public string Tipo { get; set; } = null!;

    public string? Parametro { get; set; }

    public string? Valor { get; set; }

    public int? RegSiEs0 { get; set; }

    public int? IdAcumulador { get; set; }

    public string Descripcion { get; set; } = null!;

    public short? CodEmp { get; set; }

    public string? CodVariable { get; set; }
}
