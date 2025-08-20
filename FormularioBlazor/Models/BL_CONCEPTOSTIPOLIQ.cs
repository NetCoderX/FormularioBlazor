using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_CONCEPTOSTIPOLIQ
{
    public int IdConcepto { get; set; }

    public int IdLiqTipo { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public int? CodCueDeu { get; set; }

    public int? CodCueAcr { get; set; }

    public virtual BL_CONCEPTOS IdConceptoNavigation { get; set; } = null!;

    public virtual BL_LIQUIDACIONESTIPOS IdLiqTipoNavigation { get; set; } = null!;
}
