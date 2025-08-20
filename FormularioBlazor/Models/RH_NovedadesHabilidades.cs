using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_NovedadesHabilidades
{
    public int IdOcurrencia { get; set; }

    public int IdHabilidad { get; set; }

    public byte[] TimeStamp { get; set; } = null!;

    public virtual RH_Habilidades IdHabilidadNavigation { get; set; } = null!;
}
