using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_ElementosPuestos
{
    public int IdElemento { get; set; }

    public int IdPuesto { get; set; }

    public int Cantidad { get; set; }

    public byte[] TimeStamp { get; set; } = null!;

    public virtual RH_ElementosDeTrabajo IdElementoNavigation { get; set; } = null!;

    public virtual RH_Puestos IdPuestoNavigation { get; set; } = null!;
}
