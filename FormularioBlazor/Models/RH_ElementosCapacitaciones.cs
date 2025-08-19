using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_ElementosCapacitaciones
{
    public int IdElemento { get; set; }

    public int IdCapacitacion { get; set; }

    public bool Obligatoria { get; set; }

    public byte[] TimeStamp { get; set; } = null!;

    public virtual RH_Capacitaciones IdCapacitacionNavigation { get; set; } = null!;

    public virtual RH_ElementosDeTrabajo IdElementoNavigation { get; set; } = null!;
}
