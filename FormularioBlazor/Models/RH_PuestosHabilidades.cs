using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_PuestosHabilidades
{
    public int IdPuesto { get; set; }

    public int IdHabilidad { get; set; }

    public bool? Imprescindible { get; set; }

    public byte[] TimeStamp { get; set; } = null!;

    public virtual RH_Habilidades IdHabilidadNavigation { get; set; } = null!;

    public virtual RH_Puestos IdPuestoNavigation { get; set; } = null!;
}
