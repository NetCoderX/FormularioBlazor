using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_Proveedores
{
    public int IdProveedor { get; set; }

    public string Codigo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public string? Contacto { get; set; }

    public short? CodEmp { get; set; }

    public virtual ICollection<RH_CapacitacionesProveedores> RH_CapacitacionesProveedores { get; set; } = new List<RH_CapacitacionesProveedores>();
}
