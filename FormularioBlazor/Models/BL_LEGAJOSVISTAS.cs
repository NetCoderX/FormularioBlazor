using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_LEGAJOSVISTAS
{
    public int? IdLegajo { get; set; }

    public int IdVista { get; set; }

    public short Dependencia { get; set; }

    public string NombreNodo { get; set; } = null!;

    public short Secuencia { get; set; }

    public virtual BL_VISTAS IdVistaNavigation { get; set; } = null!;
}
