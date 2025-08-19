using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_NOVEDADESPERSONALEVENTUAL
{
    public int idOcurrencia { get; set; }

    public int idPersonalEventual { get; set; }

    public decimal? Importe { get; set; }
}
