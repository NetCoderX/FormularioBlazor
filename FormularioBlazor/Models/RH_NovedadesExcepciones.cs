using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_NovedadesExcepciones
{
    public int? IdOcurrencia { get; set; }

    public int? IdHabilidad { get; set; }

    public int? IdResponsable { get; set; }

    public byte[] TimeStamp { get; set; } = null!;

    public int? IdPersona { get; set; }

    public virtual RH_Habilidades? IdHabilidadNavigation { get; set; }

    public virtual BL_PERSONAS? IdPersonaNavigation { get; set; }
}
