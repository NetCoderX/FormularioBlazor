using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_GANANCIASANEXO5
{
    public short ANIO { get; set; }

    public byte MES { get; set; }

    public decimal IMPORTE { get; set; }

    public decimal PORCENTAJE { get; set; }

    public byte[] TIMESTAMP { get; set; } = null!;
}
