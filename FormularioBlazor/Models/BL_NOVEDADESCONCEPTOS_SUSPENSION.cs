using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_NOVEDADESCONCEPTOS_SUSPENSION
{
    public int IdOcurrencia { get; set; }

    public int IdConcepto { get; set; }

    public byte? Liquidar { get; set; }

    public string? Observacion { get; set; }

    public virtual BL_CONCEPTOS IdConceptoNavigation { get; set; } = null!;

    public virtual BL_NOVEDADES_SUSPENSION IdOcurrenciaNavigation { get; set; } = null!;
}
