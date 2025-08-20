using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_LEGAJOSVACS
{
    public int IdLegajo { get; set; }

    public short Anio { get; set; }

    public decimal? DiasAcr { get; set; }

    public decimal? DiasAsig { get; set; }

    public decimal? DiasGozados { get; set; }

    public decimal? DiasLiq { get; set; }

    public DateTime? FecCalculo { get; set; }

    public virtual BL_LEGAJOS IdLegajoNavigation { get; set; } = null!;
}
