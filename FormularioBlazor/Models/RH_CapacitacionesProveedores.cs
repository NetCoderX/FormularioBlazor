using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_CapacitacionesProveedores
{
    public int IdCapacitacion { get; set; }

    public int IdProveedor { get; set; }

    public byte[] TimeStamp { get; set; } = null!;

    public virtual RH_Capacitaciones IdCapacitacionNavigation { get; set; } = null!;

    public virtual RH_Proveedores IdProveedorNavigation { get; set; } = null!;
}
