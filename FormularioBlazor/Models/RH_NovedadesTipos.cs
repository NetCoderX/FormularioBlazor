using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class RH_NovedadesTipos
{
    public short IdTipo { get; set; }

    public string? Codigo { get; set; }

    public string? Descripcion { get; set; }

    public string? Grupo { get; set; }
}
