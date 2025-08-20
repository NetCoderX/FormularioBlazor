using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_GANANCIASANEXO2_CEDULAR
{
    public short ANIO { get; set; }

    public byte MES { get; set; }

    public decimal IMPORTE { get; set; }

    public decimal ACUMULADO { get; set; }

    public decimal PORCENTAJE { get; set; }

    public byte[] TIMESTAMP { get; set; } = null!;

    public int? ValorAFIP { get; set; }
}
