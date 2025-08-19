using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_NovedadesCancelaciones
{
    public int? IdOcurrencia { get; set; }

    public int? IdPlan { get; set; }

    public int? IdObservaciones { get; set; }

    public byte[] TimeStamp { get; set; } = null!;

    public int IdPersona { get; set; }

    public virtual RTF_Textos? IdObservacionesNavigation { get; set; }

    public virtual BL_PERSONAS IdPersonaNavigation { get; set; } = null!;
}
