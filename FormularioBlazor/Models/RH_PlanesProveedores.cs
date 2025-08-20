using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_PlanesProveedores
{
    public int IdPlanCap { get; set; }

    public int IdResponsable { get; set; }

    public int IdCapacitacion { get; set; }

    public int IdProveedor { get; set; }

    public byte[] TimeStamp { get; set; } = null!;

    public virtual RH_Capacitaciones IdCapacitacionNavigation { get; set; } = null!;

    public virtual RH_PlanesResponsables RH_PlanesResponsables { get; set; } = null!;
}
