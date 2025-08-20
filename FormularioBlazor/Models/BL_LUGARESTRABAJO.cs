using System;
using System.Collections.Generic;

namespace Autogestion.Models;

public partial class BL_LUGARESTRABAJO
{
    public int IdLugar { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string PagoLugar { get; set; } = null!;
}
