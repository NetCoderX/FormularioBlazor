using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_NovedadesPersonas
{
    public int IdOcurrencia { get; set; }

    public int IdPersona { get; set; }

    public int? IdObservaciones { get; set; }

    public DateTime? FecInicioCapacitacion { get; set; }

    public DateTime? FecFinCapacitacion { get; set; }

    public byte[] TimeStamp { get; set; } = null!;

    public virtual RTF_Textos? IdObservacionesNavigation { get; set; }

    public virtual BL_PERSONAS IdPersonaNavigation { get; set; } = null!;
}
