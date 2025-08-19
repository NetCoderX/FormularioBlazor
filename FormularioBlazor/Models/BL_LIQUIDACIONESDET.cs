using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_LIQUIDACIONESDET
{
    public int IdLiquidacion { get; set; }

    public short SecLiquidacion { get; set; }

    public int IdLegajo { get; set; }

    public int IdConcepto { get; set; }

    public decimal Importe { get; set; }

    public int? CodCueDeu { get; set; }

    public int? CodCueAcr { get; set; }

    public string? CentroA { get; set; }

    public string? CentroB { get; set; }

    public decimal? Cantidad { get; set; }

    public byte? Auxiliar { get; set; }

    public string? Observacion { get; set; }

    public virtual CUENTAS? CodCueAcrNavigation { get; set; }

    public virtual CUENTAS? CodCueDeuNavigation { get; set; }

    public virtual BL_CONCEPTOS IdConceptoNavigation { get; set; } = null!;

    public virtual BL_LEGAJOS IdLegajoNavigation { get; set; } = null!;

    public virtual BL_LIQUIDACIONES IdLiquidacionNavigation { get; set; } = null!;
}
