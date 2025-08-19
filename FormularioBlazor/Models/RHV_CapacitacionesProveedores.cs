using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RHV_CapacitacionesProveedores
{
    public int IdProveedor { get; set; }

    public int? IdCapacitacion { get; set; }

    public string Codigo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public short? CodEmp { get; set; }
}
