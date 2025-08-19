using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_PARAMETROS
{
    public string? PARAMETRO { get; set; }

    public string? STRVALOR { get; set; }

    public int? INTVALOR { get; set; }

    public DateTime? DATEVALOR { get; set; }

    public string TIPOVALOR { get; set; } = null!;

    public double? FLOATVALOR { get; set; }

    public bool? RegistrarVarSiEs0 { get; set; }

    public short? CodEmp { get; set; }
}
