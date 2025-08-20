using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_ACUMSASOCIADOS
{
    public int IdConcepto { get; set; }

    public int IdAcumulador { get; set; }

    public short Operacion { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual BL_ACUMULADORES IdAcumuladorNavigation { get; set; } = null!;

    public virtual BL_CONCEPTOS IdConceptoNavigation { get; set; } = null!;
}
