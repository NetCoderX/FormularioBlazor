using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_NovedadesEvaluaciones_AnexoFactores
{
    public int? IdOcurrencia { get; set; }

    public int? IdFormulario { get; set; }

    public int? IdFactor { get; set; }

    public int? IdEscalaValor { get; set; }

    public byte[] TimeStamp { get; set; } = null!;

    public int? IdPersona { get; set; }

    public virtual RH_Factores? IdFactorNavigation { get; set; }

    public virtual RH_Formularios? IdFormularioNavigation { get; set; }

    public virtual BL_PERSONAS? IdPersonaNavigation { get; set; }
}
