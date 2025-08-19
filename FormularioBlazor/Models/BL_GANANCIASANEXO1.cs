using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_GANANCIASANEXO1
{
    public short ANIO { get; set; }

    public int CODIGO { get; set; }

    public string CONCEPTO { get; set; } = null!;

    public decimal? ENERO { get; set; }

    public decimal? FEBRERO { get; set; }

    public decimal? MARZO { get; set; }

    public decimal? ABRIL { get; set; }

    public decimal? MAYO { get; set; }

    public decimal? JUNIO { get; set; }

    public decimal? JULIO { get; set; }

    public decimal? AGOSTO { get; set; }

    public decimal? SEPTIEMBRE { get; set; }

    public decimal? OCTUBRE { get; set; }

    public decimal? NOVIEMBRE { get; set; }

    public decimal? DICIEMBRE { get; set; }

    public byte[] TIMESTAMP { get; set; } = null!;

    public decimal? ANUAL { get; set; }
}
