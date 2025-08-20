using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_ZONAS
{
    public short Zona { get; set; }

    public string Descripcion { get; set; } = null!;

    public decimal PorReduccion { get; set; }

    public string? CodZona { get; set; }

    public byte EsPatagonica { get; set; }

    public int? IdProvincia { get; set; }
}
