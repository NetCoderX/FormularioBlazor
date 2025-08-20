using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_FERIADOS_DETALLE
{
    public short ANIO { get; set; }

    public DateTime FECHA { get; set; }

    public string? DESCRIPCION { get; set; }

    public byte[] TIMESTAMP { get; set; } = null!;

    public virtual BL_FERIADOS ANIONavigation { get; set; } = null!;
}
