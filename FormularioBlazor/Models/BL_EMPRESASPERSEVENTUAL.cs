using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_EMPRESASPERSEVENTUAL
{
    public string CodEmpEventual { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? Domicilio { get; set; }

    public string? CUIT { get; set; }

    public string? CodHab { get; set; }
}
