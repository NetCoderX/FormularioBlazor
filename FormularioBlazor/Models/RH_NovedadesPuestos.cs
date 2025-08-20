using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_NovedadesPuestos
{
    public int IdNovPuesto { get; set; }

    public int IdOcurrencia { get; set; }

    public int IdSuceso { get; set; }

    public bool EsEntrada { get; set; }

    public int IdPuesto { get; set; }

    public int IdPersona { get; set; }

    public virtual RH_Novedades IdOcurrenciaNavigation { get; set; } = null!;

    public virtual BL_PERSONAS IdPersonaNavigation { get; set; } = null!;

    public virtual RH_PuestosHistorico IdPuestoNavigation { get; set; } = null!;

    public virtual BL_SUCESOS IdSucesoNavigation { get; set; } = null!;
}
